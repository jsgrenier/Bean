<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopMenuSwap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopMenuSwap))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnSwap = New Guna.UI2.WinForms.Guna2Button()
        Me.StartingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSwap)
        Me.Guna2Transition1.SetDecoration(Me.FlowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1000, 45)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Visible = False
        '
        'BtnSwap
        '
        Me.BtnSwap.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSwap.BorderRadius = 10
        Me.BtnSwap.BorderThickness = 1
        Me.BtnSwap.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnSwap.Checked = True
        Me.BtnSwap.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.BtnSwap.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnSwap.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnSwap.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnSwap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSwap.CustomImages.CheckedImage = Global.Bean.My.Resources.Resources.swap2_white
        Me.BtnSwap.CustomImages.HoveredImage = Global.Bean.My.Resources.Resources.swap2_hover
        Me.BtnSwap.CustomImages.Image = Global.Bean.My.Resources.Resources.swap2_gray
        Me.BtnSwap.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSwap.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSwap.CustomizableEdges.BottomLeft = False
        Me.BtnSwap.CustomizableEdges.BottomRight = False
        Me.Guna2Transition1.SetDecoration(Me.BtnSwap, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSwap.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSwap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSwap.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSwap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSwap.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnSwap.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSwap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSwap.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnSwap.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnSwap.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSwap.Location = New System.Drawing.Point(0, 1)
        Me.BtnSwap.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.BtnSwap.Name = "BtnSwap"
        Me.BtnSwap.PressedDepth = 0
        Me.BtnSwap.Size = New System.Drawing.Size(170, 45)
        Me.BtnSwap.TabIndex = 1
        Me.BtnSwap.Text = "Swap tokens"
        Me.BtnSwap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSwap.TextOffset = New System.Drawing.Point(30, 0)
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
        'TopMenuSwap
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
        Me.Name = "TopMenuSwap"
        Me.Text = "TopMenuSwap"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnSwap As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents StartingTimer As Timer
End Class
