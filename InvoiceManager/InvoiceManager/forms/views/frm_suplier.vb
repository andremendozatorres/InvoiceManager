Public Class frm_suplier
    Dim ID As String = 0
    Dim maxcolumn
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sql = "INSERT INTO tblperson (`ID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`)" &
        " VALUES ('" & ID & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddress.Text & "','" & txttelephone.Text & "','" & txtmobile.Text & "','SUPLIER')"
        create(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Suplier'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '------------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblperson SET  `FIRSTNAME`='" & txtfname.Text & "', `LASTNAME`='" & txtlname.Text &
        "', `ADDRESS`='" & txtaddress.Text & "', `TELEPHONE`='" & txttelephone.Text & "', `MOBILE`='" & txtmobile.Text & "' WHERE `ID`='" & ID & "'"
        updates(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Suplier'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "DELETE FROM tblperson WHERE `ID`='" & dtglist.CurrentRow.Cells("ID").Value & "'"
        deletes(sql, dtglist.CurrentRow.Cells("ID").Value, dtglist.CurrentRow.Cells("ID").Value)
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Suplier'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        ID = dt.Rows(0).Item(0)

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Suplier' AND  ID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
        '----------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub frm_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Suplier'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        ID = dt.Rows(0).Item(0)
        ' MsgBox(ID)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Suplier'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        ID = dt.Rows(0).Item(0)
        ' MsgBox(ID)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            ID = dtglist.CurrentRow.Cells(0).Value
            reloadtxt("SELECT * FROM tblperson WHERE TYPE='Suplier' AND ID ='" & dtglist.CurrentRow.Cells(0).Value & "'")
            txtfname.Text = dt.Rows(0).Item("FIRSTNAME")
            txtlname.Text = dt.Rows(0).Item("LASTNAME")
            txtaddress.Text = dt.Rows(0).Item("ADDRESS")
            txttelephone.Text = dt.Rows(0).Item("TELEPHONE")
            txtmobile.Text = dt.Rows(0).Item("MOBILE")
        Catch ex As Exception
            MsgBox("La acción no es válida.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        frm_transaction.txt_suplierId.Text = dtglist.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class