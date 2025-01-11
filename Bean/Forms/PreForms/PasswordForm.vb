Public Class PasswordForm
    Private Sub BtnUnlock_Click(sender As Object, e As EventArgs) Handles BtnUnlock.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub PasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBPassword.Focus()
    End Sub
End Class