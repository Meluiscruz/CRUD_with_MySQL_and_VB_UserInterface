Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration.ConfigurationManager
Imports System.Configuration

Public Class Connection
    Private server, database, user, password As String

    Public Sub New()
        Try
            server = System.Configuration.ConfigurationManager.AppSettings("server").ToString
            database = System.Configuration.ConfigurationManager.AppSettings("database").ToString
            user = System.Configuration.ConfigurationManager.AppSettings("user").ToString
            password = System.Configuration.ConfigurationManager.AppSettings("password").ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function OpenConnection() As MySqlConnection

        Dim MySQLConnectionString As String
        MySQLConnectionString = "server=" + server + ";" & "uid=" + user + ";" + "pwd=" + password + ";" + "database=" + database + ";"

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(MySQLConnectionString)
        conn.Open()
        Return conn

    End Function

End Class
