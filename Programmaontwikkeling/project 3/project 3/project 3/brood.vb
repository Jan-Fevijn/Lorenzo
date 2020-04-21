Public Class brood
    Private _idbrood As Integer
    Private _naam As String


    Public Property Idbrood() As Integer
        Get
            Return _idbrood
        End Get
        Set(ByVal value As Integer)
            _idbrood = value
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



End Class


