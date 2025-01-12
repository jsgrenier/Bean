<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExplorerForm
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.LblTitle)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1015, 100)
        Me.TopPanel.TabIndex = 27
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LblTitle.Location = New System.Drawing.Point(58, 32)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(202, 37)
        Me.LblTitle.TabIndex = 20
        Me.LblTitle.Text = "Block Explorer"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 580)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1015, 10)
        Me.Guna2Panel1.TabIndex = 28
        '
        'ExplorerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 590)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExplorerForm"
        Me.Text = "ExplorerForm"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
