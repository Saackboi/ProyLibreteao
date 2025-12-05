
Public Class Usuario
    Public Property IdUsuario As Integer
    Public Property Nombre As String
    Public Property Correo As String
    Public Property TipoUsuario As String
End Class

Public Class UsuarioInput
    Public Property Nombre As String
    Public Property Correo As String
    Public Property Contrasena As String
    Public Property TipoUsuario As String ' "cliente" o "bibliotecario"
End Class