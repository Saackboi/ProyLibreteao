Imports ProyLibreteao.ProyLibreteao
'//////////////////////////////////////////////////////////////
' ESQUEMA DEL CÓDIGO — FORMULARIO: FormAdministrador.vb
'══════════════════════════════════════════════════════════
'
' Descripción general:
'   Este formulario pertenece al área de administración.
'   Controla la navegación, el encabezado y el contenido central,
'   mostrando secciones como REPORTES, CONSULTAS o INICIO.
'
'──────────────────────────────────────────────────────────
'  Estructura general
'
'  FormAdministrador
'  ├── Clases auxiliares
'  │     ├─ ClaseEncabezado     → Actualiza el encabezado (título e ícono de sección)
'  │     ├─ ClaseNav            → Maneja los clics del menú y levanta eventos
'  │     └─ ClaseReportes       → Muestra el contenido específico de la sección REPORTES
'
'  ├── Controles principales
'  │     ├─ PanelContenido       → Panel central donde se cargan los formularios o secciones
'  │     ├─ lblTituloMenuEncabezado → Título principal del encabezado
'  │     ├─ pb2seccionMenuNav    → Ícono del encabezado
'  │     ├─ dgvTablaInfoReporte  → Tabla de datos (solo reportes)
'  │     ├─ tcContenidoReportes  → Pestañas de reportes (TabControl)
'  │     ├─ lblTituloTabControl  → Nombre de la pestaña activa
'  │     └─ btnFiltroReporte     → Botón para filtrar reportes
'
'──────────────────────────────────────────────────────────
'  Flujo de ejecución
'
'  1️  Form_Load()
'       - Inicializa las clases auxiliares.
'       - Conecta los eventos del menú (ToolStripMenuItems) con ClaseNav.
'       - Muestra un mensaje inicial en el PanelContenido.
'
'  2️  MenuItem_Click()
'       - Detecta la opción del menú seleccionada.
'       - Llama a ClaseNav.ManejarClick() para ejecutar la acción correspondiente.
'
'  3️ CambiarSeccion(titulo, icono)
'       - Actualiza encabezado mediante ClaseEncabezado.
'       - Si la sección es "REPORTES", carga ClaseReportes.
'       - Para otras secciones, muestra el formulario correspondiente (FormConsultas, FormInicio, etc.).
'       - Si no hay formulario definido, muestra un mensaje por defecto.
'
'──────────────────────────────────────────────────────────
'  Eventos clave
'   - SeSeleccionoOpcion (ClaseNav) → indica qué sección se eligió
'   - SelectedIndexChanged (TabControl de reportes) → cambia el título de la pestaña activa
'
'──────────────────────────────────────────────────────────
'  Última actualización: 18/10/2025
'
'  Nota:
'   Prefijos de controles:
'     lbl → Label
'     tc  → TabControl
'     dgv → DataGridView
'     pb  → PictureBox
'
'//////////////////////////////////////////////////////////////


Public Class Interface_Administrador

    Private codigoEncabezado As ClaseEncabezado
    Private codigoNavegacion As ClaseNav

    Private seccionActual As String = "" ' Para controlar sección abierta

    ' Cargar formulario inicial
    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar clases
        codigoEncabezado = New ClaseEncabezado(lblTituloMenuEncabezado, pb1MenuNav)
        codigoNavegacion = New ClaseNav()

        ' Mostrar sección inicial
        CambiarSeccion("INICIO", My.Resources.iconoInicio)

        ' Vincular evento del menú
        AddHandler codigoNavegacion.SeSeleccionoOpcion, AddressOf CambiarSeccion

        ' Agregar manejadores a todos los items del menú
        For Each item As ToolStripMenuItem In msMenuNavegacion.Items.OfType(Of ToolStripMenuItem)()
            AddHandler item.Click, AddressOf codigoNavegacion.ManejarClick
            AgregarHandlerRecursivo(item)
        Next
    End Sub
    ' Agrega manejadores de eventos recursivamente a los subitems del menú
    Private Sub AgregarHandlerRecursivo(parent As ToolStripMenuItem)
        For Each subItem As ToolStripMenuItem In parent.DropDownItems.OfType(Of ToolStripMenuItem)()
            AddHandler subItem.Click, AddressOf codigoNavegacion.ManejarClick
            AgregarHandlerRecursivo(subItem)
        Next
    End Sub
    ' Cambia la sección mostrada en el panel de contenido
    Public Sub CambiarSeccion(titulo As String, icono As Image)
        ' Actualizar encabezado
        codigoEncabezado.Actualizar(titulo, icono)

        ' Si selecciona la misma sección, no hacemos nada
        If titulo = seccionActual Then Return

        ' Limpiar panel
        PanelContenido.Controls.Clear()

        ' Abrir formulario según sección
        Select Case titulo.ToUpper()
            Case "INICIO"
                Dim f As New Inicio With {
                    .TopLevel = False,
                    .FormBorderStyle = FormBorderStyle.None,
                    .Dock = DockStyle.Fill
                }
                PanelContenido.Controls.Add(f)
                f.Show()
            Case "LIBROS"
                Dim f As New FormLibros With {
                    .TopLevel = False,
                    .FormBorderStyle = FormBorderStyle.None,
                    .Dock = DockStyle.Fill
                }
                PanelContenido.Controls.Add(f)
                f.Show()
            Case "CATEGORIAS"
                Dim f As New FormCategorias With {
                    .TopLevel = False,
                    .FormBorderStyle = FormBorderStyle.None,
                    .Dock = DockStyle.Fill
                }
                PanelContenido.Controls.Add(f)
                f.Show()
            Case "AUTORES"
                Dim f As New FormAutores With {
                    .TopLevel = False,
                    .FormBorderStyle = FormBorderStyle.None,
                    .Dock = DockStyle.Fill
                }
                PanelContenido.Controls.Add(f)
                f.Show()
            Case "CLIENTES"
                Dim f As New FormUsuarios()
                f.TopLevel = False
                f.FormBorderStyle = FormBorderStyle.None
                f.Dock = DockStyle.Fill
                PanelContenido.Controls.Add(f)
                f.Show()
            Case "REPORTES"
                Dim f As New FormReporte With {
                    .TopLevel = False,
                    .FormBorderStyle = FormBorderStyle.None,
                    .Dock = DockStyle.Fill
                }
                PanelContenido.Controls.Add(f)
                f.Show()

            Case "PRÉSTAMOS"
                Dim f As New FormPrestamos With {
                    .TopLevel = False,
                    .FormBorderStyle = FormBorderStyle.None,
                    .Dock = DockStyle.Fill
                }
                PanelContenido.Controls.Add(f)
                f.Show()

            Case Else ' Si no hay formulario definido, mostrar mensaje
                PanelContenido.Controls.Add(New Label With {
                    .Text = "Seleccione una opción del menú.",
                    .Dock = DockStyle.Fill,
                    .Font = New Font("Segoe UI", 10, FontStyle.Italic),
                    .ForeColor = Color.Gray,
                    .TextAlign = ContentAlignment.MiddleCenter})
        End Select

        seccionActual = titulo
    End Sub


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Login.Show()
        Me.Hide()
    End Sub


End Class
