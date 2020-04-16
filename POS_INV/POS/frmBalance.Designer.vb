<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalance
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
        Me.btn_Verify = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.tb_initial_Bal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Initial Balance:"
        '
        'btn_Verify
        '
        Me.btn_Verify.Location = New System.Drawing.Point(151, 172)
        Me.btn_Verify.Name = "btn_Verify"
        Me.btn_Verify.Size = New System.Drawing.Size(98, 46)
        Me.btn_Verify.TabIndex = 1
        Me.btn_Verify.Text = "Set"
        Me.btn_Verify.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(255, 172)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(97, 46)
        Me.btn_Cancel.TabIndex = 12
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'tb_initial_Bal
        '
        Me.tb_initial_Bal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_initial_Bal.Location = New System.Drawing.Point(45, 80)
        Me.tb_initial_Bal.MaxLength = 0
        Me.tb_initial_Bal.Multiline = True
        Me.tb_initial_Bal.Name = "tb_initial_Bal"
        Me.tb_initial_Bal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_initial_Bal.Size = New System.Drawing.Size(307, 69)
        Me.tb_initial_Bal.TabIndex = 0
        '
        'frmBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 251)
        Me.Controls.Add(Me.tb_initial_Bal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Verify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBalance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Verify As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents tb_initial_Bal As TextBox
End Class
