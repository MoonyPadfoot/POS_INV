Imports MySql.Data.MySqlClient
Public Class clsLogin
    Dim encryption As New clsEncryption
    Private _Username As String
    Private _Password As String

    Public Sub SetUsername(AutoPropertyValue As String)
        _Username = AutoPropertyValue
    End Sub
    Public Sub SetPassword(AutoPropertyValue As String)
        _Password = AutoPropertyValue
    End Sub
    Public Function authLogin() As Integer
        Dim salt As String = ""
        ConnectDatabase()
        Dim query = "SELECT COUNT(*) FROM user WHERE username = @username" 'check if active
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        Dim count = CInt(cm.ExecuteScalar)
        If count <> 1 Then
            DisconnectDatabase()
            Return 0
        End If

        query = "SELECT COUNT(*) FROM user WHERE username = @username AND is_active = 1" 'check if active
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        If CInt(cm.ExecuteScalar) <> 1 Then
            DisconnectDatabase()
            Return 1
        End If


        query = "SELECT COUNT(*) FROM user WHERE username = @username AND is_logged_in = 0" 'check if logged_in
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        If CInt(cm.ExecuteScalar) <> 1 Then
            DisconnectDatabase()
            Return 2
        End If

        query = "SELECT CAST(salt AS CHAR) AS salt FROM user WHERE username = @username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        dr = cm.ExecuteReader()
        While dr.Read()
            If dr.HasRows Then
                salt = dr("salt").ToString
            Else
                dr.Close()
                DisconnectDatabase()
                Return 0
            End If
        End While
        dr.Close()

        Dim pass = encryption.hashString(_Password & _Username)
        Dim hashedAndSalt = encryption.hashString(String.Format("{0},{1}", pass, salt))

        query = "SELECT COUNT(*) FROM user WHERE username = @username AND password = @password "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        cm.Parameters.AddWithValue("@password", hashedAndSalt)

        Dim results = CInt(cm.ExecuteScalar())
        If results = 1 Then
            DisconnectDatabase()
            Return 3
        Else
            DisconnectDatabase()
            Return 0
        End If
        DisconnectDatabase()
        Return 0
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
