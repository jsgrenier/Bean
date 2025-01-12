﻿Public Class TopMenuContracts
    Private _privateKey As String
    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey
    End Sub
    Private Sub TopMenuContracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartingTimer.Start()
    End Sub

    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        Guna2Transition1.ShowSync(FlowLayoutPanel1)
    End Sub

    Private Sub BtnSwap_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCreateToken.MouseDown
        If BtnCreateToken.Checked = False Then
            BtnCreateToken.Checked = True
            Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
            _mainMenu.OpenContentPanel(New CreateTokenForm(_privateKey))
        End If
    End Sub
End Class