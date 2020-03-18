<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Gname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Suffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.cbo_Category = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_amount_Receivable = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_Balance = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_row_Count = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.pnlHeader)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1281, 629)
        Me.Panel1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Column6, Me.col_Code, Me.col_Gname, Me.col_Mi, Me.col_Fname, Me.col_Suffix, Me.Column1, Me.col_Balance, Me.col_Edit, Me.col_Delete})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1281, 376)
        Me.DataGridView1.TabIndex = 8
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "#"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 45
        '
        'col_Code
        '
        Me.col_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.col_Code.HeaderText = "Customer Code"
        Me.col_Code.MinimumWidth = 6
        Me.col_Code.Name = "col_Code"
        Me.col_Code.ReadOnly = True
        Me.col_Code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Code.Width = 123
        '
        'col_Gname
        '
        Me.col_Gname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_Gname.HeaderText = "Given Name"
        Me.col_Gname.MinimumWidth = 6
        Me.col_Gname.Name = "col_Gname"
        Me.col_Gname.ReadOnly = True
        Me.col_Gname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Mi
        '
        Me.col_Mi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.col_Mi.HeaderText = "M.I."
        Me.col_Mi.MinimumWidth = 6
        Me.col_Mi.Name = "col_Mi"
        Me.col_Mi.ReadOnly = True
        Me.col_Mi.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Mi.Width = 59
        '
        'col_Fname
        '
        Me.col_Fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_Fname.HeaderText = "Family Name"
        Me.col_Fname.MinimumWidth = 6
        Me.col_Fname.Name = "col_Fname"
        Me.col_Fname.ReadOnly = True
        Me.col_Fname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Suffix
        '
        Me.col_Suffix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.col_Suffix.HeaderText = "Suffix"
        Me.col_Suffix.MinimumWidth = 6
        Me.col_Suffix.Name = "col_Suffix"
        Me.col_Suffix.ReadOnly = True
        Me.col_Suffix.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Suffix.Width = 71
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column1.HeaderText = "Credit Limit"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 99
        '
        'col_Balance
        '
        Me.col_Balance.HeaderText = "Balance"
        Me.col_Balance.MinimumWidth = 6
        Me.col_Balance.Name = "col_Balance"
        Me.col_Balance.Visible = False
        Me.col_Balance.Width = 125
        '
        'col_Edit
        '
        Me.col_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Edit.HeaderText = ""
        Me.col_Edit.MinimumWidth = 6
        Me.col_Edit.Name = "col_Edit"
        Me.col_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Edit.Width = 23
        '
        'col_Delete
        '
        Me.col_Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Delete.HeaderText = ""
        Me.col_Delete.MinimumWidth = 6
        Me.col_Delete.Name = "col_Delete"
        Me.col_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Delete.Width = 23
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btn_Add)
        Me.Panel3.Controls.Add(Me.cbo_Category)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.tb_Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1281, 91)
        Me.Panel3.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(817, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Filter By:"
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(1113, 28)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(128, 34)
        Me.btn_Add.TabIndex = 5
        Me.btn_Add.Text = "Add Customer"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'cbo_Category
        '
        Me.cbo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Category.FormattingEnabled = True
        Me.cbo_Category.Items.AddRange(New Object() {"Name", "Code"})
        Me.cbo_Category.Location = New System.Drawing.Point(902, 34)
        Me.cbo_Category.Name = "cbo_Category"
        Me.cbo_Category.Size = New System.Drawing.Size(183, 24)
        Me.cbo_Category.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search:"
        '
        'tb_Search
        '
        Me.tb_Search.Location = New System.Drawing.Point(114, 34)
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.Size = New System.Drawing.Size(663, 22)
        Me.tb_Search.TabIndex = 3
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.Panel5)
        Me.pnlHeader.Controls.Add(Me.Label21)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1281, 85)
        Me.pnlHeader.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_Close)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1178, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(103, 85)
        Me.Panel5.TabIndex = 3
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(20, 12)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(63, 53)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = " "
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(28, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(214, 44)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Customers"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_row_Count)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lbl_amount_Receivable)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 552)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1281, 77)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Total Amount(s) Receivable:"
        '
        'lbl_amount_Receivable
        '
        Me.lbl_amount_Receivable.AutoSize = True
        Me.lbl_amount_Receivable.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount_Receivable.Location = New System.Drawing.Point(404, 28)
        Me.lbl_amount_Receivable.Name = "lbl_amount_Receivable"
        Me.lbl_amount_Receivable.Size = New System.Drawing.Size(85, 17)
        Me.lbl_amount_Receivable.TabIndex = 29
        Me.lbl_amount_Receivable.Text = "Row Count"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl_Balance)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(618, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(663, 77)
        Me.Panel4.TabIndex = 28
        '
        'lbl_Balance
        '
        Me.lbl_Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Balance.Location = New System.Drawing.Point(301, 13)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(350, 50)
        Me.lbl_Balance.TabIndex = 27
        Me.lbl_Balance.Text = "200,000.00"
        Me.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 46)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "User Balance:"
        '
        'lbl_row_Count
        '
        Me.lbl_row_Count.AutoSize = True
        Me.lbl_row_Count.Location = New System.Drawing.Point(33, 28)
        Me.lbl_row_Count.Name = "lbl_row_Count"
        Me.lbl_row_Count.Size = New System.Drawing.Size(76, 17)
        Me.lbl_row_Count.TabIndex = 31
        Me.lbl_row_Count.Text = "Row Count"
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 629)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomers"
        Me.Text = "frmCustomers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_Balance As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Add As Button
    Friend WithEvents cbo_Category As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_amount_Receivable As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents col_Code As DataGridViewTextBoxColumn
    Friend WithEvents col_Gname As DataGridViewTextBoxColumn
    Friend WithEvents col_Mi As DataGridViewTextBoxColumn
    Friend WithEvents col_Fname As DataGridViewTextBoxColumn
    Friend WithEvents col_Suffix As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents col_Balance As DataGridViewTextBoxColumn
    Friend WithEvents col_Edit As DataGridViewButtonColumn
    Friend WithEvents col_Delete As DataGridViewButtonColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents lbl_row_Count As Label
End Class
