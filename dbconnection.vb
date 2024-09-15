




Imports MySql.Data.MySqlClient
Imports System.IO


Module dbconnection
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public dt As MySqlDataAdapter

    Public i As Integer
    Public result As Boolean

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=127.0.0.1; port=3377; database=book_db; user=root; password=123"
                result = True

            End If
        Catch ex As Exception
            result = False
            MsgBox("Server Not Connected !", vbExclamation
                   )

        End Try
        Return result
    End Function


End Module