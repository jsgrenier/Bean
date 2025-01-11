Imports Newtonsoft.Json.Linq

Public Class ConfirmationForm
    Private _apiClient As New APIClient()

    Public Sub New(message As String, txID As String)
        InitializeComponent()
        LabelTitle.Text = message
        IDLabel.Text = txID

        TrackTransaction(txID)
    End Sub

    Private Sub TrackTransaction(txid As String)
        Dim jsonObject As JObject = _apiClient.Gett("/transaction", New Dictionary(Of String, String) From {{"id", txid}})
        Dim _status As String = jsonObject("status").ToString()

        Console.WriteLine(jsonObject("transaction")("timestamp").ToString())
    End Sub

    Private Sub ConfirmationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingControl1.Start()
        StartingTimer.Start()
    End Sub

    Private Sub StartingTimer_Tick(sender As Object, e As EventArgs) Handles StartingTimer.Tick
        StartingTimer.Stop()
        LoadingControl1.Stop()
        LoadingControl1.Visible = False
        Guna2Transition1.ShowSync(MainPanel)
    End Sub

    Private Sub CopyPublicAddress_Click(sender As Object, e As EventArgs) Handles CopyPublicAddress.Click
        Try
            IDLabel.Focus()
            Clipboard.SetData(DataFormats.Text, IDLabel.Text)
            IDLabel.Focus()
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class