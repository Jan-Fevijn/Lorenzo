Imports MySql.Data.MySqlClient

Public Class opwaarderen
    Dim conn As New MySqlConnection("server=localhost;user=root;database=project3;port=3307;password=usbw;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnToevoegen.Click
        Dim insertQuery As String = "insert into saldo ( idklant, saldo, datum, broodpositiedatum) VALUES('" & txtklant.Text & "'" & txtSaldo.Text & "'" & txtDatum.Text & "'" & txtbroodpositiedatum.Text & "')"
        Dim command As New MySqlCommand(insertQuery, conn)
        conn.Open()

        command.ExecuteNonQuery()

        conn.Close()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub lblnaam_Click(sender As Object, e As EventArgs) Handles lblnaam.Click

    End Sub
End Class