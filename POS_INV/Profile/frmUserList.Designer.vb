<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserList
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
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_row_Count = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_Filter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
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
        Me.col_Select = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 44)
        Me.Panel1.TabIndex = 21
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(1211, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(52, 44)
        Me.btn_Close.TabIndex = 53
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User List"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1263, 613)
        Me.Panel2.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.col_Row, Me.col_Branch, Me.col_Name, Me.col_mi, Me.col_Surname, Me.col_Suffix, Me.col_Username, Me.col_Type, Me.col_Active, Me.col_Select})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1263, 471)
        Me.DataGridView1.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbl_row_Count)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 553)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1263, 60)
        Me.Panel3.TabIndex = 22
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cbo_Filter)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.tb_Search)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1263, 82)
        Me.Panel4.TabIndex = 21
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
        'col_Select
        '
        Me.col_Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Select.HeaderText = ""
        Me.col_Select.MinimumWidth = 6
        Me.col_Select.Name = "col_Select"
        Me.col_Select.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Select.Width = 23
        '
        'frmUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 657)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUserList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmUserList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_row_Count As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_Filter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents btn_Close As Button
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
    Friend WithEvents col_Select As DataGridViewButtonColumn
End Class
