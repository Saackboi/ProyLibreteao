Imports System.Web.Http
Imports System.Data.SqlClient
Imports LibreTeaO_API.Models

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
End Class