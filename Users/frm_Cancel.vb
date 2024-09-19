Imports MySql.Data.MySqlClient


Public Class frm_Cancel


    Private Sub frm_Cancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Load_Transaction()
    End Sub

    Sub Load_Transaction()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `grandtotal` FROM `tblbookinventory` group by grandtotal", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "Column5" Then
            If MsgBox("Are you sure cancel this order ", vbQuestion + vbYesNo) = vbYes Then
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tblbookinventory` WHERE `transno`=@transno", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@transno", DataGridView1.CurrentRow.Cells(2).Value)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Order Cancel Success !", vbInformation)
                Else
                    MsgBox("Order Cancel failed !", vbInformation)
                End If

                conn.Close()
            End If
            Load_Transaction()
            Update_bookStatus()
            frm_userMain.Load_Books()
        End If

    End Sub

    Sub Update_bookStatus()
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tbl_bookmaster1` SET `status`=@status WHERE `bookid`=@bookid", conn)
            For j As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@status", "")
                cmd.Parameters.AddWithValue("@bookid", DataGridView1.CurrentRow.Cells(2).Value)
                i = cmd.ExecuteNonQuery
            Next

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub
End Class