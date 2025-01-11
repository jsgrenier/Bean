<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingForm))
        Me.LoadingPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnRetry = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.PBValidating = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.PBKey = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PBChain = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PBNetwork = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ValidatingProcess = New System.Windows.Forms.Timer(Me.components)
        Me.WalletConnector = New System.Windows.Forms.Timer(Me.components)
        Me.LoadingPanel.SuspendLayout()
        CType(Me.PBKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBChain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBNetwork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingPanel
        '
        Me.LoadingPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.LoadingPanel.BorderRadius = 10
        Me.LoadingPanel.BorderThickness = 1
        Me.LoadingPanel.Controls.Add(Me.BtnRetry)
        Me.LoadingPanel.Controls.Add(Me.BtnExit)
        Me.LoadingPanel.Controls.Add(Me.PBValidating)
        Me.LoadingPanel.Controls.Add(Me.PBKey)
        Me.LoadingPanel.Controls.Add(Me.PBChain)
        Me.LoadingPanel.Controls.Add(Me.PBNetwork)
        Me.LoadingPanel.Controls.Add(Me.Label4)
        Me.LoadingPanel.Controls.Add(Me.Label3)
        Me.LoadingPanel.Controls.Add(Me.Label2)
        Me.LoadingPanel.Controls.Add(Me.LabelTitle)
        Me.Guna2Transition1.SetDecoration(Me.LoadingPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoadingPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LoadingPanel.Location = New System.Drawing.Point(5, 5)
        Me.LoadingPanel.Name = "LoadingPanel"
        Me.LoadingPanel.Size = New System.Drawing.Size(453, 506)
        Me.LoadingPanel.TabIndex = 0
        Me.LoadingPanel.Visible = False
        '
        'BtnRetry
        '
        Me.BtnRetry.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnRetry.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnRetry.BorderRadius = 10
        Me.BtnRetry.BorderThickness = 1
        Me.BtnRetry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BtnRetry, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnRetry.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRetry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRetry.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRetry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRetry.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnRetry.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetry.ForeColor = System.Drawing.Color.White
        Me.BtnRetry.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnRetry.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnRetry.Location = New System.Drawing.Point(298, 430)
        Me.BtnRetry.Name = "BtnRetry"
        Me.BtnRetry.PressedDepth = 10
        Me.BtnRetry.Size = New System.Drawing.Size(100, 45)
        Me.BtnRetry.TabIndex = 12
        Me.BtnRetry.Text = "Retry"
        Me.BtnRetry.Visible = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnExit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnExit.BorderRadius = 10
        Me.BtnExit.BorderThickness = 1
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BtnExit, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnExit.Location = New System.Drawing.Point(54, 430)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.PressedDepth = 10
        Me.BtnExit.Size = New System.Drawing.Size(100, 45)
        Me.BtnExit.TabIndex = 13
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.Visible = False
        '
        'PBValidating
        '
        Me.PBValidating.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.PBValidating, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PBValidating.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PBValidating.FillThickness = 15
        Me.PBValidating.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PBValidating.ForeColor = System.Drawing.Color.White
        Me.PBValidating.Location = New System.Drawing.Point(176, 126)
        Me.PBValidating.Minimum = 0
        Me.PBValidating.Name = "PBValidating"
        Me.PBValidating.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PBValidating.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PBValidating.ProgressThickness = 15
        Me.PBValidating.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PBValidating.Size = New System.Drawing.Size(100, 100)
        Me.PBValidating.TabIndex = 12
        Me.PBValidating.Text = "Guna2CircleProgressBar1"
        '
        'PBKey
        '
        Me.PBKey.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.PBKey, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PBKey.FillColor = System.Drawing.Color.Empty
        Me.PBKey.ImageRotate = 0!
        Me.PBKey.Location = New System.Drawing.Point(298, 364)
        Me.PBKey.Name = "PBKey"
        Me.PBKey.Size = New System.Drawing.Size(24, 24)
        Me.PBKey.TabIndex = 11
        Me.PBKey.TabStop = False
        '
        'PBChain
        '
        Me.PBChain.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.PBChain, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PBChain.FillColor = System.Drawing.Color.Empty
        Me.PBChain.ImageRotate = 0!
        Me.PBChain.Location = New System.Drawing.Point(298, 316)
        Me.PBChain.Name = "PBChain"
        Me.PBChain.Size = New System.Drawing.Size(24, 24)
        Me.PBChain.TabIndex = 10
        Me.PBChain.TabStop = False
        '
        'PBNetwork
        '
        Me.PBNetwork.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.PBNetwork, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PBNetwork.FillColor = System.Drawing.Color.Empty
        Me.PBNetwork.ImageRotate = 0!
        Me.PBNetwork.Location = New System.Drawing.Point(298, 267)
        Me.PBNetwork.Name = "PBNetwork"
        Me.PBNetwork.Size = New System.Drawing.Size(24, 24)
        Me.PBNetwork.TabIndex = 9
        Me.PBNetwork.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Location = New System.Drawing.Point(210, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Key is valid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Location = New System.Drawing.Point(163, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Blockchain is valid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Location = New System.Drawing.Point(130, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Blockchain is reachable"
        '
        'LabelTitle
        '
        Me.LabelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.LabelTitle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(7, 57)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(439, 32)
        Me.LabelTitle.TabIndex = 4
        Me.LabelTitle.Text = "Connecting to the blockchain..."
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'StartingTimer
        '
        '
        'ValidatingProcess
        '
        '
        'WalletConnector
        '
        Me.WalletConnector.Interval = 3000
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(463, 516)
        Me.Controls.Add(Me.LoadingPanel)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadingForm"
        Me.Text = "LoadingForm"
        Me.LoadingPanel.ResumeLayout(False)
        Me.LoadingPanel.PerformLayout()
        CType(Me.PBKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBChain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBNetwork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadingPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents StartingTimer As Timer
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PBNetwork As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PBKey As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PBChain As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PBValidating As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents ValidatingProcess As Timer
    Friend WithEvents BtnRetry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents WalletConnector As Timer
End Class
