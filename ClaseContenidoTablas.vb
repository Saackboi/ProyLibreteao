Imports System.Drawing.Printing

Imports System.Drawing

Public Class ClaseContenidoTablas
    Private ReadOnly dgvActividad As DataGridView
    Private ReadOnly dgvLibros As DataGridView
    Private ReadOnly dgvMultas As DataGridView

    Public Sub New(dgvTablaActividadSemanal As DataGridView, dgvLibros As DataGridView, dgvMultas As DataGridView)
        ' Validar dependencias recibidas para evitar NullReferenceException posteriores.
        If dgvTablaActividadSemanal Is Nothing Then Throw New ArgumentNullException(NameOf(dgvTablaActividadSemanal))
        If dgvLibros Is Nothing Then Throw New ArgumentNullException(NameOf(dgvLibros))
        If dgvMultas Is Nothing Then Throw New ArgumentNullException(NameOf(dgvMultas))

        Me.dgvActividad = dgvTablaActividadSemanal
        Me.dgvLibros = dgvLibros
        Me.dgvMultas = dgvMultas
    End Sub

    Friend Sub MostrarTablaActividadSemenal()
        If dgvActividad Is Nothing Then Return
        dgvActividad.Columns.Clear()
        ' Cambiar estilo de borde
        dgvActividad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single


        dgvActividad.Columns.Add("Semana", "Semana")
        dgvActividad.Columns.Add("Prestamos", "Préstamos")
        dgvActividad.Columns.Add("Devoluciones", "Devolución")
        dgvActividad.Columns.Add("LibrosNoDevueltos", "Libros No Devueltos")
        dgvActividad.Columns.Add("Multas", "Multas")

        dgvActividad.Rows.Add("1 - 7 de octubre", 100, 90, 10, 9)
        dgvActividad.Rows.Add("8 - 14 de octubre", 80, 75, 5, 8)

    End Sub

    Friend Sub MostrarTablaLibros()

        If dgvLibros Is Nothing Then Return
        dgvLibros.Columns.Clear()
        ' Cambiar estilo de borde
        dgvLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single


        dgvLibros.Columns.Add("Semana", "Semana")
        dgvLibros.Columns.Add("Prestamos", "Préstamos")
        dgvLibros.Columns.Add("Devoluciones", "Devolución")
        dgvLibros.Columns.Add("LibrosNoDevueltos", "Libros No Devueltos")
        dgvLibros.Columns.Add("Multas", "Multas")

        dgvLibros.Rows.Add("1 - 7 de octubre", 100, 90, 10, 9)
        dgvLibros.Rows.Add("8 - 14 de octubre", 80, 75, 5, 8)

    End Sub

    Friend Sub MostrarTablaMultas()
        If dgvMultas Is Nothing Then Return
        dgvMultas.Columns.Clear()
        ' Cambiar estilo de borde
        dgvMultas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single


        dgvMultas.Columns.Add("Semana", "Semana")
        dgvMultas.Columns.Add("Prestamos", "Préstamos")
        dgvMultas.Columns.Add("Devoluciones", "Devolución")
        dgvMultas.Columns.Add("LibrosNoDevueltos", "Libros No Devueltos")
        dgvMultas.Columns.Add("Multas", "Multas")

        dgvMultas.Rows.Add("1 - 7 de octubre", 100, 90, 10, 9)
        dgvMultas.Rows.Add("8 - 14 de octubre", 80, 75, 5, 8)
    End Sub

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

                printDoc.Print()
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

        ' --- Logo  ---
        Try
            g.DrawImage(My.Resources.iconoLibro, e.MarginBounds.Right - 100, e.MarginBounds.Top, 80, 80)
        Catch
        End Try

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
                    dibujarTabla(dgvLibros, "Tabla de Libros")
            End Select
        End If
    End Sub

End Class
