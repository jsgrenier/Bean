﻿Public Class CreateWalletForm
    Private Sub BtnGenerate_MouseClick(sender As Object, e As MouseEventArgs) Handles BtnGenerate.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim walletInfo As Tuple(Of String, String) = WalletHandler.GenerateWallet(TBPassword.Text)
            Dim publicKey As String = walletInfo.Item1
            Dim privateKey As String = walletInfo.Item2


            ' Display keys in the form (use a TextBox or Label)
            TBPublicAddress.Text = publicKey
            TBPrivateAddress.Text = privateKey
        End If
    End Sub

    Private Sub CreateWalletForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartingTimer.Start()
    End Sub

    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        Guna2Transition1.ShowSync(CreatePanel)
    End Sub

    Private Sub Guna2PictureBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2PictureBox3.MouseClick
        Dim loginForm As New LoginForm()
        MainForm.OpenMainPanel(loginForm)
    End Sub

    Private Sub BtnSave_MouseClick(sender As Object, e As MouseEventArgs) Handles BtnSave.MouseClick
        ' Now, use SaveFileDialog to let the user choose where to save
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Wallet Files (*.dat)|*.dat"
        saveFileDialog.Title = "Save Wallet"
        saveFileDialog.FileName = "wallet.dat"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            ' Save the wallet to the chosen file path
            If WalletHandler.SaveWalletToFile(TBPrivateAddress.Text, filePath, TBPassword.Text) Then
                MessageBox.Show("Wallet created and saved successfully!")
            Else
                MessageBox.Show("Error saving wallet to file.")
            End If
        End If
    End Sub

    Private Sub BtnWallet_MouseClick(sender As Object, e As MouseEventArgs) Handles BtnWallet.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim loadingForm As New LoadingForm(TBPrivateAddress.Text)
            MainForm.OpenMainPanel(loadingForm)
        End If
    End Sub
End Class