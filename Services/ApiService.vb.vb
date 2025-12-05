Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json
Imports System.Text
Imports System.Configuration

Public Class ApiService

    Private Shared ReadOnly client As HttpClient

    ' Constructor Estático: Se ejecuta una sola vez al iniciar la app
    Shared Sub New()
        ' 1. Configuración para ignorar errores de certificado SSL (Vital para Localhost)
        Dim handler As New HttpClientHandler()
        handler.ServerCertificateCustomValidationCallback = Function(message, cert, chain, errors) True

        ' 2. Inicializar cliente
        client = New HttpClient(handler)

        client.BaseAddress = New Uri(ConfigurationManager.AppSettings("ApiBaseUrl") & "libros")

        client.DefaultRequestHeaders.Accept.Clear()
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
    End Sub

    ' =================================================================================
    ' MÉTODO POST (Para Login, Guardar, Actualizar)
    ' =================================================================================
    Public Shared Async Function PostAsync(Of T)(endpoint As String, data As Object) As Task(Of T)
        Try
            Dim json As String = JsonConvert.SerializeObject(data)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            ' Hacemos la llamada (endpoint ej: "usuarios/login")
            Dim response = Await client.PostAsync(endpoint, content)

            ' Manejo de errores específicos (Ej: 400 Bad Request o 401 Unauthorized)
            If Not response.IsSuccessStatusCode Then
                ' Leemos el mensaje que mandó la API (Ej: "Correo duplicado" o "Clave mal")
                Dim errorMsg = Await response.Content.ReadAsStringAsync()

                ' Limpiamos el mensaje si viene en formato JSON complejo
                If String.IsNullOrEmpty(errorMsg) Then errorMsg = response.ReasonPhrase

                Throw New Exception(errorMsg)
            End If

            ' Si todo salió bien, deserializamos la respuesta
            Dim resultJson = Await response.Content.ReadAsStringAsync()
            Return JsonConvert.DeserializeObject(Of T)(resultJson)

        Catch ex As Exception
            Throw ' Re-lanzamos para que el Formulario muestre el MessageBox
        End Try
    End Function

    ' =================================================================================
    ' MÉTODO GET (Para Listas, Reportes, Cargar Datos)
    ' =================================================================================
    Public Shared Async Function GetAsync(Of T)(endpoint As String) As Task(Of T)
        Try
            Dim response = Await client.GetAsync(endpoint)

            If Not response.IsSuccessStatusCode Then
                Throw New Exception("Error al obtener datos: " & response.StatusCode.ToString())
            End If

            Dim resultJson = Await response.Content.ReadAsStringAsync()
            Return JsonConvert.DeserializeObject(Of T)(resultJson)

        Catch ex As Exception

            Throw
        End Try
    End Function

    ' =================================================================================
    ' MÉTODO DELETE (Para Eliminar)
    ' =================================================================================
    Public Shared Async Function DeleteAsync(endpoint As String) As Task(Of Boolean)
        Try
            Dim response = Await client.DeleteAsync(endpoint)

            If Not response.IsSuccessStatusCode Then
                Dim errorMsg = Await response.Content.ReadAsStringAsync()
                Throw New Exception(errorMsg)
            End If

            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class