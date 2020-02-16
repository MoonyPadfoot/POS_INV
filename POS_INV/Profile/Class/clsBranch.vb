Imports MySql.Data.MySqlClient
Public Class clsBranch
    Public Property BranchName
    Public Property BranchId
    Public Property BranchSearch
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO branch (branch_address) VALUES (@branch_address)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@branch_address", BranchName)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        Return False
    End Function
    Public Function edit()
        Try
            ConnectDatabase()
            Dim query = "UPDATE branch SET branch_address=@branch_address WHERE branch_id=@branch_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@branch_id", BranchId)
            cm.Parameters.AddWithValue("@branch_address", BranchName)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
        End Try
    End Function
    Public Function delete()
        Try
            ConnectDatabase()
            Dim query = "DELETE FROM branch WHERE branch_id = @branch_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@branch_id", BranchId)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            loadAutosuggest()
        Catch ex As Exception

        End Try
    End Function
    Public Sub loadRecord()
        Dim i As Integer
        frmBranch.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM branch"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            frmBranch.DataGridView1.Rows.Add(dr.Item("branch_id").ToString, i, dr.Item("branch_address").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmBranch.lbl_row_Count.Text = "(" & frmBranch.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Sub loadAutosuggest()
        ConnectDatabase()
        Dim query = "SELECT * FROM branch ORDER BY branch_address"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "branch_address")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("branch_address").ToString)
        Next
        frmBranch.tb_Search.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmBranch.tb_Search.AutoCompleteCustomSource = col
        frmBranch.tb_Search.AutoCompleteMode = AutoCompleteMode.Suggest
        DisconnectDatabase()
    End Sub
    Public Sub searchItem(query As String)
        Dim i As Integer
        frmBranch.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", BranchSearch & "%")
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            frmBranch.DataGridView1.Rows.Add(dr.Item("branch_id").ToString, i, dr.Item("branch_address").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmBranch.lbl_row_Count.Text = "(" & frmBranch.DataGridView1.RowCount & ") Record(s) found."
    End Sub
End Class
