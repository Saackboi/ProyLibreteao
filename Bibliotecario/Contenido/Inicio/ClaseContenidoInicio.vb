Imports System.Configuration
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ClaseContenidoInicio

    ' URL Base de los Reportes (Asegúrate que el puerto coincida con tu API)
    Private ReadOnly BaseUrl As String = ConfigurationManager.AppSettings("ApiBaseUrl") & "reportes"

    ' Cliente HTTP para la clase
    Private Shared client As HttpClient = CrearClienteInseguro()

    ' Controles visuales que vamos a manipular
    Private lblBienvenida As Label
    Private lblFecha As Label

    ' Labels de los números
    Private lblKpiLibros As Label
    Private lblKpiUsuarios As Label
    Private lblKpiPrestamos As Label
    Private lblKpiMorosos As Label

    Public Sub New(lblB As Label, lblF As Label, lblL As Label, lblU As Label, lblP As Label, lblM As Label)
        Me.lblBienvenida = lblB
        Me.lblFecha = lblF
        Me.lblKpiLibros = lblL
        Me.lblKpiUsuarios = lblU
        Me.lblKpiPrestamos = lblP
        Me.lblKpiMorosos = lblM
    End Sub

    Private Shared Function CrearClienteInseguro() As HttpClient
        Dim handler As New HttpClientHandler()
        handler.ServerCertificateCustomValidationCallback = Function(message, cert, chain, errors) True
        Return New HttpClient(handler)
    End Function

    ' =============================
    ' 1. CARGAR TARJETAS (KPIs)
    ' =============================
    Public Async Sub CargarDatosTarjetas()
        If lblKpiUsuarios Is Nothing Then Return

        Try
            ' Llamada al endpoint GET api/reportes/kpis
            Dim json As String = Await client.GetStringAsync(BaseUrl & "/kpis")
            Dim datos = JsonConvert.DeserializeObject(Of DashboardKpis)(json)

            If datos IsNot Nothing Then
                lblKpiUsuarios.Text = datos.TotalUsuarios.ToString()
                lblKpiPrestamos.Text = datos.TotalPrestamos.ToString()
                lblKpiLibros.Text = datos.TotalLibros.ToString()
                lblKpiMorosos.Text = datos.TotalMultasCount.ToString()
            End If

        Catch ex As Exception
            ' En caso de error, ponemos guiones
            lblKpiUsuarios.Text = "-"
            lblKpiMorosos.Text = "-"

        End Try
    End Sub

    Public Async Sub CargarDashboard(nombreUsuario As String)
        ' 1. Configurar Saludo y Fecha
        Dim hora = DateTime.Now.Hour
        Dim saludo As String

        If hora < 12 Then
            saludo = "Buenos días"
        ElseIf hora < 18 Then
            saludo = "Buenas tardes"
        Else
            saludo = "Buenas noches"
        End If

        lblBienvenida.Text = $"{saludo}, {nombreUsuario}."
        lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper()

        ' 2. Traer Datos de la API (Reusamos el endpoint de Reportes)
        Try
            ' GET api/reportes/kpis
            Dim kpis = Await ApiService.GetAsync(Of DashboardKpis)("reportes/kpis")

            If kpis IsNot Nothing Then
                AnimarNumero(lblKpiLibros, kpis.TotalLibros)
                AnimarNumero(lblKpiUsuarios, kpis.TotalUsuarios)
                AnimarNumero(lblKpiPrestamos, kpis.TotalPrestamos)
                AnimarNumero(lblKpiMorosos, kpis.TotalMultasCount)

                ' Colorear rojo si hay morosos
                If kpis.TotalMultasCount > 0 Then
                    lblKpiMorosos.ForeColor = System.Drawing.Color.Crimson
                End If
            End If

        Catch ex As Exception
            lblBienvenida.Text = "Bienvenido (Sin conexión)"
        End Try
    End Sub

    ' Pequeño efecto visual para que los números no aparezcan de golpe
    Private Sub AnimarNumero(lbl As Label, valorFinal As Integer)
        lbl.Text = valorFinal.ToString()
    End Sub

End Class