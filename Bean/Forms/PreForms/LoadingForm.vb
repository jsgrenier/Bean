Imports System.Threading
Imports Microsoft.VisualBasic.Devices
Imports Newtonsoft.Json.Linq

Public Class LoadingForm
    Private _privateKey As String
    Private _isChainValid As Boolean = False
    Private _isKeyValid As Boolean = False
    Private _apiClient As New APIClient()

    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey
    End Sub

    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartingTimer.Start()
    End Sub

    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        Guna2Transition1.ShowSync(LoadingPanel)
        ValidatingProcess.Start()
    End Sub

    Private Sub ValidatingProcess_Tick(sender As Object, e As EventArgs) Handles ValidatingProcess.Tick
        PBValidating.Increment(2)
    End Sub

    Private Sub PBValidating_ValueChanged(sender As Object, e As EventArgs) Handles PBValidating.ValueChanged
        Select Case PBValidating.Value
            Case 30
                ValidatingProcess.Stop()

                If _apiClient.IsConnectionFunctional = False Then
                    PBNetwork.Image = My.Resources.error_red
                    ShowError("network", "Blockchain is not accessible")
                    Exit Sub
                Else
                    PBNetwork.Image = My.Resources.checkmark_blue
                End If

                ValidatingProcess.Start()

            Case 60
                ValidatingProcess.Stop()
                'We need to fix this, it always return False (server sided)
                If _apiClient.CheckBlockchainValidity = False Then
                    PBChain.Image = My.Resources.error_red
                    'ShowError("chain", "Blockchain is not valid")
                    'Exit Sub
                Else
                    PBChain.Image = My.Resources.checkmark_blue
                End If

                ValidatingProcess.Start()

            Case 80
                ValidatingProcess.Stop()
                If WalletHandler.GetPublicKeyFromPrivateKey(_privateKey).Contains("Invalid format") Then
                    PBKey.Image = My.Resources.error_red
                    ShowError("key", "Private key has the wrong format")
                Else
                    PBKey.Image = My.Resources.checkmark_blue
                End If

                ValidatingProcess.Start()


            Case 100
                ValidatingProcess.Stop()
                LabelTitle.Text = "Loading your wallet..."
                PBValidating.Value = 50
                PBValidating.Animated = True

                WalletConnector.Start()

        End Select
    End Sub

    Private Sub WalletConnector_Tick(sender As Object, e As EventArgs) Handles WalletConnector.Tick
        WalletConnector.Stop()
        'OpeningForm.OpenWallet(_privateKey)
        MainForm.OpenMainPanel(New MainMenu(_privateKey))
        MainForm.MainPanel.AutoScroll = False
        MainForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ShowError(type As String, errorString As String)
        LabelTitle.ForeColor = Color.FromArgb(250, 82, 82)
        LabelTitle.Text = "Operation was cancelled"
        Select Case type
            Case "network"
                Console.WriteLine(errorString)

            Case "chain"
                Console.WriteLine(errorString)

            Case "key"
                Console.WriteLine(errorString)
        End Select

        BtnExit.Visible = True
        BtnRetry.Visible = True

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        MainForm.OpenMainPanel(New LoginForm())
    End Sub

    Private Sub BtnRetry_Click(sender As Object, e As EventArgs) Handles BtnRetry.Click
        MainForm.OpenMainPanel(New LoadingForm(_privateKey))
    End Sub
End Class