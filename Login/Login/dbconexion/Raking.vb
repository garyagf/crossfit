Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Raking
#Region "Declares"
    Dim myconectcion As New DTconexion
    Dim objdatapter As MySqlDataAdapter
    Dim dtable As New DataTable
#End Region

    Private Sub Raking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objdatapter = New MySqlDataAdapter("select US_NAME NOMBRE, FECHA, TIEMPO, PUNTOS from RANKING order by PUNTOS DESC", myconectcion.open())
        objdatapter.Fill(dtable)
        DataGridView1.DataSource = dtable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub
End Class