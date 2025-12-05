Imports System.Web.Http
Imports System.Data.SqlClient
Imports LibreTeaO_API.Models ' Asegúrate que aquí estén tus modelos

Public Class LibroController
    Inherits ApiController

    ' ==========================================
    ' 1. OBTENER LISTA (GET)
    ' ==========================================
    <HttpGet>
    <Route("api/libros")>
    Public Function GetLibros() As IHttpActionResult
        Dim lista As New List(Of Libro)

        Using cn = GetConnection()
            Dim query As String = "
            SELECT 
                l.id_libro, 
                l.titulo, 
                c.nombre_categoria, 
                l.disponibilidad,
                ISNULL((SELECT TOP 1 a.nombre_autor 
                        FROM autores a 
                        INNER JOIN libro_autor la ON a.id_autor = la.id_autor 
                        WHERE la.id_libro = l.id_libro), 'Sin Autor') as AutorPrincipal
            FROM libro l
            INNER JOIN categorias c ON l.id_categoria = c.id_categoria"

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim libro As New Libro()
                        libro.IdLibro = Convert.ToInt32(reader("id_libro"))
                        libro.Titulo = reader("titulo").ToString()
                        libro.NombreAutor = reader("AutorPrincipal").ToString()
                        libro.NombreCategoria = reader("nombre_categoria").ToString()

                        ' Lógica visual simple
                        Dim disp = Convert.ToBoolean(reader("disponibilidad"))
                        libro.EstadoTexto = If(disp, "Disponible", "Prestado")

                        lista.Add(libro)
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function

    ' ==========================================
    ' 2. AGREGAR LIBRO (POST)
    ' ==========================================
    <HttpPost>
    <Route("api/libros")>
    Public Function PostLibro(<FromBody> nuevo As Libro) As IHttpActionResult
        Using cn = GetConnection()
            cn.Open()

            ' Usamos una transacción porque vamos a insertar en 2 tablas (libro y libro_autor)
            Dim transaction = cn.BeginTransaction()

            Try
                ' A. Insertar el Libro y recuperar el ID generado
                Dim queryLibro As String = "
                    INSERT INTO libro (titulo, id_categoria, descripcion, disponibilidad) 
                    VALUES (@titulo, @idCat, @desc, 1);
                    SELECT CAST(SCOPE_IDENTITY() as int);"

                Dim nuevoId As Integer

                Using cmd As New SqlCommand(queryLibro, cn, transaction)
                    cmd.Parameters.AddWithValue("@titulo", nuevo.Titulo)
                    cmd.Parameters.AddWithValue("@idCat", nuevo.IdCategoria)
                    cmd.Parameters.AddWithValue("@desc", If(nuevo.Descripcion, ""))

                    ' Ejecutamos y guardamos el ID
                    nuevoId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' B. Insertar la relación con el Autor
                Dim queryRelacion As String = "INSERT INTO libro_autor (id_libro, id_autor) VALUES (@idL, @idA)"
                Using cmdRel As New SqlCommand(queryRelacion, cn, transaction)
                    cmdRel.Parameters.AddWithValue("@idL", nuevoId)
                    cmdRel.Parameters.AddWithValue("@idA", nuevo.IdAutor)
                    cmdRel.ExecuteNonQuery()
                End Using

                ' Si todo salió bien, confirmamos los cambios
                transaction.Commit()
                Return Ok("Libro guardado correctamente")

            Catch ex As Exception
                ' Si algo falla, deshacemos todo
                transaction.Rollback()
                Return InternalServerError(ex)
            End Try
        End Using
    End Function

    ' ==========================================
    ' 3. ELIMINAR LIBRO (DELETE)
    ' ==========================================
    <HttpDelete>
    <Route("api/libros/{id}")>
    Public Function DeleteLibro(id As Integer) As IHttpActionResult
        Using cn = GetConnection()
            cn.Open()
            Dim query As String = "DELETE FROM libro WHERE id_libro = @id"

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@id", id)
                Try
                    Dim filas = cmd.ExecuteNonQuery()
                    If filas > 0 Then
                        Return Ok("Eliminado")
                    Else
                        Return NotFound()
                    End If
                Catch ex As SqlException
                    ' Si el libro está prestado, la base de datos no dejará borrarlo (FK)
                    Return BadRequest("No se puede eliminar el libro porque tiene préstamos activos o historial.")
                End Try
            End Using
        End Using
    End Function

End Class