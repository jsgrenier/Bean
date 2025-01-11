<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopMenuWallet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopMenuWallet))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnPortfolio = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSend = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReceive = New Guna.UI2.WinForms.Guna2Button()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnPortfolio)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnReceive)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSend)
        Me.Guna2Transition1.SetDecoration(Me.FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1000, 45)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Visible = False
        '
        'BtnPortfolio
        '
        Me.BtnPortfolio.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnPortfolio.BorderRadius = 10
        Me.BtnPortfolio.BorderThickness = 1
        Me.BtnPortfolio.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnPortfolio.Checked = True
        Me.BtnPortfolio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnPortfolio.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnPortfolio.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnPortfolio.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnPortfolio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPortfolio.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnPortfolio.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.portfolio_white
        Me.BtnPortfolio.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.portfolio_hover
        Me.BtnPortfolio.CustomImages.Image = Global.Bean.My.Resources.Resources.portfolio_gray
        Me.BtnPortfolio.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnPortfolio.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnPortfolio.CustomizableEdges.BottomLeft = False
        Me.BtnPortfolio.CustomizableEdges.BottomRight = False
        Me.Guna2Transition1.SetDecoration(Me.BtnPortfolio, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnPortfolio.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPortfolio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPortfolio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPortfolio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPortfolio.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnPortfolio.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPortfolio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPortfolio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnPortfolio.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnPortfolio.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPortfolio.Location = New System.Drawing.Point(0, 1)
        Me.BtnPortfolio.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.BtnPortfolio.Name = "BtnPortfolio"
        Me.BtnPortfolio.PressedDepth = 0
        Me.BtnPortfolio.Size = New System.Drawing.Size(170, 45)
        Me.BtnPortfolio.TabIndex = 1
        Me.BtnPortfolio.Text = "Portfolio"
        Me.BtnPortfolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnPortfolio.TextOffset = New System.Drawing.Point(30, 0)
        '
        'BtnSend
        '
        Me.BtnSend.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSend.BorderRadius = 10
        Me.BtnSend.BorderThickness = 1
        Me.BtnSend.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnSend.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSend.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSend.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnSend.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSend.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSend.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.send_white
        Me.BtnSend.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.send_hover
        Me.BtnSend.CustomImages.Image = Global.Bean.My.Resources.Resources.send_gray
        Me.BtnSend.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSend.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSend.CustomizableEdges.BottomLeft = False
        Me.BtnSend.CustomizableEdges.BottomRight = False
        Me.Guna2Transition1.SetDecoration(Me.BtnSend, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSend.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSend.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnSend.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnSend.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSend.Location = New System.Drawing.Point(340, 1)
        Me.BtnSend.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.PressedDepth = 0
        Me.BtnSend.Size = New System.Drawing.Size(170, 45)
        Me.BtnSend.TabIndex = 2
        Me.BtnSend.Text = "Send"
        Me.BtnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSend.TextOffset = New System.Drawing.Point(30, 0)
        '
        'BtnReceive
        '
        Me.BtnReceive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnReceive.BorderRadius = 10
        Me.BtnReceive.BorderThickness = 1
        Me.BtnReceive.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnReceive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnReceive.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnReceive.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnReceive.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnReceive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceive.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnReceive.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.receive_white
        Me.BtnReceive.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.receive_hover
        Me.BtnReceive.CustomImages.Image = Global.Bean.My.Resources.Resources.receive_gray
        Me.BtnReceive.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnReceive.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnReceive.CustomizableEdges.BottomLeft = False
        Me.BtnReceive.CustomizableEdges.BottomRight = False
        Me.Guna2Transition1.SetDecoration(Me.BtnReceive, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnReceive.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnReceive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnReceive.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnReceive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnReceive.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnReceive.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnReceive.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnReceive.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnReceive.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReceive.Location = New System.Drawing.Point(170, 1)
        Me.BtnReceive.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.BtnReceive.Name = "BtnReceive"
        Me.BtnReceive.PressedDepth = 0
        Me.BtnReceive.Size = New System.Drawing.Size(170, 45)
        Me.BtnReceive.TabIndex = 3
        Me.BtnReceive.Text = "Receive"
        Me.BtnReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnReceive.TextOffset = New System.Drawing.Point(30, 0)
        '
        'StartingTimer
        '
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
        'TopMenuWallet
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 45)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TopMenuWallet"
        Me.Text = "TopMenuWallet"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnPortfolio As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReceive As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents StartingTimer As Timer
End Class
