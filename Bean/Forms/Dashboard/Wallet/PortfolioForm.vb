Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
Imports System.Net.Http

Public Class PortfolioForm
    Private _apiClient As New APIClient()
    Private _cacheFilePath As String = "coin_cache.json" ' Path to your cache file
    Private _privateKey As String

    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey
        DisplayTokensOwnedAsync(WalletHandler.GetPublicKeyFromPrivateKey(privatekey))
        DisplayTransactionHistory(WalletHandler.GetPublicKeyFromPrivateKey(privatekey))
    End Sub

    Private Sub UpdateBalance(value As Decimal)
        Dim currentBalance As Decimal
        currentBalance = value
        CoinsFlowPanel.Controls.Add(New BalanceControl("$" & currentBalance.ToString("#,0.########")))
    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        LoadingTimer.Stop()
        LoadingControl1.Stop()
        LoadingControl1.Visible = False
        CoinsFlowPanel.Visible = True
    End Sub


    Private Async Sub DisplayTokensOwnedAsync(address As String) ' Make this method async
        CoinsFlowPanel.SuspendLayout()
        CoinsFlowPanel.Controls.Clear()

        CoinsFlowPanel.Visible = False
        LoadingControl1.Start()
        LoadingControl1.Visible = True



        Try
            Dim encodedAddress As String = WebUtility.UrlEncode(address)

            ' Use the async GettAsync method
            Dim jsonObject As JObject = Await _apiClient.GettAsync("/get_tokens_owned", New Dictionary(Of String, String) From {{"address", encodedAddress}})
            Dim tokensOwned As JObject = jsonObject("tokensOwned")

            ' Use the async GettAsync method
            Dim tokenNamesToken As JToken = Await _apiClient.GettAsync("/get_token_names")

            If tokenNamesToken.Type = JTokenType.Array Then
                Dim tokenNameDict As Dictionary(Of String, String) = tokenNamesToken.ToObject(Of JArray)() _
                    .ToDictionary(Function(t) t("symbol").ToString(), Function(t) t("name").ToString())


                Dim sortedTokens = tokensOwned.Properties().OrderBy(Function(p) p.Name)
                Dim totalBalance As Decimal = 0
                Dim balctrl As New BalanceControl(totalBalance)
                CoinsFlowPanel.Controls.Add(balctrl)

                For Each token In sortedTokens
                    Dim tokenAmount As Decimal = token.Value.ToObject(Of Decimal)()
                    Dim tokenName As String = If(tokenNameDict.ContainsKey(token.Name), tokenNameDict(token.Name), token.Name)

                    ' Await the GetCoinInfoAsync method (see below for the updated method)
                    Dim coinInfo As CoinInfo = Await GetCoinInfoAsync(tokenName.ToLower())

                    Dim coinPrice As Decimal = Decimal.Parse(coinInfo.CoinPrice)
                    Dim totalPrice As Decimal = tokenAmount * coinPrice
                    totalBalance += totalPrice

                    ' Create and add the token display item
                    Dim coinItem As New TokenControl()
                    coinItem.LblName.Text = $"{tokenName}"
                    coinItem.LblQtySymbol.Text = $"{tokenAmount.ToString("#,0.########")} {token.Name}"
                    coinItem.CoinImage.Image = If(coinInfo.CoinImage, My.Resources.token_icon)
                    coinItem.LblPrice.Text = "$" & coinPrice.ToString("#,0.########")
                    coinItem.LblTotalPrice.Text = "$" & totalPrice.ToString("#,0.########")

                    CoinsFlowPanel.Controls.Add(coinItem)
                    balctrl.UpdateBalance(totalBalance)
                Next
                ' Update the overall balance
                'UpdateBalance(totalBalance)
            Else
                Throw New Exception("API response for /get_token_names is not a valid array.")
            End If

        Catch ex As Exception
            ' Handle any API call errors
            Console.WriteLine($"Error getting tokens owned: {ex.Message}")
        End Try
        LoadingTimer.Start()


        CoinsFlowPanel.ResumeLayout() ' Resume layout updates
    End Sub

    Public Async Function GetCoinInfoAsync(ByVal symbol As String) As Task(Of CoinInfo) ' Make async and return Task(Of CoinInfo)
        Try
            Dim cachedCoinInfo As CoinInfo = GetCoinInfoFromCache(symbol)
            If cachedCoinInfo IsNot Nothing Then
                Return cachedCoinInfo
            End If

            Dim apiUrl As String = $"https://api.coingecko.com/api/v3/coins/{symbol}"
            Using client As New HttpClient() ' Use HttpClient for async requests
                Dim json As String = Await client.GetStringAsync(apiUrl) ' Use GetStringAsync
                Dim jsonObject As JObject = JObject.Parse(json)
                Dim imageUrl As String = jsonObject("image")("small").ToString()
                Dim price As Decimal = jsonObject("market_data")("current_price")("usd").ToObject(Of Decimal)()

                Dim coinInfo As New CoinInfo()
                ' Use GetByteArrayAsync for downloading image data
                Dim imageBytes As Byte() = Await client.GetByteArrayAsync(imageUrl)
                Using stream As New MemoryStream(imageBytes)
                    coinInfo.CoinImage = Image.FromStream(stream)
                End Using
                coinInfo.CoinPrice = price.ToString("#,0.########")

                SaveCoinInfoToCache(symbol, coinInfo)

                Return coinInfo
            End Using

        Catch ex As Exception
            Console.WriteLine($"Error getting info for {symbol}: {ex.Message}")

            ' Return default values if API call fails
            Dim coinInfo As New CoinInfo()
            coinInfo.CoinImage = My.Resources.token_icon ' Replace with your default image
            coinInfo.CoinPrice = "0.00" ' Set your default price 

            Return coinInfo
        End Try
    End Function

    Private Function GetCoinInfoFromCache(ByVal symbol As String) As CoinInfo
        Try
            If File.Exists(_cacheFilePath) Then
                Dim json As String = File.ReadAllText(_cacheFilePath)
                Dim cache As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(json)
                If cache.ContainsKey(symbol) Then
                    Dim cachedData As JObject = JObject.FromObject(cache(symbol))
                    Dim coinInfo As New CoinInfo()
                    coinInfo.CoinPrice = cachedData("CoinPrice").ToString()

                    ' Deserialize the image from Base64 string
                    Dim imageBytes As Byte() = Convert.FromBase64String(cachedData("CoinImage").ToString())
                    Using stream As New MemoryStream(imageBytes)
                        coinInfo.CoinImage = Image.FromStream(stream)
                    End Using

                    Return coinInfo
                End If
            End If
            Return Nothing
        Catch ex As Exception
            Console.WriteLine($"Error reading from cache: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Private Sub SaveCoinInfoToCache(ByVal symbol As String, ByVal coinInfo As CoinInfo)
        Try
            Dim cache As Dictionary(Of String, Object)
            If File.Exists(_cacheFilePath) Then
                Dim json As String = File.ReadAllText(_cacheFilePath)
                cache = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(json)
            Else
                cache = New Dictionary(Of String, Object)()
            End If

            ' Convert image to Base64 string for storage
            Dim imageBase64 As String
            Using ms As New MemoryStream()
                ' Save the image as PNG to avoid RawFormat issues
                Using clonedImage As New Bitmap(coinInfo.CoinImage)
                    clonedImage.Save(ms, Imaging.ImageFormat.Png)
                End Using
                Dim imageBytes As Byte() = ms.ToArray()
                imageBase64 = Convert.ToBase64String(imageBytes)
            End Using

            cache(symbol) = New With {
            .CoinPrice = coinInfo.CoinPrice,
            .CoinImage = imageBase64
        }

            Dim updatedJson As String = JsonConvert.SerializeObject(cache)
            File.WriteAllText(_cacheFilePath, updatedJson)
        Catch ex As Exception
            Console.WriteLine($"Error writing to cache: {ex.Message}")
        End Try
    End Sub

    Private Sub AdjustListControlWidths()
        Dim widthAdjustment As Integer = If(HistoryFlow.VerticalScroll.Visible, 17, 0)
        For Each control As Control In HistoryFlow.Controls
            control.Width = HistoryFlow.Width - widthAdjustment
        Next
    End Sub


    Public Class CoinInfo
        Public Property CoinImage As Image
        Public Property CoinPrice As String
    End Class

    Private Async Sub DisplayTransactionHistory(address As String)
        ' Clear the existing controls
        HistoryFlow.Controls.Clear()

        Try
            ' Encode the address before making the API call
            Dim encodedAddress As String = WebUtility.UrlEncode(address)

            ' Use the APIClient to make the GET request
            Dim jsonObject As JObject = Await _apiClient.GettAsync("/get_transaction_history", New Dictionary(Of String, String) From {{"address", encodedAddress}})

            Dim transactions As JArray = jsonObject("transactions")

            ' Sort history items by timestamp in descending order (most recent first)
            Dim sortedTransactions = transactions.OrderByDescending(Function(t) t("Timestamp")).ToList()

            ' Add sorted history items to the HistoryFlowPanel as CoinItem controls
            Dim transactionCount As Integer = 0

            For Each transaction In sortedTransactions
                If transactionCount >= 10 Then
                    Exit For
                End If

                Dim timestampValue = transaction("Timestamp")?.ToString()
                Dim amountValue = transaction("Amount")?.ToString()
                Dim hashValue = transaction("Hash")?.ToString()
                Dim txIdValue = transaction("TxId")?.ToString()
                Dim typeValue = transaction("Type")?.ToString()
                Dim statusValue = transaction("Status")?.ToString()

                If timestampValue IsNot Nothing AndAlso amountValue IsNot Nothing AndAlso hashValue IsNot Nothing Then
                    Dim historyItem As New HistoryControl() With {
                    .Timestamp = DateTime.Parse(timestampValue)
                }

                    If statusValue = "completed" Then
                        historyItem.PBStatus.Image = My.Resources.confirmedIcon
                    Else
                        historyItem.PBStatus.Image = My.Resources.pendingIcon
                    End If
                    ' Format the timestamp as "dd/MM/yyyy HH:mm:ss"
                    historyItem.LblDate.Text = historyItem.Timestamp.ToString("dd/MM/yyyy HH:mm:ss")
                    historyItem.LblQty.Text = amountValue
                    historyItem.LblTx.Text = txIdValue
                    historyItem.LblType.Text = typeValue


                    'coinItem.PBExternal.Visible = True
                    AddHandler historyItem.Tx_Click, AddressOf Tx_Click
                    HistoryFlow.Controls.Add(historyItem)
                    transactionCount += 1
                Else
                    Console.WriteLine("Transaction data is incomplete.")
                End If
            Next

            ' Add a "View More" item if there are more than 10 transactions
            If sortedTransactions.Count > 10 Then
                Dim viewMoreItem As New ViewMoreControl()
                AddHandler viewMoreItem.ViewMore_Click, AddressOf ViewMore_Click
                HistoryFlow.Controls.Add(viewMoreItem)
            End If

            AdjustListControlWidths()

            If sortedTransactions.Count = 0 Then
                BottomBar1.Visible = False
            End If

        Catch ex As Exception
            ' Handle API call errors
            Console.WriteLine($"Error getting transaction history: {ex.Message}")
            ' You might want to display an error message to the user
        End Try
    End Sub

    Private Sub ViewMore_Click(sender As Object, e As EventArgs)
        MsgBox("Viewing more for " & WalletHandler.GetPublicKeyFromPrivateKey(_privateKey))
    End Sub

    Private Sub Tx_Click(sender As Object, e As EventArgs)
        Dim historyCtrl As HistoryControl = TryCast(sender, HistoryControl)
        Dim parentForm As MainMenu = TryCast(Me.ParentForm, MainMenu)
        parentForm.SearchTx(historyCtrl.LblTx.Text)
    End Sub

    Private Sub PortfolioForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        AdjustListControlWidths()
    End Sub

    Private Sub BottomBar1_BarClicked(sender As Object, e As EventArgs) Handles BottomBar1.BarClicked
        BottomBar1.Visible = False
        HistoryPanel.Visible = True
        AdjustListControlWidths()
    End Sub

    Private Sub TopHistoryPanel_MouseEnter(sender As Object, e As EventArgs) Handles TopHistoryPanel.MouseEnter, PBArrow.MouseEnter, LblLatest.MouseEnter, PBHistory.MouseEnter
        TopHistoryPanel.FillColor = Color.FromArgb(26, 26, 31)
        LblLatest.BackColor = Color.FromArgb(26, 26, 31)
        LblLatest.ForeColor = Color.White
        PBArrow.BackColor = Color.FromArgb(26, 26, 31)
        PBArrow.Image = My.Resources.DownArrow_white
        PBHistory.BackColor = Color.FromArgb(26, 26, 31)
        PBHistory.Image = My.Resources.history_white
    End Sub

    Private Sub TopHistoryPanel_MouseLeave(sender As Object, e As EventArgs) Handles TopHistoryPanel.MouseLeave, PBArrow.MouseLeave, LblLatest.MouseLeave, PBHistory.MouseLeave
        TopHistoryPanel.FillColor = Color.FromArgb(23, 24, 28)
        LblLatest.BackColor = Color.FromArgb(23, 24, 28)
        LblLatest.ForeColor = Color.FromArgb(188, 188, 192)
        PBArrow.BackColor = Color.FromArgb(23, 24, 28)
        PBArrow.Image = My.Resources.DownArrow_gray
        PBHistory.BackColor = Color.FromArgb(23, 24, 28)
        PBHistory.Image = My.Resources.history_gray
    End Sub

    Private Sub TopHistoryPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles TopHistoryPanel.MouseClick, PBArrow.MouseClick, LblLatest.MouseClick, PBHistory.MouseClick
        HistoryPanel.Visible = False
        BottomBar1.Visible = True
    End Sub
End Class