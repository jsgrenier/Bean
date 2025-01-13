Public Class MainForm

    Public currentChildformContentPanel As Form
    'Private _privateAddress As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingControl1.Start()
        StartingTimer.Start()
    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        LoadingControl1.Visible = False
        LoadingControl1.Stop()
        Dim loginForm As New LoginForm()
        OpenMainPanel(loginForm)
    End Sub

    Public Sub OpenMainPanel(childForm As Form)
        If currentChildformContentPanel IsNot Nothing Then
            currentChildformContentPanel.Close()
        End If
        currentChildformContentPanel = childForm
        'end
        Select Case childForm.Name
            Case "LoginForm", "CreateWalletForm", "LoadingForm"
                childForm.TopLevel = False
                childForm.FormBorderStyle = FormBorderStyle.None
                childForm.Left = MainPanel.Width / 2 - childForm.Width / 2
                childForm.Top = 50
                childForm.Anchor = AnchorStyles.Top
                childForm.Margin = New Padding(0, 0, 0, 50)
                MainPanel.Controls.Add(childForm)
                MainPanel.Tag = childForm
                childForm.BringToFront()
                childForm.Show()

            Case Else
                childForm.TopLevel = False
                childForm.FormBorderStyle = FormBorderStyle.None
                childForm.Dock = DockStyle.Fill
                MainPanel.Controls.Add(childForm)
                MainPanel.Tag = childForm
                childForm.BringToFront()
                childForm.Show()

        End Select

    End Sub
End Class
