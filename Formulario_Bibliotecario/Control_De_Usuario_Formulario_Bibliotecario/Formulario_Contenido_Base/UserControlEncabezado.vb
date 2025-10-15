Public Class UserControlEncabezado

    Public Sub ActualizarEncabezado(ByVal nuevaImagen As Image, ByVal nuevoTexto As String)
        PictureBox2.Image = nuevaImagen
        lblTituloEncabezadoMenu.Text = nuevoTexto
    End Sub


End Class
