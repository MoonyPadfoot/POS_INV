<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPosButtons
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_CashOut = New System.Windows.Forms.Button()
        Me.btn_CashIn = New System.Windows.Forms.Button()
        Me.btn_Balance = New System.Windows.Forms.Button()
        Me.btn_Refund = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_Checkout = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Advance_Srch = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.52389!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28583!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.67024!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.520032!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(494, 869)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 76)
        Me.Panel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(193, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 25)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "00000000000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 24)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Transaction Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "00000013241"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Invoice No :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 118)
        Me.Panel2.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Symbol", 8.25!)
        Me.TextBox2.Location = New System.Drawing.Point(188, 16)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(279, 41)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 69)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 41)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Code:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_CashOut, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_CashIn, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Balance, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Refund, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_New, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Checkout, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Add, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Advance_Srch, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 209)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(488, 582)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'btn_CashOut
        '
        Me.btn_CashOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_CashOut.Location = New System.Drawing.Point(247, 438)
        Me.btn_CashOut.Name = "btn_CashOut"
        Me.btn_CashOut.Size = New System.Drawing.Size(238, 141)
        Me.btn_CashOut.TabIndex = 7
        Me.btn_CashOut.Text = "Cash Out"
        Me.btn_CashOut.UseVisualStyleBackColor = True
        '
        'btn_CashIn
        '
        Me.btn_CashIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_CashIn.Location = New System.Drawing.Point(3, 438)
        Me.btn_CashIn.Name = "btn_CashIn"
        Me.btn_CashIn.Size = New System.Drawing.Size(238, 141)
        Me.btn_CashIn.TabIndex = 6
        Me.btn_CashIn.Text = "Cash In"
        Me.btn_CashIn.UseVisualStyleBackColor = True
        '
        'btn_Balance
        '
        Me.btn_Balance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Balance.Location = New System.Drawing.Point(247, 293)
        Me.btn_Balance.Name = "btn_Balance"
        Me.btn_Balance.Size = New System.Drawing.Size(238, 139)
        Me.btn_Balance.TabIndex = 5
        Me.btn_Balance.Text = "Settle Customer Balance"
        Me.btn_Balance.UseVisualStyleBackColor = True
        '
        'btn_Refund
        '
        Me.btn_Refund.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Refund.Location = New System.Drawing.Point(3, 293)
        Me.btn_Refund.Name = "btn_Refund"
        Me.btn_Refund.Size = New System.Drawing.Size(238, 139)
        Me.btn_Refund.TabIndex = 4
        Me.btn_Refund.Text = "Refund"
        Me.btn_Refund.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_New.Location = New System.Drawing.Point(3, 148)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(238, 139)
        Me.btn_New.TabIndex = 2
        Me.btn_New.Text = "New Transaction"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_Checkout
        '
        Me.btn_Checkout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Checkout.Location = New System.Drawing.Point(247, 3)
        Me.btn_Checkout.Name = "btn_Checkout"
        Me.btn_Checkout.Size = New System.Drawing.Size(238, 139)
        Me.btn_Checkout.TabIndex = 1
        Me.btn_Checkout.Text = "Checkout"
        Me.btn_Checkout.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Add.Location = New System.Drawing.Point(3, 3)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(238, 139)
        Me.btn_Add.TabIndex = 0
        Me.btn_Add.Text = "Add to Cart"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Advance_Srch
        '
        Me.btn_Advance_Srch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Advance_Srch.Location = New System.Drawing.Point(247, 148)
        Me.btn_Advance_Srch.Name = "btn_Advance_Srch"
        Me.btn_Advance_Srch.Size = New System.Drawing.Size(238, 139)
        Me.btn_Advance_Srch.TabIndex = 9
        Me.btn_Advance_Srch.Text = "Advance Search"
        Me.btn_Advance_Srch.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_Logout)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 797)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(488, 69)
        Me.Panel3.TabIndex = 4
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.Red
        Me.btn_Logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Logout.Location = New System.Drawing.Point(0, 0)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(488, 69)
        Me.btn_Logout.TabIndex = 4
        Me.btn_Logout.Text = "Logout"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'frmPosButtons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 869)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPosButtons"
        Me.Text = "frmPosButtons"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_Advance_Srch As Button
    Friend WithEvents btn_CashOut As Button
    Friend WithEvents btn_CashIn As Button
    Friend WithEvents btn_Balance As Button
    Friend WithEvents btn_Refund As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Checkout As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Logout As Button
End Class
