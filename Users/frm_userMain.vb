Imports MySql.Data.MySqlClient
Imports System.IO


Public Class frm_userMain
    Private WithEvents pic As New PictureBox
    Private WithEvents Iblbookid As New Label
    Private WithEvents Iblbookname As New Label
    Private WithEvents Iblprice As New Label


    Private Sub frm_UserMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 28
        Ibl_TranscationDate.Text = Date.Now.ToString("yyy-MM-dd")
        Load_Books()
    End Sub
    Sub Load_Books()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))

        pic = New PictureBox
        pic.Width = 120
        pic.Height = 150
        pic.BackgroundImageLayout = ImageLayout.Stretch

        Iblbookid = New Label
        With Iblbookid
            .ForeColor = Color.DimGray
            .BackColor = Color.WhiteSmoke
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
        End With

        Iblbookname = New Label
        With Iblbookname
            .ForeColor = Color.DimGray
            .BackColor = Color.WhiteSmoke
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
        End With

        Iblprice = New Label
        With Iblprice
            .ForeColor = Color.Orange
            .BackColor = Color.WhiteSmoke
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Bottom
            .Font = New Font("Segoe UI", 11, FontStyle.Bold)
        End With

        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        pic.BackgroundImage = bitmap
        Iblbookid.Text = dr.Item("bookid").ToString
        Iblbookname.Text = dr.Item("bookname").ToString
        Iblprice.Text = dr.Item("totalprice").ToString

        pic.Controls.Add(Iblbookid)
        pic.Controls.Add(Iblbookname)
        pic.Controls.Add(Iblprice)

        FlowLayoutPanel1.Controls.Add(pic)
    End Sub
End Class