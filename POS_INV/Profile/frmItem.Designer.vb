<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItem
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tp_Items = New System.Windows.Forms.TabPage()
        Me.dg_Items = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_row_count_Items = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.cbo_Filter = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.tp_Category = New System.Windows.Forms.TabPage()
        Me.dg_Category = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_edit_Category = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_delete_Category = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_row_count_Category = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_new_Category = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_search_Category = New System.Windows.Forms.TextBox()
        Me.tp_Brand = New System.Windows.Forms.TabPage()
        Me.dg_Brand = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_edit_Brand = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_delete_Brand = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_row_count_Brand = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_new_Brand = New System.Windows.Forms.Button()
        Me.tb_search_Brand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_add_Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MetroTabControl1.SuspendLayout()
        Me.tp_Items.SuspendLayout()
        CType(Me.dg_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tp_Category.SuspendLayout()
        CType(Me.dg_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tp_Brand.SuspendLayout()
        CType(Me.dg_Brand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tp_Items)
        Me.MetroTabControl1.Controls.Add(Me.tp_Category)
        Me.MetroTabControl1.Controls.Add(Me.tp_Brand)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1248, 470)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'tp_Items
        '
        Me.tp_Items.Controls.Add(Me.dg_Items)
        Me.tp_Items.Controls.Add(Me.Panel5)
        Me.tp_Items.Controls.Add(Me.Panel2)
        Me.tp_Items.Location = New System.Drawing.Point(4, 38)
        Me.tp_Items.Name = "tp_Items"
        Me.tp_Items.Size = New System.Drawing.Size(1240, 428)
        Me.tp_Items.TabIndex = 0
        Me.tp_Items.Text = "Manage Items"
        '
        'dg_Items
        '
        Me.dg_Items.AllowUserToAddRows = False
        Me.dg_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column6, Me.DataGridViewTextBoxColumn2, Me.Column7, Me.Column8, Me.col_add_Description, Me.DataGridViewTextBoxColumn3, Me.Column11, Me.Column9, Me.Column10, Me.col_Edit, Me.col_Delete})
        Me.dg_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Items.Location = New System.Drawing.Point(0, 67)
        Me.dg_Items.Name = "dg_Items"
        Me.dg_Items.RowHeadersVisible = False
        Me.dg_Items.RowHeadersWidth = 51
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dg_Items.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_Items.RowTemplate.Height = 24
        Me.dg_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Items.Size = New System.Drawing.Size(1240, 301)
        Me.dg_Items.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_row_count_Items)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 368)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1240, 60)
        Me.Panel5.TabIndex = 26
        '
        'lbl_row_count_Items
        '
        Me.lbl_row_count_Items.AutoSize = True
        Me.lbl_row_count_Items.Location = New System.Drawing.Point(27, 21)
        Me.lbl_row_count_Items.Name = "lbl_row_count_Items"
        Me.lbl_row_count_Items.Size = New System.Drawing.Size(76, 17)
        Me.lbl_row_count_Items.TabIndex = 9
        Me.lbl_row_count_Items.Text = "Row Count"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btn_Add)
        Me.Panel2.Controls.Add(Me.cbo_Filter)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tb_Search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1240, 67)
        Me.Panel2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(789, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Filter By:"
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(1087, 16)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(128, 34)
        Me.btn_Add.TabIndex = 5
        Me.btn_Add.Text = "Add Item"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'cbo_Filter
        '
        Me.cbo_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Filter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbo_Filter.FormattingEnabled = True
        Me.cbo_Filter.Items.AddRange(New Object() {"Code", "Description", "Brand", "Category"})
        Me.cbo_Filter.Location = New System.Drawing.Point(877, 20)
        Me.cbo_Filter.Name = "cbo_Filter"
        Me.cbo_Filter.Size = New System.Drawing.Size(183, 24)
        Me.cbo_Filter.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search:"
        '
        'tb_Search
        '
        Me.tb_Search.Location = New System.Drawing.Point(93, 22)
        Me.tb_Search.MaxLength = 100
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.ShortcutsEnabled = False
        Me.tb_Search.Size = New System.Drawing.Size(663, 22)
        Me.tb_Search.TabIndex = 3
        '
        'tp_Category
        '
        Me.tp_Category.Controls.Add(Me.dg_Category)
        Me.tp_Category.Controls.Add(Me.Panel4)
        Me.tp_Category.Controls.Add(Me.Panel1)
        Me.tp_Category.Location = New System.Drawing.Point(4, 38)
        Me.tp_Category.Name = "tp_Category"
        Me.tp_Category.Size = New System.Drawing.Size(1240, 428)
        Me.tp_Category.TabIndex = 1
        Me.tp_Category.Text = "Category"
        '
        'dg_Category
        '
        Me.dg_Category.AllowUserToAddRows = False
        Me.dg_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Category.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.col_edit_Category, Me.col_delete_Category})
        Me.dg_Category.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Category.Location = New System.Drawing.Point(0, 67)
        Me.dg_Category.Name = "dg_Category"
        Me.dg_Category.RowHeadersVisible = False
        Me.dg_Category.RowHeadersWidth = 51
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dg_Category.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_Category.RowTemplate.Height = 24
        Me.dg_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Category.Size = New System.Drawing.Size(1240, 301)
        Me.dg_Category.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "#"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 45
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Category"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_edit_Category
        '
        Me.col_edit_Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_edit_Category.HeaderText = ""
        Me.col_edit_Category.MinimumWidth = 6
        Me.col_edit_Category.Name = "col_edit_Category"
        Me.col_edit_Category.ReadOnly = True
        Me.col_edit_Category.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_edit_Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_edit_Category.Width = 23
        '
        'col_delete_Category
        '
        Me.col_delete_Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_delete_Category.HeaderText = ""
        Me.col_delete_Category.MinimumWidth = 6
        Me.col_delete_Category.Name = "col_delete_Category"
        Me.col_delete_Category.ReadOnly = True
        Me.col_delete_Category.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_delete_Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_delete_Category.Width = 23
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl_row_count_Category)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 368)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1240, 60)
        Me.Panel4.TabIndex = 27
        '
        'lbl_row_count_Category
        '
        Me.lbl_row_count_Category.AutoSize = True
        Me.lbl_row_count_Category.Location = New System.Drawing.Point(27, 21)
        Me.lbl_row_count_Category.Name = "lbl_row_count_Category"
        Me.lbl_row_count_Category.Size = New System.Drawing.Size(76, 17)
        Me.lbl_row_count_Category.TabIndex = 9
        Me.lbl_row_count_Category.Text = "Row Count"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_new_Category)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tb_search_Category)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 67)
        Me.Panel1.TabIndex = 2
        '
        'btn_new_Category
        '
        Me.btn_new_Category.Location = New System.Drawing.Point(643, 17)
        Me.btn_new_Category.Name = "btn_new_Category"
        Me.btn_new_Category.Size = New System.Drawing.Size(128, 34)
        Me.btn_new_Category.TabIndex = 2
        Me.btn_new_Category.Text = "Create New"
        Me.btn_new_Category.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search:"
        '
        'tb_search_Category
        '
        Me.tb_search_Category.Location = New System.Drawing.Point(90, 23)
        Me.tb_search_Category.Name = "tb_search_Category"
        Me.tb_search_Category.Size = New System.Drawing.Size(519, 22)
        Me.tb_search_Category.TabIndex = 0
        '
        'tp_Brand
        '
        Me.tp_Brand.Controls.Add(Me.dg_Brand)
        Me.tp_Brand.Controls.Add(Me.Panel6)
        Me.tp_Brand.Controls.Add(Me.Panel3)
        Me.tp_Brand.Location = New System.Drawing.Point(4, 38)
        Me.tp_Brand.Name = "tp_Brand"
        Me.tp_Brand.Size = New System.Drawing.Size(1240, 428)
        Me.tp_Brand.TabIndex = 2
        Me.tp_Brand.Text = "Brand"
        '
        'dg_Brand
        '
        Me.dg_Brand.AllowUserToAddRows = False
        Me.dg_Brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Brand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.col_edit_Brand, Me.col_delete_Brand})
        Me.dg_Brand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Brand.Location = New System.Drawing.Point(0, 67)
        Me.dg_Brand.Name = "dg_Brand"
        Me.dg_Brand.RowHeadersVisible = False
        Me.dg_Brand.RowHeadersWidth = 51
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dg_Brand.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dg_Brand.RowTemplate.Height = 24
        Me.dg_Brand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Brand.Size = New System.Drawing.Size(1240, 301)
        Me.dg_Brand.TabIndex = 9
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
        Me.DataGridViewTextBoxColumn5.HeaderText = "#"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.Width = 45
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.HeaderText = "Brand Name"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_edit_Brand
        '
        Me.col_edit_Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_edit_Brand.HeaderText = ""
        Me.col_edit_Brand.MinimumWidth = 6
        Me.col_edit_Brand.Name = "col_edit_Brand"
        Me.col_edit_Brand.ReadOnly = True
        Me.col_edit_Brand.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_edit_Brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_edit_Brand.Width = 23
        '
        'col_delete_Brand
        '
        Me.col_delete_Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_delete_Brand.HeaderText = ""
        Me.col_delete_Brand.MinimumWidth = 6
        Me.col_delete_Brand.Name = "col_delete_Brand"
        Me.col_delete_Brand.ReadOnly = True
        Me.col_delete_Brand.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_delete_Brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_delete_Brand.Width = 23
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lbl_row_count_Brand)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 368)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1240, 60)
        Me.Panel6.TabIndex = 27
        '
        'lbl_row_count_Brand
        '
        Me.lbl_row_count_Brand.AutoSize = True
        Me.lbl_row_count_Brand.Location = New System.Drawing.Point(27, 21)
        Me.lbl_row_count_Brand.Name = "lbl_row_count_Brand"
        Me.lbl_row_count_Brand.Size = New System.Drawing.Size(76, 17)
        Me.lbl_row_count_Brand.TabIndex = 9
        Me.lbl_row_count_Brand.Text = "Row Count"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_new_Brand)
        Me.Panel3.Controls.Add(Me.tb_search_Brand)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1240, 67)
        Me.Panel3.TabIndex = 8
        '
        'btn_new_Brand
        '
        Me.btn_new_Brand.Location = New System.Drawing.Point(643, 17)
        Me.btn_new_Brand.Name = "btn_new_Brand"
        Me.btn_new_Brand.Size = New System.Drawing.Size(128, 34)
        Me.btn_new_Brand.TabIndex = 5
        Me.btn_new_Brand.Text = "Create New"
        Me.btn_new_Brand.UseVisualStyleBackColor = True
        '
        'tb_search_Brand
        '
        Me.tb_search_Brand.Location = New System.Drawing.Point(90, 23)
        Me.tb_search_Brand.Name = "tb_search_Brand"
        Me.tb_search_Brand.Size = New System.Drawing.Size(519, 22)
        Me.tb_search_Brand.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "#"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.Width = 45
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column7.HeaderText = "Brand"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column7.Width = 75
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
        'col_add_Description
        '
        Me.col_add_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_add_Description.HeaderText = "Additional Description"
        Me.col_add_Description.MinimumWidth = 6
        Me.col_add_Description.Name = "col_add_Description"
        Me.col_add_Description.ReadOnly = True
        Me.col_add_Description.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 94
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column11.HeaderText = "Unit Price"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column11.Width = 98
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column9.HeaderText = "Price A"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column9.Width = 82
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column10.HeaderText = "Price B"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column10.Width = 82
        '
        'col_Edit
        '
        Me.col_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Edit.HeaderText = ""
        Me.col_Edit.MinimumWidth = 6
        Me.col_Edit.Name = "col_Edit"
        Me.col_Edit.ReadOnly = True
        Me.col_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Edit.Width = 23
        '
        'col_Delete
        '
        Me.col_Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Delete.HeaderText = ""
        Me.col_Delete.MinimumWidth = 6
        Me.col_Delete.Name = "col_Delete"
        Me.col_Delete.ReadOnly = True
        Me.col_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Delete.Width = 23
        '
        'frmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 470)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItem"
        Me.Text = "`"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tp_Items.ResumeLayout(False)
        CType(Me.dg_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tp_Category.ResumeLayout(False)
        CType(Me.dg_Category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tp_Brand.ResumeLayout(False)
        CType(Me.dg_Brand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tp_Items As TabPage
    Friend WithEvents tp_Category As TabPage
    Friend WithEvents tp_Brand As TabPage
    Friend WithEvents dg_Category As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_new_Category As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_search_Category As TextBox
    Friend WithEvents dg_Brand As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_new_Brand As Button
    Friend WithEvents tb_search_Brand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_row_count_Category As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_row_count_Brand As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents col_edit_Category As DataGridViewButtonColumn
    Friend WithEvents col_delete_Category As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents col_edit_Brand As DataGridViewButtonColumn
    Friend WithEvents col_delete_Brand As DataGridViewButtonColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_row_count_Items As Label
    Friend WithEvents dg_Items As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Add As Button
    Friend WithEvents cbo_Filter As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents col_add_Description As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents col_Edit As DataGridViewButtonColumn
    Friend WithEvents col_Delete As DataGridViewButtonColumn
End Class
