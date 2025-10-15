Public Class UserControlNavegacion
    ' --- Declaramos un evento público ---
    Public Event ItemSeleccionado(ByVal imagen As Image, ByVal texto As String)

    ' --- Método único para todos los ToolStripMenuItem ---
    Private Sub MenuStripMenuNavegacion_Click(sender As Object, e As EventArgs) _
        Handles btn_NavInicioToolStripMenuItem.Click,
                btn_NavLIBROSToolStripMenuItem.Click,
                btn_NavPRESTAMOSToolStripMenuItem.Click,
                btn_NavMENSAJERÍAToolStripMenuItem.Click,
                btn_NavCLIENTESToolStripMenuItem.Click,
                btn_NavVISTASToolStripMenuItem.Click,
                btn_NavREPORTESToolStripMenuItem.Click,
                btn_NavSOLICITUDToolStripMenuItem.Click,
                btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem.Click,
                btn_NavCONSULTASToolStripMenuItem.Click

        Dim item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        ' Según el nombre del ítem o Tag, se asigna imagen y texto
        Select Case item.Name
            Case "btn_NavInicioToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoInicio, "INICIO")
            Case "btn_NavLIBROSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoLibros, "LIBROS")
            Case "btn_NavPRESTAMOSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoPrestamo, "PRÉSTAMOS")
            Case "btn_NavMENSAJERÍAToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconomensajería, "MENSAJERÍA")
            Case "btn_NavCLIENTESToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoClientes, "CLIENTES")
            Case "btn_NavVISTASToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoVista, "VISTAS")
            Case "btn_NavREPORTESToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoReportes, "REPORTES")
            Case "btn_NavSOLICITUDToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoSolicitud, "SOLICITUD DE LIBROS")
            Case "btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoGestionarCatálogo, "GESTIÓN DE CATÁLOGO")
            Case "btn_NavCONSULTASToolStripMenuItem"
                RaiseEvent ItemSeleccionado(My.Resources.iconoPreguntas, "CONSULTAS")
        End Select

    End Sub

End Class
