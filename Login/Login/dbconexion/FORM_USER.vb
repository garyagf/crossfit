Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FORM_USER

#Region "Declares"
    Dim myconectcion As New DTconexion
    Dim objdatapter As MySqlDataAdapter
    Dim dtable As New DataTable
#End Region

    Private Sub FORM_USER_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

        End
    End Sub

    Private Sub FORM_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As String
        user = Form1.Tusername.Text
        'Called the username'
        Label1.Text = "Usuario: " & user

    End Sub

    Private Sub Tseg_Click(sender As Object, e As EventArgs) Handles Tseg.Click

    End Sub

    Private Sub Tmin_Click(sender As Object, e As EventArgs) Handles Tmin.Click

    End Sub

    Private Sub Thora_Click(sender As Object, e As EventArgs) Handles Thora.Click

    End Sub

    Private Sub Tiniciar_Click(sender As Object, e As EventArgs) Handles Tiniciar.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Tseg.Text += 1
        If Tseg.Text = "60" Then
            Tmin.Text += 1
            Tseg.Text = "00"
        End If
        If Tmin.Text = "60" Then
            Thora.Text += 1
            Tmin.Text = "00"
        End If


    End Sub

    Private Sub Tstop_Click(sender As Object, e As EventArgs) Handles Tstop.Click
        Timer1.Stop()
        objdatapter = New MySqlDataAdapter("INSERT INTO tests(name,start_at,end_at)VALUES('Test 1',' " & Thora.Text & ":" & Tmin.Text & ":" & Tseg.Text & "',' 10:00:00 ')", myconectcion.open())
        dtable.Clear()
        objdatapter.Fill(dtable)
        myconectcion.close()
        Thora.Text = ""
        Tmin.Text = ""
        Tseg.Text = ""
    End Sub
End Class