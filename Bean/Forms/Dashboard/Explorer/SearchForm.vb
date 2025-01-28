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
        Try
            ' Use the async GettAsync method
            Dim jsonObject As JObject = Await _apiClient.GettAsync("/transaction", New Dictionary(Of String, String) From {{"id", searchQuery}})
            Dim _status As String = jsonObject("status").ToString()

            Dim _transaction As JObject = jsonObject("transaction")

            FlowLayoutPanel1.Controls.Clear()
            Select Case _status
                Case "Complete"
                    'Dim _timestamp As String = jsonObject("timestamp").ToString()
                    'Dim _blockindex As String = jsonObject("blockIndex").ToString()
                    'Dim _blockhash As String = jsonObject("blockHash").ToString()
                    'Dim _nonce As String = jsonObject("nonce").ToString()
                    Label1.ForeColor = Color.Green






                Case "Pending"
                    Label1.ForeColor = Color.Orange
            End Select

            Label1.Text = _status
            For Each item In _transaction
                Dim lbl As New Label()
                lbl.AutoSize = False
                lbl.Size = New Size(500, 20)
                lbl.Text = $"{item.Key}: {item.Value}"
                FlowLayoutPanel1.Controls.Add(lbl)
            Next


        Catch ex As Exception
            Label1.ForeColor = Color.Red
            Label1.Text = "Transaction could not be found."
        End Try
    End Sub

    Private Sub TBTxID_KeyDown(sender As Object, e As KeyEventArgs) Handles TBTxID.KeyDown
        If e.KeyValue = Keys.Enter Then
            SearchTransaction(TBTxID.Text)
        End If
    End Sub
End Class