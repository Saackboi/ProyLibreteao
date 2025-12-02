Public Class perfilninos
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub perfilninos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub perfilninos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        interfacesninos.Show()
        Me.Hide()

    End Sub

    Private Sub btnCatalogo_Click(sender As Object, e As EventArgs) Handles btnCatalogo.Click
        interfacesninos.Show()
        Me.Hide()

    End Sub
End Class