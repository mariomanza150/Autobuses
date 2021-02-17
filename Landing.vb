Public Class Landing
    Private Sub bttn_exit_Click(sender As Object, e As EventArgs) Handles bttn_exit.Click
        Me.Close()
    End Sub

    Private Sub bttn_go_login_Click(sender As Object, e As EventArgs) Handles bttn_go_login.Click
        Login.Show()
        Me.Close()
    End Sub
End Class
