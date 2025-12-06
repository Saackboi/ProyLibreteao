Imports System.Drawing.Drawing2D

Public Class Inicio

    ' Instancia del gestor de contenido
    Private gestor As ClaseContenidoInicio

    ' Variable para guardar quién entró (puedes pasarla desde el Login)
    Public NombreUsuarioLogueado As String = "Bibliotecario"

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Estilizado Visual (Bordes Redondeados)
        RedondearBordes(pnlCardLibros)
        RedondearBordes(pnlCardUsuarios)
        RedondearBordes(pnlCardPrestamos)
        RedondearBordes(pnlCardMorosos)

        ' 2. Inicializar Gestor
        ' Asegúrate de pasar los Labels reales que creaste en el diseño
        gestor = New ClaseContenidoInicio(lblBienvenida, lblFecha, lblNumLibros, lblNumUsuarios, lblNumPrestamos, lblNumMorosos)

        ' 3. Cargar Datos
        gestor.CargarDashboard(NombreUsuarioLogueado)
    End Sub

    Private Sub RedondearBordes(pnl As Panel)
        Dim radio As Integer = 20
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
        path.AddLine(radio, 0, pnl.Width - radio, 0)
        path.AddArc(New Rectangle(pnl.Width - radio, 0, radio, radio), 270, 90)
        path.AddLine(pnl.Width, radio, pnl.Width, pnl.Height - radio)
        path.AddArc(New Rectangle(pnl.Width - radio, pnl.Height - radio, radio, radio), 0, 90)
        path.AddLine(pnl.Width - radio, pnl.Height, radio, pnl.Height)
        path.AddArc(New Rectangle(0, pnl.Height - radio, radio, radio), 90, 90)
        path.CloseFigure()
        pnl.Region = New Region(path)
    End Sub

    ' =================================================
    ' BOTONES DE ACCESO RÁPIDO
    ' =================================================
    Private Sub btnIrPrestamo_Click(sender As Object, e As EventArgs) Handles btnIrPrestamo.Click
        Interface_Administrador.CambiarSeccion("INICIO", My.Resources.iconoInicio)
    End Sub

    Private Sub btnIrDevolucion_Click(sender As Object, e As EventArgs) Handles btnIrDevolucion.Click
        Interface_Administrador.CambiarSeccion("INICIO", My.Resources.iconoInicio)
    End Sub

    Private Sub btnIrCatalogo_Click(sender As Object, e As EventArgs) Handles btnIrCatalogo.Click
        Interface_Administrador.CambiarSeccion("LIBROS", My.Resources.iconoLibros)
    End Sub

End Class