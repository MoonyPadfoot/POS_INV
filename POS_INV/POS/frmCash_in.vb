Public Class frmCash_in
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Proceed_Click(sender As Object, e As EventArgs) Handles btn_Proceed.Click
        frmAuthenticate.ShowDialog()
    End Sub
End Class