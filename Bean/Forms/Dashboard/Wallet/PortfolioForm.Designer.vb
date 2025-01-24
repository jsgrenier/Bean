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
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HistoryPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.TopHistoryPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.PBHistory = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PBArrow = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LblLatest = New System.Windows.Forms.Label()
        Me.HistoryFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.LoadingControl1 = New Bean.LoadingControl()
        Me.BottomBar1 = New Bean.BottomBar()
        Me.TopPanel.SuspendLayout()
        Me.HistoryPanel.SuspendLayout()
        Me.TopHistoryPanel.SuspendLayout()
        CType(Me.PBHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBArrow, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CoinsFlowPanel.Size = New System.Drawing.Size(967, 191)
        Me.CoinsFlowPanel.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(48, 191)
        Me.Panel1.TabIndex = 9
        '
        'LoadingTimer
        '
        Me.LoadingTimer.Interval = 500
        '
        'HistoryPanel
        '
        Me.HistoryPanel.Controls.Add(Me.TopHistoryPanel)
        Me.HistoryPanel.Controls.Add(Me.HistoryFlow)
        Me.HistoryPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.HistoryPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HistoryPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.HistoryPanel.Location = New System.Drawing.Point(0, 291)
        Me.HistoryPanel.MinimumSize = New System.Drawing.Size(800, 0)
        Me.HistoryPanel.Name = "HistoryPanel"
        Me.HistoryPanel.Size = New System.Drawing.Size(1015, 262)
        Me.HistoryPanel.TabIndex = 11
        Me.HistoryPanel.Visible = False
        '
        'TopHistoryPanel
        '
        Me.TopHistoryPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.TopHistoryPanel.Controls.Add(Me.PBHistory)
        Me.TopHistoryPanel.Controls.Add(Me.PBArrow)
        Me.TopHistoryPanel.Controls.Add(Me.LblLatest)
        Me.TopHistoryPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TopHistoryPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TopHistoryPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.TopHistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopHistoryPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopHistoryPanel.Name = "TopHistoryPanel"
        Me.TopHistoryPanel.Size = New System.Drawing.Size(1015, 37)
        Me.TopHistoryPanel.TabIndex = 29
        '
        'PBHistory
        '
        Me.PBHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBHistory.FillColor = System.Drawing.Color.Empty
        Me.PBHistory.Image = Global.Bean.My.Resources.Resources.history_gray
        Me.PBHistory.ImageRotate = 0!
        Me.PBHistory.Location = New System.Drawing.Point(19, 10)
        Me.PBHistory.Name = "PBHistory"
        Me.PBHistory.Size = New System.Drawing.Size(18, 18)
        Me.PBHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBHistory.TabIndex = 29
        Me.PBHistory.TabStop = False
        '
        'PBArrow
        '
        Me.PBArrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBArrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBArrow.FillColor = System.Drawing.Color.Empty
        Me.PBArrow.Image = Global.Bean.My.Resources.Resources.DownArrow_gray
        Me.PBArrow.ImageRotate = 0!
        Me.PBArrow.Location = New System.Drawing.Point(967, 9)
        Me.PBArrow.Name = "PBArrow"
        Me.PBArrow.Size = New System.Drawing.Size(18, 18)
        Me.PBArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBArrow.TabIndex = 28
        Me.PBArrow.TabStop = False
        '
        'LblLatest
        '
        Me.LblLatest.AutoSize = True
        Me.LblLatest.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.LblLatest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblLatest.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLatest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblLatest.Location = New System.Drawing.Point(47, 8)
        Me.LblLatest.Name = "LblLatest"
        Me.LblLatest.Size = New System.Drawing.Size(134, 20)
        Me.LblLatest.TabIndex = 25
        Me.LblLatest.Text = "Latest transactions"
        '
        'HistoryFlow
        '
        Me.HistoryFlow.AutoScroll = True
        Me.HistoryFlow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HistoryFlow.Location = New System.Drawing.Point(0, 37)
        Me.HistoryFlow.Name = "HistoryFlow"
        Me.HistoryFlow.Size = New System.Drawing.Size(1015, 225)
        Me.HistoryFlow.TabIndex = 28
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
        'BottomBar1
        '
        Me.BottomBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BottomBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomBar1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottomBar1.ForeColor = System.Drawing.Color.White
        Me.BottomBar1.Location = New System.Drawing.Point(0, 553)
        Me.BottomBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BottomBar1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.BottomBar1.Name = "BottomBar1"
        Me.BottomBar1.Size = New System.Drawing.Size(1015, 37)
        Me.BottomBar1.TabIndex = 12
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
        Me.Controls.Add(Me.HistoryPanel)
        Me.Controls.Add(Me.BottomBar1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PortfolioForm"
        Me.Text = "PortfolioForm"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.HistoryPanel.ResumeLayout(False)
        Me.TopHistoryPanel.ResumeLayout(False)
        Me.TopHistoryPanel.PerformLayout()
        CType(Me.PBHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CoinsFlowPanel As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadingControl1 As LoadingControl
    Friend WithEvents LoadingTimer As Timer
    Friend WithEvents HistoryPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblLatest As Label
    Friend WithEvents HistoryFlow As FlowLayoutPanel
    Friend WithEvents TopHistoryPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PBArrow As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BottomBar1 As BottomBar
    Friend WithEvents PBHistory As Guna.UI2.WinForms.Guna2PictureBox
End Class
