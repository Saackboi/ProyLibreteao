Public Class UCHeader
    Inherits UserControl
    Public Sub ActualizarEncabezado(ByVal nuevaImagen As Image, ByVal nuevoTexto As String)
        PictureBox2.Image = nuevaImagen
        lblTituloEncabezadoMenu.Text = nuevoTexto
    End Sub

    Private Sub lblTituloEncabezado_Click(sender As Object, e As EventArgs) Handles lblTituloEncabezado.Click

    End Sub
End Class
