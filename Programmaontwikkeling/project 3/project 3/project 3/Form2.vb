Imports MySql.Data.MySqlClient

Public Class Brood_Toevoegen
    Dim conn As New MySqlConnection("server=localhost;user=root;database=project3;port=3307;password=usbw;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim insertQuery As String = "insert into brood (naam) VALUES('" & txtBrood.Text & "')"
        Dim command As New MySqlCommand(insertQuery, conn)
        conn.Open()

        command.ExecuteNonQuery()

        conn.Close()
        Me.Hide()
        Form1.Show()

    End Sub
End Class