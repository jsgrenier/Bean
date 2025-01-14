﻿Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Newtonsoft.Json.Linq

Public Class SendForm
    Private _privateKey As String
    Private _apiClient As New APIClient()

    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey

        UpdateTokensOwnedAsync() ' Call the async version
    End Sub

    Private Async Sub UpdateTokensOwnedAsync() ' Make this method async
        Try
            Dim encodedAddress As String = WebUtility.UrlEncode(WalletHandler.GetPublicKeyFromPrivateKey(_privateKey))

            ' Use the async GettAsync method
            Dim jsonObject As JObject = Await _apiClient.GettAsync("/get_tokens_owned", New Dictionary(Of String, String) From {{"address", encodedAddress}})
            Dim tokensOwned As JObject = jsonObject("tokensOwned")

            CBTokens.Items.Clear()

            ' Use the async GettAsync method
            Dim tokenNamesToken As JToken = Await _apiClient.GettAsync("/get_token_names")
            Dim tokenNameDict As Dictionary(Of String, String) = tokenNamesToken.ToObject(Of JArray)() _
                .ToDictionary(Function(t) t("symbol").ToString(), Function(t) t("name").ToString())

            Dim sortedTokens = tokensOwned.Properties().OrderBy(Function(p) p.Name)
            For Each token In sortedTokens
                Dim tokenName As String = If(tokenNameDict.ContainsKey(token.Name), tokenNameDict(token.Name), token.Name)
                Dim amount As Decimal = token.Value.ToObject(Of Decimal)()
                CBTokens.Items.Add($"{tokenName} ({token.Name}) - {amount.ToString("#,0.########")}")
            Next
            If CBTokens.Items.Count > 0 Then CBTokens.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show($"Error loading tokens: {ex.Message}")
        End Try
    End Sub

    Private Async Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click ' Make this method async
        Dim fromPrivateKey As String = _privateKey
        Dim fromPublicKey As String = WalletHandler.GetPublicKeyFromPrivateKey(_privateKey)
        Dim toPublicKey As String = TBRecipient.Text
        Dim amount As String = TBAmount.Text
        Dim inputForm As New ConfirmationDialog()

        If String.IsNullOrWhiteSpace(fromPublicKey) OrElse
           String.IsNullOrWhiteSpace(toPublicKey) OrElse
           String.IsNullOrWhiteSpace(amount) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        Dim amountDecimal As Decimal
        If Not Decimal.TryParse(amount.Replace("(", "").Replace(")", "").Replace(",", ""), amountDecimal) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        If inputForm.ShowDialog() = DialogResult.OK Then
            Try
                ' Use the async IsConnectionFunctionalAsync method
                If Await _apiClient.IsConnectionFunctionalAsync() Then
                    Dim selectedItem = CBTokens.SelectedItem.ToString()
                    Dim tokenSymbol As String = Regex.Match(selectedItem, "\(([^)]*)\)").Groups(1).Value

                    Dim transactionData As String = $"{fromPublicKey}:{toPublicKey}:{amountDecimal}:{tokenSymbol}"
                    Dim signature As String = WalletHandler.SignTransaction(_privateKey, transactionData)

                    LoadingControl1.Start()
                    BtnSend.Visible = False
                    LoadingControl1.Visible = True

                    Try
                        ' Use the async TransferTokensAsync method and await the result
                        Dim response As JObject = Await _apiClient.TransferTokensAsync(fromPublicKey, toPublicKey, amountDecimal, tokenSymbol, signature)

                        LoadingControl1.Visible = False
                        Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
                        _mainMenu.OpenContentPanel(New ConfirmationForm(response("message"), response("txId").ToString()))

                    Catch ex As Exception
                        LoadingControl1.Visible = False
                        LabelError.ForeColor = Color.Red
                        LabelError.Text = ex.Message
                        LoadingControl1.Stop()
                        LoadingControl1.Visible = False
                        BtnSend.Visible = True
                    End Try

                Else
                    MessageBox.Show("Blockchain is not reachable. Please check the connection")
                End If

            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub TBAmount_TextChanged(sender As Object, e As EventArgs) Handles TBAmount.TextChanged
        Try
            Dim caretPosition As Integer = TBAmount.SelectionStart

            Dim value As String = TBAmount.Text.Replace("(", "").Replace(")", "").Replace(",", "")

            If Decimal.TryParse(value, Nothing) Then
                TBAmount.Text = String.Format("{0:#,0.########}", Decimal.Parse(value))

                Dim newCaretPosition As Integer = caretPosition + (TBAmount.Text.Length - value.Length)
                TBAmount.SelectionStart = Math.Max(0, newCaretPosition)
                TBAmount.SelectionLength = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid input.")
        End Try

    End Sub

    Private Sub TBAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles TBAmount.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            e.SuppressKeyPress = True ' Suppress the paste operation
        End If
    End Sub
End Class