<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.LblTx = New System.Windows.Forms.LinkLabel()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.PBStatus = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PBStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1015, 45)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LblQty, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTx, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblType, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDate, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBStatus, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1015, 43)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LblQty
        '
        Me.LblQty.AutoSize = True
        Me.LblQty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblQty.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!, System.Drawing.FontStyle.Bold)
        Me.LblQty.Location = New System.Drawing.Point(770, 0)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Padding = New System.Windows.Forms.Padding(0, 0, 48, 0)
        Me.LblQty.Size = New System.Drawing.Size(242, 43)
        Me.LblQty.TabIndex = 4
        Me.LblQty.Text = "+ 50000000 BTC"
        Me.LblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTx
        '
        Me.LblTx.ActiveLinkColor = System.Drawing.Color.White
        Me.LblTx.AutoEllipsis = True
        Me.LblTx.AutoSize = True
        Me.LblTx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTx.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.LblTx.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LblTx.LinkColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTx.Location = New System.Drawing.Point(388, 0)
        Me.LblTx.Name = "LblTx"
        Me.LblTx.Size = New System.Drawing.Size(376, 43)
        Me.LblTx.TabIndex = 0
        Me.LblTx.TabStop = True
        Me.LblTx.Text = "96d8a27312d14b2b91ac6eadabc76d1e"
        Me.LblTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblType.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblType.Location = New System.Drawing.Point(263, 0)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(119, 43)
        Me.LblType.TabIndex = 3
        Me.LblType.Text = "Transfer"
        Me.LblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDate
        '
        Me.LblDate.AutoEllipsis = True
        Me.LblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDate.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.LblDate.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblDate.Location = New System.Drawing.Point(101, 0)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(156, 43)
        Me.LblDate.TabIndex = 1
        Me.LblDate.Text = "23/01/2025 - 09:54:32"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PBStatus
        '
        Me.PBStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBStatus.FillColor = System.Drawing.Color.Empty
        Me.PBStatus.Image = Global.Bean.My.Resources.Resources.pendingIcon
        Me.PBStatus.ImageRotate = 0!
        Me.PBStatus.Location = New System.Drawing.Point(3, 3)
        Me.PBStatus.Name = "PBStatus"
        Me.PBStatus.Padding = New System.Windows.Forms.Padding(48, 0, 0, 0)
        Me.PBStatus.Size = New System.Drawing.Size(92, 37)
        Me.PBStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBStatus.TabIndex = 5
        Me.PBStatus.TabStop = False
        '
        'HistoryControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "HistoryControl"
        Me.Size = New System.Drawing.Size(1015, 45)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PBStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblTx As LinkLabel
    Friend WithEvents LblDate As Label
    Friend WithEvents LblType As Label
    Friend WithEvents LblQty As Label
    Friend WithEvents PBStatus As Guna.UI2.WinForms.Guna2PictureBox
End Class
