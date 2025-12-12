Imports System.Net.Http
Imports Newtonsoft.Json

Public Class FormPrestamos

    Private manejador As ClasePrestamos

    ' ===============================================
    ' LOAD DEL FORMULARIO
    ' ===============================================
    Private Async Sub FormPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        manejador = New ClasePrestamos(dgvPrestamos)

        ' Cargar datos al inicio
        Await manejador.CargarPrestamos()
    End Sub


    ' ===============================================
    ' BOTÓN NUEVO PRÉSTAMO
    ' ===============================================
    Private Async Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Dim f As New FrmInputs()
        f.ShowDialog()

        If Not f.Confirmado Then Exit Sub

        ' VALIDACIÓN
        If String.IsNullOrWhiteSpace(f.Valor1) OrElse
       String.IsNullOrWhiteSpace(f.Valor2) Then

            MessageBox.Show("Debe ingresar ambos valores.")
            Exit Sub
        End If

        Dim idUsuario As Integer
        Dim idLibro As Integer

        If Not Integer.TryParse(f.Valor1, idUsuario) Then
            MessageBox.Show("El ID de usuario no es válido.")
            Exit Sub
        End If

        If Not Integer.TryParse(f.Valor2, idLibro) Then
            MessageBox.Show("El ID del libro no es válido.")
            Exit Sub
        End If

        Try
            Dim ok = Await manejador.CrearPrestamo(idUsuario, idLibro)

            If ok Then
                MessageBox.Show("Préstamo creado correctamente.")
                Await manejador.CargarPrestamos()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub



    ' ===============================================
    ' BOTÓN MARCAR DEVUELTO
    ' ===============================================
    Private Async Sub BtnMarcarDevuelto_Click(sender As Object, e As EventArgs) Handles BtnMarcarDevuelto.Click
        If dgvPrestamos.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un préstamo.")
            Return
        End If

        Try
            Dim idPrestamo As Integer = CInt(dgvPrestamos.CurrentRow.Cells("IdPrestamo").Value)

            Dim ok = Await manejador.MarcarDevuelto(idPrestamo)

            If ok Then
                MessageBox.Show("Libro marcado como devuelto.")
                Await manejador.CargarPrestamos()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    ' ===============================================
    ' BOTÓN EDITAR (vacío porque tu API no tiene PUT EDITAR)
    ' ===============================================
    Private Async Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If dgvPrestamos.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un préstamo para editar.")
            Return
        End If

        Dim idPrestamo = CInt(dgvPrestamos.CurrentRow.Cells("IdPrestamo").Value)

        Dim f As New FrmInputs()
        f.Label1.Text = "Editar préstamo"
        f.lbl1.Text = "Nuevo ID Usuario:"
        f.lbl2.Text = "Nuevo ID Libro:"
        f.ShowDialog()

        If Not f.Confirmado Then Exit Sub

        Dim idUsuario As Integer
        Dim idLibro As Integer

        If Not Integer.TryParse(f.Valor1, idUsuario) Then
            MessageBox.Show("ID usuario inválido")
            Exit Sub
        End If

        If Not Integer.TryParse(f.Valor2, idLibro) Then
            MessageBox.Show("ID libro inválido")
            Exit Sub
        End If

        Dim ok = Await manejador.EditarPrestamo(idPrestamo, idUsuario, idLibro)

        If ok Then
            MessageBox.Show("Préstamo editado correctamente.")
            Await manejador.CargarPrestamos()
        End If
    End Sub



    ' ===============================================
    ' BOTÓN ELIMINAR (vacío porque tu API no tiene DELETE)
    ' ===============================================
    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If dgvPrestamos.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un préstamo para eliminar.")
            Return
        End If

        Dim idPrestamo = CInt(dgvPrestamos.CurrentRow.Cells("IdPrestamo").Value)

        If MessageBox.Show("¿Seguro que desea eliminar este préstamo?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim ok = Await manejador.EliminarPrestamo(idPrestamo)

        If ok Then
            MessageBox.Show("Préstamo eliminado.")
            Await manejador.CargarPrestamos()
        End If
    End Sub



    ' ===============================================
    ' BOTONES DE EXPORTACIÓN
    ' ===============================================
    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Exportador.ExportarExcel(dgvPrestamos)
    End Sub

    Private Sub BtnPDF_Click(sender As Object, e As EventArgs) Handles BtnPDF.Click
        Exportador.ExportarPDF(dgvPrestamos)
    End Sub

    Private Sub BtnWord_Click(sender As Object, e As EventArgs) Handles BtnWord.Click
        Exportador.ExportarWord(dgvPrestamos)
    End Sub

    Private Sub ToolStripTextBoxBuscar_Enter(sender As Object, e As EventArgs) Handles ToolStripTextBoxBuscar.Enter
        If ToolStripTextBoxBuscar.Text = "Buscar Préstamo 🔎" Then
            ToolStripTextBoxBuscar.Clear()
            ToolStripTextBoxBuscar.ForeColor = Color.Black
        End If

    End Sub

    Private Sub ToolStripTextBoxBuscar_Leave(sender As Object, e As EventArgs) Handles ToolStripTextBoxBuscar.Leave
        If ToolStripTextBoxBuscar.Text.Trim() = "" Then
            ToolStripTextBoxBuscar.ForeColor = SystemColors.WindowFrame
            ToolStripTextBoxBuscar.Text = "Buscar Préstamo 🔎"
        End If

    End Sub
    ' Marcar el método como Async y usar Async Sub
    Private Async Sub ToolStripTextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBoxBuscar.TextChanged
        If manejador Is Nothing Then Exit Sub

        Dim texto As String = ToolStripTextBoxBuscar.Text.Trim()

        ' Si está vacío o es el placeholder, recarga todos los préstamos
        If String.IsNullOrWhiteSpace(texto) OrElse texto = "Buscar Préstamo 🔎" Then
            Await manejador.CargarPrestamos()   ' <-- Aquí sí podemos usar Await
        Else
            manejador.BuscarPrestamos(texto)
        End If
    End Sub



End Class
