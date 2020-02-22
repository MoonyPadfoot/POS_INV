Public Class frmProfiling
    Private Sub btn_Item_Click(sender As Object, e As EventArgs) Handles btn_Item.Click
        With frmItem
            .TopLevel = False
            pnl_Mid.Controls.Add(frmItem)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_User_Click(sender As Object, e As EventArgs) Handles btn_User.Click
        With frmUser
            .TopLevel = False
            pnl_Mid.Controls.Add(frmUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Service_Click(sender As Object, e As EventArgs) Handles btn_Service.Click
        With frmServices
            .TopLevel = False
            pnl_Mid.Controls.Add(frmServices)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Branch_Click(sender As Object, e As EventArgs) Handles btn_Branch.Click
        With frmBranch
            .TopLevel = False
            pnl_Mid.Controls.Add(frmBranch)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Supplier_Click(sender As Object, e As EventArgs) Handles btn_Supplier.Click
        With frmSupplier
            .TopLevel = False
            pnl_Mid.Controls.Add(frmSupplier)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        With frmMain
            .btn_Pos.Enabled = True
            .btn_Inventory.Enabled = True
            .btn_Customer.Enabled = True
            .btn_sales_Report.Enabled = True
            .btn_Logout.Enabled = True
        End With
        Me.Close()
    End Sub
End Class