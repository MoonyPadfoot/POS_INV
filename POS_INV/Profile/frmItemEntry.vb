Public Class frmItemEntry
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Dim item As New clsItem
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        clearControls()
        Me.Close()
    End Sub

    Private Sub tb_unit_Price_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_unit_Price.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub tb_unit_Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_unit_Price.KeyPress
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
                tb_unit_Price.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_unit_Price.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_unit_Price.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_unit_Price.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_unit_Price.Select(tb_Category.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub tb_price_A_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_price_A.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub tb_price_A_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_price_A.KeyPress
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
                tb_price_A.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_price_A.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_price_A.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_price_A.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_price_A.Select(tb_price_A.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub tb_price_B_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_price_B.KeyDown

        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub tb_price_B_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_price_B.KeyPress
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
                tb_price_B.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_price_B.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_price_B.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_price_B.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_price_B.Select(tb_price_B.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub tb_unit_Price_Leave(sender As Object, e As EventArgs) Handles tb_unit_Price.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub tb_price_A_Leave(sender As Object, e As EventArgs) Handles tb_price_A.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub tb_price_B_Leave(sender As Object, e As EventArgs) Handles tb_price_B.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If countEmpty() = True Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        Try
            item.SetCode(Trim(tb_Code.Text))
            item.SetDesc(Trim(tb_Desc.Text))
            item.SetAddDesc(Trim(tb_add_Desc.Text))
            item.SetBrand(Trim(tb_Brand.Text))
            item.SetCategory(Trim(tb_Category.Text))
            item.SetUnitPrice(Trim(tb_unit_Price.Text))
            item.SetPriceA(Trim(tb_price_A.Text))
            item.SetPriceB(Trim(tb_price_B.Text))
            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            If item.checkUserDuplicate = True Then
                MsgBox("Username is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                If item.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    clearControls()
                    frmItem.tb_Search.Text = vbNullString
                    item.loadRecord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clearControls()
        For Each cntrl As Control In Me.Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.Text = vbNullString
            End If
        Next
    End Sub
    Private Function countEmpty()
        If tb_Code.Text = vbNullString Then
            tb_Code.Focus()
            Return True
        ElseIf tb_Desc.Text = vbNullString Then
            tb_Desc.Focus()
            Return True
        ElseIf tb_add_Desc.Text = vbNullString Then
            tb_add_Desc.Focus()
            Return True
        ElseIf tb_Brand.Text = vbNullString Then
            tb_Brand.Focus()
            Return True
        ElseIf tb_Category.Text = vbNullString Then
            tb_Category.Focus()
            Return True
        ElseIf tb_unit_Price.Text = vbNullString Then
            tb_unit_Price.Focus()
            Return True
        ElseIf tb_price_A.Text = vbNullString Then
            tb_price_A.Focus()
            Return True
        ElseIf tb_price_B.Text = vbNullString Then
            tb_price_B.Focus()
            Return True
        End If
        Return False
    End Function
End Class