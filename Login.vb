Public Class Login

    '====================================== BOTONES =====================================================
    Private Sub btnRegistrase_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        NuevoUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If Not ValidarEntrada(txtUsuario, "Debe ingresar un usuario.") Then Exit Sub
        If Not ValidarEntrada(txtContrasena, "Debe ingresar una contraseña.") Then Exit Sub
        MsgBox("´Bienvenido al sistema!")
    End Sub


    '-------------------------------------------- EFECTOS MOUSE -------------------------------------------------------------
    Private Sub btnEntrarInvitado_MouseHover(sender As Object, e As EventArgs) Handles btnEntrarInvitado.MouseHover
        btnEntrarInvitado.ForeColor = Color.Black
    End Sub

    Private Sub btnEntrarInvitado_MouseLeave(sender As Object, e As EventArgs) Handles btnEntrarInvitado.MouseLeave
        btnEntrarInvitado.ForeColor = Color.White
    End Sub

    Private Sub btnRegistrarse_MouseHover(sender As Object, e As EventArgs) Handles btnRegistrarse.MouseHover
        btnRegistrarse.ForeColor = Color.Black
    End Sub

    Private Sub btnRegistrarse_MouseLeave(sender As Object, e As EventArgs) Handles btnRegistrarse.MouseLeave
        btnRegistrarse.ForeColor = Color.White
    End Sub

    '====================================================== VALIDACIONES ======================================================
    Private Function ValidarEntrada(txt As TextBox, msg As String)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            MsgBox(msg)
            txt.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnEntrarInvitado_Click(sender As Object, e As EventArgs) Handles btnEntrarInvitado.Click
        Interface_invitados.Show()
        Me.Hide()
    End Sub
End Class