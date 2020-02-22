Public Class frmUserEntry
    Dim user As New clsUser
    Dim frmUser As New frmUser
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearControls()
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If countEmpty() > 0 Then
            MsgBox("Please fill in the field(s) before saving.", vbExclamation)
            Exit Sub
        End If
        Try
            user.GName = Trim(Me.tb_Gname.Text)
            user.Mi = Trim(Me.tb_Mi.Text)
            user.Surname = Trim(Me.tb_Surname.Text)
            user.Suffix = Trim(Me.tb_Suffix.Text)
            user.BranchId = CInt(lbl_branch_Id.Text)
            user.Username = Me.tb_Username.Text
            user.Password = Me.tb_Password.Text
            user.UserType = Me.cbo_Usertype.Text
            user.Branch = Me.lbl_branch_Id.Text
            If cbo_Active.Text = "Yes" Then
                user.Active = 1
            ElseIf cbo_Active.Text = "No" Then
                user.Active = 0
            End If
            Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
            If user.checkUserDuplicate = True Then
                MsgBox("Username is already existing.", vbInformation)
                Exit Sub
            End If
            If result = vbYes Then
                If user.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    clearControls()
                    frmUser.tb_Search.Text = vbNullString
                    user.loadRecord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Try
            Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)
            user.Id = CInt(Me.lbl_Id.Text)
            user.UserType = Me.cbo_Usertype.Text
            user.BranchId = CInt(lbl_branch_Id.Text)
            user.Password = Me.tb_Password.Text
            If cbo_Active.Text = "Yes" Then
                user.Active = 1
            ElseIf cbo_Active.Text = "No" Then
                user.Active = 0
            End If
            If result = vbYes Then
                If user.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    frmBranch.tb_Search.Clear()
                    user.loadRecord()
                End If
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clearControls()
        For Each cntrl As Control In GroupBox1.Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.Text = vbNullString
            End If
        Next
        For Each cntrl As Control In GroupBox2.Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.Text = vbNullString
            End If
            If TypeOf cntrl Is ComboBox Then
                cntrl.Text = vbNullString
            End If
        Next
    End Sub

    Private Sub frmUserEntry_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub cbo_Branch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Branch.SelectedIndexChanged
        user.Branch = Me.cbo_Branch.Text
        user.loadBranchId()
    End Sub

    Private Function countEmpty()
        Dim count = 0
        For Each cntrl As Control In GroupBox1.Controls
            If TypeOf cntrl Is TextBox Then
                If cntrl.Name <> "tb_Mi" And cntrl.Name <> "tb_Suffix" Then
                    If Trim(cntrl.Text) = vbNullString Then
                        count += 1
                    End If
                End If
            End If
        Next
        For Each cntrl As Control In GroupBox2.Controls
            If TypeOf cntrl Is TextBox Then
                If Trim(cntrl.Text) = vbNullString Then
                    count += 1
                End If
            End If
            If TypeOf cntrl Is ComboBox Then
                If Trim(cntrl.Text) = vbNullString Then
                    count += 1
                End If
            End If
        Next
        Return count
    End Function

    Private Sub cb_show_Password_CheckedChanged(sender As Object, e As EventArgs) Handles cb_show_Password.CheckedChanged
        If cb_show_Password.Checked = True Then
            tb_Password.PasswordChar = ""
        ElseIf cb_show_Password.Checked = False Then
            tb_Password.PasswordChar = "*"
        End If
    End Sub
End Class