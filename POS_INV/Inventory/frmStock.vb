Imports MetroFramework.Forms
Public Class frmStock
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        frmStock_In.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmStock_In.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmStock_Transfer.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmStock_Out.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        frmSupplierEntry.ShowDialog()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs)
        frmBranchEntry.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

End Class