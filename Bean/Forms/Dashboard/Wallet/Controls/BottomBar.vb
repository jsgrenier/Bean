Public Class BottomBar
    Public Event BarClicked As EventHandler
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Dock = DockStyle.Bottom
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub MainPanel_MouseEnter(sender As Object, e As EventArgs) Handles MainPanel.MouseEnter, Label1.MouseEnter, PBArrow.MouseEnter, PBHistory.MouseEnter
        MainPanel.FillColor = Color.FromArgb(26, 26, 31)
        Label1.BackColor = Color.FromArgb(26, 26, 31)
        Label1.ForeColor = Color.White
        PBArrow.BackColor = Color.FromArgb(26, 26, 31)
        PBArrow.Image = My.Resources.UpArrow_white
        PBHistory.BackColor = Color.FromArgb(26, 26, 31)
        PBHistory.Image = My.Resources.history_white
    End Sub
    Private Sub MainPanel_MouseLeave(sender As Object, e As EventArgs) Handles MainPanel.MouseLeave, Label1.MouseLeave, PBArrow.MouseLeave, PBHistory.MouseLeave
        MainPanel.FillColor = Color.FromArgb(23, 24, 28)
        Label1.BackColor = Color.FromArgb(23, 24, 28)
        Label1.ForeColor = Color.FromArgb(188, 188, 192)
        PBArrow.BackColor = Color.FromArgb(23, 24, 28)
        PBArrow.Image = My.Resources.UpArrow_gray
        PBHistory.BackColor = Color.FromArgb(23, 24, 28)
        PBHistory.Image = My.Resources.history_gray
    End Sub

    Private Sub MainPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles MainPanel.MouseClick, Label1.MouseClick, PBArrow.MouseClick, PBHistory.MouseClick
        RaiseEvent BarClicked(Me, e)
    End Sub
End Class
