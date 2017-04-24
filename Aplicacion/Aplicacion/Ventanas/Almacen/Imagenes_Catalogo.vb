Public Class Imagenes_Catalogo

    Public selectedid As Integer
    Public nombreconrolidregresar As String
    Public formularioaregresar As String
    Private _AlmacenCls As New AlmacenCls
    Private _imagefolder As New IO.DirectoryInfo("images/products")

    Private Sub Imagenes_Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInfo()

    End Sub

    Public Sub ConfigureListView()
        'configura listview
        ListView1.LargeImageList = ilImagenes
        ListView1.LargeImageList.ImageSize = New System.Drawing.Size(150, 200)
    End Sub

    Public Sub LoadDataInfo()

        ListView1.Clear()
        ConfigureListView()

        'configura los campos
        Dim campos As New List(Of String)
        campos.Add("imagenes_Id")
        campos.Add("imagenes_ruta")
        campos.Add("imagenes_activo")

        'obtiene los resultados de la base de datos.
        Dim dts As DataSet
        dts = _AlmacenCls.SelImagenes(campos, "imagenes_activo=1")
        ListView1.View = View.LargeIcon
        For Each dr As DataRow In dts.Tables(0).Rows
            Dim infofile As New IO.FileInfo(dr.Item(1).ToString)
            ilImagenes.Images.Add(dr.Item(0).ToString, Image.FromFile(dr.Item(1).ToString))
            Dim item As New ListViewItem
            item.Text = infofile.Name
            item.Name = dr.Item(0).ToString
            item.ImageKey = dr.Item(0).ToString
            ListView1.Items.Add(item)
        Next


    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'filtra solo imagenes JPG
        fdImageDialog.Filter = "Image Files (*.jpg)|*.jpg"
        'muestra el dialogo de selecionar archivo
        fdImageDialog.ShowDialog()

        Try
            'una vez que seleciono el archivo obtiene su informacion
            Dim selectedfile As New IO.FileInfo(fdImageDialog.FileName)

            'si el directorio default no existe lo crea
            If Not IO.Directory.Exists(_imagefolder.FullName) Then
                IO.Directory.CreateDirectory(_imagefolder.FullName)
            End If

            'crea la ruta donde se van a guardar las imagenes
            Dim newpathofimage As String = _imagefolder.FullName & "\" & selectedfile.Name
            IO.File.Copy(fdImageDialog.FileName, newpathofimage)

            'guarada en la base de datos la imagen.
            Dim campos As New List(Of String)
            Dim valores As New List(Of String)
            'se configuran los campos y los valores
            campos.Add("imagenes_ruta")
            valores.Add("'" & newpathofimage & "'")
            campos.Add("imagenes_activo")
            valores.Add("1")

            Try
                'agrega registro en la tabla
                _AlmacenCls.InsertaImagen(campos, valores)
                'muestra la foro en el recuadro
                PictureBox1.ImageLocation = newpathofimage
                'recarga el listview
                LoadDataInfo()
            Catch ex As Exception
                MsgBox("Error agregar la imagen , Error " & ex.Message.ToString)
            End Try
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.Click
        Debug.WriteLine(ListView1.SelectedItems.Item(0).Name)
        Dim idimagen As Integer = Integer.Parse(ListView1.SelectedItems.Item(0).Name)
        Dim imagen As String = _AlmacenCls.SelImagenPorID(idimagen)
        PictureBox1.ImageLocation = imagen
        selectedid = idimagen
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        SetValuesonParentForm()
    End Sub

    Public Sub SetValuesonParentForm()
        If selectedid > 0 And formularioaregresar <> "" Then
            Dim frm As Form = My.Application.OpenForms(formularioaregresar)
            'Llena el campo de la descripcion
            Dim control As Control() = frm.Controls.Find(nombreconrolidregresar, True)
            If Not IsNothing(control) Then
                Try
                    control(0).Text = selectedid
                Catch ex As Exception

                End Try
            End If
        End If

        Me.Close()
    End Sub
End Class