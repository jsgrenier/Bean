Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Newtonsoft.Json.Linq

Public Class SendForm
    Private _privateKey As String
    Private _apiClient As New APIClient()

    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey

        UpdateTokensOwned()
    End Sub

    Private Sub UpdateTokensOwned()
        Try
            ' Fetch tokens owned via the API
            Dim encodedAddress As String = WebUtility.UrlEncode(WalletHandler.GetPublicKeyFromPrivateKey(_privateKey))
            Dim jsonObject As JObject = _apiClient.Gett("/get_tokens_owned", New Dictionary(Of String, String) From {{"address", encodedAddress}})
            Dim tokensOwned As JObject = jsonObject("tokensOwned")

            CBTokens.Items.Clear()
            ' Fetch token names from the API
            Dim tokenNamesToken As JToken = _apiClient.Gett("/get_token_names")
            Dim tokenNameDict As Dictionary(Of String, String) = tokenNamesToken.ToObject(Of JArray)() _
                .ToDictionary(Function(t) t("symbol").ToString(), Function(t) t("name").ToString())

            ' Sort tokens and populate the combobox
            Dim sortedTokens = tokensOwned.Properties().OrderBy(Function(p) p.Name)
            For Each token In sortedTokens
                ' Get the token name from the dictionary, or fallback to the symbol
                Dim tokenName As String = If(tokenNameDict.ContainsKey(token.Name), tokenNameDict(token.Name), token.Name)
                Dim amount As Decimal = token.Value.ToObject(Of Decimal)()
                CBTokens.Items.Add($"{tokenName} ({token.Name}) - {amount}")
            Next
            If CBTokens.Items.Count > 0 Then CBTokens.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show($"Error loading tokens: {ex.Message}")
        End Try
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click


        Dim fromPrivateKey As String = _privateKey
        Dim fromPublicKey As String = WalletHandler.GetPublicKeyFromPrivateKey(_privateKey)
        Dim toPublicKey As String = TBRecipient.Text
        Dim amount As String = TBAmount.Text ' Keep amount as string for validation
        Dim inputForm As New ConfirmationDialog()

        ' Validate input fields
        If String.IsNullOrWhiteSpace(fromPublicKey) OrElse
                   String.IsNullOrWhiteSpace(toPublicKey) OrElse
                   String.IsNullOrWhiteSpace(amount) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        ' Convert amount to decimal after validation
        Dim amountDecimal As Decimal
        If Not Decimal.TryParse(amount, amountDecimal) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        If inputForm.ShowDialog() = DialogResult.OK Then
            Try
                If _apiClient.IsConnectionFunctional() Then
                    ' Get input values


                    ' Extract token symbol from combobox selection
                    Dim selectedItem = CBTokens.SelectedItem.ToString()
                    Dim tokenSymbol As String = Regex.Match(selectedItem, "\(([^)]*)\)").Groups(1).Value
                    Console.WriteLine(tokenSymbol)
                    Console.WriteLine(amount)



                    ' Construct the transaction data string (same format as server-side)
                    Dim transactionData As String = $"{fromPublicKey}:{toPublicKey}:{amount}:{tokenSymbol}"

                    ' Sign the transaction data using the user's private key
                    Dim signature As String = WalletHandler.SignTransaction(_privateKey, transactionData)
                    LoadingControl1.Start()
                    BtnSend.Visible = False
                    LoadingControl1.Visible = True

                    ' Start a new thread for the API call
                    Dim thread As New Thread(Sub()
                                                 Try
                                                     ' Send transfer request to the API
                                                     Dim response As JObject = _apiClient.TransferTokens(fromPublicKey, toPublicKey, amount, tokenSymbol, signature)

                                                     ' Update UI on the main thread
                                                     Me.Invoke(Sub()
                                                                   LoadingControl1.Visible = False
                                                                   Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
                                                                   _mainMenu.OpenContentPanel(New ConfirmationForm(response("message"), response("txId").ToString()))
                                                               End Sub)
                                                 Catch ex As Exception
                                                     ' Update UI on the main thread
                                                     Me.Invoke(Sub()
                                                                   LoadingControl1.Visible = False
                                                                   LabelError.ForeColor = Color.Red
                                                                   LabelError.Text = ex.Message
                                                                   LoadingControl1.Stop()
                                                                   LoadingControl1.Visible = False
                                                                   BtnSend.Visible = True
                                                               End Sub)
                                                 End Try
                                             End Sub)
                    thread.Start()

                Else
                    MessageBox.Show("Blockchain is not reachable. Please check the connection")
                End If
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
    End Sub
End Class