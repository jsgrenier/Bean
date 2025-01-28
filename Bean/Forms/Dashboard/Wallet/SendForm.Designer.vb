<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendForm
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.CBTokens = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.BtnSend = New Guna.UI2.WinForms.Guna2Button()
        Me.LblRecipient = New System.Windows.Forms.Label()
        Me.TBRecipient = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblAmount = New System.Windows.Forms.Label()
        Me.TBAmount = New Bean.NumericTextbox()
        Me.TBContextMenu = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.LblToken = New System.Windows.Forms.Label()
        Me.LoadingControl1 = New Bean.LoadingControl()
        Me.TopPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MainPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LblTitle.Location = New System.Drawing.Point(58, 32)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(173, 37)
        Me.LblTitle.TabIndex = 20
        Me.LblTitle.Text = "Send tokens"
        '
        'CBTokens
        '
        Me.CBTokens.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBTokens.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.CBTokens.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.CBTokens.BorderRadius = 10
        Me.CBTokens.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBTokens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTokens.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CBTokens.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBTokens.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBTokens.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.CBTokens.ForeColor = System.Drawing.Color.White
        Me.CBTokens.ItemHeight = 39
        Me.CBTokens.Location = New System.Drawing.Point(80, 60)
        Me.CBTokens.Name = "CBTokens"
        Me.CBTokens.Size = New System.Drawing.Size(346, 45)
        Me.CBTokens.TabIndex = 23
        Me.CBTokens.TextOffset = New System.Drawing.Point(10, 0)
        '
        'MainPanel
        '
        Me.MainPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.MainPanel.BorderRadius = 10
        Me.MainPanel.BorderThickness = 1
        Me.MainPanel.Controls.Add(Me.LabelError)
        Me.MainPanel.Controls.Add(Me.BtnSend)
        Me.MainPanel.Controls.Add(Me.LblRecipient)
        Me.MainPanel.Controls.Add(Me.TBRecipient)
        Me.MainPanel.Controls.Add(Me.LblAmount)
        Me.MainPanel.Controls.Add(Me.TBAmount)
        Me.MainPanel.Controls.Add(Me.LblToken)
        Me.MainPanel.Controls.Add(Me.CBTokens)
        Me.MainPanel.Controls.Add(Me.LoadingControl1)
        Me.MainPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MainPanel.Location = New System.Drawing.Point(58, 101)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 50)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(653, 480)
        Me.MainPanel.TabIndex = 24
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LabelError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.LabelError.Location = New System.Drawing.Point(200, 401)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(41, 20)
        Me.LabelError.TabIndex = 30
        Me.LabelError.Text = "Error"
        Me.LabelError.Visible = False
        '
        'BtnSend
        '
        Me.BtnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSend.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSend.BorderRadius = 10
        Me.BtnSend.BorderThickness = 1
        Me.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSend.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.White
        Me.BtnSend.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSend.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnSend.Location = New System.Drawing.Point(80, 389)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.PressedDepth = 10
        Me.BtnSend.Size = New System.Drawing.Size(114, 45)
        Me.BtnSend.TabIndex = 29
        Me.BtnSend.Text = "Send"
        '
        'LblRecipient
        '
        Me.LblRecipient.AutoSize = True
        Me.LblRecipient.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblRecipient.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecipient.Location = New System.Drawing.Point(76, 248)
        Me.LblRecipient.Name = "LblRecipient"
        Me.LblRecipient.Size = New System.Drawing.Size(72, 20)
        Me.LblRecipient.TabIndex = 28
        Me.LblRecipient.Text = "Recipient"
        '
        'TBRecipient
        '
        Me.TBRecipient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBRecipient.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBRecipient.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBRecipient.BorderRadius = 10
        Me.TBRecipient.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBRecipient.DefaultText = ""
        Me.TBRecipient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBRecipient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBRecipient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBRecipient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBRecipient.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBRecipient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBRecipient.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBRecipient.ForeColor = System.Drawing.Color.White
        Me.TBRecipient.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBRecipient.Location = New System.Drawing.Point(80, 280)
        Me.TBRecipient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBRecipient.Name = "TBRecipient"
        Me.TBRecipient.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBRecipient.PlaceholderText = ""
        Me.TBRecipient.SelectedText = ""
        Me.TBRecipient.Size = New System.Drawing.Size(518, 45)
        Me.TBRecipient.TabIndex = 27
        Me.TBRecipient.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblAmount
        '
        Me.LblAmount.AutoSize = True
        Me.LblAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmount.Location = New System.Drawing.Point(76, 138)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(64, 20)
        Me.LblAmount.TabIndex = 26
        Me.LblAmount.Text = "Amount"
        '
        'TBAmount
        '
        Me.TBAmount.AllowDecimals = True
        Me.TBAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBAmount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBAmount.BorderRadius = 10
        Me.TBAmount.ContextMenuStrip = Me.TBContextMenu
        Me.TBAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBAmount.DefaultText = ""
        Me.TBAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBAmount.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAmount.ForeColor = System.Drawing.Color.White
        Me.TBAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBAmount.Location = New System.Drawing.Point(80, 170)
        Me.TBAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBAmount.MaxLength = 19
        Me.TBAmount.Name = "TBAmount"
        Me.TBAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBAmount.PlaceholderText = ""
        Me.TBAmount.SelectedText = ""
        Me.TBAmount.Size = New System.Drawing.Size(346, 45)
        Me.TBAmount.TabIndex = 25
        Me.TBAmount.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TBContextMenu
        '
        Me.TBContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBContextMenu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBContextMenu.Name = "TBContextMenu"
        Me.TBContextMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBContextMenu.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBContextMenu.RenderStyle.ColorTable = Nothing
        Me.TBContextMenu.RenderStyle.RoundedEdges = True
        Me.TBContextMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.TBContextMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TBContextMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.TBContextMenu.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBContextMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.TBContextMenu.ShowImageMargin = False
        Me.TBContextMenu.Size = New System.Drawing.Size(36, 4)
        '
        'LblToken
        '
        Me.LblToken.AutoSize = True
        Me.LblToken.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblToken.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblToken.Location = New System.Drawing.Point(76, 28)
        Me.LblToken.Name = "LblToken"
        Me.LblToken.Size = New System.Drawing.Size(50, 20)
        Me.LblToken.TabIndex = 24
        Me.LblToken.Text = "Token"
        '
        'LoadingControl1
        '
        Me.LoadingControl1.AnimationSpeed = 16
        Me.LoadingControl1.ArcColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.LoadingControl1.ArcLength = 120
        Me.LoadingControl1.ArcThickness = 5
        Me.LoadingControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LoadingControl1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LoadingControl1.Location = New System.Drawing.Point(114, 389)
        Me.LoadingControl1.Name = "LoadingControl1"
        Me.LoadingControl1.PaddingSize = 10
        Me.LoadingControl1.Size = New System.Drawing.Size(45, 45)
        Me.LoadingControl1.TabIndex = 21
        Me.LoadingControl1.Visible = False
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.LblTitle)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1117, 100)
        Me.TopPanel.TabIndex = 25
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 581)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1117, 10)
        Me.Guna2Panel1.TabIndex = 26
        '
        'SendForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1134, 590)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SendForm"
        Me.Text = "SendForm"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitle As Label
    Friend WithEvents CBTokens As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblToken As Label
    Friend WithEvents LblAmount As Label
    Friend WithEvents TBAmount As NumericTextbox
    Friend WithEvents LblRecipient As Label
    Friend WithEvents TBRecipient As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LoadingControl1 As LoadingControl
    Friend WithEvents LabelError As Label
    Friend WithEvents TBContextMenu As Guna.UI2.WinForms.Guna2ContextMenuStrip
End Class
