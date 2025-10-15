Public Class Formulario_Bibliotecario
    Private ucInicio As New UserControlContenidoInicio1()
    Private ucLibro As New UserControlContenidoLibros1()
    Private ucPrestamo As New UserControlContenidoPrestamo1()
    Private ucMensajeria As New UserControlContenidoMensajeria1()
    Private ucClientes As New UserControlContenidoClientes1()
    Private ucVistas As New UserControlContenidoVistas1()
    Private ucReportes As New UserControlContenidoReportes1()
    Private ucSolicitud As New UserControlContenidoSolicitudDeLibro1()
    Private ucGestionar As New UserControlContenidoGestionarCatálogo1()
    Private ucConsulta As New UserControlContenidoConsultas1()


    Private Sub Formulario_Bibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Conecta el evento del menú de navegación (UserControlNavegacion)
        AddHandler UserControlNavegacion1.ItemSeleccionado, AddressOf Navegacion_Click

        ' (Opcional) Muestra un mensaje inicial o pantalla vacía
        Panel1.Controls.Add(New Label With {
            .Text = "Seleccione una opción del menú.",
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10, FontStyle.Italic),
            .ForeColor = Color.Gray,
            .TextAlign = ContentAlignment.MiddleCenter
        })
    End Sub

    Private Sub Navegacion_Click(imagen As Image, texto As String)
        ' Actualiza encabezado
        UserControlEncabezado1.ActualizarEncabezado(imagen, texto)

        ' Carga el contenido adecuado
        MostrarUserControl(texto)
    End Sub

    Private Sub MostrarUserControl(texto As String)
        Panel1.Controls.Clear()

        Select Case texto
            Case "INICIO"
                Panel1.Controls.Add(ucInicio)
            Case "LIBROS"
                Panel1.Controls.Add(ucLibro)
            Case "PRÉSTAMOS"
                Panel1.Controls.Add(ucPrestamo)
            Case "MENSAJERÍA"
                Panel1.Controls.Add(ucMensajeria)
            Case "CLIENTES"
                Panel1.Controls.Add(ucClientes)
            Case "VISTAS"
                Panel1.Controls.Add(ucVistas)
            Case "REPORTES"
                Panel1.Controls.Add(ucReportes)
            Case "SOLICITUD DE LIBROS"
                Panel1.Controls.Add(ucSolicitud)
            Case "GESTIÓN DE CATÁLOGO"
                Panel1.Controls.Add(ucGestionar)
            Case "CONSULTAS"
                Panel1.Controls.Add(ucConsulta)

            Case Else
                Panel1.Controls.Add(New Label With {
                    .Text = "Vista no disponible.",
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleCenter
                })
        End Select

        ' Asegura que el control agregado se ajuste al panel
        If Panel1.Controls.Count > 0 Then
            Panel1.Controls(0).Dock = DockStyle.Fill
        End If
    End Sub

End Class