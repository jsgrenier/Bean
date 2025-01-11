Public Class TopMenuWallet
    Private _privateKey As String
    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub TopMenuWallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartingTimer.Start()
    End Sub

    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        Guna2Transition1.ShowSync(FlowLayoutPanel1)
    End Sub

    Private Sub BtnPortfolio_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnPortfolio.MouseDown
        If BtnPortfolio.Checked = False Then
            BtnPortfolio.Checked = True
            Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
            _mainMenu.OpenContentPanel(New PortfolioForm(_privateKey))
        End If
    End Sub

    Private Sub BtnSend_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSend.MouseDown
        If BtnSend.Checked = False Then
            BtnSend.Checked = True
            Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
            _mainMenu.OpenContentPanel(New SendForm(_privateKey))
        End If
    End Sub

    Private Sub BtnReceive_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnReceive.MouseDown
        If BtnReceive.Checked = False Then
            BtnReceive.Checked = True
            Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
            _mainMenu.OpenContentPanel(New ReceiveForm(_privateKey))
        End If
    End Sub
End Class