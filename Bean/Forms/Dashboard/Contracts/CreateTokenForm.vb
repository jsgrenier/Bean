Imports System.Threading
Imports Newtonsoft.Json.Linq

Public Class CreateTokenForm
    Private _apiClient As New APIClient()
    Private _privateKey As String

    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey
        ' Add any initialization after the InitializeComponent() call.
        TBOwnerAddress.Text = WalletHandler.GetPublicKeyFromPrivateKey(privatekey)
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            ' Check if the API is reachable
            If _apiClient.IsConnectionFunctional() Then
                ' Get input values

                ' Construct the data to be signed (consistent with server-side)
                Dim dataToSign As String = $"{TBTokenName.Text}:{TBTokenSymbol.Text}:{TBSupply.Text}:{TBOwnerAddress.Text}"
                ' Sign the data using the private key
                Dim signature As String = WalletHandler.SignTransaction(_privateKey, dataToSign)
                LoadingControl1.Start()
                BtnCreate.Enabled = False
                LoadingControl1.Visible = True

                ' Start a new thread for the API call
                Dim thread As New Thread(Sub()
                                             Try
                                                 ' Create the token using the APIClient.CreateToken method
                                                 Dim response As JObject = _apiClient.CreateToken(TBTokenName.Text, TBTokenSymbol.Text, TBSupply.Text, TBOwnerAddress.Text, signature)

                                                 ' Update UI on the main thread
                                                 Me.Invoke(Sub()
                                                               LoadingControl1.Visible = False
                                                               Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
                                                               'Console.WriteLine(response.ToString())
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
                                                               BtnCreate.Visible = True
                                                           End Sub)
                                             End Try
                                         End Sub)
                thread.Start()

            Else
                MessageBox.Show("Blockchain is not reachable. Please check the connection.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

End Class