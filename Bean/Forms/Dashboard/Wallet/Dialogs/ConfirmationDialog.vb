Public Class ConfirmationDialog
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class