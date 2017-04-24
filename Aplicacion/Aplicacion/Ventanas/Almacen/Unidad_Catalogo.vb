Public Class Unidad_Catalogo

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

    Private Sub btnNew_Ribbon(sender As Object, e As EventArgs) Handles btnNew.Click
        With tDESCRIPCION
            .Text = ""
            .Focus()
        End With
        _setform = 1
    End Sub

    Private Sub btnSave_Ribbon(sender As Object, e As EventArgs) Handles btnSave.Click
        'Obtiene los valores de las cajas de texto
        Dim val_descripcion As String = tDESCRIPCION.Text

        'Se generan los array de los campos y valores
        Dim campos As New List(Of String)
        Dim valores As New List(Of String)

        campos.Add("unidad_Descripcion")
        valores.Add("'" & val_descripcion & "'")

        Select Case _setform
            Case 1
                Try
                    campos.Add("unidad_activo")
                    valores.Add("1")
                    _AlmacenCls.InsertaUnidad(campos, valores)
                    MsgBox("Registro Agregado Con Exito.", MsgBoxStyle.Information, "Registro Guardado")
                    dgv_unidad.Rows.Clear()
                    LoadDataGridInfo()
                Catch ex As Exception
                    MsgBox("Error al guardar el registro Error:" & ex.Message, MsgBoxStyle.Critical)
                End Try
            Case 2
                Try
                    Dim val_id As Integer = Integer.Parse(lblID.Text)
                    _AlmacenCls.ActualizaUnidad(campos, valores, val_id)
                    dgv_unidad.Rows.Clear()
                    LoadDataGridInfo()
                Catch ex As Exception
                    MsgBox("Error al guardar el registro Error:" & ex.Message, MsgBoxStyle.Critical)
                End Try
        End Select

        _setform = 0

    End Sub

    Private Sub btnDelete_Ribbon(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MsgBox("Desea borrar el registro Actual?", MsgBoxStyle.OkCancel, "Borrar Registro")
        If result = vbOK Then
            'obtiene el id seleccionado
            Dim id As Integer = Integer.Parse(lblID.Text)
            _AlmacenCls.BorrarUnidad(id)
            dgv_unidad.Rows.Clear()
            LoadDataGridInfo()
        End If
    End Sub

    Private Sub btnSearch_Ribbon(sender As Object, e As EventArgs) Handles btnSearch.Click
        'revisa si el formulario de buscar esta abierto
        Dim frm_buscar As Unidad_Buscar = My.Application.OpenForms("Unidad_Buscar")
        'si el formulario existe solo lo manda a llamar a enfrente
        'de lo contrario crea nuevo formulario y lo muestra.
        If Not IsNothing(frm_buscar) Then
            frm_buscar.Focus()
        Else
            frm_buscar = New Unidad_Buscar
            frm_buscar.Show()
        End If
    End Sub

    Private Sub Unidad_Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Unidad_Catalogo_SizeChanged(Nothing, Nothing)
        LoadDataGridInfo()
    End Sub

    Private Sub Unidad_Catalogo_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim windosize As Integer = Me.Width
        Dim windowheigth As Integer = Me.Height
        dgv_unidad.Width = windosize - 50
        dgv_unidad.Height = windowheigth - 335
    End Sub

    Public Sub ConfigureDataGrid()
        dgv_unidad.ColumnCount = 2
        dgv_unidad.Columns(0).Name = "Descripcion de Unidad"
        dgv_unidad.Columns(1).Name = "ID"

        dgv_unidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Sub LoadDataGridInfo()
        'Configura el datagridview 
        ConfigureDataGrid()

        'Se selecionan los campos a cargar en el datagrid
        Dim campos As New List(Of String)
        campos.Add("unidad_Id")
        campos.Add("unidad_Descripcion")
        campos.Add("unidad_activo")

        'Obtiene los datos de la base de datos
        Dim dtsresult As DataSet
        dtsresult = _AlmacenCls.SelUnidad(campos, " unidad_activo=1")

        'si no hay registros selecciona el formulario en modo de nuevo registro
        If dtsresult.Tables(0).Rows.Count = 0 Then
            _setform = 1
        End If

        'Carga info en el datagrid
        For Each dr As DataRow In dtsresult.Tables(0).Rows
            Dim row As String() = New String() {dr.Item(1).ToString, dr.Item(0)}
            dgv_unidad.Rows.Add(row)
        Next
    End Sub

    Public Sub SelectDataFromDataGridSelected()
        Try
            'Llena los campos de acuerdo con lo que se selecione en el datagridview
            tDESCRIPCION.Text = dgv_unidad.SelectedCells.Item(0).Value
            lblID.Text = dgv_unidad.SelectedCells.Item(1).Value

            'Configura el formulario en modo de edicio
            _setform = 2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_unidad_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_unidad.SelectionChanged
        SelectDataFromDataGridSelected()
    End Sub
End Class