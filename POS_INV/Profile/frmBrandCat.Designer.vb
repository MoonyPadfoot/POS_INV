<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrandCat
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
        Me.tb_brand_Cat = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.lbl_Header = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_brand_Cat = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_brand_Cat
        '
        Me.tb_brand_Cat.Location = New System.Drawing.Point(37, 65)
        Me.tb_brand_Cat.Name = "tb_brand_Cat"
        Me.tb_brand_Cat.Size = New System.Drawing.Size(472, 22)
        Me.tb_brand_Cat.TabIndex = 0
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(337, 109)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(84, 39)
        Me.btn_Save.TabIndex = 1
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(425, 109)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(84, 39)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "Close"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.Location = New System.Drawing.Point(337, 109)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(84, 39)
        Me.btn_Update.TabIndex = 4
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'lbl_Header
        '
        Me.lbl_Header.AutoSize = True
        Me.lbl_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New System.Drawing.Size(60, 24)
        Me.lbl_Header.TabIndex = 5
        Me.lbl_Header.Text = "Brand"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Header)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 39)
        Me.Panel1.TabIndex = 6
        '
        'lbl_brand_Cat
        '
        Me.lbl_brand_Cat.AutoSize = True
        Me.lbl_brand_Cat.Location = New System.Drawing.Point(45, 109)
        Me.lbl_brand_Cat.Name = "lbl_brand_Cat"
        Me.lbl_brand_Cat.Size = New System.Drawing.Size(51, 17)
        Me.lbl_brand_Cat.TabIndex = 7
        Me.lbl_brand_Cat.Text = "Label1"
        '
        'frmBrandCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 177)
        Me.Controls.Add(Me.lbl_brand_Cat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.tb_brand_Cat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBrandCat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_brand_Cat As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents lbl_Header As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_brand_Cat As Label
End Class
