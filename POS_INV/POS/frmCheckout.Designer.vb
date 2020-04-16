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
        Me.lbl_Due = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Pay = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Receipt = New System.Windows.Forms.Label()
        Me.tb_Receipt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tb_due_Total
        '
        Me.tb_due_Total.BackColor = System.Drawing.Color.Black
        Me.tb_due_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_due_Total.ForeColor = System.Drawing.Color.Green
        Me.tb_due_Total.Location = New System.Drawing.Point(457, 151)
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
        Me.tb_cash_Tendered.Location = New System.Drawing.Point(457, 223)
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
        Me.tb_Change.Location = New System.Drawing.Point(408, 296)
        Me.tb_Change.Multiline = True
        Me.tb_Change.Name = "tb_Change"
        Me.tb_Change.ReadOnly = True
        Me.tb_Change.Size = New System.Drawing.Size(300, 78)
        Me.tb_Change.TabIndex = 10
        Me.tb_Change.TabStop = False
        Me.tb_Change.Text = "0.00"
        Me.tb_Change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Due
        '
        Me.lbl_Due.AutoSize = True
        Me.lbl_Due.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Due.ForeColor = System.Drawing.Color.White
        Me.lbl_Due.Location = New System.Drawing.Point(49, 166)
        Me.lbl_Due.Name = "lbl_Due"
        Me.lbl_Due.Size = New System.Drawing.Size(146, 32)
        Me.lbl_Due.TabIndex = 6
        Me.lbl_Due.Text = "Due Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(49, 232)
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
        Me.Label3.Location = New System.Drawing.Point(43, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 69)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Change:"
        '
        'btn_Pay
        '
        Me.btn_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pay.Location = New System.Drawing.Point(486, 397)
        Me.btn_Pay.Name = "btn_Pay"
        Me.btn_Pay.Size = New System.Drawing.Size(108, 56)
        Me.btn_Pay.TabIndex = 2
        Me.btn_Pay.Text = "Pay"
        Me.btn_Pay.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(600, 397)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(108, 56)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'dtp_Date
        '
        Me.dtp_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Location = New System.Drawing.Point(387, 44)
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
        'lbl_Receipt
        '
        Me.lbl_Receipt.AutoSize = True
        Me.lbl_Receipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Receipt.ForeColor = System.Drawing.Color.White
        Me.lbl_Receipt.Location = New System.Drawing.Point(49, 95)
        Me.lbl_Receipt.Name = "lbl_Receipt"
        Me.lbl_Receipt.Size = New System.Drawing.Size(227, 32)
        Me.lbl_Receipt.TabIndex = 17
        Me.lbl_Receipt.Text = "Receipt Number:"
        '
        'tb_Receipt
        '
        Me.tb_Receipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Receipt.Location = New System.Drawing.Point(387, 89)
        Me.tb_Receipt.Multiline = True
        Me.tb_Receipt.Name = "tb_Receipt"
        Me.tb_Receipt.Size = New System.Drawing.Size(321, 44)
        Me.tb_Receipt.TabIndex = 18
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 488)
        Me.Controls.Add(Me.tb_Receipt)
        Me.Controls.Add(Me.lbl_Receipt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_Date)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Pay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Due)
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
    Friend WithEvents lbl_Due As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Pay As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_Receipt As Label
    Friend WithEvents tb_Receipt As TextBox
End Class
