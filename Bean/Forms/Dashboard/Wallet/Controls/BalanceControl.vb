Public Class BalanceControl
    Public Sub New(balanceValue As String)

        ' This call is required by the designer.
        InitializeComponent()
        UpdateBalance(balanceValue)
        Me.Width = LblBalance.Width + 66
        MainPanel.Width = LblBalance.Width + 66
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UpdateBalance(value As Decimal)
        Dim currentBalance As Decimal
        currentBalance = value
        If currentBalance = 0 Then
            LblBalance.Text = "$ 0.00"
        Else
            LblBalance.Text = "$ " & currentBalance.ToString("#,0.########")
        End If


        Me.Width = LblBalance.Width + 66
        MainPanel.Width = LblBalance.Width + 66
    End Sub

    Private Sub MainPanel_MouseEnter(sender As Object, e As EventArgs) Handles MainPanel.MouseEnter, LblBalance.MouseEnter, LblTitle.MouseEnter
        MainPanel.FillColor = Color.FromArgb(26, 26, 31)
        LblBalance.BackColor = Color.FromArgb(26, 26, 31)
        LblTitle.BackColor = Color.FromArgb(26, 26, 31)
    End Sub

    Private Sub MainPanel_MouseLeave(sender As Object, e As EventArgs) Handles MainPanel.MouseLeave, LblBalance.MouseLeave, LblTitle.MouseLeave
        MainPanel.FillColor = Color.FromArgb(23, 24, 28)
        LblBalance.BackColor = Color.FromArgb(23, 24, 28)
        LblTitle.BackColor = Color.FromArgb(23, 24, 28)
    End Sub

End Class
