Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection("server=localhost;user=root;database=project3;port=3307;password=usbw;")


    End Sub

    Private Sub broodToevoegen_Click(sender As Object, e As EventArgs) Handles broodToevoegen.Click
        Me.Hide()
        Brood_Toevoegen.Show()
    End Sub

    Private Sub btnTonen_Click(sender As Object, e As EventArgs) Handles btnTonen.Click
        Dim conn As New MySqlConnection("server=localhost;user=root;database=project3;port=3307;password=usbw;")
        Try
            Dim Str = "SELECT * FROM opties"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "opties")
            broodmetprijs.DataSource = ds.Tables("opties")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub lblH1_Click(sender As Object, e As EventArgs) Handles lblH1.Click

    End Sub

    Private Sub btnSaldo_Click(sender As Object, e As EventArgs) Handles btnSaldo.Click
        Dim conn As New MySqlConnection("server=localhost;user=root;database=project3;port=3307;password=usbw;")
        Try
            Dim Str = "SELECT * FROM saldovanklant"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "saldovanklant")
            Saldo.DataSource = ds.Tables("saldovanklant")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnOpwaarderen_Click(sender As Object, e As EventArgs) Handles btnOpwaarderen.Click
        Me.Hide()
        opwaarderen.Show()
    End Sub
End Class
