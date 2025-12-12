Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class verlibro

    Private _idLibro As Integer
    Private _libroLocal As CatalogoLibros.Libro ' <-- datos locales opcionales

    ' ===========================
    ' CONSTRUCTORES
    ' ===========================
    ' Constructor original con idLibro
    Public Sub New(idLibro As Integer)
        InitializeComponent()
        _idLibro = idLibro
    End Sub

    ' Constructor que recibe datos locales
    Public Sub New(libro As CatalogoLibros.Libro)
        InitializeComponent()
        _libroLocal = libro
        _idLibro = libro.IdLibro
    End Sub

    ' ===========================
    ' AJUSTE DE LAYOUT
    ' ===========================
    Private Sub AdjustLayout()
        ' Vacío por ahora
    End Sub

    Private Sub verlibro_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AdjustLayout()
    End Sub

    ' ===========================
    ' LOAD DEL FORMULARIO
    ' ===========================
    Private Async Sub verlibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdjustLayout()

        ' Limpiar controles primero para evitar valores del diseñador
        txtDescripcion.Clear()
        lstComentarios.Items.Clear()
        picPortada.Image = Nothing

        If _libroLocal IsNot Nothing Then
            ' Usar datos locales directamente
            lblTitulo.Text = _libroLocal.Titulo
            lblAutor.Text = "Autor: " & _libroLocal.NombreAutor
            txtDescripcion.Text = _libroLocal.Descripcion
            lblISBN.Text = "ISBN: N/A"
            lblCalificacion.Text = "Calificación: " & _libroLocal.ValoracionPromedio.ToString()
            lblDisponibles.Text = "Disponibles: N/A"

            ' Cargar portada local si existe
            Try
                Dim rutaPortada As String = IO.Path.Combine(Application.StartupPath, "..\..\Resources\Portadas", _libroLocal.IdLibro & ".jpg")
                If IO.File.Exists(rutaPortada) Then
                    picPortada.Image = Image.FromFile(rutaPortada)
                End If
            Catch
                ' ignorar error si no hay imagen
            End Try



        Else
            ' Intentar cargar desde la API
            Await CargarDatosLibro()
        End If
    End Sub

    ' ===========================
    ' CARGA DE DATOS DESDE API
    ' ===========================
    Private Async Function CargarDatosLibro() As Task
        Try
            Using client As New HttpClient()
                Dim url = $"http://localhost:44385/api/libros/{_idLibro}"
                Dim respuesta = Await client.GetAsync(url)

                If Not respuesta.IsSuccessStatusCode Then
                    MessageBox.Show("No se pudo obtener la información del libro desde la API.")
                    Return
                End If

                Dim contenido As String = Await respuesta.Content.ReadAsStringAsync()
                Dim datos As JObject = JObject.Parse(contenido)

                ' Limpiar controles antes de asignar
                txtDescripcion.Clear()
                lstComentarios.Items.Clear()
                picPortada.Image = Nothing

                ' Asignar datos
                lblTitulo.Text = datos("titulo")?.ToString()
                lblAutor.Text = "Autor: " & datos("autorNombre")?.ToString()
                txtDescripcion.Text = datos("descripcion")?.ToString()
                lblISBN.Text = "ISBN: " & datos("isbn")?.ToString()
                lblCalificacion.Text = "Calificación: " & datos("calificacion")?.ToString()
                lblDisponibles.Text = "Disponibles: " & datos("cantidadDisponible")?.ToString()

                ' Portada
                If datos("portadaBase64") IsNot Nothing AndAlso datos("portadaBase64").ToString().Length > 0 Then
                    Dim base64 As String = datos("portadaBase64").ToString()
                    Dim bytes() As Byte = Convert.FromBase64String(base64)
                    Using ms As New IO.MemoryStream(bytes)
                        picPortada.Image = Image.FromStream(ms)
                    End Using
                End If

                ' Comentarios
                If datos("comentarios") IsNot Nothing Then
                    For Each c In datos("comentarios")
                        lstComentarios.Items.Add(c.ToString())
                    Next
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del libro: " & ex.Message)
        End Try
    End Function

    ' ===========================
    ' EVENTOS
    ' ===========================
    Private Sub lblISBN_Click(sender As Object, e As EventArgs) Handles lblISBN.Click
        ' Sin funcionalidad por ahora
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Me.Hide()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub
End Class
