Imports MetroFramework.Forms
Public Class frmStock
    Dim supplier As New clsSupplier
    Dim branch As New clsBranch
    Dim stockIn As New clsStockIn
    Dim stockHistory As New clsStockHistory
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
        tb_branch_stock_In.Clear()
        tb_supplier_stock_In.Clear()
        tb_remarks_stock_In.Clear()
        dg_stock_In.Rows.Clear()
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
        Dim _refNo = stockIn.getRefNo
        stockIn.RefNo = _refNo
        Dim refNoLegnth As String = _refNo.ToString
        Dim zero = ""
        For i = 0 To 5 - refNoLegnth.Length
            zero &= "0"
            i += 1
        Next
        For i = 0 To dg_stock_In.RowCount - 1    'sets the column entries for stock_in table per dg_stock_in row
            stockIn.ItemId = dg_stock_In.Rows(i).Cells(0).Value   'item_id
            stockIn.BranchId = lbl_branch_id_stock_In.Text 'branch_id
            stockIn.SupplierId = lbl_supplier_id_stock_In.Text 'supplier_id
            stockIn.ItemQty = dg_stock_In.Rows(i).Cells(7).Value 'qty
            stockIn.TransacDate = dtp_stock_In.Value.ToString("yyyy-MM-dd") 'transac_date
            stockIn.Remarks = tb_remarks_stock_In.Text 'remarks
            stockIn.save()
        Next
        MsgBox("Reference Code: " & "SI" & dtp_stock_In.Value.ToString("yyyyMMdd") & zero & _refNo, vbInformation) 'generate ref Code
        clearControls()
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

    Private Sub btn_new_stock_In_Click(sender As Object, e As EventArgs) Handles btn_new_stock_In.Click
        If MsgBox("All inputs will be cleared, Do you wish to proceed?", vbQuestion + vbYesNo) = vbYes Then
            clearControls()
        End If
    End Sub

    Private Sub btn_history_stock_In_Click(sender As Object, e As EventArgs) Handles btn_history_stock_In.Click
        frmStockIn_History.ShowDialog()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        If frmMain.lbl_Type.Text = "Manager" Then
            frmMain.btn_Profile.Enabled = False
            frmMain.btn_Logout.Enabled = True
            frmMain.btn_sales_Report.Enabled = True
            frmMain.btn_Customer.Enabled = True
            frmMain.btn_Pos.Enabled = True
        End If
        Me.Close()
    End Sub
End Class