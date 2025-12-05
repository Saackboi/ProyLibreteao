Imports System.Data.SqlClient

Module DbConnection
    Public Function GetConnection() As SqlConnection
        Dim cn As New SqlConnection("Server=localhost;Database=libretiaoDB;User Id=libreriaUser;Password=L1br3t40!;")
        Return cn
    End Function
End Module
