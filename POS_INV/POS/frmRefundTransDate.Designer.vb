<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefundTransDate
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Continue = New System.Windows.Forms.Button()
        Me.tb_Remarks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 32)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Transaction Date:"
        '
        'dtp_Date
        '
        Me.dtp_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Location = New System.Drawing.Point(72, 85)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(321, 27)
        Me.dtp_Date.TabIndex = 29
        '
        'btn_Back
        '
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.Location = New System.Drawing.Point(286, 335)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(108, 56)
        Me.btn_Back.TabIndex = 32
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'btn_Continue
        '
        Me.btn_Continue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Continue.Location = New System.Drawing.Point(164, 335)
        Me.btn_Continue.Name = "btn_Continue"
        Me.btn_Continue.Size = New System.Drawing.Size(116, 56)
        Me.btn_Continue.TabIndex = 31
        Me.btn_Continue.Text = "Continue"
        Me.btn_Continue.UseVisualStyleBackColor = True
        '
        'tb_Remarks
        '
        Me.tb_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Remarks.Location = New System.Drawing.Point(74, 196)
        Me.tb_Remarks.Multiline = True
        Me.tb_Remarks.Name = "tb_Remarks"
        Me.tb_Remarks.Size = New System.Drawing.Size(320, 106)
        Me.tb_Remarks.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 32)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Remarks:"
        '
        'frmRefundTransDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(461, 417)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Remarks)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Continue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_Date)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRefundTransDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRefundTransDate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Continue As Button
    Friend WithEvents tb_Remarks As TextBox
    Friend WithEvents Label1 As Label
End Class
