Public Class Ticket
    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.pic_destination.Image = My.Resources.ResourceManager.GetObject(Register.cb_destination_city.Text.ToLower().Replace(" ", "_"))
        Dim data As String = ""
        data = data + Register.txt_name.Text + Environment.NewLine
        data = data + Register.txt_lastname.Text + " " + Register.txt_surname.Text + Environment.NewLine
        If Register.rb_masculino.Checked Then
            data = data + Register.rb_masculino.Text + Environment.NewLine
        ElseIf Register.rb_femenino.Checked Then
            data = data + Register.rb_femenino.Text + Environment.NewLine
        End If
        data = data + Register.nd_age.Value.ToString() + Environment.NewLine
        data = data + Register.cb_passengers.Text + Environment.NewLine
        data = data + Register.dt_date.Value.ToString() + Environment.NewLine
        data = data + Register.cb_departure_state.Text + ", " + Register.cb_departure_city.Text + Environment.NewLine
        data = data + Register.cb_destination_state.Text + ", " + Register.cb_destination_city.Text + Environment.NewLine
        data = data + Register.lbl_cost.Text + Environment.NewLine
        data = data + (Register.lbl_cost.Text * Register.cb_passengers.Text).ToString() + Environment.NewLine

        Me.txt_data.Text = data
    End Sub
End Class