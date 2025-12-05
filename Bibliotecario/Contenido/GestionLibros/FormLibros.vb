Public Class FormLibros

    ' Instancia de la lógica (Ahora conectada a la API)
    Private gestorLibros As ClaseContenidoLibros

    Private Sub FormLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gestorLibros = New ClaseContenidoLibros(dgvLibros)

        ' Ajuste visual del buscador
        txtBusqueda.AutoSize = False
        txtBusqueda.Size = New Size(300, 30)

        ' Cargar datos iniciales (Async fire-and-forget)
        gestorLibros.MostrarCatalogo()

        gestorLibros.LlenarCombos(cmbNuevoAutor, cmbNuevaCategoria)

        ' Asegurar que el panel empiece oculto
        pnlNuevoLibro.Visible = False
    End Sub

    ' ==========================================
    ' EVENTOS DE BÚSQUEDA
    ' ==========================================
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text <> " 🔍 Buscar libro..." Then
            gestorLibros.MostrarCatalogo(txtBusqueda.Text.Trim())
        End If
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If txtBusqueda.Text = " 🔍 Buscar libro..." Then
            txtBusqueda.Text = ""
            txtBusqueda.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If String.IsNullOrWhiteSpace(txtBusqueda.Text) Then
            txtBusqueda.Text = " 🔍 Buscar libro..."
            txtBusqueda.ForeColor = Color.Gray
            gestorLibros.MostrarCatalogo()
        End If
    End Sub

    ' ==========================================
    ' BOTONES DE ACCIÓN (ACTUALIZAR / ELIMINAR)
    ' ==========================================
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        txtBusqueda.Text = " 🔍 Buscar libro..."
        txtBusqueda.ForeColor = Color.Gray
        gestorLibros.MostrarCatalogo()
    End Sub

    ' Convertimos a ASYNC para poder esperar la confirmación de la API si fuera necesario
    Private Async Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Llamada directa: Se ejecuta en el hilo principal pero espera a la API sin congelar
        Await gestorLibros.EliminarLibroSeleccionado()
    End Sub

    ' ==========================================
    ' LÓGICA DEL PANEL "AGREGAR LIBRO"
    ' ==========================================
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' 1. Limpiar campos
        txtNuevoTitulo.Clear()
        txtDescripcion.Clear()
        cmbNuevoAutor.SelectedIndex = -1
        cmbNuevaCategoria.SelectedIndex = -1

        ' 2. Centrar el panel
        pnlNuevoLibro.Location = New Point(
            (Me.Width - pnlNuevoLibro.Width) \ 2,
            (Me.Height - pnlNuevoLibro.Height) \ 2
        )

        ' 3. Mostrar
        pnlNuevoLibro.Visible = True
        pnlNuevoLibro.BringToFront()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlNuevoLibro.Visible = False
    End Sub

    ' BOTÓN GUARDAR (IMPORTANTE: Es Async)
    Private Async Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Validaciones simples de UI
        If String.IsNullOrWhiteSpace(txtNuevoTitulo.Text) Then
            MessageBox.Show("El título es obligatorio.")
            Return
        End If

        ' Obtener IDs (Protección contra nulos si no se seleccionó nada)
        Dim idAutor As Integer = 0
        Dim idCat As Integer = 0

        If cmbNuevoAutor.SelectedValue IsNot Nothing Then idAutor = Convert.ToInt32(cmbNuevoAutor.SelectedValue)
        If cmbNuevaCategoria.SelectedValue IsNot Nothing Then idCat = Convert.ToInt32(cmbNuevaCategoria.SelectedValue)

        ' Deshabilitar botón para evitar doble clic
        btnGuardar.Enabled = False
        btnGuardar.Text = "Guardando..."

        Try
            ' LLAMADA A LA API (Esperamos respuesta)
            Dim exito As Boolean = Await gestorLibros.AgregarLibro(
                txtNuevoTitulo.Text.Trim(),
                idAutor,
                idCat,
                txtDescripcion.Text.Trim()
            )

            If exito Then
                pnlNuevoLibro.Visible = False ' Cerrar panel
                gestorLibros.MostrarCatalogo() ' Refrescar tabla
            End If

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
        Finally
            ' Rehabilitar botón siempre
            btnGuardar.Enabled = True
            btnGuardar.Text = "GUARDAR"
        End Try
    End Sub

End Class