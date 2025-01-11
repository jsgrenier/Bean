<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopMenuExplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopMenuExplorer))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnExplorer = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnExplorer)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSearch)
        Me.Guna2Transition1.SetDecoration(Me.FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1000, 45)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Visible = False
        '
        'BtnExplorer
        '
        Me.BtnExplorer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnExplorer.BorderRadius = 10
        Me.BtnExplorer.BorderThickness = 1
        Me.BtnExplorer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnExplorer.Checked = True
        Me.BtnExplorer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnExplorer.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnExplorer.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnExplorer.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnExplorer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExplorer.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.blockchain_white
        Me.BtnExplorer.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.blockchain_hover
        Me.BtnExplorer.CustomImages.Image = Global.Bean.My.Resources.Resources.blockchain_gray
        Me.BtnExplorer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnExplorer.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnExplorer.CustomizableEdges.BottomLeft = False
        Me.BtnExplorer.CustomizableEdges.BottomRight = False
        Me.Guna2Transition1.SetDecoration(Me.BtnExplorer, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.BtnExplorer.Location = New System.Drawing.Point(0, 1)
        Me.BtnExplorer.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.BtnExplorer.Name = "BtnExplorer"
        Me.BtnExplorer.PressedDepth = 0
        Me.BtnExplorer.Size = New System.Drawing.Size(170, 45)
        Me.BtnExplorer.TabIndex = 1
        Me.BtnExplorer.Text = "Explorer"
        Me.BtnExplorer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnExplorer.TextOffset = New System.Drawing.Point(30, 0)
        '
        'BtnSearch
        '
        Me.BtnSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSearch.BorderRadius = 10
        Me.BtnSearch.BorderThickness = 1
        Me.BtnSearch.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSearch.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnSearch.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.search_white
        Me.BtnSearch.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.search_hover
        Me.BtnSearch.CustomImages.Image = Global.Bean.My.Resources.Resources.search_gray
        Me.BtnSearch.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSearch.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSearch.CustomizableEdges.BottomLeft = False
        Me.BtnSearch.CustomizableEdges.BottomRight = False
        Me.Guna2Transition1.SetDecoration(Me.BtnSearch, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnSearch.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSearch.Location = New System.Drawing.Point(170, 1)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.PressedDepth = 0
        Me.BtnSearch.Size = New System.Drawing.Size(170, 45)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSearch.TextOffset = New System.Drawing.Point(30, 0)
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
        'TopMenuExplorer
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
        Me.Name = "TopMenuExplorer"
        Me.Text = "TopMenuExplorer"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnExplorer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents StartingTimer As Timer
End Class
