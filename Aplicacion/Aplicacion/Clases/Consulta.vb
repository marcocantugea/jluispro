Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class Consulta
    Dim con1 As New ADO.ConnectionsProperty
    Dim con3 As New ADO.ConnectionsProperty
    Function SelToGrid(ByVal Consultas As String, ByVal Tablas As String)
        '******************************************************************
        '****************** CLAUSULA PARA SELECCIONAR *********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB("SARE")
            con1 = conDB.conections("SARE")
            con1.Command = New SqlCommand("Select " & Consultas & " From " & Tablas & "", con1.Connection)
            con1.Adap = New SqlDataAdapter(con1.Command)
            Dim dts As New DataSet
            con1.Adap.Fill(dts)
            conDB.CloseDB()
            Return dts
        Catch ex As Exception
            Throw
        End Try
    End Function
    Function SelToGridWhere(ByVal Consultas As String, ByVal Tablas As String, ByVal Condicion As String)
        '******************************************************************
        '****************** CLAUSULA PARA SELECCIONAR *********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB("SARE")
            con1 = conDB.conections("SARE")
            con1.Command = New SqlCommand("Select " & Consultas & " From " & Tablas & " Where " & Condicion & "", con1.Connection)
            con1.Adap = New SqlDataAdapter(con1.Command)
            Dim dts As New DataSet
            con1.Adap.Fill(dts)
            conDB.CloseDB()
            Return dts
        Catch ex As Exception
            Throw
        End Try
    End Function
    Function SelToGridWherePlus(ByVal Consultas As String, ByVal Tablas As String, ByVal Condicion As String, ByVal Conexion As String)
        '******************************************************************
        '****************** CLAUSULA PARA SELECCIONAR *********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB(Conexion)
            con1 = conDB.conections(Conexion)
            con1.Command = New SqlCommand("Select " & Consultas & " From " & Tablas & " Where " & Condicion & "", con1.Connection)
            con1.Adap = New SqlDataAdapter(con1.Command)
            Dim dts As New DataSet
            con1.Adap.Fill(dts)
            conDB.CloseDB()
            Return dts
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Sub InsertarDatos(ByVal campos As String, ByVal valores As String, ByVal tabla As String)
        '******************************************************************
        '*********************CLAUSULA PARA INSERTAR **********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB("SARE")
            con1 = conDB.conections("SARE")
            con1.Command = New SqlCommand("Insert Into " & tabla & "(" & campos & ") values (" & valores & ")", con1.Connection)
            con1.Command.ExecuteNonQuery()
            conDB.CloseDB()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub InsertarDatosPlus(ByVal campos As String, ByVal valores As String, ByVal tabla As String, ByVal Conexion As String)
        '******************************************************************
        '*********************CLAUSULA PARA INSERTAR **********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB(Conexion)
            con1 = conDB.conections(Conexion)
            con1.Command = New SqlCommand("Insert Into " & tabla & "(" & campos & ") values (" & valores & ")", con1.Connection)
            con1.Command.ExecuteNonQuery()
            conDB.CloseDB()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub ActulizarGral(ByVal tabla As String, ByVal consulta As String, ByVal Condicion As String)
        '******************************************************************
        '*********************CLAUSULA PARA ACTUALIZAR **********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB("SARE")
            con1 = conDB.conections("SARE")
            con1.Command = New SqlCommand("Update " & tabla & " Set " & consulta & " Where " & Condicion, con1.Connection)
            con1.Command.ExecuteNonQuery()
            conDB.CloseDB()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub ActulizarCEstado(ByVal carpeta As String, ByVal estadoc As Boolean)
        '******************************************************************
        '*********************CLAUSULA PARA ACTUALIZAR **********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB("SARE")
            con1 = conDB.conections("SARE")
            con1.Command = New SqlCommand("Update tblGeneral Set Estado=" & estadoc & " Where CarpetaNombre='" & carpeta & "'", con1.Connection)
            con1.Command.ExecuteNonQuery()
            conDB.CloseDB()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub ActulizarAEstado(ByVal Archivo As String, ByVal carpeta As String, ByVal estado As Boolean)
        '******************************************************************
        '*********************CLAUSULA PARA ACTUALIZAR **********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB("SARE")
            con1 = conDB.conections("SARE")
            con1.Command = New SqlCommand("Update tblArchivos Set Estado=" & estado & " Where CarpetaNombre='" & carpeta & "' and Archivo='" & Archivo & "'", con1.Connection)
            con1.Command.ExecuteNonQuery()
            conDB.CloseDB()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub ActulizarCEstado(ByVal Archivo As String, ByVal carpeta As String)
        '******************************************************************
        '*********************CLAUSULA PARA ACTUALIZAR **********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB("SARE")
            con1 = conDB.conections("SARE")
            con1.Command = New SqlCommand("Update tblCertificados Set CopiadoSistema=" & "Yes" & " Where CarpetaNombre='" & carpeta & "' and Archivo='" & Archivo & "'", con1.Connection)
            con1.Command.ExecuteNonQuery()
            conDB.CloseDB()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub EliminarDatos(ByVal tabla As String, ByVal valores As String)
        '******************************************************************
        '*********************CLAUSULA PARA ELIMINAR **********************
        '******************************************************************
        Try
            Dim conDB As New ADO.ADOC
            conDB.OpenDB("SARE")
            con1 = conDB.conections("SARE")
            con1.Command = New SqlCommand("delete from " & tabla & " where " & valores & "", con1.Connection)
            con1.Command.ExecuteNonQuery()
            conDB.CloseDB()
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
