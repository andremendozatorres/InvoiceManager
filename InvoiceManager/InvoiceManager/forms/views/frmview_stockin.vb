Public Class frmview_stockin

    Private Sub frmview_stockin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  `TRANSACTIONNUMBER` as 'No. Factura', concat(`FIRSTNAME`, `LASTNAME`) as 'Cliente',`NAME` as 'Nombre Producto', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `TRANSACTIONDATE` as 'Fecha', i.`QTY` as 'Cantidad', `TOTALPRICE` as 'Precio Total' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`ID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Suplier'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `TRANSACTIONNUMBER` as 'No. Factura', concat(`FIRSTNAME`, `LASTNAME`) as 'Cliente',`NAME` as 'Nombre Producto', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `TRANSACTIONDATE` as 'Fecha', i.`QTY` as 'Cantidad', `TOTALPRICE` as 'Precio Total' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE  i.`ITEMID`=o.`ITEMID` and p.`ID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Suplier'" &
        " AND (NAME like '%" & txtsearch.Text & "%' OR  TRANSACTIONNUMBER like '%" & txtsearch.Text & "%')"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub
End Class