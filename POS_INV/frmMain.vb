Public Class frmMain
    Private Sub btnItem_Click(sender As Object, e As EventArgs)
        With frmItem
            .TopLevel = False
            pnlBody.Controls.Add(frmItem)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs)
        With frmServices
            .TopLevel = False
            pnlBody.Controls.Add(frmServices)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnPos_Click(sender As Object, e As EventArgs) Handles btn_Pos.Click
        _authLogin = "Pos"
        frmLogin.ShowDialog()
    End Sub

    Private Sub btn_User_Click(sender As Object, e As EventArgs)
        With frmUser
            .TopLevel = False
            pnlMid.Controls.Add(frmUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_sales_Report_Click(sender As Object, e As EventArgs) Handles btn_sales_Report.Click
    End Sub

    Private Sub btn_Customer_Click(sender As Object, e As EventArgs) Handles btn_Customer.Click
        With frmCustomers
            .TopLevel = False
            pnlMid.Controls.Add(frmCustomers)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Inventory_Click(sender As Object, e As EventArgs) Handles btn_Inventory.Click
        With frmStock
            .TopLevel = False
            pnlMid.Controls.Add(frmStock)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_Profile_Click(sender As Object, e As EventArgs) Handles btn_Profile.Click
        With frmProfiling
            .TopLevel = False
            pnlMid.Controls.Add(frmProfiling)
            .BringToFront()
            .Show()
        End With
        With Me
            .btn_Pos.Enabled = False
            .btn_Inventory.Enabled = False
            .btn_Customer.Enabled = False
            .btn_sales_Report.Enabled = False
            .btn_Logout.Enabled = False
        End With
    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        _authLogin = "Login"
        frmLogin.Show()
        Me.Close()
    End Sub
End Class
