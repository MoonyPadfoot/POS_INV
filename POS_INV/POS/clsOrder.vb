Imports MySql.Data.MySqlClient
Public Class clsOrder
    Public Sub loadAutosuggestItems(branch_id)
        ConnectDatabase()
        Dim query = "SELECT brand_name, item_desc, item_add_desc FROM inventory " &
                    "INNER JOIN item ON item.item_id = inventory.item_id " &
                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                    "INNER JOIN branch ON branch.branch_id = inventory.branch_id " &
                    "WHERE inventory.branch_id = @branch_id ORDER BY brand_name; "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_id", branch_id)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "brand_name")
        da.Fill(ds, "item_desc")
        da.Fill(ds, "item_add_desc")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("brand_name").ToString & " | " & ds.Tables(0).Rows(i)("item_desc").ToString & " | " & ds.Tables(0).Rows(i)("item_add_desc").ToString)
        Next
        frmPos.cbo_Desc.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmPos.cbo_Desc.AutoCompleteCustomSource = col
        frmPos.cbo_Desc.AutoCompleteMode = AutoCompleteMode.Append
        DisconnectDatabase()
    End Sub
End Class
