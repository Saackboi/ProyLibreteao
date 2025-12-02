Public Class interfacesninos
    Private Sub pnlSuperior_Paint(sender As Object, e As PaintEventArgs) Handles pnlSuperior.Paint

    End Sub

    Private Sub flowLibros_Paint(sender As Object, e As PaintEventArgs) Handles flowLibros.Paint

    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        perfilninos.Show()
        Me.Hide()

    End Sub

    Private Sub btnCatalogo_Click(sender As Object, e As EventArgs) Handles btnCatalogo.Click

    End Sub

    Private Sub btnJuegos_Click(sender As Object, e As EventArgs) Handles btnJuegos.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub interfacesninos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Permite que el contenido se reorganice automáticamente cuando cambie el tamaño de la ventana
        flowLibros.WrapContents = True
        flowLibros.AutoScroll = True
        flowLibros.Dock = DockStyle.Fill
        flowLibros.Padding = New Padding(20)
        MostrarCatalogo()
    End Sub

    Private Sub MostrarCatalogo()
        Dim libros As (String, Image)() = {
            ("El Principito", My.Resources.Principito),
            ("Alicia en el País de las Maravillas", My.Resources.alis),
            ("Pinocho", My.Resources.pinochoi)
        }

        flowLibros.Controls.Clear()

        For Each libro In libros
            Dim panelLibro As New Panel With {
                .Width = CInt(flowLibros.Width * 0.25), ' ancho relativo al contenedor
                .Height = CInt(flowLibros.Height * 0.4),
                .Margin = New Padding(15),
                .BackColor = Color.White
            }

            Dim pic As New PictureBox With {
                .Image = libro.Item2,
                .Width = panelLibro.Width - 20,
                .Height = CInt(panelLibro.Height * 0.7),
                .SizeMode = PictureBoxSizeMode.Zoom,
                .Top = 5,
                .Left = 10,
                .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right,
                .Cursor = Cursors.Hand
            }

            Dim lbl As New Label With {
                .Text = libro.Item1,
                .Font = New Font("Comic Sans MS", 10, FontStyle.Bold),
                .ForeColor = Color.FromArgb(0, 120, 255),
                .Width = panelLibro.Width,
                .Height = 40,
                .Top = panelLibro.Height - 45,
                .Left = 0,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            }

            ' Efectos al pasar el ratón
            AddHandler pic.MouseEnter, Sub() panelLibro.BackColor = Color.FromArgb(255, 255, 200)
            AddHandler pic.MouseLeave, Sub() panelLibro.BackColor = Color.White

            ' Acción al hacer clic en la imagen
            AddHandler pic.Click, Sub()
                                      leerninos.Show()
                                      Me.Hide()

                                  End Sub

            panelLibro.Controls.Add(pic)
            panelLibro.Controls.Add(lbl)
            flowLibros.Controls.Add(panelLibro)
        Next
    End Sub

    ' Redibuja el contenido cuando el usuario cambia el tamaño de la ventana
    Private Sub interfacesninos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        MostrarCatalogo()
    End Sub




End Class

