Public Class frmNewTransaction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Cash.Click
        frmPos.lbl_pay_Type.Text = "Cash"
        Me.Close()
    End Sub

    Private Sub btn_Credit_Click(sender As Object, e As EventArgs) Handles btn_Credit.Click
        frmPos.lbl_pay_Type.Text = "Credit"
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class