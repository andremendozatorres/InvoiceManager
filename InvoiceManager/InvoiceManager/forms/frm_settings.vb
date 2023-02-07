Public Class frm_settings
    Dim typeid As Integer = 0
    Dim unitid As Integer = 0
    Private Sub btnCategorySave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategorySave.Click
        sql = "INSERT INTO tblcategories (NAME) VALUES ('" & txtCategory.Text & "')"
        create(sql, txtCategory.Text, txtCategory.Text)

        txtCategory.Clear()
        sql = "SELECT ID, NAME as 'Categoría' FROM tblcategories"
        reloadDtg(sql, dtgCategoryList)
        '- dtgCategoryList.Columns(0).Visible = False
    End Sub

    Private Sub btnCategoryLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoryLoad.Click
        sql = "SELECT ID, NAME as 'Categoría' FROM tblcategories"
        reloadDtg(sql, dtgCategoryList)
        '- dtgCategoryList.Columns(0).Visible = False
        txtCategory.Clear()
    End Sub

    Private Sub dtgCategoryList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCategoryList.DoubleClick
        txtCategory.Text = dtgCategoryList.CurrentRow.Cells(1).Value
        typeid = dtgCategoryList.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnCategoryUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoryUpdate.Click
        sql = "UPDATE tblcategories  SET NAME= '" & txtCategory.Text & "' WHERE ID ='" & typeid & "'"
        updates(sql, txtCategory.Text, txtCategory.Text)
        sql = "SELECT ID, NAME as 'Categoría' FROM tblcategories"
        reloadDtg(sql, dtgCategoryList)
        '- dtgCategoryList.Columns(0).Visible = False
        txtCategory.Clear()
    End Sub

    Private Sub btnCategoryDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoryDelete.Click
        sql = "DELETE FROM `tblcategories` WHERE `ID`='" & dtgCategoryList.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtCategory.Text, txtCategory.Text)
        txtCategory.Clear()
        sql = "SELECT ID, NAME as 'Categoría' FROM tblcategories"
        reloadDtg(sql, dtgCategoryList)
        '- dtgCategoryList.Columns(0).Visible = False
    End Sub

    Private Sub btnUnitLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitLoad.Click
        sql = "SELECT ID, NAME as 'Unidad' FROM tblunits"
        reloadDtg(sql, dtgUnitList)
        '- dtgUnitList.Columns(0).Visible = False
        txtUnit.Clear()
    End Sub

    Private Sub dtgUnitList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgUnitList.DoubleClick
        txtUnit.Text = dtgUnitList.CurrentRow.Cells(1).Value
        unitid = dtgUnitList.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnUnitSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitSave.Click
        sql = "INSERT INTO tblunits (Name) VALUES ('" & txtUnit.Text & "')"
        create(sql, txtUnit.Text, txtUnit.Text)
        txtUnit.Clear()
        sql = "SELECT ID, Name as 'Unidad' FROM tblunits"
        reloadDtg(sql, dtgUnitList)
        '- dtgUnitList.Columns(0).Visible = False
    End Sub

    Private Sub btnUnitUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitUpdate.Click
        sql = "UPDATE tblunits  SET NAME = '" & txtUnit.Text & "' WHERE ID ='" & unitid & "'"
        updates(sql, txtUnit.Text, txtUnit.Text)
        sql = "SELECT ID, NAME as 'Unidad' FROM tblunits"
        reloadDtg(sql, dtgUnitList)
        '- dtgUnitList.Columns(0).Visible = False
        txtUnit.Clear()
    End Sub

    Private Sub btnUnitDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitDelete.Click
        sql = "DELETE FROM `tblunits` WHERE `ID`='" & dtgUnitList.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtUnit.Text, txtUnit.Text)
        sql = "SELECT ID, NAME as 'Unidad' FROM tblunits"
        reloadDtg(sql, dtgUnitList)
        '- dtgUnitList.Columns(0).Visible = False
    End Sub

    Private Sub frm_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'For Each dtg As Control In Me.Controls
        '    If TypeOf dtg Is DataGridView Then

        '        For Each r As DataGridViewRow In dtg.rows


        '        Next
        '    End If
        'Next
        sql = "SELECT ID, NAME as 'Categoría' FROM tblcategories"
        reloadDtg(sql, dtgCategoryList)
        '- dtgCategoryList.Columns(0).Visible = False
        sql = "SELECT ID, NAME as 'Unidad' FROM tblunits"
        reloadDtg(sql, dtgUnitList)
        '- dtgUnitList.Columns(0).Visible = False
        dtgCategoryList.DefaultCellStyle.ForeColor = Color.Black
        dtgUnitList.DefaultCellStyle.ForeColor = Color.Black
    End Sub

End Class