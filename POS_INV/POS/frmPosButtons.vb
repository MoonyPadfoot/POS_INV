Public Class frmPosButtons
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmQty.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frm_Checkout.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmNewTransaction.ShowDialog()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        frmNewTransaction.ShowDialog()
    End Sub
End Class