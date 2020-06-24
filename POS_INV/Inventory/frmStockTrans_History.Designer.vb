<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockTrans_History
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_To = New System.Windows.Forms.DateTimePicker()
        Me.btn_load_History = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_From = New System.Windows.Forms.DateTimePicker()
        Me.dg_stock_History = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.dg_stock_History, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1368, 44)
        Me.Panel1.TabIndex = 25
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(1315, 0)
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
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Stock Transfer History"
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.Label2)
        Me.Panel18.Controls.Add(Me.dtp_To)
        Me.Panel18.Controls.Add(Me.btn_load_History)
        Me.Panel18.Controls.Add(Me.Label19)
        Me.Panel18.Controls.Add(Me.dtp_From)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 44)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1368, 90)
        Me.Panel18.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(427, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Date To:"
        '
        'dtp_To
        '
        Me.dtp_To.CustomFormat = "MM/dd/yyyy"
        Me.dtp_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_To.Location = New System.Drawing.Point(530, 31)
        Me.dtp_To.Name = "dtp_To"
        Me.dtp_To.Size = New System.Drawing.Size(259, 30)
        Me.dtp_To.TabIndex = 16
        Me.dtp_To.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'btn_load_History
        '
        Me.btn_load_History.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load_History.Location = New System.Drawing.Point(816, 26)
        Me.btn_load_History.Name = "btn_load_History"
        Me.btn_load_History.Size = New System.Drawing.Size(132, 37)
        Me.btn_load_History.TabIndex = 15
        Me.btn_load_History.Text = "Load History"
        Me.btn_load_History.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 25)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Date From:"
        '
        'dtp_From
        '
        Me.dtp_From.CustomFormat = "MM/dd/yyyy"
        Me.dtp_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_From.Location = New System.Drawing.Point(150, 31)
        Me.dtp_From.Name = "dtp_From"
        Me.dtp_From.Size = New System.Drawing.Size(259, 30)
        Me.dtp_From.TabIndex = 11
        Me.dtp_From.Value = New Date(2020, 3, 21, 0, 0, 0, 0)
        '
        'dg_stock_History
        '
        Me.dg_stock_History.AllowUserToAddRows = False
        Me.dg_stock_History.ColumnHeadersHeight = 29
        Me.dg_stock_History.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.Column11, Me.Column5, Me.Column15, Me.Column1, Me.Column4, Me.Column13, Me.Column9, Me.Column12, Me.Column14, Me.Column2, Me.Column10})
        Me.dg_stock_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_stock_History.Location = New System.Drawing.Point(0, 134)
        Me.dg_stock_History.Name = "dg_stock_History"
        Me.dg_stock_History.RowHeadersVisible = False
        Me.dg_stock_History.RowHeadersWidth = 51
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dg_stock_History.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_stock_History.RowTemplate.Height = 24
        Me.dg_stock_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_stock_History.Size = New System.Drawing.Size(1368, 595)
        Me.dg_stock_History.TabIndex = 27
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column11.HeaderText = "Reference Code"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column11.Width = 140
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "Transaction Date"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 146
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column15.HeaderText = "Branch From"
        Me.Column15.MinimumWidth = 6
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column15.Width = 118
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.HeaderText = "Branch To"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 103
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Code"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 70
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column13.HeaderText = "Brand"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column13.Width = 75
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Description"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Additional Description"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column14.HeaderText = "Category"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column14.Width = 94
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Unit"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 62
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column10.HeaderText = "Qty"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column10.Width = 59
        '
        'frmStockTrans_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 729)
        Me.Controls.Add(Me.dg_stock_History)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStockTrans_History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmStockOut_History"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        CType(Me.dg_stock_History, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_To As DateTimePicker
    Friend WithEvents btn_load_History As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_From As DateTimePicker
    Friend WithEvents dg_stock_History As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
