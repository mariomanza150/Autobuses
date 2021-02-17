Public Class Register
    Dim cities = New Dictionary(Of String, Array) From {
        {"Coahuila", {"Saltillo", "Arteaga", "Ramos Arizpe", "Parras"}},
        {"Nuevo Leon", {"Guadalupe", "Monterrey", "San Nicolas"}}
    }

    Dim costs = New Dictionary(Of String, Array) From {
        {"Saltillo", {{"Arteaga", 15}, {"Parras", 142}, {"Ramos Arizpe", 13}, {"Monterrey", 87}, {"Guadalupe", 98}, {"San Nicolas", 106}}},
        {"Arteaga", {{"Parras", 162}, {"Ramos Arizpe", 22}, {"Monterrey", 89}, {"Guadalupe", 99}, {"San Nicolas", 107}}},
        {"Parras", {{"Ramos Arizpe", 157}, {"Monterrey", 229}, {"Guadalupe", 240}, {"San Nicolas", 236}}},
        {"Ramos Arizpe", {{"Monterrey", 74}, {"Guadalupe", 85}, {"San Nicolas", 93}}},
        {"Monterrey", {{"Guadalupe", 14}, {"San Nicolas", 10}}},
        {"Guadalupe", {{"San Nicolas", 15}}}
    }

    Private Function Calculate(ByVal cityone As String, ByVal citytwo As String) As String
        Dim km As Integer = 0
        Dim i As Integer
        For Each group As KeyValuePair(Of String, Array) In costs
            For i = 0 To group.Value.Length / 2 - 1
                If group.Key.Equals(cityone) And group.Value(i, 0).Equals(citytwo) Then
                    km = group.Value(i, 1)
                End If
                If group.Key.Equals(citytwo) And group.Value(i, 0).Equals(cityone) Then
                    km = group.Value(i, 1)
                End If
            Next i
        Next
        Return Math.Round(1.05964 * km + 34.4179).ToString()
    End Function

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dt_date.MinDate = DateTime.Today
        If Me.cb_passengers.Items.Count > 0 Then
            Me.cb_passengers.SelectedIndex = 0
        End If
    End Sub

    Private Sub cb_departure_state_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_departure_state.SelectedIndexChanged
        Me.cb_departure_city.Items.Clear()
        Dim result As Array = Nothing
        If cities.TryGetValue(Me.cb_departure_state.Text, result) Then
            For Each city As String In result
                Me.cb_departure_city.Items.Add(city)
            Next
        End If
    End Sub

    Private Sub cb_destination_state_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_destination_state.SelectedIndexChanged
        Me.cb_destination_city.Items.Clear()
        Dim result As Array = Nothing
        If cities.TryGetValue(Me.cb_destination_state.Text, result) Then
            For Each city As String In result
                Me.cb_destination_city.Items.Add(city)
            Next
        End If
    End Sub

    Private Sub cb_departure_city_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_departure_city.SelectedIndexChanged
        If Me.cb_destination_city.Text IsNot "" Then
            Me.lbl_cost.Text = Calculate(Me.cb_departure_city.Text, Me.cb_destination_city.Text)
        End If
    End Sub

    Private Sub cb_destination_city_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_destination_city.SelectedIndexChanged
        If Me.cb_departure_city.Text IsNot "" Then
            Me.lbl_cost.Text = Calculate(Me.cb_departure_city.Text, Me.cb_destination_city.Text)
        End If
        Me.pic_destination.Image = My.Resources.ResourceManager.GetObject(Me.cb_destination_city.Text.ToLower().Replace(" ", "_"))
    End Sub

    Private Sub bttn_print_Click(sender As Object, e As EventArgs) Handles bttn_print.Click
        Ticket.Show()
        Me.Close()
    End Sub
End Class