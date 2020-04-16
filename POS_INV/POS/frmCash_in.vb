﻿Public Class frmCash_in
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Private Sub tb_Amount_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Amount.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub
    Private Sub tb_Amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Amount.KeyPress
        If tb_Amount.Text.Length > 7 Then
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
                tb_Amount.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_Amount.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_Amount.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_Amount.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_Amount.Select(tb_Amount.Text.Length, 0)

        End If
        e.Handled = True
    End Sub
    Private Sub tb_Amount_Leave(sender As Object, e As EventArgs) Handles tb_Amount.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Go_Click(sender As Object, e As EventArgs) Handles btn_Go.Click
        If tb_Amount.Text = "" Then
            MsgBox("Please input a valid amount.", vbExclamation)
            Exit Sub
        End If
        frmAuthenticate.lbl_Type.Text = 2
        frmAuthenticate.ShowDialog()
        MsgBox("Transaction saved.", vbInformation)
        Me.Close()
    End Sub

    Private Sub frmCash_in_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_Amount.Focus()
    End Sub
End Class