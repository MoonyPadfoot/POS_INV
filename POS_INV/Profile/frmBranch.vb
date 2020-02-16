Public Class frmBranch
    Dim branch As New clsBranch
    Dim _id, _branch As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        With frmBranchEntry
            .btn_Save.Show()
            .btn_Update.Hide()
            .tb_Address.Clear()
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        _id = DataGridView1.Item(0, i).Value
        _branch = DataGridView1.Item(2, i).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "col_Edit" Then
            With frmBranchEntry
                .lbl_Id.Text = _id
                .tb_Address.Text = _branch
                .btn_Save.Hide()
                .btn_Update.Show()
                .tb_Address.Focus()
                .ShowDialog()
            End With
        ElseIf colName = "col_Delete" Then
            Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                branch.BranchId = _id
                branch.delete()
                branch.loadRecord()
            End If
        End If
    End Sub
    Private Sub frmBranch_Load(sender As Object, e As EventArgs) Handles Me.Load
        branch.loadRecord()
        branch.loadAutosuggest()
    End Sub

    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            branch.BranchSearch = Trim(tb_Search.Text)
            branch.searchItem("SELECT * FROM branch WHERE branch_address LIKE @0 ")
        Else
            branch.loadRecord()
        End If
    End Sub
End Class