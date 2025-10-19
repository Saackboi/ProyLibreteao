Imports ProyLibreteao.ProyLibreteao

Public Class FormPrincipal
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmInicio As New FormInicio()
        frmInicio.Show()
        Me.Hide()
    End Sub
End Class
