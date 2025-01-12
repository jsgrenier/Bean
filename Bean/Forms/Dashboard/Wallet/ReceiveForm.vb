Imports QRCoder

Public Class ReceiveForm
    Private _privateKey As String

    Public Sub New(privatekey As String)
        InitializeComponent()
        _privateKey = privatekey
        ' Add any initialization after the InitializeComponent() call.
        TBPublicAddress.Text = WalletHandler.GetPublicKeyFromPrivateKey(privatekey)
    End Sub

    Private Sub TBPublicAddress_TextChanged(sender As Object, e As EventArgs) Handles TBPublicAddress.TextChanged
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(TBPublicAddress.Text, QRCodeGenerator.ECCLevel.Q)

        Dim qrCode As New QRCode(qrCodeData)

        Dim moduleSize As Integer = 300 \ qrCodeData.ModuleMatrix.Count

        ' Get the QR code as a Bitmap
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(moduleSize)

        PBWalletQR.Image = qrCodeImage
    End Sub
End Class