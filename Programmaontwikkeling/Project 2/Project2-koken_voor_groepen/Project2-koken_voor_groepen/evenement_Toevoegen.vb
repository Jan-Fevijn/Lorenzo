Imports MySql.Data.MySqlClient

Public Class evenement_Toevoegen
    Dim conn As New MySqlConnection("server=localhost;user=root;database=project2;port=3307;password=usbw;")
    Private Sub btnToevoegen_Click(sender As Object, e As EventArgs) Handles btnToevoegen.Click
        ' EVENEMENT TOEVOEGEN
        Dim insertQuery As String = "insert into evenement (naam, `aantal dagen`, `aantal personen`) VALUES('" & txtNaam.Text & "','" & txtPersonen.Text & "','" & txtDagen.Text & "')"

        Dim command As New MySqlCommand(insertQuery, conn)
        conn.Open()

        command.ExecuteNonQuery()

        conn.Close()
        Me.Hide()
        Kokenvoorgroepen.Show()

    End Sub
End Class