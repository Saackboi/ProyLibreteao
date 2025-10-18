Namespace ProyLibreteao
    Public Class ClaseReportes
        Private panelContenido As Panel
        Private dgvActividad As DataGridView
        Private tlpReporte As TableLayoutPanel
        Private tabControl As TabControl
        Private lblTituloTab As Label
        Private btnFiltro As Button


        Public Sub New(panel As Panel, dgv As DataGridView, tlp As TableLayoutPanel, tab As TabControl, lblTitulo As Label, btnFiltroReporte As Button)
            panelContenido = panel
            dgvActividad = dgv
            tlpReporte = tlp
            tabControl = tab
            lblTituloTab = lblTitulo
            btnFiltro = btnFiltroReporte

            ' Configurar TabControl (solo una vez)
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed
            tabControl.BackColor = Color.White
            AddHandler tabControl.DrawItem, AddressOf TabControl_DrawItem
            AddHandler tabControl.SelectedIndexChanged, AddressOf TabControl_SelectedIndexChanged
        End Sub






        '============================
        ' Mostrar sección de reportes
        '============================
        Public Sub MostrarReportes()
            panelContenido.Controls.Clear()
            tlpReporte.Dock = DockStyle.Fill
            panelContenido.Controls.Add(tlpReporte)

            ' Limpiar y configurar DataGridView
            dgvActividad.Columns.Clear()
            dgvActividad.Rows.Clear()

            dgvActividad.Columns.Add("Semana", "Semana")
            dgvActividad.Columns.Add("Prestamos", "Préstamos")
            dgvActividad.Columns.Add("Devoluciones", "Devolución")
            dgvActividad.Columns.Add("LibrosNoDevueltos", "Libros No Devueltos")
            dgvActividad.Columns.Add("Multas", "Multas")

            ' Filas de ejemplo
            dgvActividad.Rows.Add("1 - 7 de octubre", 100, 90, 10, 9)
            dgvActividad.Rows.Add("8 - 14 de octubre", 80, 75, 5, 8)
        End Sub


        '============================
        ' diseño del TabControl 
        '============================
        Private Sub TabControl_DrawItem(sender As Object, e As DrawItemEventArgs)
            Dim g As Graphics = e.Graphics
            Dim tab As TabPage = tabControl.TabPages(e.Index)
            Dim rect = e.Bounds

            ' Colores del tema lavanda
            Dim colorSeleccionado As Color = Color.FromArgb(37, 33, 59)
            Dim colorTexto As Color = If(e.Index = tabControl.SelectedIndex, colorSeleccionado, Color.FromArgb(110, 104, 147))

            ' Fondo del tab
            g.FillRectangle(New SolidBrush(tabControl.BackColor), rect)

            ' Texto centrado
            Dim sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            g.DrawString(tab.Text, tabControl.Font, New SolidBrush(colorTexto), rect, sf)

            ' Subrayado solo si está seleccionado
            If e.Index = tabControl.SelectedIndex Then
                g.FillRectangle(New SolidBrush(colorSeleccionado), rect.X + 10, rect.Bottom - 2, rect.Width - 20, 3)
            End If
        End Sub


        '============================
        ' 🔹 Cambio de pestaña
        '============================
        Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs)
            lblTituloTab.Text = tabControl.SelectedTab.Text
        End Sub

    End Class
End Namespace
