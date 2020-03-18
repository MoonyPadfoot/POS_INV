Public Class frmItemList
    Dim itemList As New clsItemList
    Dim _id, _code, _desc, _brand, _category
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
    Private Sub dg_Items_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Items.CellContentClick
        Dim colName As String = dg_Items.Columns(e.ColumnIndex).Name
        Dim stockId = dg_Items.Rows(e.RowIndex).Cells(0).Value
        If frmStock.dg_stock_In.RowCount <> 0 Then
            For i = 0 To frmStock.dg_stock_In.RowCount - 1
                Dim b = frmStock.dg_stock_In.Rows(i).Cells(0).Value
                If stockId = b Then
                    MsgBox("Item has already been added.", vbExclamation)
                    Exit Sub
                End If
            Next
        End If
        If colName = "col_Select" Then
            If MsgBox("Add item to list?", vbYesNo + vbInformation) = vbYes Then
                frmStock.dg_stock_In.Rows.Add(dg_Items.Rows(e.RowIndex).Cells(0).Value.ToString, frmStock.dg_stock_In.Rows.Count + 1.ToString, dg_Items.Rows(e.RowIndex).Cells(2).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(3).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(4).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(5).Value.ToString, 0.ToString, "REMOVE")
                MsgBox("Item is added to the list.", vbInformation)
            End If
        End If
    End Sub
    'Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
    '    If Trim(tb_Search.Text) <> "" Then
    '        Select Case cbo_Filter.Text
    '            Case "Username"
    '                userList.UserSearch = Trim(tb_Search.Text)
    '                userList.searchUser("SELECT user.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS username, user_type, is_active FROM user " &
    '                        "INNER JOIN user_details ON user.user_id = user_details.user_id " &
    '                        "INNER JOIN branch ON branch.branch_id = user.branch_id WHERE user.username LIKE @0")
    '            Case "Name"
    '                userList.UserSearch = Trim(tb_Search.Text)
    '                userList.searchUser("SELECT user.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS username, user_type, is_active FROM user " &
    '                        "INNER JOIN user_details ON user.user_id = user_details.user_id " &
    '                        "INNER JOIN branch ON branch.branch_id = user.branch_id WHERE user_details.user_gname LIKE @0 OR user_details.user_surname LIKE @0")
    '            Case "Branch"
    '                userList.UserSearch = Trim(tb_Search.Text)
    '                userList.searchUser("SELECT user.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS username, user_type, is_active FROM user " &
    '                        "INNER JOIN user_details ON user.user_id = user_details.user_id " &
    '                        "INNER JOIN branch ON branch.branch_id = user.branch_id WHERE branch_address LIKE @0")
    '        End Select
    '    Else
    '        userList.loadRecord()
    '    End If
    'End Sub
    'Private Sub frmUserList_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    cbo_Filter.Text = "Name"
    '    userList.loadRecord()
    'End Sub
    Private Sub tb_Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Search.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "',- .abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmItemList_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_Filter.Text = "Description"
        itemList.loadRecord()
    End Sub
End Class