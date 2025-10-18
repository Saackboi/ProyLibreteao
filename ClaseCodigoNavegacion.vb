Namespace ProyLibreteao
    Public Class ClaseCodigoNavegacion
        Public Event SeSeleccionoOpcion(titulo As String, icono As Image)

        Public Sub ManejarClick(item As ToolStripMenuItem)
            Select Case item.Name
                Case "btn_NavInicioToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("INICIO", My.Resources.iconoInicio)
                Case "btn_NavLIBROSToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("LIBROS", My.Resources.iconoLibros)
                Case "btn_NavPRESTAMOSToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("PRÉSTAMOS", My.Resources.iconoPrestamo)

                Case "btn_NavMENSAJERÍAToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("MENSAJERÍA", My.Resources.iconomensajería)

                Case "btn_NavCLIENTESToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("CLIENTES", My.Resources.iconoClientes)

                Case "btn_NavVISTASToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("VISTAS", My.Resources.iconoVista)
                Case "btn_NavREPORTESToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("REPORTES", My.Resources.iconoReportes)
                Case "btn_NavSOLICITUDToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("SOLICITUD DE LIBROS", My.Resources.iconoSolicitud)

                Case "btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("GESTIÓN DE CATÁLOGO", My.Resources.iconoGestionarCatálogo)

                Case "btn_NavCONSULTASToolStripMenuItem"
                    RaiseEvent SeSeleccionoOpcion("CONSULTAS", My.Resources.iconoPreguntas)

                Case Else
                    RaiseEvent SeSeleccionoOpcion(item.Text, Nothing)
            End Select
        End Sub
    End Class
End Namespace

