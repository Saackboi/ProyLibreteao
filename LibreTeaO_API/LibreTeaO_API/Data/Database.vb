Imports System.Data.SqlClient

Public Class Database

    Private ReadOnly connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("LibreTeaOConnection").ConnectionString
    End Sub

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

    Public Function ExecuteQuery(sql As String, params As List(Of SqlParameter)) As DataTable
        Dim dt As New DataTable()

        Using conn = GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
                conn.Open()
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using

        Return dt
    End Function

    Public Function ExecuteNonQuery(sql As String, params As List(Of SqlParameter)) As Integer
        Using conn = GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

End Class
