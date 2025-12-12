Public Class FormFiltro

    Public Property PeriodoSeleccionado As String = ""
    Private Sub FormFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar todos los RadioButtons dentro del TableLayoutPanel2
        For Each rb As RadioButton In TableLayoutPanel2.Controls.OfType(Of RadioButton)()
            rb.FlatStyle = FlatStyle.Flat
            rb.BackColor = Color.White
            rb.ForeColor = Color.FromArgb(90, 80, 150)
            rb.RightToLeft = RightToLeft.Yes ' texto primero, círculo después

            ' Cambiar borde al estilo moderno
            rb.FlatAppearance.BorderColor = Color.FromArgb(130, 100, 250)
            rb.FlatAppearance.CheckedBackColor = Color.FromArgb(230, 225, 255)

            ' Eventos de color al pasar el mouse
            AddHandler rb.MouseEnter, AddressOf RadioHover
            AddHandler rb.MouseLeave, AddressOf RadioLeave
        Next
    End Sub

    Private Sub RadioHover(sender As Object, e As EventArgs)
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        rb.BackColor = Color.FromArgb(240, 235, 255) ' Fondo lavanda al pasar el mouse
    End Sub

    Private Sub RadioLeave(sender As Object, e As EventArgs)
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        rb.BackColor = Color.White ' Vuelve al color base
    End Sub


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ' Buscar cuál RadioButton está seleccionado
        For Each rb As RadioButton In TableLayoutPanel2.Controls.OfType(Of RadioButton)()
            If rb.Checked Then
                PeriodoSeleccionado = rb.Text   ' ← devuelve el texto del radio
                Exit For
            End If
        Next

        If PeriodoSeleccionado = "" Then
            MessageBox.Show("Debe seleccionar un periodo.")
            Exit Sub
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


End Class