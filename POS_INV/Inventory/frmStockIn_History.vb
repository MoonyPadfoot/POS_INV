﻿Public Class frmStockIn_History
    Dim stockInHistory As New clsStockHistory
    Private Sub btn_load_History_Click(sender As Object, e As EventArgs) Handles btn_load_History.Click
        dg_stock_History.Rows.Clear()
        stockInHistory.SetDateFrom(dtp_From.Value.ToString("yyyy-MM-dd"))
        stockInHistory.SetDateTo(dtp_To.Value.ToString("yyyy-MM-dd"))
        stockInHistory.loadStockHistory()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

End Class