Public Class FormUsuarios

    ' Instancia de la lógica conectada a la API
    Private gestorUsuarios As ClaseContenidoUsuarios
    Private modoAccion As String ' "agregar" o "modificar"

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Vinculación al DataGridView correcto
        gestorUsuarios = New ClaseContenidoUsuarios(dgvUsuarios)

        ' Buscador con placeholder
        txtBusqueda.AutoSize = False
        txtBusqueda.Text = " 🔍 Buscar usuario..."
        txtBusqueda.ForeColor = Color.Gray
        txtBusqueda.Size = New Size(300, 30)

        gestorUsuarios.MostrarUsuarios()

        pnlInput.Visible = False
    End Sub

    ' ============================================================
    ' BUSCAR
    ' ============================================================
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text <> " 🔍 Buscar usuario..." Then
            gestorUsuarios.MostrarUsuarios(txtBusqueda.Text.Trim())
        End If
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = " 🔍 Buscar usuario..." Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            txtBusqueda.Text = " 🔍 Buscar usuario..."
            txtBusqueda.ForeColor = Color.Gray
            gestorUsuarios.MostrarUsuarios()
        End If
    End Sub


    ' ============================================================
    ' BOTONES DE ACCIÓN
    ' ============================================================
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        txtBusqueda.Text = " 🔍 Buscar usuario..."
        txtBusqueda.ForeColor = Color.Gray
        gestorUsuarios.MostrarUsuarios()
    End Sub

    Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Await gestorUsuarios.EliminarUsuarioSeleccionado()
    End Sub


    ' ============================================================
    ' PANEL DE INPUT
    ' ============================================================
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        txtInputNombreUsuario.Clear()
        modoAccion = "agregar"

        pnlInput.Location = New Point(
            (Me.Width - pnlInput.Width) \ 2,
            (Me.Height - pnlInput.Height) \ 2
        )

        lblPanelInput.Text = "Datos del nuevo usuario"
        pnlInput.Visible = True
        pnlInput.BringToFront()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If dgvUsuarios.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario primero.")
            Return
        End If

        modoAccion = "modificar"
        txtInputNombreUsuario.Clear()

        pnlInput.Location = New Point(
            (Me.Width - pnlInput.Width) \ 2,
            (Me.Height - pnlInput.Height) \ 2
        )

        lblPanelInput.Text = "Modificar nombre del usuario"

        txtInputNombreUsuario.Text =
            dgvUsuarios.SelectedRows(0).Cells(1).Value.ToString()

        pnlInput.Visible = True
        pnlInput.BringToFront()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlInput.Visible = False
    End Sub


    ' ============================================================
    ' GUARDAR (Agregar / Modificar)
    ' ============================================================
    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If String.IsNullOrWhiteSpace(txtInputNombreUsuario.Text) Then
            MessageBox.Show("El nombre del usuario es obligatorio.")
            Return
        End If

        btnGuardar.Enabled = False
        btnGuardar.Text = "Guardando..."

        Try
            Dim exito As Boolean = False

            Select Case modoAccion
                Case "agregar"
                    exito = Await gestorUsuarios.AgregarUsuario(txtInputNombreUsuario.Text.Trim(), txtCorreoUsuario.Text.Trim(), txtContraUsuario.Text.Trim(), "cliente")

                Case "modificar"
                    exito = Await gestorUsuarios.ModificarUsuarioSeleccionado(txtInputNombreUsuario.Text.Trim(), txtCorreoUsuario.Text.Trim(), txtContraUsuario.Text.Trim(), "cliente")

                Case Else
                    MessageBox.Show("Error interno.")
                    Return
            End Select

            If exito Then
                pnlInput.Visible = False
                gestorUsuarios.MostrarUsuarios()
            End If

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)

        Finally
            btnGuardar.Enabled = True
            btnGuardar.Text = "GUARDAR USUARIO"
        End Try
    End Sub

End Class
