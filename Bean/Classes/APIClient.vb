Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class APIClient

    Private _baseUrl As String

    Public Sub New()
        _baseUrl = "http://localhost:8080/api"
        '_baseUrl = "http://192.168.18.17:8080/api"
    End Sub

    Public Function IsConnectionFunctional() As Boolean
        Try
            ' Make a simple GET request to a lightweight endpoint (e.g., check server status)
            Dim url As String = _baseUrl & "/check_validity" ' Assuming you have a /ping endpoint
            Dim request As WebRequest = WebRequest.Create(url)
            request.Method = "GET"

            Using response As WebResponse = request.GetResponse()
                ' If the response is successful, the connection is functional
                Return True
            End Using

        Catch ex As WebException
            Console.WriteLine($"Connection check failed: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function Gett(endpoint As String, Optional queryParams As Dictionary(Of String, String) = Nothing) As JToken
        Try
            Dim url As String = _baseUrl & endpoint
            If queryParams IsNot Nothing Then
                url &= "?" & BuildQueryString(queryParams)
            End If

            Dim request As WebRequest = WebRequest.Create(url)
            request.Method = "GET"

            Using response As WebResponse = request.GetResponse()
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim jsonResponse As String = reader.ReadToEnd()
                    Dim jsonToken As JToken = JToken.Parse(jsonResponse)
                    If endpoint = "/get_token_names" Then
                        Return jsonToken
                    Else
                        Return jsonToken
                    End If
                End Using
            End Using

        Catch ex As WebException
            Console.WriteLine($"Error communicating with blockchain: {ex.Message}")
            ' Optionally, you can re-throw the exception or a custom exception
            ' to be handled by the calling code.
            Throw New Exception("Blockchain is not reachable.", ex)
        End Try
    End Function

    Public Function Post(endpoint As String, jsonData As String) As JObject
        Dim url As String = _baseUrl & endpoint

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        request.ContentType = "application/json"

        Using writer As New StreamWriter(request.GetRequestStream())
            writer.Write(jsonData)
        End Using

        Using response As WebResponse = request.GetResponse()
            Using reader As New StreamReader(response.GetResponseStream())
                Dim jsonResponse As String = reader.ReadToEnd()
                Return JObject.Parse(jsonResponse)
            End Using
        End Using
    End Function

    Public Function TransferTokens(fromAddress As String, toAddress As String, amount As Decimal, tokenSymbol As String, signature As String) As JObject
        Try
            ' Create a dictionary to hold the transaction data
            Dim data As New Dictionary(Of String, String) From {
            {"toAddress", toAddress},
            {"amount", amount.ToString()},
            {"tokenSymbol", tokenSymbol},
            {"signature", signature},
            {"fromAddress", fromAddress}
        }

            ' Serialize the dictionary to a JSON string
            Dim jsonData As String = Newtonsoft.Json.JsonConvert.SerializeObject(data)

            ' Make a POST request to the /transfer_tokens endpoint with the JSON string
            Return Post("/transfer_tokens", jsonData)

        Catch ex As Exception
            ' Handle exceptions (e.g., log the error, display a message)
            Console.WriteLine($"Error transferring tokens: {ex.Message}")
            Throw ' Or handle the exception as needed
        End Try
    End Function

    Public Function CreateToken(name As String, symbol As String, supply As String, publickey As String, signature As String) As JObject
        Try
            ' Create a dictionary to hold the transaction data
            Dim data As New Dictionary(Of String, String) From {
            {"name", name},
            {"symbol", symbol},
            {"initialSupply", supply},
            {"ownerPublicKey", publickey},
            {"signature", signature}
        }
            ' Serialize the dictionary to a JSON string
            Dim jsonData As String = Newtonsoft.Json.JsonConvert.SerializeObject(data)

            ' Make a POST request to the /transfer_tokens endpoint with the JSON string
            Return Post("/create_token", jsonData)
        Catch ex As Exception
            ' Handle exceptions (e.g., log the error, display a message)
            Console.WriteLine($"Error creating tokens: {ex.Message}")
            Throw ' Or handle the exception as needed
        End Try
    End Function

    Private Function BuildQueryString(queryParams As Dictionary(Of String, String)) As String
        Dim queryString As String = ""
        For Each param In queryParams
            queryString &= $"{param.Key}={param.Value}&"
        Next
        Return queryString.TrimEnd("&")
    End Function

    Public Function CheckBlockchainValidity() As Boolean
        Try
            ' Make a GET request to the /api/check_validity endpoint
            Dim response As JObject = Gett("/check_validity")

            ' Access the "isValid" property in the JSON response
            Return response("isValid").ToObject(Of Boolean)()
        Catch ex As Exception
            ' Handle the exception (e.g., log the error, display a message)
            Console.WriteLine($"Error checking blockchain validity: {ex.Message}")
            Return False ' Or throw the exception if you want to handle it elsewhere
        End Try
    End Function

End Class