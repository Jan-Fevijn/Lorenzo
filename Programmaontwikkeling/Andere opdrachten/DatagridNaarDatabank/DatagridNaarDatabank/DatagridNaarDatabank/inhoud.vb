Imports MySql.Data.MySqlClient
Public Class inhoud
Private connStr As String = "server=localhost;user=root;port=3307;password=usbw;database=diepvries;"
Private conn As New MySqlConnection(connStr)
Private _houdbaarheidstijd as String
Private _idinhoud as Integer
Private _omschrijvingInhoud as String
Public Sub New()
End Sub
Public Sub New(houdbaarheidstijd As String,idinhoud As Integer,omschrijvingInhoud As String)
Me.houdbaarheidstijd = houdbaarheidstijd
Me.idinhoud = idinhoud
Me.omschrijvingInhoud = omschrijvingInhoud
End Sub
Public Property houdbaarheidstijd() As String
Get
Return _houdbaarheidstijd
End Get
Set(ByVal value as String)
_houdbaarheidstijd = value
End Set
End Property
Public Property idinhoud () As Integer
Get
Return _idinhoud
End Get
Set(ByVal value as Integer)
_idinhoud = value
End Set
End Property
Public Property omschrijvingInhoud() As String
Get
Return _omschrijvingInhoud
End Get
Set(ByVal value as String)
_omschrijvingInhoud = value
End Set
End Property
    Public Sub Add()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO inhoud(houdbaarheidstijd,idinhoud,omschrijvingInhoud) VALUES(@houdbaarheidstijd,@idinhoud,@omschrijvingInhoud)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@houdbaarheidstijd", houdbaarheidstijd())
                    cmd.Parameters.AddWithValue("@idinhoud", idinhoud())
                    cmd.Parameters.AddWithValue("@omschrijvingInhoud", omschrijvingInhoud())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
            conn.Close()
        End Using
    End Sub

    Public Sub AddInhoud()
        Using conn = New MySqlConnection(connStr)
            Dim query = "INSERT INTO inhoud(idinhoud, omschrijvingInhoud, houdbaarheidstijd ) VALUES(@idinhoud, @omschrijvingInhoud, @houdbaarheidstijd)"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@@idinhoud", idinhoud())
                    cmd.Parameters.AddWithValue("@omschrijvingInhoud", omschrijvingInhoud())
                    cmd.Parameters.AddWithValue("@houdbaarheidstijd", houdbaarheidstijd())
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
            conn.Close()
        End Using
    End Sub
    Public Sub Update()
Using Conn = new MySqlConnection(connStr)
Dim query As String = "Update inhoud SET houdbaarheidstijd=@houdbaarheidstijd,omschrijvingInhoud=@omschrijvingInhoud WHERE idinhoud = @idinhoud"
conn.Open()
Try
Using cmd As New MySqlCommand(query,conn)
cmd.Parameters.AddWithValue("@houdbaarheidstijd", houdbaarheidstijd())
cmd.Parameters.AddWithValue("@idinhoud", idinhoud())
cmd.Parameters.AddWithValue("@omschrijvingInhoud", omschrijvingInhoud())
cmd.ExecuteNonQuery()
End Using
Catch ex As Exception
Messagebox.show(ex.toString())
End Try
conn.Close()
End Using
End Sub
    Public Shared Function GetOne(ByVal ID As Integer) As inhoud
        Dim myObj As New inhoud()
        Using conn = New MySqlConnection("server=localhost;user=root;port=3307;password=usbw;database=diepvries;")
            Dim query As String = "SELECT * FROM inhoud WHERE idinhoud = @idinhoud"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idinhoud", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.houdbaarheidstijd = reader("houdbaarheidstijd").ToString()
                            myObj.idinhoud = Convert.ToInt32(reader("idinhoud"))
                            myObj.omschrijvingInhoud = reader("omschrijvingInhoud").ToString()
                        End If
                    End Using
                End Using
                Return myObj
            Catch ex As Exception
                Messagebox.show(ex.toString())
            End Try
        End Using
    End Function

    Public Shared Function GetOneItem(ByVal ID As Integer) As inhoud
        Dim myObj As New inhoud()
        Using conn = New MySqlConnection("server=localhost;user=root;port=3307;password=usbw;database=diepvries;")
            Dim query As String = "SELECT * FROM inhoud WHERE idinhoud = @idinhoud"
            conn.Open()
            Try
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idinhoud", ID)
                    Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        If reader.Read() Then
                            myObj.idinhoud = Convert.ToInt32(reader("idinhoud"))
                            myObj.omschrijvingInhoud = reader("omschrijvingInhoud").ToString()
                            myObj.houdbaarheidstijd = reader("houdbaarheidstijd").ToString()


                        End If
                    End Using
                End Using
                Return myObj
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Using
    End Function
    Public Shared Function GetAll() As Datatable
Using conn = New MySqlConnection("server=localhost;user=root;port=3307;password=usbw;database=diepvries;")
conn.Open()
Dim datatable As New DataTable()
Dim query as String = "SELECT * FROM inhoud"
Try
Using cmd = New MySqlCommand(query, conn)
Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
datatable.load(reader)
End Using
Return datatable
End Using
Catch ex As Exception
Messagebox.show(ex.toString())
End Try
End Using
End Function
End Class
