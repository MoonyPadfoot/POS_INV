Imports MetroFramework.Forms
Public Class frmStock
    Dim id
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedTab = tp_stock_List
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        frmItemList.ShowDialog()
    End Sub
    Private Sub dg_stock_In_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dg_stock_In.EditingControlShowing
        Dim txtEdit As TextBox = e.Control
        RemoveHandler txtEdit.KeyPress, AddressOf TextEdit_keyPress
        AddHandler txtEdit.KeyPress, AddressOf TextEdit_keyPress
    End Sub
    Private Sub TextEdit_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If dg_stock_In.CurrentCell.ColumnIndex = 5 Then
            If IsNumeric(e.KeyChar.ToString()) Or e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dg_stock_In_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_stock_In.CellContentClick
        Dim colName As String = dg_stock_In.Columns(e.ColumnIndex).Name
        If colName = "col_Remove" Then
            dg_stock_In.Rows.RemoveAt(dg_stock_In.SelectedRows(0).Index)
            For i = 0 To dg_stock_In.RowCount - 1
                dg_stock_In.Rows(i).Cells(1).Value = i + 1
            Next
        End If
    End Sub

    Private Sub dg_stock_In_SelectionChanged(sender As Object, e As EventArgs) Handles dg_stock_In.SelectionChanged

    End Sub
End Class