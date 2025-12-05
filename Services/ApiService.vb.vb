Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class ApiService
    Private Shared ReadOnly client As HttpClient

    Shared Sub New()
        client = New HttpClient()
        client.BaseAddress = New Uri("https://localhost:44385/api/")
        client.DefaultRequestHeaders.Accept.Clear()
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
    End Sub


    Public Shared Async Function PostAsync(Of T)(url As String, data As Object) As Task(Of T)

        Dim json = Newtonsoft.Json.JsonConvert.SerializeObject(data)
        Dim content = New StringContent(json, Text.Encoding.UTF8, "application/json")

        ' Usa el cliente compartido
        Dim response = Await client.PostAsync(url, content)

        If Not response.IsSuccessStatusCode Then
            ' Si el código de estado es 400 (BadRequest de tu API) o 401 (Unauthorized)
            If response.StatusCode = Net.HttpStatusCode.BadRequest OrElse response.StatusCode = Net.HttpStatusCode.Unauthorized Then
                Dim errorMessage = Await response.Content.ReadAsStringAsync()
                Throw New Exception(errorMessage) ' Lanza el error para que Login.vb lo capture
            Else
                Throw New Exception("Error en el servidor: " & response.StatusCode.ToString())
            End If
        End If

        Dim resultJson = Await response.Content.ReadAsStringAsync()
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of T)(resultJson)

    End Function


    Public Shared Async Function GetAsync(Of T)(url As String) As Task(Of T)
        Dim response = Await client.GetAsync(url)

        If Not response.IsSuccessStatusCode Then
            Throw New Exception("Error: " & response.StatusCode.ToString())
        End If

        Dim resultJson = Await response.Content.ReadAsStringAsync()
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of T)(resultJson)
    End Function
End Class