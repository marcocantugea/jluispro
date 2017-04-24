<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Divisa_Catalogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Divisa_Catalogo))
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblsimbolo = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblfechacotizacion = New System.Windows.Forms.Label()
        Me.lblcotizacionunitaria = New System.Windows.Forms.Label()
        Me.lblfuente = New System.Windows.Forms.Label()
        Me.lblDivisaPredeterminada = New System.Windows.Forms.Label()
        Me.lblAbreviacion = New System.Windows.Forms.Label()
        Me.dgv_divisas = New System.Windows.Forms.DataGridView()
        Me.tDESCRIPCION = New System.Windows.Forms.TextBox()
        Me.tSIMBOLOMONEDA = New System.Windows.Forms.TextBox()
        Me.dtFECHAULTIMACOTIZACION = New System.Windows.Forms.DateTimePicker()
        Me.tCOTIZACIONUNITARIA = New System.Windows.Forms.TextBox()
        Me.tFUENTECOTIZACION = New System.Windows.Forms.TextBox()
        Me.chkPREDETERMINADO = New System.Windows.Forms.CheckBox()
        Me.tABREVIATURA = New System.Windows.Forms.TextBox()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnNew = New System.Windows.Forms.RibbonButton()
        Me.btnSave = New System.Windows.Forms.RibbonButton()
        Me.btnSearch = New System.Windows.Forms.RibbonButton()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.RibbonButton()
        CType(Me.dgv_divisas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbldescripcion.ForeColor = System.Drawing.Color.White
        Me.lbldescripcion.Location = New System.Drawing.Point(18, 201)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(177, 16)
        Me.lbldescripcion.TabIndex = 0
        Me.lbldescripcion.Text = "Descripcion de la Divisa"
        '
        'lblsimbolo
        '
        Me.lblsimbolo.AutoSize = True
        Me.lblsimbolo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblsimbolo.ForeColor = System.Drawing.Color.White
        Me.lblsimbolo.Location = New System.Drawing.Point(18, 234)
        Me.lblsimbolo.Name = "lblsimbolo"
        Me.lblsimbolo.Size = New System.Drawing.Size(147, 16)
        Me.lblsimbolo.TabIndex = 1
        Me.lblsimbolo.Text = "Simbolo de Moneda"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(13, 140)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(375, 44)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "Catalogo de Divisas"
        '
        'lblfechacotizacion
        '
        Me.lblfechacotizacion.AutoSize = True
        Me.lblfechacotizacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblfechacotizacion.ForeColor = System.Drawing.Color.White
        Me.lblfechacotizacion.Location = New System.Drawing.Point(18, 268)
        Me.lblfechacotizacion.Name = "lblfechacotizacion"
        Me.lblfechacotizacion.Size = New System.Drawing.Size(197, 16)
        Me.lblfechacotizacion.TabIndex = 109
        Me.lblfechacotizacion.Text = "Fecha de Ultima Cotizacion"
        '
        'lblcotizacionunitaria
        '
        Me.lblcotizacionunitaria.AutoSize = True
        Me.lblcotizacionunitaria.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblcotizacionunitaria.ForeColor = System.Drawing.Color.White
        Me.lblcotizacionunitaria.Location = New System.Drawing.Point(18, 303)
        Me.lblcotizacionunitaria.Name = "lblcotizacionunitaria"
        Me.lblcotizacionunitaria.Size = New System.Drawing.Size(139, 16)
        Me.lblcotizacionunitaria.TabIndex = 110
        Me.lblcotizacionunitaria.Text = "Cotizacion Unitaria"
        '
        'lblfuente
        '
        Me.lblfuente.AutoSize = True
        Me.lblfuente.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblfuente.ForeColor = System.Drawing.Color.White
        Me.lblfuente.Location = New System.Drawing.Point(18, 334)
        Me.lblfuente.Name = "lblfuente"
        Me.lblfuente.Size = New System.Drawing.Size(157, 16)
        Me.lblfuente.TabIndex = 111
        Me.lblfuente.Text = "Fuente de Cotizacion"
        '
        'lblDivisaPredeterminada
        '
        Me.lblDivisaPredeterminada.AutoSize = True
        Me.lblDivisaPredeterminada.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDivisaPredeterminada.ForeColor = System.Drawing.Color.White
        Me.lblDivisaPredeterminada.Location = New System.Drawing.Point(18, 369)
        Me.lblDivisaPredeterminada.Name = "lblDivisaPredeterminada"
        Me.lblDivisaPredeterminada.Size = New System.Drawing.Size(167, 16)
        Me.lblDivisaPredeterminada.TabIndex = 112
        Me.lblDivisaPredeterminada.Text = "Divisa Predeterminada"
        '
        'lblAbreviacion
        '
        Me.lblAbreviacion.AutoSize = True
        Me.lblAbreviacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAbreviacion.ForeColor = System.Drawing.Color.White
        Me.lblAbreviacion.Location = New System.Drawing.Point(18, 401)
        Me.lblAbreviacion.Name = "lblAbreviacion"
        Me.lblAbreviacion.Size = New System.Drawing.Size(92, 16)
        Me.lblAbreviacion.TabIndex = 113
        Me.lblAbreviacion.Text = "Abreviación"
        '
        'dgv_divisas
        '
        Me.dgv_divisas.AllowUserToAddRows = False
        Me.dgv_divisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_divisas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_divisas.Location = New System.Drawing.Point(21, 447)
        Me.dgv_divisas.MultiSelect = False
        Me.dgv_divisas.Name = "dgv_divisas"
        Me.dgv_divisas.ReadOnly = True
        Me.dgv_divisas.RowTemplate.Height = 24
        Me.dgv_divisas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_divisas.Size = New System.Drawing.Size(240, 150)
        Me.dgv_divisas.TabIndex = 114
        '
        'tDESCRIPCION
        '
        Me.tDESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tDESCRIPCION.Location = New System.Drawing.Point(246, 198)
        Me.tDESCRIPCION.Name = "tDESCRIPCION"
        Me.tDESCRIPCION.Size = New System.Drawing.Size(397, 23)
        Me.tDESCRIPCION.TabIndex = 115
        '
        'tSIMBOLOMONEDA
        '
        Me.tSIMBOLOMONEDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tSIMBOLOMONEDA.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tSIMBOLOMONEDA.Location = New System.Drawing.Point(246, 232)
        Me.tSIMBOLOMONEDA.Name = "tSIMBOLOMONEDA"
        Me.tSIMBOLOMONEDA.Size = New System.Drawing.Size(74, 23)
        Me.tSIMBOLOMONEDA.TabIndex = 116
        '
        'dtFECHAULTIMACOTIZACION
        '
        Me.dtFECHAULTIMACOTIZACION.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.dtFECHAULTIMACOTIZACION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFECHAULTIMACOTIZACION.Location = New System.Drawing.Point(246, 263)
        Me.dtFECHAULTIMACOTIZACION.Name = "dtFECHAULTIMACOTIZACION"
        Me.dtFECHAULTIMACOTIZACION.Size = New System.Drawing.Size(121, 24)
        Me.dtFECHAULTIMACOTIZACION.TabIndex = 117
        '
        'tCOTIZACIONUNITARIA
        '
        Me.tCOTIZACIONUNITARIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tCOTIZACIONUNITARIA.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tCOTIZACIONUNITARIA.Location = New System.Drawing.Point(246, 301)
        Me.tCOTIZACIONUNITARIA.Name = "tCOTIZACIONUNITARIA"
        Me.tCOTIZACIONUNITARIA.Size = New System.Drawing.Size(121, 23)
        Me.tCOTIZACIONUNITARIA.TabIndex = 118
        '
        'tFUENTECOTIZACION
        '
        Me.tFUENTECOTIZACION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tFUENTECOTIZACION.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tFUENTECOTIZACION.Location = New System.Drawing.Point(246, 332)
        Me.tFUENTECOTIZACION.Name = "tFUENTECOTIZACION"
        Me.tFUENTECOTIZACION.Size = New System.Drawing.Size(397, 23)
        Me.tFUENTECOTIZACION.TabIndex = 119
        '
        'chkPREDETERMINADO
        '
        Me.chkPREDETERMINADO.AutoSize = True
        Me.chkPREDETERMINADO.Location = New System.Drawing.Point(246, 369)
        Me.chkPREDETERMINADO.Name = "chkPREDETERMINADO"
        Me.chkPREDETERMINADO.Size = New System.Drawing.Size(18, 17)
        Me.chkPREDETERMINADO.TabIndex = 120
        Me.chkPREDETERMINADO.UseVisualStyleBackColor = True
        '
        'tABREVIATURA
        '
        Me.tABREVIATURA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tABREVIATURA.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tABREVIATURA.Location = New System.Drawing.Point(246, 399)
        Me.tABREVIATURA.Name = "tABREVIATURA"
        Me.tABREVIATURA.Size = New System.Drawing.Size(121, 23)
        Me.tABREVIATURA.TabIndex = 121
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
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 72)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = Nothing
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon1.OrbText = "FILE"
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(793, 137)
        Me.Ribbon1.TabIndex = 122
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        Me.Ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Text = "GENERAL"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.btnNew)
        Me.RibbonPanel1.Items.Add(Me.btnSave)
        Me.RibbonPanel1.Items.Add(Me.btnSearch)
        Me.RibbonPanel1.Items.Add(Me.btnDelete)
        Me.RibbonPanel1.Text = ""
        '
        'btnNew
        '
        Me.btnNew.Image = Global.Aplicacion.My.Resources.Resources.ic_New
        Me.btnNew.SmallImage = CType(resources.GetObject("btnNew.SmallImage"), System.Drawing.Image)
        Me.btnNew.Text = "Nuevo"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Aplicacion.My.Resources.Resources.ic_Save
        Me.btnSave.SmallImage = CType(resources.GetObject("btnSave.SmallImage"), System.Drawing.Image)
        Me.btnSave.Text = "Guardar"
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.btnSearch.SmallImage = CType(resources.GetObject("btnSearch.SmallImage"), System.Drawing.Image)
        Me.btnSearch.Text = "Buscar"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(669, 200)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(51, 17)
        Me.lblID.TabIndex = 123
        Me.lblID.Text = "Label1"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Aplicacion.My.Resources.Resources.ic_Cancel
        Me.btnDelete.SmallImage = CType(resources.GetObject("btnDelete.SmallImage"), System.Drawing.Image)
        Me.btnDelete.Text = "Borrar"
        '
        'Divisa_Catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 615)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Ribbon1)
        Me.Controls.Add(Me.tABREVIATURA)
        Me.Controls.Add(Me.chkPREDETERMINADO)
        Me.Controls.Add(Me.tFUENTECOTIZACION)
        Me.Controls.Add(Me.tCOTIZACIONUNITARIA)
        Me.Controls.Add(Me.dtFECHAULTIMACOTIZACION)
        Me.Controls.Add(Me.tSIMBOLOMONEDA)
        Me.Controls.Add(Me.tDESCRIPCION)
        Me.Controls.Add(Me.dgv_divisas)
        Me.Controls.Add(Me.lblAbreviacion)
        Me.Controls.Add(Me.lblDivisaPredeterminada)
        Me.Controls.Add(Me.lblfuente)
        Me.Controls.Add(Me.lblcotizacionunitaria)
        Me.Controls.Add(Me.lblfechacotizacion)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblsimbolo)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Name = "Divisa_Catalogo"
        Me.Text = "Catalogo de Divisas"
        CType(Me.dgv_divisas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents lblsimbolo As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblfechacotizacion As System.Windows.Forms.Label
    Friend WithEvents lblcotizacionunitaria As System.Windows.Forms.Label
    Friend WithEvents lblfuente As System.Windows.Forms.Label
    Friend WithEvents lblDivisaPredeterminada As System.Windows.Forms.Label
    Friend WithEvents lblAbreviacion As System.Windows.Forms.Label
    Friend WithEvents dgv_divisas As System.Windows.Forms.DataGridView
    Friend WithEvents tDESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents tSIMBOLOMONEDA As System.Windows.Forms.TextBox
    Friend WithEvents dtFECHAULTIMACOTIZACION As System.Windows.Forms.DateTimePicker
    Friend WithEvents tCOTIZACIONUNITARIA As System.Windows.Forms.TextBox
    Friend WithEvents tFUENTECOTIZACION As System.Windows.Forms.TextBox
    Friend WithEvents chkPREDETERMINADO As System.Windows.Forms.CheckBox
    Friend WithEvents tABREVIATURA As System.Windows.Forms.TextBox
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents RibbonTab1 As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnNew As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSave As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSearch As System.Windows.Forms.RibbonButton
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.RibbonButton
End Class
