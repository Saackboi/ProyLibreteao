Imports System.Configuration
Imports System.Drawing
Imports System.Net.Http
Imports System.Windows.Forms.DataVisualization.Charting
Imports Newtonsoft.Json

Public Class ClaseContenidoResumen

    Private ReadOnly dgvClientes As DataGridView
    Private ReadOnly chartP As Chart
    Private ReadOnly chartLibros As Chart

    ' Etiquetas para las tarjetas informativas (Cards)
    Private ReadOnly lblTotalUsuarios As Label
    Private ReadOnly lblTotalPrestamos As Label
    Private ReadOnly lblTotalMultas As Label
    Private ReadOnly lblTotalPedidos As Label
    Private ReadOnly lblTotalDevoluciones As Label

    ' URL Base de los Reportes (Asegúrate que el puerto coincida con tu API)
    Private ReadOnly BaseUrl As String = ConfigurationManager.AppSettings("ApiBaseUrl") & "reportes"

    ' Cliente HTTP para la clase
    Private Shared client As HttpClient = CrearClienteInseguro()

    Private Shared Function CrearClienteInseguro() As HttpClient
        Dim handler As New HttpClientHandler()
        handler.ServerCertificateCustomValidationCallback = Function(message, cert, chain, errors) True
        Return New HttpClient(handler)
    End Function

    Public Sub New(dgv As DataGridView,
                   chP As Chart,
                   chL As Chart,
                   lblUsuarios As Label,
                   lblPrestamos As Label,
                   lblMultas As Label,
                   lblPedidos As Label,
                   lblDevoluciones As Label)

        Me.dgvClientes = dgv
        Me.chartP = chP
        Me.chartLibros = chL
        Me.lblTotalUsuarios = lblUsuarios
        Me.lblTotalPrestamos = lblPrestamos
        Me.lblTotalMultas = lblMultas
        Me.lblTotalPedidos = lblPedidos
        Me.lblTotalDevoluciones = lblDevoluciones
    End Sub

    ' =============================
    ' 1. CARGAR TARJETAS (KPIs)
    ' =============================
    Public Async Sub CargarDatosTarjetas()
        If lblTotalUsuarios Is Nothing Then Return

        Try
            ' Llamada al endpoint GET api/reportes/kpis
            Dim json As String = Await client.GetStringAsync(BaseUrl & "/kpis")
            Dim datos = JsonConvert.DeserializeObject(Of DashboardKpis)(json)

            If datos IsNot Nothing Then
                lblTotalUsuarios.Text = datos.TotalUsuarios.ToString()
                lblTotalPrestamos.Text = datos.TotalPrestamos.ToString()
                lblTotalDevoluciones.Text = datos.TotalDevoluciones.ToString()
                lblTotalPedidos.Text = datos.TotalCategorias.ToString() ' Reusamos Pedidos como Categorías
                lblTotalMultas.Text = datos.TotalMultasCount.ToString()
            End If

        Catch ex As Exception
            ' En caso de error, ponemos guiones
            lblTotalUsuarios.Text = "-"
            lblTotalMultas.Text = "-"

        End Try
    End Sub

    ' =============================
    ' 2. DATAGRIDVIEW DE RESUMEN (Actividad Semanal)
    ' =============================
    Public Async Sub CrearGraficoReporteCantidadUsuarios()
        If dgvClientes Is Nothing Then Return

        Try
            ' Llamada al endpoint GET api/reportes/semanal
            Dim json As String = Await client.GetStringAsync(BaseUrl & "/semanal")
            Dim lista = JsonConvert.DeserializeObject(Of List(Of ActividadSemanal))(json)

            dgvClientes.Columns.Clear()
            dgvClientes.Rows.Clear()
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

            dgvClientes.Columns.Add("Semana", "Semana")
            dgvClientes.Columns.Add("Prestamos", "Préstamos")
            dgvClientes.Columns.Add("Devoluciones", "Devoluciones")
            dgvClientes.Columns.Add("LibrosNoDevueltos", "Libros No Devueltos")
            dgvClientes.Columns.Add("Multas", "Multas")

            For Each item In lista
                dgvClientes.Rows.Add(
                    item.Semana,
                    item.CantidadPrestamos,
                    item.CantidadDevoluciones,
                    item.Pendientes,
                    item.TotalMultas.ToString("N2")
                )
            Next

        Catch ex As Exception
            ' Fallo silencioso o log
        End Try
    End Sub

    ' =============================
    ' 3. GRAFICA DE PRÉSTAMOS - MIGRADO A API
    ' =============================
    Public Async Sub MostrarGraficaPrestamos()
        Try
            ' Reusamos el endpoint semanal que ya trae estos datos
            Dim json As String = Await client.GetStringAsync(BaseUrl & "/semanal")
            Dim lista = JsonConvert.DeserializeObject(Of List(Of ActividadSemanal))(json)

            Dim datosPrestamos As New Dictionary(Of String, Integer)()

            For Each item In lista
                ' Usamos la semana como etiqueta
                datosPrestamos.Add(item.Semana, item.CantidadPrestamos)
            Next

            chartP.Series.Clear()
            chartP.Titles.Clear()

            If datosPrestamos.Count > 0 Then
                chartP.Series.Add(CrearSerie("Préstamos", SeriesChartType.Column, Color.MediumSlateBlue, datosPrestamos))
                chartP.Titles.Add("Préstamos por Semana")
            Else
                chartP.Titles.Add("Sin datos recientes")
            End If

        Catch ex As Exception
            chartP.Titles.Add("Error al cargar gráfica")
        End Try
    End Sub

    ' =============================
    ' 4. GRAFICA DE LIBROS POPULARES - MIGRADO A API
    ' =============================
    Friend Async Sub MostrarGraficaLibros()
        Try
            ' Llamada al endpoint GET api/reportes/toplibros
            Dim json As String = Await client.GetStringAsync(BaseUrl & "/toplibros")
            Dim lista = JsonConvert.DeserializeObject(Of List(Of LibroPopular))(json)

            Dim datosLibros As New Dictionary(Of String, Integer)()

            For Each item In lista
                Dim titulo As String = item.Titulo
                If titulo.Length > 15 Then titulo = titulo.Substring(0, 12) & "..."

                datosLibros.Add(titulo, item.VecesPrestado)
            Next

            chartLibros.Series.Clear()
            chartLibros.Titles.Clear()

            If datosLibros.Count > 0 Then
                chartLibros.Series.Add(CrearSerie("Populares", SeriesChartType.Column, Color.Teal, datosLibros))
                chartLibros.Titles.Add("Top 5 Libros")
                chartLibros.ChartAreas(0).AxisX.Interval = 1
            Else
                chartLibros.Titles.Add("Sin datos de libros")
            End If

        Catch ex As Exception
            chartLibros.Titles.Add("Error al cargar gráfica")
        End Try
    End Sub

    ' =============================
    ' MÉTODO AUXILIAR PARA CREAR SERIES (Se mantiene igual, es visual)
    ' =============================
    Private Function CrearSerie(nombre As String, tipo As SeriesChartType, color As Color, datos As Dictionary(Of String, Integer)) As Series
        Dim serie As New Series(nombre) With {
            .ChartType = tipo,
            .Color = color,
            .IsValueShownAsLabel = True
        }

        For Each kvp In datos
            serie.Points.AddXY(kvp.Key, kvp.Value)
        Next

        Return serie
    End Function

End Class