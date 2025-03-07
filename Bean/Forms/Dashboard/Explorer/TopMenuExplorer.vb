﻿Public Class TopMenuExplorer

    Public Sub New(menu As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Select Case menu
            Case 0
                BtnSearch.Checked = False
                BtnExplorer.Checked = True

            Case 1
                BtnExplorer.Checked = False
                BtnSearch.Checked = True

        End Select
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        Guna2Transition1.ShowSync(FlowLayoutPanel1)
    End Sub

    Private Sub TopMenuExplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartingTimer.Start()
    End Sub

    Private Sub BtnExplorer_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnExplorer.MouseDown
        If BtnExplorer.Checked = False Then
            BtnExplorer.Checked = True
            Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
            _mainMenu.OpenContentPanel(New ExplorerForm)
        End If
    End Sub

    Private Sub BtnSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSearch.MouseDown
        If BtnSearch.Checked = False Then
            BtnSearch.Checked = True
            Dim _mainMenu = TryCast(Me.ParentForm, MainMenu)
            _mainMenu.OpenContentPanel(New SearchForm(""))
        End If
    End Sub
End Class