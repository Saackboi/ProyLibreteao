Imports ProyLibreteao.ProyLibreteao

Public Class FormReporte
    Private formFiltro As New FormFiltro()

    Private codigoContenidoResumen As ClaseContenidoResumen
    Private codigoContenidoTablas As ClaseContenidoTablas
    Private codigoDiseñoReporte As ClaseDiseño
    Private codigoReportes As ClaseContenidoTablas



    Public Property FormFiltroReportes As Object

    Private Sub FormReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Inicializar la sección de reportes

        codigoDiseñoReporte = New ClaseDiseño(tcReportes, lblTituloTabControl)
        codigoContenidoResumen = New ClaseContenidoResumen(dtgCantidadUsuario, ChartPrestamo, ChartLibros, Label6, Label2, Label7, Label11, Label12)
        codigoContenidoTablas = New ClaseContenidoTablas(dgvTablaActividadSemanal, dgvLibros, dgvMultas)
        codigoReportes = New ClaseContenidoTablas(dgvTablaActividadSemanal, dgvLibros, dgvMultas)
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

        Dim f As New FormFiltro()

        If f.ShowDialog() = DialogResult.OK Then

            ' --- Comprobaciones para saber EXACTO qué está fallando ---

            If f.PeriodoSeleccionado Is Nothing Then
                MsgBox("ERROR: PeriodoSeleccionado ES NULL")
                Exit Sub
            End If

            If f.PeriodoSeleccionado = "" Then
                MsgBox("ERROR: PeriodoSeleccionado está vacío")
                Exit Sub
            End If

            If codigoReportes Is Nothing Then
                MsgBox("ERROR: codigoReportes NO ESTÁ INICIALIZADO")
                Exit Sub
            End If

            ' --- Aquí ya sabemos que TODO está bien ---
            codigoReportes.FiltrarMultas(f.PeriodoSeleccionado)
            MostrarAviso($"Filtro aplicado: {f.PeriodoSeleccionado}")
        End If
    End Sub




    Private Sub BtnFiltrosL_Click(sender As Object, e As EventArgs) Handles BtnFiltrosL.Click

        Dim f As New FormFiltro()

        If f.ShowDialog() = DialogResult.OK Then

            ' --- Comprobaciones para saber EXACTO qué está fallando ---

            If f.PeriodoSeleccionado Is Nothing Then
                MsgBox("ERROR: PeriodoSeleccionado ES NULL")
                Exit Sub
            End If

            If f.PeriodoSeleccionado = "" Then
                MsgBox("ERROR: PeriodoSeleccionado está vacío")
                Exit Sub
            End If

            If codigoReportes Is Nothing Then
                MsgBox("ERROR: codigoReportes NO ESTÁ INICIALIZADO")
                Exit Sub
            End If

            ' --- Aquí ya sabemos que TODO está bien ---
            codigoReportes.FiltrarMultas(f.PeriodoSeleccionado)
            MostrarAviso($"Filtro aplicado: {f.PeriodoSeleccionado}")
        End If
    End Sub


    Private Sub BtnFiltroM_Click(sender As Object, e As EventArgs) Handles BtnFiltroM.Click
        Dim f As New FormFiltro()

        If f.ShowDialog() = DialogResult.OK Then

            ' --- Comprobaciones para saber EXACTO qué está fallando ---

            If f.PeriodoSeleccionado Is Nothing Then
                MsgBox("ERROR: PeriodoSeleccionado ES NULL")
                Exit Sub
            End If

            If f.PeriodoSeleccionado = "" Then
                MsgBox("ERROR: PeriodoSeleccionado está vacío")
                Exit Sub
            End If

            If codigoReportes Is Nothing Then
                MsgBox("ERROR: codigoReportes NO ESTÁ INICIALIZADO")
                Exit Sub
            End If

            ' --- Aquí ya sabemos que TODO está bien ---
            codigoReportes.FiltrarMultas(f.PeriodoSeleccionado)
            MostrarAviso($"Filtro aplicado: {f.PeriodoSeleccionado}")
        End If
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
    Private Sub MostrarAviso(mensaje As String)
        MessageBox.Show(mensaje, "Filtro aplicado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub BarraBusquedaAS_TextChanged(sender As Object, e As EventArgs) Handles BarraBusquedaAS.TextChanged
        If codigoReportes Is Nothing Then Exit Sub
        codigoReportes.BuscarActividad(BarraBusquedaAS.Text)
    End Sub

    Private Sub BarraBuequedaL_TextChanged(sender As Object, e As EventArgs) Handles BarraBuequedaL.TextChanged
        If codigoReportes Is Nothing Then Exit Sub
        codigoReportes.BuscarLibros(BarraBuequedaL.Text)
    End Sub

    Private Sub BarraBusquedaM_TextChanged(sender As Object, e As EventArgs) Handles BarraBusquedaM.TextChanged
        If codigoReportes Is Nothing Then Exit Sub
        codigoReportes.BuscarMultas(BarraBusquedaM.Text)
    End Sub



    Private Sub BarraBusqueda_Enter(sender As Object, e As EventArgs) _
    Handles BarraBusquedaAS.Enter, BarraBuequedaL.Enter, BarraBusquedaM.Enter

        Dim txt As ToolStripTextBox = CType(sender, ToolStripTextBox)

        Select Case txt.Name
            Case "BarraBusquedaAS"
                If txt.Text = "Buscar Actividad Semanal 🔎" Then txt.Clear()
                txt.ForeColor = Color.Black

            Case "BarraBuequedaL"
                If txt.Text = "Buscar Libros 🔎" Then txt.Clear()
                txt.ForeColor = Color.Black

            Case "BarraBusquedaM"
                If txt.Text = "Buscar Multas🔎" Then txt.Clear()
                txt.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub BarraBusqueda_Leve(sender As Object, e As EventArgs) _
    Handles BarraBusquedaAS.Leave, BarraBuequedaL.Leave, BarraBusquedaM.Leave

        Dim txt As ToolStripTextBox = CType(sender, ToolStripTextBox)

        Select Case txt.Name
            Case "BarraBusquedaAS"
                If txt.Text.Trim() = "" Then txt.Clear()
                txt.ForeColor = SystemColors.WindowFrame
                BarraBusquedaAS.Text = "Buscar Actividad Semanal 🔎"

            Case "BarraBuequedaL"
                If txt.Text.Trim() = "" Then txt.Clear()
                txt.ForeColor = SystemColors.WindowFrame
                BarraBuequedaL.Text = "Buscar Libros 🔎"

            Case "BarraBusquedaM"
                If txt.Text.Trim() = "" Then txt.Clear()
                txt.ForeColor = SystemColors.WindowFrame
                BarraBusquedaM.Text = "Buscar Multas🔎"

        End Select
    End Sub




End Class