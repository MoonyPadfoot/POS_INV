Public Class frmCreditPay
    Private Sub btn_Back_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_Checkout_Click(sender As Object, e As EventArgs)
        frm_Checkout.ShowDialog()
    End Sub

End Class