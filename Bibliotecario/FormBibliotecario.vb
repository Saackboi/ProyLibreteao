

Imports ProyLibreteao
Public Class FormBibliotecario

    Private ucReportes = New UCCReportes1()

    ' Evento que se dispara al seleccionar un ítem del menú
    Public Event ItemSeleccionado(ByVal imagen As Image, ByVal texto As String)

    ' Al cargar el formulario, muestra un mensaje inicial
    Private Sub FormBibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarMensajeInicial()

        ' Conectar el evento al método que actualiza el encabezado
        AddHandler ItemSeleccionado, AddressOf ActualizarEncabezado
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

            Case "btn_NavLIBROSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoLibros, "LIBROS")

            Case "btn_NavPRESTAMOSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoPrestamo, "PRÉSTAMOS")

            Case "btn_NavMENSAJERIAToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconomensajería, "MENSAJERÍA")

            Case "btn_NavCLIENTESToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoClientes, "CLIENTES")

            Case "btn_NavVISTASToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoVista, "VISTAS")

            Case "btn_NavREPORTESToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoReportes, "REPORTES")
                PanelContenido.Controls.Clear()
                ucReportes.Dock = DockStyle.Fill
                PanelContenido.Controls.Add(ucReportes)


            Case "btn_NavSOLICITUDToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoSolicitud, "SOLICITUD DE LIBROS")

            Case "btn_NavGESTIONDECATALOGOSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoGestionarCatálogo, "GESTIÓN DE CATÁLOGO")

            Case "btn_NavCONSULTASToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoPreguntas, "CONSULTAS")
        End Select
    End Sub

    ' Actualiza el encabezado con una nueva imagen y texto
    Private Sub ActualizarEncabezado(ByVal nuevaImagen As Image, ByVal nuevoTexto As String)
        PictureBox2.Image = nuevaImagen
        lblTituloMenuEncabezado.Text = nuevoTexto
    End Sub

End Class
