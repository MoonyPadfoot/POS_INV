Public Class frmPos
    Dim loginPos As New clsLoginPos
    Dim order As New clsOrder
    Private Sub frmPos_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_transac_Date.Text = Date.Now.ToString("MM/dd/yyy")
        frmNewTransaction.btn_Close.Visible = False
        order.loadAutosuggestItems(lbl_branch_Id.Text)
        cbo_Desc.Focus()

    End Sub
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        frmQty.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Checkout.Click
        frm_Checkout.ShowDialog()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        frmNewTransaction.btn_Close.Visible = True
        Dim ans = MsgBox("The Current Transaction will be Canceled, Do You Wish to Continue?", vbQuestion + vbYesNo, "Warning!")
        If ans = vbYes Then
            frmNewTransaction.ShowDialog()
        End If

    End Sub

    Private Sub btn_Advance_Srch_Click(sender As Object, e As EventArgs) Handles btn_Advance_Srch.Click
        frmAdvanceSearch.ShowDialog()
    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        If MsgBox("Do you wish to logout?", vbQuestion + vbYesNo) = vbYes Then
            loginPos.SetUsername(lbl_Username.Text)
            loginPos.setUserLogin(0)
            frmMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_CashIn_Click(sender As Object, e As EventArgs) Handles btn_CashIn.Click
        With frmCash_in
            .lbl_cash_In.Show()
            .lbl_cash_Out.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_CashOut_Click(sender As Object, e As EventArgs) Handles btn_CashOut.Click
        With frmCash_in
            .lbl_cash_Out.Show()
            .lbl_cash_In.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_Refund_Click(sender As Object, e As EventArgs) Handles btn_Refund.Click
        frmRefund.ShowDialog()
    End Sub

    Private Sub btn_Balance_Click(sender As Object, e As EventArgs) Handles btn_Balance.Click
        frmCreditPay.ShowDialog()
    End Sub
End Class