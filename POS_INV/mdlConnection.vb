﻿Imports MySql.Data.MySqlClient
Module mdlConnection
    Public _EntryType As String
    Public con As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public Sub ConnectDatabase()

        Try
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "Persist Security Info = False; DATABASE=" & My.Settings.myDb & ";" &
                   "SERVER=" & My.Settings.myServer & ";user id=" & My.Settings.myUsername &
                   ";password=" & My.Settings.myPassword & ";port=" &
                   My.Settings.myPassword & ";charset=utf8;"
                con.Open()
            End If

        Catch myerror As Exception

        End Try
    End Sub

    Public Sub DisconnectDatabase()
        Try
            con.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException

        End Try
    End Sub
End Module
