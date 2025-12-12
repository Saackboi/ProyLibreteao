Imports System.Configuration
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ClaseContenidoTablas
    Private ReadOnly dgvActividad As DataGridView
    Private ReadOnly dgvLibros As DataGridView
    Private ReadOnly dgvMultas As DataGridView

    ' ==========================================
    ' CONFIGURACIÓN API
    ' ==========================================

    Private ReadOnly BaseUrl As String = ConfigurationManager.AppSettings("ApiBaseUrl")

    Private Shared client As HttpClient = CrearClienteInseguro()

    Private Shared Function CrearClienteInseguro() As HttpClient
        Dim handler As New HttpClientHandler With {
            .ServerCertificateCustomValidationCallback = Function(message, cert, chain, errors) True
        }
        Return New HttpClient(handler)
    End Function

    Public Sub New(dgvTablaActividadSemanal As DataGridView, dgvLibros As DataGridView, dgvMultas As DataGridView)
        ' Validar dependencias
        If dgvTablaActividadSemanal Is Nothing Then Throw New ArgumentNullException(NameOf(dgvTablaActividadSemanal))
        If dgvLibros Is Nothing Then Throw New ArgumentNullException(NameOf(dgvLibros))
        If dgvMultas Is Nothing Then Throw New ArgumentNullException(NameOf(dgvMultas))

        Me.dgvActividad = dgvTablaActividadSemanal
        Me.dgvLibros = dgvLibros
        Me.dgvMultas = dgvMultas
    End Sub

    ' =========================================================================
    ' 1. ACTIVIDAD SEMANAL (Tabla 1)
    ' Endpoint: GET api/reportes/semanal
    ' =========================================================================
    Friend Async Sub MostrarTablaActividadSemenal()
        If dgvActividad Is Nothing Then Return

        Try
            ' Llamada API
            Dim json As String = Await client.GetStringAsync(BaseUrl & "/reportes/semanal")
            Dim lista = JsonConvert.DeserializeObject(Of List(Of ActividadSemanal))(json)

            ' Configuración Visual
            dgvActividad.Columns.Clear()
            dgvActividad.Rows.Clear()
            dgvActividad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

            dgvActividad.Columns.Add("Semana", "Semana (Año)")
            dgvActividad.Columns.Add("Prestamos", "Préstamos")
            dgvActividad.Columns.Add("Devoluciones", "Devoluciones")
            dgvActividad.Columns.Add("Multas", "Total Multas ($)")

            ' Llenado
            For Each item In lista
                dgvActividad.Rows.Add(
                    item.Semana,
                    item.CantidadPrestamos,
                    item.CantidadDevoluciones,
                    "$" & item.TotalMultas.ToString("N2")
                )
            Next
        Catch ex As Exception
            ' Manejo silencioso o MessageBox.Show("Error al cargar actividad: " & ex.Message)
        End Try
    End Sub

    ' =========================================================================
    ' 2. LISTA DE LIBROS (Tabla 2)
    ' Endpoint: GET api/libros (Reusamos el del catálogo)
    ' =========================================================================
    Friend Async Sub MostrarTablaLibros()
        If dgvLibros Is Nothing Then Return

        Try
            ' Llamada API
            Dim json As String = Await client.GetStringAsync(BaseUrl & "/libros")
            Dim lista = JsonConvert.DeserializeObject(Of List(Of Libro))(json)

            ' Configuración Visual
            dgvLibros.Columns.Clear()
            dgvLibros.Rows.Clear()
            dgvLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

            dgvLibros.Columns.Add("ID", "ID")
            dgvLibros.Columns.Add("Titulo", "Título")
            dgvLibros.Columns.Add("Categoria", "Categoría")
            dgvLibros.Columns.Add("Estado", "Disponibilidad")

            ' Llenado
            For Each libro In lista
                dgvLibros.Rows.Add(
                    libro.idLibro,
                    libro.titulo,
                    libro.nombreCategoria,
                    libro.estadoTexto
                )
            Next
        Catch ex As Exception
            ' Manejo silencioso
        End Try
    End Sub

    ' =========================================================================
    ' 3. MULTAS DETALLADAS (Tabla 3)
    ' Endpoint: GET api/reportes/multas (El que creamos hace poco)
    ' =========================================================================
    Friend Async Sub MostrarTablaMultas()
        If dgvMultas Is Nothing Then Return

        Try
            ' Llamada API
            Dim json As String = Await client.GetStringAsync(BaseUrl & "/reportes/multas")
            Dim lista = JsonConvert.DeserializeObject(Of List(Of ReporteMulta))(json)

            ' Configuración Visual
            dgvMultas.Columns.Clear()
            dgvMultas.Rows.Clear()
            dgvMultas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

            dgvMultas.Columns.Add("Usuario", "Usuario")
            dgvMultas.Columns.Add("Libro", "Libro")
            dgvMultas.Columns.Add("FechaDev", "Fecha Devolución")
            dgvMultas.Columns.Add("Monto", "Monto Multa")

            ' Llenado
            For Each m In lista
                dgvMultas.Rows.Add(
                    m.Usuario,
                    m.Libro,
                    m.FechaDev,
                    "$" & m.Monto.ToString("N2")
                )
            Next
        Catch ex As Exception
            ' Manejo silencioso
        End Try
    End Sub

    ' =========================================================================
    ' 4. LÓGICA DE IMPRESIÓN (PDF)
    ' Esta parte NO CAMBIA, funciona sobre los datos visuales del Grid
    ' =========================================================================
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
            sfd.FileName = $"Reporte_{DateTime.Now:yyyyMMdd_HHmm}.pdf"

            If sfd.ShowDialog() = DialogResult.OK Then
                With printDoc.PrinterSettings
                    .PrinterName = "Microsoft Print to PDF"
                    .PrintToFile = True
                    .PrintFileName = sfd.FileName
                End With

                Try
                    printDoc.Print()
                    MessageBox.Show("Reporte generado exitosamente.")
                Catch ex As Exception
                    MessageBox.Show("Error al imprimir: Asegúrese de tener 'Microsoft Print to PDF' instalado.")
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

        ' --- Logo (Opcional) ---
        ' Try
        '    g.DrawImage(My.Resources.iconoLibro, e.MarginBounds.Right - 100, e.MarginBounds.Top, 80, 80)
        ' Catch
        ' End Try

        Dim lapiz As New Pen(Color.Black, 1)

        ' Función para dibujar una tabla
        Dim dibujarTabla As Action(Of DataGridView, String) =
        Sub(dgv As DataGridView, titulo As String)
            g.DrawString(titulo, fuenteTabla, brocha, margenIzq, y)
            y += 25
            If dgv.Columns.Count = 0 Then Return

            Dim anchoPagina As Integer = e.MarginBounds.Width
            Dim anchoColumna As Integer = anchoPagina \ dgv.Columns.Count

            Dim x As Integer = margenIzq
            For Each col As DataGridViewColumn In dgv.Columns
                g.DrawRectangle(lapiz, x, y, anchoColumna, 25)
                g.DrawString(col.HeaderText, fuenteTabla, brocha, x + 2, y + 5)
                x += anchoColumna
            Next
            y += 25

            For Each fila As DataGridViewRow In dgv.Rows
                If Not fila.IsNewRow Then
                    Dim alturaFila As Integer = 25
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

        ' --- Seleccionar tabla según la pestaña ---
        If tabSeleccionada IsNot Nothing Then
            Select Case tabSeleccionada.Name
                Case "tpActividadSemanal"
                    dibujarTabla(dgvActividad, "Tabla de Actividad Semanal")
                Case "tpMultas"
                    dibujarTabla(dgvMultas, "Tabla de Multas")
                Case "tpLibros"
                    dibujarTabla(dgvLibros, "Listado de Libros")
            End Select
        End If
    End Sub

    ' =============================================================
    '   FILTRO – ACTIVIDAD
    ' =============================================================
    Public Async Sub FiltrarActividadSemanal(filtro As String)
        Try
            Dim url = $"{BaseUrl}/reportes/semanal/filtrar?filtro={filtro}"
            Dim json = Await client.GetStringAsync(url)
            Dim lista = JsonConvert.DeserializeObject(Of List(Of ActividadSemanal))(json)

            dgvActividad.Rows.Clear()

            For Each item In lista
                dgvActividad.Rows.Add(
                item.Semana,
                item.CantidadPrestamos,
                item.CantidadDevoluciones,
                item.Pendientes,
                item.TotalMultas
            )
            Next

        Catch ex As Exception
            MessageBox.Show("Error filtrando actividad semanal: " & ex.Message)
        End Try
    End Sub



    ' =============================================================
    '   FILTRO – LIBROS
    ' =============================================================
    Public Async Sub FiltrarLibros(filtro As String)
        Try
            Dim url = $"{BaseUrl}/reportes/libros/filtrar?filtro={filtro}"
            Dim json = Await client.GetStringAsync(url)
            Dim lista = JsonConvert.DeserializeObject(Of List(Of LibroPopular))(json)

            dgvLibros.Rows.Clear()

            For Each item In lista
                dgvLibros.Rows.Add(
                item.Titulo,
                item.VecesPrestado
            )
            Next

        Catch ex As Exception
            MessageBox.Show("Error filtrando libros: " & ex.Message)
        End Try
    End Sub




    ' =============================================================
    '   FILTRO – MULTAS
    ' =============================================================
    Public Async Sub FiltrarMultas(filtro As String)
        Try
            filtro = SanitizarTexto(filtro)

            Dim url = $"{BaseUrl}/reportes/multas/filtrar?filtro={Uri.EscapeDataString(filtro)}"

            Dim json = Await client.GetStringAsync(url)

            If String.IsNullOrWhiteSpace(json) OrElse json = "null" Then
                dgvMultas.Rows.Clear()
                Exit Sub
            End If

            Dim lista = JsonConvert.DeserializeObject(Of List(Of ReporteMulta))(json)

            dgvMultas.Rows.Clear()

            If lista Is Nothing Then Exit Sub

            For Each item In lista
                dgvMultas.Rows.Add(
                item.Usuario,
                item.Libro,
                item.FechaDev,
                "$" & item.Monto.ToString("N2")
            )
            Next

        Catch ex As TaskCanceledException
            MessageBox.Show("Tiempo de espera agotado al cargar multas.")
        Catch ex As Exception
            MessageBox.Show("Error filtrando multas: " & ex.Message)
        End Try
    End Sub

    ' ================================================================
    ' 🔍 MÉTODO GENERAL PARA VALIDAR TEXTO ANTES DE ENVIAR AL API
    ' ================================================================
    Private Function SanitizarTexto(texto As String) As String
        If texto Is Nothing Then Return ""
        texto = texto.Trim()

        ' Evitar caracteres peligrosos para URLs o SQL
        Dim invalido As Char() = {"'", """", ";", "|", "\", "/", "<", ">"}

        For Each c In invalido
            texto = texto.Replace(c, "")
        Next

        Return texto
    End Function


    Public Async Sub BuscarMultas(texto As String)
        Try

            If String.IsNullOrWhiteSpace(texto) Then
                MostrarTablaMultas()      '  <<--- ESTE MÉTODO DEBE CARGAR TODAS LAS MULTAS NORMALES
                Exit Sub
            End If
            texto = SanitizarTexto(texto)

            Dim url = $"{BaseUrl}/reportes/multas/buscar?texto={Uri.EscapeDataString(texto)}"
            Dim json = Await client.GetStringAsync(url)

            If String.IsNullOrWhiteSpace(json) OrElse json = "null" Then
                dgvMultas.Rows.Clear()
                Exit Sub
            End If

            Dim lista = JsonConvert.DeserializeObject(Of List(Of ReporteMulta))(json)

            dgvMultas.Rows.Clear()

            If lista Is Nothing Then Exit Sub

            For Each item In lista
                dgvMultas.Rows.Add(item.Usuario, item.Libro, item.FechaDev, "$" & item.Monto.ToString("N2"))
            Next

        Catch
            dgvMultas.Rows.Clear()
        End Try
    End Sub


    Public Async Sub BuscarLibros(texto As String)
        Try
            If String.IsNullOrWhiteSpace(texto) Then
                MostrarTablaLibros()      '  <<--- ESTE MÉTODO DEBE CARGAR TODAS LAS MULTAS NORMALES
                Exit Sub
            End If
            texto = SanitizarTexto(texto)

            Dim url = $"{BaseUrl}/reportes/libros/buscar?texto={Uri.EscapeDataString(texto)}"
            Dim json = Await client.GetStringAsync(url)

            If String.IsNullOrWhiteSpace(json) Then
                dgvLibros.Rows.Clear()
                Exit Sub
            End If

            Dim lista = JsonConvert.DeserializeObject(Of List(Of LibroPopular))(json)

            dgvLibros.Rows.Clear()

            If lista Is Nothing Then Exit Sub

            For Each item In lista
                dgvLibros.Rows.Add(item.Titulo, item.VecesPrestado)
            Next

        Catch
            dgvLibros.Rows.Clear()
        End Try
    End Sub

    Public Async Sub BuscarActividad(texto As String)
        Try
            If String.IsNullOrWhiteSpace(texto) Then
                MostrarTablaActividadSemenal()      '  <<--- ESTE MÉTODO DEBE CARGAR TODAS LAS MULTAS NORMALES
                Exit Sub
            End If
            texto = SanitizarTexto(texto)

            Dim url = $"{BaseUrl}/reportes/semanal/buscar?texto={Uri.EscapeDataString(texto)}"
            Dim json = Await client.GetStringAsync(url)

            If String.IsNullOrWhiteSpace(json) OrElse json = "null" Then
                dgvActividad.Rows.Clear()
                Exit Sub
            End If

            Dim lista = JsonConvert.DeserializeObject(Of List(Of ActividadSemanal))(json)

            dgvActividad.Rows.Clear()

            If lista Is Nothing Then Exit Sub

            For Each item In lista
                dgvActividad.Rows.Add(
                    item.Semana,
                    item.CantidadPrestamos,
                    item.CantidadDevoluciones,
                    item.Pendientes,
                    item.TotalMultas
                )
            Next

        Catch
            dgvActividad.Rows.Clear()
        End Try
    End Sub


End Class
