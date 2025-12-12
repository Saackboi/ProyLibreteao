Imports System.Data.SqlClient ' Asegúrate que tus modelos estén aquí
Imports System.Web.Http

Public Class PrestamosController
    Inherits ApiController

    ' ==========================================
    ' GET: Ver lista de préstamos
    ' ==========================================
    <HttpGet>
    <Route("api/prestamos")>
    Public Function GetPrestamos() As IHttpActionResult
        Dim lista As New List(Of PrestamoVista)

        Using cn = GetConnection()
            ' Traemos Nombres (Usuario/Libro) en vez de IDs
            Dim query As String = "
                SELECT p.id_prestamo, u.nombre AS Usuario, l.titulo AS Libro, 
                       p.fecha_prestamo, p.fecha_devolucion, p.estado
                FROM prestamo p
                INNER JOIN usuario u ON p.id_usuario = u.id_usuario
                INNER JOIN libro l ON p.id_libro = l.id_libro
                ORDER BY p.estado ASC, p.fecha_prestamo DESC"

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Formatear fechas para que se vean bien
                        Dim p As New PrestamoVista With {
                            .IdPrestamo = Convert.ToInt32(reader("id_prestamo")),
                            .NombreUsuario = reader("Usuario").ToString(),
                            .TituloLibro = reader("Libro").ToString(),
                            .FechaPrestamo = Convert.ToDateTime(reader("fecha_prestamo")).ToString("dd/MM/yyyy"),
                            .FechaDevolucion = Convert.ToDateTime(reader("fecha_devolucion")).ToString("dd/MM/yyyy"),
                            .Estado = reader("estado").ToString()
                        }

                        lista.Add(p)
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function

    ' ==========================================
    ' POST: Crear nuevo préstamo
    ' ==========================================
    <HttpPost>
    <Route("api/prestamos")>
    Public Function PostPrestamo(<FromBody> nuevo As PrestamoInput) As IHttpActionResult
        Using cn = GetConnection()
            cn.Open()

            ' 1. Validar si el libro está disponible (disponibilidad = 1)
            Dim checkQuery As String = "SELECT disponibilidad FROM libro WHERE id_libro = @idLibro"
            Using cmdCheck As New SqlCommand(checkQuery, cn)
                cmdCheck.Parameters.AddWithValue("@idLibro", nuevo.IdLibro)

                Dim result = cmdCheck.ExecuteScalar()
                If result Is Nothing OrElse Convert.ToBoolean(result) = False Then
                    Return BadRequest("El libro no está disponible.")
                End If
            End Using

            ' 2. Registrar Préstamo y Actualizar Libro a No Disponible (0)
            Dim query As String = "
                INSERT INTO prestamo (id_usuario, id_libro, fecha_prestamo, fecha_devolucion, estado)
                VALUES (@idUser, @idLibro, GETDATE(), DATEADD(day, 7, GETDATE()), 'activo');
                
                UPDATE libro SET disponibilidad = 0 WHERE id_libro = @idLibro;"

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@idUser", nuevo.IdUsuario)
                cmd.Parameters.AddWithValue("@idLibro", nuevo.IdLibro)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return Ok("Préstamo registrado correctamente")
    End Function

    ' ==========================================
    ' PUT: Devolver Libro
    ' ==========================================
    <HttpPut>
    <Route("api/prestamos/devolver/{id}")>
    Public Function DevolverLibro(id As Integer) As IHttpActionResult
        Using cn = GetConnection()
            cn.Open()

            ' Cambiar estado a 'devuelto' y liberar el libro (disponibilidad = 1)
            Dim query As String = "
                UPDATE prestamo SET estado = 'devuelto' WHERE id_prestamo = @id;
                
                UPDATE libro SET disponibilidad = 1 
                WHERE id_libro = (SELECT id_libro FROM prestamo WHERE id_prestamo = @id);"

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return Ok("Libro devuelto")
    End Function
    <HttpGet>
    <Route("api/prestamos/buscar")>
    Public Function BuscarPrestamos(<FromUri> buscar As String) As IHttpActionResult
        Dim lista As New List(Of PrestamoVista)

        Using cn = GetConnection()
            Dim query As String

            If String.IsNullOrWhiteSpace(buscar) Then
                ' Si no hay búsqueda, traemos todos los préstamos
                query = "
                SELECT p.id_prestamo, u.nombre AS Usuario, l.titulo AS Libro, 
                       p.fecha_prestamo, p.fecha_devolucion, p.estado
                FROM prestamo p
                INNER JOIN usuario u ON p.id_usuario = u.id_usuario
                INNER JOIN libro l ON p.id_libro = l.id_libro
                ORDER BY p.estado ASC, p.fecha_prestamo DESC"
            Else
                ' Si hay búsqueda, filtramos
                query = "
                SELECT p.id_prestamo, u.nombre AS Usuario, l.titulo AS Libro, 
                       p.fecha_prestamo, p.fecha_devolucion, p.estado
                FROM prestamo p
                INNER JOIN usuario u ON p.id_usuario = u.id_usuario
                INNER JOIN libro l ON p.id_libro = l.id_libro
                WHERE u.nombre LIKE '%' + @buscar + '%'
                   OR l.titulo LIKE '%' + @buscar + '%'
                   OR CAST(p.id_prestamo AS VARCHAR(20)) LIKE '%' + @buscar + '%'
                ORDER BY p.estado ASC, p.fecha_prestamo DESC"
            End If

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                If Not String.IsNullOrWhiteSpace(buscar) Then
                    cmd.Parameters.AddWithValue("@buscar", buscar)
                End If

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim p As New PrestamoVista With {
                        .IdPrestamo = reader("id_prestamo"),
                        .NombreUsuario = reader("Usuario").ToString(),
                        .TituloLibro = reader("Libro").ToString(),
                        .FechaPrestamo = Convert.ToDateTime(reader("fecha_prestamo")).ToString("dd/MM/yyyy"),
                        .FechaDevolucion = Convert.ToDateTime(reader("fecha_devolucion")).ToString("dd/MM/yyyy"),
                        .Estado = reader("estado").ToString()
                    }
                        lista.Add(p)
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function


End Class