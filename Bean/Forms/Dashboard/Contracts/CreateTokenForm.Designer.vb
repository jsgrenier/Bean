<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateTokenForm
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
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblSupply = New System.Windows.Forms.Label()
        Me.TBTokenName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TBContextMenu = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.TBOwnerAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.BtnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.LblSymbol = New System.Windows.Forms.Label()
        Me.TBTokenSymbol = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TBSupply = New Bean.NumericTextbox()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LoadingControl1 = New Bean.LoadingControl()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TopPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.LblTitle)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1202, 100)
        Me.TopPanel.TabIndex = 26
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LblTitle.Location = New System.Drawing.Point(58, 32)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(204, 37)
        Me.LblTitle.TabIndex = 20
        Me.LblTitle.Text = "Create a token"
        '
        'MainPanel
        '
        Me.MainPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.MainPanel.BorderRadius = 10
        Me.MainPanel.BorderThickness = 1
        Me.MainPanel.Controls.Add(Me.LblSupply)
        Me.MainPanel.Controls.Add(Me.TBTokenName)
        Me.MainPanel.Controls.Add(Me.TBOwnerAddress)
        Me.MainPanel.Controls.Add(Me.LabelError)
        Me.MainPanel.Controls.Add(Me.BtnCreate)
        Me.MainPanel.Controls.Add(Me.LblSymbol)
        Me.MainPanel.Controls.Add(Me.TBTokenSymbol)
        Me.MainPanel.Controls.Add(Me.LblName)
        Me.MainPanel.Controls.Add(Me.TBSupply)
        Me.MainPanel.Controls.Add(Me.LblAddress)
        Me.MainPanel.Controls.Add(Me.LoadingControl1)
        Me.MainPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MainPanel.Location = New System.Drawing.Point(58, 101)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 50)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(653, 591)
        Me.MainPanel.TabIndex = 27
        '
        'LblSupply
        '
        Me.LblSupply.AutoSize = True
        Me.LblSupply.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblSupply.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSupply.Location = New System.Drawing.Point(76, 358)
        Me.LblSupply.Name = "LblSupply"
        Me.LblSupply.Size = New System.Drawing.Size(96, 20)
        Me.LblSupply.TabIndex = 33
        Me.LblSupply.Text = "Initial supply"
        '
        'TBTokenName
        '
        Me.TBTokenName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBTokenName.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBTokenName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBTokenName.BorderRadius = 10
        Me.TBTokenName.ContextMenuStrip = Me.TBContextMenu
        Me.TBTokenName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBTokenName.DefaultText = ""
        Me.TBTokenName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBTokenName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBTokenName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBTokenName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBTokenName.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBTokenName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBTokenName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBTokenName.ForeColor = System.Drawing.Color.White
        Me.TBTokenName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBTokenName.Location = New System.Drawing.Point(80, 170)
        Me.TBTokenName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBTokenName.Name = "TBTokenName"
        Me.TBTokenName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBTokenName.PlaceholderText = ""
        Me.TBTokenName.SelectedText = ""
        Me.TBTokenName.Size = New System.Drawing.Size(257, 45)
        Me.TBTokenName.TabIndex = 1
        Me.TBTokenName.TextOffset = New System.Drawing.Point(10, 0)
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
        'TBOwnerAddress
        '
        Me.TBOwnerAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBOwnerAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBOwnerAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBOwnerAddress.BorderRadius = 10
        Me.TBOwnerAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBOwnerAddress.DefaultText = ""
        Me.TBOwnerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBOwnerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBOwnerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBOwnerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBOwnerAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBOwnerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBOwnerAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBOwnerAddress.ForeColor = System.Drawing.Color.White
        Me.TBOwnerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBOwnerAddress.Location = New System.Drawing.Point(80, 60)
        Me.TBOwnerAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBOwnerAddress.Name = "TBOwnerAddress"
        Me.TBOwnerAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBOwnerAddress.PlaceholderText = ""
        Me.TBOwnerAddress.SelectedText = ""
        Me.TBOwnerAddress.Size = New System.Drawing.Size(518, 45)
        Me.TBOwnerAddress.TabIndex = 0
        Me.TBOwnerAddress.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LabelError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.LabelError.Location = New System.Drawing.Point(210, 512)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(41, 20)
        Me.LabelError.TabIndex = 30
        Me.LabelError.Text = "Error"
        Me.LabelError.Visible = False
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCreate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnCreate.BorderRadius = 10
        Me.BtnCreate.BorderThickness = 1
        Me.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnCreate.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.ForeColor = System.Drawing.Color.White
        Me.BtnCreate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BtnCreate.Location = New System.Drawing.Point(80, 500)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.PressedDepth = 10
        Me.BtnCreate.Size = New System.Drawing.Size(124, 45)
        Me.BtnCreate.TabIndex = 4
        Me.BtnCreate.Text = "Create token"
        '
        'LblSymbol
        '
        Me.LblSymbol.AutoSize = True
        Me.LblSymbol.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblSymbol.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSymbol.Location = New System.Drawing.Point(76, 248)
        Me.LblSymbol.Name = "LblSymbol"
        Me.LblSymbol.Size = New System.Drawing.Size(166, 20)
        Me.LblSymbol.TabIndex = 28
        Me.LblSymbol.Text = "Token symbol (eg. BTC)"
        '
        'TBTokenSymbol
        '
        Me.TBTokenSymbol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBTokenSymbol.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBTokenSymbol.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBTokenSymbol.BorderRadius = 10
        Me.TBTokenSymbol.ContextMenuStrip = Me.TBContextMenu
        Me.TBTokenSymbol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBTokenSymbol.DefaultText = ""
        Me.TBTokenSymbol.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBTokenSymbol.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBTokenSymbol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBTokenSymbol.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBTokenSymbol.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBTokenSymbol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBTokenSymbol.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBTokenSymbol.ForeColor = System.Drawing.Color.White
        Me.TBTokenSymbol.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBTokenSymbol.Location = New System.Drawing.Point(80, 280)
        Me.TBTokenSymbol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBTokenSymbol.MaxLength = 5
        Me.TBTokenSymbol.Name = "TBTokenSymbol"
        Me.TBTokenSymbol.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBTokenSymbol.PlaceholderText = ""
        Me.TBTokenSymbol.SelectedText = ""
        Me.TBTokenSymbol.Size = New System.Drawing.Size(257, 45)
        Me.TBTokenSymbol.TabIndex = 2
        Me.TBTokenSymbol.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(76, 138)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(178, 20)
        Me.LblName.TabIndex = 26
        Me.LblName.Text = "Token name (eg. Bitcoin)"
        '
        'TBSupply
        '
        Me.TBSupply.AllowDecimals = True
        Me.TBSupply.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TBSupply.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TBSupply.BorderRadius = 10
        Me.TBSupply.ContextMenuStrip = Me.TBContextMenu
        Me.TBSupply.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBSupply.DefaultText = ""
        Me.TBSupply.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBSupply.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBSupply.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TBSupply.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBSupply.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSupply.ForeColor = System.Drawing.Color.White
        Me.TBSupply.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBSupply.Location = New System.Drawing.Point(80, 390)
        Me.TBSupply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBSupply.MaxLength = 19
        Me.TBSupply.Name = "TBSupply"
        Me.TBSupply.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBSupply.PlaceholderText = ""
        Me.TBSupply.SelectedText = ""
        Me.TBSupply.Size = New System.Drawing.Size(257, 45)
        Me.TBSupply.TabIndex = 3
        Me.TBSupply.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddress.Location = New System.Drawing.Point(76, 28)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(110, 20)
        Me.LblAddress.TabIndex = 24
        Me.LblAddress.Text = "Owner address"
        '
        'LoadingControl1
        '
        Me.LoadingControl1.AnimationSpeed = 16
        Me.LoadingControl1.ArcColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.LoadingControl1.ArcLength = 120
        Me.LoadingControl1.ArcThickness = 5
        Me.LoadingControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LoadingControl1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LoadingControl1.Location = New System.Drawing.Point(120, 500)
        Me.LoadingControl1.Name = "LoadingControl1"
        Me.LoadingControl1.PaddingSize = 10
        Me.LoadingControl1.Size = New System.Drawing.Size(45, 45)
        Me.LoadingControl1.TabIndex = 21
        Me.LoadingControl1.Visible = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 692)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1202, 10)
        Me.Guna2Panel1.TabIndex = 28
        '
        'CreateTokenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1219, 590)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateTokenForm"
        Me.Text = "CreateTokenForm"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelError As Label
    Friend WithEvents BtnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblSymbol As Label
    Friend WithEvents TBTokenSymbol As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents TBSupply As NumericTextbox
    Friend WithEvents LblAddress As Label
    Friend WithEvents LoadingControl1 As LoadingControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TBTokenName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TBOwnerAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblSupply As Label
    Friend WithEvents TBContextMenu As Guna.UI2.WinForms.Guna2ContextMenuStrip
End Class
