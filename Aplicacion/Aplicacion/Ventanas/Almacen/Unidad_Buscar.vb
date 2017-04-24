Public Class Unidad_Buscar

    Dim _campos As New List(Of String)
    Dim _tipocampo As New List(Of String)
    Dim _titulocampo As New List(Of String)
    Dim _camposelecionado As String = ""
    Dim _tiposelecionado As String = ""

    Private Sub ConfiguraCampos()
        _campos.Add("unidad_Descripcion")
        _tipocampo.Add("String")
        _titulocampo.Add("Descripcion")

    End Sub

    Private Sub Unidad_Buscar_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim _form_unidad_catalogo As Unidad_Catalogo = My.Application.OpenForms("Unidad_Catalogo")
        _form_unidad_catalogo.dgv_unidad.Rows.Clear()
        _form_unidad_catalogo.LoadDataGridInfo()
    End Sub

    Private Sub Unidad_Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                txttexto.Focus()
            Case "Date"
                dtFecha.Visible = True
            Case "boolean"
                chkValue.Visible = True
            Case "decimal"
                txttexto.Visible = True
                txttexto.Focus()
        End Select

        If btnSearch.Visible = False Then
            btnSearch.Visible = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'variable para detectar errores de captura
        Dim errores As Boolean = False
        'busca el formulario padre de divisas para cambiar el gridview
        Dim _form_unidad_catalogo As Unidad_Catalogo = My.Application.OpenForms("Unidad_Catalogo")

        '_form_unidad_catalogo.dgv_unidad.Rows.Clear()

        'Se selecionan los campos a cargar en el datagrid
        Dim campos As New List(Of String)
        campos.Add("unidad_Id")
        campos.Add("unidad_Descripcion")
        campos.Add("unidad_activo")

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
            _form_unidad_catalogo.dgv_unidad.Rows.Clear()
            'Obtiene los datos de la base de datos
            Dim dtsresult As DataSet
            dtsresult = _form_unidad_catalogo.AlmacenCls.SelUnidad(campos, consulta)
            'Carga info en el datagrid

            'Carga info en el datagrid
            For Each dr As DataRow In dtsresult.Tables(0).Rows
                Dim row As String() = New String() {dr.Item(1).ToString, dr.Item(0)}
                _form_unidad_catalogo.dgv_unidad.Rows.Add(row)
            Next
        End If
    End Sub
End Class