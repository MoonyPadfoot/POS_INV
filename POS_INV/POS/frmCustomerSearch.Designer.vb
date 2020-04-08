<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerSearch
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_Balance = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_row_Count = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Gname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Suffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Add = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1233, 44)
        Me.Panel1.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_Close)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1183, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(50, 44)
        Me.Panel2.TabIndex = 2
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Close.Location = New System.Drawing.Point(0, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(50, 44)
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
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer List"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.tb_Search)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 44)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1233, 66)
        Me.Panel4.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search:"
        '
        'tb_Search
        '
        Me.tb_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Search.Location = New System.Drawing.Point(133, 16)
        Me.tb_Search.MaxLength = 50
        Me.tb_Search.Multiline = True
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.ShortcutsEnabled = False
        Me.tb_Search.Size = New System.Drawing.Size(884, 35)
        Me.tb_Search.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.lbl_row_Count)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 513)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1233, 75)
        Me.Panel3.TabIndex = 26
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_Balance)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(570, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(663, 75)
        Me.Panel5.TabIndex = 29
        '
        'lbl_Balance
        '
        Me.lbl_Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Balance.BackColor = System.Drawing.Color.Black
        Me.lbl_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Balance.ForeColor = System.Drawing.Color.Green
        Me.lbl_Balance.Location = New System.Drawing.Point(322, 13)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(329, 50)
        Me.lbl_Balance.TabIndex = 27
        Me.lbl_Balance.Text = "0.00"
        Me.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 46)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "User Balance:"
        '
        'lbl_row_Count
        '
        Me.lbl_row_Count.AutoSize = True
        Me.lbl_row_Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_row_Count.Location = New System.Drawing.Point(27, 21)
        Me.lbl_row_Count.Name = "lbl_row_Count"
        Me.lbl_row_Count.Size = New System.Drawing.Size(91, 20)
        Me.lbl_row_Count.TabIndex = 9
        Me.lbl_row_Count.Text = "Row Count"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.col_Code, Me.col_Gname, Me.col_Mi, Me.col_Fname, Me.col_Suffix, Me.Column1, Me.col_Balance, Me.col_Add})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1233, 403)
        Me.DataGridView1.TabIndex = 27
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 27
        '
        'col_Code
        '
        Me.col_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Code.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_Code.HeaderText = "Code"
        Me.col_Code.MinimumWidth = 6
        Me.col_Code.Name = "col_Code"
        Me.col_Code.ReadOnly = True
        Me.col_Code.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Code.Width = 70
        '
        'col_Gname
        '
        Me.col_Gname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Gname.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_Gname.HeaderText = "Given Name"
        Me.col_Gname.MinimumWidth = 6
        Me.col_Gname.Name = "col_Gname"
        Me.col_Gname.ReadOnly = True
        Me.col_Gname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Mi
        '
        Me.col_Mi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Mi.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Fname.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_Fname.HeaderText = "Family Name"
        Me.col_Fname.MinimumWidth = 6
        Me.col_Fname.Name = "col_Fname"
        Me.col_Fname.ReadOnly = True
        Me.col_Fname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_Suffix
        '
        Me.col_Suffix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_Suffix.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_Suffix.HeaderText = "Suffix"
        Me.col_Suffix.MinimumWidth = 6
        Me.col_Suffix.Name = "col_Suffix"
        Me.col_Suffix.ReadOnly = True
        Me.col_Suffix.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_Suffix.Width = 71
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column1.HeaderText = "Credit Limit"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 107
        '
        'col_Balance
        '
        Me.col_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Balance.HeaderText = "Balance"
        Me.col_Balance.MinimumWidth = 6
        Me.col_Balance.Name = "col_Balance"
        Me.col_Balance.Visible = False
        Me.col_Balance.Width = 88
        '
        'col_Add
        '
        Me.col_Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_Add.HeaderText = ""
        Me.col_Add.MinimumWidth = 6
        Me.col_Add.Name = "col_Add"
        Me.col_Add.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_Add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_Add.Width = 23
        '
        'frmCustomerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 588)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomerSearch"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_row_Count As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_Balance As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents col_Code As DataGridViewTextBoxColumn
    Friend WithEvents col_Gname As DataGridViewTextBoxColumn
    Friend WithEvents col_Mi As DataGridViewTextBoxColumn
    Friend WithEvents col_Fname As DataGridViewTextBoxColumn
    Friend WithEvents col_Suffix As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents col_Balance As DataGridViewTextBoxColumn
    Friend WithEvents col_Add As DataGridViewButtonColumn
End Class
