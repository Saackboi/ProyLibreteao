Public Class PerfilUsuario

    Private _tituloLibro As String
    Private _autorLibro As String

    ' ===========================
    ' Constructor que recibe libro
    ' ===========================
    Public Sub New(titulo As String, autor As String)
        InitializeComponent()
        _tituloLibro = titulo
        _autorLibro = autor
    End Sub

    Private Sub PerfilUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Asignar datos del libro a controles

        Label3.Text = _tituloLibro
        Label4.Text = _autorLibro
    End Sub

End Class
