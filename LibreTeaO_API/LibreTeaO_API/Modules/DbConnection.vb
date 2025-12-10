Imports System.Data.SqlClient

Module DbConnection
    Public Function GetConnection() As SqlConnection
        Dim cn As New SqlConnection("Server=LASUSY;Database=libretiaoDB;User Id=user_lib;Password=123;")
        Return cn
    End Function
End Module