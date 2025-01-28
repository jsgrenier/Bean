<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfirmationForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmationForm))
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelPublicAddress = New Guna.UI2.WinForms.Guna2Panel()
        Me.CopyPublicAddress = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.IDLabel = New System.Windows.Forms.LinkLabel()
        Me.BtnDetails = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.LoadingControl1 = New Bean.LoadingControl()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPublicAddress.SuspendLayout()
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.MainPanel.BorderRadius = 10
        Me.MainPanel.BorderThickness = 1
        Me.MainPanel.Controls.Add(Me.Label7)
        Me.MainPanel.Controls.Add(Me.LabelTitle)
        Me.MainPanel.Controls.Add(Me.Guna2PictureBox1)
        Me.MainPanel.Controls.Add(Me.PanelPublicAddress)
        Me.MainPanel.Controls.Add(Me.BtnDetails)
        Me.Guna2Transition1.SetDecoration(Me.MainPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MainPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MainPanel.Location = New System.Drawing.Point(58, 58)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 50)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(653, 462)
        Me.MainPanel.TabIndex = 24
        Me.MainPanel.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(270, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 21)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Transaction ID"
        '
        'LabelTitle
        '
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.LabelTitle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.LabelTitle.Location = New System.Drawing.Point(3, 32)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(647, 37)
        Me.LabelTitle.TabIndex = 32
        Me.LabelTitle.Text = "Title"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Empty
        Me.Guna2PictureBox1.Image = Global.Bean.My.Resources.Resources.successIcon
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(276, 100)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 31
        Me.Guna2PictureBox1.TabStop = False
        '
        'PanelPublicAddress
        '
        Me.PanelPublicAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelPublicAddress.BackColor = System.Drawing.Color.Transparent
        Me.PanelPublicAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PanelPublicAddress.BorderRadius = 10
        Me.PanelPublicAddress.BorderThickness = 1
        Me.PanelPublicAddress.Controls.Add(Me.CopyPublicAddress)
        Me.PanelPublicAddress.Controls.Add(Me.IDLabel)
        Me.Guna2Transition1.SetDecoration(Me.PanelPublicAddress, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelPublicAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PanelPublicAddress.Location = New System.Drawing.Point(78, 272)
        Me.PanelPublicAddress.Name = "PanelPublicAddress"
        Me.PanelPublicAddress.ShadowDecoration.Depth = 20
        Me.PanelPublicAddress.ShadowDecoration.Enabled = True
        Me.PanelPublicAddress.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 2, 2)
        Me.PanelPublicAddress.Size = New System.Drawing.Size(496, 45)
        Me.PanelPublicAddress.TabIndex = 30
        '
        'CopyPublicAddress
        '
        Me.CopyPublicAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyPublicAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CopyPublicAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.CopyPublicAddress, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CopyPublicAddress.FillColor = System.Drawing.Color.Empty
        Me.CopyPublicAddress.Image = Global.Bean.My.Resources.Resources.copy_24
        Me.CopyPublicAddress.ImageRotate = 0!
        Me.CopyPublicAddress.Location = New System.Drawing.Point(456, 10)
        Me.CopyPublicAddress.Name = "CopyPublicAddress"
        Me.CopyPublicAddress.Size = New System.Drawing.Size(24, 24)
        Me.CopyPublicAddress.TabIndex = 0
        Me.CopyPublicAddress.TabStop = False
        '
        'IDLabel
        '
        Me.IDLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.IDLabel.AutoEllipsis = True
        Me.IDLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.IDLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IDLabel.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.IDLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.IDLabel.Location = New System.Drawing.Point(10, 9)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(476, 25)
        Me.IDLabel.TabIndex = 16
        Me.IDLabel.TabStop = True
        Me.IDLabel.Text = "ad4bcf728b134652ac70419a6b4a13c6"
        Me.IDLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnDetails
        '
        Me.BtnDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnDetails.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnDetails.BorderRadius = 10
        Me.BtnDetails.BorderThickness = 1
        Me.BtnDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BtnDetails, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDetails.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnDetails.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetails.ForeColor = System.Drawing.Color.White
        Me.BtnDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnDetails.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnDetails.Location = New System.Drawing.Point(262, 374)
        Me.BtnDetails.Name = "BtnDetails"
        Me.BtnDetails.PressedDepth = 10
        Me.BtnDetails.Size = New System.Drawing.Size(129, 45)
        Me.BtnDetails.TabIndex = 29
        Me.BtnDetails.Text = "View details"
        '
        'Guna2Panel1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 540)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1049, 50)
        Me.Guna2Panel1.TabIndex = 26
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'LoadingControl1
        '
        Me.LoadingControl1.AnimationSpeed = 20
        Me.LoadingControl1.ArcColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LoadingControl1.ArcLength = 120
        Me.LoadingControl1.ArcThickness = 10
        Me.LoadingControl1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.LoadingControl1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoadingControl1.Location = New System.Drawing.Point(288, 181)
        Me.LoadingControl1.Name = "LoadingControl1"
        Me.LoadingControl1.PaddingSize = 10
        Me.LoadingControl1.Size = New System.Drawing.Size(100, 100)
        Me.LoadingControl1.TabIndex = 28
        '
        'StartingTimer
        '
        Me.StartingTimer.Interval = 1000
        '
        'ConfirmationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1049, 590)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.LoadingControl1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConfirmationForm"
        Me.Text = "SendForm"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPublicAddress.ResumeLayout(False)
        CType(Me.CopyPublicAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnDetails As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelPublicAddress As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CopyPublicAddress As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents IDLabel As LinkLabel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LoadingControl1 As LoadingControl
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents StartingTimer As Timer
End Class
