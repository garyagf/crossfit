
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class Form1
#Region "Declares"
    Dim myconectcion As New DTconexion
    Dim objdatapter As MySqlDataAdapter
    Dim dtable As New DataTable

#End Region


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub BTlogin_Click(sender As Object, e As EventArgs) Handles BTlogin.Click
        objdatapter = New MySqlDataAdapter("select NOMBRE, PASSWORD FROM LOGIN where  NOMBRE='" & Tusername.Text & "'and PASSWORD='" & Tpassword.Text & "'", myconectcion.open)
        dtable.Clear()
        objdatapter.Fill(dtable)
        If dtable.Rows.Count = Nothing Then
            MsgBox("Nothing username and password")
        Else
            FORM_USER.Show()
            Me.Hide()
        End If
        myconectcion.close()
    End Sub

    Private Sub Tusername_TextChanged(sender As Object, e As EventArgs) Handles Tusername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tpassword_TextChanged(sender As Object, e As EventArgs) Handles Tpassword.TextChanged

    End Sub
End Class
