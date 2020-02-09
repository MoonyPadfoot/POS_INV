<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProfiling
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Supplier = New System.Windows.Forms.Button()
        Me.btn_Branch = New System.Windows.Forms.Button()
        Me.btn_Service = New System.Windows.Forms.Button()
        Me.btn_Item = New System.Windows.Forms.Button()
        Me.btn_User = New System.Windows.Forms.Button()
        Me.pnl_Mid = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.Label21)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1272, 85)
        Me.pnlHeader.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(28, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(168, 44)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Profiling"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Supplier)
        Me.Panel1.Controls.Add(Me.btn_Branch)
        Me.Panel1.Controls.Add(Me.btn_Service)
        Me.Panel1.Controls.Add(Me.btn_Item)
        Me.Panel1.Controls.Add(Me.btn_User)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1272, 46)
        Me.Panel1.TabIndex = 2
        '
        'btn_Supplier
        '
        Me.btn_Supplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Supplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Supplier.ForeColor = System.Drawing.Color.White
        Me.btn_Supplier.Location = New System.Drawing.Point(521, 0)
        Me.btn_Supplier.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Supplier.Name = "btn_Supplier"
        Me.btn_Supplier.Size = New System.Drawing.Size(130, 46)
        Me.btn_Supplier.TabIndex = 9
        Me.btn_Supplier.Text = "Supplier"
        Me.btn_Supplier.UseVisualStyleBackColor = False
        '
        'btn_Branch
        '
        Me.btn_Branch.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Branch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Branch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Branch.ForeColor = System.Drawing.Color.White
        Me.btn_Branch.Location = New System.Drawing.Point(391, 0)
        Me.btn_Branch.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Branch.Name = "btn_Branch"
        Me.btn_Branch.Size = New System.Drawing.Size(130, 46)
        Me.btn_Branch.TabIndex = 8
        Me.btn_Branch.Text = "Branch"
        Me.btn_Branch.UseVisualStyleBackColor = False
        '
        'btn_Service
        '
        Me.btn_Service.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Service.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Service.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Service.ForeColor = System.Drawing.Color.White
        Me.btn_Service.Location = New System.Drawing.Point(261, 0)
        Me.btn_Service.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Service.Name = "btn_Service"
        Me.btn_Service.Size = New System.Drawing.Size(130, 46)
        Me.btn_Service.TabIndex = 6
        Me.btn_Service.Text = "Services"
        Me.btn_Service.UseVisualStyleBackColor = False
        '
        'btn_Item
        '
        Me.btn_Item.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Item.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Item.ForeColor = System.Drawing.Color.White
        Me.btn_Item.Location = New System.Drawing.Point(1, 0)
        Me.btn_Item.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Item.Name = "btn_Item"
        Me.btn_Item.Size = New System.Drawing.Size(130, 46)
        Me.btn_Item.TabIndex = 5
        Me.btn_Item.Text = "Items"
        Me.btn_Item.UseVisualStyleBackColor = False
        '
        'btn_User
        '
        Me.btn_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_User.ForeColor = System.Drawing.Color.White
        Me.btn_User.Location = New System.Drawing.Point(131, 0)
        Me.btn_User.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_User.Name = "btn_User"
        Me.btn_User.Size = New System.Drawing.Size(130, 46)
        Me.btn_User.TabIndex = 7
        Me.btn_User.Text = "Users"
        Me.btn_User.UseVisualStyleBackColor = False
        '
        'pnl_Mid
        '
        Me.pnl_Mid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Mid.Location = New System.Drawing.Point(0, 131)
        Me.pnl_Mid.Name = "pnl_Mid"
        Me.pnl_Mid.Size = New System.Drawing.Size(1272, 560)
        Me.pnl_Mid.TabIndex = 3
        '
        'frmProfiling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 691)
        Me.Controls.Add(Me.pnl_Mid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProfiling"
        Me.Text = "frmProfiling"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Item As Button
    Friend WithEvents btn_Service As Button
    Friend WithEvents btn_User As Button
    Friend WithEvents btn_Supplier As Button
    Friend WithEvents btn_Branch As Button
    Friend WithEvents pnl_Mid As Panel
End Class
