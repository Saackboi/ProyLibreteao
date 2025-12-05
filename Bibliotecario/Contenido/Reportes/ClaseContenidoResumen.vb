Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient

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

    ' Instancia de la clase de conexión
    Private db As New Database()

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
    ' NUEVO MÉTODO: CARGAR TARJETAS (LABELS)
    ' =============================
    Public Sub CargarDatosTarjetas()
        If lblTotalUsuarios Is Nothing Then Return

        ' Calcula todos los totales en un solo viaje
        Dim query As String = "
            SELECT 
                (SELECT COUNT(*) FROM usuario) AS TotalUsuarios,
                (SELECT COUNT(*) FROM prestamo) AS TotalPrestamos,
                (SELECT COUNT(*) FROM devolucion) AS TotalDevoluciones,
                (SELECT COUNT(*) FROM categorias) AS TotalCategorias,
                (SELECT COUNT(*) FROM devolucion WHERE multa > 0) AS TotalMultasCount"

        Try
            Dim dt As DataTable = db.ExecuteQuery(query, Nothing)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                ' Asignar valores a los labels
                lblTotalUsuarios.Text = row("TotalUsuarios").ToString()
                lblTotalPrestamos.Text = row("TotalPrestamos").ToString()
                lblTotalDevoluciones.Text = row("TotalDevoluciones").ToString()

                ' Pedidos = Solicitudes de libros pendientes
                lblTotalPedidos.Text = row("TotalCategorias").ToString()

                ' Multas = Número total de multas
                lblTotalMultas.Text = row("TotalMultasCount").ToString()
            End If
        Catch ex As Exception
            ' En caso de error, ponemos guiones para indicar fallo sin romper la UI
            lblTotalUsuarios.Text = "-"
            lblTotalMultas.Text = "-"
        End Try
    End Sub

    ' =============================
    ' DATAGRIDVIEW DE RESUMEN (Actividad Semanal)
    ' =============================
    Public Sub CrearGraficoReporteCantidadUsuarios()
        If dgvClientes Is Nothing Then Return

        dgvClientes.Columns.Clear()
        dgvClientes.Rows.Clear()
        dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        dgvClientes.Columns.Add("Semana", "Semana")
        dgvClientes.Columns.Add("Prestamos", "Préstamos")
        dgvClientes.Columns.Add("Devoluciones", "Devoluciones")
        dgvClientes.Columns.Add("LibrosNoDevueltos", "Libros No Devueltos")
        dgvClientes.Columns.Add("Multas", "Multas")

        Dim query As String = "
            SELECT 
                CONCAT('Semana ', DATEPART(iso_week, p.fecha_prestamo), ' - ', YEAR(p.fecha_prestamo)) as Semana,
                COUNT(p.id_prestamo) as CantidadPrestamos,
                (SELECT COUNT(*) FROM devolucion d WHERE DATEPART(iso_week, d.fecha_real_devolucion) = DATEPART(iso_week, p.fecha_prestamo)) as CantidadDevoluciones,
                ISNULL((SELECT SUM(d2.multa) FROM devolucion d2 WHERE DATEPART(iso_week, d2.fecha_real_devolucion) = DATEPART(iso_week, p.fecha_prestamo)), 0) as TotalMultas
            FROM prestamo p
            GROUP BY DATEPART(iso_week, p.fecha_prestamo), YEAR(p.fecha_prestamo)
            ORDER BY YEAR(p.fecha_prestamo) DESC, DATEPART(iso_week, p.fecha_prestamo) DESC"

        Try
            Dim dt As DataTable = db.ExecuteQuery(query, Nothing)

            For Each row As DataRow In dt.Rows
                dgvClientes.Rows.Add(
                    row("Semana"),
                    row("CantidadPrestamos"),
                    row("CantidadDevoluciones"),
                    Convert.ToInt32(row("CantidadPrestamos")) - Convert.ToInt32(row("CantidadDevoluciones")),
                    Convert.ToDecimal(row("TotalMultas")).ToString("N2")
                )
            Next
        Catch ex As Exception
        End Try
    End Sub

    ' =============================
    ' GRAFICA DE PRÉSTAMOS
    ' =============================
    Public Sub MostrarGraficaPrestamos()
        Dim datosPrestamos As New Dictionary(Of String, Integer)()

        Dim query As String = "
            SELECT 
                CONCAT('Sem ', DATEPART(iso_week, fecha_prestamo)) as SemanaLabel, 
                COUNT(*) as Total 
            FROM prestamo 
            GROUP BY DATEPART(iso_week, fecha_prestamo), YEAR(fecha_prestamo)
            ORDER BY YEAR(fecha_prestamo), DATEPART(iso_week, fecha_prestamo)"

        Try
            Dim dt As DataTable = db.ExecuteQuery(query, Nothing)

            For Each row As DataRow In dt.Rows
                datosPrestamos.Add(row("SemanaLabel").ToString(), Convert.ToInt32(row("Total")))
            Next
        Catch ex As Exception
            datosPrestamos.Add("Error BD", 0)
        End Try

        chartP.Series.Clear()
        chartP.Titles.Clear()

        If datosPrestamos.Count > 0 Then
            chartP.Series.Add(CrearSerie("Préstamos", SeriesChartType.Column, Color.MediumSlateBlue, datosPrestamos))
            chartP.Titles.Add("Préstamos por Semana")
        Else
            chartP.Titles.Add("Sin datos recientes")
        End If
    End Sub

    ' =============================
    ' GRAFICA DE LIBROS POPULARES
    ' =============================
    Friend Sub MostrarGraficaLibros()
        Dim datosLibros As New Dictionary(Of String, Integer)()

        Dim query As String = "
            SELECT TOP 5 l.titulo, COUNT(p.id_prestamo) as VecesPrestado
            FROM prestamo p
            INNER JOIN libro l ON p.id_libro = l.id_libro
            GROUP BY l.titulo
            ORDER BY VecesPrestado DESC"

        Try
            Dim dt As DataTable = db.ExecuteQuery(query, Nothing)

            For Each row As DataRow In dt.Rows
                Dim titulo As String = row("titulo").ToString()
                If titulo.Length > 15 Then titulo = titulo.Substring(0, 12) & "..."
                datosLibros.Add(titulo, Convert.ToInt32(row("VecesPrestado")))
            Next
        Catch ex As Exception
            datosLibros.Add("Error", 0)
        End Try

        chartLibros.Series.Clear()
        chartLibros.Titles.Clear()

        If datosLibros.Count > 0 Then
            chartLibros.Series.Add(CrearSerie("Populares", SeriesChartType.Column, Color.Teal, datosLibros))
            chartLibros.Titles.Add("Top 5 Libros")
            chartLibros.ChartAreas(0).AxisX.Interval = 1
        Else
            chartLibros.Titles.Add("Sin datos de libros")
        End If
    End Sub

    ' =============================
    ' HELPER PARA SERIES
    ' =============================
    Private Function CrearSerie(nombre As String, tipo As SeriesChartType, color As Color, datos As Dictionary(Of String, Integer)) As Series
        Dim serie As New Series(nombre) With {
            .ChartType = tipo,
            .color = color,
            .IsValueShownAsLabel = True
        }

        For Each kvp In datos
            serie.Points.AddXY(kvp.Key, kvp.Value)
        Next

        Return serie
    End Function

End Class