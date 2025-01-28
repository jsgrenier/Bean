Public Class ViewMoreControl
    Public Event ViewMore_Click As EventHandler

    Private Sub LblViewMore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblViewMore.LinkClicked
        RaiseEvent ViewMore_Click(Me, e)
    End Sub
End Class
