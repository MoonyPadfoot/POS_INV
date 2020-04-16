<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCash_in
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
        Me.lbl_cash_Out = New System.Windows.Forms.Label()
        Me.lbl_cash_In = New System.Windows.Forms.Label()
        Me.tb_Remarks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_transDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Go = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.tb_Amount = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_cash_Out)
        Me.Panel1.Controls.Add(Me.lbl_cash_In)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 50)
        Me.Panel1.TabIndex = 8
        '
        'lbl_cash_Out
        '
        Me.lbl_cash_Out.AutoSize = True
        Me.lbl_cash_Out.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cash_Out.ForeColor = System.Drawing.Color.White
        Me.lbl_cash_Out.Location = New System.Drawing.Point(12, 12)
        Me.lbl_cash_Out.Name = "lbl_cash_Out"
        Me.lbl_cash_Out.Size = New System.Drawing.Size(88, 24)
        Me.lbl_cash_Out.TabIndex = 6
        Me.lbl_cash_Out.Text = "Cash Out"
        '
        'lbl_cash_In
        '
        Me.lbl_cash_In.AutoSize = True
        Me.lbl_cash_In.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cash_In.ForeColor = System.Drawing.Color.White
        Me.lbl_cash_In.Location = New System.Drawing.Point(12, 12)
        Me.lbl_cash_In.Name = "lbl_cash_In"
        Me.lbl_cash_In.Size = New System.Drawing.Size(73, 24)
        Me.lbl_cash_In.TabIndex = 5
        Me.lbl_cash_In.Text = "Cash In"
        '
        'tb_Remarks
        '
        Me.tb_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Remarks.Location = New System.Drawing.Point(153, 213)
        Me.tb_Remarks.Multiline = True
        Me.tb_Remarks.Name = "tb_Remarks"
        Me.tb_Remarks.Size = New System.Drawing.Size(320, 106)
        Me.tb_Remarks.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Remarks:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Amount:"
        '
        'dtp_transDate
        '
        Me.dtp_transDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_transDate.Location = New System.Drawing.Point(153, 69)
        Me.dtp_transDate.Name = "dtp_transDate"
        Me.dtp_transDate.Size = New System.Drawing.Size(320, 27)
        Me.dtp_transDate.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Date:"
        '
        'btn_Go
        '
        Me.btn_Go.Location = New System.Drawing.Point(272, 341)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(98, 48)
        Me.btn_Go.TabIndex = 2
        Me.btn_Go.Text = "Go"
        Me.btn_Go.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(375, 341)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(98, 48)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'tb_Amount
        '
        Me.tb_Amount.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Amount.ForeColor = System.Drawing.Color.Black
        Me.tb_Amount.Location = New System.Drawing.Point(153, 112)
        Me.tb_Amount.Multiline = True
        Me.tb_Amount.Name = "tb_Amount"
        Me.tb_Amount.Size = New System.Drawing.Size(320, 78)
        Me.tb_Amount.TabIndex = 0
        Me.tb_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCash_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 419)
        Me.Controls.Add(Me.tb_Amount)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Go)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_transDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Remarks)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCash_in"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCash_in"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_cash_Out As Label
    Friend WithEvents lbl_cash_In As Label
    Friend WithEvents tb_Remarks As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_transDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Go As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents tb_Amount As TextBox
End Class
