Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Data.SqlClient

Public Class ClaseContenidoTablas
    Private ReadOnly dgvActividad As DataGridView
    Private ReadOnly dgvLibros As DataGridView
    Private ReadOnly dgvMultas As DataGridView

    ' Instancia de la clase de conexión para realizar consultas
    Private db As New Database()

    Public Sub New(dgvTablaActividadSemanal As DataGridView, dgvLibros As DataGridView, dgvMultas As DataGridView)
        ' Validar dependencias recibidas para evitar NullReferenceException posteriores.
        If dgvTablaActividadSemanal Is Nothing Then Throw New ArgumentNullException(NameOf(dgvTablaActividadSemanal))
        If dgvLibros Is Nothing Then Throw New ArgumentNullException(NameOf(dgvLibros))
        If dgvMultas Is Nothing Then Throw New ArgumentNullException(NameOf(dgvMultas))

        Me.dgvActividad = dgvTablaActividadSemanal
        Me.dgvLibros = dgvLibros
        Me.dgvMultas = dgvMultas
    End Sub

    ' -------------------------------------------------------------------------
    ' MÉTODO 1: CARGAR ACTIVIDAD SEMANAL (Estadísticas reales desde BD)
    ' -------------------------------------------------------------------------
    Friend Sub MostrarTablaActividadSemenal()
        If dgvActividad Is Nothing Then Return

        ' Limpiar y configurar columnas
        dgvActividad.Columns.Clear()
        dgvActividad.Rows.Clear()
        dgvActividad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        dgvActividad.Columns.Add("Semana", "Semana (Año)")
        dgvActividad.Columns.Add("Prestamos", "Préstamos")
        dgvActividad.Columns.Add("Devoluciones", "Devoluciones")
        dgvActividad.Columns.Add("Multas", "Total Multas ($)")

        ' Consulta SQL: Agrupa préstamos, devoluciones y multas por semana
        ' Se usa DATEPART(iso_week) para identificar el número de semana
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
                dgvActividad.Rows.Add(
                    row("Semana"),
                    row("CantidadPrestamos"),
                    row("CantidadDevoluciones"),
                    Convert.ToDecimal(row("TotalMultas")).ToString("N2") ' Formato de moneda
                )
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar la actividad semanal: " & ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' MÉTODO 2: CARGAR LIBROS (Catálogo desde BD con Categorías)
    ' -------------------------------------------------------------------------
    Friend Sub MostrarTablaLibros()
        If dgvLibros Is Nothing Then Return

        ' Limpiar y configurar columnas (Ajustadas a la realidad de la tabla Libro)
        dgvLibros.Columns.Clear()
        dgvLibros.Rows.Clear()
        dgvLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        dgvLibros.Columns.Add("ID", "ID")
        dgvLibros.Columns.Add("Titulo", "Título")
        dgvLibros.Columns.Add("Categoria", "Categoría")
        dgvLibros.Columns.Add("Estado", "Disponibilidad")

        ' Consulta SQL: Une la tabla Libro con Categorias
        Dim query As String = "
            SELECT l.id_libro, l.titulo, c.nombre_categoria, l.disponibilidad 
            FROM libro l
            INNER JOIN categorias c ON l.id_categoria = c.id_categoria"

        Try
            Dim dt As DataTable = db.ExecuteQuery(query, Nothing)

            For Each row As DataRow In dt.Rows
                ' Interpretar el bit de disponibilidad (1 = Disponible, 0 = Prestado)
                Dim estado As String = If(row("disponibilidad") IsNot DBNull.Value AndAlso Convert.ToBoolean(row("disponibilidad")), "Disponible", "Prestado")

                dgvLibros.Rows.Add(
                    row("id_libro"),
                    row("titulo"),
                    row("nombre_categoria"),
                    estado
                )
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar los libros: " & ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' MÉTODO 3: CARGAR MULTAS (Usuarios con deuda activa)
    ' -------------------------------------------------------------------------
    Friend Sub MostrarTablaMultas()
        If dgvMultas Is Nothing Then Return

        ' Limpiar y configurar columnas (Ajustadas para mostrar quién debe qué)
        dgvMultas.Columns.Clear()
        dgvMultas.Rows.Clear()
        dgvMultas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        dgvMultas.Columns.Add("Usuario", "Usuario")
        dgvMultas.Columns.Add("Libro", "Libro")
        dgvMultas.Columns.Add("FechaDev", "Fecha Devolución")
        dgvMultas.Columns.Add("Monto", "Monto Multa")

        ' Consulta SQL: Une Devolucion, Prestamo, Usuario y Libro
        ' Filtra solo aquellas devoluciones donde la multa sea mayor a 0
        Dim query As String = "
            SELECT u.nombre, l.titulo, d.fecha_real_devolucion, d.multa
            FROM devolucion d
            INNER JOIN prestamo p ON d.id_prestamo = p.id_prestamo
            INNER JOIN usuario u ON p.id_usuario = u.id_usuario
            INNER JOIN libro l ON p.id_libro = l.id_libro
            WHERE d.multa > 0"

        Try
            Dim dt As DataTable = db.ExecuteQuery(query, Nothing)

            For Each row As DataRow In dt.Rows
                dgvMultas.Rows.Add(
                    row("nombre"),
                    row("titulo"),
                    Convert.ToDateTime(row("fecha_real_devolucion")).ToString("dd/MM/yyyy"),
                    "$" & Convert.ToDecimal(row("multa")).ToString("N2")
                )
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar las multas: " & ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' LÓGICA DE IMPRESIÓN Y PDF
    ' -------------------------------------------------------------------------
    Friend Sub DescargarReportes(tabSeleccionada As TabPage)
        Dim printDoc As New Printing.PrintDocument()

        ' Suscribir el evento PrintPage para dibujar la página
        AddHandler printDoc.PrintPage, Sub(sender As Object, e As PrintPageEventArgs)
                                           PrintPageHandler(sender, e, tabSeleccionada)
                                       End Sub

        ' --- Configurar el guardado en PDF ---
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Archivo PDF|*.pdf"
            sfd.Title = "Guardar reporte como PDF"
            sfd.FileName = $"Reporte_{DateTime.Now:yyyyMMdd}.pdf"

            If sfd.ShowDialog() = DialogResult.OK Then
                With printDoc.PrinterSettings
                    .PrinterName = "Microsoft Print to PDF"
                    .PrintToFile = True
                    .PrintFileName = sfd.FileName
                End With

                Try
                    printDoc.Print()
                    MessageBox.Show("Reporte guardado exitosamente.")
                Catch ex As Exception
                    MessageBox.Show("Error al generar el PDF. Asegúrese de tener 'Microsoft Print to PDF' instalado. Detalle: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ' Modificar PrintPageHandler para recibir la pestaña seleccionada
    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs, tabSeleccionada As TabPage)
        Dim g As Graphics = e.Graphics
        Dim fuenteTitulo As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fuenteSubtitulo As New Font("Segoe UI", 10, FontStyle.Italic)
        Dim fuenteTabla As New Font("Segoe UI", 9)
        Dim brocha As Brush = Brushes.Black

        Dim margenIzq As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top

        ' --- Encabezado ---
        g.DrawString("Reporte de Actividades", fuenteTitulo, brocha, margenIzq, y)
        y += 30
        g.DrawString("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy"), fuenteSubtitulo, brocha, margenIzq, y)
        y += 40

        ' --- Logo (Opcional, envuelto en Try por si no existe el recurso) ---
        Try
            g.DrawImage(My.Resources.iconoLibro, e.MarginBounds.Right - 100, e.MarginBounds.Top, 80, 80)
        Catch
        End Try

        Dim lapiz As New Pen(Color.Black, 1)

        ' Función interna para dibujar una tabla dinámica
        Dim dibujarTabla As Action(Of DataGridView, String) =
        Sub(dgv As DataGridView, titulo As String)
            g.DrawString(titulo, fuenteTabla, brocha, margenIzq, y)
            y += 25
            If dgv.Columns.Count = 0 Then Return

            Dim anchoPagina As Integer = e.MarginBounds.Width
            Dim anchoColumna As Integer = anchoPagina \ dgv.Columns.Count

            ' Dibujar Encabezados
            Dim x As Integer = margenIzq
            For Each col As DataGridViewColumn In dgv.Columns
                g.DrawRectangle(lapiz, x, y, anchoColumna, 25)
                ' Recortar texto si es muy largo para el encabezado
                Dim textoHeader As String = col.HeaderText
                g.DrawString(textoHeader, fuenteTabla, brocha, x + 2, y + 5)
                x += anchoColumna
            Next
            y += 25

            ' Dibujar Filas
            For Each fila As DataGridViewRow In dgv.Rows
                If Not fila.IsNewRow Then
                    Dim alturaFila As Integer = 25

                    ' Calcular altura necesaria basada en el contenido
                    For Each celda As DataGridViewCell In fila.Cells
                        If celda.Value IsNot Nothing Then
                            Dim tamañoTexto As SizeF = g.MeasureString(celda.Value.ToString(), fuenteTabla, anchoColumna)
                            If tamañoTexto.Height + 5 > alturaFila Then
                                alturaFila = CInt(tamañoTexto.Height) + 5
                            End If
                        End If
                    Next

                    x = margenIzq
                    For Each celda As DataGridViewCell In fila.Cells
                        g.DrawRectangle(lapiz, x, y, anchoColumna, alturaFila)
                        If celda.Value IsNot Nothing Then
                            g.DrawString(celda.Value.ToString(), fuenteTabla, brocha, New RectangleF(x + 2, y + 2, anchoColumna - 4, alturaFila - 4))
                        End If
                        x += anchoColumna
                    Next
                    y += alturaFila
                End If
            Next
            y += 20
        End Sub

        ' --- Seleccionar qué tabla dibujar según la pestaña activa ---
        If tabSeleccionada IsNot Nothing Then
            Select Case tabSeleccionada.Name
                Case "tpActividadSemanal"
                    dibujarTabla(dgvActividad, "Tabla de Actividad Semanal")
                Case "tpMultas"
                    dibujarTabla(dgvMultas, "Tabla de Multas Pendientes")
                Case "tpLibros"
                    dibujarTabla(dgvLibros, "Listado de Libros")
            End Select
        End If
    End Sub

End Class