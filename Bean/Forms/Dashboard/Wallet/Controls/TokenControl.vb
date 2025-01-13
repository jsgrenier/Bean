Public Class TokenControl

    Private Sub MainPanel_MouseEnter(sender As Object, e As EventArgs) Handles MainPanel.MouseEnter, LblTotalPrice.MouseEnter, LblQtySymbol.MouseEnter, LblPrice.MouseEnter, LblName.MouseEnter, CoinImage.MouseEnter
        MainPanel.FillColor = Color.FromArgb(26, 26, 31)
        CoinImage.BackColor = Color.FromArgb(26, 26, 31)
        LblName.BackColor = Color.FromArgb(26, 26, 31)
        LblPrice.BackColor = Color.FromArgb(26, 26, 31)
        LblQtySymbol.BackColor = Color.FromArgb(26, 26, 31)
        LblTotalPrice.BackColor = Color.FromArgb(26, 26, 31)
    End Sub

    Private Sub MainPanel_MouseLeave(sender As Object, e As EventArgs) Handles MainPanel.MouseLeave, LblTotalPrice.MouseLeave, LblQtySymbol.MouseLeave, LblPrice.MouseLeave, LblName.MouseLeave, CoinImage.MouseLeave
        MainPanel.FillColor = Color.FromArgb(23, 24, 28)
        CoinImage.BackColor = Color.FromArgb(23, 24, 28)
        LblName.BackColor = Color.FromArgb(23, 24, 28)
        LblPrice.BackColor = Color.FromArgb(23, 24, 28)
        LblQtySymbol.BackColor = Color.FromArgb(23, 24, 28)
        LblTotalPrice.BackColor = Color.FromArgb(23, 24, 28)
    End Sub
End Class
