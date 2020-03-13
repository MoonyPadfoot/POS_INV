Imports MySql.Data.MySqlClient
Public Class clsLogin
    Private _Username As String
    Private _Password As String

    Public Sub SetUsername(AutoPropertyValue As String)
        _Username = AutoPropertyValue
    End Sub
    Public Sub SetPassword(AutoPropertyValue As String)
        _Password = AutoPropertyValue
    End Sub
    Public Function authLogin()
        ConnectDatabase()
        Dim query = "SELECT username, password FROM user WHERE username = @username AND password = @password "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        cm.Parameters.AddWithValue("@password", _Password)
        dr = cm.ExecuteReader()
        While dr.Read()
            If dr.HasRows Then
                dr.Close()
                DisconnectDatabase()
                Return True
            End If
        End While
        dr.Close()
        DisconnectDatabase()
        Return False
    End Function
    Public Function setUserId()
        ConnectDatabase()
        Dim query = "SELECT user_id FROM user WHERE username = @username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        Return cm.ExecuteScalar()
        DisconnectDatabase()
    End Function
    Public Sub setUserLogin(_key As Integer)
        ConnectDatabase()
        Dim query = "UPDATE user SET is_logged_in = '" & _key & "' WHERE username = @username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        cm.ExecuteScalar()
        DisconnectDatabase()
    End Sub
    Public Function setName(_key As Integer)
        ConnectDatabase()
        Dim query = "SELECT user_gname, user_surname FROM user_details WHERE user_id = '" & _key & "'"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader
        dr.Read()
        Dim name = dr.Item("user_gname").ToString & " " & dr.Item("user_surname").ToString
        dr.Close()
        DisconnectDatabase()
        Return name
    End Function
    Public Function setUserType() As String
        ConnectDatabase()
        Dim query = "SELECT user_type FROM user WHERE username = @username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        dr = cm.ExecuteReader
        dr.Read()
        Dim userType = dr.Item("user_type").ToString
        dr.Close()
        DisconnectDatabase()
        Return userType
    End Function
End Class
