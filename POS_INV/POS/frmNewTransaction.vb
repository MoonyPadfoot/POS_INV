Public Class frmNewTransaction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Cash.Click
        frmPos.lbl_pay_Type.Text = "Cash"
        frmPos.tb_customer_Code.Enabled = False
        frmPos.tb_customer_Name.Enabled = False
        Me.Close()
    End Sub

    Private Sub btn_Credit_Click(sender As Object, e As EventArgs) Handles btn_Credit.Click
        frmPos.lbl_pay_Type.Text = "Credit"
        frmPos.tb_customer_Code.Enabled = False
        frmPos.tb_customer_Name.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class