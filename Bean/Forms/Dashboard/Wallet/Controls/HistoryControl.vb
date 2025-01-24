Public Class HistoryControl
    Public Timestamp As Date

    Private Sub LblQty_TextChanged(sender As Object, e As EventArgs) Handles LblQty.TextChanged
        If LblQty.Text.Contains("+") Then
            LblQty.ForeColor = Color.FromArgb(139, 195, 74)
        Else
            LblQty.ForeColor = Color.FromArgb(244, 67, 54)
        End If
    End Sub
End Class
