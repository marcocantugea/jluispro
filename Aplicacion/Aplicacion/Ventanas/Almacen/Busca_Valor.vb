Imports System.Text
Public Class Busca_Valor

    Public campos As New List(Of String)
    Public titulos As New List(Of String)
    Public nombrecampoallenar As String
    Public etiquetaallenarid As String
    Public settabla As String
    Public activofield As String
    Public campoafiltrar As String
    Public formulariopadre As String
    Private _consulta As New Consulta
    Private _source As New BindingSource
    Public Sub ConfigDataview()
        dgv_datos.ColumnCount = campos.Count
        dgv_datos.Columns(0).Visible = False
        If titulos.Count > 0 Then
            For i As Integer = 1 To campos.Count - 1
                dgv_datos.Columns(i).Name = titulos(i)
            Next
        End If
        dgv_datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Busca_Valor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigDataview()
        CargaDatos()
    End Sub

    Public Sub CargaDatos()
        Try
            If campos.Count > 0 And nombrecampoallenar <> "" And etiquetaallenarid <> "" And settabla <> "" And activofield <> "" Then
                Dim dts As DataSet
                Dim consulta As String = GetCampos(campos).ToString
                dts = _consulta.SelToGridWhere(consulta, settabla, activofield & "=1")
                'Carga info en el datagrid

                
                For Each dr As DataRow In dts.Tables(0).Rows
                    Dim row As String()
                    ReDim row(campos.Count - 1)
                    Dim index As Integer = 0
                    For i As Integer = 0 To campos.Count - 1
                        row(i) = dr.Item(i).ToString
                    Next

                    dgv_datos.Rows.Add(row)
                Next
                
            End If
        Catch ex As Exception
            MsgBox("Error al realizar la consulta, Error:" & ex.Message, MsgBoxStyle.Critical, "Error en consulta")
        End Try
    End Sub

    Public Sub MakeFilter() Handles TextBox1.KeyUp
        If TextBox1.Text.Length >= 3 Then
            dgv_datos.Rows.Clear()
            Dim dts As DataSet
            Dim consulta As String = GetCampos(campos).ToString
            dts = _consulta.SelToGridWhere(consulta, settabla, activofield & "=1 and " & campoafiltrar & " like ('%" & TextBox1.Text & "%')")
            'Carga info en el datagrid
            Dim row As String()
            ReDim row(campos.Count - 1)
            For Each dr As DataRow In dts.Tables(0).Rows
                '    Dim row As String() = New String() {dr.Item(1).ToString, dr.Item(0)}
                Dim index As Integer = 0
                For i As Integer = 0 To campos.Count - 1
                    row(i) = dr.Item(i).ToString
                Next
                dgv_datos.Rows.Add(row)
            Next
        Else
            ReloadForm()
        End If
    End Sub

    Public Sub ReloadForm()
        dgv_datos.Rows.Clear()
        CargaDatos()
    End Sub

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetValuesonParentForm()
    End Sub

    Private Sub dgv_datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datos.CellDoubleClick
        SetValuesonParentForm()

    End Sub

    Public Sub SetValuesonParentForm()
        Dim frm As Form = My.Application.OpenForms(formulariopadre)
        'Llena el campo de la descripcion
        Dim control As Control() = frm.Controls.Find(nombrecampoallenar, True)
        If Not IsNothing(control) Then
            Try
                control(0).Text = dgv_datos.SelectedCells(1).Value
            Catch ex As Exception

            End Try
        End If

        'llena el campo del id
        Dim idcontrol As Control() = frm.Controls.Find(etiquetaallenarid, True)
        If Not IsNothing(idcontrol) Then
            Try
                idcontrol(0).Text = dgv_datos.SelectedCells(0).Value
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class