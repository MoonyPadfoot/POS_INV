Public Class frmCreditTransacs
    Dim credPay As New clsCreditPay

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub frmCreditTransacs_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim orderId = frmCreditPay.dg_Transactions.Item(0, frmCreditPay.dg_Transactions.CurrentRow.Index).Value
        cbo_Type.SelectedIndex = 0
        credPay.loadItems(orderId)
        lbl_due_Total.Text = Format(credPay.loadOrderTotal(orderId), "0.00")
    End Sub

    Private Sub cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Type.SelectedIndexChanged
        Dim orderId = frmCreditPay.dg_Transactions.Item(0, frmCreditPay.dg_Transactions.CurrentRow.Index).Value
        If cbo_Type.SelectedIndex = 0 Then
            credPay.loadItems(orderId)

        ElseIf cbo_Type.SelectedIndex = 1 Then
            credPay.loadServices(orderId)

        End If
    End Sub
End Class