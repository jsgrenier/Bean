Public Class LoginForm
    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        Guna2Transition1.ShowSync(LoginPanel)
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartingTimer.Start()
    End Sub

    Private Sub Guna2Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles BtnCreate.MouseClick
        If e.Button = MouseButtons.Left Then
            MainForm.OpenMainPanel(New CreateWalletForm)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Wallet Files (*.dat)|*.dat|All files (*.*)|*.*"
        openFileDialog.Title = "Select Wallet File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            ' Prompt the user for the password
            Dim inputForm As New PasswordForm()
            If inputForm.ShowDialog() = DialogResult.OK Then
                Dim password As String = inputForm.TBPassword.Text
                Try
                    ' Load and decrypt the private key using the provided password
                    Dim privateKey As String = WalletHandler.LoadWalletFromFile(filePath, password)

                    ' If decryption is successful, proceed
                    If privateKey IsNot Nothing Then
                        ' ... (rest of your import logic, e.g., display the key or use it in your application)
                        Dim _loadingForm As New LoadingForm(privateKey) ' Assuming LoadingForm takes the private key
                        'Me.Hide()
                        MainForm.OpenMainPanel(_loadingForm)
                        '_loadingForm.Show()
                    Else
                        MessageBox.Show("Incorrect password or invalid wallet file.")
                    End If

                Catch ex As Exception
                    MessageBox.Show($"Error importing wallet: {ex.Message}")
                End Try
            End If

        End If
    End Sub
End Class