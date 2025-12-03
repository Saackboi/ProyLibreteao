Imports System.Data.SqlClient
Public Class NuevoUsuario

    Private db As New Database()
    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles btnYaTengo.MouseHover
        btnYaTengo.ForeColor = Color.Black
    End Sub

    Private Sub btnYaTengo_MouseLeave(sender As Object, e As EventArgs) Handles btnYaTengo.MouseLeave
        btnYaTengo.ForeColor = Color.White
    End Sub

    Private Sub btnYaTengo_Click(sender As Object, e As EventArgs) Handles btnYaTengo.Click
        Dim login = New Login()
        login.Show()
        Me.Hide()
    End Sub




    Private auth As New Auth()

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
            If Not ValidarEntrada(txtEmail, "Debe ingresar un correo.") Then Exit Sub
            If Not ValidarEntrada(txtUsuario, "Debe ingresar un usuario.") Then Exit Sub
            If Not ValidarEntrada(txtContrasena, "Debe ingresar una contraseña.") Then Exit Sub

            Dim ok As Boolean = auth.Register(
            txtEmail.Text,
            txtUsuario.Text,
            txtContrasena.Text
        )

            If ok Then
                MsgBox("Usuario registrado correctamente")

                Dim login = New Login()
                login.Show()
                Me.Hide()
            Else
                MsgBox("No se pudo registrar el usuario.")
            End If
        End Sub

        '============================== VALIDACIONES ==========================================
        Private Function ValidarEntrada(txt As TextBox, msg As String)
            If String.IsNullOrWhiteSpace(txt.Text) Then
                MsgBox(msg)
                txt.Focus()
                Return False
            Else
                Return True
            End If
        End Function


End Class
