Namespace ProyLibreteao
    Public Class ClaseDiseño

        Private ReadOnly tabControl As TabControl
        Private ReadOnly lblTituloTab As Label


        ' Índice del tab sobre el que está el mouse
        Private hoveredIndex As Integer = -1


        Public Sub New(tab As TabControl, lblTitulo As Label)

            tabControl = tab
            lblTituloTab = lblTitulo


            ' Configurar TabControl
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed
            tabControl.BackColor = Color.White
            tabControl.ItemSize = New Size(130, 35)
            tabControl.SizeMode = TabSizeMode.Fixed

            ' 🔹 Asignar manejadores de eventos
            AddHandler tabControl.DrawItem, AddressOf TabControl_DrawItem
            AddHandler tabControl.MouseMove, AddressOf TabControl_MouseMove
            AddHandler tabControl.MouseLeave, AddressOf TabControl_MouseLeave
            AddHandler tabControl.SelectedIndexChanged, AddressOf TabControl_SelectedIndexChanged
        End Sub


        '============================
        '  Diseño del TabControl
        '============================
        Private Sub TabControl_DrawItem(sender As Object, e As DrawItemEventArgs)
            Dim g As Graphics = e.Graphics
            Dim tab As TabPage = tabControl.TabPages(e.Index)
            Dim rect As Rectangle = e.Bounds

            ' Colores del tema
            Dim colorLavanda As Color = Color.FromArgb(230, 230, 250)
            Dim colorSubrayado As Color = Color.FromArgb(180, 160, 230)
            Dim colorTextoNormal As Color = Color.Black
            Dim colorTextoActivo As Color = Color.FromArgb(50, 40, 120)

            ' Estado del tab
            Dim isSelected As Boolean = (e.Index = tabControl.SelectedIndex)
            Dim isHovered As Boolean = (e.Index = hoveredIndex)

            ' 🔹 Fondo: lavanda si hover o seleccionado, blanco si no
            Dim fondo As Color = If(isSelected, colorLavanda, Color.White)
            g.FillRectangle(New SolidBrush(fondo), rect)

            ' 🔹 Texto centrado
            Dim sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            Dim colorTexto As Color = If(isSelected OrElse isHovered, colorTextoActivo, colorTextoNormal)
            g.DrawString(tab.Text, tabControl.Font, New SolidBrush(colorTexto), rect, sf)

            ' 🔹 Subrayado si está seleccionado o en hover
            If isSelected OrElse isHovered Then
                g.FillRectangle(New SolidBrush(colorSubrayado),
                                rect.X + 10,
                                rect.Bottom - 2,
                                rect.Width - 20,
                                3)
            End If
        End Sub


        '============================
        ' Detectar hover
        '============================
        Private Sub TabControl_MouseMove(sender As Object, e As MouseEventArgs)
            For i As Integer = 0 To tabControl.TabPages.Count - 1
                If tabControl.GetTabRect(i).Contains(e.Location) Then
                    If hoveredIndex <> i Then
                        hoveredIndex = i
                        tabControl.Invalidate()
                    End If
                    Exit Sub
                End If
            Next
            ' Si el cursor no está sobre ningún tab
            If hoveredIndex <> -1 Then
                hoveredIndex = -1
                tabControl.Invalidate()
            End If
        End Sub


        '============================
        ' Quitar hover al salir
        '============================
        Private Sub TabControl_MouseLeave(sender As Object, e As EventArgs)
            hoveredIndex = -1
            tabControl.Invalidate()
        End Sub


        '============================
        ' Cambiar título al cambiar de pestaña
        '============================
        Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs)
            lblTituloTab.Text = tabControl.SelectedTab.Text
        End Sub


    End Class
End Namespace
