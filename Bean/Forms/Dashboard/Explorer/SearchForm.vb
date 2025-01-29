Imports Newtonsoft.Json.Linq

Public Class SearchForm
    Private _apiClient As New APIClient()
    Public Sub New(searchQuery As String)
        InitializeComponent()

        If searchQuery IsNot "" Then
            TBTxID.Text = searchQuery
            SearchTransaction(searchQuery)
        End If
    End Sub

    Private Async Sub SearchTransaction(searchQuery As String)
        SearchPanel.Focus()
        LoadingControl1.Start()
        Try
            MainPanel.Visible = False
            LoadingControl1.Visible = True

            ' Use the async GettAsync method
            Dim jsonObject As JObject = Await _apiClient.GettAsync("/transaction", New Dictionary(Of String, String) From {{"id", searchQuery}})
            Dim _status As String = jsonObject("status").ToString()

            Dim _transaction As JObject = jsonObject("transaction")

            FlowLayoutPanel1.Controls.Clear()
            Select Case _status
                Case "Complete"

                    Dim ctrl As New DetailControl()
                    ctrl.LblKey.Text = "status"
                    ctrl.LblValue.Text = _status
                    ctrl.LblValue.Font = New Font("Segoe UI Semibold", 11.25!, FontStyle.Bold, GraphicsUnit.Point)
                    ctrl.LblValue.ForeColor = Color.FromArgb(139, 195, 74)
                    FlowLayoutPanel1.Controls.Add(ctrl)






                Case "Pending"
                    Dim ctrl As New DetailControl()
                    ctrl.LblKey.Text = "status"
                    ctrl.LblValue.Text = _status
                    ctrl.LblValue.Font = New Font("Segoe UI Semibold", 11.25!, FontStyle.Bold, GraphicsUnit.Point)
                    ctrl.LblValue.ForeColor = Color.Orange
                    FlowLayoutPanel1.Controls.Add(ctrl)
            End Select


            For Each item In _transaction
                Dim ctrl As New DetailControl()
                ctrl.LblKey.Text = item.Key
                ctrl.LblValue.Text = item.Value
                FlowLayoutPanel1.Controls.Add(ctrl)
            Next


            If _status = "Complete" Then
                For i As Integer = 0 To 4
                    Dim ctrl As New DetailControl()
                    Select Case i
                        Case 0
                            ctrl.LblKey.Text = "Block Informations"
                            ctrl.LblKey.Font = New Font("Segoe UI", 11.25!, FontStyle.Bold, GraphicsUnit.Point)
                            ctrl.LblValue.Text = ""
                            FlowLayoutPanel1.Controls.Add(ctrl)
                        Case 1
                            ctrl.LblKey.Text = "timestamp"
                            ctrl.LblValue.Text = jsonObject("timestamp").ToString()
                            FlowLayoutPanel1.Controls.Add(ctrl)
                        Case 2
                            ctrl.LblKey.Text = "blockHeight"
                            ctrl.LblValue.Text = jsonObject("blockIndex").ToString()
                            FlowLayoutPanel1.Controls.Add(ctrl)
                        Case 3
                            ctrl.LblKey.Text = "blockHash"
                            ctrl.LblValue.Text = jsonObject("blockHash").ToString()
                            FlowLayoutPanel1.Controls.Add(ctrl)
                        Case 4
                            ctrl.LblKey.Text = "nonce"
                            ctrl.LblValue.Text = jsonObject("nonce").ToString()
                            ctrl.Guna2Panel1.CustomBorderThickness = New Padding(0, 0, 0, 0)
                            FlowLayoutPanel1.Controls.Add(ctrl)
                    End Select
                Next

                MainPanel.Size = New Size(770, 529)
            Else
                Dim lastcontrol As DetailControl = FlowLayoutPanel1.Controls.Item(FlowLayoutPanel1.Controls.Count - 1)
                lastcontrol.Guna2Panel1.CustomBorderThickness = New Padding(0, 0, 0, 0)
                MainPanel.Size = New Size(770, 329)

            End If



            FlowLayoutPanel1.Visible = True



        Catch ex As Exception
            MainPanel.Size = New Size(770, 92)
            FlowLayoutPanel1.Controls.Clear()
            FlowLayoutPanel1.Visible = False
            LblError.ForeColor = Color.FromArgb(244, 67, 54)
            LblError.Text = "Transaction could not be found."
        End Try

        TimerDataLoading.Start()
    End Sub

    Private Sub TBTxID_KeyDown(sender As Object, e As KeyEventArgs) Handles TBTxID.KeyDown
        If e.KeyValue = Keys.Enter Then
            TimerDataLoading.Stop()
            SearchTransaction(TBTxID.Text)
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        TimerDataLoading.Stop()
        SearchTransaction(TBTxID.Text)
    End Sub

    Private Sub TimerDataLoading_Tick(sender As Object, e As EventArgs) Handles TimerDataLoading.Tick
        TimerDataLoading.Stop()
        LoadingControl1.Stop()
        LoadingControl1.Visible = False
        MainPanel.Visible = True
    End Sub
End Class