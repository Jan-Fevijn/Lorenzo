Public Class klant
    Private _idklant As Integer
    Private _naam As String
    Private _voornaam As String
    Private _code As String
    Private _saldo As String


    Public Property Idklant() As Integer
        Get
            Return _idklant
        End Get
        Set(ByVal value As Integer)
            _idklant = value
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



    Public Property Voornaam() As String
        Get
            Return _voornaam
        End Get
        Set(ByVal value As String)
            _voornaam = value
        End Set
    End Property



    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property


    Public Property Saldo() As String
        Get
            Return _saldo
        End Get
        Set(ByVal value As String)
            _saldo = value
        End Set
    End Property
End Class
