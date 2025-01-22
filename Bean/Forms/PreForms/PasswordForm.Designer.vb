<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnUnlock = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(126, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Enter your password to unlock your wallet"
        '
        'TBPassword
        '
        Me.TBPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TBPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBPassword.BorderRadius = 10
        Me.TBPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TBPassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TBPassword.DefaultText = ""
        Me.TBPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBPassword.ForeColor = System.Drawing.Color.White
        Me.TBPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBPassword.Location = New System.Drawing.Point(60, 126)
        Me.TBPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TBPassword.PlaceholderText = ""
        Me.TBPassword.SelectedText = ""
        Me.TBPassword.Size = New System.Drawing.Size(403, 45)
        Me.TBPassword.TabIndex = 0
        Me.TBPassword.TextOffset = New System.Drawing.Point(10, 0)
        Me.TBPassword.UseSystemPasswordChar = True
        '
        'BtnUnlock
        '
        Me.BtnUnlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnUnlock.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnUnlock.BorderRadius = 10
        Me.BtnUnlock.BorderThickness = 1
        Me.BtnUnlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BtnUnlock, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnUnlock.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUnlock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUnlock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUnlock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUnlock.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnUnlock.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnlock.ForeColor = System.Drawing.Color.White
        Me.BtnUnlock.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnUnlock.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnUnlock.Location = New System.Drawing.Point(203, 202)
        Me.BtnUnlock.Name = "BtnUnlock"
        Me.BtnUnlock.PressedDepth = 10
        Me.BtnUnlock.Size = New System.Drawing.Size(117, 45)
        Me.BtnUnlock.TabIndex = 4
        Me.BtnUnlock.Text = "&Unlock"
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
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Empty
        Me.Guna2PictureBox1.Image = Global.Bean.My.Resources.Resources.password_icon
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(24, 24)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 21
        Me.Guna2PictureBox1.TabStop = False
        '
        'PasswordForm
        '
        Me.AcceptButton = Me.BtnUnlock
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 273)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.BtnUnlock)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter your password"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUnlock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents StartingTimer As Timer
    Friend WithEvents TBPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
