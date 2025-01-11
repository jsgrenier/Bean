Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net

Public Class PortfolioForm
    Private _apiClient As New APIClient()
    Public Sub New(privatekey As String)
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DisplayTokensOwned(WalletHandler.GetPublicKeyFromPrivateKey(privatekey))
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        'RightPanel.Visible = False
        CoinsFlowPanel.Controls.Add(New TokenControl)
    End Sub

    Private Sub DisplayTokensOwned(address As String)
        CoinsFlowPanel.Controls.Clear()

        Try
            ' Encode the address
            Dim encodedAddress As String = WebUtility.UrlEncode(address)

            ' Use the APIClient to make the GET request for tokens owned
            Dim jsonObject As JObject = _apiClient.Gett("/get_tokens_owned", New Dictionary(Of String, String) From {{"address", encodedAddress}})
            Dim tokensOwned As JObject = jsonObject("tokensOwned")

            ' Fetch token names from the API
            Dim tokenNamesToken As JToken = _apiClient.Gett("/get_token_names")

            ' Ensure tokenNamesToken is a JArray
            If tokenNamesToken.Type = JTokenType.Array Then
                ' Convert the JArray into a dictionary for easy lookup
                Dim tokenNameDict As Dictionary(Of String, String) = tokenNamesToken.ToObject(Of JArray)() _
                .ToDictionary(Function(t) t("symbol").ToString(), Function(t) t("name").ToString())

                ' Sort tokens by their symbol
                Dim sortedTokens = tokensOwned.Properties().OrderBy(Function(p) p.Name)

                ' Display each token in the CoinsFlowPanel
                For Each token In sortedTokens
                    Dim tokenAmount As String
                    Dim amount As Decimal = token.Value.ToObject(Of Decimal)()

                    ' Format the token amount
                    tokenAmount = If(amount = Math.Floor(amount), CInt(amount).ToString(), amount.ToString())

                    ' Get the token name from the dictionary, or fallback to the symbol
                    Dim tokenName As String = If(tokenNameDict.ContainsKey(token.Name), tokenNameDict(token.Name), token.Name)

                    Dim coinInfo As CoinInfo = GetCoinInfo(tokenName.ToLower())

                    ' Create and add the token display item
                    Dim coinItem As New TokenControl()
                    coinItem.LblName.Text = $"{tokenName}"
                    coinItem.LblQtySymbol.Text = $"{tokenAmount} {token.Name}"
                    coinItem.CoinImage.Image = coinInfo.CoinImage
                    coinItem.LblPrice.Text = coinInfo.CoinPrice

                    CoinsFlowPanel.Controls.Add(coinItem)
                Next
            Else
                Throw New Exception("API response for /get_token_names is not a valid array.")
            End If

        Catch ex As Exception
            ' Handle any API call errors
            Console.WriteLine($"Error getting tokens owned: {ex.Message}")
        End Try
    End Sub

    Public Function GetCoinInfo(ByVal symbol As String) As CoinInfo
        Try
            ' Check if the coin data is in the cache
            Dim cachedCoinInfo As CoinInfo = GetCoinInfoFromCache(symbol)
            If cachedCoinInfo IsNot Nothing Then
                Return cachedCoinInfo
            End If

            ' If not cached, fetch from the API
            Dim apiUrl As String = $"https://api.coingecko.com/api/v3/coins/{symbol}"
            Using client As New WebClient()
                Dim json As String = client.DownloadString(apiUrl)
                Dim jsonObject As JObject = JObject.Parse(json)
                Dim imageUrl As String = jsonObject("image")("small").ToString()
                Dim price As Decimal = jsonObject("market_data")("current_price")("usd").ToObject(Of Decimal)()

                Dim coinInfo As New CoinInfo()
                Using stream As New MemoryStream(client.DownloadData(imageUrl))
                    coinInfo.CoinImage = Image.FromStream(stream)
                End Using
                coinInfo.CoinPrice = price.ToString("#,0.00")

                ' Store the fetched data in the cache
                SaveCoinInfoToCache(symbol, coinInfo)

                Return coinInfo
            End Using

        Catch ex As Exception
            Console.WriteLine($"Error getting info for {symbol}: {ex.Message}")
            Return Nothing
        End Try
    End Function
    Private _cacheFilePath As String = "coin_cache.json" ' Path to your cache file
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
            Using ms As New MemoryStream()
                coinInfo.CoinImage.Save(ms, coinInfo.CoinImage.RawFormat)
                Dim imageBytes As Byte() = ms.ToArray()
                Dim imageBase64 As String = Convert.ToBase64String(imageBytes)

                cache(symbol) = New With {
                    .CoinPrice = coinInfo.CoinPrice,
                    .CoinImage = imageBase64
                }
            End Using

            Dim updatedJson As String = JsonConvert.SerializeObject(cache)
            File.WriteAllText(_cacheFilePath, updatedJson)
        Catch ex As Exception
            Console.WriteLine($"Error writing to cache: {ex.Message}")
        End Try
    End Sub


    Public Class CoinInfo
        Public Property CoinImage As Image
        Public Property CoinPrice As String
    End Class
End Class