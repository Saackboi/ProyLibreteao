Imports System.Data.SqlClient


Public Class Database
    'Private conn As New Conexion()

    ' Ejecutar INSERT / UPDATE / DELETE
    Public Function ExecuteNonQuery(query As String, parameters As List(Of SqlParameter)) As Integer
        'Using connection = conn.GetConnection()
        '  Using cmd As New SqlCommand(query, connection)
        If parameters IsNot Nothing Then
            '      cmd.Parameters.AddRange(parameters.ToArray())
        End If

        '   connection.Open()
        '   Return cmd.ExecuteNonQuery()
        ' End Using
        ' End Using
    End Function

        ' Ejecutar SELECT y devolver DataTable
        Public Function ExecuteQuery(query As String, parameters As List(Of SqlParameter)) As DataTable
            Dim dt As New DataTable()

        '  Using connection = conn.GetConnection()
        'Using cmd As New SqlCommand(query, connection)
        If parameters IsNot Nothing Then
            '        cmd.Parameters.AddRange(parameters.ToArray())
        End If

        'connection.Open()

        '  Using reader = cmd.ExecuteReader()
        ' dt.Load(reader)
        'End Using
        '   End Using
        'End Using

        Return dt
        End Function

    End Class



