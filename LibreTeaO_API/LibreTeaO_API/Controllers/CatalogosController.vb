Imports System.Web.Http
Imports System.Data.SqlClient

Public Class CatalogosController
    Inherits ApiController

    ' GET: api/catalogos/autores
    <HttpGet>
    <Route("api/catalogos/autores")>
    Public Function GetAutores() As IHttpActionResult
        Dim lista As New List(Of Autor)
        Using cn = GetConnection()
            cn.Open()
            Dim query As String = "SELECT id_autor, nombre_autor FROM autores ORDER BY nombre_autor"
            Using cmd As New SqlCommand(query, cn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New Autor With {
                            .IdAutor = Convert.ToInt32(reader("id_autor")),
                            .NombreAutor = reader("nombre_autor").ToString()
                        })
                    End While
                End Using
            End Using
        End Using
        Return Ok(lista)
    End Function

    ' POST: api/catalogos/autores
    <HttpPost>
    <Route("api/catalogos/autores")>
    Public Function PostAutor(<FromBody> nuevo As Autor) As IHttpActionResult
        If nuevo Is Nothing OrElse String.IsNullOrEmpty(nuevo.NombreAutor) Then
            Return BadRequest("El nombre del autor es obligatorio.")
        End If

        Try
            Using cn = GetConnection()
                cn.Open()
                Dim query As String = "
            INSERT INTO autores (nombre_autor)
            VALUES (@nombre);
            SELECT CAST(SCOPE_IDENTITY() AS INT);"

                Using cmd As New SqlCommand(query, cn)
                    cmd.Parameters.AddWithValue("@nombre", nuevo.NombreAutor)
                    Dim nuevoId = Convert.ToInt32(cmd.ExecuteScalar())
                    Return Ok(New With {.Mensaje = "Autor creado", .Id = nuevoId})
                End Using
            End Using
        Catch ex As Exception
            Return Conflict()
        End Try
    End Function

    ' DELETE: api/catalogos/autores/5
    <HttpDelete>
    <Route("api/catalogos/autores/{id}")>
    Public Function DeleteAutor(id As Integer) As IHttpActionResult
        Using cn = GetConnection()
            cn.Open()

            Dim query As String = "DELETE FROM autores WHERE id_autor=@id"

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@id", id)

                Try
                    Dim filas = cmd.ExecuteNonQuery()
                    If filas > 0 Then
                        Return Ok("Autor eliminado.")
                    Else
                        Return NotFound()
                    End If

                Catch ex As SqlException
                    Return BadRequest("No se puede eliminar el autor porque tiene libros asociados.")
                End Try
            End Using
        End Using
    End Function
    ' PUT: api/catalogos/autores/5
    <HttpPut>
    <Route("api/catalogos/autores/{id}")>
    Public Function PutAutor(<FromBody> modelo As Autor) As IHttpActionResult
        If modelo Is Nothing OrElse String.IsNullOrWhiteSpace(modelo.NombreAutor) Then
            Return BadRequest("Datos inválidos.")
        End If

        Try
            Using cn = GetConnection()
                cn.Open()
                Dim query As String = "
            UPDATE autores
            SET nombre_autor=@nombre
            WHERE id_autor=@id"

                Using cmd As New SqlCommand(query, cn)
                    cmd.Parameters.AddWithValue("@nombre", modelo.NombreAutor)
                    cmd.Parameters.AddWithValue("@id", modelo.IdAutor)

                    Dim filas = cmd.ExecuteNonQuery()
                    If filas > 0 Then
                        Return Ok("Autor actualizado.")
                    Else
                        Return NotFound()
                    End If
                End Using
            End Using
        Catch ex As Exception
            Return Conflict()
        End Try
    End Function



    ' GET: api/catalogos/categorias
    <HttpGet>
    <Route("api/catalogos/categorias")>
    Public Function GetCategorias() As IHttpActionResult
        Dim lista As New List(Of Categoria)
        Using cn = GetConnection()
            cn.Open()
            Dim query As String = "SELECT id_categoria, nombre_categoria FROM categorias ORDER BY nombre_categoria"
            Using cmd As New SqlCommand(query, cn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New Categoria With {
                            .IdCategoria = Convert.ToInt32(reader("id_categoria")),
                            .NombreCategoria = reader("nombre_categoria").ToString()
                        })
                    End While
                End Using
            End Using
        End Using
        Return Ok(lista)
    End Function

    <HttpPost>
    <Route("api/catalogos/categorias")>
    Public Function PostCategoria(<FromBody> nueva As Categoria) As IHttpActionResult
        If nueva Is Nothing OrElse String.IsNullOrWhiteSpace(nueva.NombreCategoria) Then
            Return BadRequest("El nombre de la categoría es obligatorio.")
        End If
        Try
            Using cn = GetConnection()
                cn.Open()
                Dim query As String = "
            INSERT INTO categorias (nombre_categoria)
            VALUES (@nombre);
            SELECT CAST(SCOPE_IDENTITY() AS INT);"

                Using cmd As New SqlCommand(query, cn)
                    cmd.Parameters.AddWithValue("@nombre", nueva.NombreCategoria)
                    Dim nuevoId = Convert.ToInt32(cmd.ExecuteScalar())

                    Return Ok(New With {.Mensaje = "Categoría creada", .Id = nuevoId})
                End Using
            End Using
        Catch ex As Exception
            Return Conflict()
        End Try
    End Function


    <HttpDelete>
    <Route("api/catalogos/categorias/{id}")>
    Public Function DeleteCategoria(id As Integer) As IHttpActionResult
        Using cn = GetConnection()
            cn.Open()

            Dim query As String = "DELETE FROM categorias WHERE id_categoria=@id"

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@id", id)

                Try
                    Dim filas = cmd.ExecuteNonQuery()
                    If filas > 0 Then
                        Return Ok("Categoría eliminada.")
                    Else
                        Return NotFound()
                    End If

                Catch ex As SqlException
                    Return BadRequest("No se puede eliminar la categoría porque tiene libros asociados.")
                End Try
            End Using
        End Using
    End Function

    <HttpPut>
    <Route("api/catalogos/categorias/{id}")>
    Public Function PutCategoria(<FromBody> modelo As Categoria) As IHttpActionResult
        If modelo Is Nothing OrElse String.IsNullOrWhiteSpace(modelo.NombreCategoria) Then
            Return BadRequest("Datos inválidos.")
        End If

        Try
            Using cn = GetConnection()
                cn.Open()
                Dim query As String = "
            UPDATE categorias
            SET nombre_categoria=@nombre
            WHERE id_categoria=@id"

                Using cmd As New SqlCommand(query, cn)
                    cmd.Parameters.AddWithValue("@nombre", modelo.NombreCategoria)
                    cmd.Parameters.AddWithValue("@id", modelo.IdCategoria)

                    Dim filas = cmd.ExecuteNonQuery()
                    If filas > 0 Then
                        Return Ok("Categoría actualizada.")
                    Else
                        Return NotFound()
                    End If
                End Using
            End Using
        Catch ex As Exception
            Return Conflict()
        End Try
    End Function

End Class

