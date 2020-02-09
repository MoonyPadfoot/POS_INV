Public Class frmLogin
    Private Sub btn_Login_Click_1(sender As Object, e As EventArgs) Handles btn_Login.Click
        If _authLogin = "Pos" Then
            frmPos.Show()
            frmMain.Close()
        ElseIf _authlogin = "Login" Then
            frmMain.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub
End Class