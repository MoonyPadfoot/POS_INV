<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPos
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lbl_Header = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.btn_CashOut = New System.Windows.Forms.Button()
        Me.btn_CashIn = New System.Windows.Forms.Button()
        Me.btn_Balance = New System.Windows.Forms.Button()
        Me.btn_Refund = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_Checkout = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Advance_Srch = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_dateTime = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlSearchHolder = New System.Windows.Forms.Panel()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_pay_Type = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlSearchHolder.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlMid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lbl_Header)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1726, 50)
        Me.pnlHeader.TabIndex = 0
        '
        'lbl_Header
        '
        Me.lbl_Header.AutoSize = True
        Me.lbl_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header.ForeColor = System.Drawing.Color.White
        Me.lbl_Header.Location = New System.Drawing.Point(12, 15)
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New System.Drawing.Size(338, 24)
        Me.lbl_Header.TabIndex = 5
        Me.lbl_Header.Text = "AJE Point of Sale and Inventory System"
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.SystemColors.GrayText
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 960)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1726, 40)
        Me.pnlFooter.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date and Time:"
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pnlRight.Controls.Add(Me.TableLayoutPanel3)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(1206, 50)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(520, 910)
        Me.pnlRight.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel8, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel9, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.52389!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28583!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.67024!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.520032!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(520, 910)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel8.Controls.Add(Me.TextBox2)
        Me.Panel8.Controls.Add(Me.TextBox1)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 89)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(514, 124)
        Me.Panel8.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Symbol", 8.25!)
        Me.TextBox2.Location = New System.Drawing.Point(188, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(304, 31)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 64)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 31)
        Me.TextBox1.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(160, 25)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Customer Name:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 25)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Customer Code:"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Logout, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_CashOut, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_CashIn, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Balance, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Refund, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_New, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Checkout, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Add, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Advance_Srch, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 219)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(514, 609)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.Red
        Me.btn_Logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Logout.Location = New System.Drawing.Point(260, 487)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(251, 119)
        Me.btn_Logout.TabIndex = 4
        Me.btn_Logout.Text = "Logout"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'btn_CashOut
        '
        Me.btn_CashOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_CashOut.Location = New System.Drawing.Point(260, 366)
        Me.btn_CashOut.Name = "btn_CashOut"
        Me.btn_CashOut.Size = New System.Drawing.Size(251, 115)
        Me.btn_CashOut.TabIndex = 7
        Me.btn_CashOut.Text = "Cash Out"
        Me.btn_CashOut.UseVisualStyleBackColor = True
        '
        'btn_CashIn
        '
        Me.btn_CashIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_CashIn.Location = New System.Drawing.Point(3, 366)
        Me.btn_CashIn.Name = "btn_CashIn"
        Me.btn_CashIn.Size = New System.Drawing.Size(251, 115)
        Me.btn_CashIn.TabIndex = 6
        Me.btn_CashIn.Text = "Cash In"
        Me.btn_CashIn.UseVisualStyleBackColor = True
        '
        'btn_Balance
        '
        Me.btn_Balance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Balance.Location = New System.Drawing.Point(260, 245)
        Me.btn_Balance.Name = "btn_Balance"
        Me.btn_Balance.Size = New System.Drawing.Size(251, 115)
        Me.btn_Balance.TabIndex = 5
        Me.btn_Balance.Text = "Settle Customer Balance"
        Me.btn_Balance.UseVisualStyleBackColor = True
        '
        'btn_Refund
        '
        Me.btn_Refund.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Refund.Location = New System.Drawing.Point(3, 245)
        Me.btn_Refund.Name = "btn_Refund"
        Me.btn_Refund.Size = New System.Drawing.Size(251, 115)
        Me.btn_Refund.TabIndex = 4
        Me.btn_Refund.Text = "Refund"
        Me.btn_Refund.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_New.Location = New System.Drawing.Point(3, 124)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(251, 115)
        Me.btn_New.TabIndex = 2
        Me.btn_New.Text = "New Transaction"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_Checkout
        '
        Me.btn_Checkout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Checkout.Location = New System.Drawing.Point(260, 3)
        Me.btn_Checkout.Name = "btn_Checkout"
        Me.btn_Checkout.Size = New System.Drawing.Size(251, 115)
        Me.btn_Checkout.TabIndex = 1
        Me.btn_Checkout.Text = "Checkout"
        Me.btn_Checkout.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Add.Location = New System.Drawing.Point(3, 3)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(251, 115)
        Me.btn_Add.TabIndex = 0
        Me.btn_Add.Text = "Add to Cart"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Advance_Srch
        '
        Me.btn_Advance_Srch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Advance_Srch.Location = New System.Drawing.Point(260, 124)
        Me.btn_Advance_Srch.Name = "btn_Advance_Srch"
        Me.btn_Advance_Srch.Size = New System.Drawing.Size(251, 115)
        Me.btn_Advance_Srch.TabIndex = 9
        Me.btn_Advance_Srch.Text = "Advance Search"
        Me.btn_Advance_Srch.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel9.Controls.Add(Me.lbl_Username)
        Me.Panel9.Controls.Add(Me.lbl_dateTime)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.lbl_Name)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 834)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(514, 73)
        Me.Panel9.TabIndex = 4
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(411, 10)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(81, 20)
        Me.lbl_Username.TabIndex = 6
        Me.lbl_Username.Text = "John Doe"
        Me.lbl_Username.Visible = False
        '
        'lbl_dateTime
        '
        Me.lbl_dateTime.AutoSize = True
        Me.lbl_dateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dateTime.Location = New System.Drawing.Point(179, 37)
        Me.lbl_dateTime.Name = "lbl_dateTime"
        Me.lbl_dateTime.Size = New System.Drawing.Size(124, 20)
        Me.lbl_dateTime.TabIndex = 5
        Me.lbl_dateTime.Text = "Date and Time:"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(180, 10)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(81, 20)
        Me.lbl_Name.TabIndex = 4
        Me.lbl_Name.Text = "John Doe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cashier Name:"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.Label5)
        Me.pnlBottom.Controls.Add(Me.lbl_pay_Type)
        Me.pnlBottom.Controls.Add(Me.Label4)
        Me.pnlBottom.Controls.Add(Me.Label7)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 818)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1206, 92)
        Me.pnlBottom.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(880, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(314, 50)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "200,000.00"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(672, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 46)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Due Total:"
        '
        'pnlSearchHolder
        '
        Me.pnlSearchHolder.Controls.Add(Me.Panel5)
        Me.pnlSearchHolder.Controls.Add(Me.Panel4)
        Me.pnlSearchHolder.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchHolder.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearchHolder.Name = "pnlSearchHolder"
        Me.pnlSearchHolder.Size = New System.Drawing.Size(1206, 232)
        Me.pnlSearchHolder.TabIndex = 23
        '
        'pnlBody
        '
        Me.pnlBody.Controls.Add(Me.pnlMid)
        Me.pnlBody.Controls.Add(Me.pnlSearchHolder)
        Me.pnlBody.Controls.Add(Me.pnlBottom)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 50)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1206, 910)
        Me.pnlBody.TabIndex = 3
        '
        'pnlMid
        '
        Me.pnlMid.Controls.Add(Me.DataGridView1)
        Me.pnlMid.Controls.Add(Me.Panel3)
        Me.pnlMid.Controls.Add(Me.Panel2)
        Me.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMid.Location = New System.Drawing.Point(0, 232)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(1206, 586)
        Me.pnlMid.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column8, Me.Column9, Me.Column1, Me.Column2, Me.DataGridViewButtonColumn3, Me.Column3})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(13, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1181, 586)
        Me.DataGridView1.TabIndex = 4
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Description"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Price"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 69
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Qty"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 59
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "Total"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 69
        '
        'DataGridViewButtonColumn3
        '
        Me.DataGridViewButtonColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewButtonColumn3.HeaderText = ""
        Me.DataGridViewButtonColumn3.MinimumWidth = 6
        Me.DataGridViewButtonColumn3.Name = "DataGridViewButtonColumn3"
        Me.DataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewButtonColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewButtonColumn3.Width = 23
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = ""
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.Width = 23
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1194, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(12, 586)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 586)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.TextBox6)
        Me.Panel4.Controls.Add(Me.MetroComboBox1)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1206, 113)
        Me.Panel4.TabIndex = 0
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(924, 39)
        Me.TextBox6.MaxLength = 9
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox6.Size = New System.Drawing.Size(268, 63)
        Me.TextBox6.TabIndex = 46
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 24
        Me.MetroComboBox1.Items.AddRange(New Object() {"A", "B"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(813, 51)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(81, 30)
        Me.MetroComboBox1.TabIndex = 49
        Me.MetroComboBox1.UseSelectable = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(808, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 29)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Price:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.TextBox5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 113)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1206, 119)
        Me.Panel5.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 29)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Description:"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(13, 32)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(1179, 63)
        Me.TextBox5.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Code:"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(13, 39)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(768, 63)
        Me.TextBox4.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 36)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Payment Type:"
        '
        'lbl_pay_Type
        '
        Me.lbl_pay_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_pay_Type.AutoSize = True
        Me.lbl_pay_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pay_Type.Location = New System.Drawing.Point(249, 23)
        Me.lbl_pay_Type.Name = "lbl_pay_Type"
        Me.lbl_pay_Type.Size = New System.Drawing.Size(42, 46)
        Me.lbl_pay_Type.TabIndex = 31
        Me.lbl_pay_Type.Text = "b"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 80)
        Me.Panel1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(247, 32)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Transaction Code:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(270, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 32)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "00000000000"
        '
        'frmPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1726, 981)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1500, 1000)
        Me.Name = "frmPos"
        Me.Text = "frmPos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlSearchHolder.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlMid.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lbl_Header As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btn_CashOut As Button
    Friend WithEvents btn_CashIn As Button
    Friend WithEvents btn_Balance As Button
    Friend WithEvents btn_Refund As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Checkout As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Advance_Srch As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btn_Logout As Button
    Friend WithEvents lbl_Name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_dateTime As Label
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlSearchHolder As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlMid As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn3 As DataGridViewButtonColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_Username As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_pay_Type As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
