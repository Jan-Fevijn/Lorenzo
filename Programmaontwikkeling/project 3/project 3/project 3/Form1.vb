Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection("server=localhost;user=root;database=project3;port=3307;password=usbw;")


    End Sub

    Private Sub broodToevoegen_Click(sender As Object, e As EventArgs) Handles broodToevoegen.Click
        Me.Hide()
        Brood_Toevoegen.Show()
    End Sub
End Class
