Imports MySql.Data.MySqlClient
Public Class clsStockIn
    Private _ItemId As Object
    Private _RefNo As Object
    Private _SupplierId As Object
    Private _SupplierName As Object
    Private _BranchId As Object
    Private _BranchAddress As Object
    Private _TransacDate As Object
    Private _ItemQty As Object
    Private _Remarks As Object
    Public WriteOnly Property ItemId
        Set
            _ItemId = Value
        End Set
    End Property
    Public WriteOnly Property RefNo
        Set
            _RefNo = Value
        End Set
    End Property
    Public WriteOnly Property SupplierId
        Set
            _SupplierId = Value
        End Set
    End Property
    Public WriteOnly Property SupplierName
        Set
            _SupplierName = Value
        End Set
    End Property
    Public WriteOnly Property BranchId
        Set
            _BranchId = Value
        End Set
    End Property
    Public WriteOnly Property BranchAddress
        Set
            _BranchAddress = Value
        End Set
    End Property
    Public WriteOnly Property TransacDate
        Set
            _TransacDate = Value
        End Set
    End Property
    Public WriteOnly Property ItemQty
        Set
            _ItemQty = Value
        End Set
    End Property
    Public WriteOnly Property Remarks
        Set
            _Remarks = Value
        End Set
    End Property
    Public Sub save()
        'Try
        ConnectDatabase()
            'Dim query = "INSERT INTO stock_in (item_id, ref_no, branch_id, supplier_id, qty, trans_date, remarks) VALUES (@item_id, @ref_no, @branch_id, @supplier_id, @qty, @trans_date, @remarks); " &
            '    "SELECT item_qty FROM item WHERE item_id = @item_id"
            Dim query = "INSERT INTO inventory (item_id, branch_id) VALUES (@item_id, @branch_id); SELECT LAST_INSERT_ID() "
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@item_id", _ItemId)
            cm.Parameters.AddWithValue("@branch_id", _BranchId)
            Dim inventory_id = cm.ExecuteScalar()
            cm.Dispose()

            query = "INSERT INTO stock_in (inventory_id, ref_no, branch_id, supplier_id, qty, trans_date, remarks) " &
                    "VALUES (@inventory_id, @ref_no, @branch_id, @supplier_id, @qty, @trans_date, @remarks); " &
                    "SELECT qty FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@inventory_id", inventory_id)
            cm.Parameters.AddWithValue("@ref_no", _RefNo)
            cm.Parameters.AddWithValue("@supplier_id", _SupplierId)
            cm.Parameters.AddWithValue("@qty", _ItemQty)
            cm.Parameters.AddWithValue("@trans_date", _TransacDate)
            cm.Parameters.AddWithValue("@remarks", _Remarks)
            cm.Parameters.AddWithValue("@item_id", _ItemId)
            cm.Parameters.AddWithValue("@branch_id", _BranchId)
            Dim initialQty = cm.ExecuteScalar()
            cm.Dispose()

            Dim newStockQty = _ItemQty + initialQty  'computes the sum of initial item qty with stock entry qty
            query = "UPDATE inventory SET qty = " & newStockQty & " WHERE item_id = @item_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@item_id", _ItemId)
            cm.ExecuteScalar()
            cm.Dispose()
            DisconnectDatabase()
        'Catch ex As Exception
        '    DisconnectDatabase()
        '    MsgBox(ex.Message, vbCritical)
        'End Try
    End Sub
    Public Function getRefNo() As Integer  'checks table is empty with return of count = 1 else if empty count = 0
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT ref_no FROM stock_in)"
        cm = New MySqlCommand(query, con)
        Dim count = cm.ExecuteScalar()
        cm.Dispose()

        If count = 1 Then
            query = "SELECT MAX(ref_No) AS refNo FROM stock_in"
            cm = New MySqlCommand(query, con)
            Dim ret = cm.ExecuteScalar() + 1
            cm.Dispose()
            DisconnectDatabase()
            Return ret
        Else
            Return 1
        End If
        DisconnectDatabase()
    End Function
    Public Function loadBranchId()
        ConnectDatabase()
        Dim query = "SELECT branch_id FROM branch WHERE branch_address = @branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", _BranchAddress)
        Dim dr As MySqlDataReader = cm.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Dim id = dr(0).ToString
            dr.Close()
            DisconnectDatabase()
            Return id
        Else
            dr.Close()
            DisconnectDatabase()
            Return -1
        End If
        DisconnectDatabase()
    End Function
    Public Function loadSupplierId()
        ConnectDatabase()
        Dim query = "SELECT supplier_id FROM supplier WHERE supplier_name = @supplier_name"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@supplier_name", _SupplierName)
        Dim dr As MySqlDataReader = cm.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Dim id = dr(0).ToString
            dr.Close()
            DisconnectDatabase()
            Return id
        Else
            dr.Close()
            DisconnectDatabase()
            Return -1
        End If
        DisconnectDatabase()
    End Function
    Public Function loadBranchName()
        ConnectDatabase()
        Dim query = "SELECT branch_address FROM branch WHERE branch_id = @branch_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_id", frmMain.lbl_branch_Id.Text)
        Dim _branchName = cm.ExecuteScalar()
        DisconnectDatabase()
        Return _branchName
    End Function
End Class
