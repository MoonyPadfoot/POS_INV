Public Class frmUser
    Dim user As New clsUser
    Dim _id, _is_actve
    Dim _branch, _gName, _mi, _fName, _suffix, _username, _usertype As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmUserEntry
            .tb_Gname.ReadOnly = False
            .tb_Mi.ReadOnly = False
            .tb_Surname.ReadOnly = False
            .tb_Suffix.ReadOnly = False
            .tb_Username.ReadOnly = False
            .btn_Update.Hide()
            .btn_Save.Show()
            .cbo_Branch.Items.Clear()
        End With
        user.loadBranch()
        frmUserEntry.ShowDialog()
    End Sub
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        user.loadRecord()
        cbo_Filter.SelectedIndex = 1
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        _id = DataGridView1.Item(0, i).Value
        _branch = DataGridView1.Item(2, i).Value
        _gName = DataGridView1.Item(3, i).Value
        _mi = DataGridView1.Item(4, i).Value
        _fName = DataGridView1.Item(5, i).Value
        _suffix = DataGridView1.Item(6, i).Value
        _username = DataGridView1.Item(7, i).Value
        _usertype = DataGridView1.Item(8, i).Value
        _is_actve = DataGridView1.Item(9, i).Value
        If _is_actve = False Then
            _is_actve = "No"
        ElseIf _is_actve = True Then
            _is_actve = "Yes"
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        frmUserEntry.cbo_Branch.Items.Clear()
        user.loadBranch()
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "col_Edit" Then
            With frmUserEntry
                .lbl_Id.Text = _id
                .tb_Gname.Text = _gName
                .tb_Mi.Text = _mi
                .tb_Surname.Text = _fName
                .tb_Suffix.Text = _suffix
                .tb_Username.Text = _username
                .tb_Password.Text = user.loadPassword(_username)
                .cbo_Branch.Text = _branch
                .cbo_Usertype.Text = _usertype
                .cbo_Active.Text = _is_actve
                .tb_Gname.ReadOnly = True
                .tb_Mi.ReadOnly = True
                .tb_Surname.ReadOnly = True
                .tb_Suffix.ReadOnly = True
                .tb_Username.ReadOnly = True
                .btn_Save.Hide()
                .btn_Update.Show()
                .tb_Password.Focus()
                .ShowDialog()
            End With

            'ElseIf colName = "col_Delete" Then
            '    Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            '    If result = vbYes Then
            '        user.Id = _id
            '        If user.checkBranchExists = False Then
            '            branch.delete()
            '            MsgBox("Record has been successfully deleted.", vbInformation)
            '            branch.loadRecord()
            '        Else
            '            MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
            '        End If
            '    End If

        End If
    End Sub
End Class