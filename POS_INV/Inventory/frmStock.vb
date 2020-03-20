Imports MetroFramework.Forms
Public Class frmStock
    Dim supplier As New clsSupplier
    Dim branch As New clsBranch
    Dim stockIn As New clsStockIn
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedTab = tp_stock_List
        branch.loadAutosuggest()
        supplier.loadAutosuggest()
    End Sub
    Private Sub lbl_items_stock_In_Click(sender As Object, e As EventArgs) Handles lbl_items_stock_In.Click
        frmItemList.ShowDialog()
    End Sub
    Private Sub dg_stock_In_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_stock_In.CellContentClick
        Dim colName As String = dg_stock_In.Columns(e.ColumnIndex).Name
        If colName = "col_Remove" Then
            If MsgBox("Do you wish to remove item from the list?", vbQuestion + vbYesNo) = vbYes Then
                dg_stock_In.Rows.RemoveAt(dg_stock_In.SelectedRows(0).Index)
                For i = 0 To dg_stock_In.RowCount - 1
                    dg_stock_In.Rows(i).Cells(1).Value = i + 1
                Next
                MsgBox("Item has been removed.", vbInformation)
            End If
        End If
    End Sub
    'Dim zero As String = "0"
    'Dim refNo As Integer = stockIn.generateRefNo() 'count stock_in_id for reference no.
    'For i = 0 To 5 - refNo.ToString.Length 'number of zeros
    '    zero &= "0"
    '    i += 1
    'Next
    'tb_ref_stock_In.Text = "SI" & dtp_stock_In.Value.ToString("yyyyMMdd") & zero & refNo
    Private Sub lbl_items_stock_In_MouseHover(sender As Object, e As EventArgs) Handles lbl_items_stock_In.MouseHover
        lbl_items_stock_In.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_items_stock_In_In_MouseLeave(sender As Object, e As EventArgs) Handles lbl_items_stock_In.MouseLeave
        lbl_items_stock_In.ForeColor = Color.Black
    End Sub
    Private Function countEmpty()
        If tb_branch_stock_In.Text = vbNullString Then
            tb_branch_stock_In.Focus()
            Return True
        ElseIf tb_supplier_stock_In.Text = vbNullString Then
            tb_supplier_stock_In.Focus()
            Return True
        End If
        Return False
    End Function
    Private Sub clearControls()
        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.Text = vbNullString
            End If
        Next
    End Sub
    Private Sub btn_save_stock_In_Click(sender As Object, e As EventArgs) Handles btn_save_stock_In.Click
        If countEmpty() = True Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        If Val(lbl_supplier_id_stock_In.Text) = -1 Then
            MsgBox("Please input an existing supplier.", vbExclamation)
            tb_supplier_stock_In.Focus()
            Exit Sub
        End If
        If Val(lbl_branch_id_stock_In.Text) = -1 Then
            MsgBox("Please input an existing branch.", vbExclamation)
            tb_branch_stock_In.Focus()
            Exit Sub
        End If
        If dg_stock_In.RowCount = 0 Then
            MsgBox("Please add the items to be stocked.", vbExclamation)
            Exit Sub
        End If
        For i = 0 To dg_stock_In.RowCount - 1
            If dg_stock_In.Rows(i).Cells(7).Value = 0 Then
                MsgBox("Please fill in a valid quantity.", vbExclamation)
                Exit Sub
            End If
        Next
        stockIn.BranchId = tb_branch_stock_In.Text
        stockIn.SupplierId = tb_supplier_stock_In.Text
        stockIn.Remarks = tb_remarks_stock_In.Text
        stockIn.TransacDate = dtp_stock_In.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub tb_supplier_stock_In_Leave(sender As Object, e As EventArgs) Handles tb_supplier_stock_In.Leave
        If tb_supplier_stock_In.Text = vbNullString Then
            Exit Sub
        End If
        stockIn.SupplierName = tb_supplier_stock_In.Text.Trim
        lbl_supplier_id_stock_In.Text = stockIn.loadSupplierId()
    End Sub
    Private Sub tb_branch_stock_In_Leave(sender As Object, e As EventArgs) Handles tb_branch_stock_In.Leave
        If tb_branch_stock_In.Text = vbNullString Then
            Exit Sub
        End If
        stockIn.BranchAddress = tb_branch_stock_In.Text.Trim
        lbl_branch_id_stock_In.Text = stockIn.loadBranchId()
    End Sub
End Class