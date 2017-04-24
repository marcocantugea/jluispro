<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clasificacion_Catalogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clasificacion_Catalogo))
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.tDESCRIPCION = New System.Windows.Forms.TextBox()
        Me.dgv_clasificacion = New System.Windows.Forms.DataGridView()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.rtabGeneral = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnNew = New System.Windows.Forms.RibbonButton()
        Me.btnSave = New System.Windows.Forms.RibbonButton()
        Me.btnSearch = New System.Windows.Forms.RibbonButton()
        Me.btnDelete = New System.Windows.Forms.RibbonButton()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.dgv_clasificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(13, 160)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(474, 44)
        Me.Label21.TabIndex = 109
        Me.Label21.Text = "Catalogo de Clasificacion"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbldescripcion.ForeColor = System.Drawing.Color.White
        Me.lbldescripcion.Location = New System.Drawing.Point(18, 240)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(207, 16)
        Me.lbldescripcion.TabIndex = 110
        Me.lbldescripcion.Text = "Descripcion de Clasificacion"
        '
        'tDESCRIPCION
        '
        Me.tDESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tDESCRIPCION.Location = New System.Drawing.Point(231, 237)
        Me.tDESCRIPCION.Name = "tDESCRIPCION"
        Me.tDESCRIPCION.Size = New System.Drawing.Size(347, 23)
        Me.tDESCRIPCION.TabIndex = 111
        '
        'dgv_clasificacion
        '
        Me.dgv_clasificacion.AllowUserToAddRows = False
        Me.dgv_clasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clasificacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_clasificacion.Location = New System.Drawing.Point(21, 294)
        Me.dgv_clasificacion.MultiSelect = False
        Me.dgv_clasificacion.Name = "dgv_clasificacion"
        Me.dgv_clasificacion.ReadOnly = True
        Me.dgv_clasificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clasificacion.Size = New System.Drawing.Size(240, 150)
        Me.dgv_clasificacion.TabIndex = 114
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
        Me.Ribbon1.Size = New System.Drawing.Size(843, 130)
        Me.Ribbon1.TabIndex = 113
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
        Me.btnSearch.SmallImage = CType(resources.GetObject("btnSearch.SmallImage"), System.Drawing.Image)
        Me.btnSearch.Text = "Buscar"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Aplicacion.My.Resources.Resources.ic_Cancel
        Me.btnDelete.SmallImage = CType(resources.GetObject("btnDelete.SmallImage"), System.Drawing.Image)
        Me.btnDelete.Text = "Borrar"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblID.Location = New System.Drawing.Point(596, 240)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(51, 17)
        Me.lblID.TabIndex = 114
        Me.lblID.Text = "Label1"
        '
        'Clasificacion_Catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 468)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Ribbon1)
        Me.Controls.Add(Me.dgv_clasificacion)
        Me.Controls.Add(Me.tDESCRIPCION)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.Label21)
        Me.Name = "Clasificacion_Catalogo"
        Me.Text = "Catalogo Clasificacion"
        CType(Me.dgv_clasificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents tDESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents dgv_clasificacion As System.Windows.Forms.DataGridView
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents rtabGeneral As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnNew As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSave As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSearch As System.Windows.Forms.RibbonButton
    Friend WithEvents btnDelete As System.Windows.Forms.RibbonButton
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
