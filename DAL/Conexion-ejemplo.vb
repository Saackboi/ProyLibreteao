' Conexion-ejemplo.vb
' CADENA DE EJEMPLO - COPIA ESTE ARCHIVO, RENOMBRALO A 'Conexion.vb' Y PON TUS DATOS
Imports System.Data.SqlClient

Public Class Conexion_ejemplo
    Private connectionString As String =
            "Server=localhost;Database=libretiaoDB;User Id=libreriaUser;Password=L1br3t40!;"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
    ' ...
End Class
