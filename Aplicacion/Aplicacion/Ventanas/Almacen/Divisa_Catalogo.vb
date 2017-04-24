Public Class Divisa_Catalogo

    Private _AlmacenCls As New AlmacenCls
    Private _campos As List(Of String)
    Private _valores As List(Of String)
    'variable para configurar el formulario
    'para edicion, nuevo registro
    ' valor 1 para nuevo registro
    ' valor 2 para editar registro
    Private _setform As Integer = 0

    ReadOnly Property AlmacenCls As AlmacenCls
        Get
            Return _AlmacenCls
        End Get
    End Property

    Private Sub Divisa_Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridInfo()
        Divisa_Catalogo_SizeChanged(Nothing, Nothing)
    End Sub

    Private Sub Divisa_Catalogo_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim windosize As Integer = Me.Width
        Dim windowheigth As Integer = Me.Height
        dgv_divisas.Width = windosize - 50
        dgv_divisas.Height = windowheigth - 490
    End Sub

    Private Sub Save_RibbonButton(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim val_descripcion As String = "'" & tDESCRIPCION.Text & "'"
        Dim val_simbolo As String = "'" & tSIMBOLOMONEDA.Text & "'"
        Dim convertdate As Date = Date.Parse(dtFECHAULTIMACOTIZACION.Text)
        Dim val_fechaultimacotizacion As String = "'" & convertdate.ToString("yyyy-MM-dd") & "'"
        Dim val_fuentecotizacion As String = "'" & tFUENTECOTIZACION.Text & "'"
        Dim val_cotizacionunitaria As String = tCOTIZACIONUNITARIA.Text
        Dim val_divisapredeterminada As String = ""
        If chkPREDETERMINADO.Checked Then
            val_divisapredeterminada = "1"
        Else
            val_divisapredeterminada = "0"
        End If
        Dim val_abreviatura As String = "'" & tABREVIATURA.Text & "'"

        Dim campos As New List(Of String)
        Dim values As New List(Of String)

        campos.Add("divisa_DESCRIPCION")
        values.Add(val_descripcion.ToString)

        campos.Add("divisa_SIMBOLO_MONEDA")
        values.Add(val_simbolo)

        campos.Add("divisa_FECHA_ULTIMA_COTIZACION")
        values.Add(val_fechaultimacotizacion)

        If val_cotizacionunitaria <> "" Then
            campos.Add("divisa_COTIZACION_UNITARIA")
            values.Add(val_cotizacionunitaria)
        Else
            val_cotizacionunitaria = 1
            campos.Add("divisa_COTIZACION_UNITARIA")
            values.Add(val_cotizacionunitaria)
        End If

        If val_fuentecotizacion <> "" Then
            campos.Add("divisa_FUENTE_COTIZACION")
            values.Add(val_fuentecotizacion)
        Else
            campos.Add("divisa_FUENTE_COTIZACION")
            values.Add("''")
        End If


        campos.Add("divisa_PREDETERMINADO")
        values.Add(val_divisapredeterminada)

        If val_abreviatura <> "" Then
            campos.Add("divisa_ABREVIATURA")
            values.Add(val_abreviatura)
        Else
            campos.Add("divisa_ABREVIATURA")
            values.Add("''")
        End If

        Select Case _setform
            Case 1
                Try
                    campos.Add("divisa_activo")
                    values.Add("1")
                    _AlmacenCls.InsertaDivisa(campos, values)
                    MsgBox("Registro Agregado Con Exito.", MsgBoxStyle.Information, "Registro Guardado")
                Catch ex As Exception
                    MsgBox("Error al guardar el registro Error:" & ex.Message, MsgBoxStyle.Critical)
                End Try
                dgv_divisas.Rows.Clear()
                LoadDataGridInfo()
            Case 2
                Dim val_id As Integer = Integer.Parse(lblID.Text)
                Try
                    _AlmacenCls.ActualizaDivisa(campos, values, val_id)
                Catch ex As Exception
                    MsgBox("Error al guardar el registro Error:" & ex.Message, MsgBoxStyle.Critical)
                End Try

                dgv_divisas.Rows.Clear()
                LoadDataGridInfo()
        End Select

        _setform = 0
    End Sub

    Private Sub NewRecord_RibbonButton(sender As Object, e As EventArgs) Handles btnNew.Click
        'limpia los campos para nueva captura
        tDESCRIPCION.Text = ""
        tSIMBOLOMONEDA.Text = ""
        lblID.Text = ""
        dtFECHAULTIMACOTIZACION.Text = Date.Now.ToString
        tCOTIZACIONUNITARIA.Text = ""
        tFUENTECOTIZACION.Text = ""
        chkPREDETERMINADO.Checked = False
        tABREVIATURA.Text = ""
        tDESCRIPCION.Focus()
        'configura el formulario como nuevo formulario
        _setform = 1
    End Sub

    Private Sub SearchRecord_RibbonButton(sender As Object, e As EventArgs) Handles btnSearch.Click
        'revisa si el formulario de buscar esta abierto
        Dim frm_buscar As Divisa_Buscar = My.Application.OpenForms("Divisa_Buscar")
        'si el formulario existe solo lo manda a llamar a enfrente
        'de lo contrario crea nuevo formulario y lo muestra.
        If Not IsNothing(frm_buscar) Then
            frm_buscar.Focus()
        Else
            frm_buscar = New Divisa_Buscar
            frm_buscar.Show()
        End If

    End Sub

    Private Sub DeleteRecord_RibbonButton(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MsgBox("Desea Borrar el registro seleccionado?", MsgBoxStyle.OkCancel, "Borrar Registro")
        If result = vbOK Then
            'obtiene el id seleccionado
            Dim id As Integer = Integer.Parse(lblID.Text)
            _AlmacenCls.BorrarDivisa(id)
            dgv_divisas.Rows.Clear()
            LoadDataGridInfo()
        End If
    End Sub

    Public Sub ConfigureDataGrid()
        'Se configura el data grid
        dgv_divisas.ColumnCount = 8
        dgv_divisas.Columns(0).Name = "Descripcion Divisa"
        dgv_divisas.Columns(1).Name = "Simbolo"
        dgv_divisas.Columns(2).Name = "Fecha ultima Cotizacion"
        dgv_divisas.Columns(3).Name = "Cotizacion Unitaria"
        dgv_divisas.Columns(4).Name = "Fuente de Cotizacion"
        dgv_divisas.Columns(5).Name = "Prederterminada"
        dgv_divisas.Columns(6).Name = "Abreviatura"
        dgv_divisas.Columns(7).Name = "ID"

        dgv_divisas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_divisas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub

    Public Sub LoadDataGridInfo()
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

        'Obtiene los datos de la base de datos
        Dim dtsresult As DataSet
        dtsresult = _AlmacenCls.SelDivisas(campos, "divisa_id >0 and divisa_activo=1")

        'Se configura el data grid
        ConfigureDataGrid()

        'si no hay registros selecciona el formulario en modo de nuevo registro
        If dtsresult.Tables(0).Rows.Count = 0 Then
            _setform = 1
        End If



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
            dgv_divisas.Rows.Add(row)
        Next


    End Sub

    Public Sub SelectDataFromDataGridSelected()
        'MsgBox(dgv_divisas.SelectedCells.Item(0).Value)
        Try
            'Llena los campos de acuerdo con lo que se selecione en el datagridview
            tDESCRIPCION.Text = dgv_divisas.SelectedCells.Item(0).Value
            tSIMBOLOMONEDA.Text = dgv_divisas.SelectedCells.Item(1).Value

            'Revisa La Fecha del control datagridview para si tienene valores.
            Try
                Dim val As Date = dgv_divisas.SelectedCells.Item(2).Value
                dtFECHAULTIMACOTIZACION.Text = val
            Catch ex As Exception
                'MsgBox(dgv_divisas.SelectedCells.Item(2).Value)
            End Try

            tFUENTECOTIZACION.Text = dgv_divisas.SelectedCells.Item(4).Value
            tCOTIZACIONUNITARIA.Text = dgv_divisas.SelectedCells.Item(3).Value

            'revisa si es predeterminado
            'si esta predetermnado le pone la marca al checkbox
            'Debug.WriteLine(dgv_divisas.SelectedCells.Item(5).Value)
            Dim predeterminado As String = dgv_divisas.SelectedCells.Item(5).Value
            If predeterminado = "Si" Then
                chkPREDETERMINADO.Checked = True
            Else
                chkPREDETERMINADO.Checked = False
            End If

            tABREVIATURA.Text = dgv_divisas.SelectedCells.Item(6).Value
            lblID.Text = dgv_divisas.SelectedCells.Item(7).Value

            'Configura el formulario en modo de edicio
            _setform = 2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_divisas_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_divisas.SelectionChanged
        SelectDataFromDataGridSelected()
    End Sub
End Class