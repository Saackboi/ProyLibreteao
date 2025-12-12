Imports System.Drawing.Printing
Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Imports Xceed.Words.NET
Imports SD = System.Drawing

Public Class Exportador

    ' ============================================================
    '   FUNCIÓN AUXILIAR PARA GENERAR EL NOMBRE DE ARCHIVO
    ' ============================================================
    Private Shared Function GenerarNombreArchivo() As String
        Dim fechaHora As String = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")
        Return $"REPORTE DE PRESTAMOS {fechaHora}"
    End Function

    ' ============================================================
    '   SELECCIONAR RUTA
    ' ============================================================
    Private Shared Function SeleccionarRuta(filtro As String, defecto As String) As String
        Using dlg As New SaveFileDialog()
            dlg.Filter = filtro
            dlg.FileName = defecto
            dlg.AddExtension = True

            If dlg.ShowDialog() = DialogResult.OK Then
                Return dlg.FileName
            Else
                Return Nothing
            End If
        End Using
    End Function

    ' ============================================================
    '   EXPORTAR A EXCEL (.xlsx)
    ' ============================================================
    Public Shared Sub ExportarExcel(grid As DataGridView)
        Dim nombreArchivoDefecto As String = GenerarNombreArchivo() & ".xlsx"
        Dim ruta = SeleccionarRuta("Excel (*.xlsx)|*.xlsx", nombreArchivoDefecto)
        If ruta Is Nothing Then Exit Sub

        ExcelPackage.License.SetNonCommercialOrganization("LIBRETEAO")

        Using excel As New ExcelPackage()
            Dim hoja = excel.Workbook.Worksheets.Add("Reporte")

            ' Encabezados
            For c As Integer = 0 To grid.Columns.Count - 1
                Dim celda = hoja.Cells(1, c + 1)
                celda.Value = grid.Columns(c).HeaderText
                celda.Style.Font.Bold = True
                celda.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
                celda.Style.Fill.PatternType = ExcelFillStyle.Solid
                celda.Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                celda.Style.Border.BorderAround(ExcelBorderStyle.Thin)
            Next

            ' Filas
            For r As Integer = 0 To grid.Rows.Count - 1
                If Not grid.Rows(r).IsNewRow Then
                    For c As Integer = 0 To grid.Columns.Count - 1
                        Dim celda = hoja.Cells(r + 2, c + 1)
                        celda.Value = If(grid.Rows(r).Cells(c).Value, "")
                        celda.Style.Border.BorderAround(ExcelBorderStyle.Thin)
                        celda.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left
                    Next
                End If
            Next

            hoja.Cells.AutoFitColumns(15)
            File.WriteAllBytes(ruta, excel.GetAsByteArray())
        End Using

        MessageBox.Show("Excel exportado correctamente.")
    End Sub

    ' ============================================================
    '   EXPORTAR A WORD (.docx)
    ' ============================================================
    Public Shared Sub ExportarWord(grid As DataGridView)
        Dim nombreArchivoDefecto As String = GenerarNombreArchivo() & ".docx"
        Dim ruta = SeleccionarRuta("Documento Word (*.docx)|*.docx", nombreArchivoDefecto)
        If ruta Is Nothing Then Exit Sub

        Dim doc As DocX = DocX.Create(ruta)
        Dim tabla = doc.AddTable(grid.Rows.Count + 1, grid.Columns.Count)
        tabla.Design = Xceed.Document.NET.TableDesign.MediumList2Accent1

        ' Encabezados
        For c As Integer = 0 To grid.Columns.Count - 1
            tabla.Rows(0).Cells(c).Paragraphs(0).Append(grid.Columns(c).HeaderText).Bold().Alignment = Xceed.Document.NET.Alignment.center
        Next

        ' Filas
        For r As Integer = 0 To grid.Rows.Count - 1
            If Not grid.Rows(r).IsNewRow Then
                For c As Integer = 0 To grid.Columns.Count - 1
                    tabla.Rows(r + 1).Cells(c).Paragraphs(0).Append(
                        If(grid.Rows(r).Cells(c).Value, "").ToString()
                    ).Alignment = Xceed.Document.NET.Alignment.left
                Next
            End If
        Next

        doc.InsertTable(tabla)
        doc.Save()
        MessageBox.Show("Word exportado correctamente.")
    End Sub
    ' ============================================================
    '   EXPORTAR → PDF (Profesional, estilo limpio)
    ' ============================================================

    Public Shared Sub ExportarPDF(grid As DataGridView)
        Dim nombreArchivoDefecto As String = GenerarNombreArchivo() & ".pdf"
        Dim ruta = SeleccionarRuta("Archivo PDF (*.pdf)|*.pdf", nombreArchivoDefecto)
        If ruta Is Nothing Then Exit Sub

        Dim printDoc As New PrintDocument()

        AddHandler printDoc.PrintPage,
        Sub(sender As Object, e As PrintPageEventArgs)
            Dim g As SD.Graphics = e.Graphics
            Dim tituloFont As New SD.Font("Segoe UI", 16, SD.FontStyle.Bold)
            Dim subtituloFont As New SD.Font("Segoe UI", 10, SD.FontStyle.Italic)
            Dim tablaFont As New SD.Font("Segoe UI", 9)

            Dim margenIzq As Integer = e.MarginBounds.Left
            Dim margenSup As Integer = e.MarginBounds.Top
            Dim y As Integer = margenSup

            ' Título
            g.DrawString("Reporte de Préstamos de la Biblioteca", tituloFont, SD.Brushes.Black, margenIzq, y)
            y += 35

            ' Subtítulo (fecha)
            g.DrawString("Fecha: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"), subtituloFont, SD.Brushes.Black, margenIzq, y)
            y += 30

            Dim lapiz As New SD.Pen(SD.Color.Black, 1)

            If grid.Columns.Count = 0 Then
                g.DrawString("No hay datos para mostrar.", tablaFont, SD.Brushes.Black, margenIzq, y)
                Return
            End If

            ' Calcular ancho de columnas
            Dim anchoPagina As Integer = e.MarginBounds.Width
            Dim anchoCol As Integer = Math.Max(60, anchoPagina \ grid.Columns.Count)

            Dim x As Integer = margenIzq

            ' Encabezados
            For Each col As DataGridViewColumn In grid.Columns
                g.DrawRectangle(lapiz, x, y, anchoCol, 28)
                g.FillRectangle(SD.Brushes.LightGray, x + 1, y + 1, anchoCol - 1, 26)
                g.DrawString(col.HeaderText, tablaFont, SD.Brushes.Black,
                             New SD.RectangleF(x + 4, y + 4, anchoCol - 8, 20))
                x += anchoCol
            Next
            y += 28

            ' Filas
            For i As Integer = 0 To grid.Rows.Count - 1
                Dim fila As DataGridViewRow = grid.Rows(i)
                If fila.IsNewRow Then Continue For

                Dim altFila As Integer = 24

                ' Calcular altura dinámica
                For Each celda As DataGridViewCell In fila.Cells
                    If celda.Value IsNot Nothing Then
                        Dim size As SD.SizeF = g.MeasureString(celda.Value.ToString(), tablaFont, anchoCol)
                        If size.Height + 6 > altFila Then altFila = CInt(size.Height) + 6
                    End If
                Next

                x = margenIzq

                ' Dibujar celdas
                For Each celda As DataGridViewCell In fila.Cells
                    g.DrawRectangle(lapiz, x, y, anchoCol, altFila)
                    ' Fondo alternado
                    If i Mod 2 = 0 Then
                        g.FillRectangle(SD.Brushes.White, x + 1, y + 1, anchoCol - 1, altFila - 1)
                    Else
                        g.FillRectangle(SD.Brushes.LightYellow, x + 1, y + 1, anchoCol - 1, altFila - 1)
                    End If
                    g.DrawString(If(celda.Value IsNot Nothing, celda.Value.ToString(), ""),
                                 tablaFont, SD.Brushes.Black,
                                 New SD.RectangleF(x + 4, y + 2, anchoCol - 8, altFila - 4))
                    x += anchoCol
                Next
                y += altFila
            Next
        End Sub

        ' Configuración de impresión
        With printDoc.PrinterSettings
            .PrinterName = "Microsoft Print to PDF"
            .PrintToFile = True
            .PrintFileName = ruta
        End With

        printDoc.PrintController = New StandardPrintController()
        printDoc.Print()

        MessageBox.Show("PDF exportado correctamente.")
    End Sub


End Class
