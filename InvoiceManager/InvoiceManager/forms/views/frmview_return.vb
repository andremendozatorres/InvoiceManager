Public Class frmview_return

    Private Sub frmview_return_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT concat(`FIRSTNAME`, `LASTNAME`) as 'Nombre',`STOCKRETURNNUMBER` as 'Transacción #',`NAME` as 'Nombre Producto', `RETURNDATE` as 'Fecha' FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ITEMID`=r.`ITEMID` and r.`OWNER_CUS_ID` =p.`ID` and p.TYPE not in ('Suplier')"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT concat(`FIRSTNAME`, `LASTNAME`) as 'Nombre',`STOCKRETURNNUMBER` as 'Transacción #',`NAME` as 'Nombre Producto', `RETURNDATE` as 'Fecha' FROM `tblstock_return` r, `tblitems` i,`tblperson` p WHERE i.`ITEMID`=r.`ITEMID` and r.`OWNER_CUS_ID` =p.`ID` and p.TYPE not in ('Suplier')" &
        " AND STOCKRETURNNUMBER LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub

End Class