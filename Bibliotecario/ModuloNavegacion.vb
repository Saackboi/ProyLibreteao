Module ModNavegacion

    ' Muestra un formulario dentro de un panel y limpia los anteriores
    Public Sub MostrarFormulario(panel As Panel, f As Form)
        panel.Controls.Clear()

        f.TopLevel = False
        f.FormBorderStyle = FormBorderStyle.None
        f.Dock = DockStyle.Fill

        panel.Controls.Add(f)
        f.Show()
    End Sub

    ' Mostrar mensaje neutro en el panel
    Public Sub MostrarMensaje(panel As Panel, texto As String)
        panel.Controls.Clear()
        panel.Controls.Add(New Label With {
            .Text = texto,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10, FontStyle.Italic),
            .ForeColor = Color.Gray,
            .TextAlign = ContentAlignment.MiddleCenter})
    End Sub

End Module

