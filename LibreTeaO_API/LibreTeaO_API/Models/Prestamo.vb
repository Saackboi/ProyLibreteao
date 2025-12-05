
' Modelo para MOSTRAR en la tabla (Texto legible)
Public Class PrestamoVista
    Public Property IdPrestamo As Integer
    Public Property NombreUsuario As String
    Public Property TituloLibro As String
    Public Property FechaPrestamo As String
    Public Property FechaDevolucion As String
    Public Property Estado As String
End Class

' Modelo para INSERTAR (IDs numéricos)
Public Class PrestamoInput
    Public Property IdUsuario As Integer
    Public Property IdLibro As Integer
End Class
