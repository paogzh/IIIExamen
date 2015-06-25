Public Class Usuario
    Public nombre As String
    Public contrasenna As String


    Public Property nom() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property


    Public Property contra() As String
        Get
            Return contrasenna
        End Get
        Set(ByVal value As String)
            contrasenna = value
        End Set
    End Property


 
End Class
