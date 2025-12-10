Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Imports Xceed.Words.NET

Public Class Exportador

    ' ============================================================
    '   FUNCIÓN AUXILIAR PARA GENERAR EL NOMBRE DE ARCHIVO
    ' ============================================================
    Private Shared Function GenerarNombreArchivo() As String
        ' Formatea la fecha y hora actual: "yyyy-MM-dd HH-mm-ss"
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
    '   EXPORTAR A EXCEL (.xlsx) — EPPlus 7/8
    ' ============================================================

    Public Shared Sub ExportarExcel(grid As DataGridView)

        ' Usa el nombre de archivo generado dinámicamente
        Dim nombreArchivoDefecto As String = GenerarNombreArchivo() & ".xlsx"
        Dim ruta = SeleccionarRuta("Excel (*.xlsx)|*.xlsx", nombreArchivoDefecto)
        If ruta Is Nothing Then Exit Sub

        ' EPPlus — Licencia requerida para versión 8+
        ExcelPackage.License.SetNonCommercialOrganization("LIBRETEAO")

        Using excel As New ExcelPackage()
            Dim hoja = excel.Workbook.Worksheets.Add("Reporte")

            ' ... [rest of the Excel logic remains the same] ...
            ' Encabezados
            For c As Integer = 0 To grid.Columns.Count - 1
                hoja.Cells(1, c + 1).Value = grid.Columns(c).HeaderText
                hoja.Cells(1, c + 1).Style.Font.Bold = True
                hoja.Cells(1, c + 1).Style.Fill.PatternType = ExcelFillStyle.Solid
                hoja.Cells(1, c + 1).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
            Next

            ' Filas
            For r As Integer = 0 To grid.Rows.Count - 1
                If Not grid.Rows(r).IsNewRow Then
                    For c As Integer = 0 To grid.Columns.Count - 1
                        hoja.Cells(r + 2, c + 1).Value = If(grid.Rows(r).Cells(c).Value, "")
                    Next
                End If
            Next

            hoja.Cells.AutoFitColumns()
            File.WriteAllBytes(ruta, excel.GetAsByteArray())
        End Using

        MessageBox.Show("Excel exportado correctamente.")
    End Sub

    ' ============================================================
    '   EXPORTAR A WORD (.docx) — DocX
    ' ============================================================
    Public Shared Sub ExportarWord(grid As DataGridView)

        ' Usa el nombre de archivo generado dinámicamente
        Dim nombreArchivoDefecto As String = GenerarNombreArchivo() & ".docx"
        Dim ruta = SeleccionarRuta("Documento Word (*.docx)|*.docx", nombreArchivoDefecto)
        If ruta Is Nothing Then Exit Sub

        Dim doc As DocX = DocX.Create(ruta)

        ' ... [rest of the Word logic remains the same] ...
        Dim tabla = doc.AddTable(grid.Rows.Count + 1, grid.Columns.Count)
        tabla.Design = Xceed.Document.NET.TableDesign.ColorfulList

        ' Encabezados
        For c As Integer = 0 To grid.Columns.Count - 1
            tabla.Rows(0).Cells(c).Paragraphs(0).Append(grid.Columns(c).HeaderText).Bold()
        Next

        ' Filas
        For r As Integer = 0 To grid.Rows.Count - 1
            If Not grid.Rows(r).IsNewRow Then
                For c As Integer = 0 To grid.Columns.Count - 1
                    tabla.Rows(r + 1).Cells(c).Paragraphs(0).Append(
                        If(grid.Rows(r).Cells(c).Value, "").ToString()
                    )
                Next
            End If
        Next

        doc.InsertTable(tabla)
        doc.Save()

        MessageBox.Show("Word exportado correctamente.")
    End Sub

    ' ============================================================
    '   EXPORTAR A PDF — PrintDocument
    ' ============================================================
    Public Shared Sub ExportarPDF(grid As DataGridView)

        ' Usa el nombre de archivo generado dinámicamente
        Dim nombreArchivoDefecto As String = GenerarNombreArchivo() & ".pdf"
        Dim ruta = SeleccionarRuta("Archivo PDF (*.pdf)|*.pdf", nombreArchivoDefecto)
        If ruta Is Nothing Then Exit Sub
        ' NOTA: La función SeleccionarRuta ya maneja la cancelación sin mostrar MessageBox.

        Dim printDoc As New PrintDocument()

        AddHandler printDoc.PrintPage,
            Sub(sender As Object, e As PrintPageEventArgs)
                ' ... [rest of the PDF logic remains the same] ...
                Dim g As Graphics = e.Graphics
                Dim fuente As New Font("Segoe UI", 10)
                Dim y As Integer = 40
                Dim x As Integer = 40

                g.DrawString("Reporte Exportado",
                             New Font("Segoe UI", 14, FontStyle.Bold),
                             Brushes.Black, x, y)

                y += 40

                ' Encabezados
                For Each col As DataGridViewColumn In grid.Columns
                    g.DrawString(col.HeaderText, fuente, Brushes.Black, x, y)
                    x += 150
                Next

                y += 25
                x = 40

                ' Filas
                For Each fila As DataGridViewRow In grid.Rows
                    If Not fila.IsNewRow Then
                        For Each celda As DataGridViewCell In fila.Cells
                            g.DrawString(
                                If(celda.Value Is Nothing, "", celda.Value.ToString()),
                                fuente, Brushes.Black, x, y
                            )
                            x += 150
                        Next
                        y += 20
                        x = 40
                    End If
                Next

            End Sub

        With printDoc.PrinterSettings
            .PrinterName = "Microsoft Print to PDF"
            .PrintToFile = True
            .PrintFileName = ruta
        End With

        ' AÑADE ESTA LÍNEA para suprimir el diálogo de impresión de Windows/Progreso
        printDoc.PrintController = New System.Drawing.Printing.StandardPrintController()

        ' Imprime el documento usando la configuración establecida
        printDoc.Print()

        ' Este es el único aviso final que se mostrará.
        MessageBox.Show("PDF exportado correctamente.")
    End Sub

End Class


