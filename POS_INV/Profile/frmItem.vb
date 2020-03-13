Public Class frmItem
    Dim item As New clsItem
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim colName = dgCategory.Columns(e.ColumnIndex).Name
        If colName = "Column4" Then
            With frmBrandCat
                .lblBrand.Hide()
                .lblCategory.Show()
                .btnUpdate.Visible = True
                .btnSave.Hide()
                .btnUpdate.Show()
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        frmItemEntry.btn_Update.Enabled = False
        frmItemEntry.btn_Save.Enabled = False
        frmItemEntry.ShowDialog()
    End Sub

    Private Sub btn_new_Category_Click(sender As Object, e As EventArgs) Handles btn_new_Category.Click
        With frmBrandCat
            .lblBrand.Hide()
            .lblCategory.Show()
            .btnSave.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_new_Brand_Click(sender As Object, e As EventArgs) Handles btn_new_Brand.Click
        With frmBrandCat
            .lblBrand.Show()
            .lblCategory.Hide()
            .btnSave.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub frmItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        item.loadRecord()
    End Sub
End Class