Public Class verlibro
    Private Sub verlibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdjustLayout()
    End Sub

    Private Sub verlibro_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AdjustLayout()
    End Sub

    Private Sub AdjustLayout()
        If Me.IsHandleCreated = False Then Return

        Dim cw As Integer = Me.ClientSize.Width
        Dim ch As Integer = Me.ClientSize.Height
        Dim margin As Integer = 12

        ' Barra superior (ya con Dock = Top)
        If pnlMenuSuperior IsNot Nothing Then
            Dim topH As Integer = pnlMenuSuperior.Height

            If picLogo IsNot Nothing Then
                picLogo.Location = New Point(margin, (topH - picLogo.Height) \ 2)
            End If

            If picUsuario IsNot Nothing Then
                picUsuario.Location = New Point(Math.Max(margin, cw - picUsuario.Width - margin), (topH - picUsuario.Height) \ 2)
            End If

            If btnBuscar IsNot Nothing Then
                btnBuscar.Location = New Point(Math.Max(margin, cw - btnBuscar.Width - picUsuario.Width - margin * 3), (topH - btnBuscar.Height) \ 2)
            End If

            If txtBuscar IsNot Nothing Then
                Dim leftX As Integer = margin + If(picLogo IsNot Nothing, picLogo.Width, 0) + margin
                Dim rightLimit As Integer = If(btnBuscar IsNot Nothing, btnBuscar.Location.X - margin, cw - margin)
                txtBuscar.Location = New Point(leftX, (topH - txtBuscar.Height) \ 2)
                txtBuscar.Width = Math.Max(100, rightLimit - txtBuscar.Location.X)
            End If
        End If

        ' Área de contenido: columna izquierda (portada) y derecha (detalle)
        Dim contentTop As Integer = If(pnlMenuInferior IsNot Nothing, pnlMenuInferior.Bottom + 16, 70)
        Dim leftXMain As Integer = 20
        Dim leftW As Integer = CInt(Math.Min(Math.Max(180, cw * 0.25), 380)) ' ancho portada: 25% o entre 180 y 380

        If picPortada IsNot Nothing Then
            picPortada.Location = New Point(leftXMain, contentTop)
            picPortada.Size = New Size(leftW, Math.Max(180, CInt(ch * 0.45)))
        End If

        Dim rightX As Integer = leftXMain + leftW + 20
        Dim rightW As Integer = Math.Max(220, cw - rightX - 20)

        If lblTitulo IsNot Nothing Then
            lblTitulo.Location = New Point(rightX, contentTop)
            lblTitulo.Width = rightW
        End If

        If lblAutor IsNot Nothing Then
            lblAutor.Location = New Point(rightX, If(lblTitulo IsNot Nothing, lblTitulo.Bottom + 6, contentTop + 30))
        End If

        If txtDescripcion IsNot Nothing Then
            Dim descTop As Integer = If(lblAutor IsNot Nothing, lblAutor.Bottom + 8, contentTop + 60)
            txtDescripcion.Location = New Point(rightX, descTop)
            txtDescripcion.Width = rightW
            txtDescripcion.Height = Math.Max(80, CInt(ch * 0.18))
        End If

        ' Colocación de ISBN y calificación (evita solapamiento con la portada)
        If lblISBN IsNot Nothing Then
            Dim isbnTop As Integer = If(txtDescripcion IsNot Nothing, txtDescripcion.Bottom + 8, If(lblAutor IsNot Nothing, lblAutor.Bottom + 8, contentTop + 120))
            lblISBN.Location = New Point(rightX, isbnTop)
            lblISBN.Width = Math.Min(220, rightW) ' limitar anchura para que no se solape
        End If

        If lblCalificacion IsNot Nothing Then
            Dim calTop As Integer = If(lblISBN IsNot Nothing, lblISBN.Bottom + 6, If(txtDescripcion IsNot Nothing, txtDescripcion.Bottom + 32, contentTop + 140))
            lblCalificacion.Location = New Point(rightX, calTop)
            lblCalificacion.Width = Math.Min(220, rightW)
        End If

        If btnHacerPedido IsNot Nothing Then
            btnHacerPedido.Location = New Point(rightX + rightW - btnHacerPedido.Width, If(txtDescripcion IsNot Nothing, txtDescripcion.Bottom + 12, contentTop + 160))
        End If

        If lblDisponibles IsNot Nothing Then
            Dim lblLeft As Integer = If(btnHacerPedido IsNot Nothing, Math.Max(rightX, btnHacerPedido.Left - lblDisponibles.Width - 10), rightX)
            lblDisponibles.Location = New Point(lblLeft, If(btnHacerPedido IsNot Nothing, btnHacerPedido.Top + Math.Max(0, (btnHacerPedido.Height - lblDisponibles.Height) \ 2), contentTop + 180))
        End If

        ' Comentarios en la parte inferior, estirando el ancho
        If lstComentarios IsNot Nothing Then
            Dim listH As Integer = Math.Max(80, CInt(ch * 0.18))
            lstComentarios.Size = New Size(Math.Max(200, cw - leftXMain * 2), listH)
            lstComentarios.Location = New Point(leftXMain, ch - listH - 20)
        End If
    End Sub

    Private Sub lblISBN_Click(sender As Object, e As EventArgs) Handles lblISBN.Click

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Interface_invitados.Show()
        Me.Hide()

    End Sub
End Class