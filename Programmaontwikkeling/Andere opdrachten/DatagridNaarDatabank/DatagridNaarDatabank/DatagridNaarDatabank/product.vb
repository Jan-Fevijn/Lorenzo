Imports MySql.Data.MySqlClient
Public Class product
Private connStr As String = "server=localhost;user=root;port=3307;password=usbw;database=diepvries;"
Private conn As New MySqlConnection(connStr)
Private _aantal as String
Private _gewicht as String
Private _idinhoud as Integer
Private _idlade as Integer
Private _idproduct as Integer
Private _invriesdatum as String
Public Sub New()
End Sub
Public Sub New(aantal As String,gewicht As String,idinhoud As Integer,idlade As Integer,idproduct As Integer,invriesdatum As String)
Me.aantal = aantal
Me.gewicht = gewicht
Me.idinhoud = idinhoud
Me.idlade = idlade
Me.idproduct = idproduct
Me.invriesdatum = invriesdatum
End Sub
Public Property aantal() As String
Get
Return _aantal
End Get
Set(ByVal value as String)
_aantal = value
End Set
End Property
Public Property gewicht() As String
Get
Return _gewicht
End Get
Set(ByVal value as String)
_gewicht = value
End Set
End Property
Public Property idinhoud() As Integer
Get
Return _idinhoud
End Get
Set(ByVal value as Integer)
_idinhoud = value
End Set
End Property
Public Property idlade() As Integer
Get
Return _idlade
End Get
Set(ByVal value as Integer)
_idlade = value
End Set
End Property
Public Property idproduct () As Integer
Get
Return _idproduct
End Get
Set(ByVal value as Integer)
_idproduct = value
End Set
End Property
Public Property invriesdatum() As String
Get
Return _invriesdatum
End Get
Set(ByVal value as String)
_invriesdatum = value
End Set
End Property
Public Sub Add()
Using conn = New MySqlConnection(connStr)
Dim query = "INSERT INTO product(aantal,gewicht,idinhoud,idlade,idproduct,invriesdatum) VALUES(@aantal,@gewicht,@idinhoud,@idlade,@idproduct,@invriesdatum)"
conn.Open()
Try
Using cmd As New MySqlCommand(query,conn)
cmd.Parameters.AddWithValue("@aantal", aantal())
cmd.Parameters.AddWithValue("@gewicht", gewicht())
cmd.Parameters.AddWithValue("@idinhoud", idinhoud())
cmd.Parameters.AddWithValue("@idlade", idlade())
cmd.Parameters.AddWithValue("@idproduct", idproduct())
cmd.Parameters.AddWithValue("@invriesdatum", invriesdatum())
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
Dim query As String = "Update product SET aantal=@aantal,gewicht=@gewicht,idinhoud=@idinhoud,idlade=@idlade,invriesdatum=@invriesdatum WHERE idproduct = @idproduct"
conn.Open()
Try
Using cmd As New MySqlCommand(query,conn)
cmd.Parameters.AddWithValue("@aantal", aantal())
cmd.Parameters.AddWithValue("@gewicht", gewicht())
cmd.Parameters.AddWithValue("@idinhoud", idinhoud())
cmd.Parameters.AddWithValue("@idlade", idlade())
cmd.Parameters.AddWithValue("@idproduct", idproduct())
cmd.Parameters.AddWithValue("@invriesdatum", invriesdatum())
cmd.ExecuteNonQuery()
End Using
Catch ex As Exception
Messagebox.show(ex.toString())
End Try
conn.Close()
End Using
End Sub
Public Shared Function GetOne(ByVal ID as Integer) as product
Dim myObj As New product()
Using conn = New MySqlConnection("server=localhost;user=root;port=3307;password=usbw;database=diepvries;")
Dim query as String = "SELECT * FROM product WHERE idproduct = @idproduct"
conn.Open()
Try
Using cmd As New MySqlCommand(query, conn)
cmd.Parameters.AddWithValue("@idproduct", ID)
Using reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
If reader.Read() Then
myObj.aantal = reader("aantal").ToString()
myObj.gewicht = reader("gewicht").ToString()
myObj.idinhoud = Convert.ToInt32(reader("idinhoud"))
myObj.idlade = Convert.ToInt32(reader("idlade"))
myObj.idproduct = Convert.ToInt32(reader("idproduct"))
myObj.invriesdatum = reader("invriesdatum").ToString()
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
Dim query as String = "SELECT * FROM product"
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
