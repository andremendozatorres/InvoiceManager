﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ts_Transaction = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_StockMaster = New System.Windows.Forms.ToolStripButton()
        Me.ts_Customer = New System.Windows.Forms.ToolStripButton()
        Me.ts_ManageUser = New System.Windows.Forms.ToolStripButton()
        Me.ts_Setting = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_Login = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ts_Transaction
        '
        Me.ts_Transaction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Transaction.Image = CType(resources.GetObject("ts_Transaction.Image"), System.Drawing.Image)
        Me.ts_Transaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Transaction.Name = "ts_Transaction"
        Me.ts_Transaction.Size = New System.Drawing.Size(126, 49)
        Me.ts_Transaction.Text = "INGRESO Y REPORTES"
        Me.ts_Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'ts_StockMaster
        '
        Me.ts_StockMaster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_StockMaster.Image = CType(resources.GetObject("ts_StockMaster.Image"), System.Drawing.Image)
        Me.ts_StockMaster.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_StockMaster.Name = "ts_StockMaster"
        Me.ts_StockMaster.Size = New System.Drawing.Size(80, 49)
        Me.ts_StockMaster.Text = "PRODUCTOS"
        Me.ts_StockMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Customer
        '
        Me.ts_Customer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Customer.Image = CType(resources.GetObject("ts_Customer.Image"), System.Drawing.Image)
        Me.ts_Customer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Customer.Name = "ts_Customer"
        Me.ts_Customer.Size = New System.Drawing.Size(61, 49)
        Me.ts_Customer.Text = "CLIENTES"
        Me.ts_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_ManageUser
        '
        Me.ts_ManageUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_ManageUser.Image = CType(resources.GetObject("ts_ManageUser.Image"), System.Drawing.Image)
        Me.ts_ManageUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_ManageUser.Name = "ts_ManageUser"
        Me.ts_ManageUser.Size = New System.Drawing.Size(66, 49)
        Me.ts_ManageUser.Text = "USUARIOS"
        Me.ts_ManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Setting
        '
        Me.ts_Setting.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Setting.Image = CType(resources.GetObject("ts_Setting.Image"), System.Drawing.Image)
        Me.ts_Setting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Setting.Name = "ts_Setting"
        Me.ts_Setting.Size = New System.Drawing.Size(127, 49)
        Me.ts_Setting.Text = "AJUSTES PRODUCTOS"
        Me.ts_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'ts_Login
        '
        Me.ts_Login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.ts_Login.Image = CType(resources.GetObject("ts_Login.Image"), System.Drawing.Image)
        Me.ts_Login.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Login.Name = "ts_Login"
        Me.ts_Login.Size = New System.Drawing.Size(46, 49)
        Me.ts_Login.Text = "LOGIN"
        Me.ts_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Transaction, Me.ToolStripSeparator2, Me.ts_StockMaster, Me.ts_Customer, Me.ts_ManageUser, Me.ts_Setting, Me.ToolStripSeparator1, Me.ts_Login})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(915, 52)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(915, 499)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ts_Transaction As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ts_StockMaster As ToolStripButton
    Friend WithEvents ts_Customer As ToolStripButton
    Friend WithEvents ts_ManageUser As ToolStripButton
    Friend WithEvents ts_Setting As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ts_Login As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
