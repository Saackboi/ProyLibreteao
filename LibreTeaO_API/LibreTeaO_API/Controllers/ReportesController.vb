Imports System.Data.SqlClient
Imports System.Web.Http

Public Class ReportesController
    Inherits ApiController

    ' ==========================================
    ' GET: Tarjetas (KPIs)
    ' ==========================================
    <HttpGet>
    <Route("api/reportes/kpis")>
    Public Function GetKpis() As IHttpActionResult
        Dim kpis As New DashboardKpis()

        Using cn = GetConnection()
            Dim query As String = "
                SELECT 
                    (SELECT COUNT(*) FROM usuario) AS TotalUsuarios,
                    (SELECT COUNT(*) FROM prestamo) AS TotalPrestamos,
                    (SELECT COUNT(*) FROM devolucion) AS TotalDevoluciones,
                    (SELECT COUNT(*) FROM categorias) AS TotalCategorias,
                    (SELECT COUNT(*) FROM devolucion WHERE multa > 0) AS TotalMultasCount,
                    (SELECT COUNT(*) FROM libro) AS TotalLibros"

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        kpis.TotalUsuarios = Convert.ToInt32(reader("TotalUsuarios"))
                        kpis.TotalPrestamos = Convert.ToInt32(reader("TotalPrestamos"))
                        kpis.TotalDevoluciones = Convert.ToInt32(reader("TotalDevoluciones"))
                        kpis.TotalCategorias = Convert.ToInt32(reader("TotalCategorias"))
                        kpis.TotalMultasCount = Convert.ToInt32(reader("TotalMultasCount"))
                        kpis.TotalLibros = Convert.ToInt32(reader("TotalLibros"))
                    End If
                End Using
            End Using
        End Using

        Return Ok(kpis)
    End Function

    ' ==========================================
    ' GET: Actividad Semanal (Gráfica)
    ' ==========================================
    <HttpGet>
    <Route("api/reportes/semanal")>
    Public Function GetActividadSemanal() As IHttpActionResult
        Dim lista As New List(Of ActividadSemanal)

        Using cn = GetConnection()
            Dim query As String = "
                SELECT 
                    CONCAT('Semana ', DATEPART(iso_week, p.fecha_prestamo), ' - ', YEAR(p.fecha_prestamo)) as Semana,
                    COUNT(p.id_prestamo) as CantidadPrestamos,
                    (SELECT COUNT(*) FROM devolucion d WHERE DATEPART(iso_week, d.fecha_real_devolucion) = DATEPART(iso_week, p.fecha_prestamo)) as CantidadDevoluciones,
                    ISNULL((SELECT SUM(d2.multa) FROM devolucion d2 WHERE DATEPART(iso_week, d2.fecha_real_devolucion) = DATEPART(iso_week, p.fecha_prestamo)), 0) as TotalMultas
                FROM prestamo p
                GROUP BY DATEPART(iso_week, p.fecha_prestamo), YEAR(p.fecha_prestamo)
                ORDER BY YEAR(p.fecha_prestamo) DESC, DATEPART(iso_week, p.fecha_prestamo) DESC"

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ActividadSemanal With {
                            .Semana = reader("Semana").ToString(),
                            .CantidadPrestamos = Convert.ToInt32(reader("CantidadPrestamos")),
                            .CantidadDevoluciones = Convert.ToInt32(reader("CantidadDevoluciones")),
                            .TotalMultas = Convert.ToDecimal(reader("TotalMultas"))
                        }
                        item.Pendientes = item.CantidadPrestamos - item.CantidadDevoluciones

                        lista.Add(item)
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function

    ' ==========================================
    ' GET: Top Libros
    ' ==========================================
    <HttpGet>
    <Route("api/reportes/toplibros")>
    Public Function GetTopLibros() As IHttpActionResult
        Dim lista As New List(Of LibroPopular)

        Using cn = GetConnection()
            Dim query As String = "
                SELECT TOP 5 l.titulo, COUNT(p.id_prestamo) as VecesPrestado
                FROM prestamo p
                INNER JOIN libro l ON p.id_libro = l.id_libro
                GROUP BY l.titulo
                ORDER BY VecesPrestado DESC"

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New LibroPopular With {
                            .Titulo = reader("titulo").ToString(),
                            .VecesPrestado = Convert.ToInt32(reader("VecesPrestado"))
                        }
                        lista.Add(item)
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function

    ' 4. DETALLE DE MULTAS (Para la tabla de deudores)
    ' GET: api/reportes/multas
    <HttpGet>
    <Route("api/reportes/multas")>
    Public Function GetDetalleMultas() As IHttpActionResult
        Dim lista As New List(Of ReporteMulta)

        Using cn = GetConnection()
            cn.Open()
            Dim query As String = "
                SELECT u.nombre AS Usuario, l.titulo AS Libro, d.fecha_real_devolucion, d.multa
                FROM devolucion d
                INNER JOIN prestamo p ON d.id_prestamo = p.id_prestamo
                INNER JOIN usuario u ON p.id_usuario = u.id_usuario
                INNER JOIN libro l ON p.id_libro = l.id_libro
                WHERE d.multa > 0"

            Using cmd As New SqlCommand(query, cn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New ReporteMulta With {
                            .Usuario = reader("Usuario").ToString(),
                            .Libro = reader("Libro").ToString(),
                            .FechaDev = Convert.ToDateTime(reader("fecha_real_devolucion")).ToString("dd/MM/yyyy"),
                            .Monto = Convert.ToDecimal(reader("multa"))
                        })
                    End While
                End Using
            End Using
        End Using
        Return Ok(lista)
    End Function

    Private Function GetFechaFiltro(filtro As String) As DateTime
        Select Case filtro?.ToLower()
            Case "7dias"
                Return DateTime.Now.AddDays(-7)
            Case "mes"
                Return DateTime.Now.AddDays(-30)
            Case "anio"
                Return DateTime.Now.AddDays(-365)
            Case Else
                Return DateTime.Now.AddYears(-5)
        End Select
    End Function


    <HttpGet>
    <Route("api/reportes/semanal/filtrar")>
    Public Function GetActividadSemanalFiltrado(filtro As String) As IHttpActionResult
        Dim lista As New List(Of ActividadSemanal)
        Dim fechaDesde = GetFechaFiltro(filtro)

        Using cn = GetConnection()
            Dim query As String = "
            SELECT 
                CONCAT('Semana ', DATEPART(iso_week, p.fecha_prestamo), '-', YEAR(p.fecha_prestamo)) AS Semana,
                COUNT(*) AS CantidadPrestamos,
                (SELECT COUNT(*) FROM devolucion d 
                    WHERE d.fecha_real_devolucion >= @fechaDesde
                    AND DATEPART(iso_week, d.fecha_real_devolucion) = DATEPART(iso_week, p.fecha_prestamo)
                ) AS CantidadDevoluciones,
                ISNULL((
                    SELECT SUM(multa) FROM devolucion d2
                    WHERE d2.fecha_real_devolucion >= @fechaDesde
                    AND DATEPART(iso_week, d2.fecha_real_devolucion) = DATEPART(iso_week, p.fecha_prestamo)
                ), 0) AS TotalMultas
            FROM prestamo p
            WHERE p.fecha_prestamo >= @fechaDesde
            GROUP BY DATEPART(iso_week, p.fecha_prestamo), YEAR(p.fecha_prestamo)
            ORDER BY YEAR(p.fecha_prestamo) DESC, DATEPART(iso_week, p.fecha_prestamo) DESC
        "

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde)

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New ActividadSemanal With {
                        .Semana = reader("Semana").ToString(),
                        .CantidadPrestamos = CInt(reader("CantidadPrestamos")),
                        .CantidadDevoluciones = CInt(reader("CantidadDevoluciones")),
                        .Pendientes = CInt(reader("CantidadPrestamos")) - CInt(reader("CantidadDevoluciones")),
                        .TotalMultas = CDec(reader("TotalMultas"))
                    })
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function


    <HttpGet>
    <Route("api/reportes/multas/filtrar")>
    Public Function GetMultasFiltrado(filtro As String) As IHttpActionResult
        Dim lista As New List(Of ReporteMulta)
        Dim fechaDesde = GetFechaFiltro(filtro)

        Using cn = GetConnection()
            Dim query As String = "
            SELECT 
                u.nombre AS Usuario,
                l.titulo AS Libro,
                d.fecha_real_devolucion,
                d.multa
            FROM devolucion d
            INNER JOIN prestamo p ON d.id_prestamo = p.id_prestamo
            INNER JOIN usuario u ON p.id_usuario = u.id_usuario
            INNER JOIN libro l ON p.id_libro = l.id_libro
            WHERE d.multa > 0
            AND d.fecha_real_devolucion >= @fechaDesde
            ORDER BY d.fecha_real_devolucion DESC
        "

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde)

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New ReporteMulta With {
                        .Usuario = reader("Usuario").ToString(),
                        .Libro = reader("Libro").ToString(),
                        .FechaDev = CDate(reader("fecha_real_devolucion")).ToString("dd/MM/yyyy"),
                        .Monto = CDec(reader("multa"))
                    })
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function

    <HttpGet>
    <Route("api/reportes/libros/filtrar")>
    Public Function GetLibrosFiltrado(filtro As String) As IHttpActionResult
        Dim lista As New List(Of LibroPopular)
        Dim fechaDesde = GetFechaFiltro(filtro)

        Using cn = GetConnection()
            Dim query As String = "
            SELECT 
                l.titulo,
                COUNT(p.id_prestamo) AS VecesPrestado
            FROM prestamo p
            INNER JOIN libro l ON p.id_libro = l.id_libro
            WHERE p.fecha_prestamo >= @fechaDesde
            GROUP BY l.titulo
            ORDER BY VecesPrestado DESC
        "

            cn.Open()
            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde)

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New LibroPopular With {
                        .Titulo = reader("titulo").ToString(),
                        .VecesPrestado = CInt(reader("VecesPrestado"))
                    })
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function
    <HttpGet>
    <Route("api/reportes/semanal/buscar")>
    Public Function BuscarActividad(texto As String) As IHttpActionResult

        ' Si el usuario borra el texto → DEVOLVER LISTA VACÍA
        If String.IsNullOrWhiteSpace(texto) Then
            Return Ok(New List(Of ActividadSemanal)())
        End If

        Dim lista As New List(Of ActividadSemanal)

        Using cn = GetConnection()
            cn.Open()

            Dim query As String = "
            SELECT 
                CONCAT('Semana ', DATEPART(iso_week, p.fecha_prestamo), '-', YEAR(p.fecha_prestamo)) AS Semana,
                COUNT(*) AS CantidadPrestamos,
                (SELECT COUNT(*) FROM devolucion d 
                    WHERE DATEPART(iso_week, d.fecha_real_devolucion) = DATEPART(iso_week, p.fecha_prestamo)
                ) AS CantidadDevoluciones,
                ISNULL((
                    SELECT SUM(multa) FROM devolucion d2
                    WHERE DATEPART(iso_week, d2.fecha_real_devolucion) = DATEPART(iso_week, p.fecha_prestamo)
                ), 0) AS TotalMultas
            FROM prestamo p
            GROUP BY DATEPART(iso_week, p.fecha_prestamo), YEAR(p.fecha_prestamo)
            HAVING CONCAT('Semana ', DATEPART(iso_week, p.fecha_prestamo), '-', YEAR(p.fecha_prestamo)) 
                   LIKE '%' + @txt + '%'
        "

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@txt", texto)

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New ActividadSemanal With {
                        .Semana = reader("Semana").ToString(),
                        .CantidadPrestamos = CInt(reader("CantidadPrestamos")),
                        .CantidadDevoluciones = CInt(reader("CantidadDevoluciones")),
                        .Pendientes = CInt(reader("CantidadPrestamos")) - CInt(reader("CantidadDevoluciones")),
                        .TotalMultas = CDec(reader("TotalMultas"))
                    })
                    End While
                End Using
            End Using

        End Using

        Return Ok(lista)
    End Function


    <HttpGet>
    <Route("api/reportes/libros/buscar")>
    Public Function BuscarLibros(texto As String) As IHttpActionResult

        ' Si el usuario borra el texto → devolver lista vacía
        If String.IsNullOrWhiteSpace(texto) Then
            Return Ok(New List(Of LibroPopular)())
        End If

        Dim lista As New List(Of LibroPopular)

        Using cn = GetConnection()
            cn.Open()

            Dim query As String = "
            SELECT l.titulo, COUNT(p.id_prestamo) AS VecesPrestado
            FROM prestamo p
            INNER JOIN libro l ON p.id_libro = l.id_libro
            WHERE l.titulo LIKE '%' + @txt + '%'
            GROUP BY l.titulo
        "

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@txt", texto)

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New LibroPopular With {
                        .Titulo = reader("titulo").ToString(),
                        .VecesPrestado = CInt(reader("VecesPrestado"))
                    })
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function

    <HttpGet>
    <Route("api/reportes/multas/buscar")>
    Public Function BuscarMultas(texto As String) As IHttpActionResult

        ' Si el usuario borra el texto → devolver lista vacía
        If String.IsNullOrWhiteSpace(texto) Then
            Return Ok(New List(Of ReporteMulta)())
        End If

        Dim lista As New List(Of ReporteMulta)

        Using cn = GetConnection()
            cn.Open()

            Dim query As String = "
            SELECT 
                u.nombre AS Usuario,
                l.titulo AS Libro,
                d.fecha_real_devolucion,
                d.multa
            FROM devolucion d
            INNER JOIN prestamo p ON d.id_prestamo = p.id_prestamo
            INNER JOIN usuario u ON p.id_usuario = u.id_usuario
            INNER JOIN libro l ON p.id_libro = l.id_libro
            WHERE d.multa > 0
            AND (
                u.nombre LIKE '%' + @txt + '%' OR
                l.titulo LIKE '%' + @txt + '%' OR
                CONVERT(VARCHAR, d.fecha_real_devolucion, 103) LIKE '%' + @txt + '%' OR
                CONVERT(VARCHAR, d.multa) LIKE '%' + @txt + '%'
            )
        "

            Using cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@txt", texto)

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        lista.Add(New ReporteMulta With {
                            .Usuario = reader("Usuario").ToString(),
                            .Libro = reader("Libro").ToString(),
                            .FechaDev = CDate(reader("fecha_real_devolucion")).ToString("dd/MM/yyyy"),
                            .Monto = CDec(reader("multa"))
                        })
                    End While
                End Using
            End Using
        End Using

        Return Ok(lista)
    End Function


End Class