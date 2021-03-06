﻿Public Class frmCheckoutCred
    Dim order As New clsOrder
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Private Sub tb_cash_Tendered_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_cash_Tendered.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub
    Private Sub tb_cash_Tendered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cash_Tendered.KeyPress
        If tb_cash_Tendered.Text.Length > 7 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = Char.IsNumber(e.KeyChar) Or Not Char.IsNumber(e.KeyChar)
                Exit Sub
            End If
        End If
        ' Check for the flag being set in the KeyDown event.
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                tb_cash_Tendered.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_cash_Tendered.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_cash_Tendered.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_cash_Tendered.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_cash_Tendered.Select(tb_cash_Tendered.Text.Length, 0)

        End If
        e.Handled = True
    End Sub
    Private Sub tb_cash_Tendered_Leave(sender As Object, e As EventArgs) Handles tb_cash_Tendered.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        tb_Receipt.Clear()
        tb_cash_Tendered.Clear()
        tb_Change.Text = Format(0.00, "0.00")
        Me.Close()
    End Sub
    Private Sub frm_Checkout_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_cash_Tendered.Focus()
        tb_due_Total.Text = frmCreditPay.lbl_Balance.Text
        dtp_Date.Value = Date.Now
    End Sub
    Private Sub tb_cash_Tendered_TextChanged(sender As Object, e As EventArgs) Handles tb_cash_Tendered.TextChanged
        tb_Change.Text = Format(Math.Abs(Val(tb_cash_Tendered.Text) - Val(tb_due_Total.Text)), "0.00")

    End Sub

    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        If Val(tb_cash_Tendered.Text) = 0.00 Or tb_cash_Tendered.Text = vbNullString Then
            MsgBox("Please input a valid amount.", vbExclamation)
            Exit Sub
        End If
        If tb_Receipt.Text.Trim = vbNullString Then
            MsgBox("Please fill in receipt field.", vbExclamation)
            Exit Sub
        End If
        frmAuthenticate.lbl_Type.Text = 3
        frmAuthenticate.ShowDialog()

        tb_Receipt.Clear()
        tb_cash_Tendered.Clear()
        tb_Change.Text = Format(0.00, "0.00")
        frmCreditPay.dg_Transactions.Rows.Clear()
        frmCreditPay.tb_Name.Clear()
        frmCreditPay.lbl_customer_Id.Text = ""
        frmCreditPay.lbl_Balance.Text = Format(0.00, "0.00")
        Me.Close()
    End Sub
End Class