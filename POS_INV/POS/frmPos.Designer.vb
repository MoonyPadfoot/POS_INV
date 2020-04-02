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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lbl_Header = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lbl_branch_Id = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_transaction_Code = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.tb_customer_Code = New System.Windows.Forms.TextBox()
        Me.tb_customer_Name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.tb_Sales = New System.Windows.Forms.Button()
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
        Me.lbl_user_Id = New System.Windows.Forms.Label()
        Me.lbl_transac_Date = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_pay_Type = New System.Windows.Forms.Label()
        Me.lbl_due_Total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlSearchHolder = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Price = New System.Windows.Forms.TextBox()
        Me.cbo_Price = New MetroFramework.Controls.MetroComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.dg_Order = New System.Windows.Forms.DataGridView()
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
        Me.cbo_Desc = New System.Windows.Forms.ComboBox()
        Me.cbo_Code = New System.Windows.Forms.ComboBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlSearchHolder.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlMid.SuspendLayout()
        CType(Me.dg_Order, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlFooter.Controls.Add(Me.lbl_branch_Id)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 960)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1726, 40)
        Me.pnlFooter.TabIndex = 1
        '
        'lbl_branch_Id
        '
        Me.lbl_branch_Id.AutoSize = True
        Me.lbl_branch_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_branch_Id.Location = New System.Drawing.Point(1568, 11)
        Me.lbl_branch_Id.Name = "lbl_branch_Id"
        Me.lbl_branch_Id.Size = New System.Drawing.Size(18, 20)
        Me.lbl_branch_Id.TabIndex = 10
        Me.lbl_branch_Id.Text = "3"
        Me.lbl_branch_Id.Visible = False
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
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.lbl_transaction_Code)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 80)
        Me.Panel1.TabIndex = 1
        '
        'lbl_transaction_Code
        '
        Me.lbl_transaction_Code.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_transaction_Code.AutoSize = True
        Me.lbl_transaction_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transaction_Code.Location = New System.Drawing.Point(270, 28)
        Me.lbl_transaction_Code.Name = "lbl_transaction_Code"
        Me.lbl_transaction_Code.Size = New System.Drawing.Size(219, 32)
        Me.lbl_transaction_Code.TabIndex = 25
        Me.lbl_transaction_Code.Text = "202003010001"
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
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel8.Controls.Add(Me.tb_customer_Code)
        Me.Panel8.Controls.Add(Me.tb_customer_Name)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 89)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(514, 124)
        Me.Panel8.TabIndex = 2
        '
        'tb_customer_Code
        '
        Me.tb_customer_Code.Enabled = False
        Me.tb_customer_Code.Font = New System.Drawing.Font("Symbol", 8.25!)
        Me.tb_customer_Code.Location = New System.Drawing.Point(188, 24)
        Me.tb_customer_Code.Multiline = True
        Me.tb_customer_Code.Name = "tb_customer_Code"
        Me.tb_customer_Code.Size = New System.Drawing.Size(304, 31)
        Me.tb_customer_Code.TabIndex = 6
        Me.tb_customer_Code.TabStop = False
        '
        'tb_customer_Name
        '
        Me.tb_customer_Name.Enabled = False
        Me.tb_customer_Name.Location = New System.Drawing.Point(188, 69)
        Me.tb_customer_Name.Multiline = True
        Me.tb_customer_Name.Name = "tb_customer_Name"
        Me.tb_customer_Name.Size = New System.Drawing.Size(304, 31)
        Me.tb_customer_Name.TabIndex = 5
        Me.tb_customer_Name.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(160, 25)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Customer Name:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 23)
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
        Me.TableLayoutPanel4.Controls.Add(Me.tb_Sales, 0, 4)
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
        'tb_Sales
        '
        Me.tb_Sales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_Sales.Location = New System.Drawing.Point(3, 487)
        Me.tb_Sales.Name = "tb_Sales"
        Me.tb_Sales.Size = New System.Drawing.Size(251, 119)
        Me.tb_Sales.TabIndex = 13
        Me.tb_Sales.Text = "Daily Sale"
        Me.tb_Sales.UseVisualStyleBackColor = True
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.Red
        Me.btn_Logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Logout.Location = New System.Drawing.Point(260, 487)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(251, 119)
        Me.btn_Logout.TabIndex = 12
        Me.btn_Logout.Text = "Logout"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'btn_CashOut
        '
        Me.btn_CashOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_CashOut.Location = New System.Drawing.Point(260, 366)
        Me.btn_CashOut.Name = "btn_CashOut"
        Me.btn_CashOut.Size = New System.Drawing.Size(251, 115)
        Me.btn_CashOut.TabIndex = 11
        Me.btn_CashOut.Text = "Cash Out"
        Me.btn_CashOut.UseVisualStyleBackColor = True
        '
        'btn_CashIn
        '
        Me.btn_CashIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_CashIn.Location = New System.Drawing.Point(3, 366)
        Me.btn_CashIn.Name = "btn_CashIn"
        Me.btn_CashIn.Size = New System.Drawing.Size(251, 115)
        Me.btn_CashIn.TabIndex = 10
        Me.btn_CashIn.Text = "Cash In"
        Me.btn_CashIn.UseVisualStyleBackColor = True
        '
        'btn_Balance
        '
        Me.btn_Balance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Balance.Location = New System.Drawing.Point(260, 245)
        Me.btn_Balance.Name = "btn_Balance"
        Me.btn_Balance.Size = New System.Drawing.Size(251, 115)
        Me.btn_Balance.TabIndex = 9
        Me.btn_Balance.Text = "Customer Balance"
        Me.btn_Balance.UseVisualStyleBackColor = True
        '
        'btn_Refund
        '
        Me.btn_Refund.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Refund.Location = New System.Drawing.Point(3, 245)
        Me.btn_Refund.Name = "btn_Refund"
        Me.btn_Refund.Size = New System.Drawing.Size(251, 115)
        Me.btn_Refund.TabIndex = 8
        Me.btn_Refund.Text = "Refund"
        Me.btn_Refund.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_New.Location = New System.Drawing.Point(3, 124)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(251, 115)
        Me.btn_New.TabIndex = 6
        Me.btn_New.Text = "New Transaction"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_Checkout
        '
        Me.btn_Checkout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Checkout.Location = New System.Drawing.Point(260, 3)
        Me.btn_Checkout.Name = "btn_Checkout"
        Me.btn_Checkout.Size = New System.Drawing.Size(251, 115)
        Me.btn_Checkout.TabIndex = 5
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
        Me.btn_Advance_Srch.TabIndex = 7
        Me.btn_Advance_Srch.Text = "Advance Search"
        Me.btn_Advance_Srch.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel9.Controls.Add(Me.lbl_user_Id)
        Me.Panel9.Controls.Add(Me.lbl_transac_Date)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.lbl_Username)
        Me.Panel9.Controls.Add(Me.lbl_Name)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 834)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(514, 73)
        Me.Panel9.TabIndex = 4
        '
        'lbl_user_Id
        '
        Me.lbl_user_Id.AutoSize = True
        Me.lbl_user_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user_Id.Location = New System.Drawing.Point(359, 40)
        Me.lbl_user_Id.Name = "lbl_user_Id"
        Me.lbl_user_Id.Size = New System.Drawing.Size(63, 20)
        Me.lbl_user_Id.TabIndex = 9
        Me.lbl_user_Id.Text = "User Id"
        Me.lbl_user_Id.Visible = False
        '
        'lbl_transac_Date
        '
        Me.lbl_transac_Date.AutoSize = True
        Me.lbl_transac_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transac_Date.Location = New System.Drawing.Point(197, 40)
        Me.lbl_transac_Date.Name = "lbl_transac_Date"
        Me.lbl_transac_Date.Size = New System.Drawing.Size(138, 20)
        Me.lbl_transac_Date.TabIndex = 8
        Me.lbl_transac_Date.Text = "Date and Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Transaction Date:"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(359, 10)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(86, 20)
        Me.lbl_Username.TabIndex = 6
        Me.lbl_Username.Text = "Username"
        Me.lbl_Username.Visible = False
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(197, 10)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(89, 20)
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
        Me.pnlBottom.Controls.Add(Me.lbl_due_Total)
        Me.pnlBottom.Controls.Add(Me.Label7)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 818)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1206, 92)
        Me.pnlBottom.TabIndex = 3
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
        Me.lbl_pay_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pay_Type.Location = New System.Drawing.Point(249, 23)
        Me.lbl_pay_Type.Name = "lbl_pay_Type"
        Me.lbl_pay_Type.Size = New System.Drawing.Size(117, 46)
        Me.lbl_pay_Type.TabIndex = 31
        Me.lbl_pay_Type.Text = "Cash"
        '
        'lbl_due_Total
        '
        Me.lbl_due_Total.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_due_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_due_Total.Location = New System.Drawing.Point(880, 19)
        Me.lbl_due_Total.Name = "lbl_due_Total"
        Me.lbl_due_Total.Size = New System.Drawing.Size(314, 50)
        Me.lbl_due_Total.TabIndex = 25
        Me.lbl_due_Total.Text = "200,000.00"
        Me.lbl_due_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlSearchHolder.Size = New System.Drawing.Size(1206, 237)
        Me.pnlSearchHolder.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cbo_Desc)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 118)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1206, 117)
        Me.Panel5.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 29)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Description:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbo_Code)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.tb_Price)
        Me.Panel4.Controls.Add(Me.cbo_Price)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1206, 118)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Code:"
        '
        'tb_Price
        '
        Me.tb_Price.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tb_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Price.Location = New System.Drawing.Point(926, 44)
        Me.tb_Price.MaxLength = 9
        Me.tb_Price.Multiline = True
        Me.tb_Price.Name = "tb_Price"
        Me.tb_Price.ReadOnly = True
        Me.tb_Price.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tb_Price.Size = New System.Drawing.Size(268, 64)
        Me.tb_Price.TabIndex = 4
        Me.tb_Price.TabStop = False
        Me.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbo_Price
        '
        Me.cbo_Price.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_Price.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cbo_Price.FormattingEnabled = True
        Me.cbo_Price.ItemHeight = 29
        Me.cbo_Price.Items.AddRange(New Object() {"A", "B"})
        Me.cbo_Price.Location = New System.Drawing.Point(813, 53)
        Me.cbo_Price.Name = "cbo_Price"
        Me.cbo_Price.Size = New System.Drawing.Size(81, 35)
        Me.cbo_Price.TabIndex = 3
        Me.cbo_Price.TabStop = False
        Me.cbo_Price.UseSelectable = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(808, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 29)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Price:"
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
        Me.pnlMid.Controls.Add(Me.dg_Order)
        Me.pnlMid.Controls.Add(Me.Panel3)
        Me.pnlMid.Controls.Add(Me.Panel2)
        Me.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMid.Location = New System.Drawing.Point(0, 237)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(1206, 581)
        Me.pnlMid.TabIndex = 24
        '
        'dg_Order
        '
        Me.dg_Order.AllowUserToAddRows = False
        Me.dg_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column8, Me.Column9, Me.Column1, Me.Column2, Me.DataGridViewButtonColumn3, Me.Column3})
        Me.dg_Order.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Order.Location = New System.Drawing.Point(13, 0)
        Me.dg_Order.Name = "dg_Order"
        Me.dg_Order.RowHeadersVisible = False
        Me.dg_Order.RowHeadersWidth = 51
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dg_Order.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_Order.RowTemplate.Height = 24
        Me.dg_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Order.Size = New System.Drawing.Size(1181, 581)
        Me.dg_Order.TabIndex = 4
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
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Description"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Price"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column9.Width = 69
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Qty"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 59
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "Total"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        Me.Panel3.Size = New System.Drawing.Size(12, 581)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 581)
        Me.Panel2.TabIndex = 1
        '
        'cbo_Desc
        '
        Me.cbo_Desc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_Desc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbo_Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Desc.FormattingEnabled = True
        Me.cbo_Desc.Location = New System.Drawing.Point(12, 41)
        Me.cbo_Desc.MaxLength = 50
        Me.cbo_Desc.Name = "cbo_Desc"
        Me.cbo_Desc.Size = New System.Drawing.Size(1182, 64)
        Me.cbo_Desc.TabIndex = 51
        '
        'cbo_Code
        '
        Me.cbo_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_Code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbo_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Code.FormattingEnabled = True
        Me.cbo_Code.Location = New System.Drawing.Point(12, 44)
        Me.cbo_Code.MaxLength = 50
        Me.cbo_Code.Name = "cbo_Code"
        Me.cbo_Code.Size = New System.Drawing.Size(772, 64)
        Me.cbo_Code.TabIndex = 53
        '
        'frmPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1726, 1000)
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
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlSearchHolder.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlMid.ResumeLayout(False)
        CType(Me.dg_Order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lbl_Header As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents tb_customer_Code As TextBox
    Friend WithEvents tb_customer_Name As TextBox
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
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents lbl_due_Total As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlSearchHolder As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlMid As Panel
    Friend WithEvents dg_Order As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tb_Price As TextBox
    Friend WithEvents cbo_Price As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_pay_Type As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_transaction_Code As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_transac_Date As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Sales As Button
    Friend WithEvents lbl_user_Id As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn3 As DataGridViewButtonColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents lbl_branch_Id As Label
    Friend WithEvents cbo_Desc As ComboBox
    Friend WithEvents cbo_Code As ComboBox
End Class
