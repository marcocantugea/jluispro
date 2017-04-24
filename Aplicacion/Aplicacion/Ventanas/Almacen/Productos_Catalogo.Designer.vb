<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos_Catalogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos_Catalogo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblimageid = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblfilename = New System.Windows.Forms.Label()
        Me.lblidclasificacion = New System.Windows.Forms.Label()
        Me.lblidunidad = New System.Windows.Forms.Label()
        Me.tdiasparasurtir = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAddNewPhoto = New System.Windows.Forms.Button()
        Me.pboxImageProducto = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tunidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tclasificacion = New System.Windows.Forms.TextBox()
        Me.tmaximo = New System.Windows.Forms.TextBox()
        Me.tminimo = New System.Windows.Forms.TextBox()
        Me.tlocacion = New System.Windows.Forms.TextBox()
        Me.tprecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tespecificacionproducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdescripciondeproducto = New System.Windows.Forms.TextBox()
        Me.tclavefabricante = New System.Windows.Forms.TextBox()
        Me.tclaveproducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblclavefabricante = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.rtabGeneral = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnNew = New System.Windows.Forms.RibbonButton()
        Me.btnSave = New System.Windows.Forms.RibbonButton()
        Me.btnSearch = New System.Windows.Forms.RibbonButton()
        Me.btnDelete = New System.Windows.Forms.RibbonButton()
        Me.dgv_productos = New System.Windows.Forms.DataGridView()
        Me.ofd_ImageSave = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.pboxImageProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblimageid)
        Me.Panel1.Controls.Add(Me.lblid)
        Me.Panel1.Controls.Add(Me.lblfilename)
        Me.Panel1.Controls.Add(Me.lblidclasificacion)
        Me.Panel1.Controls.Add(Me.lblidunidad)
        Me.Panel1.Controls.Add(Me.tdiasparasurtir)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnAddNewPhoto)
        Me.Panel1.Controls.Add(Me.pboxImageProducto)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.tunidad)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.tclasificacion)
        Me.Panel1.Controls.Add(Me.tmaximo)
        Me.Panel1.Controls.Add(Me.tminimo)
        Me.Panel1.Controls.Add(Me.tlocacion)
        Me.Panel1.Controls.Add(Me.tprecio)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tespecificacionproducto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tdescripciondeproducto)
        Me.Panel1.Controls.Add(Me.tclavefabricante)
        Me.Panel1.Controls.Add(Me.tclaveproducto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblclavefabricante)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Ribbon1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 385)
        Me.Panel1.TabIndex = 0
        '
        'lblimageid
        '
        Me.lblimageid.AutoSize = True
        Me.lblimageid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblimageid.Location = New System.Drawing.Point(14, 358)
        Me.lblimageid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblimageid.Name = "lblimageid"
        Me.lblimageid.Size = New System.Drawing.Size(45, 13)
        Me.lblimageid.TabIndex = 141
        Me.lblimageid.Text = "Label11"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblid.Location = New System.Drawing.Point(702, 141)
        Me.lblid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(45, 13)
        Me.lblid.TabIndex = 140
        Me.lblid.Text = "Label11"
        '
        'lblfilename
        '
        Me.lblfilename.AutoSize = True
        Me.lblfilename.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblfilename.ForeColor = System.Drawing.Color.White
        Me.lblfilename.Location = New System.Drawing.Point(11, 338)
        Me.lblfilename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfilename.MaximumSize = New System.Drawing.Size(112, 0)
        Me.lblfilename.Name = "lblfilename"
        Me.lblfilename.Size = New System.Drawing.Size(0, 14)
        Me.lblfilename.TabIndex = 139
        '
        'lblidclasificacion
        '
        Me.lblidclasificacion.AutoSize = True
        Me.lblidclasificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblidclasificacion.Location = New System.Drawing.Point(703, 332)
        Me.lblidclasificacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblidclasificacion.Name = "lblidclasificacion"
        Me.lblidclasificacion.Size = New System.Drawing.Size(45, 13)
        Me.lblidclasificacion.TabIndex = 138
        Me.lblidclasificacion.Text = "Label11"
        '
        'lblidunidad
        '
        Me.lblidunidad.AutoSize = True
        Me.lblidunidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblidunidad.Location = New System.Drawing.Point(703, 176)
        Me.lblidunidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblidunidad.Name = "lblidunidad"
        Me.lblidunidad.Size = New System.Drawing.Size(45, 13)
        Me.lblidunidad.TabIndex = 137
        Me.lblidunidad.Text = "Label11"
        '
        'tdiasparasurtir
        '
        Me.tdiasparasurtir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tdiasparasurtir.Location = New System.Drawing.Point(575, 359)
        Me.tdiasparasurtir.Margin = New System.Windows.Forms.Padding(2)
        Me.tdiasparasurtir.Name = "tdiasparasurtir"
        Me.tdiasparasurtir.Size = New System.Drawing.Size(94, 20)
        Me.tdiasparasurtir.TabIndex = 136
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(478, 359)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 14)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Dias Para Surtir"
        '
        'btnAddNewPhoto
        '
        Me.btnAddNewPhoto.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddNewPhoto.Location = New System.Drawing.Point(9, 304)
        Me.btnAddNewPhoto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddNewPhoto.Name = "btnAddNewPhoto"
        Me.btnAddNewPhoto.Size = New System.Drawing.Size(106, 28)
        Me.btnAddNewPhoto.TabIndex = 134
        Me.btnAddNewPhoto.Text = "Agregar Foto"
        Me.btnAddNewPhoto.UseVisualStyleBackColor = False
        '
        'pboxImageProducto
        '
        Me.pboxImageProducto.BackColor = System.Drawing.Color.Silver
        Me.pboxImageProducto.Location = New System.Drawing.Point(9, 181)
        Me.pboxImageProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.pboxImageProducto.Name = "pboxImageProducto"
        Me.pboxImageProducto.Size = New System.Drawing.Size(106, 117)
        Me.pboxImageProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxImageProducto.TabIndex = 133
        Me.pboxImageProducto.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(673, 167)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 28)
        Me.Button2.TabIndex = 132
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tunidad
        '
        Me.tunidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tunidad.Location = New System.Drawing.Point(575, 175)
        Me.tunidad.Margin = New System.Windows.Forms.Padding(2)
        Me.tunidad.Name = "tunidad"
        Me.tunidad.ReadOnly = True
        Me.tunidad.Size = New System.Drawing.Size(94, 20)
        Me.tunidad.TabIndex = 131
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(478, 176)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 14)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Unidad"
        '
        'Button1
        '
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(673, 323)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 28)
        Me.Button1.TabIndex = 129
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tclasificacion
        '
        Me.tclasificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tclasificacion.Location = New System.Drawing.Point(575, 330)
        Me.tclasificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.tclasificacion.Name = "tclasificacion"
        Me.tclasificacion.ReadOnly = True
        Me.tclasificacion.Size = New System.Drawing.Size(94, 20)
        Me.tclasificacion.TabIndex = 128
        '
        'tmaximo
        '
        Me.tmaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tmaximo.Location = New System.Drawing.Point(575, 300)
        Me.tmaximo.Margin = New System.Windows.Forms.Padding(2)
        Me.tmaximo.Name = "tmaximo"
        Me.tmaximo.Size = New System.Drawing.Size(124, 20)
        Me.tmaximo.TabIndex = 127
        '
        'tminimo
        '
        Me.tminimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tminimo.Location = New System.Drawing.Point(575, 266)
        Me.tminimo.Margin = New System.Windows.Forms.Padding(2)
        Me.tminimo.Name = "tminimo"
        Me.tminimo.Size = New System.Drawing.Size(124, 20)
        Me.tminimo.TabIndex = 126
        '
        'tlocacion
        '
        Me.tlocacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlocacion.Location = New System.Drawing.Point(575, 235)
        Me.tlocacion.Margin = New System.Windows.Forms.Padding(2)
        Me.tlocacion.Name = "tlocacion"
        Me.tlocacion.Size = New System.Drawing.Size(124, 20)
        Me.tlocacion.TabIndex = 125
        '
        'tprecio
        '
        Me.tprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tprecio.Location = New System.Drawing.Point(575, 206)
        Me.tprecio.Margin = New System.Windows.Forms.Padding(2)
        Me.tprecio.Name = "tprecio"
        Me.tprecio.Size = New System.Drawing.Size(124, 20)
        Me.tprecio.TabIndex = 124
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(478, 332)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 14)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Clasificacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(478, 301)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 14)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Cantidad Maxima"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(478, 271)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 14)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Cantidad Minima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(478, 240)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 14)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Locacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(478, 208)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 14)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Precio"
        '
        'tespecificacionproducto
        '
        Me.tespecificacionproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tespecificacionproducto.Location = New System.Drawing.Point(276, 312)
        Me.tespecificacionproducto.Margin = New System.Windows.Forms.Padding(2)
        Me.tespecificacionproducto.Multiline = True
        Me.tespecificacionproducto.Name = "tespecificacionproducto"
        Me.tespecificacionproducto.Size = New System.Drawing.Size(186, 69)
        Me.tespecificacionproducto.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(126, 314)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 14)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Especificacion de Producto"
        '
        'tdescripciondeproducto
        '
        Me.tdescripciondeproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tdescripciondeproducto.Location = New System.Drawing.Point(276, 238)
        Me.tdescripciondeproducto.Margin = New System.Windows.Forms.Padding(2)
        Me.tdescripciondeproducto.Multiline = True
        Me.tdescripciondeproducto.Name = "tdescripciondeproducto"
        Me.tdescripciondeproducto.Size = New System.Drawing.Size(186, 69)
        Me.tdescripciondeproducto.TabIndex = 116
        '
        'tclavefabricante
        '
        Me.tclavefabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tclavefabricante.Location = New System.Drawing.Point(276, 206)
        Me.tclavefabricante.Margin = New System.Windows.Forms.Padding(2)
        Me.tclavefabricante.Name = "tclavefabricante"
        Me.tclavefabricante.Size = New System.Drawing.Size(186, 20)
        Me.tclavefabricante.TabIndex = 115
        '
        'tclaveproducto
        '
        Me.tclaveproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tclaveproducto.Location = New System.Drawing.Point(276, 174)
        Me.tclaveproducto.Margin = New System.Windows.Forms.Padding(2)
        Me.tclaveproducto.Name = "tclaveproducto"
        Me.tclaveproducto.Size = New System.Drawing.Size(186, 20)
        Me.tclaveproducto.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(126, 240)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 14)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Descripcion de Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(126, 176)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 14)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Clave de Producto"
        '
        'lblclavefabricante
        '
        Me.lblclavefabricante.AutoSize = True
        Me.lblclavefabricante.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblclavefabricante.ForeColor = System.Drawing.Color.White
        Me.lblclavefabricante.Location = New System.Drawing.Point(126, 208)
        Me.lblclavefabricante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblclavefabricante.Name = "lblclavefabricante"
        Me.lblclavefabricante.Size = New System.Drawing.Size(114, 14)
        Me.lblclavefabricante.TabIndex = 111
        Me.lblclavefabricante.Text = "Clave de Fabricante"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(10, 119)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(342, 35)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = "Catalogo de Productos"
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Tahoma", 8.400001!, System.Drawing.FontStyle.Bold)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Ribbon1.OrbText = "File"
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(770, 106)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.rtabGeneral)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        Me.Ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'rtabGeneral
        '
        Me.rtabGeneral.Panels.Add(Me.RibbonPanel1)
        Me.rtabGeneral.Text = "GENERAL"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.btnNew)
        Me.RibbonPanel1.Items.Add(Me.btnSave)
        Me.RibbonPanel1.Items.Add(Me.btnSearch)
        Me.RibbonPanel1.Items.Add(Me.btnDelete)
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
        Me.btnSave.Image = Global.Aplicacion.My.Resources.Resources.ic_Save
        Me.btnSave.SmallImage = CType(resources.GetObject("btnSave.SmallImage"), System.Drawing.Image)
        Me.btnSave.Text = "Guardar"
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.btnSearch.SmallImage = Global.Aplicacion.My.Resources.Resources.ic_Search
        Me.btnSearch.Text = "Buscar"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Aplicacion.My.Resources.Resources.ic_Cancel
        Me.btnDelete.SmallImage = CType(resources.GetObject("btnDelete.SmallImage"), System.Drawing.Image)
        Me.btnDelete.Text = "Borrar"
        '
        'dgv_productos
        '
        Me.dgv_productos.AllowUserToAddRows = False
        Me.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_productos.Location = New System.Drawing.Point(0, 385)
        Me.dgv_productos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_productos.Name = "dgv_productos"
        Me.dgv_productos.RowTemplate.Height = 24
        Me.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_productos.Size = New System.Drawing.Size(770, 118)
        Me.dgv_productos.TabIndex = 1
        '
        'ofd_ImageSave
        '
        Me.ofd_ImageSave.DefaultExt = "jpg"
        Me.ofd_ImageSave.Title = "Select image"
        '
        'Productos_Catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 503)
        Me.Controls.Add(Me.dgv_productos)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Productos_Catalogo"
        Me.Text = "Catalogo de Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pboxImageProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgv_productos As System.Windows.Forms.DataGridView
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents rtabGeneral As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnNew As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSave As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSearch As System.Windows.Forms.RibbonButton
    Friend WithEvents btnDelete As System.Windows.Forms.RibbonButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tespecificacionproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tdescripciondeproducto As System.Windows.Forms.TextBox
    Friend WithEvents tclavefabricante As System.Windows.Forms.TextBox
    Friend WithEvents tclaveproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblclavefabricante As System.Windows.Forms.Label
    Friend WithEvents btnAddNewPhoto As System.Windows.Forms.Button
    Friend WithEvents pboxImageProducto As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tunidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tclasificacion As System.Windows.Forms.TextBox
    Friend WithEvents tmaximo As System.Windows.Forms.TextBox
    Friend WithEvents tminimo As System.Windows.Forms.TextBox
    Friend WithEvents tlocacion As System.Windows.Forms.TextBox
    Friend WithEvents tprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ofd_ImageSave As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tdiasparasurtir As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblidunidad As System.Windows.Forms.Label
    Friend WithEvents lblidclasificacion As System.Windows.Forms.Label
    Friend WithEvents lblfilename As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblimageid As System.Windows.Forms.Label
End Class
