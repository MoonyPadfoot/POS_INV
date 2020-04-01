Public Class frmAuthenticate
    Dim cashLog As New clsCashierLog
    Dim auth As New clsAuth
    Dim authKey As Integer
    Private Sub btn_Ok_Click_(sender As Object, e As EventArgs) Handles btn_Ok.Click
        auth.SetUsername(tb_Username.Text) 'authkey: 1 if inactive, 2 signed-in, 3 if valid
        auth.SetPassword(tb_Password.Text)
        authKey = auth.authLogin()
        If authKey = 0 Then
            MsgBox("Username or Password incorrect.", vbCritical)
            Exit Sub
        ElseIf authKey = 1 Then
            MsgBox("User is currently inactive.", vbCritical)
            Exit Sub
        ElseIf authKey = 3 Then
            tb_Username.Clear()
            tb_Password.Clear()
            MsgBox("Verfied by manager.", vbInformation)
        End If

        If lbl_Type.Text = 1 Then
            cashLog.SetCashierId(frmPos.lbl_user_Id.Text)
            cashLog.SetManagerId(auth.setUserId)
            cashLog.SetLogDate(Date.Now.ToString("yyyy-MM-dd"))
            cashLog.SetTimeIn(TimeOfDay.ToString("HH:mm:ss"))
            cashLog.SetInBal(frmBalance.tb_initial_Bal.Text)
            cashLog.setCashierIn()

        End If
        frmBalance.tb_initial_Bal.Clear()
        frmBalance.Close()
        Me.Close()
    End Sub

    Private Sub tb_username_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Username.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

End Class