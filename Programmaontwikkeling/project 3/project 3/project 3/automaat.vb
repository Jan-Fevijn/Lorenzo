Public Class automaat
    Private _idbrood As List(Of brood)
    Private _plaats As String

    Public Property Idbrood() As List(Of brood)
        Get
            Return _idbrood
        End Get
        Set(ByVal value As List(Of brood))
            _idbrood = value
        End Set
    End Property


    Public Property Plaats() As String
        Get
            Return _plaats
        End Get
        Set(ByVal value As String)
            _plaats = value
        End Set
    End Property
End Class
