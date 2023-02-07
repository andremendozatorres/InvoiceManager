<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.btnUnitSave = New System.Windows.Forms.Button()
        Me.btnCategoryDelete = New System.Windows.Forms.Button()
        Me.btnCategoryUpdate = New System.Windows.Forms.Button()
        Me.btnCategoryLoad = New System.Windows.Forms.Button()
        Me.dtgCategoryList = New System.Windows.Forms.DataGridView()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUnitUpdate = New System.Windows.Forms.Button()
        Me.btnUnitLoad = New System.Windows.Forms.Button()
        Me.dtgUnitList = New System.Windows.Forms.DataGridView()
        Me.btnCategorySave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUnitDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dtgCategoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgUnitList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(72, 28)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(212, 20)
        Me.txtUnit.TabIndex = 2
        '
        'btnUnitSave
        '
        Me.btnUnitSave.BackColor = System.Drawing.Color.White
        Me.btnUnitSave.ForeColor = System.Drawing.Color.Black
        Me.btnUnitSave.Location = New System.Drawing.Point(290, 31)
        Me.btnUnitSave.Name = "btnUnitSave"
        Me.btnUnitSave.Size = New System.Drawing.Size(75, 23)
        Me.btnUnitSave.TabIndex = 0
        Me.btnUnitSave.Text = "Guardar"
        Me.btnUnitSave.UseVisualStyleBackColor = False
        '
        'btnCategoryDelete
        '
        Me.btnCategoryDelete.BackColor = System.Drawing.Color.White
        Me.btnCategoryDelete.ForeColor = System.Drawing.Color.Black
        Me.btnCategoryDelete.Location = New System.Drawing.Point(290, 89)
        Me.btnCategoryDelete.Name = "btnCategoryDelete"
        Me.btnCategoryDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnCategoryDelete.TabIndex = 6
        Me.btnCategoryDelete.Text = "Eliminar"
        Me.btnCategoryDelete.UseVisualStyleBackColor = False
        '
        'btnCategoryUpdate
        '
        Me.btnCategoryUpdate.BackColor = System.Drawing.Color.White
        Me.btnCategoryUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnCategoryUpdate.Location = New System.Drawing.Point(290, 60)
        Me.btnCategoryUpdate.Name = "btnCategoryUpdate"
        Me.btnCategoryUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnCategoryUpdate.TabIndex = 5
        Me.btnCategoryUpdate.Text = "Actualizar"
        Me.btnCategoryUpdate.UseVisualStyleBackColor = False
        '
        'btnCategoryLoad
        '
        Me.btnCategoryLoad.BackColor = System.Drawing.Color.White
        Me.btnCategoryLoad.ForeColor = System.Drawing.Color.Black
        Me.btnCategoryLoad.Location = New System.Drawing.Point(290, 121)
        Me.btnCategoryLoad.Name = "btnCategoryLoad"
        Me.btnCategoryLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnCategoryLoad.TabIndex = 4
        Me.btnCategoryLoad.Text = "Cargar"
        Me.btnCategoryLoad.UseVisualStyleBackColor = False
        '
        'dtgCategoryList
        '
        Me.dtgCategoryList.AllowUserToAddRows = False
        Me.dtgCategoryList.AllowUserToDeleteRows = False
        Me.dtgCategoryList.AllowUserToResizeColumns = False
        Me.dtgCategoryList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgCategoryList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCategoryList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCategoryList.Location = New System.Drawing.Point(6, 54)
        Me.dtgCategoryList.Name = "dtgCategoryList"
        Me.dtgCategoryList.RowHeadersVisible = False
        Me.dtgCategoryList.Size = New System.Drawing.Size(278, 312)
        Me.dtgCategoryList.TabIndex = 3
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(72, 28)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(212, 20)
        Me.txtCategory.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categoria :"
        '
        'btnUnitUpdate
        '
        Me.btnUnitUpdate.BackColor = System.Drawing.Color.White
        Me.btnUnitUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUnitUpdate.Location = New System.Drawing.Point(290, 60)
        Me.btnUnitUpdate.Name = "btnUnitUpdate"
        Me.btnUnitUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUnitUpdate.TabIndex = 5
        Me.btnUnitUpdate.Text = "Actualizar"
        Me.btnUnitUpdate.UseVisualStyleBackColor = False
        '
        'btnUnitLoad
        '
        Me.btnUnitLoad.BackColor = System.Drawing.Color.White
        Me.btnUnitLoad.ForeColor = System.Drawing.Color.Black
        Me.btnUnitLoad.Location = New System.Drawing.Point(290, 117)
        Me.btnUnitLoad.Name = "btnUnitLoad"
        Me.btnUnitLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnUnitLoad.TabIndex = 4
        Me.btnUnitLoad.Text = "Cargar"
        Me.btnUnitLoad.UseVisualStyleBackColor = False
        '
        'dtgUnitList
        '
        Me.dtgUnitList.AllowUserToAddRows = False
        Me.dtgUnitList.AllowUserToDeleteRows = False
        Me.dtgUnitList.AllowUserToResizeColumns = False
        Me.dtgUnitList.AllowUserToResizeRows = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgUnitList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgUnitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUnitList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgUnitList.Location = New System.Drawing.Point(6, 54)
        Me.dtgUnitList.Name = "dtgUnitList"
        Me.dtgUnitList.RowHeadersVisible = False
        Me.dtgUnitList.Size = New System.Drawing.Size(278, 312)
        Me.dtgUnitList.TabIndex = 3
        '
        'btnCategorySave
        '
        Me.btnCategorySave.BackColor = System.Drawing.Color.White
        Me.btnCategorySave.ForeColor = System.Drawing.Color.Black
        Me.btnCategorySave.Location = New System.Drawing.Point(290, 31)
        Me.btnCategorySave.Name = "btnCategorySave"
        Me.btnCategorySave.Size = New System.Drawing.Size(75, 23)
        Me.btnCategorySave.TabIndex = 0
        Me.btnCategorySave.Text = "Guardar"
        Me.btnCategorySave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUnitDelete)
        Me.GroupBox2.Controls.Add(Me.btnUnitUpdate)
        Me.GroupBox2.Controls.Add(Me.btnUnitLoad)
        Me.GroupBox2.Controls.Add(Me.dtgUnitList)
        Me.GroupBox2.Controls.Add(Me.txtUnit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnUnitSave)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(392, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 372)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Unidad de Producto"
        '
        'btnUnitDelete
        '
        Me.btnUnitDelete.BackColor = System.Drawing.Color.White
        Me.btnUnitDelete.ForeColor = System.Drawing.Color.Black
        Me.btnUnitDelete.Location = New System.Drawing.Point(290, 88)
        Me.btnUnitDelete.Name = "btnUnitDelete"
        Me.btnUnitDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnUnitDelete.TabIndex = 7
        Me.btnUnitDelete.Text = "Eliminar"
        Me.btnUnitDelete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unidad :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCategoryDelete)
        Me.GroupBox1.Controls.Add(Me.btnCategoryUpdate)
        Me.GroupBox1.Controls.Add(Me.btnCategoryLoad)
        Me.GroupBox1.Controls.Add(Me.dtgCategoryList)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCategorySave)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 372)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Categoria"
        '
        'frm_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 407)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes de Productos"
        CType(Me.dtgCategoryList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgUnitList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUnit As TextBox
    Friend WithEvents btnUnitSave As Button
    Friend WithEvents btnCategoryDelete As Button
    Friend WithEvents btnCategoryUpdate As Button
    Friend WithEvents btnCategoryLoad As Button
    Friend WithEvents dtgCategoryList As DataGridView
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUnitUpdate As Button
    Friend WithEvents btnUnitLoad As Button
    Friend WithEvents dtgUnitList As DataGridView
    Friend WithEvents btnCategorySave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUnitDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
