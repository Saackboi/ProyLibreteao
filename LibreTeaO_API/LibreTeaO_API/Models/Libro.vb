
Public Class Libro
    Public Property IdLibro As Integer
    Public Property Titulo As String
    Public Property Descripcion As String

    ' Para MOSTRAR
    Public Property NombreAutor As String
    Public Property NombreCategoria As String
    Public Property EstadoTexto As String

    ' Para GUARDAR (Necesarios para el POST)
    Public Property IdAutor As Integer
    Public Property IdCategoria As Integer
End Class