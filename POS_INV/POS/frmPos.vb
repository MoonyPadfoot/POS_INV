﻿Public Class frmPos
    Private Sub frmPos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim obj_Table As New frmPosTable
        'With obj_Table
        '    .TopLevel = False
        '    pnlBody.Controls.Add(obj_Table)
        '    .BringToFront()
        '    .Show()
        'End With

        'Dim obj_Button As New frmPosButtons
        'With obj_Button
        '    .TopLevel = False
        '    pnlRight.Controls.Add(obj_Button)
        '    .BringToFront()
        '    .Show()
        'End With
        _authLogin = 2
    End Sub
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        frmQty.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Checkout.Click
        frm_Checkout.ShowDialog()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        Dim ans = MsgBox("The Current Transaction will be Canceled, Do You Wish to Continue?", vbExclamation + vbYesNo + vbDefaultButton2, "Warning!")
        If ans = vbYes Then
            frmNewTransaction.ShowDialog()
        End If

    End Sub

    Private Sub btn_Advance_Srch_Click(sender As Object, e As EventArgs) Handles btn_Advance_Srch.Click
        frmAdvanceSearch.ShowDialog()
    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        frmMain.Show()
        Me.Close()
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