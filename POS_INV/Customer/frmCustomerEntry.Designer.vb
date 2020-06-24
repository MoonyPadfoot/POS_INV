<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerEntry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.tb_Suffix = New System.Windows.Forms.TextBox()
        Me.tb_Surname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Mi = New System.Windows.Forms.TextBox()
        Me.tb_Gname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Code = New System.Windows.Forms.TextBox()
        Me.tb_credit_Limit = New System.Windows.Forms.TextBox()
        Me.tb_Balance = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(780, 44)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Profile"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 24)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Credit Limit:"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(612, 371)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(111, 51)
        Me.btn_Cancel.TabIndex = 58
        Me.btn_Cancel.Text = "Close"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(495, 371)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(111, 51)
        Me.btn_Update.TabIndex = 57
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(378, 371)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(111, 51)
        Me.btn_Save.TabIndex = 56
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'tb_Suffix
        '
        Me.tb_Suffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Suffix.Location = New System.Drawing.Point(227, 229)
        Me.tb_Suffix.MaxLength = 10
        Me.tb_Suffix.Name = "tb_Suffix"
        Me.tb_Suffix.ShortcutsEnabled = False
        Me.tb_Suffix.Size = New System.Drawing.Size(82, 30)
        Me.tb_Suffix.TabIndex = 54
        '
        'tb_Surname
        '
        Me.tb_Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Surname.Location = New System.Drawing.Point(227, 188)
        Me.tb_Surname.MaxLength = 100
        Me.tb_Surname.Name = "tb_Surname"
        Me.tb_Surname.ShortcutsEnabled = False
        Me.tb_Surname.Size = New System.Drawing.Size(496, 30)
        Me.tb_Surname.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 24)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Suffix:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Surname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 24)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Middle Initial:"
        '
        'tb_Mi
        '
        Me.tb_Mi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Mi.Location = New System.Drawing.Point(227, 146)
        Me.tb_Mi.MaxLength = 10
        Me.tb_Mi.Name = "tb_Mi"
        Me.tb_Mi.ShortcutsEnabled = False
        Me.tb_Mi.Size = New System.Drawing.Size(82, 30)
        Me.tb_Mi.TabIndex = 48
        '
        'tb_Gname
        '
        Me.tb_Gname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Gname.Location = New System.Drawing.Point(227, 106)
        Me.tb_Gname.MaxLength = 100
        Me.tb_Gname.Name = "tb_Gname"
        Me.tb_Gname.ShortcutsEnabled = False
        Me.tb_Gname.Size = New System.Drawing.Size(496, 30)
        Me.tb_Gname.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Given Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Customer Code:"
        '
        'tb_Code
        '
        Me.tb_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Code.Location = New System.Drawing.Point(227, 65)
        Me.tb_Code.MaxLength = 50
        Me.tb_Code.Name = "tb_Code"
        Me.tb_Code.ShortcutsEnabled = False
        Me.tb_Code.Size = New System.Drawing.Size(403, 30)
        Me.tb_Code.TabIndex = 44
        '
        'tb_credit_Limit
        '
        Me.tb_credit_Limit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_credit_Limit.Location = New System.Drawing.Point(227, 275)
        Me.tb_credit_Limit.Name = "tb_credit_Limit"
        Me.tb_credit_Limit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_credit_Limit.ShortcutsEnabled = False
        Me.tb_credit_Limit.Size = New System.Drawing.Size(165, 30)
        Me.tb_credit_Limit.TabIndex = 60
        '
        'tb_Balance
        '
        Me.tb_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Balance.Location = New System.Drawing.Point(227, 319)
        Me.tb_Balance.Name = "tb_Balance"
        Me.tb_Balance.ReadOnly = True
        Me.tb_Balance.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_Balance.Size = New System.Drawing.Size(165, 30)
        Me.tb_Balance.TabIndex = 62
        Me.tb_Balance.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 24)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Balance:"
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(41, 367)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(41, 17)
        Me.lbl_Id.TabIndex = 63
        Me.lbl_Id.Text = "lbl_Id"
        Me.lbl_Id.Visible = False
        '
        'frmCustomerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 447)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.tb_Balance)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_credit_Limit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.tb_Suffix)
        Me.Controls.Add(Me.tb_Surname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Mi)
        Me.Controls.Add(Me.tb_Gname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_Code)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCustomerEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents tb_Suffix As TextBox
    Friend WithEvents tb_Surname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Mi As TextBox
    Friend WithEvents tb_Gname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Code As TextBox
    Friend WithEvents tb_credit_Limit As TextBox
    Friend WithEvents tb_Balance As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_Id As Label
End Class
