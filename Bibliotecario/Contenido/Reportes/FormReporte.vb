Imports ProyLibreteao.ProyLibreteao

Public Class FormReporte
    Private formFiltro As New FormFiltro()

    Private codigoContenidoResumen As ClaseContenidoResumen
    Private codigoContenidoTablas As ClaseContenidoTablas
    Private codigoDiseñoReporte As ClaseDiseño



    Public Property FormFiltroReportes As Object

    Private Sub FormReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Inicializar la sección de reportes

        codigoDiseñoReporte = New ClaseDiseño(tcReportes, lblTituloTabControl)
        codigoContenidoResumen = New ClaseContenidoResumen(dtgCantidadUsuario, ChartPrestamo, ChartLibros, Label6, Label2, Label7, Label11, Label12)
        codigoContenidoTablas = New ClaseContenidoTablas(dgvTablaActividadSemanal, dgvLibros, dgvMultas)
        codigoContenidoTablas.MostrarTablaActividadSemenal() '
        codigoContenidoTablas.MostrarTablaLibros()
        codigoContenidoTablas.MostrarTablaMultas()
        codigoContenidoResumen.CargarDatosTarjetas()
        codigoContenidoResumen.CrearGraficoReporteCantidadUsuarios()
        codigoContenidoResumen.MostrarGraficaPrestamos()
        codigoContenidoResumen.MostrarGraficaLibros()

    End Sub


    Private Sub CambiarSeccion(titulo As String, icono As Image)

        ' Mostrar contenido según la sección
        Select Case titulo.ToUpper()
            Case "REPORTES"
                codigoContenidoTablas.MostrarTablaActividadSemenal() '
                codigoContenidoResumen.CrearGraficoReporteCantidadUsuarios()

        End Select
    End Sub

    Private Sub BtnFiltroAS_Click(sender As Object, e As EventArgs) Handles BtnFiltroAS.Click
        formFiltro.ShowDialog()

    End Sub

    Private Sub BtnFiltrosAS_Click(sender As Object, e As EventArgs) Handles BtnFiltrosAS.Click
        formFiltro.ShowDialog()
    End Sub

    Private Sub BtnFiltroM_Click(sender As Object, e As EventArgs) Handles BtnFiltroM.Click
        formFiltro.ShowDialog()
    End Sub

    Private Sub BtnDescargaAS_Click(sender As Object, e As EventArgs) Handles BtnDescargaAS.Click
        Dim tabSeleccionada As TabPage = Me.tcReportes.SelectedTab

        ' Llamar al método que genera el PDF según la pestaña seleccionada
        codigoContenidoTablas.DescargarReportes(tabSeleccionada)
    End Sub

    Private Sub BtnDescargaL_Click(sender As Object, e As EventArgs) Handles BtnDescargaL.Click
        Dim tabSeleccionada As TabPage = Me.tcReportes.SelectedTab

        ' Llamar al método que genera el PDF según la pestaña seleccionada
        codigoContenidoTablas.DescargarReportes(tabSeleccionada)
    End Sub

    Private Sub BtnDescargaM_Click(sender As Object, e As EventArgs) Handles BtnDescargaM.Click
        Dim tabSeleccionada As TabPage = Me.tcReportes.SelectedTab

        ' Llamar al método que genera el PDF según la pestaña seleccionada
        codigoContenidoTablas.DescargarReportes(tabSeleccionada)
    End Sub

End Class
