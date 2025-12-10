Namespace ProyLibreteao

    Public Class ClaseNav

        Public Event SeSeleccionoOpcion(titulo As String, icono As Image)

        Private secciones As Dictionary(Of String, Tuple(Of String, Image))

        ' Item actualmente seleccionado
        Private itemSeleccionado As ToolStripMenuItem = Nothing

        Public Sub New()
            secciones = New Dictionary(Of String, Tuple(Of String, Image)) From {
                {"btn_NavInicioToolStripMenuItem", Tuple.Create("INICIO", CType(My.Resources.iconoInicio, Image))},
                {"btn_NavLIBROSToolStripMenuItem", Tuple.Create("LIBROS", CType(My.Resources.iconoLibros, Image))},
                {"btn_NavPRESTAMOSToolStripMenuItem", Tuple.Create("PRÉSTAMOS", CType(My.Resources.iconoPrestamo, Image))},
                {"btn_NavMENSAJERÍAToolStripMenuItem", Tuple.Create("MENSAJERÍA", CType(My.Resources.iconomensajería, Image))},
                {"btn_NavCLIENTESToolStripMenuItem", Tuple.Create("CLIENTES", CType(My.Resources.iconoClientes, Image))},
                {"btn_NavVISTASToolStripMenuItem", Tuple.Create("VISTAS", CType(My.Resources.iconoVista, Image))},
                {"btn_NavREPORTESToolStripMenuItem", Tuple.Create("REPORTES", CType(My.Resources.iconoReportes, Image))},
                {"btn_NavSOLICITUDToolStripMenuItem", Tuple.Create("SOLICITUD DE LIBROS", CType(My.Resources.iconoSolicitud, Image))},
                {"btn_NavGESTIÓNDECATÁLOGOSToolStripMenuItem", Tuple.Create("GESTIÓN DE CATÁLOGOS", CType(My.Resources.iconoGestionarCatálogo, Image))},
                {"btn_NavCONSULTASToolStripMenuItem", Tuple.Create("CONSULTAS", CType(My.Resources.iconoPreguntas, Image))}
            }
        End Sub


        ' ================================
        '      MANEJO DE CLICK DEL MENÚ
        ' ================================
        Public Sub ManejarClick(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item Is Nothing Then Return

            ' Guardar ítem seleccionado
            itemSeleccionado = item

            ' Restaurar colores
            RestaurarColores(item.Owner.Items)

            ' Pintar seleccionado
            item.ForeColor = Color.Purple


            ' Lanzar evento (como ya lo tenías)
            If secciones.ContainsKey(item.Name) Then
                Dim info = secciones(item.Name)
                RaiseEvent SeSeleccionoOpcion(info.Item1, info.Item2)
            Else
                RaiseEvent SeSeleccionoOpcion(item.Text, Nothing)
            End If
        End Sub



        Public Sub ManejarMouseLeave(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item Is Nothing Then Return

            ' Si este item NO es el seleccionado, vuelve normal
            If itemSeleccionado IsNot item Then
                item.ForeColor = SystemColors.ControlText
            End If
        End Sub


        ' ================================
        '     Restaurar colores del menú
        ' ================================
        Private Sub RestaurarColores(items As ToolStripItemCollection)
            For Each it As ToolStripItem In items
                If TypeOf it Is ToolStripMenuItem Then
                    Dim mi = DirectCast(it, ToolStripMenuItem)

                    If mi IsNot itemSeleccionado Then
                        mi.ForeColor = SystemColors.ControlText
                    End If

                    ' Submenús
                    If mi.HasDropDownItems Then
                        RestaurarColores(mi.DropDownItems)
                    End If
                End If
            Next
        End Sub

    End Class

End Namespace


