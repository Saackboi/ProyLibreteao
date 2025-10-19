Imports ProyLibreteao.ProyLibreteao

Public Class FormReporte
    Private formFiltro As New FormFiltro()

    Private codigoContenidoReporte As ClaseReportes
    Public Property FormFiltroReportes As Object

    Private Sub FormReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Inicializar la sección de reportes
        codigoContenidoReporte = New ClaseReportes(dgvTablaInfoReporte,
                                                tlpReporte, tcReportes,
                                                lblTituloTabControl, btnFiltroReporte)
        codigoContenidoReporte.MostrarReportes() '
    End Sub


    Private Sub CambiarSeccion(titulo As String, icono As Image)

        ' Mostrar contenido según la sección
        Select Case titulo.ToUpper()
            Case "REPORTES"
                codigoContenidoReporte.MostrarReportes() '


        End Select
    End Sub

    Private Sub btnFiltroReporte_Click(sender As Object, e As EventArgs) Handles btnFiltroReporte.Click
        formFiltro.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDescarga.Click
        MessageBox.Show("Descargnado reporte...")
    End Sub
End Class
