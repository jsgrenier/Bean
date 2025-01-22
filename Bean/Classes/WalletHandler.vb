Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Org.BouncyCastle.Asn1.X9
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.EC
Imports Org.BouncyCastle.Crypto.Generators
Imports Org.BouncyCastle.Crypto.Parameters
Imports Org.BouncyCastle.Math
Imports Org.BouncyCastle.Security

Public Class WalletHandler
    Private Shared ReadOnly curve As X9ECParameters = ECNamedCurveTable.GetByName("secp256k1")
    Private Shared ReadOnly domainParams As ECDomainParameters = New ECDomainParameters(curve.Curve, curve.G, curve.N, curve.H)
    Private Shared msInput As MemoryStream
    Private Shared msOutput As MemoryStream

    Public Shared Function GenerateWallet() As Tuple(Of String, String)
        ' Generate the ECDSA key pair
        Dim keyPair As Tuple(Of String, String) = GenerateKeyPair()
        Dim privateKey As String = keyPair.Item1
        Dim publicKey As String = keyPair.Item2

        ' Return the public key
        Return Tuple.Create(publicKey, privateKey)
    End Function
    Public Shared Function GenerateKeyPair() As Tuple(Of String, String)
        ' Generate ECDSA key pair
        Dim generator As New ECKeyPairGenerator("ECDSA")
        generator.Init(New ECKeyGenerationParameters(domainParams, New SecureRandom()))
        Dim keyPair As AsymmetricCipherKeyPair = generator.GenerateKeyPair()

        ' Extract private and public keys
        Dim privateKey As ECPrivateKeyParameters = TryCast(keyPair.Private, ECPrivateKeyParameters)
        Dim publicKey As ECPublicKeyParameters = TryCast(keyPair.Public, ECPublicKeyParameters)

        ' Encode private key to Base64 string
        Dim privateKeyString As String = Convert.ToBase64String(privateKey.D.ToByteArrayUnsigned())

        ' Encode public key to Base64 string in compressed format
        Dim publicKeyString As String = Convert.ToBase64String(publicKey.Q.GetEncoded(True))

        Return New Tuple(Of String, String)(privateKeyString, publicKeyString)
    End Function

    Public Shared Sub SaveWalletToFile(privateKey As String, filePath As String, password As String)
        ' Generate a key and IV from the password with a secure salt
        Using deriveBytes As New Rfc2898DeriveBytes(password, New Byte() {1, 2, 3, 4, 5, 6, 7, 8}) ' Use a salt of at least 8 bytes
            Dim key As Byte() = deriveBytes.GetBytes(32) ' 32 bytes for Rijndael key
            Dim iv As Byte() = deriveBytes.GetBytes(16) ' 16 bytes for Rijndael IV

            ' Encrypt the string and save to file
            EncryptFile(privateKey, filePath, key, iv)
        End Using
    End Sub

    Public Shared Function EncryptFile(strInput As String, strOutputFile As String, bytKey() As Byte, bytIV() As Byte) As Boolean
        Return EncryptOrDecryptFile(strInput, strOutputFile, bytKey, bytIV, CryptoAction.ActionEncrypt)
    End Function

    Public Shared Function LoadWalletFromFile(filePath As String, password As String) As String
        Try
            ' Read the encrypted data from the file
            Dim encryptedData As Byte() = File.ReadAllBytes(filePath)

            ' Generate a key and IV from the password with the same salt used for encryption
            Using deriveBytes As New Rfc2898DeriveBytes(password, New Byte() {1, 2, 3, 4, 5, 6, 7, 8}) ' Use the same salt as for encryption
                Dim key As Byte() = deriveBytes.GetBytes(32) ' 32 bytes for Rijndael key
                Dim iv As Byte() = deriveBytes.GetBytes(16) ' 16 bytes for Rijndael IV

                ' Decrypt the data
                Using rijndael As New RijndaelManaged()
                    rijndael.Key = key
                    rijndael.IV = iv

                    Using decryptor As ICryptoTransform = rijndael.CreateDecryptor()
                        Using ms As New MemoryStream(encryptedData)
                            Using cs As New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
                                Using sr As New StreamReader(cs)
                                    Return sr.ReadToEnd()
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions during decryption
            Console.WriteLine("Error decrypting file: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function DecryptFile(strInputFile As String, strOutputFile As String, bytKey() As Byte, bytIV() As Byte) As Boolean
        Return EncryptOrDecryptFile(strInputFile, strOutputFile, bytKey, bytIV, CryptoAction.ActionDecrypt)
    End Function

    Public Shared Function SignTransaction(privateKey As String, transactionData As String) As String
        Try
            ' Decode the private key
            Dim privateKeyBytes As Byte() = Convert.FromBase64String(privateKey)
            Dim keyParameters As New ECPrivateKeyParameters(New BigInteger(1, privateKeyBytes), domainParams)

            ' Create a SHA256withECDSA signer
            Dim signer As ISigner = SignerUtilities.GetSigner("SHA256withECDSA")

            ' Initialize the signer for signing
            signer.Init(True, keyParameters)

            Dim bytes As Byte() = Encoding.UTF8.GetBytes(transactionData)

            ' Update the signer with the transaction data
            signer.BlockUpdate(bytes, 0, bytes.Length)

            ' Generate the signature
            Dim signature As Byte() = signer.GenerateSignature()

            ' Encode the signature to Base64 string
            Return Convert.ToBase64String(signature)

        Catch ex As Exception
            Console.WriteLine($"Error signing transaction: {ex.Message}")
            Return ""
        End Try
    End Function

    Public Shared Function GetPublicKeyFromPrivateKey(privateKeyString As String) As String
        Try
            ' Decode the private key
            Dim privateKeyBytes As Byte() = Convert.FromBase64String(privateKeyString)

            ' Get the ECDomainParameters
            Dim ecP As X9ECParameters = CustomNamedCurves.GetByName("secp256k1")
            Dim parameters As ECDomainParameters = New ECDomainParameters(ecP.Curve, ecP.G, ecP.N, ecP.H, ecP.GetSeed())

            ' Create ECPrivateKeyParameters from the private key bytes
            Dim privateKey As New ECPrivateKeyParameters(
            "ECDSA",
            New BigInteger(1, privateKeyBytes),
            parameters)

            ' Calculate the public key from the private key
            Dim q As Org.BouncyCastle.Math.EC.ECPoint = privateKey.Parameters.G.Multiply(privateKey.D)

            ' Create ECPublicKeyParameters from the calculated public key point
            Dim publicKey As New ECPublicKeyParameters(
            "ECDSA",
            q,
            parameters)

            ' Encode public key to Base64 string in compressed format
            Dim publicKeyString As String = Convert.ToBase64String(publicKey.Q.GetEncoded(True))

            Return publicKeyString

        Catch ex As FormatException
            ' Return the error message or handle it as needed
            Return "Error: Invalid format - " & ex.Message
        Catch ex As Exception
            ' Handle other exceptions if necessary
            Return "Error: " & ex.Message
        End Try
    End Function

    Public Enum CryptoAction
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Shared Function EncryptOrDecryptFile(strInput As String, strOutputFile As String, bytKey() As Byte, bytIV() As Byte, Direction As CryptoAction) As Boolean
        Try
            ' Create a MemoryStream with the input string
            msInput = New MemoryStream(System.Text.Encoding.UTF8.GetBytes(strInput))

            ' Create a MemoryStream for output
            msOutput = New MemoryStream()

            ' Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte ' Holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 ' Running count of bytes processed
            Dim lngFileLength As Long = msInput.Length ' The input string's length
            Dim intBytesInCurrentBlock As Integer ' Current bytes being processed
            Dim csCryptoStream As CryptoStream

            ' Declare your CryptoServiceProvider.
            Dim cspRijndael As New RijndaelManaged()

            ' Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(msOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
                    Exit Select
                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(msOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
                    Exit Select
            End Select

            ' Use While to loop until all of the string is processed.
            While lngBytesProcessed < lngFileLength
                ' Read data from the input MemoryStream.
                intBytesInCurrentBlock = msInput.Read(bytBuffer, 0, 4096)

                ' Write output to the cryptostream.
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

                ' Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
            End While

            ' Close streams
            csCryptoStream.Close()
            msInput.Close()
            msOutput.Close()

            ' If encrypting, save the encrypted data to a file
            If Direction = CryptoAction.ActionEncrypt Then
                File.WriteAllBytes(strOutputFile, msOutput.ToArray())
            End If

            ' If decrypting, return the decrypted string
            If Direction = CryptoAction.ActionDecrypt Then
                Return System.Text.Encoding.UTF8.GetString(msOutput.ToArray())
            End If

            Return True
        Catch ex As Exception
            ' Handle any errors that occur during encryption or decryption
            Return False
        End Try
    End Function
End Class
