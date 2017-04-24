Public Class Recepcion_Material
    Private _AlmacenCls As New AlmacenCls
    Private _campos As List(Of String)
    Private _valores As List(Of String)
    Private _transaccionid As Integer
    'variable para configurar el formulario
    'para edicion, nuevo registro
    ' valor 1 para nuevo registro
    ' valor 2 para editar registro
    Private _setform As Integer = 0

    Private Sub btnNew_Rubbon(sender As Object, e As EventArgs) Handles btnNew.Click
        _setform = 1
        Button2_Click(btnNew, Nothing)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If _setform > 0 Then

            'revisa si el formulario de buscar esta abierto
            Dim frm_buscar As Busca_Valor = My.Application.OpenForms("Busca_Valor")

            'si el formulario existe solo lo manda a llamar a enfrente
            'de lo contrario crea nuevo formulario y lo muestra.
            If Not IsNothing(frm_buscar) Then
                frm_buscar.formulariopadre = Me.Name
                frm_buscar.campos.Clear()
                frm_buscar.settabla = "cat_proveedor"
                frm_buscar.campos.Add("prov_id")
                frm_buscar.campos.Add("prov_proveedor")
                frm_buscar.nombrecampoallenar = "tproveedor"
                frm_buscar.activofield = "prov_activo"
                frm_buscar.etiquetaallenarid = "lblproveedorid"
                frm_buscar.campoafiltrar = "prov_proveedor"
                frm_buscar.lbltitulo.Text = "Proveedor"
                frm_buscar.Focus()
                frm_buscar.ReloadForm()
            Else
                'configura formulario
                frm_buscar = New Busca_Valor
                frm_buscar.formulariopadre = Me.Name
                frm_buscar.settabla = "cat_proveedor"
                frm_buscar.campos.Add("prov_id")
                frm_buscar.campos.Add("prov_proveedor")
                frm_buscar.nombrecampoallenar = "tproveedor"
                frm_buscar.activofield = "prov_activo"
                frm_buscar.etiquetaallenarid = "lblproveedorid"
                frm_buscar.campoafiltrar = "prov_proveedor"
                frm_buscar.lbltitulo.Text = "Proveedor"
                frm_buscar.Show()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If _setform > 0 Then


            'revisa si el formulario de buscar esta abierto
            Dim frm_buscar As Busca_Valor = My.Application.OpenForms("Busca_Valor")

            'si el formulario existe solo lo manda a llamar a enfrente
            'de lo contrario crea nuevo formulario y lo muestra.
            If Not IsNothing(frm_buscar) Then
                frm_buscar.formulariopadre = Me.Name
                frm_buscar.campos.Clear()
                frm_buscar.settabla = "tab_OrdenesCompra"

                frm_buscar.campos.Add("oc_ID")
                frm_buscar.titulos.Add("ID")
                frm_buscar.campos.Add("oc_Folio")
                frm_buscar.titulos.Add("Folio")
                frm_buscar.campos.Add("Req_Id")
                frm_buscar.titulos.Add("Requision ID")
                frm_buscar.campos.Add("oc_Status")
                frm_buscar.titulos.Add("Estado")
                frm_buscar.campos.Add("Referencia_No")
                frm_buscar.titulos.Add("Numero Referencia")

                frm_buscar.nombrecampoallenar = "tordencompra"
                frm_buscar.activofield = "oc_Activo"
                frm_buscar.etiquetaallenarid = "lblordencompraid"
                frm_buscar.campoafiltrar = "oc_Folio"
                frm_buscar.lbltitulo.Text = "Folio de Orden de Compra"
                frm_buscar.Focus()
                frm_buscar.ReloadForm()
                frm_buscar.Size = (New Drawing.Size(600, 400))
            Else
                'configura formulario
                frm_buscar = New Busca_Valor
                frm_buscar.formulariopadre = Me.Name
                frm_buscar.settabla = "tab_OrdenesCompra"

                frm_buscar.campos.Add("oc_ID")
                frm_buscar.titulos.Add("ID")
                frm_buscar.campos.Add("oc_Folio")
                frm_buscar.titulos.Add("Folio")
                frm_buscar.campos.Add("Req_Id")
                frm_buscar.titulos.Add("Requision ID")
                frm_buscar.campos.Add("oc_Status")
                frm_buscar.titulos.Add("Estado")
                frm_buscar.campos.Add("Referencia_No")
                frm_buscar.titulos.Add("Numero Referencia")
                frm_buscar.nombrecampoallenar = "tordencompra"
                frm_buscar.activofield = "oc_Activo"
                frm_buscar.etiquetaallenarid = "lblordencompraid"
                frm_buscar.campoafiltrar = "oc_Folio"
                frm_buscar.lbltitulo.Text = "Folio de Orden de Compra"
                frm_buscar.Show()
                frm_buscar.Size = (New Drawing.Size(600, 400))
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If _setform > 0 Then


            'revisa si el formulario de buscar esta abierto
            Dim frm_buscar As Busca_Valor = My.Application.OpenForms("Busca_Valor")

            'si el formulario existe solo lo manda a llamar a enfrente
            'de lo contrario crea nuevo formulario y lo muestra.
            If Not IsNothing(frm_buscar) Then
                frm_buscar.formulariopadre = Me.Name
                frm_buscar.campos.Clear()
                frm_buscar.settabla = "cat_Almacenes"
                frm_buscar.campos.Add("almacen_Id")
                frm_buscar.campos.Add("almacen_NombreAlmacen")
                frm_buscar.nombrecampoallenar = "talmacen"
                frm_buscar.activofield = "almacen_Activo"
                frm_buscar.etiquetaallenarid = "lblalmacenid"
                frm_buscar.campoafiltrar = "almacen_NombreAlmacen"
                frm_buscar.lbltitulo.Text = "Almacen"
                frm_buscar.Focus()
                frm_buscar.ReloadForm()
            Else
                'configura formulario
                frm_buscar = New Busca_Valor
                frm_buscar.formulariopadre = Me.Name
                frm_buscar.settabla = "cat_Almacenes"
                frm_buscar.campos.Add("almacen_Id")
                frm_buscar.campos.Add("almacen_NombreAlmacen")
                frm_buscar.nombrecampoallenar = "talmacen"
                frm_buscar.activofield = "almacen_Activo"
                frm_buscar.etiquetaallenarid = "lblalmacenid"
                frm_buscar.campoafiltrar = "almacen_NombreAlmacen"
                frm_buscar.lbltitulo.Text = "Almacen"
                frm_buscar.Show()
            End If
        End If
    End Sub

    Public Sub ActivaCajasTexto()
        tfolioentrada.Enabled = True
        tfolioentrada.Enabled = True
        tobservaciones.Enabled = True
        tsubtotal.ReadOnly = True
        tsubtotal.Enabled = True
        timpuestos.Enabled = True
        timpuestos.ReadOnly = True
        tTotal.Enabled = True
        tTotal.ReadOnly = True
    End Sub

    Private Sub lblordencompraid_Click(sender As Object, e As EventArgs) Handles lblordencompraid.TextChanged
        Try
            Dim id As Integer = Integer.Parse(lblordencompraid.Text)
            Try
                CargaPartidas(id)
                ActivaCajasTexto()
            Catch ex As Exception
                MsgBox("" & ex.Message.ToString, MsgBoxStyle.Critical, "Error al cargar la orden de compra")
            End Try
        Catch ex As Exception
        End Try
    End Sub


    Public Sub CargaPartidas(id As Integer)

        dgv_partidas.Rows.Clear()

        'Se selecionan los campos a cargar en el datagrid
        Dim campos As New List(Of String)
        campos.Add("oc_ID") '0
        campos.Add("ocDetalle_Id") '1
        campos.Add("ocDetalle_Partida") '2
        campos.Add("prod_Id") '3
        campos.Add("prod_Producto") '4
        campos.Add("prod_ClaveProducto") '5
        campos.Add("ocDetalle_Cantidad_Solicitada") '6
        campos.Add("cantidadrecibida") '7
        campos.Add("prod_CantidadPendiente") '8
        campos.Add("unidad_Id") '9 
        campos.Add("unidad_Descripcion") '10
        campos.Add("prod_Precio") '11
        campos.Add("impuesto") '12
        campos.Add("importe") '13


        'Obtiene los datos de la base de datos
        Dim dtsresult As DataSet
        dtsresult = _AlmacenCls.SelDetalleOCParaEntrada(campos, id)

        'si no hay registros selecciona el formulario en modo de nuevo registro
        If dtsresult.Tables(0).Rows.Count = 0 Then
            _setform = 1
            Throw New Exception("Error en Orden de compra, no se encontro partidas en la orden")
        End If

        For Each dr As DataRow In dtsresult.Tables(0).Rows
            Dim row As String() = New String() {dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(4).ToString, "", dr.Item(5).ToString, dr.Item(6).ToString, "0", dr.Item(8).ToString, dr.Item(10).ToString, dr.Item(11).ToString, "0", "0", dr.Item(1).ToString}
            dgv_partidas.Rows.Add(row)
        Next

    End Sub

    Private Sub Recepcion_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridInfo()
    End Sub

    Public Sub LoadDataGridInfo()
        dgv_partidas.ColumnCount = 13
        dgv_partidas.Columns(0).Name = "IDOrdenCompra"
        dgv_partidas.Columns(0).Visible = False
        dgv_partidas.Columns(1).Name = "No."
        dgv_partidas.Columns(1).ReadOnly = True
        dgv_partidas.Columns(2).Name = "Descripcion"
        dgv_partidas.Columns(2).ReadOnly = True
        dgv_partidas.Columns(3).Name = "# Proveedor"
        dgv_partidas.Columns(3).ReadOnly = True
        dgv_partidas.Columns(4).Name = "# Parte"
        dgv_partidas.Columns(4).ReadOnly = True
        dgv_partidas.Columns(5).Name = "Cantidad Requerida"
        dgv_partidas.Columns(5).ReadOnly = True
        dgv_partidas.Columns(6).Name = "Cantidad Recibida"
        'dgv_partidas.Columns(6).ReadOnly = True
        dgv_partidas.Columns(7).Name = "Cantidad Pendiente"
        dgv_partidas.Columns(7).ReadOnly = True
        dgv_partidas.Columns(8).Name = "Unidad"
        dgv_partidas.Columns(8).ReadOnly = True
        dgv_partidas.Columns(9).Name = "Costo Unitario"
        dgv_partidas.Columns(9).ReadOnly = True
        dgv_partidas.Columns(10).Name = "Impuesto"
        dgv_partidas.Columns(10).ReadOnly = True
        dgv_partidas.Columns(11).Name = "Importe"
        dgv_partidas.Columns(11).ReadOnly = True
        dgv_partidas.Columns(12).Name = "IDOrdenCompraDetalle"
        dgv_partidas.Columns(12).Visible = False

        dgv_partidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_partidas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub
End Class