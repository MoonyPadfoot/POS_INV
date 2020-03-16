Imports MySql.Data.MySqlClient
Public Class clsCustomer
    Private _GName As Object
    Private _Mi As Object
    Private _Surname As Object
    Private _Suffix As Object
    Private _Id As Object
    Private _Code As Object
    Private _CreditLimit As Object
    Private _CustomerSearch As Object
    Public Sub SetGName(AutoPropertyValue As Object)
        _GName = AutoPropertyValue
    End Sub

    Public Sub SetMi(AutoPropertyValue As Object)
        _Mi = AutoPropertyValue
    End Sub

    Public Sub SetSurname(AutoPropertyValue As Object)
        _Surname = AutoPropertyValue
    End Sub

    Public Sub SetSuffix(AutoPropertyValue As Object)
        _Suffix = AutoPropertyValue
    End Sub

    Public Sub SetId(AutoPropertyValue As Object)
        _Id = AutoPropertyValue
    End Sub

    Public Sub SetCode(AutoPropertyValue As Object)
        _Code = AutoPropertyValue
    End Sub
    Public Sub SetCreditLimit(AutoPropertyValue As Object)
        _CreditLimit = AutoPropertyValue
    End Sub

    Public Sub SetUserSearch(AutoPropertyValue As Object)
        _CustomerSearch = AutoPropertyValue
    End Sub

    Public Function save()
        Dim _id As Integer
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO customer (customer_code, credit_limit) " &
                            "VALUES (@customer_code, @credit_limit); " &
                            "SELECT LAST_INSERT_ID(); "
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_code", _Code)
            cm.Parameters.AddWithValue("@credit_limit", _CreditLimit)
            _id = CInt(cm.ExecuteScalar)
            cm.Dispose()

            query = "INSERT INTO customer_details (customer_id, customer_surname, customer_gname, customer_mi, customer_suffix) " &
                "VALUES (" & _id & ", @customer_surname, @customer_gname, @customer_mi, @customer_suffix)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_surname", _Surname)
            cm.Parameters.AddWithValue("@user_gname", _GName)
            cm.Parameters.AddWithValue("@user_mi", _Mi)
            cm.Parameters.AddWithValue("@user_suffix", _Suffix)
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
            Dim query = "UPDATE customer SET credit_limit WHERE customer_id=@customer_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_id", _Id)
            cm.Parameters.AddWithValue("@credit_limit", _CreditLimit)
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
    Public Sub loadRecord() 'HERE'
        Dim i As Integer
        frmCustomers.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT user.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS _username, user_type, is_active FROM user " &
                    "INNER JOIN user_details ON user.user_id = user_details.user_id " &
                    "INNER JOIN branch ON branch.branch_id = user.branch_id"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUser.DataGridView1.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("branch_address").ToString, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("_username").ToString, dr.Item("user_type").ToString, dr.Item("is_active"), "EDIT", "DELETE")
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
            cm.Parameters.AddWithValue("@user_id", GetId())
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
        Dim query = "SELECT CAST(password AS CHAR) FROM user WHERE username=@username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _username)
        Return cm.ExecuteScalar
    End Function
    Public Sub searchUser(query As String)
        Dim i As Integer
        frmUser.DataGridView1.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", GetUserSearch() & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUser.DataGridView1.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("branch_address").ToString, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("username").ToString, dr.Item("user_type").ToString, dr.Item("is_active"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmUser.lbl_row_Count.Text = "(" & frmUser.DataGridView1.RowCount & ") Record(s) found."
    End Sub
End Class
