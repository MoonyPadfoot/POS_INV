Public Class frmStockTrans_History
    Dim stockTransHistory As New clsStockHistory
    Private Sub btn_load_History_Click(sender As Object, e As EventArgs) Handles btn_load_History.Click
        dg_stock_History.Rows.Clear()
        stockTransHistory.SetDateFrom(dtp_From.Value.ToString("yyyy-MM-dd"))
        stockTransHistory.SetDateTo(dtp_To.Value.ToString("yyyy-MM-dd"))
        stockTransHistory.loadStockTransHistory()
    End Sub
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        dg_stock_History.Rows.Clear()
        Me.Close()
    End Sub
End Class