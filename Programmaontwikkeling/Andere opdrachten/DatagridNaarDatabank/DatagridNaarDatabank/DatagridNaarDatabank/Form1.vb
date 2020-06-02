Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1
    Private dt As DataTable
    Private Sub btnWeergeven_Click(sender As Object, e As EventArgs) Handles btnWeergeven.Click
        'inhoud tonen in datagridview

        dt = inhoud.GetAll()

        dgWeergave.DataSource = dt
    End Sub

    Private Sub btnUpdates_Click(sender As Object, e As EventArgs) Handles btnUpdates.Click
        'rijen updaten
        Dim dtaangepast As DataTable = dt.GetChanges

        If Not IsNothing(dtaangepast) AndAlso dtaangepast.Rows.Count > 0 Then
            For Each row As DataRow In dtaangepast.Rows
                Dim inhoudx As inhoud = inhoud.GetOne(row("idinhoud"))
                inhoudx.omschrijvingInhoud = row("omschrijvingInhoud")
                inhoudx.houdbaarheidstijd = row("houdbaarheidstijd")
                inhoudx.Update()
                MessageBox.Show("Update was succesfull")


            Next
        End If



    End Sub
    'programma sluiten
    Private Sub btnSluiten_Click(sender As Object, e As EventArgs) Handles btnSluiten.Click
        Me.Close()
    End Sub
    'Rijen toevoegen
    Private Sub btnToevoegen_Click(sender As Object, e As EventArgs) Handles btnToevoegen.Click
        Dim dttoegevoegd As DataTable = dt.GetChanges


        For i As Integer = 0 To dgWeergave.Rows.Count - 2 Step +1
            For Each row As DataRow In dttoegevoegd.Rows
                Dim inhoudy As inhoud = inhoud.GetOneItem(row("idinhoud"))
                inhoudy.omschrijvingInhoud = row("omschrijvingInhoud")
                inhoudy.houdbaarheidstijd = row("houdbaarheidstijd")
                inhoudy.AddInhoud()
                MessageBox.Show("rij(en) toegevoegd")

            Next
        Next
    End Sub

    Private Sub btntest_Click(sender As Object, e As EventArgs) Handles btntest.Click

    End Sub
End Class
