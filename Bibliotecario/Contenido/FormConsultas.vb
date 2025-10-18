Imports ProyLibreteao.ProyLibreteao

Public Class FormConsultas

    Private codigoEncabezado As ClaseEncabezado
    Private codigoNavegacion As ClaseNav
    Private codigoContenidoConsultas As ClaseConsultas

    Private Sub FormConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar clases auxiliares
        codigoEncabezado = New ClaseEncabezado(lblTituloMenuEncabezado, pb2seccionMenuNav)
        codigoNavegacion = New ClaseNav()
        'codigoContenidoConsultas = New ClaseConsultas(PanelContenido)

        ' Vincular evento de navegación
        AddHandler codigoNavegacion.SeSeleccionoOpcion, AddressOf CambiarSeccion

        ' Mostrar mensaje inicial
        PanelContenido.Controls.Clear()
        PanelContenido.Controls.Add(New Label With {
            .Text = "Seleccione una opción del menú.",
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10, FontStyle.Italic),
            .ForeColor = Color.Gray,
            .TextAlign = ContentAlignment.MiddleCenter
        })

        ' Vincular todos los ToolStripMenuItems del menú
        For Each item As ToolStripMenuItem In msMenuNavegacion.Items.OfType(Of ToolStripMenuItem)()
            AddHandler item.Click, AddressOf codigoNavegacion.ManejarClick
            AgregarHandlerRecursivo(item)
        Next
    End Sub

    ' Recursivo: para submenús
    Private Sub AgregarHandlerRecursivo(parent As ToolStripMenuItem)
        For Each subItem As ToolStripMenuItem In parent.DropDownItems.OfType(Of ToolStripMenuItem)()
            AddHandler subItem.Click, AddressOf codigoNavegacion.ManejarClick
            AgregarHandlerRecursivo(subItem)
        Next
    End Sub

    ' Reacciona cuando se selecciona una opción en el menú
    Private Sub CambiarSeccion(titulo As String, icono As Image)
        codigoEncabezado.Actualizar(titulo, icono)

        If titulo = "CONSULTAS" Then
            codigoContenidoConsultas.MostrarConsultas()
        Else
            PanelContenido.Controls.Clear()
        End If
    End Sub

End Class
