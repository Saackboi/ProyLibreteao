Public Class FormAutores

    ' Instancia de la lógica (Ahora conectada a la API)
    Private gestorAutores As ClaseContenidoAutores
    Private modoAccion As String ' "agregar" o "modificar"
    Private Sub FormAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gestorAutores = New ClaseContenidoAutores(dgvAutores)

        ' Ajuste visual del buscador
        txtBusqueda.AutoSize = False
        txtBusqueda.Text = " 🔍 Buscar autor..."
        txtBusqueda.ForeColor = Color.Gray
        txtBusqueda.Size = New Size(300, 30)

        ' Cargar datos iniciales (Async fire-and-forget)
        gestorAutores.MostrarAutores()

        ' Asegurar que el panel empiece oculto
        pnlInput.Visible = False
    End Sub

    ' ==========================================
    ' EVENTOS DE BÚSQUEDA
    ' ==========================================
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text <> " 🔍 Buscar autor..." Then
            gestorAutores.MostrarAutores(txtBusqueda.Text.Trim())
        End If
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = " 🔍 Buscar autor..." Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            txtBusqueda.Text = " 🔍 Buscar autor..."
            txtBusqueda.ForeColor = Color.Gray
            gestorAutores.MostrarAutores()
        End If
    End Sub

    ' ==========================================
    ' BOTONES DE ACCIÓN (ACTUALIZAR / ELIMINAR)
    ' ==========================================
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        txtBusqueda.Text = " 🔍 Buscar autor..."
        txtBusqueda.ForeColor = Color.Gray
        gestorAutores.MostrarAutores()
    End Sub

    ' Convertimos a ASYNC para poder esperar la confirmación de la API si fuera necesario
    Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Llamada directa: Se ejecuta en el hilo principal pero espera a la API sin congelar
        Await gestorAutores.EliminarAutorSeleccionado()
    End Sub

    ' ==========================================
    ' LÓGICA DEL PANEL DE INPUT
    ' ==========================================
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' 1. Limpiar campos
        txtInputNombreAutor.Clear()

        modoAccion = "agregar"  ' ← cuando se guarde desde el panel , será una adición

        ' 2. Centrar el panel
        pnlInput.Location = New Point(
            (Me.Width - pnlInput.Width) \ 2,
            (Me.Height - pnlInput.Height) \ 2
        )

        ' 3. Mostrar
        lblPanelInput.Text = "Nombre del nuevo autor"
        pnlInput.Visible = True
        pnlInput.BringToFront()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtInputNombreAutor.Clear()

        modoAccion = "modificar" ' ←  cuando se guarde desde el panel , será una modificación

        pnlInput.Location = New Point(
            (Me.Width - pnlInput.Width) \ 2,
            (Me.Height - pnlInput.Height) \ 2
        )


        lblPanelInput.Text = "Nuevo nombre para la categoria"
        If dgvAutores.SelectedRows.Count <> 0 Then txtInputNombreAutor.Text = dgvAutores.SelectedRows(0).Cells(1).Value.ToString()
        pnlInput.Visible = True
        pnlInput.BringToFront()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlInput.Visible = False
    End Sub

    ' BOTÓN GUARDAR (IMPORTANTE: Es Async)
    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' Validación básica
        If String.IsNullOrWhiteSpace(txtInputNombreAutor.Text) Then
            MessageBox.Show("El nombre del autor es obligatorio.")
            Return
        End If

        ' Evitar doble clic y mostrar estado
        btnGuardar.Enabled = False
        btnGuardar.Text = "Guardando..."

        Try
            Dim exito As Boolean = False

            ' Elegir acción según cómo se abrió el panel
            Select Case modoAccion
                Case "agregar"
                    exito = Await gestorAutores.AgregarAutor(txtInputNombreAutor.Text.Trim())

                Case "modificar"
                    exito = Await gestorAutores.ModificarAutorSeleccionado(txtInputNombreAutor.Text.Trim())

                Case Else
                    MessageBox.Show("Error interno: No se especificó la acción.")
                    Return
            End Select

            ' Si la operación fue exitosa, cerrar panel y refrescar tabla
            If exito Then
                pnlInput.Visible = False
                gestorAutores.MostrarAutores()
            End If

        Catch ex As Exception
            ' Captura de errores inesperados
            MessageBox.Show("Error inesperado: " & ex.Message)

        Finally
            ' Restaurar botón siempre
            btnGuardar.Enabled = True
            btnGuardar.Text = "GUARDAR"
        End Try

    End Sub


End Class