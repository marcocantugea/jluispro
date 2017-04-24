Imports System.Data.SqlClient
Imports System.Configuration
Namespace ADO
    Public Class ADOC

        Public conections As New Collection
        Protected connection As ConnectionsProperty

        Public Sub New()
            Dim con1 As New ConnectionsProperty
            Dim con2 As New ConnectionsProperty
            Dim con3 As New ConnectionsProperty

            con1.Name = "Coneccion"
            con1.ConectionString = ConfigurationSettings.AppSettings("Ruta")

            conections.Add(con1, "SARE") 'Certificados

            'con2.Name = "Usere"
            'con2.ConectionString = ConfigurationSettings.AppSettings("Usuarios")
            'conections.Add(con2, "Usuarios")


            'con3.Name = "FAT"
            'con3.ConectionString = ConfigurationSettings.AppSettings("FATr")
            'conections.Add(con3, "FAT")

        End Sub

        Public Sub OpenDB(ByVal Project As String)
            Try
                connection = conections.Item(Project)
                connection.Connection.Open()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub CloseDB()
            Try
                If Not IsNothing(connection.Adap) Then
                    connection.Adap.Dispose()
                End If
                If Not IsNothing(connection.Command) Then
                    connection.Command.Dispose()
                End If
                If Not IsNothing(connection.Connection) Then
                    connection.Connection.Close()
                End If
            Catch ex As Exception

            End Try
        End Sub

    End Class

    Public Class ConnectionsProperty
        Dim _Name As String
        Dim _ConectionString As String
        Dim _Connection As SqlConnection
        Dim _Adap As SqlDataAdapter
        Dim _Command As SqlCommand

        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property ConectionString() As String
            Get
                Return _ConectionString
            End Get
            Set(ByVal value As String)
                _ConectionString = value
                Try
                    SetUpConnection()
                Catch ex As Exception

                End Try
            End Set
        End Property

        Public ReadOnly Property Connection() As SqlConnection
            Get
                Return _Connection
            End Get
        End Property

        Public Property Adap() As SqlDataAdapter
            Get
                Return _Adap
            End Get
            Set(ByVal value As SqlDataAdapter)
                _Adap = value
            End Set
        End Property

        Public Property Command() As SqlCommand
            Get
                Return _Command
            End Get
            Set(ByVal value As SqlCommand)
                _Command = value
            End Set
        End Property

        Public Sub SetUpConnection()
            _Connection = New SqlConnection(_ConectionString)
        End Sub
    End Class
End Namespace

