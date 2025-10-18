Namespace ProyLibreteao

    Public Class ClaseNav

        Public Event SeSeleccionoOpcion(titulo As String, icono As Image)

        ' Diccionario: relaciona el nombre del botón con el título y el ícono
        Private secciones As Dictionary(Of String, Tuple(Of String, Image))

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

        ' Maneja el clic de cualquier opción del menú
        Public Sub ManejarClick(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item Is Nothing Then Return

            If secciones.ContainsKey(item.Name) Then
                Dim info = secciones(item.Name)
                RaiseEvent SeSeleccionoOpcion(info.Item1, info.Item2)

                ' 🔄 Abrir el formulario correspondiente
                Select Case info.Item1
                    Case "REPORTES"
                        Dim f As New FormReportes()
                        f.Show()
                    Case "CONSULTAS"
                        Dim f As New FormConsultas()
                        f.Show()
                        ' puedes agregar más formularios aquí si lo necesitas
                End Select
            Else
                RaiseEvent SeSeleccionoOpcion(item.Text, Nothing)
            End If
        End Sub

    End Class

End Namespace



