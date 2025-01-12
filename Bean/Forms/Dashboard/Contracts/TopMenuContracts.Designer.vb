<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopMenuContracts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopMenuContracts))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnCreateToken = New Guna.UI2.WinForms.Guna2Button()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnCreateToken)
        Me.Guna2Transition1.SetDecoration(Me.FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1000, 45)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Visible = False
        '
        'BtnCreateToken
        '
        Me.BtnCreateToken.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCreateToken.BorderRadius = 10
        Me.BtnCreateToken.BorderThickness = 1
        Me.BtnCreateToken.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnCreateToken.Checked = True
        Me.BtnCreateToken.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnCreateToken.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnCreateToken.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnCreateToken.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnCreateToken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreateToken.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.createToken_white
        Me.BtnCreateToken.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.createToken_hover
        Me.BtnCreateToken.CustomImages.Image = Global.Bean.My.Resources.Resources.createToken_gray
        Me.BtnCreateToken.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCreateToken.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnCreateToken.CustomizableEdges.BottomLeft = False
        Me.BtnCreateToken.CustomizableEdges.BottomRight = False
        Me.Guna2Transition1.SetDecoration(Me.BtnCreateToken, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnCreateToken.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreateToken.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCreateToken.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCreateToken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCreateToken.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCreateToken.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateToken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCreateToken.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnCreateToken.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnCreateToken.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCreateToken.Location = New System.Drawing.Point(0, 1)
        Me.BtnCreateToken.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.BtnCreateToken.Name = "BtnCreateToken"
        Me.BtnCreateToken.PressedDepth = 0
        Me.BtnCreateToken.Size = New System.Drawing.Size(170, 45)
        Me.BtnCreateToken.TabIndex = 1
        Me.BtnCreateToken.Text = "Create a token"
        Me.BtnCreateToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCreateToken.TextOffset = New System.Drawing.Point(30, 0)
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
        'TopMenuContracts
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
        Me.Name = "TopMenuContracts"
        Me.Text = "TopMenuContracts"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnCreateToken As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents StartingTimer As Timer
End Class
