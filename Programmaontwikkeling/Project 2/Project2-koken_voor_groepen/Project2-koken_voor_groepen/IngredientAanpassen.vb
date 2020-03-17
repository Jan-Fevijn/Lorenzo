Imports MySql.Data.MySqlClient
Public Class IngredientAanpassen
    Dim conn As New MySqlConnection("server=localhost;user=root;database=project2;port=3307;password=usbw;")







    Private Sub btnIngrediënt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGerecht_Click_1(sender As Object, e As EventArgs) Handles btnGerecht.Click
        Dim adapter As New MySqlDataAdapter("SELECT naam FROM project2.gerecht", conn)
        Dim table As New DataTable()

        adapter.Fill(table)

        cbGerechten.DataSource = table
        cbGerechten.ValueMember = "naam"

        lbIngrediënten.Items.Add("SELECT naamProduct FROM project2.gerechtmetproducten where idgerecht = 1")

    End Sub

    Private Sub btnIngrediënt_Click_1(sender As Object, e As EventArgs) Handles btnIngrediënt.Click

    End Sub
End Class