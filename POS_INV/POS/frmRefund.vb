Public Class frmRefund
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

    End Sub

    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click
        frmAuthenticate.btn_Ok.Text = "Ok"
        frmAuthenticate.ShowDialog()
    End Sub

    Private Sub frmRefund_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
    End Sub

    Private Sub frmRefund_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btn_Add_Click(sender, e)
            Case Keys.F2
                btn_New_Click(sender, e)
            Case Keys.F5
                btn_Confirm_Click(sender, e)
            Case Keys.Escape
                btn_Back_Click(sender, e)

        End Select
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click

    End Sub

    Private Sub tb_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_invoiceNo_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_invoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class