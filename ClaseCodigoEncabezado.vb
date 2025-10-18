Namespace ProyLibreteao
    Public Class ClaseCodigoEncabezado
        Private ReadOnly _lblTitulo As Label
        Private ReadOnly _picture As PictureBox

        Public Sub New(lbl As Label, pic As PictureBox)
            _lblTitulo = lbl
            _picture = pic
        End Sub

        Public Sub Actualizar(titulo As String, imagen As Image)
            _lblTitulo.Text = titulo
            _picture.Image = imagen
        End Sub
    End Class
End Namespace

