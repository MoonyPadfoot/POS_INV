Public Class frmMain
    Dim login As New clsLogin
    Private Sub btn_Pos_Click(sender As Object, e As EventArgs) Handles btn_Pos.Click
        KeyPreview = False
        btn_Pos.BackColor = Color.FromArgb(236, 240, 241)
        btn_Profile.BackColor = Color.FromArgb(149, 165, 166)
        btn_Inventory.BackColor = Color.FromArgb(149, 165, 166)
        btn_Customer.BackColor = Color.FromArgb(149, 165, 166)
        btn_sales_Report.BackColor = Color.FromArgb(149, 165, 166)
        btn_Help.BackColor = Color.FromArgb(149, 165, 166)
        frmLoginPos.ShowDialog()
    End Sub

    Private Sub btn_sales_Report_Click(sender As Object, e As EventArgs) Handles btn_sales_Report.Click
        btn_Pos.BackColor = Color.FromArgb(149, 165, 166)
        btn_Profile.BackColor = Color.FromArgb(149, 165, 166)
        btn_Inventory.BackColor = Color.FromArgb(149, 165, 166)
        btn_Customer.BackColor = Color.FromArgb(149, 165, 166)
        btn_sales_Report.BackColor = Color.FromArgb(236, 240, 241)
        btn_Help.BackColor = Color.FromArgb(149, 165, 166)
    End Sub

    Private Sub btn_Customer_Click(sender As Object, e As EventArgs) Handles btn_Customer.Click
        KeyPreview = False
        btn_Pos.BackColor = Color.FromArgb(149, 165, 166)
        btn_Profile.BackColor = Color.FromArgb(149, 165, 166)
        btn_Inventory.BackColor = Color.FromArgb(149, 165, 166)
        btn_Customer.BackColor = Color.FromArgb(236, 240, 241)
        btn_sales_Report.BackColor = Color.FromArgb(149, 165, 166)
        btn_Help.BackColor = Color.FromArgb(149, 165, 166)
        With frmCustomers
            .TopLevel = False
            pnlMid.Controls.Add(frmCustomers)
            .BringToFront()
            .Show()
        End With
        With Me
            .btn_Pos.Enabled = False
            .btn_Inventory.Enabled = False
            .btn_Profile.Enabled = False
            .btn_sales_Report.Enabled = False
            .btn_Logout.Enabled = False
        End With

    End Sub

    Private Sub btn_Inventory_Click(sender As Object, e As EventArgs) Handles btn_Inventory.Click
        KeyPreview = False
        btn_Pos.BackColor = Color.FromArgb(149, 165, 166)
        btn_Profile.BackColor = Color.FromArgb(149, 165, 166)
        btn_Inventory.BackColor = Color.FromArgb(236, 240, 241)
        btn_Customer.BackColor = Color.FromArgb(149, 165, 166)
        btn_sales_Report.BackColor = Color.FromArgb(149, 165, 166)
        btn_Help.BackColor = Color.FromArgb(149, 165, 166)
        With frmStock
            .TopLevel = False
            pnlMid.Controls.Add(frmStock)
            .BringToFront()
            .Show()
        End With
        btn_Logout.Enabled = False
        btn_Customer.Enabled = False
        btn_Pos.Enabled = False
        btn_sales_Report.Enabled = False
        'MsgBox("Critical Items: 2", vbInformation)
    End Sub

    Private Sub btn_Profile_Click(sender As Object, e As EventArgs) Handles btn_Profile.Click
        KeyPreview = False
        btn_Pos.BackColor = Color.FromArgb(149, 165, 166)
        btn_Profile.BackColor = Color.FromArgb(236, 240, 241)
        btn_Inventory.BackColor = Color.FromArgb(149, 165, 166)
        btn_Customer.BackColor = Color.FromArgb(149, 165, 166)
        btn_sales_Report.BackColor = Color.FromArgb(149, 165, 166)
        btn_Help.BackColor = Color.FromArgb(149, 165, 166)
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
        KeyPreview = False
        If MsgBox("Are you sure you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            lbl_Name.Text = vbNullString
            lbl_Type.Text = vbNullString
            login.SetUsername(lbl_Username.Text)
            lbl_Username.Text = vbNullString
            lbl_branch_Id.Text = vbNullString
            login.setUserLogin(0)
            Me.Close()
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        If lbl_Type.Text = "Admin" Then
            btn_Pos.Enabled = False
            btn_Inventory.Enabled = False
            btn_Customer.Enabled = False
            btn_sales_Report.Enabled = False
        ElseIf lbl_Type.Text = "Manager" Then
            btn_Profile.Enabled = False
        ElseIf lbl_Type.Text = "Cashier" Then
            btn_Profile.Enabled = False
            btn_Inventory.Enabled = False
            btn_Customer.Enabled = False
            btn_sales_Report.Enabled = False
        End If
        KeyPreview = True
    End Sub
    Private Sub btn_Help_Click(sender As Object, e As EventArgs) Handles btn_Help.Click

    End Sub
    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If lbl_Type.Text = "Admin" Then
            Select Case e.KeyCode
                Case Keys.F2
                    btn_Profile_Click(sender, e)
                Case Keys.F6
                    btn_Help_Click(sender, e)
                Case Keys.Escape
                    btn_Logout_Click(sender, e)

            End Select
        ElseIf lbl_Type.Text = "Manager" Then
            Select Case e.KeyCode
                Case Keys.F1
                    btn_Pos_Click(sender, e)
                Case Keys.F3
                    btn_Inventory_Click(sender, e)
                Case Keys.F4
                    btn_Customer_Click(sender, e)
                Case Keys.F5
                    btn_sales_Report_Click(sender, e)
                Case Keys.F6
                    btn_Help_Click(sender, e)
                Case Keys.Escape
                    btn_Logout_Click(sender, e)

            End Select
        ElseIf lbl_Type.Text = "Cashier" Then
            Select Case e.KeyCode
                Case Keys.F1
                    btn_Pos_Click(sender, e)
                Case Keys.F6
                    btn_Help_Click(sender, e)
                Case Keys.Escape
                    btn_Logout_Click(sender, e)

            End Select
        End If

    End Sub


End Class
