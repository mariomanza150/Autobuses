Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttn_login.Click
        If Me.txt_user.Text.Equals("gs") And Me.txt_pwd.Text.Equals("gs") Then
            Register.Show()
            Me.Close()
        Else
            Me.txt_error.Text = "Error, Datos incorrectos"
        End If
    End Sub
End Class