Imports MySql.Data.MySqlClient
Public Class clsRefund
    Private _TransDate As Object
    Private _ReceiptNo As Object
    Private _InvoiceNo As Object
    Private _ItemSearch As Object
    Private _BranchId As Object
    Public Sub SetTransDate(AutoPropertyValue As Object)
        _TransDate = AutoPropertyValue
    End Sub
    Public Sub SetReceiptNo(AutoPropertyValue As Object)
        _ReceiptNo = AutoPropertyValue
    End Sub
    Public Sub SetInvoiceNo(AutoPropertyValue As Object)
        _InvoiceNo = AutoPropertyValue
    End Sub
    Public Sub SetItemSearch(AutoPropertyValue As Object)
        _ItemSearch = AutoPropertyValue
    End Sub
    Public Sub SetBranchId(AutoPropertyValue As Object)
        _BranchId = AutoPropertyValue
    End Sub
    Public Function loadFromReceipt()
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT receipt FROM cash_payment WHERE receipt = @receipt AND trans_date = @trans_date) "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@receipt", _ReceiptNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        Dim count = cm.ExecuteScalar()

        If count = 1 Then
            DisconnectDatabase()
            Return True
        Else
            DisconnectDatabase()
            Return False
        End If
    End Function
    Public Function loadFromInvoice()
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT invoice FROM credit_payment WHERE invoice = @invoice AND trans_date = @trans_date) "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@invoice", _InvoiceNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        Dim count = cm.ExecuteScalar()

        If count = 1 Then
            DisconnectDatabase()
            Return True
        Else
            DisconnectDatabase()
            Return False
        End If
    End Function
    Public Sub searchItem(query As String) 'dg_Search item populate
        frmRefund.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        cm.Parameters.AddWithValue("@receipt", _ReceiptNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        dr = cm.ExecuteReader()
        While dr.Read
            frmRefund.dg_Search.Rows.Add(dr.Item("item_id").ToString, dr.Item("item_code").ToString, dr.Item("brand_name").ToString & " | " & dr.Item("item_desc").ToString & " | " & dr.Item("item_add_desc").ToString & " | " &
                                      dr.Item("category_name").ToString, dr.Item("qty").ToString, dr.Item("price").ToString, dr.Item("line_total").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchService(query As String) 'dg_Search service populate
        frmRefund.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@receipt", _ReceiptNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        dr = cm.ExecuteReader()
        While dr.Read
            frmRefund.dg_Search.Rows.Add(dr.Item("service_id").ToString, dr.Item("service_desc").ToString, dr.Item("qty").ToString, dr.Item("price").ToString, dr.Item("line_total").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchItemInvoice(query As String) 'dg_Search item populate
        frmRefund.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        cm.Parameters.AddWithValue("@invoice", _InvoiceNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        dr = cm.ExecuteReader()
        While dr.Read
            frmRefund.dg_Search.Rows.Add(dr.Item("item_id").ToString, dr.Item("item_code").ToString, dr.Item("brand_name").ToString & " | " & dr.Item("item_desc").ToString & " | " & dr.Item("item_add_desc").ToString & " | " &
                                      dr.Item("category_name").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("line_total").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchServiceInvoice(query As String) 'dg_Search service populate
        frmRefund.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@invoice", _InvoiceNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        dr = cm.ExecuteReader()
        While dr.Read
            frmRefund.dg_Search.Rows.Add(dr.Item("service_id").ToString, dr.Item("service_desc").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("line_total").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
End Class
