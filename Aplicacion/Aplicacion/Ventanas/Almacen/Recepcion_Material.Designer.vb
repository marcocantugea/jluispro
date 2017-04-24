<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recepcion_Material
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recepcion_Material))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblAlmacenid = New System.Windows.Forms.Label()
        Me.lblordencompraid = New System.Windows.Forms.Label()
        Me.lblproveedorid = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tobservaciones = New System.Windows.Forms.TextBox()
        Me.talmacen = New System.Windows.Forms.TextBox()
        Me.tordencompra = New System.Windows.Forms.TextBox()
        Me.tproveedor = New System.Windows.Forms.TextBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tTotal = New System.Windows.Forms.TextBox()
        Me.timpuestos = New System.Windows.Forms.TextBox()
        Me.tsubtotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.rbtabGeneral = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnNew = New System.Windows.Forms.RibbonButton()
        Me.btnSave = New System.Windows.Forms.RibbonButton()
        Me.btnSearch = New System.Windows.Forms.RibbonButton()
        Me.dgv_partidas = New System.Windows.Forms.DataGridView()
        Me.tfolioentrada = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_partidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.Ribbon1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1257, 484)
        Me.Panel1.TabIndex = 0
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(37, 133)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(414, 44)
        Me.lbltitle.TabIndex = 93
        Me.lbltitle.Text = "Recepcion de Material"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 189)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1257, 295)
        Me.TabControl1.TabIndex = 103
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.tfolioentrada)
        Me.TabPage1.Controls.Add(Me.lblAlmacenid)
        Me.TabPage1.Controls.Add(Me.lblordencompraid)
        Me.TabPage1.Controls.Add(Me.lblproveedorid)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.tobservaciones)
        Me.TabPage1.Controls.Add(Me.talmacen)
        Me.TabPage1.Controls.Add(Me.tordencompra)
        Me.TabPage1.Controls.Add(Me.tproveedor)
        Me.TabPage1.Controls.Add(Me.dtFecha)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1249, 266)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle"
        '
        'lblAlmacenid
        '
        Me.lblAlmacenid.AutoSize = True
        Me.lblAlmacenid.Location = New System.Drawing.Point(388, 177)
        Me.lblAlmacenid.Name = "lblAlmacenid"
        Me.lblAlmacenid.Size = New System.Drawing.Size(87, 17)
        Me.lblAlmacenid.TabIndex = 104
        Me.lblAlmacenid.Text = "lblAlmacenid"
        '
        'lblordencompraid
        '
        Me.lblordencompraid.AutoSize = True
        Me.lblordencompraid.Location = New System.Drawing.Point(387, 17)
        Me.lblordencompraid.Name = "lblordencompraid"
        Me.lblordencompraid.Size = New System.Drawing.Size(59, 17)
        Me.lblordencompraid.TabIndex = 103
        Me.lblordencompraid.Text = "Label10"
        '
        'lblproveedorid
        '
        Me.lblproveedorid.AutoSize = True
        Me.lblproveedorid.Location = New System.Drawing.Point(388, 134)
        Me.lblproveedorid.Name = "lblproveedorid"
        Me.lblproveedorid.Size = New System.Drawing.Size(59, 17)
        Me.lblproveedorid.TabIndex = 102
        Me.lblproveedorid.Text = "Label10"
        '
        'Button3
        '
        Me.Button3.Image = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.Button3.Location = New System.Drawing.Point(342, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 34)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.Button2.Location = New System.Drawing.Point(342, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.Button1.Location = New System.Drawing.Point(342, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tobservaciones
        '
        Me.tobservaciones.Enabled = False
        Me.tobservaciones.Location = New System.Drawing.Point(550, 32)
        Me.tobservaciones.Multiline = True
        Me.tobservaciones.Name = "tobservaciones"
        Me.tobservaciones.Size = New System.Drawing.Size(286, 114)
        Me.tobservaciones.TabIndex = 9
        '
        'talmacen
        '
        Me.talmacen.Enabled = False
        Me.talmacen.Location = New System.Drawing.Point(181, 175)
        Me.talmacen.Name = "talmacen"
        Me.talmacen.Size = New System.Drawing.Size(155, 22)
        Me.talmacen.TabIndex = 7
        '
        'tordencompra
        '
        Me.tordencompra.Enabled = False
        Me.tordencompra.Location = New System.Drawing.Point(181, 29)
        Me.tordencompra.Name = "tordencompra"
        Me.tordencompra.Size = New System.Drawing.Size(155, 22)
        Me.tordencompra.TabIndex = 5
        '
        'tproveedor
        '
        Me.tproveedor.Enabled = False
        Me.tproveedor.Location = New System.Drawing.Point(181, 137)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.Size = New System.Drawing.Size(155, 22)
        Me.tproveedor.TabIndex = 3
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(181, 65)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(200, 22)
        Me.dtFecha.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tTotal)
        Me.Panel2.Controls.Add(Me.timpuestos)
        Me.Panel2.Controls.Add(Me.tsubtotal)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(859, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(287, 123)
        Me.Panel2.TabIndex = 101
        '
        'tTotal
        '
        Me.tTotal.Enabled = False
        Me.tTotal.Location = New System.Drawing.Point(174, 78)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.Size = New System.Drawing.Size(100, 22)
        Me.tTotal.TabIndex = 12
        '
        'timpuestos
        '
        Me.timpuestos.Enabled = False
        Me.timpuestos.Location = New System.Drawing.Point(174, 44)
        Me.timpuestos.Name = "timpuestos"
        Me.timpuestos.Size = New System.Drawing.Size(100, 22)
        Me.timpuestos.TabIndex = 11
        '
        'tsubtotal
        '
        Me.tsubtotal.Enabled = False
        Me.tsubtotal.Location = New System.Drawing.Point(174, 11)
        Me.tsubtotal.Name = "tsubtotal"
        Me.tsubtotal.Size = New System.Drawing.Size(100, 22)
        Me.tsubtotal.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(13, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(13, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Impuestos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(13, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Subtotal:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(431, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Observaciones:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(20, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Almacen*:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(20, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Orden de Compra*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(20, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor*:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(20, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Folio de Entrada:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(20, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Tahoma", 8.400001!, System.Drawing.FontStyle.Bold)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 447)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = Nothing
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon1.OrbText = "FILE"
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1257, 130)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.rbtabGeneral)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        Me.Ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'rbtabGeneral
        '
        Me.rbtabGeneral.Panels.Add(Me.RibbonPanel1)
        Me.rbtabGeneral.Text = "GENERAL"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.btnNew)
        Me.RibbonPanel1.Items.Add(Me.btnSave)
        Me.RibbonPanel1.Items.Add(Me.btnSearch)
        Me.RibbonPanel1.Text = Nothing
        '
        'btnNew
        '
        Me.btnNew.Image = Global.Aplicacion.My.Resources.Resources.ic_New
        Me.btnNew.SmallImage = CType(resources.GetObject("btnNew.SmallImage"), System.Drawing.Image)
        Me.btnNew.Text = "Nuevo"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Aplicacion.My.Resources.Resources.ic_Save1
        Me.btnSave.SmallImage = CType(resources.GetObject("btnSave.SmallImage"), System.Drawing.Image)
        Me.btnSave.Text = "Guardar"
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.btnSearch.SmallImage = CType(resources.GetObject("btnSearch.SmallImage"), System.Drawing.Image)
        Me.btnSearch.Text = "Buscar"
        '
        'dgv_partidas
        '
        Me.dgv_partidas.AllowUserToAddRows = False
        Me.dgv_partidas.AllowUserToDeleteRows = False
        Me.dgv_partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_partidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_partidas.Location = New System.Drawing.Point(0, 484)
        Me.dgv_partidas.Name = "dgv_partidas"
        Me.dgv_partidas.RowTemplate.Height = 24
        Me.dgv_partidas.Size = New System.Drawing.Size(1257, 134)
        Me.dgv_partidas.TabIndex = 100
        '
        'tfolioentrada
        '
        Me.tfolioentrada.Location = New System.Drawing.Point(181, 97)
        Me.tfolioentrada.Mask = "T000000"
        Me.tfolioentrada.Name = "tfolioentrada"
        Me.tfolioentrada.Size = New System.Drawing.Size(200, 22)
        Me.tfolioentrada.TabIndex = 2
        '
        'Recepcion_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 618)
        Me.Controls.Add(Me.dgv_partidas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Recepcion_Material"
        Me.Text = "Recepcion de Material"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_partidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgv_partidas As System.Windows.Forms.DataGridView
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents rbtabGeneral As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnNew As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSave As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSearch As System.Windows.Forms.RibbonButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents talmacen As System.Windows.Forms.TextBox
    Friend WithEvents tordencompra As System.Windows.Forms.TextBox
    Friend WithEvents tproveedor As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents timpuestos As System.Windows.Forms.TextBox
    Friend WithEvents tsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblAlmacenid As System.Windows.Forms.Label
    Friend WithEvents lblordencompraid As System.Windows.Forms.Label
    Friend WithEvents lblproveedorid As System.Windows.Forms.Label
    Friend WithEvents tfolioentrada As System.Windows.Forms.MaskedTextBox
End Class
