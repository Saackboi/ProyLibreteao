Imports System.IO

Public Class LibroCard

    Public Property LibroData As Object  ' Guarda todo el objeto Libro

    ' ==========================
    ' PROPIEDADES PÚBLICAS
    ' ==========================
    Public Property IdLibro As Integer

    Private _tituloLibro As String
    Public Property TituloLibro As String
        Get
            Return _tituloLibro
        End Get
        Set(value As String)
            _tituloLibro = value
            lblTitulo.Text = value
        End Set
    End Property

    Private _autores As String
    Public Property Autores As String
        Get
            Return _autores
        End Get
        Set(value As String)
            _autores = value
            lblAutor.Text = value
        End Set
    End Property

    Public WriteOnly Property ImagenPortada As Image
        Set(value As Image)
            pbxPortada.Image = value
        End Set
    End Property


    ' ==========================
    ' ZOOM HOVER VARIABLES
    ' ==========================
    Private NormalSize As Size = New Size(165, 260)
    Private ZoomSize As Size = New Size(185, 290)
    Private OriginalLocation As Point


    ' ==========================
    ' LOAD DEL CONTROL
    ' ==========================
    Private Sub LibroCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = NormalSize
        Me.Margin = New Padding(12)
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.BackColor = Color.White
    End Sub


    ' ==========================
    ' EFECTO HOVER ZOOM
    ' ==========================
    Private Sub pbxPortada_MouseEnter(sender As Object, e As EventArgs) Handles pbxPortada.MouseEnter
        Me.BackColor = Color.White
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.Padding = New Padding(0, 26, 0, 0)

        ' sombra suave
        Me.ShadowEffect(True)
    End Sub

    Private Sub pbxPortada_MouseLeave(sender As Object, e As EventArgs) Handles pbxPortada.MouseLeave
        Me.Padding = New Padding(0, 35, 0, 0)
        Me.BorderStyle = BorderStyle.FixedSingle

        Me.ShadowEffect(False)
    End Sub

    ' Efecto sombra
    Private Sub ShadowEffect(activar As Boolean)
        If activar Then
            Me.BackColor = Color.FromArgb(240, 240, 240)
        Else
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub LibroCard_Click(sender As Object, e As EventArgs) Handles MyBase.Click, pbxPortada.Click, lblTitulo.Click, lblAutor.Click
        'If LibroData IsNot Nothing Then
        'Dim detalles As New VistaDetalles(LibroData)
        'detalles.Show()
        'End If
    End Sub


End Class

