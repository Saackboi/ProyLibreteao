Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json ' Para los controles
Imports System.Configuration

Public Class ClaseContenidoLibros
    Private ReadOnly dgvCatalogo As DataGridView

    ' CONFIGURACIÓN API
    ' ---------------------------------------------------------

    Private ReadOnly BaseUrl As String = ConfigurationManager.AppSettings("ApiBaseUrl") & "libros"

    Private Shared client As HttpClient = CrearClienteInseguro()

    Private Shared Function CrearClienteInseguro() As HttpClient
        Dim handler As New HttpClientHandler()
        handler.ServerCertificateCustomValidationCallback = Function(message, cert, chain, errors) True
        Return New HttpClient(handler)
    End Function

    Public Sub New(dgv As DataGridView)
        Me.dgvCatalogo = dgv
    End Sub

    ' ========================================================
    ' 1. MOSTRAR CATALOGO
    ' ========================================================
    Public Async Sub MostrarCatalogo(Optional filtro As String = "")
        If dgvCatalogo Is Nothing Then Return

        Try
            ' 1. Pedimos TODOS los libros a la API
            Dim respuestaJSON As String = Await client.GetStringAsync(BaseUrl)
            Dim listaLibros = JsonConvert.DeserializeObject(Of List(Of Libro))(respuestaJSON)

            ' 2. Limpiamos tabla
            dgvCatalogo.Rows.Clear()
            If dgvCatalogo.Columns.Count = 0 Then ConfigurarColumnas()

            ' 3. Filtramos en memoria (Client-side filtering)
            ' Si hay filtro, solo mostramos los que coincidan. Si no, mostramos todos.
            For Each libro In listaLibros
                Dim coincide As Boolean = True

                If Not String.IsNullOrWhiteSpace(filtro) Then
                    filtro = filtro.ToLower()
                    ' Buscamos en Título, Autor o Categoría
                    coincide = libro.titulo.ToLower().Contains(filtro) OrElse
                               libro.nombreAutor.ToLower().Contains(filtro) OrElse
                               libro.nombreCategoria.ToLower().Contains(filtro)
                End If

                If coincide Then
                    dgvCatalogo.Rows.Add(
                        libro.idLibro,
                        libro.titulo,
                        libro.nombreAutor,
                        libro.nombreCategoria,
                        libro.estadoTexto
                    )
                End If
            Next

        Catch ex As Exception
            ' Evitamos spamear mensajes si falla cada vez que escribes una letra
            Debug.WriteLine("Error API: " & ex.Message)
        End Try
    End Sub

    ' ========================================================
    ' 2. AGREGAR LIBRO (POST)
    ' ========================================================
    Public Async Function AgregarLibro(titulo As String, idAutor As Integer, idCategoria As Integer, descripcion As String) As Task(Of Boolean)
        Try
            ' Creamos el objeto a enviar
            Dim nuevoLibro As New Libro With {
                .titulo = titulo,
                .IdAutor = idAutor,
                .IdCategoria = idCategoria,
                .Descripcion = descripcion
            }

            ' Convertimos el objeto a JSON
            Dim jsonEnviar As String = JsonConvert.SerializeObject(nuevoLibro)

            Dim contenido = New StringContent(jsonEnviar, Encoding.UTF8, "application/json")

            ' Enviamos el POST
            Dim respuesta = Await client.PostAsync(BaseUrl, contenido)

            If respuesta.IsSuccessStatusCode Then
                MessageBox.Show("Libro guardado correctamente en la nube.")
                Return True
            Else
                MessageBox.Show("Error en la API: " & Await respuesta.Content.ReadAsStringAsync())
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
            Return False
        End Try
    End Function

    ' ========================================================
    ' 3. ELIMINAR LIBRO (DELETE)
    ' ========================================================
    Public Async Function EliminarLibroSeleccionado() As Task
        If dgvCatalogo.SelectedRows.Count = 0 Then Return

        Dim id As Integer = Convert.ToInt32(dgvCatalogo.SelectedRows(0).Cells(0).Value)
        Dim titulo As String = dgvCatalogo.SelectedRows(0).Cells(1).Value.ToString()

        If MessageBox.Show($"¿Eliminar '{titulo}'?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim respuesta = Await client.DeleteAsync($"{BaseUrl}/{id}")

                If respuesta.IsSuccessStatusCode Then
                    MessageBox.Show("Eliminado correctamente.")
                    MostrarCatalogo() ' Recargar lista
                Else
                    MessageBox.Show("No se pudo eliminar. Verifique que no tenga préstamos activos.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al conectar con API.")
            End Try
        End If
    End Function

    ' ========================================================
    ' 4. CARGAR COMBOS 
    ' ========================================================
    Public Async Sub LlenarCombos(cmbAutores As ComboBox, cmbCategorias As ComboBox)
        Try
            ' 1. Cargar Autores
            Dim jsonAutores = Await client.GetStringAsync("https://localhost:44385/api/catalogos/autores")
            Dim listaAutores = JsonConvert.DeserializeObject(Of List(Of Autor))(jsonAutores)

            If listaAutores IsNot Nothing Then
                cmbAutores.DataSource = listaAutores
                cmbAutores.DisplayMember = "NombreAutor" ' Lo que se ve
                cmbAutores.ValueMember = "IdAutor"       ' El valor oculto (ID)
                cmbAutores.SelectedIndex = -1
            End If

            ' 2. Cargar Categorías
            Dim jsonCategorias = Await client.GetStringAsync("https://localhost:44385/api/catalogos/categorias")
            Dim listaCat = JsonConvert.DeserializeObject(Of List(Of Categoria))(jsonCategorias)

            If listaCat IsNot Nothing Then
                cmbCategorias.DataSource = listaCat
                cmbCategorias.DisplayMember = "NombreCategoria"
                cmbCategorias.ValueMember = "IdCategoria"
                cmbCategorias.SelectedIndex = -1
            End If

        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar las listas desplegables. " & ex.Message)
        End Try
    End Sub

    ' Ayuda visual
    Private Sub ConfigurarColumnas()
        dgvCatalogo.Columns.Clear()
        dgvCatalogo.Columns.Add("ID", "ID")
        dgvCatalogo.Columns.Add("Titulo", "Título")
        dgvCatalogo.Columns.Add("Autor", "Autor")
        dgvCatalogo.Columns.Add("Categoria", "Categoría")
        dgvCatalogo.Columns.Add("Estado", "Estado")
    End Sub

End Class