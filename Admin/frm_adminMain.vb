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

    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click

    End Sub

    Private Sub Ibl_UserInfo_Click(sender As Object, e As EventArgs) Handles Ibl_UserInfo.Click

    End Sub

    Private Sub frm_adminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
End Class