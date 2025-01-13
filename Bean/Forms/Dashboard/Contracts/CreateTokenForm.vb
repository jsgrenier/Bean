Imports System.Threading
Imports Guna.UI2.WinForms
Imports Newtonsoft.Json.Linq

Public Class CreateTokenForm
    Private _apiClient As New APIClient()
    Private _privateKey As String
    Private _focusedTB As String
    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey
        ' Add any initialization after the InitializeComponent() call.
        TBOwnerAddress.Text = WalletHandler.GetPublicKeyFromPrivateKey(privatekey)
    End Sub

    Private Async Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim tokenName As String = TBTokenName.Text
        Dim tokenSymbol As String = TBTokenSymbol.Text
        Dim amount As String = TBSupply.Text
        Dim ownerAddress As String = TBOwnerAddress.Text
        Dim inputForm As New ConfirmationDialog()

        If String.IsNullOrWhiteSpace(tokenName) OrElse
           String.IsNullOrWhiteSpace(tokenSymbol) OrElse
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
                ' Check if the API is reachable using the async method
                If Await _apiClient.IsConnectionFunctionalAsync() Then
                    Dim dataToSign As String = $"{tokenName}:{tokenSymbol}:{amountDecimal}:{ownerAddress}"
                    Dim signature As String = WalletHandler.SignTransaction(_privateKey, dataToSign)

                    LoadingControl1.Start()
                    BtnCreate.Visible = False
                    LoadingControl1.Visible = True

                    Try
                        ' Call CreateTokenAsync and await the result
                        Dim response As JObject = Await _apiClient.CreateTokenAsync(TBTokenName.Text, TBTokenSymbol.Text, TBSupply.Text, TBOwnerAddress.Text, signature)

                        LoadingControl1.Visible = False
                        Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
                        _mainMenu.OpenContentPanel(New ConfirmationForm(response("message"), response("txId").ToString()))

                    Catch ex As Exception
                        LoadingControl1.Visible = False
                        LabelError.ForeColor = Color.Red
                        LabelError.Text = ex.Message
                        LoadingControl1.Stop()
                        LoadingControl1.Visible = False
                        BtnCreate.Visible = True
                    End Try

                Else
                    MessageBox.Show("Blockchain is not reachable. Please check the connection.")
                End If

            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub TBSupply_TextChanged(sender As Object, e As EventArgs) Handles TBSupply.TextChanged
        Try
            Dim caretPosition As Integer = TBSupply.SelectionStart

            Dim value As String = TBSupply.Text.Replace("(", "").Replace(")", "").Replace(",", "")

            If Decimal.TryParse(value, Nothing) Then
                TBSupply.Text = String.Format("{0:#,0}", Decimal.Parse(value))

                Dim newCaretPosition As Integer = caretPosition + (TBSupply.Text.Length - value.Length)
                TBSupply.SelectionStart = Math.Max(0, newCaretPosition)
                TBSupply.SelectionLength = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid input.")
        End Try
    End Sub

    Private Sub TBSupply_KeyDown(sender As Object, e As KeyEventArgs) Handles TBTokenSymbol.KeyDown, TBTokenName.KeyDown, TBSupply.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            e.SuppressKeyPress = True ' Suppress the paste operation
        End If
    End Sub
End Class