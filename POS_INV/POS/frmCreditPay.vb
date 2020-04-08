Public Class frmCreditPay
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
    End Sub

    Private Sub btn_Checkout_Click_1(sender As Object, e As EventArgs) Handles btn_Checkout.Click
        frmCheckout.ShowDialog()
    End Sub

End Class