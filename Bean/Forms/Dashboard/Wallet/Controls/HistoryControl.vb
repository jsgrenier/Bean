Public Class HistoryControl
    Public Timestamp As Date
    Public Event Tx_Click As EventHandler

    Private Sub LblQty_TextChanged(sender As Object, e As EventArgs) Handles LblQty.TextChanged
        If LblQty.Text.Contains("+") Then
            LblQty.ForeColor = Color.FromArgb(139, 195, 74)
        Else
            LblQty.ForeColor = Color.FromArgb(244, 67, 54)
        End If
    End Sub

    Private Sub LblTx_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblTx.LinkClicked
        RaiseEvent Tx_Click(Me, e)
    End Sub
End Class
