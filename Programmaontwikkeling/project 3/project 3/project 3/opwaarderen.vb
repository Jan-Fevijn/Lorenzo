Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class opwaarderen
    Dim conn As New MySqlConnection("server=localhost;user=root;database=project3;port=3307;password=usbw;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnToevoegen.Click

        Dim mycommand As MySqlCommand = New MySqlCommand()
        mycommand.Connection = conn
        mycommand.CommandText = "INSERT INTO saldo (idklant, saldo, datum, broodpositiedatum) VALUES (@idklant, @saldo, @datum, @broodpositiedatum,)"
        conn.Open()
        Try
            mycommand.Parameters.Add("@idklant", SqlDbType.Int).Value = txtklant.Text
            mycommand.Parameters.Add("@saldo", SqlDbType.NVarChar).Value = txtSaldo.Text
            mycommand.Parameters.Add("@datum", SqlDbType.Date).Value = txtDatum.Text
            mycommand.Parameters.Add("@broodpositiedatum", SqlDbType.VarChar).Value = txtbroodpositiedatum.Text

            mycommand.ExecuteNonQuery()
            MsgBox("Success")
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
        conn.Close()


        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub lblnaam_Click(sender As Object, e As EventArgs) Handles lblnaam.Click

    End Sub
End Class