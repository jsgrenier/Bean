Imports Newtonsoft.Json.Linq

Public Class ConfirmationForm
    Private _apiClient As New APIClient()

    Public Sub New(message As String, txID As String)
        InitializeComponent()
        LabelTitle.Text = message
        IDLabel.Text = txID

        ' Call the async method to track the transaction
        TrackTransactionAsync(txID)
    End Sub

    Private Async Sub TrackTransactionAsync(txid As String)
        Try
            ' Use the async GettAsync method
            Dim jsonObject As JObject = Await _apiClient.GettAsync("/transaction", New Dictionary(Of String, String) From {{"id", txid}})
            Dim _status As String = jsonObject("status").ToString()

        Catch ex As Exception
            ' Handle exceptions that might occur during the API call
            Console.WriteLine($"Error tracking transaction: {ex.Message}")
            ' You might want to display an error message to the user here
        End Try
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