Public Class UserControlContenidoReportes1
    ' Cambia el texto del Label1 por el título  de la pestaña seleccionada

    Private Sub btnDescargarReportes_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Cargando Reportes...")

    End Sub

    Private Sub UserControlContenidoReportes1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewTablaActividadSemanal.Columns.Clear()

        DataGridViewTablaActividadSemanal.Columns.Add("Semana", "Semana")
        DataGridViewTablaActividadSemanal.Columns.Add("Prestamos", "Préstamos")
        DataGridViewTablaActividadSemanal.Columns.Add("Devoluciones", "Devolución")
        DataGridViewTablaActividadSemanal.Columns.Add("LibrosNoDevueltos", "Libros No Devueltos")
        DataGridViewTablaActividadSemanal.Columns.Add("Multas", "Multas")
        '  filas  de ejemplo
        DataGridViewTablaActividadSemanal.Rows.Add("1 - 7 de octubre", 100, 90, 10, 9)
        DataGridViewTablaActividadSemanal.Rows.Add("8 - 14 de octubre", 80, 75, 5, 8)

    End Sub


    'Muestra el formulario de filtros de periodo al hacer clic en el botón
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        FormContenidoReportesActividadSemanalFiltrosDePeriodo.ShowDialog()
    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControlContenidoReportes.DrawItem
        Dim g As Graphics = e.Graphics
        Dim tab As TabPage = TabControlContenidoReportes.TabPages(e.Index)
        Dim rect = e.Bounds


        ' Colores del tema lavanda
        Dim colorSeleccionado As Color = Color.FromArgb(37, 33, 59)
        Dim colorTexto As Color = If(e.Index = TabControlContenidoReportes.SelectedIndex, colorSeleccionado, Color.FromArgb(110, 104, 147))

        ' Fondo del tab
        g.FillRectangle(New SolidBrush(TabControlContenidoReportes.BackColor), rect)

        ' Texto centrado
        Dim sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        g.DrawString(tab.Text, TabControlContenidoReportes.Font, New SolidBrush(colorTexto), rect, sf)

        ' Subrayado solo si está seleccionado
        If e.Index = TabControlContenidoReportes.SelectedIndex Then
            g.FillRectangle(New SolidBrush(colorSeleccionado), rect.X + 10, rect.Bottom - 2, rect.Width - 20, 3)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Descargando Reportes...")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Descargando Reportes...")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Descargando Reportes...")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Descargando Reportes...")
    End Sub


    Private Sub TabControlContenidoReportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlContenidoReportes.SelectedIndexChanged
        ' Cambia el texto del Label del titulo al nombre de la pestaña  que selecciones
        lblTituloTabControl.Text = TabControlContenidoReportes.SelectedTab.Text
    End Sub

End Class
