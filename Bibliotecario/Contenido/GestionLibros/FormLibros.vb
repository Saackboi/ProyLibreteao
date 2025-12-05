Imports System.Drawing

Public Class FormLibros

    ' Instancia de la lógica (ClaseContenidoLibros debe estar creada como te mostré antes)
    Private gestorLibros As ClaseContenidoLibros

    Private Sub FormLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializamos la clase lógica pasando el Grid que acabamos de diseñar
        gestorLibros = New ClaseContenidoLibros(dgvLibros)

        ' Estética inicial del textbox de búsqueda
        txtBusqueda.AutoSize = False
        txtBusqueda.Size = New Size(300, 30)

        ' Cargar los datos
        gestorLibros.MostrarCatalogo()
    End Sub

    ' EVENTO BUSCAR
    ' Se activa al hacer clic o cambiar texto (puedes elegir el evento que prefieras)
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        ' Evitamos buscar el placeholder
        If txtBusqueda.Text <> " 🔍 Buscar libro..." Then
            gestorLibros.MostrarCatalogo(txtBusqueda.Text.Trim())
        End If
    End Sub

    ' Placeholder (Texto de ayuda)
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
            gestorLibros.MostrarCatalogo() ' Restaurar lista completa
        End If
    End Sub

    ' BOTONES DE ACCIÓN
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        txtBusqueda.Text = " 🔍 Buscar libro..."
        txtBusqueda.ForeColor = Color.Gray
        gestorLibros.MostrarCatalogo()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        gestorLibros.EliminarLibroSeleccionado()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MessageBox.Show("Aquí se abrirá el formulario para agregar libros", "En Desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class