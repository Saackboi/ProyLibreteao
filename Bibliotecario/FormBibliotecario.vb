Imports ProyLibreteao.ProyLibreteao
'//////////////////////////////////////////////////////////
' ESQUEMA DEL CÓDIGO — FORMULARIO: FormBibliotecario.vb
'═══════════════════════════════════════════════════════════════════════════════
'
' FormBibliotecario
' ├──  Clases creadas (logico y manejo de algunos controles),para secciones bases  del formulario
' │      ├─ ClaseCodigoEncabezado        → Maneja el encabezado (título e icono de la sección seleccionada)
' │      ├─ ClaseCodigoNavegacion        → Maneja el menú lateral y sus eventos (inicio, vistas, reportes, etc.)
' │      └─ ClaseCodigoContenidoReportes → Controla el contenido de la sección REPORTES
'
' ├──  Controles del formulario
' │      ├─ PanelContenido                 → Panel central donde se cargan las secciones
' │      ├─ lblTituloMenuEncabezado        → Muestra el título superior
' │      ├─ pb2seccionMenuNav              → Icono del encabezado
' │      ├─ dgvTablaActividadSemanal       → DataGridView con datos de reportes
' │      ├─ tcContenidoReportes            → TabControl con pestañas de reportes
' │      └─ lblTituloTabControl            → Título dinámico del tab seleccionado
'
' ├──  Flujo general del formulario
' │      1️ Form_Load()
' │           ├─ Inicializa clases auxiliares
' │           ├─ Vincula eventos del menú → CambiarSeccion()
' │           └─ Muestra mensaje inicial en PanelContenido
' │
' │      2️ MenuItem_Click()
' │           ├─ Detecta opción seleccionada en el menú
' │           └─ Llama a codigoNavegacion.ManejarClick()
' │
' │      3️ CambiarSeccion(titulo, icono)
' │           ├─ Actualiza encabezado (ClaseCodigoEncabezado)
' │           ├─ Según el título:
' │           │    ├─ "REPORTES" → Muestra reportes (ClaseCodigoContenidoReportes)
' │           │    └─ Otro → Muestra mensaje inicial
' │
' │      4️ TabControlContenidoReportes_DrawItem()
' │           ├─ Dibuja pestañas personalizadas (colores, subrayado)
' │           └─ Controla apariencia del TabControl
' │
' │      5️  TabControlContenidoReportes_SelectedIndexChanged()
' │           └─ Actualiza lblTituloTabControl con la pestaña activa
'
' └──  Eventos importantes
'        ├─ SeSeleccionoOpcion (ClaseCodigoNavegacion)
'        ├─ DrawItem (TabControl personalizado)
'        └─ SelectedIndexChanged (Cambio de pestaña)
'
'  17/10/2025
'  Formulario principal del área de bibliotecario.
'    maneja  la navegación,  el encabezado y contenido de  la seccion de reportes.
'    notas: los nombres de controles  los renombro así 
'           lbl → Label, tc → TabControl, dgv → DataGridView, pb → PictureBox

'///////////////////////////////////////////////////////


Public Class FormBibliotecario

    '  Declaración de clases auxiliares

    Private codigoEncabezado As ClaseCodigoEncabezado
    Private codigoNavegacion As ClaseCodigoNavegacion
    Private codigoContenidoReporte As ClaseCodigoContenidoReportes


    '  al cargar el formulario

    Private Sub FormBibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codigoEncabezado = New ClaseCodigoEncabezado(lblTituloMenuEncabezado, pb2seccionMenuNav)
        codigoNavegacion = New ClaseCodigoNavegacion()
        codigoContenidoReporte = New ClaseCodigoContenidoReportes(PanelContenido, dgvTablaInfoReporte, tlpReporte, tcContenidoReportes, lblTituloTabControl)

        AddHandler codigoNavegacion.SeSeleccionoOpcion, AddressOf CambiarSeccion
        codigoContenidoReporte.MostrarMensajeInicial()
    End Sub


    'manejar clics del menú

    Private Sub MenuItem_Click(sender As Object, e As EventArgs) _
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

        Dim item As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        codigoNavegacion.ManejarClick(item)
    End Sub


    ' cambiar de sección
    '============================
    Private Sub CambiarSeccion(titulo As String, icono As Image)
        codigoEncabezado.Actualizar(titulo, icono)

        Select Case titulo
            Case "REPORTES"
                codigoContenidoReporte.MostrarReportes()
            Case Else
                codigoContenidoReporte.MostrarMensajeInicial()
        End Select
    End Sub


End Class
