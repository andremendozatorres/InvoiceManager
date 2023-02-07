Public Class frmview_customer

    Private Sub frmview_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  `ID` as 'Cliente Id', `FIRSTNAME` as 'Nombre', `LASTNAME` as 'Apellido', `ADDRESS` as 'Dirección', `TELEPHONE` as 'Teléfono', `MOBILE` as 'Celular', `TYPE` as 'Tipo' FROM `tblperson` WHERE  `TYPE` ='Customer'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `ID` as 'Cliente Id', `FIRSTNAME` as 'Nombre', `LASTNAME` as 'Apellido', `ADDRESS` as 'Dirección', `TELEPHONE` as Teléfono, `MOBILE` as 'Celular', `TYPE` as 'Tipo' FROM `tblperson` WHERE  `TYPE` ='Customer' AND  ID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            frm_transaction.txt_cusid.Text = dtglist.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class