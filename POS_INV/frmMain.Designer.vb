<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lbl_branch_Id = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.lbl_Header = New System.Windows.Forms.Label()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Help = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Profile = New System.Windows.Forms.Button()
        Me.btn_sales_Report = New System.Windows.Forms.Button()
        Me.btn_Pos = New System.Windows.Forms.Button()
        Me.btn_Inventory = New System.Windows.Forms.Button()
        Me.btn_Customer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1568, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 38)
        Me.Panel4.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Time:"
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlFooter.Controls.Add(Me.Panel4)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 532)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1878, 38)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lbl_branch_Id)
        Me.pnlHeader.Controls.Add(Me.lbl_Username)
        Me.pnlHeader.Controls.Add(Me.btn_Logout)
        Me.pnlHeader.Controls.Add(Me.lbl_Header)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1878, 48)
        Me.pnlHeader.TabIndex = 0
        '
        'lbl_branch_Id
        '
        Me.lbl_branch_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_branch_Id.Location = New System.Drawing.Point(685, 11)
        Me.lbl_branch_Id.Name = "lbl_branch_Id"
        Me.lbl_branch_Id.Size = New System.Drawing.Size(156, 26)
        Me.lbl_branch_Id.TabIndex = 15
        Me.lbl_branch_Id.Text = "Branch"
        Me.lbl_branch_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Username
        '
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.Location = New System.Drawing.Point(861, 11)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(156, 26)
        Me.lbl_Username.TabIndex = 14
        Me.lbl_Username.Text = "Admin"
        Me.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_Logout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Location = New System.Drawing.Point(1828, 0)
        Me.btn_Logout.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(50, 48)
        Me.btn_Logout.TabIndex = 9
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'lbl_Header
        '
        Me.lbl_Header.AutoSize = True
        Me.lbl_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Header.ForeColor = System.Drawing.Color.White
        Me.lbl_Header.Location = New System.Drawing.Point(12, 15)
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New System.Drawing.Size(338, 24)
        Me.lbl_Header.TabIndex = 4
        Me.lbl_Header.Text = "AJE Point of Sale and Inventory System"
        '
        'pnlBody
        '
        Me.pnlBody.Controls.Add(Me.pnlMid)
        Me.pnlBody.Controls.Add(Me.Panel3)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 48)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1878, 484)
        Me.pnlBody.TabIndex = 3
        '
        'pnlMid
        '
        Me.pnlMid.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMid.Location = New System.Drawing.Point(0, 59)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(1878, 425)
        Me.pnlMid.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1878, 59)
        Me.Panel3.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1878, 59)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Help, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Profile, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_sales_Report, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Pos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Inventory, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Customer, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 7, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1878, 59)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'btn_Help
        '
        Me.btn_Help.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Help.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Help.Location = New System.Drawing.Point(1170, 0)
        Me.btn_Help.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Help.Name = "btn_Help"
        Me.btn_Help.Size = New System.Drawing.Size(234, 59)
        Me.btn_Help.TabIndex = 13
        Me.btn_Help.Text = "&Help [F6]"
        Me.btn_Help.UseVisualStyleBackColor = False
        Me.btn_Help.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_Name)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1407, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(228, 53)
        Me.Panel5.TabIndex = 12
        '
        'lbl_Name
        '
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(72, 19)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(153, 23)
        Me.lbl_Name.TabIndex = 15
        Me.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Name:"
        '
        'btn_Profile
        '
        Me.btn_Profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Profile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Profile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Profile.Location = New System.Drawing.Point(234, 0)
        Me.btn_Profile.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Profile.Name = "btn_Profile"
        Me.btn_Profile.Size = New System.Drawing.Size(234, 59)
        Me.btn_Profile.TabIndex = 9
        Me.btn_Profile.Text = "&Profiling [F2]"
        Me.btn_Profile.UseVisualStyleBackColor = False
        '
        'btn_sales_Report
        '
        Me.btn_sales_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_sales_Report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_sales_Report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_sales_Report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sales_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sales_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sales_Report.Location = New System.Drawing.Point(936, 0)
        Me.btn_sales_Report.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_sales_Report.Name = "btn_sales_Report"
        Me.btn_sales_Report.Size = New System.Drawing.Size(234, 59)
        Me.btn_sales_Report.TabIndex = 6
        Me.btn_sales_Report.Text = "&Sales Report [F5]"
        Me.btn_sales_Report.UseVisualStyleBackColor = False
        '
        'btn_Pos
        '
        Me.btn_Pos.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Pos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Pos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Pos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Pos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btn_Pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pos.Location = New System.Drawing.Point(0, 0)
        Me.btn_Pos.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Pos.Name = "btn_Pos"
        Me.btn_Pos.Size = New System.Drawing.Size(234, 59)
        Me.btn_Pos.TabIndex = 0
        Me.btn_Pos.Text = "&Point of Sale [F1]"
        Me.btn_Pos.UseVisualStyleBackColor = False
        '
        'btn_Inventory
        '
        Me.btn_Inventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Inventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Inventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Inventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Inventory.Location = New System.Drawing.Point(468, 0)
        Me.btn_Inventory.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Inventory.Name = "btn_Inventory"
        Me.btn_Inventory.Size = New System.Drawing.Size(234, 59)
        Me.btn_Inventory.TabIndex = 3
        Me.btn_Inventory.Text = "I&nventory [F3]"
        Me.btn_Inventory.UseVisualStyleBackColor = False
        '
        'btn_Customer
        '
        Me.btn_Customer.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Customer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Customer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Customer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Customer.Location = New System.Drawing.Point(702, 0)
        Me.btn_Customer.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Customer.Name = "btn_Customer"
        Me.btn_Customer.Size = New System.Drawing.Size(234, 59)
        Me.btn_Customer.TabIndex = 5
        Me.btn_Customer.Text = "&Customers [F4]"
        Me.btn_Customer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Type)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1641, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 53)
        Me.Panel1.TabIndex = 11
        '
        'lbl_Type
        '
        Me.lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.Location = New System.Drawing.Point(69, 17)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(156, 26)
        Me.lbl_Type.TabIndex = 13
        Me.lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "User:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1878, 570)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lbl_Header As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlMid As Panel
    Friend WithEvents btn_Pos As Button
    Friend WithEvents btn_Profile As Button
    Friend WithEvents btn_Inventory As Button
    Friend WithEvents btn_Customer As Button
    Friend WithEvents btn_sales_Report As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_Logout As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_Name As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Type As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Help As Button
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_branch_Id As Label
End Class
