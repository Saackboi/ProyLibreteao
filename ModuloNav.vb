Imports ProyLibreteao.ProyLibreteao


Module ModNavegacion

        ' Cambia el contenido de un formulario según el título del menú
        Public Sub CambiarSeccion(
        titulo As String,
        icono As Image,
        encabezado As ClaseEncabezado,
        panel As Panel,
        Optional contenidoReporte As ClaseReportes = Nothing,
        Optional contenidoConsulta As ClaseConsultas = Nothing)

            encabezado.Actualizar(titulo, icono)

            Select Case titulo.ToUpper()
                Case "REPORTES"
                    If contenidoReporte IsNot Nothing Then
                        contenidoReporte.MostrarReportes()
                    Else
                        LimpiarPanel(panel)
                    End If

                Case "CONSULTAS"
                    If contenidoConsulta IsNot Nothing Then
                        contenidoConsulta.MostrarConsultas()
                    Else
                        LimpiarPanel(panel)
                    End If

                Case Else
                    LimpiarPanel(panel)
            End Select
        End Sub

        ' Limpia el panel de contenido y muestra un mensaje neutro
        Public Sub LimpiarPanel(panel As Panel)
            panel.Controls.Clear()
            panel.Controls.Add(New Label With {
            .Text = "Seleccione una opción del menú.",
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10, FontStyle.Italic),
            .ForeColor = Color.Gray,
            .TextAlign = ContentAlignment.MiddleCenter})
        End Sub

    End Module
