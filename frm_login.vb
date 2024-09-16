Imports MySql.Data.MySqlClient



Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_userName.Text = String.Empty Or txt_password.Text = String.Empty Then
            MessageBox.Show("Warning : Required Missing Filed ?", "Book Shop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                            )
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM `tbluser` WHERE `username`=@username", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@username", txt_userName.Text)
                Dim da As New MySqlDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    cmd = New MySqlCommand("SELECT * FROM `tbluser` WHERE `username`=@username AND `password`=@password", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@username", txt_userName.Text)
                    cmd.Parameters.AddWithValue("@password", txt_password.Text)
                    dr = cmd.ExecuteReader
                    If dr.Read = True Then
                        Dim name As String = dr.Item("name").ToString
                        Dim username As String = dr.Item("username").ToString
                        Dim password As String = dr.Item("password").ToString
                        Dim role As String = dr.Item("role").ToString

                        If UCase(role) = "ADMIN" Then
                            MsgBox("Welcome: " & name)
                        ElseIf UCase(role) = "USER" Then
                            MsgBox("Welcome: " & name)

                        End If
                    Else
                        MessageBox.Show("Warning : Invalid Username or password ?", "Book Shop", MessageBoxButtons.OK, MessageBoxIcon.Error
                          )
                    End If
                Else
                    MessageBox.Show("Warning : User Not Found ?", "Book Shop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                        )
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Are you Sure want to Exit ?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub
End Class