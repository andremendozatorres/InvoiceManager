Public Class frm_customer
    Dim ID As String = 0
    Dim maxcolumn
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click


        If txtaddress.Text = "" Or txtfname.Text = "" Or txtlname.Text = "" Or txtmobile.Text = "" And txttelephone.Text = "" Then
            MsgBox("Se requiere rellenar todos los campos vacíos.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'For Each txt As Control In Panel1.Controls
        '    'If txt.GetType Is GetType(TextBox) Then
        '    '    If txt.Text = "" Then
        '    '        MsgBox("Se requiere rellenar todos los campos vacíos.", MsgBoxStyle.Exclamation)
        '    '        Exit Sub
        '    '    End If
        '    'End If
        '    If txt.GetType Is GetType(RichTextBox) Then
        '        If txt.Text = "" Then
        '            MsgBox("Se requiere rellenar todos los campos vacíos.", MsgBoxStyle.Exclamation)
        '            Exit Sub
        '        End If
        '    End If
        'Next
        sql = "INSERT INTO tblperson (`ID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`)" &
        " VALUES ('" & txtcusid.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddress.Text & "','" & txttelephone.Text & "','" & txtmobile.Text & "','Customer')"
        create(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        txtcusid.Text = dt.Rows(0).Item(0)

        Call btnclear_Click(sender, e)
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        For Each txt As Control In Panel1.Controls
            If txt.GetType Is GetType(TextBox) Then
                If txt.Text = "" Then
                    MsgBox("Se requiere rellenar todos los campos vacíos.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
            If txt.GetType Is GetType(RichTextBox) Then
                If txt.Text = "" Then
                    MsgBox("Se requiere rellenar todos los campos vacíos.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        Next

        sql = "UPDATE tblperson SET  `FIRSTNAME`='" & txtfname.Text & "', `LASTNAME`='" & txtlname.Text &
        "', `ADDRESS`='" & txtaddress.Text & "', `TELEPHONE`='" & txttelephone.Text & "', `MOBILE`='" & txtmobile.Text & "' WHERE `ID`='" & txtcusid.Text & "'"
        updates(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Customer'"
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
        Try
            sql = "DELETE FROM tblperson WHERE `ID`='" & dtglist.CurrentRow.Cells("ID").Value & "'"
            deletes(sql, dtglist.CurrentRow.Cells("ID").Value, dtglist.CurrentRow.Cells("ID").Value)
            '----------------------------------
            sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Customer'"
            reloadDtg(sql, dtglist)
            '---------------------------------
            cleartext(Panel1)
            '----------------------------------
            '- maxcolumn = dtglist.Columns.Count - 1
            '- dtglist.Columns(maxcolumn).Visible = False
            '- dtglist.Columns(0).Visible = False
            '-------------------------------------
            reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
            txtcusid.Text = dt.Rows(0).Item(0)
        Catch ex As Exception
            MsgBox("Action is not valid", MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Customer' AND  ID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
        '---------------------------------- 
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        txtcusid.Text = dt.Rows(0).Item(0)


    End Sub

    Private Sub frm_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        txtcusid.Text = dt.Rows(0).Item(0)
        ' MsgBox(ID)
        'reloadtxt("SELECT  `ID` FROM `tblperson` WHERE  `TYPE` ='Customer'")
        'select_navigation(sql)
        inc = 0
        maxrows = dtglist.Rows.Count
        lblinc.Text = inc
        lblmax.Text = maxrows
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        '----------------------------------
        sql = "SELECT ID as 'ID', FIRSTNAME as 'Nombre', LASTNAME as 'Apellido', ADDRESS as 'Dirección', TELEPHONE as '# Teléfono', MOBILE as '# Celular' FROM tblperson WHERE TYPE ='Customer'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        '- maxcolumn = dtglist.Columns.Count - 1
        '- dtglist.Columns(maxcolumn).Visible = False
        '- dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT (ID+1) FROM tblperson ORDER BY ID DESC LIMIT 1")
        txtcusid.Text = dt.Rows(0).Item(0)
        ' MsgBox(ID)
        reloadtxt("SELECT  `ID` FROM `tblperson` WHERE  `TYPE` ='Customer'")
        select_navigation(sql)
        lblinc.Text = inc
        lblmax.Text = maxrows
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            txtcusid.Text = dtglist.CurrentRow.Cells(0).Value
            reloadtxt("SELECT * FROM tblperson WHERE ID ='" & dtglist.CurrentRow.Cells(0).Value & "'")
            txtfname.Text = dt.Rows(0).Item("FIRSTNAME")
            txtlname.Text = dt.Rows(0).Item("LASTNAME")
            txtaddress.Text = dt.Rows(0).Item("ADDRESS")
            txttelephone.Text = dt.Rows(0).Item("TELEPHONE")
            txtmobile.Text = dt.Rows(0).Item("MOBILE")
        Catch ex As Exception
            MsgBox("Action is not valid.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        frm_transaction.txt_cusid.Text = dtglist.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        sql = "SELECT  `ID` FROM `tblperson` WHERE  `TYPE` ='Customer'"
        select_navigation(sql)
        inc = 0
        lblinc.Text = inc + 1
        navagate_records(txtcusid)
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        Try
            sql = "SELECT  `ID` FROM `tblperson` WHERE  `TYPE` ='Customer'"
            select_navigation(sql)
            If inc > 0 Then
                inc = 1
                inc = inc - 1
                lblinc.Text = inc + 1
                navagate_records(txtcusid)
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
            sql = "SELECT  `ID` FROM `tblperson` WHERE  `TYPE` ='Customer'"
            select_navigation(sql)
            If inc <> maxrows - 1 Then
                inc = inc + 1
                lblinc.Text = inc + 1
                navagate_records(txtcusid)

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
            sql = "SELECT  `ID` FROM `tblperson` WHERE  `TYPE` ='Customer'"
            select_navigation(sql)
            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                lblinc.Text = inc + 1
                navagate_records(txtcusid)
                'navagate_records(lblid)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcusid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcusid.TextChanged
        Try
            reloadtxt("SELECT * FROM tblperson WHERE ID ='" & txtcusid.Text & "'")
            txtfname.Text = dt.Rows(0).Item("FIRSTNAME")
            txtlname.Text = dt.Rows(0).Item("LASTNAME")
            txtaddress.Text = dt.Rows(0).Item("ADDRESS")
            txttelephone.Text = dt.Rows(0).Item("TELEPHONE")
            txtmobile.Text = dt.Rows(0).Item("MOBILE")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class