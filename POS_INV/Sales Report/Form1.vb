Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        ConnectDatabase()
        Dim dt As New DataSet
        Dim adpt As New MySqlDataAdapter
        Dim query = "SELECT * FROM cash_in"
        cm = New MySqlCommand(query, con)
        adpt.SelectCommand = cm
        adpt.Fill(dt, "cash_in")
        Dim report As New cr_CashIn
        report.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
        cm.Dispose()
        adpt.Dispose()
        dt.Dispose()
        DisconnectDatabase()
    End Sub
End Class