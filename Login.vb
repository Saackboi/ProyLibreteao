Imports System.Text.RegularExpressions

Public Class Login
    '====================================== VARIABLES DE EJEMPLO PARA AUTENTICACIÓN=====================================================
    Private Const usuarioCorrecto As String = "pan"
    Private Const contrasenaCorrecta As String = "123@"

    '====================================== BOTONES =====================================================
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        NuevoUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click

        ' Validacion de campo lleno y formato (letras y números para el usuario)
        If Not ValidarEntrada(txtUsuario, "Debe ingresar un usuario.", "^[a-zA-ZÁÉÍÓÚáéíóúÑñ0-9]+$", "Solo se permiten letras y números en el nombre de usuario.") Then Exit Sub

        ' Validacion de campo lleno y formato (letras, números y caracteres especiales para la contraseña)
        If Not ValidarEntrada(txtContrasena, "Debe ingresar una contraseña.", "^.+$", "La contraseña contiene caracteres no válidos.") Then Exit Sub

        ' Validacion de credenciales
        If Not txtUsuario.Text = usuarioCorrecto Or Not txtContrasena.Text = contrasenaCorrecta Then
            MessageBox.Show("Usuario o contraseña incorrecto", "Error al iniciar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Bienvenida al usuario (si todas la validaciones pasan)
        MessageBox.Show("Bienvenido al sistema, " + usuarioCorrecto + "!", "Inicio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ///////////////////////////   ' Subrutina para pruebas rapidas (eliminar al finalizar)/////////////////////////////////////////
    Public Function IniciarSesion(txtUsuario As TextBox, txtContrasena As TextBox) As Boolean
        ' Validación de campo lleno y formato (letras y números para el usuario)
        If Not ValidarEntrada(txtUsuario, "Debe ingresar un usuario.", "^[a-zA-ZÁÉÍÓÚáéíóúÑñ0-9]+$", "Solo se permiten letras y números en el nombre de usuario.") Then
            Return False
        End If

        ' Validación de campo lleno y formato (letras, números y caracteres especiales para la contraseña)
        If Not ValidarEntrada(txtContrasena, "Debe ingresar una contraseña.", "^.+$", "La contraseña contiene caracteres no válidos.") Then
            Return False
        End If

        ' Si todo está correcto
        MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function

    '-------------------------------------------- EFECTOS MOUSE -------------------------------------------------------------
    Private Sub btnEntrarInvitado_MouseHover(sender As Object, e As EventArgs) Handles btnEntrarInvitado.MouseHover
        btnEntrarInvitado.ForeColor = Color.LightSkyBlue
        btnEntrarInvitado.Cursor = Cursors.Hand
        btnEntrarInvitado.Font = New Font(btnEntrarInvitado.Font, FontStyle.Underline)
    End Sub

    Private Sub btnEntrarInvitado_MouseLeave(sender As Object, e As EventArgs) Handles btnEntrarInvitado.MouseLeave
        btnEntrarInvitado.ForeColor = Color.White
        btnEntrarInvitado.Font = New Font(btnRegistrarse.Font, FontStyle.Regular)
    End Sub

    Private Sub btnRegistrarse_MouseHover(sender As Object, e As EventArgs) Handles btnRegistrarse.MouseHover
        btnRegistrarse.ForeColor = Color.LightSkyBlue
        btnRegistrarse.Cursor = Cursors.Hand
        btnRegistrarse.Font = New Font(btnRegistrarse.Font, FontStyle.Underline)
    End Sub

    Private Sub btnRegistrarse_MouseLeave(sender As Object, e As EventArgs) Handles btnRegistrarse.MouseLeave
        btnRegistrarse.ForeColor = Color.White
        btnRegistrarse.Font = New Font(btnRegistrarse.Font, FontStyle.Regular)
    End Sub

    Private Sub btnIniciarSesion_MouseHover(sender As Object, e As EventArgs) Handles btnIniciarSesion.MouseHover
        btnIniciarSesion.Cursor = Cursors.Hand
    End Sub

    '====================================================== VALIDACIONES ======================================================
    Private Function ValidarEntrada(txt As TextBox, msgVacio As String, patronRegex As String, msgFormato As String) As Boolean

        If String.IsNullOrWhiteSpace(txt.Text) Then
            MessageBox.Show(msgVacio, "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt.Focus()
            Return False
        End If

        If Not Regex.IsMatch(txt.Text, patronRegex) Then
            MessageBox.Show(msgFormato, "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnEntrarInvitado_Click(sender As Object, e As EventArgs) Handles btnEntrarInvitado.Click
        Interface_invitados.Show()
        Me.Hide()
    End Sub
    '======================== CENTRAR PANEL ===========================
    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel2.Left = (Me.ClientSize.Width - Panel2.Width) / 2
        Panel2.Top = (Me.ClientSize.Height - Panel2.Height) / 2
    End Sub

    '======================== CARGAR EL COMBOBOX ===========================
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTipoUsuario.SelectedIndex = 0
    End Sub
End Class