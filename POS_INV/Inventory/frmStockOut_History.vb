Public Class frmStockOut_History
    Dim stockOutHistory As New clsStockHistory

    Private Sub btn_load_History_Click(sender As Object, e As EventArgs) Handles btn_load_History.Click
        dg_stock_History.Rows.Clear()
        stockOutHistory.SetBranch(frmStock.tb_branch_stock_Out.Text)
        stockOutHistory.SetDateFrom(dtp_From.Value.ToString("yyyy-MM-dd"))
        stockOutHistory.SetDateTo(dtp_To.Value.ToString("yyyy-MM-dd"))
        stockOutHistory.loadStockOutHistory()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class