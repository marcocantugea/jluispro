<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unidad_Buscar
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
        Me.chkValue = New System.Windows.Forms.CheckBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txttexto = New System.Windows.Forms.TextBox()
        Me.lblbuscar = New System.Windows.Forms.Label()
        Me.cmbCampos = New System.Windows.Forms.ComboBox()
        Me.ldlselcampo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkValue
        '
        Me.chkValue.AutoSize = True
        Me.chkValue.Location = New System.Drawing.Point(70, 91)
        Me.chkValue.Name = "chkValue"
        Me.chkValue.Size = New System.Drawing.Size(18, 17)
        Me.chkValue.TabIndex = 17
        Me.chkValue.UseVisualStyleBackColor = True
        Me.chkValue.Visible = False
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(15, 88)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(95, 22)
        Me.dtFecha.TabIndex = 16
        Me.dtFecha.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.Location = New System.Drawing.Point(15, 117)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(388, 39)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'txttexto
        '
        Me.txttexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttexto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txttexto.Location = New System.Drawing.Point(15, 88)
        Me.txttexto.Name = "txttexto"
        Me.txttexto.Size = New System.Drawing.Size(388, 23)
        Me.txttexto.TabIndex = 14
        Me.txttexto.Visible = False
        '
        'lblbuscar
        '
        Me.lblbuscar.AutoSize = True
        Me.lblbuscar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblbuscar.ForeColor = System.Drawing.Color.White
        Me.lblbuscar.Location = New System.Drawing.Point(12, 57)
        Me.lblbuscar.Name = "lblbuscar"
        Me.lblbuscar.Size = New System.Drawing.Size(61, 16)
        Me.lblbuscar.TabIndex = 13
        Me.lblbuscar.Text = "Buscar:"
        Me.lblbuscar.Visible = False
        '
        'cmbCampos
        '
        Me.cmbCampos.FormattingEnabled = True
        Me.cmbCampos.Location = New System.Drawing.Point(239, 13)
        Me.cmbCampos.Name = "cmbCampos"
        Me.cmbCampos.Size = New System.Drawing.Size(164, 24)
        Me.cmbCampos.TabIndex = 12
        '
        'ldlselcampo
        '
        Me.ldlselcampo.AutoSize = True
        Me.ldlselcampo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ldlselcampo.ForeColor = System.Drawing.Color.White
        Me.ldlselcampo.Location = New System.Drawing.Point(12, 16)
        Me.ldlselcampo.Name = "ldlselcampo"
        Me.ldlselcampo.Size = New System.Drawing.Size(221, 16)
        Me.ldlselcampo.TabIndex = 11
        Me.ldlselcampo.Text = "Seleccione el campo a buscar:"
        '
        'Unidad_Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(415, 168)
        Me.Controls.Add(Me.chkValue)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txttexto)
        Me.Controls.Add(Me.lblbuscar)
        Me.Controls.Add(Me.cmbCampos)
        Me.Controls.Add(Me.ldlselcampo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(423, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(423, 200)
        Me.Name = "Unidad_Buscar"
        Me.Text = "Buscar Unidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkValue As System.Windows.Forms.CheckBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txttexto As System.Windows.Forms.TextBox
    Friend WithEvents lblbuscar As System.Windows.Forms.Label
    Friend WithEvents cmbCampos As System.Windows.Forms.ComboBox
    Friend WithEvents ldlselcampo As System.Windows.Forms.Label
End Class
