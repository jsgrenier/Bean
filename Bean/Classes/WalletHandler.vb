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
    ' Constants for encryption
    Private Const SaltSize As Integer = 16 ' Size of the salt in bytes
    Private Const Iterations As Integer = 10000 ' Number of iterations for key derivation

    Public Shared Function GenerateWallet(password As String, Optional filePath As String = Nothing) As Tuple(Of String, String)
        ' Generate the ECDSA key pair
        Dim keyPair As Tuple(Of String, String) = GenerateKeyPair()
        Dim privateKey As String = keyPair.Item1
        Dim publicKey As String = keyPair.Item2

        ' Save the wallet to a file if filePath is provided
        If Not String.IsNullOrEmpty(filePath) Then
            If Not SaveWalletToFile(privateKey, filePath, password) Then
                ' Handle the error (e.g., throw an exception or return an error message)
                Throw New Exception("Error saving wallet to file.")
            End If
        End If

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

    Public Shared Function SaveWalletToFile(privateKey As String, filePath As String, password As String) As Boolean
        Try
            ' Encrypt the private key before saving it
            Dim encryptedPrivateKey As String = EncryptPrivateKey(privateKey, password)

            ' Write the encrypted private key to the file
            File.WriteAllText(filePath, encryptedPrivateKey)
            Return True
        Catch ex As Exception
            Console.WriteLine($"Error saving wallet to file: {ex.Message}")
            Return False
        End Try
    End Function

    Public Shared Function LoadWalletFromFile(filePath As String, password As String) As String
        Try
            ' Read the encrypted private key from the file
            Dim encryptedPrivateKey As String = File.ReadAllText(filePath)

            ' Decrypt the private key
            Dim privateKey As String = DecryptPrivateKey(encryptedPrivateKey, password)
            Return privateKey
        Catch ex As Exception
            Console.WriteLine($"Error loading wallet from file: {ex.Message}")
            Return Nothing ' Or throw the exception to handle it elsewhere
        End Try
    End Function

    Private Shared Function EncryptPrivateKey(privateKey As String, password As String) As String
        Using aesAlg As Aes = Aes.Create()
            ' Generate a random salt
            Dim salt(SaltSize - 1) As Byte
            Using rngCsp As New RNGCryptoServiceProvider()
                rngCsp.GetBytes(salt)
            End Using

            aesAlg.Key = New Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256).GetBytes(aesAlg.KeySize / 8)
            aesAlg.IV = New Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256).GetBytes(aesAlg.BlockSize / 8)

            aesAlg.Mode = CipherMode.CBC
            aesAlg.Padding = PaddingMode.PKCS7

            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As New StreamWriter(csEncrypt)
                        swEncrypt.Write(privateKey)
                    End Using
                    Dim encrypted As Byte() = msEncrypt.ToArray()

                    ' Prepend the salt to the encrypted data
                    Dim dataWithSalt(salt.Length + encrypted.Length - 1) As Byte
                    Array.Copy(salt, 0, dataWithSalt, 0, salt.Length)
                    Array.Copy(encrypted, 0, dataWithSalt, salt.Length, encrypted.Length)

                    Return Convert.ToBase64String(dataWithSalt)
                End Using
            End Using
        End Using
    End Function

    Private Shared Function DecryptPrivateKey(encryptedPrivateKeyWithSalt As String, password As String) As String
        Using aesAlg As Aes = Aes.Create()
            ' Extract the salt from the beginning of the encrypted data
            Dim dataWithSalt As Byte() = Convert.FromBase64String(encryptedPrivateKeyWithSalt)
            Dim salt(SaltSize - 1) As Byte
            Dim encryptedData(dataWithSalt.Length - salt.Length - 1) As Byte
            Array.Copy(dataWithSalt, 0, salt, 0, salt.Length)
            Array.Copy(dataWithSalt, salt.Length, encryptedData, 0, encryptedData.Length)

            aesAlg.Key = New Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256).GetBytes(aesAlg.KeySize / 8)
            aesAlg.IV = New Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256).GetBytes(aesAlg.BlockSize / 8)

            aesAlg.Mode = CipherMode.CBC
            aesAlg.Padding = PaddingMode.PKCS7

            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)
            Using msDecrypt As New MemoryStream(encryptedData)
                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                    Using srDecrypt As New StreamReader(csDecrypt)
                        Return srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
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

            ' Create the transaction data string (strict formatting)
            'Dim transactionData As String = $"{fromAddress}:{toAddress}:{amount}:{tokenSymbol}"
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
End Class
