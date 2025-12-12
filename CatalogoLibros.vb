

Imports System.Linq
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.IO

Public Class CatalogoLibros
    Inherits Form

    ' ============================
    ' DATOS DEL USUARIO
    ' ============================
    Public Shared NombreUsuarioActual As String = "Invitado"
    Public Shared EsInvitado As Boolean = True

    ' ============================
    ' API Y VARIABLES
    ' ============================
    Private Shared ReadOnly client As New HttpClient()
    Private Const API_URL As String = "https://localhost:44385/api/libros"

    Private TodosLosLibros As List(Of Libro)
    Private FiltroMinimoEstrellas As Integer = 0

    ' ============================
    ' CLASE LIBRO
    ' ============================
    Public Class Libro
        Public Property IdLibro As Integer
        Public Property Titulo As String
        Public Property Descripcion As String
        Public Property NombreAutor As String
        Public Property NombreCategoria As String
        Public Property EstadoTexto As String
        Public Property ValoracionPromedio As Decimal = 0
    End Class

    ' ============================
    ' LOAD DEL FORMULARIO
    ' ============================
    Private Async Sub CatalogoLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = NombreUsuarioActual

        ' Mostrar botón Registrarse solo si es invitado
        btnRegistrarse.Visible = EsInvitado

        ' Cargar libros de la API
        If Await ObtenerLibros() Then
            AplicarFiltrosYMostrarLibros()
        End If
    End Sub

    ' ============================
    ' BOTÓN BUSCAR
    ' ============================
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        AplicarFiltrosYMostrarLibros(txtBuscador.Text)
    End Sub

    Private Sub txtBuscador_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscador.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            AplicarFiltrosYMostrarLibros(txtBuscador.Text)
        End If
    End Sub

    ' ============================
    ' MOSTRAR LIBROS
    ' ============================
    Private Sub AplicarFiltrosYMostrarLibros(Optional busqueda As String = "")
        If TodosLosLibros Is Nothing Then Exit Sub

        Dim listaFiltrada = TodosLosLibros.AsEnumerable()

        ' Filtro de búsqueda
        If Not String.IsNullOrWhiteSpace(busqueda) Then
            Dim texto = busqueda.ToLower()
            listaFiltrada = listaFiltrada.Where(Function(l) l.Titulo.ToLower().Contains(texto) OrElse
                                                  l.NombreAutor.ToLower().Contains(texto) OrElse
                                                  l.NombreCategoria.ToLower().Contains(texto))
        End If

        ' LIMPIAR PANTALLA
        FlowLayoutPanelContenedorLibros.Controls.Clear()

        ' DIBUJAR CARDS
        For Each libro As Libro In listaFiltrada
            Dim card As New LibroCard()
            card.IdLibro = libro.IdLibro
            card.TituloLibro = libro.Titulo
            card.Autores = libro.NombreAutor
            card.LibroData = libro

            ' CARGAR IMAGEN LOCAL
            Dim carpetaPortadas As String = Path.Combine(Application.StartupPath, "..\..\Resources\Portadas")
            Dim extensiones As String() = {".jpg", ".jpeg", ".png", ".webp"}
            Dim rutaImagenEncontrada As String = Nothing

            For Each ext In extensiones
                Dim ruta As String = Path.Combine(carpetaPortadas, libro.IdLibro & ext)
                If File.Exists(ruta) Then
                    rutaImagenEncontrada = ruta
                    Exit For
                End If
            Next

            Dim imagenCargada As Image = Nothing
            Try
                If rutaImagenEncontrada IsNot Nothing Then
                    imagenCargada = Image.FromFile(rutaImagenEncontrada)
                Else
                    imagenCargada = Image.FromFile(Path.Combine(carpetaPortadas, "default.jpeg"))
                End If
            Catch
                Try
                    imagenCargada = Image.FromFile(Path.Combine(carpetaPortadas, "default.jpeg"))
                Catch
                    imagenCargada = Nothing
                End Try
            End Try

            card.ImagenPortada = imagenCargada

            ' ============================
            ' SUSCRIBIR EVENTO DE SELECCIÓN
            ' ============================
            AddHandler card.LibroSeleccionado, AddressOf AbrirDetalleLibro

            FlowLayoutPanelContenedorLibros.Controls.Add(card)
        Next
    End Sub

    ' ============================
    ' ABRIR VENTANA DE DETALLE DEL LIBRO
    ' ============================
    Private Sub AbrirDetalleLibro(idLibro As Integer)
        Try
            ' Buscar el libro en la lista local
            Dim libro = TodosLosLibros.FirstOrDefault(Function(l) l.IdLibro = idLibro)
            If libro IsNot Nothing Then
                ' Pasar objeto Libro a la ventana de detalle
                Dim detalle As New verlibro(libro)
                detalle.ShowDialog() ' Modal
            Else
                MessageBox.Show("Libro no encontrado en la lista local.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir detalle del libro: " & ex.Message)
        End Try
    End Sub


    ' ============================
    ' OBTENER LIBROS DESDE API
    ' ============================
    Private Async Function ObtenerLibros() As Task(Of Boolean)
        Try
            Dim resp As HttpResponseMessage = Await client.GetAsync(API_URL)
            resp.EnsureSuccessStatusCode()

            Dim json As String = Await resp.Content.ReadAsStringAsync()
            TodosLosLibros = JsonConvert.DeserializeObject(Of List(Of Libro))(json)

            Return True
        Catch ex As Exception
            MessageBox.Show("Error cargando libros: " & ex.Message)
            Return False
        End Try
    End Function

    ' ============================
    ' BOTÓN REGISTRARSE
    ' ============================
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Me.Hide()
        NuevoUsuario.Show()
    End Sub

    ' ============================
    ' BOTÓN REGRESAR / CERRAR
    ' ============================
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim result As DialogResult = MessageBox.Show(
           "¿Estás seguro que deseas salir?",
           "Confirmar",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FlowLayoutPanelContenedorLibros_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanelContenedorLibros.Paint

    End Sub
End Class
