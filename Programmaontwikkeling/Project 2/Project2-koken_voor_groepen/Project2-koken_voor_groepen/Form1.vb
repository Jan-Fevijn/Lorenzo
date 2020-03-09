Imports MySql.Data.MySqlClient

Public Class Kokenvoorgroepen
    ' SQL CONNECTIE
    Dim conn As New MySqlConnection("server=localhost;user=root;database=project2;port=3307;password=usbw;")
    Private Sub btnToevoegen_Click(sender As Object, e As EventArgs) Handles btnToevoegen.Click
        ' GERECHT TOEVOEGEN
        Dim insertQuery As String = "insert into gerecht (naam) VALUES('" & txtNaam.Text & "')"

        Dim command As New MySqlCommand(insertQuery, conn)
        conn.Open()

        command.ExecuteNonQuery()

        conn.Close()



    End Sub




End Class
