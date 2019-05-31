Imports MySql.Data.MySqlClient
Public Class DTconexion
    Dim Conect As New MySqlConnection("server='remotemysql.com'; uid='ozbauw0ZKi'; pwd='hKmJaElvb9'; database='ozbauw0ZKi';port='3306'")
    Public Function open() As MySqlConnection
        Try
            Conect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Return Conect

    End Function

    Public Function close() As MySqlConnection
        Try
            Conect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Return Conect

    End Function

End Class

