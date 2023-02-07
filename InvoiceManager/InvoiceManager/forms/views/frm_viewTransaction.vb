Public Class frm_viewTransaction
    Private Sub frm_viewTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = " SELECT `TRANSACTIONNUMBER` as 'Número de Factura',  `TRANSACTIONDATE` as 'Fecha',  `FIRSTNAME` as 'Nombre', `LASTNAME` as 'Apellido', `STATE` as 'Estado', (SELECT SUM(`TOTALPRICE`) FROM `tblstock_in_out` WHERE tblstock_in_out.`TRANSACTIONNUMBER` = t.`TRANSACTIONNUMBER`) AS Total FROM `tbltransaction` t,`tblperson` c WHERE  c.`ID`=t.`SUPLIERCUSTOMERID` AND t.TYPE ='StockOut'"
        reloadDtg(sql, dtglist)
        dtgcolor_canceled(dtglist, 4)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = " SELECT `TRANSACTIONNUMBER` as 'Número de Factura',  `TRANSACTIONDATE` as 'Fecha',  `FIRSTNAME` as 'Nombre', `LASTNAME` as 'Apellido', `STATE` as 'Estado', (SELECT SUM(`TOTALPRICE`) FROM `tblstock_in_out` WHERE tblstock_in_out.`TRANSACTIONNUMBER` = t.`TRANSACTIONNUMBER`) AS Total FROM `tbltransaction` t,`tblperson` c WHERE  c.`ID`=t.`SUPLIERCUSTOMERID` AND t.TYPE ='StockOut' " &
        " AND TRANSACTIONNUMBER LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
        dtgcolor_canceled(dtglist, 4)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        frm_transaction.txttransactionid.Text = dtglist.CurrentRow.Cells(0).Value

        Dim final_total2 As Double
        For Each r As DataGridViewRow In frm_transaction.dtgreturn_itemlist.Rows
            final_total2 += r.Cells(6).Value
        Next
        frm_transaction.Label11.Text = "Total : Q." & final_total2

        Me.Close()
    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub
End Class