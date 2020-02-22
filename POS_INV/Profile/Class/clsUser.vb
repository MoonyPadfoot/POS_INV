Imports MySql.Data.MySqlClient
Public Class clsUser
    Public Property GName
    Public Property Mi
    Public Property Surname
    Public Property Suffix
    Public Property Username
    Public Property Password
    Public Property UserType
    Public Property BranchId
    Public Property Branch
    Public Property Active
    Public Property Id
    Public Function save()
        Dim _id As Integer
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO user (branch_id, username, password, user_type, is_active) " &
                            "VALUES (@branch_id, @username, @password, @user_type, @is_active); " &
                            "SELECT LAST_INSERT_ID(); "
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@branch_id", BranchId)
            cm.Parameters.AddWithValue("@username", Username)
            cm.Parameters.AddWithValue("@password", Password)
            cm.Parameters.AddWithValue("@user_type", UserType)
            cm.Parameters.AddWithValue("@is_active", Active)
            _id = CInt(cm.ExecuteScalar)
            cm.Dispose()

            query = "INSERT INTO user_details (user_id, user_surname, user_gname, user_mi, user_suffix) " &
                "VALUES (" & _id & ", @user_surname, @user_gname, @user_mi, @user_suffix)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_surname", Surname)
            cm.Parameters.AddWithValue("@user_gname", GName)
            cm.Parameters.AddWithValue("@user_mi", Mi)
            cm.Parameters.AddWithValue("@user_suffix", Suffix)
            cm.ExecuteScalar()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function edit()
        Try
            ConnectDatabase()
            Dim query = "UPDATE user SET password=@password, user_type=@user_type, branch_id=@branch_id, is_active=@is_active WHERE user_id=@user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            cm.Parameters.AddWithValue("@password", Password)
            cm.Parameters.AddWithValue("@user_type", UserType)
            cm.Parameters.AddWithValue("@branch_id", BranchId)
            cm.Parameters.AddWithValue("@is_active", Active)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadRecord()
        Dim i As Integer
        frmUser.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT user.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, username, user_type, is_active FROM user " &
                    "INNER JOIN user_details ON user.user_id = user_details.user_id " &
                    "INNER JOIN branch ON branch.branch_id = user.branch_id"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUser.DataGridView1.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("branch_address").ToString, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("username").ToString, dr.Item("user_type").ToString, dr.Item("is_active"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmUser.lbl_row_Count.Text = "(" & frmUser.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Function checkBranchExists() 'checks if branch is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT user_id FROM user WHERE user_id = @user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            Dim count = Convert.ToInt16(cm.ExecuteScalar())
            If count > 0 Then
                Return True
                DisconnectDatabase()
            End If
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
            Dim query = "SELECT username FROM user WHERE username = @username"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@username", Username)
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
    Public Sub loadBranch()
        ConnectDatabase()
        Dim query = "SELECT branch_address FROM branch ORDER BY branch_address"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "branch_address")
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            With frmUserEntry.cbo_Branch
                .Items.Add(ds.Tables(0).Rows(i)("branch_address").ToString)
            End With
        Next
        DisconnectDatabase()
    End Sub
    Public Sub loadBranchId()
        ConnectDatabase()
        Dim query = "SELECT branch_id FROM branch WHERE branch_address=@branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", Branch)
        Dim dr As MySqlDataReader = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                frmUserEntry.lbl_branch_Id.Text = dr(0).ToString
            End While
        End If
        DisconnectDatabase()
    End Sub
    Public Function loadPassword(_username As String)
        ConnectDatabase()
        Dim query = "SELECT password FROM user WHERE username=@username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _username)
        Return cm.ExecuteScalar
    End Function
End Class
