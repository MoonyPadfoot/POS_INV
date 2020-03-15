Public Class frmItem
    Dim item As New clsItem
    Dim category As New clsCategory
    Dim brand As New clsBrand
    Dim _id As Integer
    Dim _code, _desc, _add_Desc, _brand, _category As String
    Dim _unit_Price, _price_A, _price_B As Double

    Private Sub btn_new_Category_Click(sender As Object, e As EventArgs) Handles btn_new_Category.Click
        frmBrandCat.lbl_Header.Text = "Category"
        frmBrandCat.btn_Update.Hide()
        frmBrandCat.btn_Save.Show()
        frmBrandCat.ShowDialog()
    End Sub

    Private Sub btn_new_Brand_Click(sender As Object, e As EventArgs) Handles btn_new_Brand.Click
        frmBrandCat.lbl_Header.Text = "Brand"
        frmBrandCat.btn_Update.Hide()
        frmBrandCat.btn_Save.Show()
        frmBrandCat.ShowDialog()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        frmItemEntry.btn_Update.Enabled = False
        frmItemEntry.btn_Save.Enabled = True
        frmItemEntry.ShowDialog()
    End Sub

    Private Sub frmItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        MetroTabControl1.SelectedTab = tp_Items
        cbo_Filter.SelectedIndex = 1
        item.loadRecord()
        category.loadRecord()
        category.loadAutosuggest()
        brand.loadRecord()
        brand.loadAutosuggest()
    End Sub

    Private Sub dg_Items_SelectionChanged(sender As Object, e As EventArgs) Handles dg_Items.SelectionChanged
        Dim i As Integer = dg_Items.CurrentRow.Index
        _id = dg_Items.Item(0, i).Value
        _code = dg_Items.Item(2, i).Value
        _desc = dg_Items.Item(3, i).Value
        _add_Desc = dg_Items.Item(4, i).Value
        _brand = dg_Items.Item(5, i).Value
        _category = dg_Items.Item(6, i).Value
        _unit_Price = dg_Items.Item(7, i).Value
        _price_A = dg_Items.Item(8, i).Value
        _price_B = dg_Items.Item(9, i).Value
    End Sub

    Private Sub dg_Items_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Items.CellContentClick
        Dim colName As String = dg_Items.Columns(e.ColumnIndex).Name
        If colName = "col_Edit" Then
            With frmItemEntry
                .lbl_Id.Text = _id
                .tb_Code.Text = _code
                .tb_Desc.Text = _desc
                .tb_add_Desc.Text = _add_Desc
                .tb_Brand.Text = _brand
                .tb_Category.Text = _category
                .tb_unit_Price.Text = _unit_Price
                .tb_price_A.Text = _price_A
                .tb_price_B.Text = _price_B
                .tb_Code.ReadOnly = True
                .btn_Save.Enabled = False
                .btn_Update.Enabled = True
                .ShowDialog()
            End With

            'ElseIf colName = "col_Delete" Then
            '    Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            '    If result = vbYes Then
            '        user.Id = _id
            '        If user.checkBranchExists = False Then
            '            branch.delete()
            '            MsgBox("Record has been successfully deleted.", vbInformation)
            '            branch.loadRecord()
            '        Else
            '            MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
            '        End If
            '    End If

        End If
    End Sub
    Private Sub Dg_Category_SelectionChanged(sender As Object, e As EventArgs) Handles dg_Category.SelectionChanged
        Dim i As Integer = dg_Category.CurrentRow.Index
        _id = dg_Category.Item(0, i).Value
        _category = dg_Category.Item(2, i).Value
    End Sub

    Private Sub Dg_Category_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Category.CellContentClick
        Dim colName As String = dg_Category.Columns(e.ColumnIndex).Name
        If colName = "col_edit_Category" Then
            With frmBrandCat
                .lbl_brand_Cat.Text = _id
                .tb_brand_Cat.Text = _category
                .btn_Save.Hide()
                .btn_Update.Show()
                .tb_brand_Cat.Focus()
                .ShowDialog()
            End With
        ElseIf colName = "col_delete_Category" Then
            Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                category.SetCategoryId(_id)
                If category.checkCategoryExists = False Then
                    category.delete()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    category.loadRecord()
                Else
                    MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
                End If
            End If
        End If
    End Sub
    Private Sub Dg_Brand_SelectionChanged(sender As Object, e As EventArgs) Handles dg_Brand.SelectionChanged
        Dim i As Integer = dg_Brand.CurrentRow.Index
        _id = dg_Brand.Item(0, i).Value
        _brand = dg_Brand.Item(2, i).Value
    End Sub

    Private Sub Dg_Brand_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Brand.CellContentClick
        Dim colName As String = dg_Brand.Columns(e.ColumnIndex).Name
        If colName = "col_edit_Brand" Then
            With frmBrandCat
                .lbl_brand_Cat.Text = _id
                .tb_brand_Cat.Text = _brand
                .btn_Save.Hide()
                .btn_Update.Show()
                .tb_brand_Cat.Focus()
                .ShowDialog()
            End With
        ElseIf colName = "col_delete_Brand" Then
            Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                brand.SetBrandId(_id)
                If brand.checkBrandExists = False Then
                    brand.delete()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    brand.loadRecord()
                Else
                    MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
                End If
            End If
        End If
    End Sub
    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            Select Case cbo_Filter.Text
                Case "Code"
                    item.SetItemSearch(Trim(tb_Search.Text))
                    item.searchItem("SELECT item_id, item_code, item_desc, item_add_desc, item_unit_price, item_price_A, item_price_B, item_qty, brand.brand_name, category.category_name FROM item " &
                                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                    "INNER JOIN category ON category.category_id = item.category_id WHERE item_code LIKE @0")
                Case "Description"
                    item.SetItemSearch(Trim(tb_Search.Text))
                    item.searchItem("SELECT item_id, item_code, item_desc, item_add_desc, item_unit_price, item_price_A, item_price_B, item_qty, brand.brand_name, category.category_name FROM item " &
                                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                    "INNER JOIN category ON category.category_id = item.category_id WHERE item_desc LIKE @0 OR item_add_desc LIKE @0")
                Case "Brand"
                    item.SetItemSearch(Trim(tb_Search.Text))
                    item.searchItem("SELECT item_id, item_code, item_desc, item_add_desc, item_unit_price, item_price_A, item_price_B, item_qty, brand.brand_name, category.category_name FROM item " &
                                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                    "INNER JOIN category ON category.category_id = item.category_id WHERE item_brand LIKE @0")
                Case "Category"
                    item.SetItemSearch(Trim(tb_Search.Text))
                    item.searchItem("SELECT item_id, item_code, item_desc, item_add_desc, item_unit_price, item_price_A, item_price_B, item_qty, brand.brand_name, category.category_name FROM item " &
                                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                    "INNER JOIN category ON category.category_id = item.category_id WHERE item_category LIKE @0")
            End Select
        Else
            item.loadRecord()
        End If
    End Sub
    Private Sub tb_Search_Category_TextChanged(sender As Object, e As EventArgs) Handles tb_search_Category.TextChanged
        If Trim(tb_search_Category.Text) <> "" Then
            category.SetCategorySearch(Trim(tb_search_Category.Text))
            category.searchCategory("SELECT * FROM category WHERE category_name LIKE @0 ")
        Else
            category.loadRecord()
        End If
    End Sub
    Private Sub tb_Search_Brand_TextChanged(sender As Object, e As EventArgs) Handles tb_search_Brand.TextChanged
        If Trim(tb_search_Brand.Text) <> "" Then
            brand.SetBrandSearch(Trim(tb_search_Brand.Text))
            brand.searchBrand("SELECT * FROM category WHERE category_name LIKE @0 ")
        Else
            brand.loadRecord()
        End If
    End Sub
End Class