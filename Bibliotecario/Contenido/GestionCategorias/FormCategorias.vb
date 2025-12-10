Public Class FormCategorias

    ' Instancia de la lógica (Ahora conectada a la API de Categorías)
    Private gestorCategorias As ClaseContenidoCategorias
    Private modoAccion As String ' "agregar" o "modificar"

    Private Sub FormCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gestorCategorias = New ClaseContenidoCategorias(dgvCategorias)

        ' Ajuste visual del buscador
        txtBusqueda.AutoSize = False
        txtBusqueda.Text = " 🔍 Buscar categoría..."
        txtBusqueda.ForeColor = Color.Gray
        txtBusqueda.Size = New Size(300, 30)

        ' Cargar datos iniciales
        gestorCategorias.MostrarCategorias()

        ' Panel oculto al inicio
        pnlInput.Visible = False
    End Sub

    ' ==========================================
    ' EVENTOS DE BÚSQUEDA
    ' ==========================================
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text <> " 🔍 Buscar categoría..." Then
            gestorCategorias.MostrarCategorias(txtBusqueda.Text.Trim())
        End If
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = " 🔍 Buscar categoría..." Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            txtBusqueda.Text = " 🔍 Buscar categoría..."
            txtBusqueda.ForeColor = Color.Gray
            gestorCategorias.MostrarCategorias()
        End If
    End Sub

    ' ==========================================
    ' BOTONES DE ACCIÓN
    ' ==========================================
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        txtBusqueda.Text = " 🔍 Buscar categoría..."
        txtBusqueda.ForeColor = Color.Gray
        gestorCategorias.MostrarCategorias()
    End Sub

    Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Await gestorCategorias.EliminarCategoriaSeleccionada()
    End Sub

    ' ==========================================
    ' LOGICA DEL PANEL DE INPUT
    ' ==========================================
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtInputNombreCategoria.Clear()

        modoAccion = "agregar"  ' ← cuando se guarde desde el panel , será una adición

        pnlInput.Location = New Point(
            (Me.Width - pnlInput.Width) \ 2,
            (Me.Height - pnlInput.Height) \ 2
        )

        lblPanelInput.Text = "Nombre de la nueva categoría"
        pnlInput.Visible = True
        pnlInput.BringToFront()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtInputNombreCategoria.Clear()

        modoAccion = "modificar" ' ←  cuando se guarde desde el panel , será una modificación

        pnlInput.Location = New Point(
            (Me.Width - pnlInput.Width) \ 2,
            (Me.Height - pnlInput.Height) \ 2
        )


        lblPanelInput.Text = "Nuevo nombre para la categoria"
        If dgvCategorias.SelectedRows.Count <> 0 Then txtInputNombreCategoria.Text = dgvCategorias.SelectedRows(0).Cells(1).Value.ToString()
        pnlInput.Visible = True
        pnlInput.BringToFront()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlInput.Visible = False
    End Sub

    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' Validar que el campo no esté vacío
        If String.IsNullOrWhiteSpace(txtInputNombreCategoria.Text) Then
            MessageBox.Show("El nombre de la categoría es obligatorio.")
            Return
        End If

        ' Evitar doble clic y mostrar estado de procesamiento
        btnGuardar.Enabled = False
        btnGuardar.Text = "Guardando..."

        Try
            Dim exito As Boolean = False

            ' Elegir si se agrega o se modifica según el modo actual
            Select Case modoAccion
                Case "agregar"
                    exito = Await gestorCategorias.AgregarCategoria(txtInputNombreCategoria.Text.Trim())

                Case "modificar"
                    exito = Await gestorCategorias.ModificarCategoriaSeleccionada(txtInputNombreCategoria.Text.Trim())

                Case Else
                    MessageBox.Show("Error interno: No se especificó la acción.")
                    Return
            End Select

            ' Si la operación fue correcta, cerrar el panel y recargar la lista
            If exito Then
                pnlInput.Visible = False
                gestorCategorias.MostrarCategorias()
            End If

        Catch ex As Exception
            ' Manejo de errores inesperados
            MessageBox.Show("Error inesperado: " & ex.Message)

        Finally
            ' Restaurar el botón siempre
            btnGuardar.Enabled = True
            btnGuardar.Text = "GUARDAR"
        End Try

    End Sub


End Class
