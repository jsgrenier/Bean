Public Class MainMenu
    Public currentTopMenuPanel As Form
    Public currentContentPanel As Form
    Private ReadOnly _privateKey As String



    Public Sub New(privatekey As String)
        InitializeComponent()

        _privateKey = privatekey
    End Sub

    Public Sub OpenTopMenuPanel(childForm As Form)
        If currentTopMenuPanel IsNot Nothing Then
            currentTopMenuPanel.Close()
        End If
        currentTopMenuPanel = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        TopMenuPanel.Controls.Add(childForm)
        TopMenuPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Public Sub OpenContentPanel(childForm As Form)
        If currentContentPanel IsNot Nothing Then
            currentContentPanel.Close()
        End If
        currentContentPanel = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        ContentPanel.Controls.Add(childForm)
        ContentPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenTopMenuPanel(New TopMenuWallet(_privateKey))
        OpenContentPanel(New PortfolioForm(_privateKey))
    End Sub

    Private Sub BtnWallet_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnWallet.MouseDown
        If BtnWallet.Checked = False Then
            BtnWallet.Checked = True
            OpenTopMenuPanel(New TopMenuWallet(_privateKey))
            OpenContentPanel(New PortfolioForm(_privateKey))
        End If
    End Sub

    Private Sub BtnExplorer_Mousedown(sender As Object, e As MouseEventArgs) Handles BtnExplorer.MouseDown
        If BtnExplorer.Checked = False Then
            BtnExplorer.Checked = True
            OpenTopMenuPanel(New TopMenuExplorer)
            OpenContentPanel(New ExplorerForm)
        End If
    End Sub

    Private Sub BtnContracts_Mousedown(sender As Object, e As MouseEventArgs) Handles BtnContracts.MouseDown
        If BtnContracts.Checked = False Then
            BtnContracts.Checked = True
            OpenTopMenuPanel(New TopMenuContracts(_privateKey))
            OpenContentPanel(New CreateTokenForm(_privateKey))
        End If
    End Sub

    Private Sub BtnSwap_Mousedown(sender As Object, e As MouseEventArgs) Handles BtnSwap.MouseDown
        If BtnSwap.Checked = False Then
            BtnSwap.Checked = True
            OpenTopMenuPanel(New TopMenuSwap(_privateKey))
            OpenContentPanel(New SwapTokensForm(_privateKey))
        End If
    End Sub
End Class