<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItemEntry
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
        Me.tb_Code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Desc = New System.Windows.Forms.TextBox()
        Me.tb_Brand = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_Category = New System.Windows.Forms.TextBox()
        Me.tb_unit_Price = New System.Windows.Forms.TextBox()
        Me.tb_price_A = New System.Windows.Forms.TextBox()
        Me.tb_price_B = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tb_add_Desc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.lbl_brand_Id = New System.Windows.Forms.Label()
        Me.lbl_category_Id = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_unit_Id = New System.Windows.Forms.Label()
        Me.tb_Unit = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_Code
        '
        Me.tb_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Code.Location = New System.Drawing.Point(201, 71)
        Me.tb_Code.MaxLength = 50
        Me.tb_Code.Name = "tb_Code"
        Me.tb_Code.ShortcutsEnabled = False
        Me.tb_Code.Size = New System.Drawing.Size(403, 30)
        Me.tb_Code.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description:"
        '
        'tb_Desc
        '
        Me.tb_Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Desc.Location = New System.Drawing.Point(201, 153)
        Me.tb_Desc.MaxLength = 50
        Me.tb_Desc.Name = "tb_Desc"
        Me.tb_Desc.ShortcutsEnabled = False
        Me.tb_Desc.Size = New System.Drawing.Size(496, 30)
        Me.tb_Desc.TabIndex = 2
        '
        'tb_Brand
        '
        Me.tb_Brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Brand.Location = New System.Drawing.Point(201, 111)
        Me.tb_Brand.MaxLength = 50
        Me.tb_Brand.Name = "tb_Brand"
        Me.tb_Brand.ShortcutsEnabled = False
        Me.tb_Brand.Size = New System.Drawing.Size(496, 30)
        Me.tb_Brand.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Brand:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Category:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Unit Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Price A:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Price B:"
        '
        'tb_Category
        '
        Me.tb_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Category.Location = New System.Drawing.Point(201, 236)
        Me.tb_Category.MaxLength = 50
        Me.tb_Category.Name = "tb_Category"
        Me.tb_Category.ShortcutsEnabled = False
        Me.tb_Category.Size = New System.Drawing.Size(348, 30)
        Me.tb_Category.TabIndex = 4
        '
        'tb_unit_Price
        '
        Me.tb_unit_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_unit_Price.Location = New System.Drawing.Point(202, 323)
        Me.tb_unit_Price.MaxLength = 10
        Me.tb_unit_Price.Name = "tb_unit_Price"
        Me.tb_unit_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_unit_Price.ShortcutsEnabled = False
        Me.tb_unit_Price.Size = New System.Drawing.Size(170, 30)
        Me.tb_unit_Price.TabIndex = 5
        '
        'tb_price_A
        '
        Me.tb_price_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_price_A.Location = New System.Drawing.Point(202, 365)
        Me.tb_price_A.MaxLength = 10
        Me.tb_price_A.Name = "tb_price_A"
        Me.tb_price_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_price_A.ShortcutsEnabled = False
        Me.tb_price_A.Size = New System.Drawing.Size(170, 30)
        Me.tb_price_A.TabIndex = 6
        '
        'tb_price_B
        '
        Me.tb_price_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_price_B.Location = New System.Drawing.Point(202, 408)
        Me.tb_price_B.MaxLength = 10
        Me.tb_price_B.Name = "tb_price_B"
        Me.tb_price_B.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_price_B.ShortcutsEnabled = False
        Me.tb_price_B.Size = New System.Drawing.Size(170, 30)
        Me.tb_price_B.TabIndex = 7
        '
        'btn_Save
        '
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(391, 457)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(98, 59)
        Me.btn_Save.TabIndex = 15
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(495, 457)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(98, 59)
        Me.btn_Update.TabIndex = 16
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.Location = New System.Drawing.Point(599, 457)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(98, 59)
        Me.btn_Cancel.TabIndex = 17
        Me.btn_Cancel.Text = "Close"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 44)
        Me.Panel1.TabIndex = 18
        '
        'tb_add_Desc
        '
        Me.tb_add_Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_add_Desc.Location = New System.Drawing.Point(201, 195)
        Me.tb_add_Desc.MaxLength = 50
        Me.tb_add_Desc.Name = "tb_add_Desc"
        Me.tb_add_Desc.ShortcutsEnabled = False
        Me.tb_add_Desc.Size = New System.Drawing.Size(496, 30)
        Me.tb_add_Desc.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Adtl. Description:"
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(43, 470)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(19, 17)
        Me.lbl_Id.TabIndex = 43
        Me.lbl_Id.Text = "Id"
        Me.lbl_Id.Visible = False
        '
        'lbl_brand_Id
        '
        Me.lbl_brand_Id.AutoSize = True
        Me.lbl_brand_Id.Location = New System.Drawing.Point(99, 470)
        Me.lbl_brand_Id.Name = "lbl_brand_Id"
        Me.lbl_brand_Id.Size = New System.Drawing.Size(19, 17)
        Me.lbl_brand_Id.TabIndex = 44
        Me.lbl_brand_Id.Text = "Id"
        Me.lbl_brand_Id.Visible = False
        '
        'lbl_category_Id
        '
        Me.lbl_category_Id.AutoSize = True
        Me.lbl_category_Id.Location = New System.Drawing.Point(158, 470)
        Me.lbl_category_Id.Name = "lbl_category_Id"
        Me.lbl_category_Id.Size = New System.Drawing.Size(19, 17)
        Me.lbl_category_Id.TabIndex = 45
        Me.lbl_category_Id.Text = "Id"
        Me.lbl_category_Id.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 20)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Item Unit:"
        '
        'lbl_unit_Id
        '
        Me.lbl_unit_Id.AutoSize = True
        Me.lbl_unit_Id.Location = New System.Drawing.Point(208, 470)
        Me.lbl_unit_Id.Name = "lbl_unit_Id"
        Me.lbl_unit_Id.Size = New System.Drawing.Size(19, 17)
        Me.lbl_unit_Id.TabIndex = 48
        Me.lbl_unit_Id.Text = "Id"
        Me.lbl_unit_Id.Visible = False
        '
        'tb_Unit
        '
        Me.tb_Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Unit.Location = New System.Drawing.Point(201, 280)
        Me.tb_Unit.MaxLength = 50
        Me.tb_Unit.Name = "tb_Unit"
        Me.tb_Unit.ShortcutsEnabled = False
        Me.tb_Unit.Size = New System.Drawing.Size(312, 30)
        Me.tb_Unit.TabIndex = 49
        '
        'frmItemEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 538)
        Me.Controls.Add(Me.tb_Unit)
        Me.Controls.Add(Me.lbl_unit_Id)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_category_Id)
        Me.Controls.Add(Me.lbl_brand_Id)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.tb_add_Desc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.tb_price_B)
        Me.Controls.Add(Me.tb_price_A)
        Me.Controls.Add(Me.tb_unit_Price)
        Me.Controls.Add(Me.tb_Category)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Brand)
        Me.Controls.Add(Me.tb_Desc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_Code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItemEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmItemEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_Desc As TextBox
    Friend WithEvents tb_Brand As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_Category As TextBox
    Friend WithEvents tb_unit_Price As TextBox
    Friend WithEvents tb_price_A As TextBox
    Friend WithEvents tb_price_B As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tb_add_Desc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_Id As Label
    Friend WithEvents lbl_brand_Id As Label
    Friend WithEvents lbl_category_Id As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_unit_Id As Label
    Friend WithEvents tb_Unit As TextBox
End Class
