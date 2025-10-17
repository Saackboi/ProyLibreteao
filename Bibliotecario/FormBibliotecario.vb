

Imports ProyLibreteao
Public Class FormBibliotecario

    Private ucReportes = New UCCReportes1()

    ' Evento que se dispara al seleccionar un ítem del menú
    Public Event ItemSeleccionado(ByVal imagen As Image, ByVal texto As String)

    ' Al cargar el formulario, muestra un mensaje inicial
    Private Sub FormBibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Conectar el evento al método que actualiza el encabezado
        AddHandler ItemSeleccionado, AddressOf ActualizarEncabezado


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

    ' Muestra mensaje inicial
    Private Sub MostrarMensajeInicial()
        PanelContenido.Controls.Clear()
        PanelContenido.Controls.Add(New Label With {
            .Text = "Seleccione una opción del menú.",
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10, FontStyle.Italic),
            .ForeColor = Color.Gray,
            .TextAlign = ContentAlignment.MiddleCenter
        })
    End Sub

    ' Maneja los clics de los botones del menú de navegación
    Private Sub MenuStripMenuNavegacion_Click(sender As Object, e As EventArgs) _
        Handles btn_NavInicioToolStripMenuItem.Click,
                btn_NavLIBROSToolStripMenuItem.Click,
                btn_NavPRESTAMOSToolStripMenuItem.Click,
    btn_NavMENSAJERÍAToolStripMenuItem.Click,
                btn_NavCLIENTESToolStripMenuItem.Click,
                btn_NavVISTASToolStripMenuItem.Click,
                btn_NavREPORTESToolStripMenuItem.Click,
                btn_NavSOLICITUDToolStripMenuItem.Click, btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Click,
                btn_NavCONSULTASToolStripMenuItem.Click

        Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        Select Case item.Name
            Case "btn_NavInicioToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoInicio, "INICIO")

                MostrarMensajeInicial()


            Case "btn_NavLIBROSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoLibros, "LIBROS")

                MostrarMensajeInicial()


            Case "btn_NavPRESTAMOSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoPrestamo, "PRÉSTAMOS")

                MostrarMensajeInicial()


            Case "btn_NavMENSAJERIAToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconomensajería, "MENSAJERÍA")

            Case "btn_NavCLIENTESToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoClientes, "CLIENTES")

                MostrarMensajeInicial()


            Case "btn_NavVISTASToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoVista, "VISTAS")

                MostrarMensajeInicial()


            Case "btn_NavREPORTESToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoReportes, "REPORTES")


            Case "btn_NavSOLICITUDToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoSolicitud, "SOLICITUD DE LIBROS")

                MostrarMensajeInicial()


            Case "btn_NavGESTIONDECATALOGOSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoGestionarCatálogo, "GESTIÓN DE CATÁLOGO")

                MostrarMensajeInicial()


            Case "btn_NavCONSULTASToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoPreguntas, "CONSULTAS")

                MostrarMensajeInicial()

        End Select
    End Sub

    ' Actualiza el encabezado con una nueva imagen y texto
    Private Sub ActualizarEncabezado(ByVal nuevaImagen As Image, ByVal nuevoTexto As String)
        PictureBox2.Image = nuevaImagen
        lblTituloMenuEncabezado.Text = nuevoTexto
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        FormFiltro.ShowDialog()
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
