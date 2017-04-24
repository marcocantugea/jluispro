Public Class Productos_Catalogo

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

    Private Sub Productos_Catalogo_Load(sender As Object, e As EventArgs) Handles Me.Load
        'configura datagridview
        ConfigureDataGrid()
        'carga informacion en datagrid 
        LoadDataGridInfo()
    End Sub

    Private Sub btnAddNewPhoto_Click(sender As Object, e As EventArgs) Handles btnAddNewPhoto.Click
        'ofd_ImageSave.ShowDialog()
        'Dim file_selected As New IO.FileInfo(ofd_ImageSave.FileName)
        'lblfilename.Text = file_selected.Name
        'pboxImageProducto.ImageLocation = file_selected.FullName
        Dim frmimage As New Imagenes_Catalogo
        frmimage.formularioaregresar = Me.Name
        frmimage.nombreconrolidregresar = lblimageid.Name
        frmimage.Show()

    End Sub

    Private Sub btnNew_Ribbon(sender As Object, e As EventArgs) Handles btnNew.Click
        For Each control As Control In Panel1.Controls
            Debug.WriteLine(control.GetType)
            If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
                Dim txtbox As TextBox = CType(control, TextBox)
                If txtbox.Text <> "" Then
                    txtbox.Text = ""
                End If
            End If
        Next
        lblidunidad.Text = ""
        lblidclasificacion.Text = ""
        tclaveproducto.Focus()

        ofd_ImageSave.Reset()
        pboxImageProducto.ImageLocation = ""
        lblfilename.Text = ""

        ' configura el formulario en modo de insertar datos
        _setform = 1
    End Sub

    Private Sub btnSave_Ribbon(sender As Object, e As EventArgs) Handles btnSave.Click
        'obtiene los campos en variables
        Dim save_error As Boolean = False
        Dim mensaje_error As String = ""
        Dim clave_producto As String = "'" & tclaveproducto.Text & "'"
        Dim clave_fabricante As String = "'" & tclavefabricante.Text & "'"
        Dim descripcion As String = "'" & tdescripciondeproducto.Text & "'"
        Dim especificacion As String = "'" & tespecificacionproducto.Text & "'"
        Dim idunidad As Integer = -1

        Try
            idunidad = Integer.Parse(lblidunidad.Text)
        Catch ex As Exception
            save_error = True
            mensaje_error = mensaje_error & "Seleccione una Unidad. "
        End Try
        Dim precio As Double = 0
        Try
            precio = Double.Parse(tprecio.Text)
        Catch ex As Exception
            save_error = True
            mensaje_error = mensaje_error & "Error en el Precio. "
        End Try

        Dim locacion As String = "'" & tlocacion.Text & "'"
        Dim cantidad_minima As Double = 0
        Try
            cantidad_minima = Double.Parse(tminimo.Text)
        Catch ex As Exception
            save_error = True
            mensaje_error = mensaje_error & "Error En Cantidad Minima. "
        End Try

        Dim cantidad_maxima As Double = 0
        Try
            cantidad_maxima = Double.Parse(tmaximo.Text)
        Catch ex As Exception
            save_error = True
            mensaje_error = mensaje_error & "Error En Cantidad Maxima. "
        End Try

        Dim idclasificacion As Integer = -1
        Try
            idclasificacion = Integer.Parse(lblidclasificacion.Text)
        Catch ex As Exception
            save_error = True
            mensaje_error = mensaje_error & "Seleccione una clasificacion. "
        End Try

        Dim diassurtir As Integer = 0
        Try
            diassurtir = Integer.Parse(tdiasparasurtir.Text)
        Catch ex As Exception
            save_error = True
            mensaje_error = mensaje_error & "Error en el Dias a Surtir. "
        End Try

        Dim imageid As Integer = 0
        If lblimageid.Text <> "" Then
            Try
                imageid = Integer.Parse(lblimageid.Text)
            Catch ex As Exception

            End Try
        End If

        Dim campos As New List(Of String)
        Dim valores As New List(Of String)

        If Not save_error Then
            campos.Add("prod_ClaveProducto")
            valores.Add(clave_producto)
            campos.Add("prod_ClaveFabricante")
            valores.Add(clave_fabricante)
            campos.Add("prod_Producto")
            valores.Add(descripcion)
            campos.Add("prod_Especificaciones")
            valores.Add(especificacion)
            campos.Add("unidad_Id")
            valores.Add(idunidad)
            campos.Add("prod_Precio")
            valores.Add(precio)
            campos.Add("prod_Locacion")
            valores.Add(locacion)
            campos.Add("prod_Minimo")
            valores.Add(cantidad_minima)
            campos.Add("prod_Maximo")
            valores.Add(cantidad_maxima)
            campos.Add("clasificacion_Id")
            valores.Add(idclasificacion)
            campos.Add("prod_DiasparaSurtir")
            valores.Add(diassurtir)
            If imageid > 0 Then
                campos.Add("prod_RutaImagen")
                valores.Add(imageid)
            End If

            Select Case _setform
                Case 1
                    Dim fechaagregado As String = "'" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                    campos.Add("prod_Fecha")
                    valores.Add(fechaagregado)
                    campos.Add("prod_Activo")
                    valores.Add("1")
                    Try
                        _AlmacenCls.InsertaProducto(campos, valores)
                        MsgBox("Registro Guardado Exitosamente", MsgBoxStyle.Information, "Registro Guardado")
                        dgv_productos.Rows.Clear()
                        LoadDataGridInfo()
                    Catch ex As Exception
                        MsgBox("Error al guardar el registro: " & ex.Message)
                    End Try
                Case 2
                    Try
                        Dim id As Integer = Integer.Parse(lblid.Text)
                        _AlmacenCls.ActualizaProducto(campos, valores, id)
                        MsgBox("Registro Guardado Exitosamente", MsgBoxStyle.Information, "Registro Guardado")
                        dgv_productos.Rows.Clear()
                        LoadDataGridInfo()
                    Catch ex As Exception
                        MsgBox("Error al guardar el registro: " & ex.Message)
                    End Try

            End Select
        Else
            MsgBox(mensaje_error, MsgBoxStyle.Critical, "Error al guargar el registro")
        End If
    End Sub


    Public Sub ConfigureDataGrid()
        dgv_productos.ColumnCount = 18
        dgv_productos.Columns(0).Name = "Clave de Producto"
        dgv_productos.Columns(1).Name = "Clave de Fabricante"
        dgv_productos.Columns(2).Name = "Descripcion de Producto"
        dgv_productos.Columns(3).Name = "Especificacion de Producto"
        dgv_productos.Columns(4).Name = "Existencias"
        dgv_productos.Columns(5).Name = "Unidad"
        dgv_productos.Columns(6).Name = "Precio"
        dgv_productos.Columns(7).Name = "Locacion"
        dgv_productos.Columns(8).Name = "Cantidad Minima"
        dgv_productos.Columns(9).Name = "Cantidad Maxima"
        dgv_productos.Columns(10).Name = "Clasificacion"
        dgv_productos.Columns(11).Name = "Dias Para Surtir"
        dgv_productos.Columns(12).Name = "Cant. Pendiente Entrega"
        dgv_productos.Columns(13).Name = "ID"
        dgv_productos.Columns(14).Name = "imagen"
        dgv_productos.Columns(15).Name = "id_unidad"
        dgv_productos.Columns(16).Name = "id_clasificacion"
        dgv_productos.Columns(17).Name = "id_imagen"

        dgv_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_productos.Columns(14).Visible = False
        dgv_productos.Columns(15).Visible = False
        dgv_productos.Columns(16).Visible = False
        dgv_productos.Columns(17).Visible = False

    End Sub

    Public Sub LoadDataGridInfo()
        'Configura campos a buscar en base de datos.
        Dim campos As New List(Of String)
        campos.Add("prod_ClaveProducto")
        campos.Add("prod_ClaveFabricante")
        campos.Add("prod_Producto")
        campos.Add("prod_Especificaciones")
        campos.Add("prod_Existencias")
        campos.Add("unidad_Descripcion")
        campos.Add("prod_Precio")
        campos.Add("prod_Locacion")
        campos.Add("prod_Minimo")
        campos.Add("prod_Maximo")
        campos.Add("clasificacion_Descripcion")
        campos.Add("prod_DiasparaSurtir")
        campos.Add("prod_CantidadPendiente")
        campos.Add("prod_Id")
        campos.Add("imagenes_ruta")
        campos.Add("unidad_Id")
        campos.Add("clasificacion_Id")
        campos.Add("prod_RutaImagen")

        'Obtiene los datos de la base de datos
        Dim dtsresult As DataSet
        dtsresult = _AlmacenCls.SelProductos(campos, "prod_Activo=1")

        'si no hay registros selecciona el formulario en modo de nuevo registro
        If dtsresult.Tables(0).Rows.Count = 0 Then
            _setform = 1
        End If

        'Carga info en el datagrid
        For Each dr As DataRow In dtsresult.Tables(0).Rows

            ''Busca la categoria por id
            'Dim catetoria As String = _AlmacenCls.SelClasificacionPorID(Integer.Parse(dr.Item(10).ToString))

            ''Busca la unidad por id
            'Dim unidad As String = _AlmacenCls.SelUnidadPorID(Integer.Parse(dr.Item(5).ToString))

            Dim row As String() = New String() {dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString, dr.Item(4).ToString, dr.Item(5).ToString, dr.Item(6).ToString, dr.Item(7).ToString, dr.Item(8).ToString, dr.Item(9).ToString, dr.Item(10).ToString, dr.Item(11).ToString, dr.Item(12).ToString, dr.Item(13).ToString, dr.Item(14).ToString, dr.Item(15).ToString, dr.Item(16).ToString, dr.Item(17).ToString}
            dgv_productos.Rows.Add(row)
        Next
        dgv_productos.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'revisa si el formulario de buscar esta abierto
        Dim frm_buscar As Busca_Valor = My.Application.OpenForms("Busca_Valor")


        'si el formulario existe solo lo manda a llamar a enfrente
        'de lo contrario crea nuevo formulario y lo muestra.
        If Not IsNothing(frm_buscar) Then
            frm_buscar.formulariopadre = Me.Name
            frm_buscar.campos.Clear()
            frm_buscar.settabla = "cat_Unidades"
            frm_buscar.campos.Add("unidad_Id")
            frm_buscar.campos.Add("unidad_Descripcion")
            frm_buscar.nombrecampoallenar = "tunidad"
            frm_buscar.activofield = "unidad_activo"
            frm_buscar.etiquetaallenarid = "lblidunidad"
            frm_buscar.campoafiltrar = "unidad_Descripcion"
            frm_buscar.Focus()
            frm_buscar.ReloadForm()
        Else
            'configura formulario
            frm_buscar = New Busca_Valor
            frm_buscar.formulariopadre = Me.Name
            frm_buscar.settabla = "cat_Unidades"
            frm_buscar.campos.Add("unidad_Id")
            frm_buscar.campos.Add("unidad_Descripcion")
            frm_buscar.nombrecampoallenar = "tunidad"
            frm_buscar.activofield = "unidad_activo"
            frm_buscar.etiquetaallenarid = "lblidunidad"
            frm_buscar.campoafiltrar = "unidad_Descripcion"
            frm_buscar.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'revisa si el formulario de buscar esta abierto
        Dim frm_buscar As Busca_Valor = My.Application.OpenForms("Busca_Valor")

        'si el formulario existe solo lo manda a llamar a enfrente
        'de lo contrario crea nuevo formulario y lo muestra.
        If Not IsNothing(frm_buscar) Then
            frm_buscar.campos.Clear()
            frm_buscar.formulariopadre = Me.Name
            frm_buscar.settabla = "cat_Clasificacion"
            frm_buscar.campos.Add("clasificacion_Id")
            frm_buscar.campos.Add("clasificacion_Descripcion")
            frm_buscar.activofield = "clasificacion_activo"
            frm_buscar.nombrecampoallenar = "tclasificacion"
            frm_buscar.etiquetaallenarid = "lblidclasificacion"
            frm_buscar.campoafiltrar = "clasificacion_Descripcion"
            frm_buscar.Focus()
            frm_buscar.ReloadForm()
        Else
            'configura formulario
            frm_buscar = New Busca_Valor
            frm_buscar.formulariopadre = Me.Name
            frm_buscar.settabla = "cat_Clasificacion"
            frm_buscar.campos.Add("clasificacion_Id")
            frm_buscar.campos.Add("clasificacion_Descripcion")
            frm_buscar.activofield = "clasificacion_activo"
            frm_buscar.nombrecampoallenar = "tclasificacion"
            frm_buscar.etiquetaallenarid = "lblidclasificacion"
            frm_buscar.campoafiltrar = "clasificacion_Descripcion"
            frm_buscar.Show()
        End If
    End Sub

    Public Sub SelectDataFromDataGridSelected()
        Try
            tclaveproducto.Text = dgv_productos.SelectedCells.Item(0).Value
            tclavefabricante.Text = dgv_productos.SelectedCells.Item(1).Value
            tdescripciondeproducto.Text = dgv_productos.SelectedCells.Item(2).Value
            tespecificacionproducto.Text = dgv_productos.SelectedCells.Item(3).Value
            lblidunidad.Text = dgv_productos.SelectedCells.Item(15).Value
            tunidad.Text = dgv_productos.SelectedCells.Item(5).Value
            tprecio.Text = dgv_productos.SelectedCells.Item(6).Value
            tlocacion.Text = dgv_productos.SelectedCells.Item(7).Value
            tminimo.Text = dgv_productos.SelectedCells.Item(8).Value
            tmaximo.Text = dgv_productos.SelectedCells.Item(9).Value
            tclasificacion.Text = dgv_productos.SelectedCells.Item(10).Value
            lblidclasificacion.Text = dgv_productos.SelectedCells.Item(16).Value
            tdiasparasurtir.Text = dgv_productos.SelectedCells.Item(11).Value
            lblid.Text = dgv_productos.SelectedCells.Item(13).Value

            If Not IsDBNull(dgv_productos.SelectedCells.Item(14)) Then
                Dim imagepath As String = dgv_productos.SelectedCells.Item(14).Value
                pboxImageProducto.ImageLocation = imagepath
            End If

            'configura el formulario en modo de edicion.
            _setform = 2
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgv_productos_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_productos.SelectionChanged
        'Debug.WriteLine(dgv_productos.SelectedCells.Item(15).Value)
        SelectDataFromDataGridSelected()
    End Sub

    Private Sub lblimageid_Click(sender As Object, e As EventArgs) Handles lblimageid.TextChanged
        'obtiene la imagen seleccionada
        Try
            Dim imagepath As String = _AlmacenCls.SelImagenPorID(Integer.Parse(lblimageid.Text))
            pboxImageProducto.ImageLocation = imagepath
        Catch ex As Exception

        End Try

    End Sub
End Class