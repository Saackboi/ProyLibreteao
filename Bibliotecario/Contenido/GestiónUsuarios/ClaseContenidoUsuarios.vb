Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Configuration

Public Class ClaseContenidoUsuarios
    Private ReadOnly dgvUsuarios As DataGridView

    ' CONFIGURACIÓN API
    ' ---------------------------------------------------------
    Private ReadOnly BaseUrl As String =
        ConfigurationManager.AppSettings("ApiBaseUrl") & "usuarios"

    Private Shared client As HttpClient = CrearClienteInseguro()

    Private Shared Function CrearClienteInseguro() As HttpClient
        Dim handler As New HttpClientHandler()
        handler.ServerCertificateCustomValidationCallback =
            Function(message, cert, chain, errors) True
        Return New HttpClient(handler)
    End Function

    Public Sub New(dgv As DataGridView)
        Me.dgvUsuarios = dgv
    End Sub


    ' ========================================================
    ' 1. MOSTRAR USUARIOS (GET)
    ' ========================================================
    Public Async Sub MostrarUsuarios(Optional filtro As String = "")
        If dgvUsuarios Is Nothing Then Return

        Try
            dgvUsuarios.AutoGenerateColumns = False
            Dim respuestaJSON As String = Await client.GetStringAsync(BaseUrl)
            Dim listaUsuarios = JsonConvert.DeserializeObject(Of List(Of Usuario))(respuestaJSON)

            dgvUsuarios.Rows.Clear()
            If dgvUsuarios.Columns.Count = 0 Then ConfigurarColumnas()

            For Each user In listaUsuarios
                If user.TipoUsuario <> "cliente" Then
                    Continue For
                End If
                Dim coincide As Boolean = True

                If Not String.IsNullOrWhiteSpace(filtro) Then
                    filtro = filtro.ToLower()

                    coincide =
                        user.Nombre.ToLower().Contains(filtro) OrElse
                        user.Correo.ToLower().Contains(filtro) OrElse
                        user.TipoUsuario.ToLower().Contains(filtro)
                End If

                If coincide Then
                    dgvUsuarios.Rows.Add(
                        user.IdUsuario,
                        user.Nombre,
                        user.Correo,
                        user.TipoUsuario
                    )
                End If
            Next

        Catch ex As Exception
            Debug.WriteLine("Error API (Usuarios): " & ex.Message)
        End Try
    End Sub


    ' ========================================================
    ' 2. AGREGAR USUARIO (POST)
    ' ========================================================
    Public Async Function AgregarUsuario(nombre As String,
                                         correo As String,
                                         contrasena As String,
                                         tipoUsuario As String) As Task(Of Boolean)

        Try
            Dim nuevo As New UsuarioInput With {
                .Nombre = nombre,
                .Correo = correo,
                .Contrasena = contrasena,
                .TipoUsuario = tipoUsuario
            }

            Dim jsonEnviar As String = JsonConvert.SerializeObject(nuevo)
            Dim contenido = New StringContent(jsonEnviar, Encoding.UTF8, "application/json")

            Dim respuesta = Await client.PostAsync(BaseUrl, contenido)

            If respuesta.IsSuccessStatusCode Then
                MessageBox.Show("Usuario registrado correctamente.")
                Return True
            Else
                MessageBox.Show("Error API: " & respuesta.ReasonPhrase)
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
            Return False
        End Try
    End Function


    ' ========================================================
    ' 3. ELIMINAR USUARIO (DELETE)
    ' ========================================================
    Public Async Function EliminarUsuarioSeleccionado() As Task
        If dgvUsuarios.SelectedRows.Count = 0 Then Return

        Dim id As Integer = Convert.ToInt32(dgvUsuarios.SelectedRows(0).Cells(0).Value)
        Dim nombre As String = dgvUsuarios.SelectedRows(0).Cells(1).Value.ToString()

        If MessageBox.Show($"¿Eliminar a '{nombre}'?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Try
                Dim respuesta = Await client.DeleteAsync($"{BaseUrl}/{id}")

                If respuesta.IsSuccessStatusCode Then
                    MessageBox.Show("Usuario eliminado.")
                    MostrarUsuarios()
                Else
                    MessageBox.Show("No se pudo eliminar.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error eliminando usuario: " & ex.Message)
            End Try

        End If
    End Function


    ' ========================================================
    ' 4. MODIFICAR USUARIO (PUT)
    ' ========================================================
    Public Async Function ModificarUsuarioSeleccionado(nombre As String,
                                                       correo As String,
                                                       tipoUsuario As String,
                                                       Optional contrasena As String = "") As Task(Of Boolean)

        If dgvUsuarios.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario.")
            Return False
        End If

        Dim id As Integer = Convert.ToInt32(dgvUsuarios.SelectedRows(0).Cells(0).Value)

        Try
            Dim user As New UsuarioInput With {
                .Nombre = nombre,
                .Correo = correo,
                .TipoUsuario = tipoUsuario,
                .Contrasena = If(String.IsNullOrWhiteSpace(contrasena), Nothing, contrasena)
            }

            Dim jsonEnviar As String = JsonConvert.SerializeObject(user)
            Dim contenido = New StringContent(jsonEnviar, Encoding.UTF8, "application/json")

            Dim respuesta = Await client.PutAsync($"{BaseUrl}/{id}", contenido)

            If respuesta.IsSuccessStatusCode Then
                MessageBox.Show("Usuario modificado.")
                Return True
            Else
                MessageBox.Show("Error API: " & respuesta.ReasonPhrase)
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
            Return False
        End Try
    End Function


    ' ========================================================
    ' 5. CONFIGURAR COLUMNAS DEL DATAGRIDVIEW
    ' ========================================================
    Private Sub ConfigurarColumnas()
        dgvUsuarios.Columns.Clear()
        dgvUsuarios.Columns.Add("IdUsuario", "ID")
        dgvUsuarios.Columns.Add("Nombre", "Nombre")
        dgvUsuarios.Columns.Add("Correo", "Correo")
        dgvUsuarios.Columns.Add("TipoUsuario", "Tipo de Usuario")
    End Sub

End Class
