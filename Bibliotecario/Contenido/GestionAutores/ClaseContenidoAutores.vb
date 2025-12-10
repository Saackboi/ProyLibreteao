Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json ' Para los controles
Imports System.Configuration

Public Class ClaseContenidoAutores
    Private ReadOnly dgvAutores As DataGridView

    ' CONFIGURACIÓN API
    ' ---------------------------------------------------------

    Private ReadOnly BaseUrl As String = ConfigurationManager.AppSettings("ApiBaseUrl") & "catalogos/autores"

    Private Shared client As HttpClient = CrearClienteInseguro()

    Private Shared Function CrearClienteInseguro() As HttpClient
        Dim handler As New HttpClientHandler()
        handler.ServerCertificateCustomValidationCallback = Function(message, cert, chain, errors) True
        Return New HttpClient(handler)
    End Function

    Public Sub New(dgv As DataGridView)
        Me.dgvAutores = dgv
    End Sub

    ' ========================================================
    ' 1. MOSTRAR AUTORES (GET)
    ' ========================================================
    Public Async Sub MostrarAutores(Optional filtro As String = "")
        If dgvAutores Is Nothing Then Return

        Try
            ' 1. Pedimos TODOS los autores a la API
            Dim respuestaJSON As String = Await client.GetStringAsync(BaseUrl)
            Dim listaAutores = JsonConvert.DeserializeObject(Of List(Of Autor))(respuestaJSON)

            ' 2. Limpiamos tabla
            dgvAutores.Rows.Clear()
            If dgvAutores.Columns.Count = 0 Then ConfigurarColumnas()

            ' 3. Filtramos en memoria (Client-side filtering)
            ' Si hay filtro, solo mostramos los que coincidan. Si no, mostramos todos.
            For Each autor In listaAutores
                Dim coincide As Boolean = True

                If Not String.IsNullOrWhiteSpace(filtro) Then
                    filtro = filtro.ToLower()
                    ' Buscamos en Título, Autor o Categoría
                    coincide = autor.NombreAutor.ToLower().Contains(filtro)
                End If

                If coincide Then
                    dgvAutores.Rows.Add(
                        autor.IdAutor,
                        autor.NombreAutor
                    )
                End If
            Next

        Catch ex As Exception
            ' Evitamos spamear mensajes si falla cada vez que escribes una letra
            Debug.WriteLine("Error en la API: " & ex.Message)
        End Try
    End Sub

    ' ========================================================
    ' 2. AGREGAR AUTOR (POST)
    ' ========================================================
    Public Async Function AgregarAutor(nombre As String) As Task(Of Boolean)
        Try
            ' Creamos el objeto a enviar
            Dim nuevoAutor As New Autor With {
                .NombreAutor = nombre
            }

            ' Convertimos el objeto a JSON
            Dim jsonEnviar As String = JsonConvert.SerializeObject(nuevoAutor)

            Dim contenido = New StringContent(jsonEnviar, Encoding.UTF8, "application/json")

            ' Enviamos el POST
            Dim respuesta = Await client.PostAsync(BaseUrl, contenido)

            If respuesta.IsSuccessStatusCode Then
                MessageBox.Show("Autor guardado correctamente en la nube.")
                Return True
            Else
                MessageBox.Show("Error en la API: " & respuesta.ReasonPhrase)
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
            Return False
        End Try
    End Function

    ' ========================================================
    ' 3. ELIMINAR AUTOR (DELETE)
    ' ========================================================
    Public Async Function EliminarAutorSeleccionado() As Task
        If dgvAutores.SelectedRows.Count = 0 Then Return

        Dim id As Integer = Convert.ToInt32(dgvAutores.SelectedRows(0).Cells(0).Value)
        Dim nombre As String = dgvAutores.SelectedRows(0).Cells(1).Value.ToString()

        If MessageBox.Show($"¿Eliminar '{nombre}'?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim respuesta = Await client.DeleteAsync($"{BaseUrl}/{id}")

                If respuesta.IsSuccessStatusCode Then
                    MessageBox.Show("Eliminado correctamente.")
                    MostrarAutores() ' Recargar lista
                Else
                    MessageBox.Show("No se pudo eliminar. Verifique que no haya escrito libros.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al conectar con API.")
            End Try
        End If
    End Function


    ' ========================================================
    ' 4. MODIFICAR AUTOR (PUT)
    ' ========================================================
    ' Modifica el autor seleccionado usando el nombre recibido.
    Public Async Function ModificarAutorSeleccionado(nombre As String) As Task(Of Boolean)

        ' Validar selección
        If dgvAutores.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un Autor antes")
            Return False
        End If

        ' Obtener ID del autor seleccionado
        Dim id As Integer = Convert.ToInt32(dgvAutores.SelectedRows(0).Cells(0).Value)

        Try
            ' Crear objeto con los nuevos datos
            Dim autor As New Autor With {
            .NombreAutor = nombre,
            .IdAutor = id
        }

            ' Serializar y enviar a la API
            Dim jsonEnviar As String = JsonConvert.SerializeObject(autor)
            Dim contenido = New StringContent(jsonEnviar, Encoding.UTF8, "application/json")
            Dim respuesta = Await client.PutAsync($"{BaseUrl}/{id}", contenido)

            ' Verificar respuesta
            If respuesta.IsSuccessStatusCode Then
                MessageBox.Show("Autor guardado correctamente.")
                Return True
            Else
                MessageBox.Show("Error en la API: " & respuesta.ReasonPhrase)
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
            Return False
        End Try

    End Function


    ' Ayuda visual
    Private Sub ConfigurarColumnas()
        dgvAutores.Columns.Clear()
        dgvAutores.Columns.Add("ID", "ID")
        dgvAutores.Columns.Add("Autor", "Autor")
    End Sub

End Class