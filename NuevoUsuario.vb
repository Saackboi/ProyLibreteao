Imports System.Drawing

Public Class NuevoUsuario

    ' =========================================================================
    ' EVENTOS VISUALES (Botón "Ya tengo cuenta")
    ' =========================================================================
    Private Sub btnYaTengo_MouseHover(sender As Object, e As EventArgs) Handles btnYaTengo.MouseHover
        btnYaTengo.ForeColor = Color.Black
        btnYaTengo.Cursor = Cursors.Hand
    End Sub

    Private Sub btnYaTengo_MouseLeave(sender As Object, e As EventArgs) Handles btnYaTengo.MouseLeave
        btnYaTengo.ForeColor = Color.White
    End Sub

    Private Sub btnYaTengo_Click(sender As Object, e As EventArgs) Handles btnYaTengo.Click
        Dim login = New Login()
        login.Show()
        Me.Hide()
    End Sub

    ' =========================================================================
    ' LÓGICA DE REGISTRO
    ' =========================================================================
    Private Async Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        ' 1. Validaciones Locales
        If Not ValidarEntrada(txtEmail, "Debe ingresar un correo.") Then Exit Sub
        If Not ValidarEntrada(txtUsuario, "Debe ingresar un usuario.") Then Exit Sub
        If Not ValidarEntrada(txtContrasena, "Debe ingresar una contraseña.") Then Exit Sub

        ' 2. Crear objeto para enviar
        Dim nuevoUsuario As New UsuarioInput With {
            .Correo = txtEmail.Text.Trim(),
            .Nombre = txtUsuario.Text.Trim(),
            .Contrasena = txtContrasena.Text.Trim(),
            .TipoUsuario = "cliente" ' Por defecto, quien se registra solo es cliente
        }

        ' 3. Deshabilitar botón para evitar doble clic
        btnRegistrarse.Enabled = False
        btnRegistrarse.Text = "Registrando..."

        Try
            ' 4. Llamada a la API (POST api/usuarios)
            ' Usamos Object o String porque la API devuelve un mensaje de texto simple
            Await ApiService.PostAsync(Of Object)("usuarios", nuevoUsuario)

            MessageBox.Show("Usuario registrado correctamente. Ahora puede iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 5. Redirigir al Login
            Dim login = New Login()
            login.Show()
            Me.Hide()

        Catch ex As Exception
            ' Si el correo ya existe, la API devuelve error 400 y cae aquí
            MessageBox.Show(ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Restaurar botón
            btnRegistrarse.Enabled = True
            btnRegistrarse.Text = "Registrarse"
        End Try
    End Sub

    ' =========================================================================
    ' VALIDACIONES AUXILIARES
    ' =========================================================================
    Private Function ValidarEntrada(txt As TextBox, msg As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            MessageBox.Show(msg, "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        Else
            Return True
        End If
    End Function

End Class