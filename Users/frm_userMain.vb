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

    Sub Auto_generateTransNo()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblbookinventory` WHERE `transno` order by id desc", conn)
            dr.Read()
            If dr.HasRows Then
                Ibl_TransactionNo.Text = dr.Item("transno").ToString + 1
            Else
                Ibl_TransactionNo.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
        conn.Close()
    End Sub
    Sub Load_controls()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))

        pic = New PictureBox
        pic.Width = 120
        pic.Height = 150
        pic.BackgroundImageLayout = ImageLayout.Stretch
        pic.Tag = dr.Item("bookid").ToString

        Iblbookid = New Label
        With Iblbookid
            .ForeColor = Color.Black
            .BackColor = Color.Wheat
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Tag = dr.Item("bookid").ToString
        End With

        Iblbookname = New Label
        With Iblbookname
            .ForeColor = Color.Black
            .BackColor = Color.Wheat
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Tag = dr.Item("bookid").ToString
        End With

        Iblprice = New Label
        With Iblprice
            .ForeColor = Color.Orange
            .BackColor = Color.Wheat
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Bottom
            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
            .Tag = dr.Item("bookid").ToString
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

        AddHandler pic.Click, AddressOf Selectimg_click
        AddHandler Iblbookid.Click, AddressOf Selectimg_click
        AddHandler Iblbookname.Click, AddressOf Selectimg_click
        AddHandler Iblprice.Click, AddressOf Selectimg_click
    End Sub

    Public Sub Selectimg_click(sender As Object, e As EventArgs)
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice` FROM `tbl_bookmaster1` WHERE bookid like'%" & sender.tag.ToString & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub
    Public Sub Load_Books()
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()
        conn.Open()
        cmd = New MySqlCommand("SELECT  `img`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice` FROM `tbl_bookmaster1`", conn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            Load_controls()

        End While
        dr.Dispose()
        conn.Close()
    End Sub


End Class