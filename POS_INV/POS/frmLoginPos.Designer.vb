<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginPos
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(408, 178)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 44)
        Me.btn_Cancel.TabIndex = 17
        Me.btn_Cancel.Text = "Close"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'btn_Login
        '
        Me.btn_Login.Location = New System.Drawing.Point(310, 178)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(92, 44)
        Me.btn_Login.TabIndex = 16
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'tb_Password
        '
        Me.tb_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Password.Location = New System.Drawing.Point(152, 129)
        Me.tb_Password.MaxLength = 30
        Me.tb_Password.Multiline = True
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Password.ShortcutsEnabled = False
        Me.tb_Password.Size = New System.Drawing.Size(348, 34)
        Me.tb_Password.TabIndex = 15
        '
        'tb_username
        '
        Me.tb_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_username.Location = New System.Drawing.Point(152, 77)
        Me.tb_username.MaxLength = 30
        Me.tb_username.Multiline = True
        Me.tb_username.Name = "tb_username"
        Me.tb_username.ShortcutsEnabled = False
        Me.tb_username.Size = New System.Drawing.Size(348, 34)
        Me.tb_username.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 44)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username:"
        '
        'frmLoginPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 258)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.tb_Password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoginPos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoginPos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_Login As Button
    Friend WithEvents tb_Password As TextBox
    Friend WithEvents tb_username As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
