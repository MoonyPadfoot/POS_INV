<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Me.tb_due_Total = New System.Windows.Forms.TextBox()
        Me.tb_cash_Tendered = New System.Windows.Forms.TextBox()
        Me.tb_Change = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Pay = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_due_Total
        '
        Me.tb_due_Total.BackColor = System.Drawing.Color.Black
        Me.tb_due_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_due_Total.ForeColor = System.Drawing.Color.Green
        Me.tb_due_Total.Location = New System.Drawing.Point(417, 84)
        Me.tb_due_Total.Multiline = True
        Me.tb_due_Total.Name = "tb_due_Total"
        Me.tb_due_Total.ReadOnly = True
        Me.tb_due_Total.Size = New System.Drawing.Size(251, 57)
        Me.tb_due_Total.TabIndex = 8
        Me.tb_due_Total.TabStop = False
        Me.tb_due_Total.Text = "0.00"
        Me.tb_due_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_cash_Tendered
        '
        Me.tb_cash_Tendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cash_Tendered.Location = New System.Drawing.Point(417, 156)
        Me.tb_cash_Tendered.Multiline = True
        Me.tb_cash_Tendered.Name = "tb_cash_Tendered"
        Me.tb_cash_Tendered.Size = New System.Drawing.Size(251, 57)
        Me.tb_cash_Tendered.TabIndex = 0
        Me.tb_cash_Tendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_Change
        '
        Me.tb_Change.BackColor = System.Drawing.Color.Black
        Me.tb_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Change.ForeColor = System.Drawing.Color.Green
        Me.tb_Change.Location = New System.Drawing.Point(368, 233)
        Me.tb_Change.Multiline = True
        Me.tb_Change.Name = "tb_Change"
        Me.tb_Change.ReadOnly = True
        Me.tb_Change.Size = New System.Drawing.Size(300, 78)
        Me.tb_Change.TabIndex = 10
        Me.tb_Change.TabStop = False
        Me.tb_Change.Text = "0.00"
        Me.tb_Change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Due Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(49, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cash Tendered:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 69)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Change:"
        '
        'btn_Pay
        '
        Me.btn_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pay.Location = New System.Drawing.Point(446, 330)
        Me.btn_Pay.Name = "btn_Pay"
        Me.btn_Pay.Size = New System.Drawing.Size(108, 56)
        Me.btn_Pay.TabIndex = 2
        Me.btn_Pay.Text = "Pay"
        Me.btn_Pay.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(560, 330)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(108, 56)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'dtp_Date
        '
        Me.dtp_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Location = New System.Drawing.Point(347, 44)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(321, 27)
        Me.dtp_Date.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(49, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 32)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Transaction Date:"
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(729, 422)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_Date)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Pay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Change)
        Me.Controls.Add(Me.tb_cash_Tendered)
        Me.Controls.Add(Me.tb_due_Total)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Checkout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_due_Total As TextBox
    Friend WithEvents tb_cash_Tendered As TextBox
    Friend WithEvents tb_Change As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Pay As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
