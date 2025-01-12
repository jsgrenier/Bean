<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReceiveForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TopPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.PanelPublicAddress = New Guna.UI2.WinForms.Guna2Panel()
        Me.CopyPublicKey = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TBPublicAddress = New System.Windows.Forms.TextBox()
        Me.PBWalletQR = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TopPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.PanelPublicAddress.SuspendLayout()
        CType(Me.CopyPublicKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBWalletQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.LblTitle)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1015, 100)
        Me.TopPanel.TabIndex = 27
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LblTitle.Location = New System.Drawing.Point(58, 32)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(208, 37)
        Me.LblTitle.TabIndex = 20
        Me.LblTitle.Text = "Receive tokens"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 580)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1015, 10)
        Me.Guna2Panel1.TabIndex = 29
        '
        'MainPanel
        '
        Me.MainPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.MainPanel.BorderRadius = 10
        Me.MainPanel.BorderThickness = 1
        Me.MainPanel.Controls.Add(Me.PanelPublicAddress)
        Me.MainPanel.Controls.Add(Me.PBWalletQR)
        Me.MainPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MainPanel.Location = New System.Drawing.Point(58, 101)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 50)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(653, 456)
        Me.MainPanel.TabIndex = 30
        '
        'PanelPublicAddress
        '
        Me.PanelPublicAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelPublicAddress.BackColor = System.Drawing.Color.Transparent
        Me.PanelPublicAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PanelPublicAddress.BorderRadius = 10
        Me.PanelPublicAddress.BorderThickness = 1
        Me.PanelPublicAddress.Controls.Add(Me.CopyPublicKey)
        Me.PanelPublicAddress.Controls.Add(Me.TBPublicAddress)
        Me.PanelPublicAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PanelPublicAddress.Location = New System.Drawing.Point(70, 357)
        Me.PanelPublicAddress.Name = "PanelPublicAddress"
        Me.PanelPublicAddress.ShadowDecoration.Depth = 20
        Me.PanelPublicAddress.ShadowDecoration.Enabled = True
        Me.PanelPublicAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.PanelPublicAddress.Size = New System.Drawing.Size(513, 45)
        Me.PanelPublicAddress.TabIndex = 19
        '
        'CopyPublicKey
        '
        Me.CopyPublicKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyPublicKey.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CopyPublicKey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyPublicKey.FillColor = System.Drawing.Color.Empty
        Me.CopyPublicKey.Image = Global.Bean.My.Resources.Resources.copy_24
        Me.CopyPublicKey.ImageRotate = 0!
        Me.CopyPublicKey.Location = New System.Drawing.Point(473, 10)
        Me.CopyPublicKey.Name = "CopyPublicKey"
        Me.CopyPublicKey.Size = New System.Drawing.Size(24, 24)
        Me.CopyPublicKey.TabIndex = 0
        Me.CopyPublicKey.TabStop = False
        '
        'TBPublicAddress
        '
        Me.TBPublicAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBPublicAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBPublicAddress.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TBPublicAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TBPublicAddress.Location = New System.Drawing.Point(17, 13)
        Me.TBPublicAddress.Name = "TBPublicAddress"
        Me.TBPublicAddress.ReadOnly = True
        Me.TBPublicAddress.Size = New System.Drawing.Size(450, 20)
        Me.TBPublicAddress.TabIndex = 5
        '
        'PBWalletQR
        '
        Me.PBWalletQR.BackColor = System.Drawing.Color.Transparent
        Me.PBWalletQR.BorderRadius = 10
        Me.PBWalletQR.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PBWalletQR.ImageRotate = 0!
        Me.PBWalletQR.Location = New System.Drawing.Point(176, 28)
        Me.PBWalletQR.Name = "PBWalletQR"
        Me.PBWalletQR.Size = New System.Drawing.Size(300, 300)
        Me.PBWalletQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBWalletQR.TabIndex = 0
        Me.PBWalletQR.TabStop = False
        '
        'ReceiveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 590)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReceiveForm"
        Me.Text = "ReceiveForm"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.PanelPublicAddress.ResumeLayout(False)
        Me.PanelPublicAddress.PerformLayout()
        CType(Me.CopyPublicKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBWalletQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PBWalletQR As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PanelPublicAddress As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CopyPublicKey As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TBPublicAddress As TextBox
End Class
