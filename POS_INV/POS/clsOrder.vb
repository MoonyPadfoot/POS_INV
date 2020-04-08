Imports MySql.Data.MySqlClient
Public Class clsOrder
    Private _ItemSearch As Object
    Private _BranchId As Object

    Public Sub SetBranchId(AutoPropertyValue As Object)
        _BranchId = AutoPropertyValue
    End Sub

    Public Sub SetItemSearch(AutoPropertyValue As Object)
        _ItemSearch = AutoPropertyValue
    End Sub

    Public Sub searchItem(query As String) 'dg_Search item populate
        frmPos.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        dr = cm.ExecuteReader()
        While dr.Read
            frmPos.dg_Search.Rows.Add(dr.Item("item_id").ToString, dr.Item("item_code").ToString, dr.Item("brand_name").ToString & " | " & dr.Item("item_desc").ToString & " | " & dr.Item("item_add_desc").ToString & " | " &
                                      dr.Item("category_name").ToString, dr.Item("item_price_A").ToString, dr.Item("item_price_B").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchService(query As String) 'dg_Search service populate
        frmPos.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            frmPos.dg_Search.Rows.Add(dr.Item("service_id").ToString, dr.Item("service_code").ToString, dr.Item("service_desc").ToString, dr.Item("service_fee_A").ToString, dr.Item("service_fee_B").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
End Class
