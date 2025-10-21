Imports System.Windows.Forms.DataVisualization.Charting

Public Class ClaseContenidoResumen

    Private ReadOnly dgvClientes As DataGridView
    Private ReadOnly chartP As Chart
    Private ReadOnly chartLibros As Chart

    Public Sub New(dgvClientes As DataGridView, chartPrestamo As Chart, chartLibros As Chart)
        Me.dgvClientes = dgvClientes
        Me.chartP = chartPrestamo
        Me.chartLibros = chartLibros
    End Sub

    ' =============================
    ' DATAGRIDVIEW DE RESUMEN DE USUARIOS
    ' =============================
    Public Sub CrearGraficoReporteCantidadUsuarios()
        If dgvClientes Is Nothing Then Return

        dgvClientes.Columns.Clear()
        dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        dgvClientes.Columns.Add("Semana", "Semana")
        dgvClientes.Columns.Add("Prestamos", "Préstamos")
        dgvClientes.Columns.Add("Devoluciones", "Devolución")
        dgvClientes.Columns.Add("LibrosNoDevueltos", "Libros No Devueltos")
        dgvClientes.Columns.Add("Multas", "Multas")

        dgvClientes.Rows.Add("1 - 7 de octubre", 100, 90, 10, 9)
        dgvClientes.Rows.Add("8 - 14 de octubre", 80, 75, 5, 8)
    End Sub

    ' =============================
    ' GRAFICA DE PRÉSTAMOS
    ' =============================
    Public Sub MostrarGraficaPrestamos()
        Dim datosPrestamos As New Dictionary(Of String, Integer) From {
            {"Semana 1", 45},
            {"Semana 2", 80},
            {"Semana 3", 70},
            {"Semana 4", 90}
        }

        chartP.Series.Clear()
        chartP.Series.Add(CrearSerie("Préstamos", SeriesChartType.Column, Color.MediumSlateBlue, datosPrestamos))
        chartP.Titles.Clear()
        chartP.Titles.Add("Préstamos Semanales")
    End Sub

    ' =============================
    ' GRAFICA DE LIBROS MÁS SOLICITADOS
    ' =============================
    Friend Sub MostrarGraficaLibros()
        Dim datosLibros As New Dictionary(Of String, Integer) From {
            {"Romeo y Julieta", 45},
            {"El Principito", 60},
            {"Cien Años de Soledad", 30},
            {"Don Quijote", 20},
            {"La Odisea", 15}
        }

        chartLibros.Series.Clear()
        chartLibros.Series.Add(CrearSerie("Libros más solicitados", SeriesChartType.Column, Color.MediumSlateBlue, datosLibros))
        chartLibros.Titles.Clear()
        chartLibros.Titles.Add("Libros Más Solicitados")
    End Sub

    ' =============================
    ' MÉTODO AUXILIAR PARA CREAR SERIES
    ' =============================
    Private Function CrearSerie(nombre As String, tipo As SeriesChartType, color As Color, datos As Dictionary(Of String, Integer)) As Series
        Dim serie As New Series(nombre) With {
            .ChartType = tipo,
            .Color = color
        }

        For Each kvp In datos
            serie.Points.AddXY(kvp.Key, kvp.Value)
        Next

        Return serie
    End Function

End Class
