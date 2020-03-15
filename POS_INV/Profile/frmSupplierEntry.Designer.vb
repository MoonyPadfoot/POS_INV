<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSupplierEntry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.tb_Address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_Name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 44)
        Me.Panel1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Supplier Entry"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(570, 153)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(87, 43)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "Close"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.Location = New System.Drawing.Point(477, 153)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(87, 43)
        Me.btn_Update.TabIndex = 3
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(384, 153)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(87, 43)
        Me.btn_Save.TabIndex = 2
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'tb_Address
        '
        Me.tb_Address.Location = New System.Drawing.Point(120, 114)
        Me.tb_Address.MaxLength = 100
        Me.tb_Address.Name = "tb_Address"
        Me.tb_Address.ShortcutsEnabled = False
        Me.tb_Address.Size = New System.Drawing.Size(537, 22)
        Me.tb_Address.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Address:"
        '
        'tb_Name
        '
        Me.tb_Name.Location = New System.Drawing.Point(120, 74)
        Me.tb_Name.MaxLength = 50
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.ShortcutsEnabled = False
        Me.tb_Name.Size = New System.Drawing.Size(537, 22)
        Me.tb_Name.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Name:"
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(34, 166)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(41, 17)
        Me.lbl_Id.TabIndex = 41
        Me.lbl_Id.Text = "lbl_Id"
        '
        'frmSupplierEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 216)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.tb_Address)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_Name)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSupplierEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSupplierEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents tb_Address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_Name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Id As Label
End Class
