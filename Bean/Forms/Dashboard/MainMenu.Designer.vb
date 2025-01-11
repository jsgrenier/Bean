<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ContentPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.TopPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.TopMenuPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.LeftPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnWallet = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnExplorer = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnContracts = New Guna.UI2.WinForms.Guna2Button()
        Me.TopLeftPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.PBLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.FlowMenu.SuspendLayout()
        Me.TopLeftPanel.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.AutoScroll = True
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.ContentPanel)
        Me.MainPanel.Controls.Add(Me.TopPanel)
        Me.MainPanel.Controls.Add(Me.LeftPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1200, 730)
        Me.MainPanel.TabIndex = 0
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ContentPanel.BorderRadius = 10
        Me.ContentPanel.CustomizableEdges.BottomLeft = False
        Me.ContentPanel.CustomizableEdges.BottomRight = False
        Me.ContentPanel.CustomizableEdges.TopRight = False
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ContentPanel.Location = New System.Drawing.Point(185, 140)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(1015, 590)
        Me.ContentPanel.TabIndex = 2
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.TopMenuPanel)
        Me.TopPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TopPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TopPanel.Location = New System.Drawing.Point(185, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1015, 140)
        Me.TopPanel.TabIndex = 1
        '
        'TopMenuPanel
        '
        Me.TopMenuPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopMenuPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TopMenuPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TopMenuPanel.Location = New System.Drawing.Point(0, 94)
        Me.TopMenuPanel.Name = "TopMenuPanel"
        Me.TopMenuPanel.Size = New System.Drawing.Size(1015, 45)
        Me.TopMenuPanel.TabIndex = 0
        '
        'LeftPanel
        '
        Me.LeftPanel.Controls.Add(Me.FlowMenu)
        Me.LeftPanel.Controls.Add(Me.TopLeftPanel)
        Me.LeftPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.LeftPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(185, 730)
        Me.LeftPanel.TabIndex = 0
        '
        'FlowMenu
        '
        Me.FlowMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.FlowMenu.Controls.Add(Me.BtnWallet)
        Me.FlowMenu.Controls.Add(Me.BtnExplorer)
        Me.FlowMenu.Controls.Add(Me.BtnContracts)
        Me.FlowMenu.Location = New System.Drawing.Point(0, 140)
        Me.FlowMenu.Name = "FlowMenu"
        Me.FlowMenu.Size = New System.Drawing.Size(184, 357)
        Me.FlowMenu.TabIndex = 3
        '
        'BtnWallet
        '
        Me.BtnWallet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnWallet.BorderRadius = 10
        Me.BtnWallet.BorderThickness = 1
        Me.BtnWallet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnWallet.Checked = True
        Me.BtnWallet.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnWallet.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnWallet.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnWallet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWallet.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.wallet_white
        Me.BtnWallet.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.wallet_hover
        Me.BtnWallet.CustomImages.Image = Global.Bean.My.Resources.Resources.wallet_gray
        Me.BtnWallet.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnWallet.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnWallet.CustomizableEdges.BottomRight = False
        Me.BtnWallet.CustomizableEdges.TopRight = False
        Me.BtnWallet.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnWallet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnWallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnWallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnWallet.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnWallet.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWallet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnWallet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnWallet.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnWallet.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnWallet.Location = New System.Drawing.Point(15, 0)
        Me.BtnWallet.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.BtnWallet.Name = "BtnWallet"
        Me.BtnWallet.PressedDepth = 0
        Me.BtnWallet.Size = New System.Drawing.Size(170, 45)
        Me.BtnWallet.TabIndex = 0
        Me.BtnWallet.Text = "Wallet"
        Me.BtnWallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnWallet.TextOffset = New System.Drawing.Point(30, 0)
        '
        'BtnExplorer
        '
        Me.BtnExplorer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnExplorer.BorderRadius = 10
        Me.BtnExplorer.BorderThickness = 1
        Me.BtnExplorer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnExplorer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnExplorer.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnExplorer.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnExplorer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExplorer.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.explorer_white
        Me.BtnExplorer.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.explorer_hover
        Me.BtnExplorer.CustomImages.Image = Global.Bean.My.Resources.Resources.explorer_gray
        Me.BtnExplorer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnExplorer.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnExplorer.CustomizableEdges.BottomRight = False
        Me.BtnExplorer.CustomizableEdges.TopRight = False
        Me.BtnExplorer.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnExplorer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnExplorer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnExplorer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnExplorer.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnExplorer.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExplorer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExplorer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnExplorer.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnExplorer.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnExplorer.Location = New System.Drawing.Point(15, 55)
        Me.BtnExplorer.Margin = New System.Windows.Forms.Padding(15, 10, 0, 0)
        Me.BtnExplorer.Name = "BtnExplorer"
        Me.BtnExplorer.PressedDepth = 0
        Me.BtnExplorer.Size = New System.Drawing.Size(170, 45)
        Me.BtnExplorer.TabIndex = 1
        Me.BtnExplorer.Text = "Block Explorer"
        Me.BtnExplorer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnExplorer.TextOffset = New System.Drawing.Point(30, 0)
        '
        'BtnContracts
        '
        Me.BtnContracts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnContracts.BorderRadius = 10
        Me.BtnContracts.BorderThickness = 1
        Me.BtnContracts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnContracts.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnContracts.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnContracts.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnContracts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnContracts.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.contracts_white
        Me.BtnContracts.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.contracts_hover
        Me.BtnContracts.CustomImages.Image = Global.Bean.My.Resources.Resources.contracts_gray
        Me.BtnContracts.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnContracts.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnContracts.CustomizableEdges.BottomRight = False
        Me.BtnContracts.CustomizableEdges.TopRight = False
        Me.BtnContracts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnContracts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnContracts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnContracts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnContracts.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnContracts.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContracts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnContracts.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnContracts.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnContracts.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnContracts.Location = New System.Drawing.Point(15, 110)
        Me.BtnContracts.Margin = New System.Windows.Forms.Padding(15, 10, 0, 0)
        Me.BtnContracts.Name = "BtnContracts"
        Me.BtnContracts.PressedDepth = 0
        Me.BtnContracts.Size = New System.Drawing.Size(170, 45)
        Me.BtnContracts.TabIndex = 2
        Me.BtnContracts.Text = "Smart Contracts"
        Me.BtnContracts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnContracts.TextOffset = New System.Drawing.Point(30, 0)
        '
        'TopLeftPanel
        '
        Me.TopLeftPanel.Controls.Add(Me.PBLogo)
        Me.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopLeftPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TopLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopLeftPanel.Name = "TopLeftPanel"
        Me.TopLeftPanel.Size = New System.Drawing.Size(185, 140)
        Me.TopLeftPanel.TabIndex = 2
        '
        'PBLogo
        '
        Me.PBLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PBLogo.FillColor = System.Drawing.Color.Empty
        Me.PBLogo.Image = Global.Bean.My.Resources.Resources.bean_icon
        Me.PBLogo.ImageRotate = 0!
        Me.PBLogo.Location = New System.Drawing.Point(42, 20)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(100, 100)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 1
        Me.PBLogo.TabStop = False
        '
        'StartingTimer
        '
        Me.StartingTimer.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 730)
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "MainMenu"
        Me.Text = "Bean"
        Me.MainPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.LeftPanel.ResumeLayout(False)
        Me.FlowMenu.ResumeLayout(False)
        Me.TopLeftPanel.ResumeLayout(False)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents StartingTimer As Timer
    Friend WithEvents LeftPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ContentPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PBLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TopLeftPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TopMenuPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowMenu As FlowLayoutPanel
    Friend WithEvents BtnWallet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnExplorer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnContracts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class
