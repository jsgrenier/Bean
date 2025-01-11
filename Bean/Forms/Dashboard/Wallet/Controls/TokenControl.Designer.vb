<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TokenControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblTotalPrice = New System.Windows.Forms.Label()
        Me.LblQtySymbol = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.CoinImage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.MainPanel.SuspendLayout()
        CType(Me.CoinImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.MainPanel.BorderRadius = 10
        Me.MainPanel.BorderThickness = 1
        Me.MainPanel.Controls.Add(Me.LblTotalPrice)
        Me.MainPanel.Controls.Add(Me.LblQtySymbol)
        Me.MainPanel.Controls.Add(Me.LblPrice)
        Me.MainPanel.Controls.Add(Me.LblName)
        Me.MainPanel.Controls.Add(Me.CoinImage)
        Me.MainPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(250, 154)
        Me.MainPanel.TabIndex = 0
        '
        'LblTotalPrice
        '
        Me.LblTotalPrice.AutoEllipsis = True
        Me.LblTotalPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblTotalPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTotalPrice.Location = New System.Drawing.Point(27, 117)
        Me.LblTotalPrice.Name = "LblTotalPrice"
        Me.LblTotalPrice.Size = New System.Drawing.Size(161, 20)
        Me.LblTotalPrice.TabIndex = 4
        Me.LblTotalPrice.Text = "$0.00"
        '
        'LblQtySymbol
        '
        Me.LblQtySymbol.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblQtySymbol.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQtySymbol.Location = New System.Drawing.Point(27, 93)
        Me.LblQtySymbol.Name = "LblQtySymbol"
        Me.LblQtySymbol.Size = New System.Drawing.Size(210, 21)
        Me.LblQtySymbol.TabIndex = 3
        Me.LblQtySymbol.Text = "500.566 DOGE"
        '
        'LblPrice
        '
        Me.LblPrice.AutoEllipsis = True
        Me.LblPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblPrice.Location = New System.Drawing.Point(76, 48)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(161, 20)
        Me.LblPrice.TabIndex = 2
        Me.LblPrice.Text = "$0.00"
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(75, 19)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(162, 25)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Dogecoin"
        '
        'CoinImage
        '
        Me.CoinImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.CoinImage.FillColor = System.Drawing.Color.Empty
        Me.CoinImage.Image = Global.Bean.My.Resources.Resources.dogecoin64
        Me.CoinImage.ImageRotate = 0!
        Me.CoinImage.Location = New System.Drawing.Point(19, 19)
        Me.CoinImage.Name = "CoinImage"
        Me.CoinImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CoinImage.Size = New System.Drawing.Size(50, 50)
        Me.CoinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CoinImage.TabIndex = 0
        Me.CoinImage.TabStop = False
        '
        'TokenControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "TokenControl"
        Me.Size = New System.Drawing.Size(250, 154)
        Me.MainPanel.ResumeLayout(False)
        CType(Me.CoinImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CoinImage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents LblPrice As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblQtySymbol As Label
    Friend WithEvents LblTotalPrice As Label
End Class
