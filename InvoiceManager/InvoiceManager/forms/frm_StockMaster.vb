Imports System.Security.Cryptography

Public Class frm_StockMaster
    Dim itemid As Integer
    Dim maxcolumn As Integer
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        For Each obj As Control In pnl_stockmaster.Controls
            If TypeOf obj Is TextBox Then
                If obj.Text = "" Then
                    MsgBox("No se puede realizar ninguna acción. Todos los campos son obligatorios.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
            If TypeOf obj Is ComboBox Then
                If obj.Text = "----Select-----" Or obj.Text = "" Then
                    MsgBox("No se puede realizar ninguna acción. Todos los campos son obligatorios.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        Next


        sql = "SELECT ITEMID FROM tblitems WHERE ITEMID='" & txtitemid.Text & "'"
        reloadtxt(sql)
        If dt.Rows.Count = 0 Then

            sql = "INSERT INTO tblitems (`ITEMID`,`NAME`,`DESCRIPTION`,`CATEGORY`,`PRICE`,`QTY`,`UNIT`) " &
            "VALUES(" & txtitemid.Text & ",'" & txtname.Text & "','" & txtdescription.Text & "'," &
            "(SELECT  tblcategories.`ID` FROM tblcategories WHERE tblcategories.`NAME` = '" & cbocategory.Text & "' LIMIT 1)," &
            txtprice.Text & "," & txtqty.Text & "," &
            "(SELECT  tblunits.`ID` FROM tblunits WHERE tblunits.`NAME` = '" & cbounit.Text & "' LIMIT 1))"
            create(sql, txtname.Text, txtname.Text)

            sql = "INSERT INTO  `tblstock_in_out` (`ITEMID`, `QTY`,`TRANSACTIONDATE`, `TOTALPRICE`, `REMARKS`)" &
               " VALUES (" & txtitemid.Text & "," & txtqty.Text & ",'" & Format(Now, "yyyy-MM-dd") & "', " & txtprice.Text &
               ", 'StockIn')"
            createNoMsg(sql)

        Else

            MsgBox("Duplicate entry '" & txtitemid.Text & "' for key 'tblitems.PRIMARY' create")

        End If


        '--------------------------------------
        sql = "SELECT `ITEMID` as 'ID Producto', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', " &
            "(SELECT NAME FROM `tblcategories` WHERE tblcategories.`ID`=tblitems.`CATEGORY`) as 'Categoría', " &
            " `PRICE` as 'Precio', `QTY` as 'Cantidad', " &
            "(SELECT NAME FROM `tblunits` WHERE tblunits.`ID`=tblitems.`UNIT`) as 'Unidad' " &
            "From tblitems"
        reloadDtg(sql, dtglist)
        '------------------------------------------
        cleartext(pnl_stockmaster)
        '--------------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False

        dtgcolor(dtglist, 5)
        loadautonumber("itemid", txtitemid)
    End Sub

    Private Sub frm_stockmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        sql = "SELECT `ITEMID` as 'ID Producto', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', " &
            "(SELECT NAME FROM `tblcategories` WHERE tblcategories.`ID`=tblitems.`CATEGORY`) as 'Categoría', " &
            " `PRICE` as 'Precio', `QTY` as 'Cantidad', " &
            "(SELECT NAME FROM `tblunits` WHERE tblunits.`ID`=tblitems.`UNIT`) as 'Unidad' " &
            "From tblitems"
        reloadDtg(sql, dtglist)
        '------------------------------------------
        dtgcolor(dtglist, 5)
        '------------------------------
        fillcbo("Select * FROM `tblcategories`", cbocategory)
        fillcbo("Select * FROM `tblunits`", cbounit)
        '-------------------------
        cleartext(pnl_stockmaster)
        '--------------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '------------------------------------------
        btnadd.Visible = False

        loadautonumber("itemid", txtitemid)

        select_navigation("Select itemid From tblitems")
        lblmax.Text = maxrows
        lblinc.Text = inc
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE From tblitems Where ITEMID ='" & dtglist.CurrentRow.Cells(0).Value & "'"
            deletes(sql, "Item", "Item")
            '--------------------------------------
            sql = "SELECT `ITEMID` as 'ID Producto', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', " &
            "(SELECT NAME FROM `tblcategories` WHERE tblcategories.`ID`=tblitems.`CATEGORY`) as 'Categoría', " &
            " `PRICE` as 'Precio', `QTY` as 'Cantidad', " &
            "(SELECT NAME FROM `tblunits` WHERE tblunits.`ID`=tblitems.`UNIT`) as 'Unidad' " &
            "From tblitems"
            reloadDtg(sql, dtglist)
            '------------------------------------------
            cleartext(pnl_stockmaster)
            '--------------------------------------
            '- maxcolumn = dtglist.Columns.Count - 1
            '- dtglist.Columns(maxcolumn).Visible = False
            loadautonumber("itemid", txtitemid)
            dtgcolor(dtglist, 5)
        Catch ex As Exception
            MsgBox("Action is invalid.", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblitems SET `NAME`='" & txtname.Text & "', `DESCRIPTION`='" & txtdescription.Text & "', " &
        "`CATEGORY`=" & "(SELECT  tblcategories.`ID` FROM tblcategories WHERE tblcategories.`NAME` = '" & cbocategory.Text & "' LIMIT 1), " &
        "`PRICE`='" & txtprice.Text & "', " & "`QTY`='" & txtqty.Text & "', " &
        "`UNIT`=" & "(SELECT  tblunits.`ID` FROM tblunits WHERE tblunits.`NAME` = '" & cbounit.Text & "' LIMIT 1) " &
        "WHERE ITEMID='" & txtitemid.Text & "'"
        updates(sql, txtname.Text, txtname.Text)
        '--------------------------------------
        sql = "SELECT `ITEMID` as 'ID Producto', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', " &
            "(SELECT NAME FROM `tblcategories` WHERE tblcategories.`ID`=tblitems.`CATEGORY`) as 'Categoría', " &
            " `PRICE` as 'Precio', `QTY` as 'Cantidad', " &
            "(SELECT NAME FROM `tblunits` WHERE tblunits.`ID`=tblitems.`UNIT`) as 'Unidad' " &
            "From tblitems"
        reloadDtg(sql, dtglist)
        '------------------------------------------
        cleartext(pnl_stockmaster)
        '--------------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        loadautonumber("itemid", txtitemid)
        dtgcolor(dtglist, 5)
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        sql = "SELECT `ITEMID` as 'ID Producto', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', " &
            "(SELECT NAME FROM `tblcategories` WHERE tblcategories.`ID`=tblitems.`CATEGORY`) as 'Categoría', " &
            " `PRICE` as 'Precio', `QTY` as 'Cantidad', " &
            "(SELECT NAME FROM `tblunits` WHERE tblunits.`ID`=tblitems.`UNIT`) as 'Unidad' " &
            "From tblitems"
        reloadDtg(sql, dtglist)
        '------------------------------------------
        dtgcolor(dtglist, 5)
        '------------------------------------------
        cleartext(pnl_stockmaster)
        '--------------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        loadautonumber("itemid", txtitemid)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try

            sql = "SELECT `ITEMID`, `NAME`, `DESCRIPTION`, " &
            "(SELECT NAME FROM `tblcategories` WHERE tblcategories.`ID`=tblitems.`CATEGORY`) as 'CATEGORY', " &
            " `PRICE`, `QTY`, " &
            "(SELECT NAME FROM `tblunits` WHERE tblunits.`ID`=tblitems.`UNIT`) as 'UNIT' " &
            "FROM tblitems " &
            "WHERE ITEMID='" & dtglist.CurrentRow.Cells(0).Value & "'"
            reloadtxt(sql)
            '- txtitemid.Text = dt.Rows(0).Item("ITEMID")
            '- txtname.Text = dt.Rows(0).Item("NAME")
            '- txtdescription.Text = dt.Rows(0).Item("DESCRIPTION")
            '- cbocategory.Text = dt.Rows(0).Item("CATEGORY")
            '- txtprice.Text = dt.Rows(0).Item("PRICE")
            '- txtqty.Text = dt.Rows(0).Item("QTY")
            '- cbounit.Text = dt.Rows(0).Item("UNIT")
            txtitemid.Text = dt.Rows(0).Item(0)
            txtname.Text = dt.Rows(0).Item(1)
            txtdescription.Text = dt.Rows(0).Item(2)
            cbocategory.Text = dt.Rows(0).Item(3)
            txtprice.Text = dt.Rows(0).Item(4)
            txtqty.Text = dt.Rows(0).Item(5)
            cbounit.Text = dt.Rows(0).Item(6)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

        sql = "SELECT `ITEMID` as 'ID Producto', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', " &
            "(SELECT NAME FROM `tblcategories` WHERE tblcategories.`ID`=tblitems.`CATEGORY`) as 'Categoría', " &
            " `PRICE` as 'Precio', `QTY` as 'Cantidad', " &
            "(SELECT NAME FROM `tblunits` WHERE tblunits.`ID`=tblitems.`UNIT`) as 'Unidad' " &
            "From tblitems " &
            "WHERE ITEMID LIKE '%" & txtsearch.Text & "%' OR NAME LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
        '------------------------------------------
        dtgcolor(dtglist, 5)
        '------------------------------------------
        cleartext(pnl_stockmaster)
        '--------------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False

        'loadautonumber("itemid", txtitemid)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        frm_transaction.txtSup_itemid.Text = dtglist.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        sql = "SELECT ITEMID FROM tblitems"
        select_navigation(sql)
        inc = 0
        lblinc.Text = inc + 1
        navagate_records(txtitemid)
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc > 0 Then
                inc = inc - 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)
            Else
                If inc - 1 Then
                    MsgBox("First records", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc <> maxrows - 1 Then
                inc = inc + 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)

            Else
                If inc = maxrows - 1 Then
                    MsgBox("No more rows", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)
                'navagate_records(lblid)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtitemid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemid.TextChanged
        Try
            sql = "SELECT `ITEMID` as 'ID Producto', `NAME` as 'Nombre', `DESCRIPTION` as 'Descripción', " &
            "(SELECT NAME FROM `tblcategories` WHERE tblcategories.`ID`=tblitems.`CATEGORY`) as 'Categoría', " &
            " `PRICE` as 'Precio', `QTY` as 'Cantidad', " &
            "(SELECT NAME FROM `tblunits` WHERE tblunits.`ID`=tblitems.`UNIT`) as 'Unidad' " &
            "From tblitems " &
            "WHERE ITEMID='" & txtitemid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtitemid.Text = dt.Rows(0).Item(0)
                txtname.Text = dt.Rows(0).Item(1)
                txtdescription.Text = dt.Rows(0).Item(2)
                cbocategory.Text = dt.Rows(0).Item(3)
                txtprice.Text = dt.Rows(0).Item(4)
                '- txtqty.Text = dt.Rows(0).Item("QTY")
                '- cbounit.Text = dt.Rows(0).Item("UNIT")
                txtqty.Text = dt.Rows(0).Item(5)
                cbounit.Text = dt.Rows(0).Item(6)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class