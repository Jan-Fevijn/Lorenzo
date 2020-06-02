Imports MySql.Data.MySqlClient
Public Class lade
Private connStr As String = "server=localhost;user=root;port=3307;password=usbw;database=diepvries;"
Private conn As New MySqlConnection(connStr)
Private _idlade as Integer
Private _omschrijvingLade as String
Public Sub New()
End Sub
Public Sub New(idlade As Integer,omschrijvingLade As String)
Me.idlade = idlade
Me.omschrijvingLade = omschrijvingLade
End Sub
Public Property idlade () As Integer
Get
Return _idlade
End Get
Set(ByVal value as Integer)
_idlade = value
End Set
End Property
Public Property omschrijvingLade() As String
Get
Return _omschrijvingLade
End Get
Set(ByVal value as String)
_omschrijvingLade = value
End Set
End Property
Public Sub Add()
Using conn = New MySqlConnection(connStr)
Dim query = "INSERT INTO lade(idlade,omschrijvingLade) VALUES(@idlade,@omschrijvingLade)"
conn.Open()
Try
Using cmd As New MySqlCommand(query,conn)
cmd.Parameters.AddWithValue("@idlade", idlade())
cmd.Parameters.AddWithValue("@omschrijvingLade", omschrijvingLade())
cmd.ExecuteNonQuery()
End Using
Catch ex As Exception
Messagebox.show(ex.toString())
End Try
conn.Close()
End Using
End Sub
Public Sub Update()
Using Conn = new MySqlConnection(connStr)
Dim query As String = "Update lade SET omschrijvingLade=@omschrijvingLade WHERE idlade = @idlade"
conn.Open()
Try
Using cmd As New MySqlCommand(query,conn)
cmd.Parameters.AddWithValue("@idlade", idlade())
cmd.Parameters.AddWithValue("@omschrijvingLade", omschrijvingLade())
cmd.ExecuteNonQuery()
End Using
Catch ex As Exception
Messagebox.show(ex.toString())
End Try
conn.Close()
End Using
End Sub
Public Shared Function GetOne(ByVal ID as Integer) as lade
Dim myObj As New lade()
Using conn = New MySqlConnection("server=localhost;user=root;port=3307;password=usbw;database=diepvries;")
Dim query as String = "SELECT * FROM lade WHERE idlade = @idlade"
conn.Open()
Try
Using cmd As New MySqlCommand(query, conn)
cmd.Parameters.AddWithValue("@idlade", ID)
Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
If reader.Read() Then
myObj.idlade = Convert.ToInt32(reader("idlade"))
myObj.omschrijvingLade = reader("omschrijvingLade").ToString()
End If
End Using
End Using
Return myObj
Catch ex As Exception
Messagebox.show(ex.toString())
End Try
End Using
End Function
Public Shared Function GetAll() As Datatable
Using conn = New MySqlConnection("server=localhost;user=root;port=3307;password=usbw;database=diepvries;")
conn.Open()
Dim datatable As New DataTable()
Dim query as String = "SELECT * FROM lade"
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
