<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unidad_Catalogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Unidad_Catalogo))
        Me.tDESCRIPCION = New System.Windows.Forms.TextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dgv_unidad = New System.Windows.Forms.DataGridView()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.rtabGENERAL = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.btnNew = New System.Windows.Forms.RibbonButton()
        Me.btnSave = New System.Windows.Forms.RibbonButton()
        Me.btnSearch = New System.Windows.Forms.RibbonButton()
        Me.btnDelete = New System.Windows.Forms.RibbonButton()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.dgv_unidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tDESCRIPCION
        '
        Me.tDESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDESCRIPCION.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tDESCRIPCION.Location = New System.Drawing.Point(231, 237)
        Me.tDESCRIPCION.Name = "tDESCRIPCION"
        Me.tDESCRIPCION.Size = New System.Drawing.Size(347, 23)
        Me.tDESCRIPCION.TabIndex = 114
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbldescripcion.ForeColor = System.Drawing.Color.White
        Me.lbldescripcion.Location = New System.Drawing.Point(18, 240)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(167, 16)
        Me.lbldescripcion.TabIndex = 113
        Me.lbldescripcion.Text = "Descripcion de Unidad"
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
        Me.Label21.TabIndex = 112
        Me.Label21.Text = "Catalogo de Clasificacion"
        '
        'dgv_unidad
        '
        Me.dgv_unidad.AllowUserToAddRows = False
        Me.dgv_unidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_unidad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_unidad.Location = New System.Drawing.Point(21, 294)
        Me.dgv_unidad.MultiSelect = False
        Me.dgv_unidad.Name = "dgv_unidad"
        Me.dgv_unidad.ReadOnly = True
        Me.dgv_unidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_unidad.Size = New System.Drawing.Size(240, 150)
        Me.dgv_unidad.TabIndex = 115
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
        Me.Ribbon1.Size = New System.Drawing.Size(816, 130)
        Me.Ribbon1.TabIndex = 116
        Me.Ribbon1.Tabs.Add(Me.rtabGENERAL)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        Me.Ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'rtabGENERAL
        '
        Me.rtabGENERAL.Panels.Add(Me.RibbonPanel1)
        Me.rtabGENERAL.Text = "GENERAL"
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
        Me.lblID.Location = New System.Drawing.Point(584, 240)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(51, 17)
        Me.lblID.TabIndex = 117
        Me.lblID.Text = "Label1"
        '
        'Unidad_Catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 459)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Ribbon1)
        Me.Controls.Add(Me.dgv_unidad)
        Me.Controls.Add(Me.tDESCRIPCION)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.Label21)
        Me.Name = "Unidad_Catalogo"
        Me.Text = "Catalogo Unidad"
        CType(Me.dgv_unidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tDESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dgv_unidad As System.Windows.Forms.DataGridView
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
    Friend WithEvents rtabGENERAL As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnNew As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSave As System.Windows.Forms.RibbonButton
    Friend WithEvents btnSearch As System.Windows.Forms.RibbonButton
    Friend WithEvents btnDelete As System.Windows.Forms.RibbonButton
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
