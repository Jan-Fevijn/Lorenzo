Public Class gerecht
    Private _idGerecht As String
    Private _naam As String



    Public Property IdGerecht() As String
        Get
            Return _idGerecht
        End Get
        Set(ByVal value As String)
            _idGerecht = value
        End Set
    End Property


    Public Property Naam() As String
        Get
            Return _naam
        End Get
        Set(ByVal value As String)
            _naam = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Naam
    End Function
End Class
