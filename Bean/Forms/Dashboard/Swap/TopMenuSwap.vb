Public Class TopMenuSwap
    Private _privateKey As String
    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey
    End Sub
    Private Sub TopMenuWallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartingTimer.Start()
    End Sub

    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        Guna2Transition1.ShowSync(FlowLayoutPanel1)
    End Sub

    Private Sub BtnSwap_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSwap.MouseDown
        If BtnSwap.Checked = False Then
            BtnSwap.Checked = True
            Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
            _mainMenu.OpenContentPanel(New SwapTokensForm(_privateKey))
        End If
    End Sub
End Class