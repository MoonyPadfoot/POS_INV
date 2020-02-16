Public Class frmBranchEntry
    Dim branch As New clsBranch
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim result = MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion)
        Try
            If result = vbYes Then
                branch.BranchName = Me.tb_Address.Text
                If branch.save = True Then
                    MsgBox("Record has been successfully saved.", vbInformation)
                    tb_Address.Clear()
                    tb_Address.Focus()
                    branch.loadRecord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim result = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion)
        Try
            If result = vbYes Then
                branch.BranchId = Me.lbl_Id.Text
                branch.BranchName = Me.tb_Address.Text
                If branch.edit = True Then
                    MsgBox("Record has been successfully updated.", vbInformation)
                    branch.loadRecord()
                End If
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class