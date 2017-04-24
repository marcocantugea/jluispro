

Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Imports System.Data


Public Class AlmacenCls

    ''Variable para poder hacer debug de la aplicacion 
    Public _debug As Boolean = True
    'Clase controladora de sql
    Private _Consulta As Consulta = New Consulta()
    'Variable pasa saber si hay cambios en divisa predeterminada
    Private _setpredeterminada As Boolean = False

    ''Funcion para obtener los campos de la Lista y pasarlos al formato sql
    '' ejemplo "campo1,campo2,campo3"
    Private Function GetCampos(campos As List(Of String)) As StringBuilder
        Dim sb_campos As New StringBuilder
        Dim firsttime As Boolean = True
        For Each item As String In campos
            If firsttime Then
                sb_campos.Append(item)
                firsttime = False
            Else
                sb_campos.Append("," & item)
            End If
        Next
        Return sb_campos
    End Function

    ''Funcion para obtener los valores de la Lista y pasarlos al formato sql
    '' ejemplo "valor1,'valor2',valor3"
    Private Function GetValores(valores As List(Of String)) As StringBuilder
        Dim sb_valores As New StringBuilder
        Dim firsttime As Boolean = True
        For Each item As String In valores
            If firsttime Then
                sb_valores.Append(item)
                firsttime = False
            Else
                sb_valores.Append("," & item)
            End If
        Next
        Return sb_valores
    End Function

#Region "Control de Tabla de Divisas"

    ''Maneja Datos en la tabla de datos divisas

    ''Funcion para Inserta datos a la tabla de cat_Divisas
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    Public Sub InsertaDivisa(campos As List(Of String), ByVal values As List(Of String))
        Try
            If (Not IsNothing(campos) And Not IsNothing(values)) Then
                Dim sb_campos As StringBuilder
                Dim sb_values As New StringBuilder
                sb_campos = GetCampos(campos)
                sb_values = GetValores(values)
                If _debug Then
                    Debug.WriteLine("Function:InsertDivisa")
                    Debug.WriteLine("Campos: " & sb_campos.ToString)
                    Debug.WriteLine("Valores: " & sb_values.ToString)
                End If

                'Revisa si hubo cambios en Divisa Predeterminada
                'Si el registro se actualiza y se pone como predeterminado
                'Configura las otras divisas en 0 para evitar que no halla 2 divisas predeterminadas
                If campos.Contains("divisa_PREDETERMINADO") Then
                    Dim getindex As Integer = campos.IndexOf("divisa_PREDETERMINADO")
                    Dim value As String = values(getindex)
                    If value = "1" Then
                        SetDivisaPredeterminadoToFalse()
                    End If
                End If

                _Consulta.InsertarDatos(sb_campos.ToString, sb_values.ToString, "cat_Divisas")

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:InsertaDivisa:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para Actualizar datos a la tabla cat_Divisas
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    ''      id as integer 
    Public Sub ActualizaDivisa(campos As List(Of String), ByVal values As List(Of String), id As Integer)
        Try
            If (Not IsNothing(campos) And Not IsNothing(values) And id > 0) Then
                Dim sb_consulta As New StringBuilder
                Dim firsttimeloop As Boolean = True
                Dim index As Integer = 0
                For Each item As String In campos
                    If firsttimeloop Then
                        sb_consulta.Append(item & "=" & values(index))
                        firsttimeloop = False
                    Else
                        sb_consulta.Append("," & item & "=" & values(index))
                    End If
                    index += 1
                Next

                If _debug Then
                    Debug.WriteLine("Function:ActualizaDivisa")
                    Debug.WriteLine("consulta: " & sb_consulta.ToString)
                    Debug.WriteLine("id to update: " & id.ToString)
                End If

                'Revisa si hubo cambios en Divisa Predeterminada
                'Si el registro se actualiza y se pone como predeterminado
                'Configura las otras divisas en 0 para evitar que no halla 2 divisas predeterminadas
                If campos.Contains("divisa_PREDETERMINADO") Then
                    Dim getindex As Integer = campos.IndexOf("divisa_PREDETERMINADO")
                    Dim value As String = values(getindex)
                    If value = "1" Then
                        SetDivisaPredeterminadoToFalse()
                    End If
                End If

                Dim condicion As String = "divisa_Id=" & id.ToString
                _Consulta.ActulizarGral("cat_Divisas", sb_consulta.ToString, condicion)

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:ActualizaDivisa:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para obtener Datos de la tabla cat_Divisas
    ''Parametros:
    ''      campos as List of String
    ''      condicion as string
    Public Function SelDivisas(campos As List(Of String), condicion As String) As DataSet
        Dim _dts As DataSet = Nothing
        Try
            If Not IsNothing(campos) And condicion <> "" Then
                Dim sb_campos As StringBuilder
                sb_campos = GetCampos(campos)
                _dts = _Consulta.SelToGridWhere(sb_campos.ToString, "cat_Divisas", condicion)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelDivisas:Exception: " & ex.Message.ToString)
        End Try
        Return _dts
    End Function

    ''Funcion para desactivar registro en tabla cat_Divisas
    ''Parametros:
    ''      id as integer 
    Public Sub BorrarDivisa(id As Integer)
        Try
            If id > 0 Then
                _Consulta.ActulizarGral("cat_Divisas", "divisa_activo=0", "divisa_id=" & id.ToString)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:BorrarDivisas:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para Activar registro en tabla cat_Divisas
    ''Parametros:
    ''      id as integer 
    Public Sub ActivaDivisa(id As Integer)
        Try
            If id > 0 Then
                _Consulta.ActulizarGral("cat_Divisas", "divisa_activo=1", "divisa_id=" & id.ToString)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:BorrarDivisas:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para limpiar predeterminado si se agrega una nueva moneda como predeterminada
    ''Parametros:
    ''           N/A
    Private Sub SetDivisaPredeterminadoToFalse()
        Try
            _Consulta.ActulizarGral("cat_Divisas", "divisa_PREDETERMINADO=0", "divisa_Id>0")
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SetPredeterminadoToFalse:Exception: " & ex.Message.ToString)
        End Try

    End Sub

#End Region

#Region "Control de Tabla de Clasificacion"
    ''Maneja Datos en la tabla de datos clasificacion

    ''Funcion para Inserta datos a la tabla de clasificacion
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    Public Sub InsertaClasificacion(campos As List(Of String), valores As List(Of String))
        Try
            If Not IsNothing(campos) And Not IsNothing(valores) Then
                Dim sb_campos As StringBuilder
                Dim sb_values As New StringBuilder
                sb_campos = GetCampos(campos)
                sb_values = GetValores(valores)
                If _debug Then
                    Debug.WriteLine("Function:InsertaClasificacion")
                    Debug.WriteLine("Campos: " & sb_campos.ToString)
                    Debug.WriteLine("Valores: " & sb_values.ToString)
                End If

                _Consulta.InsertarDatos(sb_campos.ToString, sb_values.ToString, "cat_Clasificacion")

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:InsertaClasificacion:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para Actualizar datos a la tabla clasificacion
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    ''      id as integer 
    Public Sub ActualizaClasificacion(campos As List(Of String), ByVal values As List(Of String), id As Integer)
        Try
            Dim sb_consulta As New StringBuilder
            Dim firsttimeloop As Boolean = True
            Dim index As Integer = 0
            For Each item As String In campos
                If firsttimeloop Then
                    sb_consulta.Append(item & "=" & values(index))
                    firsttimeloop = False
                Else
                    sb_consulta.Append("," & item & "=" & values(index))
                End If
                index += 1
            Next

            If _debug Then
                Debug.WriteLine("Function:ActualizaClasificacion")
                Debug.WriteLine("consulta: " & sb_consulta.ToString)
                Debug.WriteLine("id to update: " & id.ToString)
            End If

            Dim condicion As String = "clasificacion_Id=" & id.ToString
            _Consulta.ActulizarGral("cat_Clasificacion", sb_consulta.ToString, condicion)
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:ActualizaClasificacion:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para obtener Datos de la tabla clasificacion
    ''Parametros:
    ''      campos as List of String
    ''      condicion as string
    Public Function SelClasificacion(campos As List(Of String), condicion As String) As DataSet
        Dim _dts As DataSet = Nothing
        Try
            If Not IsNothing(campos) And condicion <> "" Then
                Dim sb_campos As StringBuilder
                sb_campos = GetCampos(campos)
                _dts = _Consulta.SelToGridWhere(sb_campos.ToString, "cat_Clasificacion", condicion)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelClasificacion:Exception: " & ex.Message.ToString)
        End Try
        Return _dts
    End Function

    ''Funcion para desactivar registro en tabla clasificacion
    ''Parametros:
    ''      id as integer 
    Public Sub BorrarClasificacion(id As Integer)
        Try
            If id > 0 Then
                _Consulta.ActulizarGral("cat_Clasificacion", "clasificacion_activo=0", "clasificacion_Id=" & id.ToString)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:BorrarDivisas:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para Activar registro en tabla clasificacion
    ''Parametros:
    ''      id as integer 
    Public Sub ActivaClasificacion(id As Integer)
        Try
            If id > 0 Then
                _Consulta.ActulizarGral("cat_Clasificacion", "clasificacion_activo=1", "clasificacion_Id=" & id.ToString)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:BorrarDivisas:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para obtener el registro por ID
    ''Parametro:
    ''         id as integer
    '' Regresa el nombre de la Clasificacion
    Public Function SelClasificacionPorID(id As Integer) As String
        Dim result As String = ""
        Try
            Dim consulta As String = "clasificacion_Id=" & id.ToString
            Dim campo As String = "clasificacion_Descripcion"
            Dim dts As DataSet
            dts = _Consulta.SelToGridWhere(campo, "cat_Clasificacion", consulta)
            For Each dt As DataRow In dts.Tables(0).Rows
                result = dt.Item(0).ToString
            Next
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelClasificacionPorID:Exception: " & ex.Message.ToString)
        End Try
        Return result
    End Function

#End Region

#Region "Control de Tabla Catalogo de Unidades"
    ''Maneja Datos en la tabla de datos clasificacion

    ''Funcion para Inserta datos a la tabla de Unidades
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    Public Sub InsertaUnidad(campos As List(Of String), valores As List(Of String))
        Try
            If Not IsNothing(campos) And Not IsNothing(valores) Then
                Dim sb_campos As StringBuilder
                Dim sb_values As New StringBuilder
                sb_campos = GetCampos(campos)
                sb_values = GetValores(valores)
                If _debug Then
                    Debug.WriteLine("Function:InsertaUnidad")
                    Debug.WriteLine("Campos: " & sb_campos.ToString)
                    Debug.WriteLine("Valores: " & sb_values.ToString)
                End If

                _Consulta.InsertarDatos(sb_campos.ToString, sb_values.ToString, "cat_Unidades")

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:InsertaUnidad:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para Actualizar datos a la tabla Unidades
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    ''      id as integer 
    Public Sub ActualizaUnidad(campos As List(Of String), ByVal values As List(Of String), id As Integer)
        Try
            Dim sb_consulta As New StringBuilder
            Dim firsttimeloop As Boolean = True
            Dim index As Integer = 0
            For Each item As String In campos
                If firsttimeloop Then
                    sb_consulta.Append(item & "=" & values(index))
                    firsttimeloop = False
                Else
                    sb_consulta.Append("," & item & "=" & values(index))
                End If
                index += 1
            Next

            If _debug Then
                Debug.WriteLine("Function:ActualizaUnidad")
                Debug.WriteLine("consulta: " & sb_consulta.ToString)
                Debug.WriteLine("id to update: " & id.ToString)
            End If

            Dim condicion As String = "unidad_Id=" & id.ToString
            _Consulta.ActulizarGral("cat_Unidades", sb_consulta.ToString, condicion)
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:ActualizaUnidad:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para obtener Datos de la tabla Unidades
    ''Parametros:
    ''      campos as List of String
    ''      condicion as string
    Public Function SelUnidad(campos As List(Of String), condicion As String) As DataSet
        Dim _dts As DataSet = Nothing
        Try
            If Not IsNothing(campos) And condicion <> "" Then
                Dim sb_campos As StringBuilder
                sb_campos = GetCampos(campos)
                _dts = _Consulta.SelToGridWhere(sb_campos.ToString, "cat_Unidades", condicion)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelUnidad:Exception: " & ex.Message.ToString)
        End Try
        Return _dts
    End Function

    ''Funcion para desactivar registro en tabla Unidades
    ''Parametros:
    ''      id as integer 
    Public Sub BorrarUnidad(id As Integer)
        Try
            If id > 0 Then
                _Consulta.ActulizarGral("cat_Unidades", "unidad_activo=0", "unidad_Id=" & id.ToString)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:BorrarDivisas:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para Activar registro en tabla Unidades
    ''Parametros:
    ''      id as integer 
    Public Sub ActivaUnidad(id As Integer)
        Try
            If id > 0 Then
                _Consulta.ActulizarGral("cat_Unidades", "unidad_activo=1", "unidad_Id=" & id.ToString)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:BorrarDivisas:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para obtener el registro por ID
    ''Parametro:
    ''         id as integer
    '' Regresa el nombre de la Clasificacion
    Public Function SelUnidadPorID(id As Integer) As String
        Dim result As String = ""
        Try
            Dim consulta As String = "unidad_Id=" & id.ToString
            Dim campo As String = "unidad_Descripcion"
            Dim dts As DataSet
            dts = _Consulta.SelToGridWhere(campo, "cat_Unidades", consulta)
            For Each dt As DataRow In dts.Tables(0).Rows
                result = dt.Item(0).ToString
            Next
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelUnidadPorID:Exception: " & ex.Message.ToString)
        End Try
        Return result
    End Function

#End Region

#Region "Control de Tabla de Productos"
    ''Maneja Datos en la tabla de datos Productos

    ''Funcion para Inserta datos a la tabla de cat_productos
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String
    Public Sub InsertaProducto(campos As List(Of String), ByVal values As List(Of String))
        Try
            If (Not IsNothing(campos) And Not IsNothing(values)) Then
                Dim sb_campos As StringBuilder
                Dim sb_values As New StringBuilder
                sb_campos = GetCampos(campos)
                sb_values = GetValores(values)
                If _debug Then
                    Debug.WriteLine("Function:InsertaProducto")
                    Debug.WriteLine("Campos: " & sb_campos.ToString)
                    Debug.WriteLine("Valores: " & sb_values.ToString)
                End If

                _Consulta.InsertarDatos(sb_campos.ToString, sb_values.ToString, "cat_Productos")

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:InsertaProducto:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para Actualizar datos a la tabla cat_productos
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    ''      id as integer 
    Public Sub ActualizaProducto(campos As List(Of String), ByVal values As List(Of String), id As Integer)
        Try
            If (Not IsNothing(campos) And Not IsNothing(values) And id > 0) Then
                Dim sb_consulta As New StringBuilder
                Dim firsttimeloop As Boolean = True
                Dim index As Integer = 0
                For Each item As String In campos
                    If firsttimeloop Then
                        sb_consulta.Append(item & "=" & values(index))
                        firsttimeloop = False
                    Else
                        sb_consulta.Append("," & item & "=" & values(index))
                    End If
                    index += 1
                Next

                If _debug Then
                    Debug.WriteLine("Function:ActualizaDivisa")
                    Debug.WriteLine("consulta: " & sb_consulta.ToString)
                    Debug.WriteLine("id to update: " & id.ToString)
                End If

                Dim condicion As String = "prod_Id=" & id.ToString
                _Consulta.ActulizarGral("cat_Productos", sb_consulta.ToString, condicion)

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:InsertaProducto:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para obtener Datos de la tabla cat_productos
    ''Parametros:
    ''      campos as List of String
    ''      condicion as string
    Public Function SelProductos(campos As List(Of String), condicion As String) As DataSet
        Dim _dts As DataSet = Nothing
        Try
            If Not IsNothing(campos) And condicion <> "" Then
                Dim sb_campos As StringBuilder
                sb_campos = GetCampos(campos)
                _dts = _Consulta.SelToGridWhere(sb_campos.ToString, "view_cat_Productos", condicion)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelDivisas:Exception: " & ex.Message.ToString)
        End Try
        Return _dts
    End Function

#End Region

#Region "Control de Tabla de Imagenes"
    ''Maneja Datos en la tabla de datos imagenes

    ''Funcion para Inserta datos a la tabla de cat_Imagenes
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String
    Public Sub InsertaImagen(campos As List(Of String), ByVal values As List(Of String))
        Try
            If (Not IsNothing(campos) And Not IsNothing(values)) Then
                Dim sb_campos As StringBuilder
                Dim sb_values As New StringBuilder
                sb_campos = GetCampos(campos)
                sb_values = GetValores(values)
                If _debug Then
                    Debug.WriteLine("Function:InsertaImagen")
                    Debug.WriteLine("Campos: " & sb_campos.ToString)
                    Debug.WriteLine("Valores: " & sb_values.ToString)
                End If

                _Consulta.InsertarDatos(sb_campos.ToString, sb_values.ToString, "cat_Imagenes")

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:InsertaImagen:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para obtener Datos de la tabla cat_Imagenes
    ''Parametros:
    ''      campos as List of String
    ''      condicion as string
    Public Function SelImagenes(campos As List(Of String), condicion As String) As DataSet
        Dim _dts As DataSet = Nothing
        Try
            If Not IsNothing(campos) And condicion <> "" Then
                Dim sb_campos As StringBuilder
                sb_campos = GetCampos(campos)
                _dts = _Consulta.SelToGridWhere(sb_campos.ToString, "cat_Imagenes", condicion)
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelDivisas:Exception: " & ex.Message.ToString)
        End Try
        Return _dts
    End Function

    ''Funcion para obtener Datos de la tabla cat_Imagenes
    ''Parametros:
    ''      campos as List of String
    ''      condicion as string
    Public Function SelImagenPorID(id As Integer) As String
        Dim rutaimagen As String = ""
        Dim _dts As DataSet = Nothing
        Try
            If id > 0 Then
                Dim campos As New List(Of String)
                campos.Add("imagenes_ruta")
                Dim dts As DataSet
                dts = SelImagenes(campos, "imagenes_Id=" & id.ToString)
                For Each row As DataRow In dts.Tables(0).Rows
                    rutaimagen = row.Item(0).ToString
                Next
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelDivisas:Exception: " & ex.Message.ToString)
        End Try
        Return rutaimagen
    End Function

#End Region

#Region "Control de Tabla de Transacciones Encabezado y Detalle"
    ''Maneja Datos en la tabla de datos Transacciones encabezado y detalle

    ''Funcion para Inserta datos a la tabla de tab_Transacciones
    ''Esta funcio da entrada al material 
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    Public Sub InsertaTranMatEntrada(campos As List(Of String), ByVal values As List(Of String))
        Try
            If (Not IsNothing(campos) And Not IsNothing(values)) Then
                Dim sb_campos As StringBuilder
                Dim sb_values As New StringBuilder
                sb_campos = GetCampos(campos)
                sb_values = GetValores(values)
                If _debug Then
                    Debug.WriteLine("Function:InsertaTransacionMaterialEntrada")
                    Debug.WriteLine("Campos: " & sb_campos.ToString)
                    Debug.WriteLine("Valores: " & sb_values.ToString)
                End If

                'Configura el registro como entrada de Material
                If campos.Contains("transaccion_TIPO_MOVIMIENTO") Then
                    Dim getindex As Integer = campos.IndexOf("transaccion_TIPO_MOVIMIENTO")
                    values(getindex) = "1"
                Else
                    campos.Add("transaccion_TIPO_MOVIMIENTO")
                    values.Add("1")
                End If

                _Consulta.InsertarDatos(sb_campos.ToString, sb_values.ToString, "tab_Transacciones")

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:InsertaTranMatEntrada:Exception: " & ex.Message.ToString)
        End Try
    End Sub

    ''Funcion para Inserta datos a la tabla de tab_TransaccionesDetalle
    ''Esta funcio da entrada al material 
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    Public Sub InsertaTranMateEntradaDetalle(campos As List(Of String), ByVal values As List(Of String))
        Try
            If (Not IsNothing(campos) And Not IsNothing(values)) Then
                Dim sb_campos As StringBuilder
                Dim sb_values As New StringBuilder
                sb_campos = GetCampos(campos)
                sb_values = GetValores(values)
                If _debug Then
                    Debug.WriteLine("Function:InsertaTranMateEntradaDetalle")
                    Debug.WriteLine("Campos: " & sb_campos.ToString)
                    Debug.WriteLine("Valores: " & sb_values.ToString)
                End If

                'Configura el registro como entrada de Material
                If campos.Contains("traDetalle_TIPO_MOVIMIENTO") Then
                    Dim getindex As Integer = campos.IndexOf("traDetalle_TIPO_MOVIMIENTO")
                    values(getindex) = "1"
                Else
                    campos.Add("traDetalle_TIPO_MOVIMIENTO")
                    values.Add("1")
                End If

                _Consulta.InsertarDatos(sb_campos.ToString, sb_values.ToString, "tab_TransaccionesDetalle")

            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:InsertaTranMateEntradaDetalle:Exception: " & ex.Message.ToString)
        End Try
    End Sub


    ''Funcion para selecionar datos a la vista de detalle en la entrada
    ''Esta funcio da entrada al material 
    ''Parametros:
    ''      campos as List of String
    ''      values as List of String 
    Public Function SelDetalleOCParaEntrada(campos As List(Of String), idordencompra As Integer)
        Dim _dts As DataSet = Nothing
        Try
            If Not IsNothing(campos) And idordencompra > 0 Then
                Dim sb_campos As StringBuilder
                sb_campos = GetCampos(campos)
                _dts = _Consulta.SelToGridWhere(sb_campos.ToString, "vw_ordenescompraDetalle_fill", "oc_ID=" & idordencompra.ToString & "")
            End If
        Catch ex As Exception
            Throw New Exception("Error on AlmacenCls:SelDivisas:Exception: " & ex.Message.ToString)
        End Try
        Return _dts
    End Function


#End Region

End Class
