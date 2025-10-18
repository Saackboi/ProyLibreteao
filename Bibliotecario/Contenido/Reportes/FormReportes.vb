Imports ProyLibreteao.ProyLibreteao
'//////////////////////////////////////////////////////////
' ESQUEMA DEL CÓDIGO — FORMULARIO: FormReportes.vb
'═══════════════════════════════════════════════════════════════════════════════
'
' 📋 Descripción general:
'   Este formulario pertenece al área de Bibliotecario. 
'   Controla la navegación, el encabezado y el contenido de la sección de reportes.
'
'───────────────────────────────────────────────────────────────────────────────
' 🧩 Estructura general
'
'  FormReportes
'  ├── Clases auxiliares (manejan la lógica y los controles base)
'  │     ├─ ClaseEncabezado     → Actualiza el encabezado (título e ícono de sección)
'  │     ├─ ClaseNav            → Controla el menú lateral y sus eventos
'  │     └─ ClaseReportes       → Muestra el contenido de la sección REPORTES
'
'  ├── Controles principales
'  │     ├─ PanelContenido       → Panel central donde se cargan las secciones
'  │     ├─ lblTituloMenuEncabezado → Título principal del encabezado
'  │     ├─ pb2seccionMenuNav    → Ícono del encabezado
'  │     ├─ dgvTablaInfoReporte  → Tabla (DataGridView) con datos de reportes
'  │     ├─ tcContenidoReportes  → Pestañas de reportes (TabControl)
'  │     ├─ lblTituloTabControl  → Muestra el nombre de la pestaña activa
'  │     └─ btnFiltroReporte     → Botón para aplicar filtros en reportes
'
'───────────────────────────────────────────────────────────────────────────────
' 🔄 Flujo de ejecución
'
'  1️⃣ Form_Load()
'       - Inicializa las clases auxiliares.
'       - Conecta los eventos del menú (ToolStripMenuItems) con los métodos de navegación.
'       - Muestra un mensaje inicial en el PanelContenido.
'
'  2️⃣ MenuItem_Click()
'       - Detecta cuál opción del menú fue seleccionada.
'       - Llama a ClaseNav.ManejarClick() para ejecutar la acción correspondiente.
'
'  3️⃣ CambiarSeccion(titulo, icono)
'       - Actualiza el encabezado usando ClaseEncabezado.
'       - Si el título es "REPORTES", carga el contenido de la clase ClaseReportes.
'       - En cualquier otro caso, limpia el panel o muestra un mensaje por defecto.
'
'  4️⃣ TabControlContenidoReportes
'       - Dibuja las pestañas con estilo personalizado (DrawItem).
'       - Actualiza el título del tab activo (SelectedIndexChanged).
'
'───────────────────────────────────────────────────────────────────────────────
' 🧠 Eventos clave
'   - SeSeleccionoOpcion (ClaseNav)
'   - DrawItem (TabControl personalizado)
'   - SelectedIndexChanged (Cambio de pestaña)
'
'───────────────────────────────────────────────────────────────────────────────
' 🗓️ Última actualización: 17/10/2025
'
' 💡 Nota:
'   Los prefijos de controles se usan así:
'     lbl → Label
'     tc  → TabControl
'     dgv → DataGridView
'     pb  → PictureBox
'
'//////////////////////////////////////////////////////////

Public Class FormReportes

    ' Clases auxiliares
    Private codigoEncabezado As ClaseEncabezado
    Private codigoNavegacion As ClaseNav
    Private codigoContenidoReporte As ClaseReportes

    ' Evento: Al cargar el formulario
    Private Sub FormBibliotecario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialización de clases
        codigoEncabezado = New ClaseEncabezado(lblTituloMenuEncabezado, pb2seccionMenuNav)
        codigoNavegacion = New ClaseNav()
        codigoContenidoReporte = New ClaseReportes(PanelContenido, dgvTablaInfoReporte, tlpReporte, tcContenidoReportes, lblTituloTabControl, btnFiltroReporte)

        ' Vincular evento del menú
        AddHandler codigoNavegacion.SeSeleccionoOpcion, AddressOf CambiarSeccion

        ' Mostrar mensaje inicial
        PanelContenido.Controls.Clear()
        PanelContenido.Controls.Add(New Label With {
                .Text = "Seleccione una opción del menú.",
                .Dock = DockStyle.Fill,
                .Font = New Font("Segoe UI", 10, FontStyle.Italic),
                .ForeColor = Color.Gray,
                .TextAlign = ContentAlignment.MiddleCenter})

        ' Agregar manejadores a los elementos del menú
        For Each item As ToolStripMenuItem In msMenuNavegacion.Items.OfType(Of ToolStripMenuItem)()
            AddHandler item.Click, AddressOf codigoNavegacion.ManejarClick
            AgregarHandlerRecursivo(item)
        Next
    End Sub

    ' Método recursivo: agrega eventos a los submenús
    Private Sub AgregarHandlerRecursivo(parent As ToolStripMenuItem)
        For Each subItem As ToolStripMenuItem In parent.DropDownItems.OfType(Of ToolStripMenuItem)()
            AddHandler subItem.Click, AddressOf codigoNavegacion.ManejarClick
            AgregarHandlerRecursivo(subItem)
        Next
    End Sub

    ' Cambia la sección visible según el menú seleccionado
    Private Sub CambiarSeccion(titulo As String, icono As Image)
        codigoEncabezado.Actualizar(titulo, icono)

        If titulo = "REPORTES" Then
            codigoContenidoReporte.MostrarReportes()
        Else
            PanelContenido.Controls.Clear() ' Limpia o muestra algo básico
        End If
    End Sub

End Class
