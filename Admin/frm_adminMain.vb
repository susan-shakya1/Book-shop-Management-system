Public Class frm_adminMain
    Private Sub btn_ManageBook_Click(sender As Object, e As EventArgs) Handles btn_ManageBook.Click
        frm_ManageBook.ShowDialog()

    End Sub

    Private Sub btn_ManageUser_Click(sender As Object, e As EventArgs) Handles btn_ManageUser.Click
        frm_ManageUser.ShowDialog()


    End Sub

    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Hide()
        frm_login.ShowDialog()
    End Sub

    Sub Get_Dashboard()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Get_Dashboard()
        Ibl_Date.Text = Date.Now.ToString("dddd MMM-yyyy")
        Ibl_Time.Text = Date.Now.ToString("hh:mm:ss tt")

    End Sub
End Class