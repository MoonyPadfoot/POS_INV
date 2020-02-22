<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBranch
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_row_Count = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Row = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col_Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.col_Row, Me.col_address, Me.col_Edit, Me.col_Delete})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1252, 542)
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Add)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tb_Search)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 81)
        Me.Panel1.TabIndex = 4
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(857, 26)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(128, 34)
        Me.btn_Add.TabIndex = 0
        Me.btn_Add.Text = "Add Branch"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Search:"
        '
        'tb_Search
        '
        Me.tb_Search.Location = New System.Drawing.Point(105, 33)
        Me.tb_Search.MaxLength = 100
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.ShortcutsEnabled = False
        Me.tb_Search.Size = New System.Drawing.Size(722, 22)
        Me.tb_Search.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_row_Count)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 563)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1252, 60)
        Me.Panel2.TabIndex = 6
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
        'col_address
        '
        Me.col_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_address.HeaderText = "Branch Address"
        Me.col_address.MinimumWidth = 6
        Me.col_address.Name = "col_address"
        Me.col_address.ReadOnly = True
        Me.col_address.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        'frmBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 623)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBranch"
        Me.Text = "frmBranch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Add As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_row_Count As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents col_Row As DataGridViewTextBoxColumn
    Friend WithEvents col_address As DataGridViewTextBoxColumn
    Friend WithEvents col_Edit As DataGridViewButtonColumn
    Friend WithEvents col_Delete As DataGridViewButtonColumn
End Class
