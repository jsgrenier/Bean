Public Class PasswordForm

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub BtnUnlock_Click(sender As Object, e As EventArgs) Handles BtnUnlock.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub PasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBPassword.Focus()
    End Sub
End Class