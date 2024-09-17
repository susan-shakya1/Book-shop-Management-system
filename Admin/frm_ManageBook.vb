Imports MySql.Data.MySqlClient
Imports System.ID
Public Class frm_ManageBook


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        dbconn()

    End Sub

    Public Sub clear()
        pic_bookimg.Image = Nothing
        txt_Author.Clear()

        txt_BookName.Clear()
        txt_Price.Clear()
        txt_TotalPrice.Clear()
        cbo_Tax.SelectedIndex = -1

    End Sub

    Public Sub Auto_book()
        txt_BookId.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("", conn)

        Catch ex As Exception
            MsgBox(ex.Message
                   )

        End Try
        conn.Close()

    End Sub
End Class