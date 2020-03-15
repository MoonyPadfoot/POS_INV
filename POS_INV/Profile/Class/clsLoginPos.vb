﻿Imports MySql.Data.MySqlClient
Public Class clsLoginPos
    Dim encryption As New clsEncryption
    Private _Username As String
    Private _Password As String

    Public Sub SetUsername(AutoPropertyValue As String)
        _Username = AutoPropertyValue
    End Sub
    Public Sub SetPassword(AutoPropertyValue As String)
        _Password = AutoPropertyValue
    End Sub
    Public Function authLogin()
        Dim salt As String = ""
        ConnectDatabase()
        Dim query = "SELECT COUNT(*) FROM cashier WHERE username = @username" 'check if active
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        Dim count = CInt(cm.ExecuteScalar)
        If count <> 1 Then
            DisconnectDatabase()
            Return 0
        End If

        query = "SELECT COUNT(*) FROM cashier WHERE username = @username AND is_active = 1" 'check if active
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        If CInt(cm.ExecuteScalar) <> 1 Then
            DisconnectDatabase()
            Return 1
        End If

        query = "SELECT COUNT(*) FROM cashier WHERE username = @username AND is_logged_in = 0" 'check if logged_in
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        If CInt(cm.ExecuteScalar) <> 1 Then
            DisconnectDatabase()
            Return 2
        End If

        query = "SELECT CAST(salt AS CHAR) AS salt FROM cashier WHERE username = @username"
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

        query = "SELECT COUNT(*) FROM cashier WHERE username = @username AND password = @password "
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
        Dim query = "SELECT cashier_id FROM cashier WHERE username = @username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        Return cm.ExecuteScalar()
        DisconnectDatabase()
    End Function
    Public Sub setUserLogin(_key As Integer)
        ConnectDatabase()
        Dim query = "UPDATE cashier SET is_logged_in = '" & _key & "' WHERE username = @username"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@username", _Username)
        cm.ExecuteScalar()
        DisconnectDatabase()
    End Sub
End Class