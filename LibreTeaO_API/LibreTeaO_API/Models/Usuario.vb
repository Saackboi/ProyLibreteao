' Modelo para MOSTRAR en la tabla (Sin contraseña)
Public Class UsuarioVista
    Public Property IdUsuario As Integer
    Public Property Nombre As String
    Public Property Correo As String
    Public Property TipoUsuario As String
End Class

' Modelo para INSERTAR (Con contraseña)
Public Class UsuarioInput
    Public Property Nombre As String
    Public Property Correo As String
    Public Property Contrasena As String
    Public Property TipoUsuario As String ' 'cliente' o 'bibliotecario'
End Class

' Modelo para LOGIN
Public Class LoginInput
    Public Property Correo As String
    Public Property Contrasena As String
End Class