Public Class Libro

    Public Property idLibro As Integer
    Public Property titulo As String
    Public Property nombreAutor As String     ' Viene del GET
    Public Property nombreCategoria As String ' Viene del GET
    Public Property estadoTexto As String     ' Disponible/Prestado

    ' Para cuando enviamos datos (POST)
    Public Property IdAutor As Integer
    Public Property IdCategoria As Integer
    Public Property Descripcion As String
End Class
