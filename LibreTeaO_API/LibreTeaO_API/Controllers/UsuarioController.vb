Imports System.Data.SqlClient
Imports System.Web.Http

Public Class UsuariosController
    Inherits ApiController
    ' ==========================================
    ' 1. OBTENER LISTA DE USUARIOS (Versión Depurada)
    ' GET: api/usuarios
    ' ==========================================
    <HttpGet>
    <Route("api/usuarios")>
    Public Function GetUsuarios() As IHttpActionResult
        Dim lista As New List(Of UsuarioVista)

        Try
            ' Obtenemos la conexión
            Using cn = GetConnection()

                ' Aseguramos que esté cerrada antes de abrirla (por si acaso)
                If cn.State = ConnectionState.Open Then cn.Close()

                cn.Open()

                ' Consulta simple y directa
                Dim query As String = "SELECT id_usuario, nombre, correo, tipo_usuario FROM usuario"

                Using cmd As New SqlCommand(query, cn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim u As New UsuarioVista()
                            ' Usamos nombres de columna exactos del script SQL
                            u.IdUsuario = Convert.ToInt32(reader("id_usuario"))
                            u.Nombre = reader("nombre").ToString()
                            u.Correo = reader("correo").ToString()
                            u.TipoUsuario = reader("tipo_usuario").ToString()

                            lista.Add(u)
                        End While
                    End Using
                End Using
            End Using

            Return Ok(lista)

        Catch ex As Exception
            Return InternalServerError(ex)
        End Try
    End Function

    ' ==========================================
    ' 2. REGISTRAR NUEVO USUARIO
    ' POST: api/usuarios
    ' ==========================================
    <HttpPost>
    <Route("api/usuarios")>
    Public Function PostUsuario(<FromBody> nuevo As UsuarioInput) As IHttpActionResult
        Using cn = GetConnection()
            cn.Open()

            ' Validación básica: Verificar si el correo ya existe
            Dim checkQuery As String = "SELECT COUNT(*) FROM usuario WHERE correo = @correo"
            Using cmdCheck As New SqlCommand(checkQuery, cn)
                cmdCheck.Parameters.AddWithValue("@correo", nuevo.Correo)
                Dim count = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    Return BadRequest("El correo ya está registrado.")
                End If
            End Using

            ' Insertar nuevo usuario
            Dim query As String = "
                INSERT INTO usuario (nombre, correo, contraseña, tipo_usuario)
                VALUES (@nombre, @correo, @pass, @tipo)"

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@nombre", nuevo.Nombre)
                cmd.Parameters.AddWithValue("@correo", nuevo.Correo)
                cmd.Parameters.AddWithValue("@pass", nuevo.Contrasena) ' En un sistema real, esto debería ir encriptado
                ' Si no se envía tipo, por defecto es 'cliente'
                cmd.Parameters.AddWithValue("@tipo", If(String.IsNullOrEmpty(nuevo.TipoUsuario), "cliente", nuevo.TipoUsuario))

                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return Ok("Usuario registrado exitosamente")
    End Function

    ' ==========================================
    ' 3. ELIMINAR USUARIO
    ' DELETE: api/usuarios/{id}
    ' ==========================================
    <HttpDelete>
    <Route("api/usuarios/{id}")>
    Public Function DeleteUsuario(id As Integer) As IHttpActionResult
        Using cn = GetConnection()
            cn.Open()

            Dim query As String = "DELETE FROM usuario WHERE id_usuario = @id"

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@id", id)
                Try
                    Dim filas = cmd.ExecuteNonQuery()
                    If filas > 0 Then
                        Return Ok("Usuario eliminado")
                    Else
                        Return NotFound()
                    End If
                Catch ex As SqlException
                    ' Si el usuario tiene préstamos activos, SQL lanzará error por FK
                    Return BadRequest("No se puede eliminar el usuario porque tiene historial de préstamos o multas.")
                End Try
            End Using
        End Using
    End Function

    ' ==========================================
    ' 4. MODIFICAR USUARIO
    ' PUT: api/usuarios/{id}
    ' ==========================================
    <HttpPut>
    <Route("api/usuarios/{id}")>
    Public Function PutUsuario(id As Integer, <FromBody> datos As UsuarioInput) As IHttpActionResult
        If datos Is Nothing Then
            Return BadRequest("Datos inválidos.")
        End If

        Using cn = GetConnection()
            cn.Open()

            ' 1. Verificar si existe
            Dim checkQuery As String = "SELECT COUNT(*) FROM usuario WHERE id_usuario = @id"
            Using cmdCheck As New SqlCommand(checkQuery, cn)
                cmdCheck.Parameters.AddWithValue("@id", id)
                Dim existe = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If existe = 0 Then
                    Return NotFound()
                End If
            End Using

            ' 2. Construir SQL seguro
            Dim query As String

            If String.IsNullOrWhiteSpace(datos.Contrasena) Then
                ' Sin contraseña
                query = "
                UPDATE usuario 
                SET nombre = @nombre,
                    correo = @correo,
                    tipo_usuario = @tipo
                WHERE id_usuario = @id
            "
            Else
                ' Con contraseña
                query = "
                UPDATE usuario 
                SET nombre = @nombre,
                    correo = @correo,
                    tipo_usuario = @tipo,
                    contraseña = @pass
                WHERE id_usuario = @id
            "
            End If

            ' 3. Ejecutar
            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nombre", datos.Nombre)
                cmd.Parameters.AddWithValue("@correo", datos.Correo)
                cmd.Parameters.AddWithValue("@tipo", datos.TipoUsuario)

                If Not String.IsNullOrWhiteSpace(datos.Contrasena) Then
                    cmd.Parameters.AddWithValue("@pass", datos.Contrasena)
                End If

                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return Ok("Usuario actualizado correctamente.")
    End Function


    ' ==========================================
    ' EXTRA: LOGIN
    ' POST: api/usuarios/login
    ' ==========================================
    <HttpPost>
    <Route("api/usuarios/login")>
    Public Function Login(<FromBody> credenciales As LoginInput) As IHttpActionResult
        Using cn = GetConnection()
            Dim query As String = "SELECT id_usuario, nombre, tipo_usuario FROM usuario WHERE correo = @correo AND contraseña = @pass"

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@correo", credenciales.Correo)
                cmd.Parameters.AddWithValue("@pass", credenciales.Contrasena)

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim u As New UsuarioVista()
                        u.IdUsuario = Convert.ToInt32(reader("id_usuario"))
                        u.Nombre = reader("nombre").ToString()
                        u.TipoUsuario = reader("tipo_usuario").ToString()
                        Return Ok(u)
                    Else
                        Return Unauthorized() ' 401 Credenciales inválidas
                    End If
                End Using
            End Using
        End Using
    End Function

End Class