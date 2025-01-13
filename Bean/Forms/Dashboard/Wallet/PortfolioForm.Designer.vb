<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PortfolioForm
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
        Me.TopPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CoinsFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoadingControl1 = New Bean.LoadingControl()
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.Label1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1015, 100)
        Me.TopPanel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(58, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 37)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "My portfolio"
        '
        'CoinsFlowPanel
        '
        Me.CoinsFlowPanel.AutoScroll = True
        Me.CoinsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoinsFlowPanel.Location = New System.Drawing.Point(48, 100)
        Me.CoinsFlowPanel.Name = "CoinsFlowPanel"
        Me.CoinsFlowPanel.Size = New System.Drawing.Size(967, 490)
        Me.CoinsFlowPanel.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(48, 490)
        Me.Panel1.TabIndex = 9
        '
        'LoadingControl1
        '
        Me.LoadingControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoadingControl1.AnimationSpeed = 20
        Me.LoadingControl1.ArcColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LoadingControl1.ArcLength = 120
        Me.LoadingControl1.ArcThickness = 10
        Me.LoadingControl1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LoadingControl1.Location = New System.Drawing.Point(457, 195)
        Me.LoadingControl1.Name = "LoadingControl1"
        Me.LoadingControl1.PaddingSize = 10
        Me.LoadingControl1.Size = New System.Drawing.Size(100, 100)
        Me.LoadingControl1.TabIndex = 10
        Me.LoadingControl1.Visible = False
        '
        'LoadingTimer
        '
        Me.LoadingTimer.Interval = 500
        '
        'PortfolioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 590)
        Me.Controls.Add(Me.LoadingControl1)
        Me.Controls.Add(Me.CoinsFlowPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PortfolioForm"
        Me.Text = "PortfolioForm"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CoinsFlowPanel As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadingControl1 As LoadingControl
    Friend WithEvents LoadingTimer As Timer
End Class
