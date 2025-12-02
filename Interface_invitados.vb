Public Class Interface_invitados
    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub



    Private Sub pnlIzquierdo_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Interface_invitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Interface_invitados_Resize(sender As Object, e As EventArgs) Handles Me.Resize



    End Sub

    Private Sub plLibro_Paint(sender As Object, e As PaintEventArgs) Handles plLibro.Paint
        Dim colorBorde As Color = Color.Black ' Borde negro
        Dim grosor As Integer = 2            ' Grosor del borde
        Dim rect As New Rectangle(0, 0, plLibro.Width - 1, plLibro.Height - 1)

        Using pen As New Pen(colorBorde, grosor)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        NuevoUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnVerlibro_Click(sender As Object, e As EventArgs) Handles btnVerlibro.Click
        verlibro.Show()
        Me.Hide()
    End Sub
End Class

