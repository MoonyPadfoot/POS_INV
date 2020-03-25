Public Class frmLoginPos
    Dim loginPos As New clsLoginPos
    Dim authkey As Integer
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        loginPos.SetUsername(tb_username.Text)
        loginPos.SetPassword(tb_Password.Text)
        authKey = loginPos.authLogin()
        If authKey = 0 Then
            MsgBox("Username or Password incorrect.", vbCritical)
            Exit Sub
        ElseIf authKey = 1 Then
            MsgBox("Cashier is currently inactive.", vbCritical)
            Exit Sub
        ElseIf authKey = 2 Then
            MsgBox("Cashier is currently signed-in.", vbCritical)
            Exit Sub
        ElseIf authKey = 3 Then
            loginPos.setUserLogin(1)
            'lbl_user_Id.Text = loginPos.setUserId()
            frmPos.lbl_Username.Text = tb_username.Text
            tb_username.Clear()
            tb_Password.Clear()
            MsgBox("User logged in successfully.", vbInformation)
            frmPos.Show()
            frmMain.Hide()
            Me.Hide()
        End If
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        tb_Password.Clear()
        tb_username.Clear()
        Me.Close()
    End Sub
    Private Sub tb_username_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_username.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class