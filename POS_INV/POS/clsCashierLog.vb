Imports MySql.Data.MySqlClient
Public Class clsCashierLog
    Private _CashierId As Object
    Private _ManagerId As Object
    Private _LogDate As Object
    Private _TimeIn As Object
    Private _InBal As Object

    Public Sub SetCashierId(AutoPropertyValue As String)
        _CashierId = AutoPropertyValue
    End Sub
    Public Sub SetManagerId(AutoPropertyValue As String)
        _ManagerId = AutoPropertyValue
    End Sub
    Public Sub SetLogDate(AutoPropertyValue As String)
        _LogDate = AutoPropertyValue
    End Sub
    Public Sub SetTimeIn(AutoPropertyValue As String)
        _TimeIn = AutoPropertyValue
    End Sub
    Public Sub SetInBal(AutoPropertyValue As String)
        _InBal = AutoPropertyValue
    End Sub
    Public Function setCashierIn()
        ConnectDatabase()
        Dim query = "INSERT INTO cashier_log (cashier_id, manager_id, log_date, time_from, begin_bal) VALUES (@cashier_id, @manager_id, @log_date, @time_from, @begin_bal); " &
                    "SELECT LAST_INSERT_ID()"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        cm.Parameters.AddWithValue("@manager_id", _ManagerId)
        cm.Parameters.AddWithValue("@log_date", _LogDate)
        cm.Parameters.AddWithValue("@time_from", _TimeIn)
        cm.Parameters.AddWithValue("@begin_bal", _InBal)
        Return cm.ExecuteScalar()
        DisconnectDatabase()
    End Function
    Public Sub setCashierOut()

        ConnectDatabase()
        Dim query = "UPDATE cashier_log SET time_to = @time_to, end_bal = @end_bal WHERE "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        cm.Parameters.AddWithValue("@manager_id", _ManagerId)
        cm.Parameters.AddWithValue("@log_date", _LogDate)
        cm.Parameters.AddWithValue("@time_from", _TimeIn)
        cm.Parameters.AddWithValue("@begin_bal", _InBal)
        cm.ExecuteScalar()
        DisconnectDatabase()
    End Sub
End Class
