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
    Sub Total()
        Dim sum As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(6).Value
        Next
        Ibl_GrandTotal.Text = Format(CDec(sum), "#,##0,00")
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
        cmd = New MySqlCommand("SELECT  `img`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `status` FROM `tbl_bookmaster1` where status='' ", conn)

        dr = cmd.ExecuteReader
        While dr.Read() = True
            Load_controls()

        End While
        dr.Dispose()
        conn.Close()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Hide()
        frm_login.ShowDialog()


    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Total()

    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()
        conn.Open()
        cmd = New MySqlCommand("SELECT  `img`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`,`status` FROM `tbl_bookmaster1` WHERE status='' and bookid like '%" & txt_Search.Text & "%' or  bookname like '%" & txt_Search.Text & "%' ", conn)

        dr = cmd.ExecuteReader
        While dr.Read() = True
            Load_controls()

        End While
        dr.Dispose()
        conn.Close()
    End Sub

    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        If Ibl_GrandTotal.Text > txt_enteramount.Text Then
            MsgBox("Infinity Balance", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("INSERT INTO `tblbookinventory`(`ID`, `transno`, `transdate`, `transmonth`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `grandtotal`) VALUES (@transdate,@transmonth,@bookid,@bookname,@author,@price,@tax,@totalprice,@grandtotal)", conn)
                For j As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@transno", Ibl_TransactionNo.Text)
                    cmd.Parameters.AddWithValue("@transno", Ibl_TranscationDate.Text)
                    cmd.Parameters.AddWithValue("@transmonth", Date.Now().ToString("MM"))

                    cmd.Parameters.AddWithValue("@bookid", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@bookname", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@author", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@tax", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@totalprice", DataGridView1.Rows(j).Cells(6).Value)

                    cmd.Parameters.AddWithValue("@grandtotal", Ibl_GrandTotal.Text)

                    i = cmd.ExecuteNonQuery
                Next

                If i > 0 Then
                    MsgBox("Tranaction save Success !", vbInformation)
                Else
                    MsgBox("Tranaction save Failed !", vbInformation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            update_bookstock()
            clear()
        End If

    End Sub
    Sub clear()
        DataGridView1.Rows.Clear()
        Load_Books()
        Auto_generateTransNo()
        txt_enteramount.Clear()
        txt_Search.Clear()
        Ibl_GrandTotal.Text = "0.00"

    End Sub

    Sub update_bookstock()
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tbl_bookmaster1` SET `status`=@status WHERE `bookid`=@bookid", conn)
            For j As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@status", "SELL")
                cmd.Parameters.AddWithValue("@bookid", DataGridView1.Rows(j).Cells(1).Value)
                i = cmd.ExecuteNonQuery
            Next

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub btn_ManageBook_Click(sender As Object, e As EventArgs) Handles btn_ManageBook.Click
        clear()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        frm_Cancel.ShowDialog()

    End Sub
End Class