Public Class frmRefund
    Dim refund As New clsRefund
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        dg_Search.Rows.Clear()
        dg_Refund.Rows.Clear()
        tb_Search.Clear()
        cbo_Type.SelectedIndex = 0
        tb_receiptNo.Clear()
        cbo_Receipt.SelectedIndex = 0
        dtp_Date.Value = Date.Now
        Me.Close()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If dg_Search.RowCount = 0 Then
            MsgBox("No Item or Service has been selected", vbExclamation)
            Exit Sub
        End If

        If dg_Refund.RowCount <> 0 Then
            Dim iSearch As Integer = dg_Search.CurrentRow.Index 'sets the current selected row of dg_Search
            For i = 0 To dg_Refund.RowCount - 1
                Dim orderCode = dg_Refund.Rows(i).Cells(1).Value 'sets service Id or item Id of dg_Order and dg_Search
                Dim searchCode = dg_Search.Item(1, iSearch).Value

                If orderCode = searchCode Then                     'checks if item or service has already been added to list to prevent entry duplication
                    MsgBox("Item has already been added.", vbExclamation)
                    Exit Sub
                End If

            Next
        End If
        Dim a As Integer = dg_Search.CurrentRow.Index
        Dim _id = dg_Search.Item(0, a).Value
        Dim _code = dg_Search.Item(1, a).Value
        Dim _desc = dg_Search.Item(2, a).Value
        'Dim _qty = tb_Qty.Text
        'Dim _price = Val(tb_Price.Text)
        'Dim _total = dgs

        'frmPos.dg_Order.Rows.Add(_id, _code, _desc, Format(_price, "0.00"), _qty, Format(_total, "0.00"), "EDIT", "REMOVE")

        MsgBox("Item/Service has been added to cart.", vbInformation)
    End Sub

    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click
        frmAuthenticate.btn_Ok.Text = "Ok"
        frmAuthenticate.ShowDialog()
    End Sub

    Private Sub frmRefund_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_Receipt.SelectedIndex = 0
        cbo_Type.SelectedIndex = 0
        KeyPreview = True
    End Sub

    Private Sub frmRefund_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btn_Add_Click(sender, e)
            Case Keys.F2
                btn_New_Click(sender, e)
            Case Keys.F5
                btn_Confirm_Click(sender, e)
            Case Keys.Escape
                btn_Back_Click(sender, e)

        End Select
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click

    End Sub

    Private Sub tb_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_invoiceNo_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_receiptNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        refund.SetTransDate(dtp_Date.Value.ToString("yyyy-MM-dd"))

        If cbo_Receipt.SelectedIndex = 0 Then
            refund.SetReceiptNo(tb_receiptNo.Text.Trim)
            If refund.loadFromReceipt() = True Then
                GroupBox2.Enabled = True
                tb_Search.Focus()

            ElseIf refund.loadFromReceipt() = False Then
                GroupBox2.Enabled = False
                MsgBox("No record found!", vbExclamation)

            End If
        ElseIf cbo_Receipt.SelectedIndex = 1 Then
            refund.SetInvoiceNo(tb_receiptNo.Text.Trim)
            If refund.loadFromInvoice() = True Then
                GroupBox2.Enabled = True
                tb_Search.Focus()

            ElseIf refund.loadFromInvoice = False Then
                GroupBox2.Enabled = False
                MsgBox("No record found!", vbExclamation)

            End If
        End If
    End Sub

    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        refund.SetTransDate(dtp_Date.Value.ToString("yyyy-MM-dd"))
        refund.SetBranchId(frmPos.lbl_branch_Id.Text)
        If cbo_Receipt.SelectedIndex = 0 Then
            refund.SetReceiptNo(tb_receiptNo.Text.Trim)
            If Trim(tb_Search.Text) <> "" Then
                'assigns search text
                refund.SetItemSearch(Trim(tb_Search.Text))
                'search for item
                If cbo_Type.SelectedIndex = 0 Then
                    refund.searchItem("SELECT inventory.item_id, item_code, item_desc, item_add_desc, order_item_dtls.qty, order_item_dtls.price, order_item_dtls.line_total, brand.brand_name, category.category_name FROM orders " &
                                "INNER JOIN order_item_dtls ON order_item_dtls.order_id = orders.order_id " &
                                "INNER JOIN inventory ON inventory.inventory_id = order_item_dtls.inventory_id " &
                                "INNER JOIN item ON item.item_id = inventory.item_id " &
                                "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                "INNER JOIN category ON category.category_id = item.category_id " &
                                "INNER JOIN cash_payment ON cash_payment.order_id = orders.order_id " &
                                "WHERE (receipt = @receipt) AND (cash_payment.trans_date = @trans_date) AND (item_code LIKE @0 OR item_desc LIKE @0 OR item_add_desc LIKE @0 OR brand_name LIKE @0 OR category_name LIKE @0 OR " &
                                "CONCAT(brand_name, ' ', item_desc, ' ', item_add_desc, ' ', category_name) LIKE @0 )")
                    'search for services
                ElseIf cbo_Type.SelectedIndex = 1 Then
                    refund.searchService("SELECT service.service_id, service_desc, qty, price, line_total FROM orders " &
                                        "INNER JOIN order_svc_dtls ON order_svc_dtls.order_id = orders.order_id " &
                                        "INNER JOIN service ON service.service_id = order_svc_dtls.service_id " &
                                        "INNER JOIN cash_payment ON cash_payment.order_id = orders.order_id " &
                                        "WHERE service_desc LIKE @0 AND receipt = @receipt  AND cash_payment.trans_date = @trans_date ")
                End If
            Else
                'if text search is empty string 
                dg_Search.Rows.Clear()
            End If
        ElseIf cbo_Receipt.SelectedIndex = 1 Then
            refund.SetInvoiceNo(tb_receiptNo.Text.Trim)
            If Trim(tb_Search.Text) <> "" Then
                'assigns search text
                refund.SetItemSearch(Trim(tb_Search.Text))
                'search for item
                If cbo_Type.SelectedIndex = 0 Then
                    refund.searchItemInvoice("SELECT inventory.item_id, item_code, item_desc, item_add_desc, order_item_dtls.qty, order_item_dtls.price, order_item_dtls.line_total, brand.brand_name, category.category_name FROM orders
                                                INNER Join order_item_dtls ON order_item_dtls.order_id = orders.order_id
                                                INNER Join inventory ON inventory.inventory_id = order_item_dtls.inventory_id
                                                INNER Join item ON item.item_id = inventory.item_id
                                                INNER Join brand ON brand.brand_id = item.brand_id
                                                INNER Join category ON category.category_id = item.category_id
                                                INNER Join credit_payment ON credit_payment.order_id = orders.order_id
                                                WHERE(invoice = @invoice) AND (credit_payment.trans_date = @trans_date) AND (item_code LIKE @0 OR item_desc LIKE @0 OR item_add_desc LIKE @0 OR brand_name LIKE @0 OR category_name LIKE @0 OR 
                                                CONCAT(brand_name, ' ', item_desc, ' ', item_add_desc, ' ', category_name) LIKE @0 )")
                    'search for services
                ElseIf cbo_Type.SelectedIndex = 1 Then
                    refund.searchServiceInvoice("SELECT service.service_id, service_desc, qty, price, line_total FROM orders " &
                                        "INNER JOIN order_svc_dtls ON order_svc_dtls.order_id = orders.order_id " &
                                        "INNER JOIN service ON service.service_id = order_svc_dtls.service_id " &
                                        "INNER JOIN credit_payment ON credit_payment.order_id = orders.order_id " &
                                        "WHERE service_desc LIKE @0 AND invoice = @invoice AND credit_payment.trans_date = @trans_date ")
                End If
            Else
                'if text search is empty string 
                dg_Search.Rows.Clear()
            End If
        End If
    End Sub
End Class