Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Configuration

Public Class ClasePrestamos

    Private ReadOnly dgv As DataGridView

    ' URL base definida en App.config → debe terminar en /api/
    Private ReadOnly BaseUrl As String = ConfigurationManager.AppSettings("ApiBaseUrl") & "prestamos"

    Private Shared client As HttpClient = CrearClienteInseguro()

    Private Shared Function CrearClienteInseguro() As HttpClient
        Dim handler As New HttpClientHandler With {
            .ServerCertificateCustomValidationCallback =
                Function(message, cert, chain, errors) True
        }
        Return New HttpClient(handler)
    End Function

    Public Sub New(dgvPrestamos As DataGridView)
        Me.dgv = dgvPrestamos
    End Sub

    ' ===================================================
    '   CARGAR PRÉSTAMOS DESDE LA API Y MOSTRARLOS
    ' ===================================================
    Public Async Function CargarPrestamos() As Task
        Try
            Dim json As String = Await client.GetStringAsync(BaseUrl)

            Dim lista = JsonConvert.DeserializeObject(Of List(Of PrestamoVista))(json)
            If lista Is Nothing Then Return

            dgv.Columns.Clear()
            dgv.Rows.Clear()

            ' COLUMNAS
            dgv.Columns.Add("Usuario", "Usuario")
            dgv.Columns.Add("Libro", "Libro")
            dgv.Columns.Add("FechaPrestamo", "Fecha Préstamo")
            dgv.Columns.Add("FechaDevolucion", "Fecha Devolución")
            dgv.Columns.Add("Estado", "Estado")

            ' COLUMNA OCULTA (ID)
            dgv.Columns.Add("IdPrestamo", "IdPrestamo")
            dgv.Columns("IdPrestamo").Visible = False

            ' FILAS
            For Each p In lista
                Dim rowIndex = dgv.Rows.Add(
                    p.NombreUsuario,
                    p.TituloLibro,
                    p.FechaPrestamo,
                    p.FechaDevolucion,
                    p.Estado,
                    p.IdPrestamo           ' <<--- ID OCULTO
                )

                Dim row = dgv.Rows(rowIndex)

                ' ===============================
                '   COLOREAR ESTADO
                ' ===============================
                Select Case p.Estado.ToLower()
                    Case "devuelto"
                        row.Cells("Estado").Style.ForeColor = Color.DarkGreen

                    Case "activo"
                        row.Cells("Estado").Style.ForeColor = Color.DarkRed
                End Select

                row.Cells("Estado").Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            Next

            dgv.Refresh()

        Catch ex As Exception
            MessageBox.Show("Error al cargar los préstamos desde la API: " & ex.Message)
        End Try
    End Function

    ' ===================================================
    '   CREAR NUEVO PRÉSTAMO (POST)
    ' ===================================================
    Public Async Function CrearPrestamo(idUsuario As Integer, idLibro As Integer) As Task(Of Boolean)
        Try
            Dim nuevo As New PrestamoInput With {
                .IdUsuario = idUsuario,
                .IdLibro = idLibro
            }

            Dim json As String = JsonConvert.SerializeObject(nuevo)
            Dim contenido = New StringContent(json, Text.Encoding.UTF8, "application/json")

            Dim resp = Await client.PostAsync(BaseUrl, contenido)

            If resp.IsSuccessStatusCode Then
                Return True
            Else
                MessageBox.Show("Error al crear préstamo: " & resp.ReasonPhrase)
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al crear préstamo: " & ex.Message)
            Return False
        End Try
    End Function

    ' ===================================================
    '   MARCAR COMO DEVUELTO (PUT)
    ' ===================================================
    Public Async Function MarcarDevuelto(idPrestamo As Integer) As Task(Of Boolean)
        Try
            Dim url As String = $"{BaseUrl}/devolver/{idPrestamo}"

            Dim resp = Await client.PutAsync(url, Nothing)

            If resp.IsSuccessStatusCode Then
                Return True
            Else
                MessageBox.Show("Error al devolver libro: " & resp.ReasonPhrase)
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al devolver libro: " & ex.Message)
            Return False
        End Try
    End Function

    ' ===================================================
    '   MODELOS
    ' ===================================================

    Public Class PrestamoVista
        Public Property IdPrestamo As Integer
        Public Property NombreUsuario As String
        Public Property TituloLibro As String
        Public Property FechaPrestamo As String
        Public Property FechaDevolucion As String
        Public Property Estado As String
    End Class

    Public Class PrestamoInput
        Public Property IdUsuario As Integer
        Public Property IdLibro As Integer
    End Class

End Class
