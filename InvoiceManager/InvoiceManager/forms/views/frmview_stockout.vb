Public Class frmview_stockout

    Private Sub frmview_stockout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  `TRANSACTIONNUMBER` as 'Número de Factura', concat(`FIRSTNAME`, `LASTNAME`) as 'Cliente', `NAME` as 'Producto', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `TRANSACTIONDATE` as 'Fecha', o.`QTY` as 'Cantidad', `TOTALPRICE` as 'Total' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE REMARKS='StockOut' AND i.`ITEMID`=o.`ITEMID` and p.`ID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'"
        reloadDtg(sql, dtglist)
    End Sub
    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `TRANSACTIONNUMBER` as 'Número de Factura', concat(`FIRSTNAME`, `LASTNAME`) as 'Cliente',`NAME` as 'Producto', `DESCRIPTION` as 'Descripción', `PRICE` as 'Precio', `TRANSACTIONDATE` as 'Fecha', o.`QTY` as 'Cantidad', `TOTALPRICE` as 'Total' FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE REMARKS='StockOut' and i.`ITEMID`=o.`ITEMID` and p.`ID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'" &
        " AND (NAME like '%" & txtsearch.Text & "%' OR  TRANSACTIONNUMBER like '%" & txtsearch.Text & "%')"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class