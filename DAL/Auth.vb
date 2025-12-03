Imports System.Data.SqlClient

Public Class Auth

    Private db As New Database()

    ' ===========================
    '   REGISTRO DE NUEVO USUARIO
    ' ===========================
    Public Function Register(email As String, usuario As String, contrasena As String) As Boolean
        Dim query As String =
            "INSERT INTO usuario (correo, nombre, contraseña, tipo_usuario)
             VALUES (@correo, @nombre, @contrasena, 'cliente')"

        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@correo", email),
            New SqlParameter("@nombre", usuario),
            New SqlParameter("@contrasena", contrasena)
        }

        Try
            Dim filas As Integer = db.ExecuteNonQuery(query, params)
            Return filas = 1

        Catch ex As Exception
            MsgBox("Error al registrar usuario: " & ex.Message)
            Return False
        End Try
    End Function

    ' ===========================
    '   LOGIN
    ' ===========================
    Public Function Login(nombre As String, contrasena As String, tipo As String) As DataRow

        Dim query As String =
            "SELECT * FROM usuario 
             WHERE nombre = @nombre 
               AND contraseña = @contrasena
               AND tipo_usuario = @tipo"

        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@nombre", nombre),
            New SqlParameter("@contrasena", contrasena),
            New SqlParameter("@tipo", tipo)
        }

        Dim result As DataTable = db.ExecuteQuery(query, params)

        If result.Rows.Count = 1 Then
            Return result.Rows(0)
        Else
            Return Nothing
        End If
    End Function

End Class
