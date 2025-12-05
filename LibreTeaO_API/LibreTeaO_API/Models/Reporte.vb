' Clases para Reportes
Public Class DashboardKpis
    Public Property TotalUsuarios As Integer
    Public Property TotalPrestamos As Integer
    Public Property TotalDevoluciones As Integer
    Public Property TotalCategorias As Integer
    Public Property TotalMultasCount As Integer
End Class

Public Class ActividadSemanal
    Public Property Semana As String
    Public Property CantidadPrestamos As Integer
    Public Property CantidadDevoluciones As Integer
    Public Property Pendientes As Integer
    Public Property TotalMultas As Decimal
End Class

Public Class LibroPopular
    Public Property Titulo As String
    Public Property VecesPrestado As Integer
End Class

Public Class ReporteMulta
    Public Property Usuario As String
    Public Property Libro As String
    Public Property FechaDev As String
    Public Property Monto As Decimal
End Class