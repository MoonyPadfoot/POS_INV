Imports MetroFramework.Forms
Public Class frmStock
    Dim supplier As New clsSupplier
    Dim branch As New clsBranch
    Dim stockIn As New clsStockIn
    Dim stockTrans As New clsStockTransfer
    Dim stockHistory As New clsStockHistory
    Dim stockReturn As New clsStockReturn
    '-----stock in end-----
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

    Private Sub btn_save_stock_In_Click(sender As Object, e As EventArgs) Handles btn_save_stock_In.Click
        If tb_branch_stock_In.Text = vbNullString Then
            Exit Sub
        End If
        branch.BranchName = tb_branch_stock_In.Text.Trim
        lbl_branch_id_stock_In.Text = branch.loadBranchId()
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
        supplier.SupplierName = tb_supplier_stock_In.Text.Trim
        lbl_supplier_id_stock_In.Text = supplier.loadSupplierId()
    End Sub

    Private Sub btn_new_stock_In_Click(sender As Object, e As EventArgs) Handles btn_new_stock_In.Click
        If MsgBox("All inputs will be cleared, Do you wish to proceed?", vbQuestion + vbYesNo) = vbYes Then
            clearControls()
        End If
    End Sub

    Private Sub btn_history_stock_In_Click(sender As Object, e As EventArgs) Handles btn_history_stock_In.Click
        frmStockIn_History.ShowDialog()
    End Sub

    Private Sub dg_stock_In_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_stock_In.EditingControlShowing
        If dg_stock_In.CurrentCell.ColumnIndex = 7 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf col_Qty_keypress
        End If
    End Sub
    Private Sub col_Qty_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If dg_stock_In.CurrentCell.ColumnIndex = 7 Then
            If IsNumeric(e.KeyChar.ToString()) Or e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    '-----stock transfer----
    Private Sub lbl_items_sT_Click(sender As Object, e As EventArgs) Handles lbl_items_sT.Click
        frmItemList.ShowDialog()
    End Sub
    Private Sub dg_stock_Transfer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_stock_Transfer.CellContentClick
        Dim colName As String = dg_stock_Transfer.Columns(e.ColumnIndex).Name
        If colName = "col_remove_St" Then
            If MsgBox("Do you wish to remove item from the list?", vbQuestion + vbYesNo) = vbYes Then
                dg_stock_Transfer.Rows.RemoveAt(dg_stock_Transfer.SelectedRows(0).Index)
                For i = 0 To dg_stock_Transfer.RowCount - 1
                    dg_stock_Transfer.Rows(i).Cells(1).Value = i + 1
                Next
                MsgBox("Item has been removed.", vbInformation)
            End If
        End If
    End Sub
    Private Sub lbl_items_sT_MouseHover(sender As Object, e As EventArgs) Handles lbl_items_sT.MouseHover
        lbl_items_sT.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_items_sT_MouseLeave(sender As Object, e As EventArgs) Handles lbl_items_sT.MouseLeave
        lbl_items_sT.ForeColor = Color.Black
    End Sub

    Private Sub tb_branch_to_sT_Leave(sender As Object, e As EventArgs) Handles tb_branch_to_sT.Leave
        If tb_branch_to_sT.Text = vbNullString Then
            Exit Sub
        End If
        branch.BranchName = tb_branch_to_sT.Text.Trim
        lbl_branch_to_id_sT.Text = branch.loadBranchId()
    End Sub
    Private Sub btn_save_stock_Trans_Click(sender As Object, e As EventArgs) Handles btn_save_stock_Trans.Click
        If tb_branch_from_sT.Text = vbNullString Then
            Exit Sub
        End If
        branch.BranchName = tb_branch_from_sT.Text.Trim
        lbl_branch_from_id_sT.Text = branch.loadBranchId()
        If countEmpty() = True Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        If Val(lbl_branch_to_id_sT.Text) = -1 Then
            MsgBox("Please input an existing branch.", vbExclamation)
            tb_branch_stock_In.Focus()
            Exit Sub
        End If
        If dg_stock_Transfer.RowCount = 0 Then
            MsgBox("Please add the items to be stocked.", vbExclamation)
            Exit Sub
        End If
        stockTrans.BranchFromId = lbl_branch_from_id_sT.Text
        For i = 0 To dg_stock_Transfer.RowCount - 1
            stockTrans.ItemId = dg_stock_Transfer.Rows(i).Cells(0).Value
            If dg_stock_Transfer.Rows(i).Cells(7).Value = 0 Then
                MsgBox("Please fill in a valid quantity.", vbExclamation)
                Exit Sub
            End If
            Dim _itemDesc = dg_stock_Transfer.Rows(i).Cells(3).Value & "|" & dg_stock_Transfer.Rows(i).Cells(4).Value & "|" & dg_stock_Transfer.Rows(i).Cells(5).Value
            If stockTrans.checkItemBranchExists() <> True Then
                MsgBox("Item: " & _itemDesc & " has no stock in record", vbExclamation)
                Exit Sub
            End If
            If dg_stock_Transfer.Rows(i).Cells(7).Value > stockTrans.getItemBranchQty Then
                MsgBox("Item: " & _itemDesc & " currently on stock exceeds the amount to be transfered", vbExclamation)
                Exit Sub
            End If
        Next
        Dim _refNo = stockTrans.getRefNo
        stockTrans.RefNo = _refNo
        Dim refNoLegnth As String = _refNo.ToString
        Dim zero = ""
        For i = 0 To 5 - refNoLegnth.Length
            zero &= "0"
            i += 1
        Next
        For i = 0 To dg_stock_Transfer.RowCount - 1    'sets the column entries for stock_in table per dg_stock_in row
            stockTrans.ItemId = dg_stock_Transfer.Rows(i).Cells(0).Value   'item_id
            stockTrans.BranchFromId = lbl_branch_from_id_sT.Text 'branch_id
            stockTrans.BranchToId = lbl_branch_to_id_sT.Text 'supplier_id
            stockTrans.ItemQty = dg_stock_Transfer.Rows(i).Cells(7).Value 'qty
            stockTrans.TransacDate = dtp_stock_Transfer.Value.ToString("yyyy-MM-dd") 'transac_date
            stockTrans.Remarks = tb_remarks_sT.Text 'remarks
            stockTrans.save()
        Next
        MsgBox("Reference Code: " & "SI" & dtp_stock_Transfer.Value.ToString("yyyyMMdd") & zero & _refNo, vbInformation) 'generate ref Code
        clearControls()
    End Sub

    Private Sub btn_new_stock_Trans_Click(sender As Object, e As EventArgs) Handles btn_new_stock_Trans.Click
        If MsgBox("All inputs will be cleared, Do you wish to proceed?", vbQuestion + vbYesNo) = vbYes Then
            clearControls()
        End If
    End Sub
    Private Sub btn_history_stock_Trans_Click(sender As Object, e As EventArgs) Handles btn_history_stock_Trans.Click
        frmStockTrans_History.ShowDialog()
    End Sub
    Private Sub dg_stock_Transfer_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_stock_Transfer.EditingControlShowing
        If dg_stock_Transfer.CurrentCell.ColumnIndex = 7 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf col_qty_sT_keyPress
        End If
    End Sub
    Private Sub col_qty_sT_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If dg_stock_Transfer.CurrentCell.ColumnIndex = 7 Then
            If IsNumeric(e.KeyChar.ToString()) Or e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    '------stock return-----
    Private Sub lbl_items_sR_Click(sender As Object, e As EventArgs) Handles lbl_items_sR.Click
        frmItemList.ShowDialog()
    End Sub
    Private Sub dg_stock_Return_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_stock_Return.CellContentClick
        Dim colName As String = dg_stock_Return.Columns(e.ColumnIndex).Name
        If colName = "col_remove_sR" Then
            If MsgBox("Do you wish to remove item from the list?", vbQuestion + vbYesNo) = vbYes Then
                dg_stock_Return.Rows.RemoveAt(dg_stock_Return.SelectedRows(0).Index)
                For i = 0 To dg_stock_Return.RowCount - 1
                    dg_stock_Return.Rows(i).Cells(1).Value = i + 1
                Next
                MsgBox("Item has been removed.", vbInformation)
            End If
        End If
    End Sub
    Private Sub lbl_items_sR_MouseHover(sender As Object, e As EventArgs) Handles lbl_items_sR.MouseHover
        lbl_items_sR.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_items_sR_In_MouseLeave(sender As Object, e As EventArgs) Handles lbl_items_sR.MouseLeave
        lbl_items_sR.ForeColor = Color.Black
    End Sub
    Private Sub btn_save_stock_Return_Click(sender As Object, e As EventArgs) Handles btn_save_stock_Return.Click
        If tb_branch_sR.Text = vbNullString Then
            Exit Sub
        End If
        branch.BranchName = tb_branch_sR.Text.Trim
        lbl_branch_id_sR.Text = branch.loadBranchId()
        If countEmpty() = True Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        If Val(lbl_supplier_id_sR.Text) = -1 Then
            MsgBox("Please input an existing supplier.", vbExclamation)
            tb_supplier_sR.Focus()
            Exit Sub
        End If
        If Val(lbl_branch_id_sR.Text) = -1 Then
            MsgBox("Please input an existing branch.", vbExclamation)
            tb_branch_sR.Focus()
            Exit Sub
        End If
        If dg_stock_Return.RowCount = 0 Then
            MsgBox("Please add the items to be stocked.", vbExclamation)
            Exit Sub
        End If
        stockReturn.BranchId = lbl_branch_id_sR.Text
        For i = 0 To dg_stock_Return.RowCount - 1
            stockReturn.ItemId = dg_stock_Return.Rows(i).Cells(0).Value
            If dg_stock_Return.Rows(i).Cells(7).Value = 0 Then
                MsgBox("Please fill in a valid quantity.", vbExclamation)
                Exit Sub
            End If
            Dim _itemDesc = dg_stock_Return.Rows(i).Cells(3).Value & "|" & dg_stock_Return.Rows(i).Cells(4).Value & "|" & dg_stock_Return.Rows(i).Cells(5).Value
            If stockReturn.checkItemBranchExists() <> True Then
                MsgBox("Item: " & _itemDesc & " has no stock in record", vbExclamation)
                Exit Sub
            End If
            If dg_stock_Return.Rows(i).Cells(7).Value > stockReturn.getItemBranchQty Then
                MsgBox("Item: " & _itemDesc & " currently on stock exceeds the amount to be transfered", vbExclamation)
                Exit Sub
            End If
        Next
        Dim _refNo = stockReturn.getRefNo
        stockReturn.RefNo = _refNo
        Dim refNoLegnth As String = _refNo.ToString
        Dim zero = ""
        For i = 0 To 5 - refNoLegnth.Length
            zero &= "0"
            i += 1
        Next
        For i = 0 To dg_stock_Return.RowCount - 1    'sets the column entries for stock_in table per dg_stock_in row
            stockReturn.ItemId = dg_stock_Return.Rows(i).Cells(0).Value   'item_id
            stockReturn.BranchId = lbl_branch_id_sR.Text 'branch_id
            stockReturn.SupplierId = lbl_supplier_id_sR.Text 'supplier_id
            stockReturn.ItemQty = dg_stock_Return.Rows(i).Cells(7).Value 'qty
            stockReturn.TransacDate = dtp_stock_Return.Value.ToString("yyyy-MM-dd") 'transac_date
            stockReturn.Remarks = tb_remarks_sR.Text 'remarks
            stockReturn.save()
        Next
        MsgBox("Reference Code: " & "SR" & dtp_stock_Return.Value.ToString("yyyyMMdd") & zero & _refNo, vbInformation) 'generate ref Code
        clearControls()
    End Sub

    Private Sub tb_supplier_sR_Leave(sender As Object, e As EventArgs) Handles tb_supplier_sR.Leave
        If tb_supplier_sR.Text = vbNullString Then
            Exit Sub
        End If
        supplier.SupplierName = tb_supplier_sR.Text.Trim
        lbl_supplier_id_sR.Text = supplier.loadSupplierId()
    End Sub
    Private Sub btn_new_stock_Return_Click(sender As Object, e As EventArgs) Handles btn_new_stock_Return.Click
        If MsgBox("All inputs will be cleared, Do you wish to proceed?", vbQuestion + vbYesNo) = vbYes Then
            clearControls()
        End If
    End Sub
    Private Sub dg_stock_Return_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_stock_Return.EditingControlShowing
        If dg_stock_Return.CurrentCell.ColumnIndex = 7 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf col_qty_sR_keyPress
        End If
    End Sub
    Private Sub col_qty_sR_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If dg_stock_Return.CurrentCell.ColumnIndex = 7 Then
            If IsNumeric(e.KeyChar.ToString()) Or e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    ' all
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedTab = tp_stock_List
        stockTrans.BranchToId = frmMain.lbl_branch_Id.Text
        stockTrans.loadAutoSuggestBranch()
        supplier.loadAutosuggest()
    End Sub
    Private Function countEmpty()
        If lbl_stock_Type.Text = 1 Then
            If tb_branch_stock_In.Text = vbNullString Then
                tb_branch_stock_In.Focus()
                Return True
            ElseIf tb_supplier_stock_In.Text = vbNullString Then
                tb_supplier_stock_In.Focus()
                Return True
            End If
        ElseIf lbl_stock_Type.Text = 2 Then
            If tb_branch_from_sT.Text = vbNullString Then
                tb_branch_from_sT.Focus()
                Return True
            ElseIf tb_branch_to_sT.Text = vbNullString Then
                tb_branch_to_sT.Focus()
                Return True
            End If
        End If
        Return False
    End Function
    Private Sub clearControls()
        If lbl_stock_Type.Text = 1 Then
            tb_supplier_stock_In.Clear()
            tb_remarks_stock_In.Clear()
            dg_stock_In.Rows.Clear()
        ElseIf lbl_stock_Type.Text = 2 Then
            tb_branch_to_sT.Clear()
            tb_remarks_sT.Clear()
            dg_stock_Transfer.Rows.Clear()
        ElseIf lbl_stock_Type.Text = 3 Then
            tb_supplier_sR.Clear()
            tb_remarks_sR.Clear()
            dg_stock_Return.Rows.Clear()
        End If
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
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        If MetroTabControl1.SelectedIndex = 1 Then
            lbl_stock_Type.Text = 1
        ElseIf MetroTabControl1.SelectedIndex = 2 Then
            lbl_stock_Type.Text = 2
        ElseIf MetroTabControl1.SelectedIndex = 3 Then
            lbl_stock_Type.Text = 3
        ElseIf MetroTabControl1.SelectedIndex = 4 Then
            lbl_stock_Type.Text = 4
        End If
    End Sub

    Private Sub btn_history_stock_Return_Click(sender As Object, e As EventArgs) Handles btn_history_stock_Return.Click
        frmStockRet_History.ShowDialog()
    End Sub
End Class