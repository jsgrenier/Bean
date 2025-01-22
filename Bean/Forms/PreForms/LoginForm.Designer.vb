<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LoginPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCreateWallet = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnImportWallet = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LoginPanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginPanel
        '
        Me.LoginPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.LoginPanel.BorderRadius = 10
        Me.LoginPanel.BorderThickness = 1
        Me.LoginPanel.Controls.Add(Me.Label2)
        Me.LoginPanel.Controls.Add(Me.BtnCreateWallet)
        Me.LoginPanel.Controls.Add(Me.Label1)
        Me.LoginPanel.Controls.Add(Me.BtnImportWallet)
        Me.LoginPanel.Controls.Add(Me.Guna2Separator1)
        Me.LoginPanel.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me.LoginPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoginPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LoginPanel.Location = New System.Drawing.Point(5, 5)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(486, 517)
        Me.LoginPanel.TabIndex = 0
        Me.LoginPanel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(227, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Or"
        '
        'BtnCreateWallet
        '
        Me.BtnCreateWallet.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCreateWallet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnCreateWallet.BorderRadius = 10
        Me.BtnCreateWallet.BorderThickness = 1
        Me.BtnCreateWallet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BtnCreateWallet, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnCreateWallet.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreateWallet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreateWallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCreateWallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCreateWallet.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnCreateWallet.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateWallet.ForeColor = System.Drawing.Color.White
        Me.BtnCreateWallet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnCreateWallet.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnCreateWallet.Location = New System.Drawing.Point(54, 412)
        Me.BtnCreateWallet.Name = "BtnCreateWallet"
        Me.BtnCreateWallet.PressedDepth = 10
        Me.BtnCreateWallet.Size = New System.Drawing.Size(378, 45)
        Me.BtnCreateWallet.TabIndex = 4
        Me.BtnCreateWallet.Text = "Create a new wallet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose an option"
        '
        'BtnImportWallet
        '
        Me.BtnImportWallet.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnImportWallet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnImportWallet.BorderRadius = 10
        Me.BtnImportWallet.BorderThickness = 1
        Me.BtnImportWallet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BtnImportWallet, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnImportWallet.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnImportWallet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnImportWallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnImportWallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnImportWallet.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnImportWallet.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportWallet.ForeColor = System.Drawing.Color.White
        Me.BtnImportWallet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnImportWallet.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnImportWallet.Location = New System.Drawing.Point(54, 280)
        Me.BtnImportWallet.Name = "BtnImportWallet"
        Me.BtnImportWallet.PressedDepth = 10
        Me.BtnImportWallet.Size = New System.Drawing.Size(378, 45)
        Me.BtnImportWallet.TabIndex = 2
        Me.BtnImportWallet.Text = "Import your wallet"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Separator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(54, 169)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(378, 10)
        Me.Guna2Separator1.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Empty
        Me.Guna2PictureBox1.Image = Global.Bean.My.Resources.Resources.bean_icon
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(179, 18)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
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
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 527)
        Me.Controls.Add(Me.LoginPanel)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents BtnImportWallet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCreateWallet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents StartingTimer As Timer
End Class
