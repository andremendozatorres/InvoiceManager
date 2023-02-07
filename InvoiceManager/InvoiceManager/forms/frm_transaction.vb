Public Class frm_transaction
    Dim returnid As Integer
    Private Sub btnSup_supSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup_supSearch.Click
        frm_suplier.Show()
        txt_suplierId.Clear()
        frm_suplier.btnadd.Visible = True
    End Sub

    Private Sub btnSup_itemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup_itemSearch.Click
        'frm_StockMaster.Show()
        'frm_StockMaster.btnadd.Visible = True
    End Sub

    Private Sub txtSup_itemid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSup_itemid.TextChanged
        Try

            sql = "SELECT * FROM tblitems WHERE ITEMID ='" & txtSup_itemid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtSup_itemName.Text = dt.Rows(0).Item("NAME")
                txtSup_description.Text = dt.Rows(0).Item("DESCRIPTION")
                txtSup_price.Text = dt.Rows(0).Item("PRICE")
            Else
                txtSup_itemName.Clear()
                txtSup_description.Clear()
                txtSup_price.Clear()
                txtSup_qty.Clear()
                txtSup_totprice.Clear()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `ITEMID` as 'Producto Id', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `QTY` as 'Cantidad Disponible' FROM `tblitems`"
        reloadDtg(sql, dtgCus_itemlist)

        sql = "SELECT ITEMID FROM tblitems"
        autocompletetxt(sql, txtSup_itemid)

        TabControl1.TabPages.Remove(TabPage1)

    End Sub

    Private Sub txt_suplierId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_suplierId.TextChanged
        Try

            sql = "SELECT * FROM tblperson WHERE ID ='" & txt_suplierId.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtSup_fname.Text = dt.Rows(0).Item("FIRSTNAME")
                txSup_lname.Text = dt.Rows(0).Item("LASTNAME")

            Else
                txtSup_fname.Clear()
                txSup_lname.Clear()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSup_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSup_qty.TextChanged
        Try
            txtSup_totprice.Text = txtSup_price.Text * txtSup_qty.Text
        Catch ex As Exception
            If txtSup_qty.Text <> "" Then
                MsgBox("Quantity must be a number", MsgBoxStyle.Exclamation)
                txtSup_qty.Text = ""
            Else
                txtSup_totprice.Text = 0.0
            End If

        End Try
    End Sub

    Private Sub btnSup_addtocart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup_addtocart.Click
        Try
            If txtSup_qty.Text <> "" Then

                If dtgSup_cartlist.RowCount = 0 Then
                    dtgSup_cartlist.ColumnCount = 6
                    dtgSup_cartlist.Columns(0).Name = "Producto Id"
                    dtgSup_cartlist.Columns(1).Name = "Nombre"
                    dtgSup_cartlist.Columns(2).Name = "Descripción"
                    dtgSup_cartlist.Columns(3).Name = "Precio"
                    dtgSup_cartlist.Columns(4).Name = "Cantidad"
                    dtgSup_cartlist.Columns(5).Name = "Precio Total"
                    Dim row As String() = New String() {txtSup_itemid.Text,
                                                        txtSup_itemName.Text,
                                                       txtSup_description.Text,
                                                       txtSup_price.Text,
                                                       txtSup_qty.Text,
                                                       txtSup_totprice.Text}
                    dtgSup_cartlist.Rows.Add(row)
                    cleartext(GroupBox2)
                    cleartext(GroupBox1)
                Else
                    If dtgSup_cartlist.CurrentRow.Cells(0).Value <> txtSup_itemid.Text Then
                        dtgSup_cartlist.ColumnCount = 6
                        dtgSup_cartlist.Columns(0).Name = "Producto Id"
                        dtgSup_cartlist.Columns(1).Name = "Nombre"
                        dtgSup_cartlist.Columns(2).Name = "Descripción"
                        dtgSup_cartlist.Columns(3).Name = "Precio"
                        dtgSup_cartlist.Columns(4).Name = "Cantidad"
                        dtgSup_cartlist.Columns(5).Name = "Precio Total"
                        Dim row As String() = New String() {txtSup_itemid.Text,
                                                            txtSup_itemName.Text,
                                                            txtSup_description.Text,
                                                            txtSup_price.Text,
                                                            txtSup_qty.Text,
                                                            txtSup_totprice.Text}
                        dtgSup_cartlist.Rows.Add(row)
                        cleartext(GroupBox2)
                        cleartext(GroupBox1)
                    Else
                        MsgBox("Item is already in the cart", MsgBoxStyle.Exclamation)
                    End If
                End If

            Else
                MsgBox("You must fill up all the fields.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSup_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup_edit.Click
        Try
            dtgSup_cartlist.Rows.Remove(dtgSup_cartlist.CurrentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub aa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aa.Click
        dtgSup_cartlist.Rows.Clear()
    End Sub

    Private Sub btnSup_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup_save.Click
        '-------------------------------------------------insert 
        sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" &
        " VALUES ('" & Format(Now, "yyyy-MM-dd") & "','StockIn','" & txt_suplierId.Text & "')"
        createNoMsg(sql)
        '-----------------------------------------------
        For Each r As DataGridViewRow In dtgSup_cartlist.Rows
            sql = "INSERT INTO `tblstock_in_out` ( `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`,REMARKS)" &
            " VALUES ((SELECT (TRANSACTIONNUMBER) FROM `tbltransaction` ORDER BY TRANSACTIONNUMBER DESC LIMIT 1),'" & r.Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','" & r.Cells(4).Value &
            "','" & r.Cells(5).Value & "','" & txt_suplierId.Text & "','StockIn')"
            createNoMsg(sql)
            '-----------------------------------------------update item
            sql = "UPDATE `tblitems`  SET `QTY`=`QTY` + '" & r.Cells(4).Value & "' WHERE ITEMID='" & r.Cells(0).Value & "'"
            createNoMsg(sql)
        Next
        '------------------------------------------------------------
        MsgBox("Item(s) has been save in the database.")
        '------------------------------------------------------------clearing
        cleartext(Panel4)
        cleartext(GroupBox2)
        cleartext(GroupBox1)
        dtgSup_cartlist.Rows.Clear()
    End Sub


    Private Sub txt_cusid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cusid.TextChanged
        Try
            sql = "SELECT * FROM `tblperson` WHERE `ID`='" & txt_cusid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtCus_fname.Text = dt.Rows(0).Item("FIRSTNAME")
                txtCus_lname.Text = dt.Rows(0).Item("LASTNAME")
            Else
                txtCus_fname.Clear()
                txtCus_lname.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT `ITEMID` as 'Producto Id', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `QTY` as 'Cantidad Disponible' FROM `tblitems` WHERE  `NAME` like '%" & txtsearch.Text & "%' or `ITEMID` = '" & txtsearch.Text & "'"
        reloadDtg(sql, dtgCus_itemlist)
    End Sub


    Private Sub btncus_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncus_search.Click
        frmview_customer.Show()
        ' frmview_customer.btnadd.Visible = True
    End Sub

    Private Sub btnCus_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_add.Click
        Try
            If dtCus_addedlist.RowCount = 0 Then
                With dtgCus_itemlist.CurrentRow
                    dtCus_addedlist.ColumnCount = 6
                    dtCus_addedlist.Columns(0).Name = "Producto Id"
                    dtCus_addedlist.Columns(1).Name = "Nombre"
                    dtCus_addedlist.Columns(2).Name = "Descripción"
                    dtCus_addedlist.Columns(3).Name = "Precio"
                    dtCus_addedlist.Columns(4).Name = "Cantidad"
                    dtCus_addedlist.Columns(5).Name = "Precio Total"

                    Dim tot As Double = Double.Parse(.Cells(3).Value) * 1

                    Dim row As String() = New String() { .Cells(0).Value,
                                                    .Cells(1).Value,
                                                   .Cells(2).Value,
                                                   .Cells(3).Value,
                                                   1,
                                                   tot}
                    dtCus_addedlist.Rows.Add(row)

                End With
            Else
                For Each r As DataGridViewRow In dtCus_addedlist.Rows
                    If dtgCus_itemlist.CurrentRow.Cells(0).Value = r.Cells(0).Value Then
                        MsgBox("Producto ya está en el carrito", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                Next
                If dtCus_addedlist.CurrentRow.Cells(0).Value <> dtgCus_itemlist.CurrentRow.Cells(0).Value Then
                    With dtgCus_itemlist.CurrentRow
                        dtCus_addedlist.ColumnCount = 6
                        dtCus_addedlist.Columns(0).Name = "Producto Id"
                        dtCus_addedlist.Columns(1).Name = "Nombre"
                        dtCus_addedlist.Columns(2).Name = "Descripción"
                        dtCus_addedlist.Columns(3).Name = "Precio"
                        dtCus_addedlist.Columns(4).Name = "Cantidad"
                        dtCus_addedlist.Columns(5).Name = "Precio Total"
                        Dim tot As Double = Double.Parse(.Cells(3).Value) * 1
                        Dim row As String() = New String() { .Cells(0).Value,
                                                        .Cells(1).Value,
                                                        .Cells(2).Value,
                                                       .Cells(3).Value,
                                                      1,
                                                       tot}
                        dtCus_addedlist.Rows.Add(row)

                    End With


                Else
                    MsgBox("Producto ya está en el carrito", MsgBoxStyle.Exclamation)
                End If
            End If

            Dim final_total As Double
            For Each r As DataGridViewRow In dtCus_addedlist.Rows
                final_total += r.Cells(5).Value
            Next
            Label4.Text = "Total : Q." & final_total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCus_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_Remove.Click
        Try
            dtCus_addedlist.Rows.Remove(dtCus_addedlist.CurrentRow)
            Dim final_total As Double
            For Each r As DataGridViewRow In dtCus_addedlist.Rows
                final_total += r.Cells(5).Value
            Next
            Label4.Text = "Total : Q." & final_total
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCus_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_clear.Click
        dtCus_addedlist.Rows.Clear()
    End Sub

    Private Sub btnCus_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCus_save.Click
        If txt_cusid.Text = "" Then
            MsgBox("Rellenar todos los campos", MsgBoxStyle.Exclamation)
            Return
        End If

        If dtCus_addedlist.RowCount = 0 Then
            MsgBox("El carrito está vacío", MsgBoxStyle.Exclamation)
            Return
        End If
        sql = "SELECT ITEMID,`QTY` FROM `tblitems`"
        reloadtxt(sql)
        For Each row As DataRow In dt.Rows
            For i As Integer = 0 To dtCus_addedlist.Rows.Count - 1
                If dtCus_addedlist.Rows(i).Cells(0).Value = row.Item(0) Then
                    'MsgBox(row.Item(0))
                    If dtCus_addedlist.Rows(i).Cells(4).Value > row.Item(1) Then
                        MsgBox("La cantidad del producto ( " & dtCus_addedlist.Rows(i).Cells(1).Value & " ) es mayor que la cantidad disponible.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                End If
                'If dtCus_addedlist.Rows(i).Cells(4).Value = "" Then
                '    MsgBox("Set your purpose.", MsgBoxStyle.Exclamation)
                '    Return
                'End If
            Next
        Next

        '----------------------------------------------transaction
        sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" &
       " VALUES ('" & Format(Now, "yyyy-MM-dd") & "','StockOut','" & txt_cusid.Text & "')"
        createNoMsg(sql)
        '-----------------------------------------------
        For Each r As DataGridViewRow In dtCus_addedlist.Rows
            sql = "INSERT INTO `tblstock_in_out` ( `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`,REMARKS)" &
            " VALUES ((SELECT (TRANSACTIONNUMBER) FROM `tbltransaction` ORDER BY TRANSACTIONNUMBER DESC LIMIT 1),'" & r.Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','" & r.Cells(4).Value &
            "','" & r.Cells(5).Value & "','" & txt_cusid.Text & "','StockOut')"
            createNoMsg(sql)
            '-----------------------------------------------update item
            sql = "UPDATE `tblitems`  SET `QTY`= QTY - '" & r.Cells(4).Value & "' WHERE ITEMID='" & r.Cells(0).Value & "'"
            createNoMsg(sql)
        Next
        '------------------------------------------------------------
        MsgBox("Los productos se han guardado en la base de datos")
        '------------------------------------------------------------clearing
        cleartext(Panel1)
        dtCus_addedlist.Rows.Clear()
        ' dtgreturn_itemlist.Rows.Clear()
        '----------------------------------------------------------------
        sql = "SELECT `ITEMID` as 'Producto Id', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `QTY` as 'Cantidad Disponible' FROM `tblitems`"
        reloadDtg(sql, dtgCus_itemlist)
    End Sub

    Private Sub txttransactionid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttransactionid.TextChanged
        Try

            If txttransactionid.Text <> "" Then

                sql = "SELECT p.ID, `FIRSTNAME`, `LASTNAME` ,`ADDRESS` FROM  `tbltransaction` t, `tblperson`  p  WHERE t.`SUPLIERCUSTOMERID`=p.`ID` AND `TRANSACTIONNUMBER`='" & txttransactionid.Text & "'"
                reloadtxt(sql)
                returnid = dt.Rows(0).Item("ID")
                txtreturn_name.Text = dt.Rows(0).Item("FIRSTNAME") & " " & dt.Rows(0).Item("LASTNAME")
                txtreturn_address.Text = dt.Rows(0).Item("ADDRESS")

                sql = "SELECT   i.`ITEMID` as 'Producto Id', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `TRANSACTIONDATE` as 'Fecha', o.`QTY` as 'Cantidad', `TOTALPRICE` as 'Precio Total',`STOCKOUTID` as 'Id del Producto en Transacción' FROM  `tblitems` i , `tblstock_in_out` o WHERE i.`ITEMID`=o.`ITEMID` AND `TRANSACTIONNUMBER`='" & txttransactionid.Text & "'"
                reloadDtg(sql, dtgreturn_itemlist)
                dtgreturn_itemlist.Columns(7).Visible = False
            Else
                txtreturn_name.Clear()
                txtreturn_address.Clear()
                dtgreturn_itemlist.Columns.Clear()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreturnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoverride.Click
        Try


            sql = "UPDATE `tbltransaction`  SET `STATE`= 'Anulada' WHERE TRANSACTIONNUMBER = '" & txttransactionid.Text & "'"
            createNoMsg(sql)
            MsgBox("La factura ha sido anulada.")


        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnreturn_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_remove.Click
        Try
            dtgreturn_cart.Rows.Remove(dtgreturn_cart.CurrentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreturn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_clear.Click
        dtgreturn_cart.Columns.Clear()
    End Sub

    Private Sub btnreturn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_save.Click
        If txttransactionid.Text = "" Then
            MsgBox("Rellenar todos los campos", MsgBoxStyle.Exclamation)
            Return
        End If

        If dtgreturn_cart.RowCount = 0 Then
            MsgBox("El carrito está vacío", MsgBoxStyle.Exclamation)
            Return
        End If
        sql = "SELECT `ITEMID`, `QTY` FROM `tblstock_in_out` WHERE  `TRANSACTIONNUMBER` ='" & txttransactionid.Text & "'"
        reloadtxt(sql)
        For Each row As DataRow In dt.Rows
            For i As Integer = 0 To dtgreturn_cart.Rows.Count - 1
                If dtgreturn_cart.Rows(i).Cells(0).Value = row.Item(0) Then
                    'MsgBox(row.Item(0))
                    If dtgreturn_cart.Rows(i).Cells(4).Value > row.Item(1) Then
                        MsgBox("La cantidad del producto ( " & dtgreturn_cart.Rows(i).Cells(1).Value & " ) es mayor que la cantidad disponible.", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                End If
                'If dtCus_addedlist.Rows(i).Cells(4).Value = "" Then
                '    MsgBox("Set your purpose.", MsgBoxStyle.Exclamation)
                '    Return
                'End If
            Next
        Next



        '--------------------------------------------------
        sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" &
                " VALUES ('" & Format(Now, "yyyy-MM-dd") & "','Returned','" & returnid & "')"
        createNoMsg(sql)
        '-------------------------------------------------------------
        For Each r As DataGridViewRow In dtgreturn_cart.Rows
            sql = "INSERT INTO `tblstock_return` (  `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `QTY`, `TOTALPRICE`, `OWNER_CUS_ID`)" &
            " VALUES ((SELECT (TRANSACTIONNUMBER) FROM `tbltransaction` ORDER BY TRANSACTIONNUMBER DESC LIMIT 1),'" & r.Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','" & r.Cells(4).Value &
            "','" & r.Cells(5).Value & "','" & returnid & "')"
            createNoMsg(sql)
            '-----------------------------------------------update item
            sql = "UPDATE `tblitems`  SET `QTY`=`QTY` + '" & r.Cells(4).Value & "' WHERE ITEMID='" & r.Cells(0).Value & "'"
            createNoMsg(sql)

            sql = "UPDATE `tblstock_in_out` SET  `QTY`=`QTY`-'" & r.Cells(4).Value & "', `TOTALPRICE`=`TOTALPRICE`-'" & r.Cells(5).Value & "'  WHERE `STOCKOUTID` ='" & r.Cells(6).Value & "'"
            createNoMsg(sql)

        Next
        '-------------------------------------------------------------
        MsgBox("El producto ha sido devuelto.")
        '------------------------------------------------------------clearing
        cleartext(Panel6)
        dtgreturn_cart.Columns.Clear()
    End Sub

    Private Sub btnreturn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn_Search.Click
        frm_viewTransaction.Show()
        frm_viewTransaction.Focus()

    End Sub
    Private Sub btnStaockin_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStaockin_list.Click
        frmview_stockin.Show()
        frmview_stockin.Focus()
    End Sub


    Private Sub btnviewStockout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewStockout.Click
        frmview_stockout.Show()
        frmview_stockout.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvewlreturn.Click
        frmview_return.Show()
        frmview_return.Focus()
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        Try
            '----------------------------------------------------------------
            sql = "SELECT `ITEMID` as 'Producto Id', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `QTY` as 'Cantidad Disponible' FROM `tblitems`"
            reloadDtg(sql, dtgCus_itemlist)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub dtCus_addedlist_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dtCus_addedlist.CellBeginEdit
        Try
            Dim total As Double
            For Each row As DataGridViewRow In dtCus_addedlist.Rows
                total = row.Cells(4).Value * row.Cells(3).Value
                row.Cells(5).Value = total
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtCus_addedlist_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtCus_addedlist.CellContentClick

    End Sub

    Private Sub dtCus_addedlist_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtCus_addedlist.CellLeave

    End Sub

    Private Sub dtCus_addedlist_CellMouseLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtCus_addedlist.CellMouseLeave
        Try
            If dtCus_addedlist.Rows.Count > 0 Then
                If dtCus_addedlist.CurrentCell.ColumnIndex = 4 Then
                    Dim total As Double
                    For Each row As DataGridViewRow In dtCus_addedlist.Rows
                        total = row.Cells(4).Value * row.Cells(3).Value
                        row.Cells(5).Value = total
                    Next
                End If
            End If

            Dim final_total As Double
            For Each r As DataGridViewRow In dtCus_addedlist.Rows
                final_total += r.Cells(5).Value
            Next
            Label4.Text = "Total : Q." & final_total

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtCus_addedlist_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtCus_addedlist.CellValueChanged
        Try
            If dtCus_addedlist.CurrentCell.ColumnIndex = 4 Then
                Dim total As Double
                For Each row As DataGridViewRow In dtCus_addedlist.Rows
                    total = row.Cells(4).Value * row.Cells(3).Value
                    row.Cells(5).Value = total
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgreturn_cart_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgreturn_cart.CellValueChanged
        Try
            If dtgreturn_cart.CurrentCell.ColumnIndex = 4 Then
                Dim total As Double
                For Each row As DataGridViewRow In dtgreturn_cart.Rows
                    total = row.Cells(4).Value * row.Cells(3).Value
                    row.Cells(5).Value = total
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class