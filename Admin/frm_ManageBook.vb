Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms


Public Class frm_ManageBook

    Private Sub frm_ManageBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Auto_bookid()
    End Sub



    Public Sub clear()
        pic_bookimg.Image = Nothing
        txt_Author.Clear()

        txt_BookName.Clear()
        txt_Price.Clear()
        txt_TotalPrice.Clear()
        cbo_Tax.SelectedIndex = -1

    End Sub

    Public Sub Auto_bookid()
        txt_BookId.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_bookmaster1` WHERE bookid order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.Read = True Then
                txt_BookId.Text = dr.Item("bookid").ToString + 1
            Else
                txt_BookId.Text = Date.Now.ToString("yyyy") & "001"

            End If

        Catch ex As Exception
            MsgBox(ex.Message
                   )

        End Try
        conn.Close()

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Hide()

    End Sub

    Private Sub frm_(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_bookimg_Click(sender As Object, e As EventArgs) Handles pic_bookimg.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then
            pic_bookimg.Image = System.Drawing.Image.FromFile(pop.FileName)
        End If







    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If txt_BookName.Text = String.Empty Or txt_Price.Text = String.Empty Or txt_TotalPrice.Text = String.Empty Or txt_Author.Text = String.Empty Then
            MsgBox("Warning : Missing Required Field ? ", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("INSERT INTO `tbl_bookmaster1`( `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `img`) VALUES (@bookid,@bookname,@author,@price,@tax,@totalprice,@img)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@bookid", txt_BookId.Text)
                cmd.Parameters.AddWithValue("@bookname", txt_BookName.Text)
                cmd.Parameters.AddWithValue("@author", txt_Author.Text)
                cmd.Parameters.AddWithValue("@price", CDec(txt_Price.Text))
                cmd.Parameters.AddWithValue("@tax", cbo_Tax.TabIndex)
                cmd.Parameters.AddWithValue("@totalprice", CDec(txt_TotalPrice.Text))

                Dim FileSize As New UInt32
                Dim mstream As New System.IO.MemoryStream
                pic_bookimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                FileSize = mstream.Length
                mstream.Close()


                cmd.Parameters.AddWithValue("@img", picture)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("New Book Register Success !", vbInformation)
                Else
                    MsgBox(" Book Register failed !", vbInformation)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            Auto_bookid()

        End If
    End Sub

    Private Sub cbo_Tax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Tax.SelectedIndexChanged
        Try
            txt_TotalPrice.Text = CDec(txt_Price.Text * cbo_Tax.Text / 100) + txt_Price.Text
        Catch ex As Exception

        End Try
    End Sub
End Class