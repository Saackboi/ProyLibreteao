Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Configuration

Public Class ClaseContenidoCategorias

    Private ReadOnly dgvCategorias As DataGridView

    ' CONFIGURACIÓN API
    ' ---------------------------------------------------------
    Private ReadOnly BaseUrl As String =
        ConfigurationManager.AppSettings("ApiBaseUrl") & "catalogos/categorias"

    Private Shared client As HttpClient = CrearClienteInseguro()

    Private Shared Function CrearClienteInseguro() As HttpClient
        Dim handler As New HttpClientHandler()
        handler.ServerCertificateCustomValidationCallback =
            Function(message, cert, chain, errors) True
        Return New HttpClient(handler)
    End Function

    Public Sub New(dgv As DataGridView)
        Me.dgvCategorias = dgv
    End Sub


    ' ========================================================
    ' 1. MOSTRAR CATEGORÍAS (GET)
    ' ========================================================
    Public Async Sub MostrarCategorias(Optional filtro As String = "")
        If dgvCategorias Is Nothing Then Return

        Try
            Dim respuestaJSON As String = Await client.GetStringAsync(BaseUrl)
            Dim listaCategorias = JsonConvert.DeserializeObject(Of List(Of Categoria))(respuestaJSON)

            dgvCategorias.Rows.Clear()
            If dgvCategorias.Columns.Count = 0 Then ConfigurarColumnas()

            For Each c In listaCategorias
                Dim coincide As Boolean = True

                If Not String.IsNullOrWhiteSpace(filtro) Then
                    coincide = c.NombreCategoria.ToLower().Contains(filtro.ToLower())
                End If

                If coincide Then
                    dgvCategorias.Rows.Add(
                        c.IdCategoria,
                        c.NombreCategoria
                    )
                End If
            Next

        Catch ex As Exception
            Debug.WriteLine("Error API Categorías: " & ex.Message)
        End Try
    End Sub


    ' ========================================================
    ' 2. AGREGAR CATEGORÍA (POST)
    ' ========================================================
    Public Async Function AgregarCategoria(nombre As String) As Task(Of Boolean)
        Try
            Dim nuevaCat As New Categoria With {
                .NombreCategoria = nombre
            }

            Dim jsonEnviar As String = JsonConvert.SerializeObject(nuevaCat)
            Dim contenido = New StringContent(jsonEnviar, Encoding.UTF8, "application/json")

            Dim respuesta = Await client.PostAsync(BaseUrl, contenido)

            If respuesta.IsSuccessStatusCode Then
                MessageBox.Show("Categoría guardada correctamente.")
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
    ' 3. ELIMINAR CATEGORÍA (DELETE)
    ' ========================================================
    Public Async Function EliminarCategoriaSeleccionada() As Task
        If dgvCategorias.SelectedRows.Count = 0 Then Return

        Dim id As Integer = Convert.ToInt32(dgvCategorias.SelectedRows(0).Cells(0).Value)
        Dim nombre As String = dgvCategorias.SelectedRows(0).Cells(1).Value.ToString()

        If MessageBox.Show($"¿Eliminar '{nombre}'?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim respuesta = Await client.DeleteAsync($"{BaseUrl}/{id}")

                If respuesta.IsSuccessStatusCode Then
                    MessageBox.Show("Eliminado correctamente.")
                    MostrarCategorias()
                Else
                    MessageBox.Show("No se pudo eliminar. Es posible que esté asociada a libros.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error al conectar con API.")
            End Try
        End If
    End Function

    ' ========================================================
    ' 4. MODIFICAR CATEGORÍA (PUT)
    ' ========================================================
    ' Modifica la categoría seleccionada
    Public Async Function ModificarCategoriaSeleccionada(nombre As String) As Task(Of Boolean)

        ' Validar selección
        If dgvCategorias.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una categoria antes")
            Return False
        End If

        ' Obtener ID
        Dim id As Integer = Convert.ToInt32(dgvCategorias.SelectedRows(0).Cells(0).Value)

        Try
            ' Crear objeto y enviarlo a la API
            Dim categoria As New Categoria With {.NombreCategoria = nombre, .IdCategoria = id}
            Dim jsonEnviar As String = JsonConvert.SerializeObject(categoria)
            Dim contenido = New StringContent(jsonEnviar, Encoding.UTF8, "application/json")
            Dim respuesta = Await client.PutAsync($"{BaseUrl}/{id}", contenido)

            ' Revisar respuesta
            If respuesta.IsSuccessStatusCode Then
                MessageBox.Show("Categoría guardada correctamente.")
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
    ' CONFIGURAR COLUMNAS
    ' ========================================================
    Private Sub ConfigurarColumnas()
        dgvCategorias.Columns.Clear()
        dgvCategorias.Columns.Add("ID", "ID")
        dgvCategorias.Columns.Add("Categoria", "Categoría")
    End Sub

End Class
