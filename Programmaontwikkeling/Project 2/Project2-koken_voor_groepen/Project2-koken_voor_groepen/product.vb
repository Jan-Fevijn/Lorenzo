Public Class product
    Private _idProduct As Integer
    Private _naamProduct As String
    Private _idwinkel As Integer
    Private _hoeveelheid As String


    Public Property IdProduct() As Integer
        Get
            Return _idProduct
        End Get
        Set(ByVal value As Integer)
            _idProduct = value
        End Set
    End Property


    Public Property NaamProduct() As String
        Get
            Return _naamProduct
        End Get
        Set(ByVal value As String)
            _naamProduct = value
        End Set
    End Property


    Public Property IdWinkel() As Integer
        Get
            Return _idwinkel
        End Get
        Set(ByVal value As Integer)
            _idwinkel = value
        End Set
    End Property



    Public Property Hoeveelheid() As String
        Get
            Return _hoeveelheid
        End Get
        Set(ByVal value As String)
            _hoeveelheid = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return NaamProduct
    End Function
End Class
