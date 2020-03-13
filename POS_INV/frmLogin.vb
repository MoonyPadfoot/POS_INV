Public Class frmLogin
    Dim login As New clsLogin
    Dim authKey As Boolean
    Private Sub btn_Login_Click_1(sender As Object, e As EventArgs) Handles btn_Login.Click
        If _authLogin = "Pos" Then
            frmPos.Show()
            frmMain.Close()
        ElseIf _authLogin = "Login" Then
            login.SetUsername(tb_username.Text)
            login.SetPassword(tb_Password.Text)
            authKey = login.authLogin()
            If authKey = False Then
                MsgBox("Username or Password incorrect.", vbCritical)
                Exit Sub
            ElseIf authKey = True Then
                login.setUserLogin(1)
                'lbl_user_Id.Text = login.setUserId()
                frmMain.lbl_Name.Text = login.setName(CInt(login.setUserId))
                frmMain.lbl_Username.Text = tb_username.Text
                frmMain.lbl_Type.Text = login.setUserType()
                tb_username.Clear()
                tb_Password.Clear()
                MsgBox("User logged in successfully.", vbInformation)
                frmMain.Show()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        If _authLogin = "Pos" Then
            Me.Close()
        ElseIf _authLogin = "Login" Then

            Me.Close()
                frmMain.Close()
            End If
    End Sub
End Class