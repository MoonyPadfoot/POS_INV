Imports MySql.Data.MySqlClient
Public Class clsStockIn
    Private _SupplierId As Object
    Private _SupplierName As Object
    Private _BranchId As Object
    Private _BranchAddress As Object
    Private _TransacDate As Object
    Private _Remarks As Object
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
    Public WriteOnly Property Remarks
        Set
            _Remarks = Value
        End Set
    End Property

    'Public Function generateRefNo() As Integer 'count stock_in for reference no.
    '    Dim id = 1
    '    ConnectDatabase()
    '    Dim query = "SELECT MAX(stock_in_id) AS stock_in_id FROM stock_in"
    '    cm = New MySqlCommand(query, con)
    '    dr = cm.ExecuteReader
    '    dr.Read()
    '    If dr.IsDBNull(0) Then
    '        dr.Close()
    '        DisconnectDatabase()
    '        Return id
    '    Else
    '        id = Val(dr.Item("stock_in_id")) + 1
    '        dr.Close()
    '        DisconnectDatabase()
    '        Return id
    '    End If
    'End Function
    Public Function save() As String
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO stock_in (branch_address) VALUES (@branch_address)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@supplier_name", _SupplierId)
            cm.Parameters.AddWithValue("@branch_name", _BranchId)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function loadBranchId()
        ConnectDatabase()
        Dim query = "SELECT branch_id FROM branch WHERE branch_address = @branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", _BranchAddress)
        Dim dr As MySqlDataReader = cm.ExecuteReader()
        If dr.HasRows Then
            dr.Read(
                )
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
End Class
