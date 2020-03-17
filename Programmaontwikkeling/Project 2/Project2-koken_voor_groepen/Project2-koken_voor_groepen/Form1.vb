
Public Class Kokenvoorgroepen
    Private Sub btnGerechtToevoegen_Click(sender As Object, e As EventArgs) Handles btnGerechtToevoegen.Click
        Me.Hide()
        Gerecht_toevoegen.Show()
    End Sub

    Private Sub btnSluiten_Click(sender As Object, e As EventArgs) Handles btnSluiten.Click
        Me.Close()
    End Sub

    Private Sub btnProductToevoegen_Click(sender As Object, e As EventArgs) Handles btnEvenementToevoegen.Click
        Me.Hide()
        evenement_Toevoegen.Show()
    End Sub

    Private Sub btnAanpassenIngrediënt_Click(sender As Object, e As EventArgs) Handles btnAanpassenIngrediënt.Click
        Me.Hide()
        IngredientAanpassen.Show()
    End Sub
End Class
