Public Class Divisa_Buscar
    Dim _campos As New List(Of String)
    Dim _tipocampo As New List(Of String)
    Dim _titulocampo As New List(Of String)
    Dim _camposelecionado As String = ""
    Dim _tiposelecionado As String = ""

    Private Sub ConfiguraCampos()
        'Se selecionan los campos a cargar 
        '_campos.Add("divisa_id")
        _campos.Add("divisa_DESCRIPCION")
        _tipocampo.Add("String")
        _titulocampo.Add("Descripcion Divisa")

        _campos.Add("divisa_SIMBOLO_MONEDA")
        _tipocampo.Add("String")
        _titulocampo.Add("Simbolo")

        _campos.Add("divisa_FECHA_ULTIMA_COTIZACION")
        _tipocampo.Add("Date")
        _titulocampo.Add("Fecha ultima Cotizacion")

        _campos.Add("divisa_COTIZACION_UNITARIA")
        _tipocampo.Add("decimal")
        _titulocampo.Add("Cotizacion Unitaria")

        _campos.Add("divisa_FUENTE_COTIZACION")
        _tipocampo.Add("String")
        _titulocampo.Add("Fuente de Cotizacion")

        _campos.Add("divisa_PREDETERMINADO")
        _tipocampo.Add("boolean")
        _titulocampo.Add("Prederterminada")

        _campos.Add("divisa_ABREVIATURA")
        _tipocampo.Add("String")
        _titulocampo.Add("Abreviatura")

        '_campos.Add("divisa_activo")

    End Sub

    Private Sub Divisa_Buscar_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        'busca el formulario padre de divisas para cambiar el gridview
        Dim _form_divisa_catalogo As Divisa_Catalogo = My.Application.OpenForms("Divisa_Catalogo")
        _form_divisa_catalogo.dgv_divisas.Rows.Clear()
        _form_divisa_catalogo.LoadDataGridInfo()

    End Sub

    Private Sub Divisa_Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga los campos
        ConfiguraCampos()
        'Carga los titulos en Combobox
        LoadCamposEnComboBox()
    End Sub

    Public Sub LoadCamposEnComboBox()
        cmbCampos.Items.AddRange(_titulocampo.ToArray)
    End Sub

    Private Sub cmbCampos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCampos.SelectedIndexChanged
        'oculta elementos para hacer la busqueda.
        txttexto.Visible = False
        dtFecha.Visible = False
        chkValue.Visible = False

        Dim selecteditem As String = cmbCampos.SelectedItem
        Dim indexcamposelected As Integer = _titulocampo.IndexOf(selecteditem)
        _camposelecionado = _campos(indexcamposelected)
        _tiposelecionado = _tipocampo(indexcamposelected)
        lblbuscar.Visible = True
        Select Case _tiposelecionado
            Case "String"
                txttexto.Visible = True
            Case "Date"
                dtFecha.Visible = True
            Case "boolean"
                chkValue.Visible = True
            Case "decimal"
                txttexto.Visible = True
        End Select

        If btnSearch.Visible = False Then
            btnSearch.Visible = True
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'variable para detectar errores de captura
        Dim errores As Boolean = False
        'busca el formulario padre de divisas para cambiar el gridview
        Dim _form_divisa_catalogo As Divisa_Catalogo = My.Application.OpenForms("Divisa_Catalogo")

        'Se selecionan los campos a cargar en el datagrid
        Dim campos As New List(Of String)
        campos.Add("divisa_id")
        campos.Add("divisa_DESCRIPCION")
        campos.Add("divisa_SIMBOLO_MONEDA")
        campos.Add("divisa_FECHA_ULTIMA_COTIZACION")
        campos.Add("divisa_COTIZACION_UNITARIA")
        campos.Add("divisa_FUENTE_COTIZACION")
        campos.Add("divisa_PREDETERMINADO")
        campos.Add("divisa_ABREVIATURA")
        campos.Add("divisa_activo")
        'variable para generar la consulta
        Dim consulta As String = ""
        consulta = _camposelecionado
        'De acuerdo al tipo de campo, se genera la consulta
        Select Case _tiposelecionado
            Case "String"
                Dim textoabuscar = txttexto.Text
                consulta = consulta & " like ('%" & textoabuscar & "%')"
            Case "decimal"
                Dim textoabuscar = txttexto.Text
                Try
                    If Not IsNumeric(textoabuscar) Then
                        Throw New Exception("Error en busqueda, dato no numerico")
                    Else
                        consulta = consulta & "=" & textoabuscar
                    End If
                Catch ex As Exception
                    errores = True
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en Busqueda")
                End Try
            Case "Date"
                Dim textoabuscar = dtFecha.Text
                Dim valuedate As Date = Date.Parse(textoabuscar)
                consulta = consulta & "='" & valuedate.ToString("yyyy-MM-dd") & "'"
            Case "boolean"
                If chkValue.Checked Then
                    consulta = consulta & "=1"
                Else
                    consulta = consulta & "=0"
                End If
        End Select

        If Not errores Then
            _form_divisa_catalogo.dgv_divisas.Rows.Clear()
            'Obtiene los datos de la base de datos
            Dim dtsresult As DataSet
            dtsresult = _form_divisa_catalogo.AlmacenCls.SelDivisas(campos, consulta)

            'Carga info en el datagrid

            For Each dr As DataRow In dtsresult.Tables(0).Rows
                'Debug.WriteLine(dr.Item(1).ToString)

                'revisa si el campo divisa_FECHA_ULTIMA_COTIZACION esta vacio
                'si lo esta solo despliega un espacio
                ' de lo contrario muestra la fecha en el formato espanol.
                ' si la fecha es null marca error por que no puede convertirla a fecha.
                Dim fechaUltimaCotizacion As String
                If IsDBNull(dr.Item(3)) Then
                    fechaUltimaCotizacion = ""
                Else
                    fechaUltimaCotizacion = CType(dr.Item(3), Date).ToString("dd/MM/yyyy")
                End If

                'revisa si es divisa predeterminada.
                'si es 1 pondra la palabra Si
                'si es 0 pondra la palabra No
                Dim predeterimandatext As String = ""
                Dim valor As Boolean = dr.Item(6)
                If valor Then
                    predeterimandatext = "Si"
                Else
                    predeterimandatext = "No"
                End If


                Dim row As String() = New String() {dr.Item(1).ToString, dr.Item(2).ToString, fechaUltimaCotizacion, dr.Item(4).ToString, dr.Item(5).ToString, predeterimandatext, dr.Item(7).ToString, dr.Item(0).ToString}
                _form_divisa_catalogo.dgv_divisas.Rows.Add(row)
            Next
        End If

    End Sub
End Class