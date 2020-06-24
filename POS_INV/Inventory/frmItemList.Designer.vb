<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemList
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_Filter = New System.Windows.Forms.ComboBox()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_row_Count = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dg_Items = New System.Windows.Forms.DataGridView()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.col_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Select = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cbo_Filter.Items.AddRange(New Object() {"Code", "Description", "Brand", "Category"})
        Me.cbo_Filter.Location = New System.Drawing.Point(887, 32)
        Me.cbo_Filter.Name = "cbo_Filter"
        Me.cbo_Filter.Size = New System.Drawing.Size(183, 24)
        Me.cbo_Filter.TabIndex = 6
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search:"
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
        Me.Panel3.Controls.Add(Me.lbl_row_Count)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 493)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1263, 60)
        Me.Panel3.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dg_Items)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1263, 553)
        Me.Panel2.TabIndex = 24
        '
        'dg_Items
        '
        Me.dg_Items.AllowUserToAddRows = False
        Me.dg_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Id, Me.Column6, Me.DataGridViewTextBoxColumn2, Me.Column7, Me.Column8, Me.column1, Me.DataGridViewTextBoxColumn3, Me.Column2, Me.col_Select})
        Me.dg_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Items.Location = New System.Drawing.Point(0, 82)
        Me.dg_Items.Name = "dg_Items"
        Me.dg_Items.RowHeadersVisible = False
        Me.dg_Items.RowHeadersWidth = 51
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dg_Items.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_Items.RowTemplate.Height = 24
        Me.dg_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Items.Size = New System.Drawing.Size(1263, 411)
        Me.dg_Items.TabIndex = 23
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Close.Location = New System.Drawing.Point(0, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(55, 44)
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
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 44)
        Me.Panel1.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_Close)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1208, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(55, 44)
        Me.Panel5.TabIndex = 54
        '
        'col_Id
        '
        Me.col_Id.HeaderText = "ID"
        Me.col_Id.MinimumWidth = 6
        Me.col_Id.Name = "col_Id"
        Me.col_Id.Visible = False
        Me.col_Id.Width = 125
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
        'column1
        '
        Me.column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.column1.HeaderText = "Additional Description"
        Me.column1.MinimumWidth = 6
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "Unit"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 62
        '
        'col_Select
        '
        Me.col_Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Select.HeaderText = ""
        Me.col_Select.MinimumWidth = 6
        Me.col_Select.Name = "col_Select"
        Me.col_Select.ReadOnly = True
        Me.col_Select.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Select.Width = 23
        '
        'frmItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 597)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItemList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmItemList"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dg_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_Filter As ComboBox
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_row_Count As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dg_Items As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents col_Id As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents col_Select As DataGridViewButtonColumn
End Class
