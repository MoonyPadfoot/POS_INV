Public Class frmCustomers
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btn_Add.Click
        frmCustomerEntry.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class