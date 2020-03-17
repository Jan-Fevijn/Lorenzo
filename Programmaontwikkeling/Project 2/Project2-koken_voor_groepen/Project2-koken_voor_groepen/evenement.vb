Public Class evenement
    Private _idevenement As String
    Private _naam As String
    Private _aantalDagen As String
    Private _aantalPersonen As String


    Public Property IdEvenement() As String
        Get
            Return IdEvenement
        End Get
        Set(ByVal value As String)
            IdEvenement = value
        End Set
    End Property


    Public Property Naam() As String
        Get
            Return Naam
        End Get
        Set(ByVal value As String)
            Naam = value
        End Set
    End Property


    Public Property AantalDagen() As String
        Get
            Return _aantalDagen
        End Get
        Set(ByVal value As String)
            _aantalDagen = value
        End Set
    End Property

    Public Property AantalPersonen() As String
        Get
            Return _aantalPersonen
        End Get
        Set(ByVal value As String)
            _aantalPersonen = value
        End Set
    End Property
End Class
