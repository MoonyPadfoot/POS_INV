<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tp_user_Profile = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Row = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Branch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Surname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Suffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_row_Count = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbo_Filter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.tp_Cashier = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_edit_Cashier = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_delete_Cashier = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_row_count_Cashier = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_add_Cashier = New System.Windows.Forms.Button()
        Me.cbo_filter_Cashier = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_search_Cashier = New System.Windows.Forms.TextBox()
        Me.tp_Manager = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_row_count_Manager = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_add_Manager = New System.Windows.Forms.Button()
        Me.cbo_filter_manager = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_search_Manager = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_edit_Manager = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MetroTabControl1.SuspendLayout()
        Me.tp_user_Profile.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tp_Cashier.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tp_Manager.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tp_user_Profile)
        Me.MetroTabControl1.Controls.Add(Me.tp_Cashier)
        Me.MetroTabControl1.Controls.Add(Me.tp_Manager)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(1271, 579)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'tp_user_Profile
        '
        Me.tp_user_Profile.Controls.Add(Me.DataGridView1)
        Me.tp_user_Profile.Controls.Add(Me.Panel2)
        Me.tp_user_Profile.Controls.Add(Me.Panel3)
        Me.tp_user_Profile.Location = New System.Drawing.Point(4, 38)
        Me.tp_user_Profile.Name = "tp_user_Profile"
        Me.tp_user_Profile.Size = New System.Drawing.Size(1263, 537)
        Me.tp_user_Profile.TabIndex = 0
        Me.tp_user_Profile.Text = "System Accounts"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.col_Row, Me.col_Branch, Me.col_Name, Me.col_mi, Me.col_Surname, Me.col_Suffix, Me.col_Username, Me.col_Type, Me.col_Active, Me.col_Edit, Me.col_Delete})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1263, 395)
        Me.DataGridView1.TabIndex = 20
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'col_Row
        '
        Me.col_Row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Row.HeaderText = "#"
        Me.col_Row.MinimumWidth = 6
        Me.col_Row.Name = "col_Row"
        Me.col_Row.ReadOnly = True
        Me.col_Row.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Row.Width = 45
        '
        'col_Branch
        '
        Me.col_Branch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_Branch.HeaderText = "Branch"
        Me.col_Branch.MinimumWidth = 6
        Me.col_Branch.Name = "col_Branch"
        Me.col_Branch.ReadOnly = True
        Me.col_Branch.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Name
        '
        Me.col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_Name.HeaderText = "Given Name"
        Me.col_Name.MinimumWidth = 6
        Me.col_Name.Name = "col_Name"
        Me.col_Name.ReadOnly = True
        Me.col_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_mi
        '
        Me.col_mi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.col_mi.HeaderText = "M.I."
        Me.col_mi.MinimumWidth = 6
        Me.col_mi.Name = "col_mi"
        Me.col_mi.ReadOnly = True
        Me.col_mi.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_mi.Width = 59
        '
        'col_Surname
        '
        Me.col_Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_Surname.HeaderText = "Family Name"
        Me.col_Surname.MinimumWidth = 6
        Me.col_Surname.Name = "col_Surname"
        Me.col_Surname.ReadOnly = True
        Me.col_Surname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        'col_Username
        '
        Me.col_Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Username.HeaderText = "Username"
        Me.col_Username.MinimumWidth = 6
        Me.col_Username.Name = "col_Username"
        Me.col_Username.ReadOnly = True
        Me.col_Username.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Username.Width = 102
        '
        'col_Type
        '
        Me.col_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Type.HeaderText = "User Type"
        Me.col_Type.MinimumWidth = 6
        Me.col_Type.Name = "col_Type"
        Me.col_Type.ReadOnly = True
        Me.col_Type.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Type.Width = 103
        '
        'col_Active
        '
        Me.col_Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Active.HeaderText = "Active"
        Me.col_Active.MinimumWidth = 6
        Me.col_Active.Name = "col_Active"
        Me.col_Active.ReadOnly = True
        Me.col_Active.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Active.Width = 52
        '
        'col_Edit
        '
        Me.col_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Edit.HeaderText = ""
        Me.col_Edit.MinimumWidth = 6
        Me.col_Edit.Name = "col_Edit"
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
        Me.col_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Delete.Width = 23
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_row_Count)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 477)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1263, 60)
        Me.Panel2.TabIndex = 19
        '
        'lbl_row_Count
        '
        Me.lbl_row_Count.AutoSize = True
        Me.lbl_row_Count.Location = New System.Drawing.Point(27, 21)
        Me.lbl_row_Count.Name = "lbl_row_Count"
        Me.lbl_row_Count.Size = New System.Drawing.Size(76, 17)
        Me.lbl_row_Count.TabIndex = 9
        Me.lbl_row_Count.Text = "Row Count"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.cbo_Filter)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.tb_Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1263, 82)
        Me.Panel3.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(802, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Filter By:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1103, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 34)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add User"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cbo_Filter
        '
        Me.cbo_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Filter.FormattingEnabled = True
        Me.cbo_Filter.Items.AddRange(New Object() {"Branch", "Name", "Username"})
        Me.cbo_Filter.Location = New System.Drawing.Point(887, 32)
        Me.cbo_Filter.Name = "cbo_Filter"
        Me.cbo_Filter.Size = New System.Drawing.Size(183, 24)
        Me.cbo_Filter.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search:"
        '
        'tb_Search
        '
        Me.tb_Search.Location = New System.Drawing.Point(110, 32)
        Me.tb_Search.MaxLength = 50
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.ShortcutsEnabled = False
        Me.tb_Search.Size = New System.Drawing.Size(663, 22)
        Me.tb_Search.TabIndex = 3
        '
        'tp_Cashier
        '
        Me.tp_Cashier.Controls.Add(Me.DataGridView2)
        Me.tp_Cashier.Controls.Add(Me.Panel1)
        Me.tp_Cashier.Controls.Add(Me.Panel4)
        Me.tp_Cashier.Location = New System.Drawing.Point(4, 38)
        Me.tp_Cashier.Name = "tp_Cashier"
        Me.tp_Cashier.Size = New System.Drawing.Size(1263, 537)
        Me.tp_Cashier.TabIndex = 1
        Me.tp_Cashier.Text = "Cashier"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1, Me.col_edit_Cashier, Me.col_delete_Cashier})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 82)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1263, 395)
        Me.DataGridView2.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "#"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 45
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Given Name"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "M.I."
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn6.Width = 59
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.HeaderText = "Family Name"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Suffix"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn8.Width = 71
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn9.Width = 102
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCheckBoxColumn1.Width = 52
        '
        'col_edit_Cashier
        '
        Me.col_edit_Cashier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_edit_Cashier.HeaderText = ""
        Me.col_edit_Cashier.MinimumWidth = 6
        Me.col_edit_Cashier.Name = "col_edit_Cashier"
        Me.col_edit_Cashier.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_edit_Cashier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_edit_Cashier.Width = 23
        '
        'col_delete_Cashier
        '
        Me.col_delete_Cashier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_delete_Cashier.HeaderText = ""
        Me.col_delete_Cashier.MinimumWidth = 6
        Me.col_delete_Cashier.Name = "col_delete_Cashier"
        Me.col_delete_Cashier.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_delete_Cashier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_delete_Cashier.Width = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_row_count_Cashier)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 477)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 60)
        Me.Panel1.TabIndex = 22
        '
        'lbl_row_count_Cashier
        '
        Me.lbl_row_count_Cashier.AutoSize = True
        Me.lbl_row_count_Cashier.Location = New System.Drawing.Point(27, 21)
        Me.lbl_row_count_Cashier.Name = "lbl_row_count_Cashier"
        Me.lbl_row_count_Cashier.Size = New System.Drawing.Size(76, 17)
        Me.lbl_row_count_Cashier.TabIndex = 9
        Me.lbl_row_count_Cashier.Text = "Row Count"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btn_add_Cashier)
        Me.Panel4.Controls.Add(Me.cbo_filter_Cashier)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.tb_search_Cashier)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1263, 82)
        Me.Panel4.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(802, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Filter By:"
        '
        'btn_add_Cashier
        '
        Me.btn_add_Cashier.Location = New System.Drawing.Point(1103, 26)
        Me.btn_add_Cashier.Name = "btn_add_Cashier"
        Me.btn_add_Cashier.Size = New System.Drawing.Size(128, 34)
        Me.btn_add_Cashier.TabIndex = 5
        Me.btn_add_Cashier.Text = "Add Cashier"
        Me.btn_add_Cashier.UseVisualStyleBackColor = True
        '
        'cbo_filter_Cashier
        '
        Me.cbo_filter_Cashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_filter_Cashier.FormattingEnabled = True
        Me.cbo_filter_Cashier.Items.AddRange(New Object() {"Name", "Username"})
        Me.cbo_filter_Cashier.Location = New System.Drawing.Point(887, 32)
        Me.cbo_filter_Cashier.Name = "cbo_filter_Cashier"
        Me.cbo_filter_Cashier.Size = New System.Drawing.Size(183, 24)
        Me.cbo_filter_Cashier.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Search:"
        '
        'tb_search_Cashier
        '
        Me.tb_search_Cashier.Location = New System.Drawing.Point(110, 32)
        Me.tb_search_Cashier.MaxLength = 50
        Me.tb_search_Cashier.Name = "tb_search_Cashier"
        Me.tb_search_Cashier.ShortcutsEnabled = False
        Me.tb_search_Cashier.Size = New System.Drawing.Size(663, 22)
        Me.tb_search_Cashier.TabIndex = 3
        '
        'tp_Manager
        '
        Me.tp_Manager.Controls.Add(Me.DataGridView3)
        Me.tp_Manager.Controls.Add(Me.Panel5)
        Me.tp_Manager.Controls.Add(Me.Panel6)
        Me.tp_Manager.Location = New System.Drawing.Point(4, 38)
        Me.tp_Manager.Name = "tp_Manager"
        Me.tp_Manager.Size = New System.Drawing.Size(1263, 537)
        Me.tp_Manager.TabIndex = 2
        Me.tp_Manager.Text = "Manager"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewCheckBoxColumn2, Me.col_edit_Manager, Me.DataGridViewButtonColumn2})
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 82)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(1263, 395)
        Me.DataGridView3.TabIndex = 26
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_row_count_Manager)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 477)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1263, 60)
        Me.Panel5.TabIndex = 25
        '
        'lbl_row_count_Manager
        '
        Me.lbl_row_count_Manager.AutoSize = True
        Me.lbl_row_count_Manager.Location = New System.Drawing.Point(27, 21)
        Me.lbl_row_count_Manager.Name = "lbl_row_count_Manager"
        Me.lbl_row_count_Manager.Size = New System.Drawing.Size(76, 17)
        Me.lbl_row_count_Manager.TabIndex = 9
        Me.lbl_row_count_Manager.Text = "Row Count"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.btn_add_Manager)
        Me.Panel6.Controls.Add(Me.cbo_filter_manager)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.tb_search_Manager)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1263, 82)
        Me.Panel6.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(802, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Filter By:"
        '
        'btn_add_Manager
        '
        Me.btn_add_Manager.Location = New System.Drawing.Point(1103, 26)
        Me.btn_add_Manager.Name = "btn_add_Manager"
        Me.btn_add_Manager.Size = New System.Drawing.Size(128, 34)
        Me.btn_add_Manager.TabIndex = 5
        Me.btn_add_Manager.Text = "Add Manager"
        Me.btn_add_Manager.UseVisualStyleBackColor = True
        '
        'cbo_filter_manager
        '
        Me.cbo_filter_manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_filter_manager.FormattingEnabled = True
        Me.cbo_filter_manager.Items.AddRange(New Object() {"Name", "Username"})
        Me.cbo_filter_manager.Location = New System.Drawing.Point(887, 32)
        Me.cbo_filter_manager.Name = "cbo_filter_manager"
        Me.cbo_filter_manager.Size = New System.Drawing.Size(183, 24)
        Me.cbo_filter_manager.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Search:"
        '
        'tb_search_Manager
        '
        Me.tb_search_Manager.Location = New System.Drawing.Point(110, 32)
        Me.tb_search_Manager.MaxLength = 50
        Me.tb_search_Manager.Name = "tb_search_Manager"
        Me.tb_search_Manager.ShortcutsEnabled = False
        Me.tb_search_Manager.Size = New System.Drawing.Size(663, 22)
        Me.tb_search_Manager.TabIndex = 3
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.HeaderText = "#"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn10.Width = 45
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.HeaderText = "Given Name"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn12.HeaderText = "M.I."
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn12.Width = 59
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.HeaderText = "Family Name"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn14.HeaderText = "Suffix"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn14.Width = 71
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn15.Width = 102
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCheckBoxColumn2.Width = 52
        '
        'col_edit_Manager
        '
        Me.col_edit_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_edit_Manager.HeaderText = ""
        Me.col_edit_Manager.MinimumWidth = 6
        Me.col_edit_Manager.Name = "col_edit_Manager"
        Me.col_edit_Manager.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_edit_Manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_edit_Manager.Width = 23
        '
        'DataGridViewButtonColumn2
        '
        Me.DataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewButtonColumn2.HeaderText = ""
        Me.DataGridViewButtonColumn2.MinimumWidth = 6
        Me.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        Me.DataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewButtonColumn2.Width = 23
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 579)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUser"
        Me.Text = "frmUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tp_user_Profile.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tp_Cashier.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tp_Manager.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tp_user_Profile As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents col_Row As DataGridViewTextBoxColumn
    Friend WithEvents col_Branch As DataGridViewTextBoxColumn
    Friend WithEvents col_Name As DataGridViewTextBoxColumn
    Friend WithEvents col_mi As DataGridViewTextBoxColumn
    Friend WithEvents col_Surname As DataGridViewTextBoxColumn
    Friend WithEvents col_Suffix As DataGridViewTextBoxColumn
    Friend WithEvents col_Username As DataGridViewTextBoxColumn
    Friend WithEvents col_Type As DataGridViewTextBoxColumn
    Friend WithEvents col_Active As DataGridViewCheckBoxColumn
    Friend WithEvents col_Edit As DataGridViewButtonColumn
    Friend WithEvents col_Delete As DataGridViewButtonColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_row_Count As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents cbo_Filter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents tp_Cashier As TabPage
    Friend WithEvents tp_Manager As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_row_count_Cashier As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_add_Cashier As Button
    Friend WithEvents cbo_filter_Cashier As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_search_Cashier As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents col_edit_Cashier As DataGridViewButtonColumn
    Friend WithEvents col_delete_Cashier As DataGridViewButtonColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_row_count_Manager As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_add_Manager As Button
    Friend WithEvents cbo_filter_manager As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_search_Manager As TextBox
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents col_edit_Manager As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn2 As DataGridViewButtonColumn
End Class
