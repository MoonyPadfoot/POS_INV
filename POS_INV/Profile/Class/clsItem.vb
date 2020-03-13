Imports MySql.Data.MySqlClient
Public Class clsItem
    Private _ItemCode As Object
    Private _ItemDesc As Object
    Private _ItemAddDesc As Object
    Private _ItemBrand As Object
    Private _ItemCategory As Object
    Private _ItemUnitPrice As Object
    Private _ItemPriceA As Object
    Private _ItemPriceB As Object
    Public Sub SetCode(AutoPropertyValue As Object)
        _ItemCode = AutoPropertyValue
    End Sub

    Public Sub SetDesc(AutoPropertyValue As Object)
        _ItemDesc = AutoPropertyValue
    End Sub
    Public Sub SetAddDesc(AutoPropertyValue As Object)
        _ItemAddDesc = AutoPropertyValue
    End Sub
    Public Sub SetBrand(AutoPropertyValue As Object)
        _ItemBrand = AutoPropertyValue
    End Sub
    Public Sub SetCategory(AutoPropertyValue As Object)
        _ItemCategory = AutoPropertyValue
    End Sub
    Public Sub SetUnitPrice(AutoPropertyValue As Object)
        _ItemUnitPrice = AutoPropertyValue
    End Sub
    Public Sub SetPriceA(AutoPropertyValue As Object)
        _ItemPriceA = AutoPropertyValue
    End Sub
    Public Sub SetPriceB(AutoPropertyValue As Object)
        _ItemPriceB = AutoPropertyValue
    End Sub
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO item (item_code, item_desc, item_add_desc, item_brand, item_category, item_unit_price, item_price_A, item_price_B) " &
                        "VALUES (@item_code, @item_desc, @item_add_Desc, @item_brand, @item_category, @item_unit_Price, @item_price_A, @item_price_B)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@item_code", _ItemCode)
            cm.Parameters.AddWithValue("@item_desc", _ItemDesc)
            cm.Parameters.AddWithValue("@item_add_Desc", _ItemAddDesc)
            cm.Parameters.AddWithValue("@item_brand", _ItemBrand)
            cm.Parameters.AddWithValue("@item_category", _ItemCategory)
            cm.Parameters.AddWithValue("@item_unit_Price", _ItemUnitPrice)
            cm.Parameters.AddWithValue("@item_price_A", _ItemPriceA)
            cm.Parameters.AddWithValue("@item_price_B", _ItemPriceB)
            cm.Dispose()
            cm.ExecuteScalar()
            'loadAutosuggest()
            Return True
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function checkUserDuplicate()
        Try
            ConnectDatabase()
            Dim query = "SELECT item_code FROM item WHERE item_code = @item_code"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@item_code", _ItemCode)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                dr.Close()
                DisconnectDatabase()
                Return True
            End If
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadRecord()
        Dim i As Integer
        frmItem.dg_Items.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT item_id, item_code, item_desc, item_add_desc, item_brand, item_category, item_unit_price, item_price_A, item_price_B, item_qty FROM item"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmItem.dg_Items.Rows.Add(dr.Item("item_id").ToString, i, dr.Item("item_code").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString, dr.Item("item_brand").ToString, dr.Item("item_category").ToString, dr.Item("item_unit_price").ToString, dr.Item("item_price_A").ToString, dr.Item("item_price_B"), dr.Item("item_qty"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItem.lbl_row_count_Items.Text = "(" & frmItem.dg_Items.RowCount & ") Record(s) found."
    End Sub
End Class
