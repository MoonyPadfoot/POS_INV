﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagerEntry
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
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_show_Password = New System.Windows.Forms.CheckBox()
        Me.cbo_Active = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_search_User = New System.Windows.Forms.Label()
        Me.tb_Name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 44)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manager Entry"
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(501, 448)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(116, 52)
        Me.btn_Save.TabIndex = 56
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_show_Password)
        Me.GroupBox2.Controls.Add(Me.cbo_Active)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tb_Username)
        Me.GroupBox2.Controls.Add(Me.tb_Password)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(708, 189)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manager Account Settings"
        '
        'cb_show_Password
        '
        Me.cb_show_Password.AutoSize = True
        Me.cb_show_Password.Location = New System.Drawing.Point(470, 87)
        Me.cb_show_Password.Name = "cb_show_Password"
        Me.cb_show_Password.Size = New System.Drawing.Size(126, 21)
        Me.cb_show_Password.TabIndex = 43
        Me.cb_show_Password.Text = "show password"
        Me.cb_show_Password.UseVisualStyleBackColor = True
        '
        'cbo_Active
        '
        Me.cbo_Active.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Active.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbo_Active.Location = New System.Drawing.Point(140, 137)
        Me.cbo_Active.Name = "cbo_Active"
        Me.cbo_Active.Size = New System.Drawing.Size(121, 24)
        Me.cbo_Active.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Active:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Username:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Password:"
        '
        'tb_Username
        '
        Me.tb_Username.Location = New System.Drawing.Point(140, 40)
        Me.tb_Username.MaxLength = 30
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.ShortcutsEnabled = False
        Me.tb_Username.Size = New System.Drawing.Size(310, 22)
        Me.tb_Username.TabIndex = 6
        '
        'tb_Password
        '
        Me.tb_Password.Location = New System.Drawing.Point(140, 87)
        Me.tb_Password.MaxLength = 30
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Password.ShortcutsEnabled = False
        Me.tb_Password.Size = New System.Drawing.Size(310, 22)
        Me.tb_Password.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_search_User)
        Me.GroupBox1.Controls.Add(Me.tb_Name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 129)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'lbl_search_User
        '
        Me.lbl_search_User.AutoSize = True
        Me.lbl_search_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search_User.Location = New System.Drawing.Point(137, 82)
        Me.lbl_search_User.Name = "lbl_search_User"
        Me.lbl_search_User.Size = New System.Drawing.Size(142, 17)
        Me.lbl_search_User.TabIndex = 23
        Me.lbl_search_User.Text = "Search User Account"
        '
        'tb_Name
        '
        Me.tb_Name.Location = New System.Drawing.Point(140, 43)
        Me.tb_Name.MaxLength = 50
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.ReadOnly = True
        Me.tb_Name.ShortcutsEnabled = False
        Me.tb_Name.Size = New System.Drawing.Size(538, 22)
        Me.tb_Name.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Name:"
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(65, 466)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(19, 17)
        Me.lbl_Id.TabIndex = 53
        Me.lbl_Id.Text = "Id"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(623, 448)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 52)
        Me.btnCancel.TabIndex = 52
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.Location = New System.Drawing.Point(501, 448)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(116, 52)
        Me.btn_Update.TabIndex = 57
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'frmManagerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 529)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManagerEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmManagerEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_show_Password As CheckBox
    Friend WithEvents cbo_Active As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_Username As TextBox
    Friend WithEvents tb_Password As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_search_User As Label
    Friend WithEvents tb_Name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Id As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btn_Update As Button
End Class
