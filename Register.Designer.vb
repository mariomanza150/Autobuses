<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.lbl_lastname = New System.Windows.Forms.Label()
        Me.txt_surname = New System.Windows.Forms.TextBox()
        Me.lbl_surname = New System.Windows.Forms.Label()
        Me.gb_sexo = New System.Windows.Forms.GroupBox()
        Me.rb_femenino = New System.Windows.Forms.RadioButton()
        Me.rb_masculino = New System.Windows.Forms.RadioButton()
        Me.nd_age = New System.Windows.Forms.NumericUpDown()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.dt_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.cb_passengers = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gb_departure = New System.Windows.Forms.GroupBox()
        Me.lbl_departure_city = New System.Windows.Forms.Label()
        Me.cb_departure_city = New System.Windows.Forms.ComboBox()
        Me.lbl_departure_state = New System.Windows.Forms.Label()
        Me.cb_departure_state = New System.Windows.Forms.ComboBox()
        Me.gb_destination = New System.Windows.Forms.GroupBox()
        Me.lbl_destination_city = New System.Windows.Forms.Label()
        Me.cb_destination_city = New System.Windows.Forms.ComboBox()
        Me.lbl_destination_state = New System.Windows.Forms.Label()
        Me.cb_destination_state = New System.Windows.Forms.ComboBox()
        Me.lbl_cost = New System.Windows.Forms.Label()
        Me.lbl_hold_cost = New System.Windows.Forms.Label()
        Me.bttn_print = New System.Windows.Forms.Button()
        Me.pic_destination = New System.Windows.Forms.PictureBox()
        Me.gb_sexo.SuspendLayout()
        CType(Me.nd_age, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_departure.SuspendLayout()
        Me.gb_destination.SuspendLayout()
        CType(Me.pic_destination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_name.Location = New System.Drawing.Point(24, 20)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(58, 17)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Nombre"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(29, 40)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(278, 26)
        Me.txt_name.TabIndex = 5
        '
        'txt_lastname
        '
        Me.txt_lastname.Location = New System.Drawing.Point(30, 106)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(278, 26)
        Me.txt_lastname.TabIndex = 7
        '
        'lbl_lastname
        '
        Me.lbl_lastname.AutoSize = True
        Me.lbl_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_lastname.Location = New System.Drawing.Point(24, 86)
        Me.lbl_lastname.Name = "lbl_lastname"
        Me.lbl_lastname.Size = New System.Drawing.Size(112, 17)
        Me.lbl_lastname.TabIndex = 6
        Me.lbl_lastname.Text = "Apellido Paterno"
        '
        'txt_surname
        '
        Me.txt_surname.Location = New System.Drawing.Point(30, 171)
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.Size = New System.Drawing.Size(278, 26)
        Me.txt_surname.TabIndex = 9
        '
        'lbl_surname
        '
        Me.lbl_surname.AutoSize = True
        Me.lbl_surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_surname.Location = New System.Drawing.Point(24, 151)
        Me.lbl_surname.Name = "lbl_surname"
        Me.lbl_surname.Size = New System.Drawing.Size(114, 17)
        Me.lbl_surname.TabIndex = 8
        Me.lbl_surname.Text = "Apellido Materno"
        '
        'gb_sexo
        '
        Me.gb_sexo.Controls.Add(Me.rb_femenino)
        Me.gb_sexo.Controls.Add(Me.rb_masculino)
        Me.gb_sexo.Location = New System.Drawing.Point(46, 213)
        Me.gb_sexo.Name = "gb_sexo"
        Me.gb_sexo.Size = New System.Drawing.Size(138, 91)
        Me.gb_sexo.TabIndex = 10
        Me.gb_sexo.TabStop = False
        Me.gb_sexo.Text = "Sexo"
        '
        'rb_femenino
        '
        Me.rb_femenino.AutoSize = True
        Me.rb_femenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rb_femenino.Location = New System.Drawing.Point(18, 53)
        Me.rb_femenino.Name = "rb_femenino"
        Me.rb_femenino.Size = New System.Drawing.Size(88, 21)
        Me.rb_femenino.TabIndex = 1
        Me.rb_femenino.TabStop = True
        Me.rb_femenino.Text = "Femenino"
        Me.rb_femenino.UseVisualStyleBackColor = True
        '
        'rb_masculino
        '
        Me.rb_masculino.AutoSize = True
        Me.rb_masculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rb_masculino.Location = New System.Drawing.Point(19, 26)
        Me.rb_masculino.Name = "rb_masculino"
        Me.rb_masculino.Size = New System.Drawing.Size(89, 21)
        Me.rb_masculino.TabIndex = 0
        Me.rb_masculino.TabStop = True
        Me.rb_masculino.Text = "Masculino"
        Me.rb_masculino.UseVisualStyleBackColor = True
        '
        'nd_age
        '
        Me.nd_age.Location = New System.Drawing.Point(211, 259)
        Me.nd_age.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.nd_age.Name = "nd_age"
        Me.nd_age.Size = New System.Drawing.Size(80, 26)
        Me.nd_age.TabIndex = 11
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_age.Location = New System.Drawing.Point(208, 239)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(41, 17)
        Me.lbl_age.TabIndex = 12
        Me.lbl_age.Text = "Edad"
        '
        'dt_date
        '
        Me.dt_date.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption
        Me.dt_date.Location = New System.Drawing.Point(360, 40)
        Me.dt_date.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(262, 26)
        Me.dt_date.TabIndex = 13
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_date.Location = New System.Drawing.Point(351, 20)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(110, 17)
        Me.lbl_date.TabIndex = 14
        Me.lbl_date.Text = "Fecha de Salida"
        '
        'cb_passengers
        '
        Me.cb_passengers.FormattingEnabled = True
        Me.cb_passengers.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb_passengers.Location = New System.Drawing.Point(27, 341)
        Me.cb_passengers.Name = "cb_passengers"
        Me.cb_passengers.Size = New System.Drawing.Size(121, 28)
        Me.cb_passengers.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Boletos"
        '
        'gb_departure
        '
        Me.gb_departure.Controls.Add(Me.lbl_departure_city)
        Me.gb_departure.Controls.Add(Me.cb_departure_city)
        Me.gb_departure.Controls.Add(Me.lbl_departure_state)
        Me.gb_departure.Controls.Add(Me.cb_departure_state)
        Me.gb_departure.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gb_departure.Location = New System.Drawing.Point(354, 86)
        Me.gb_departure.Name = "gb_departure"
        Me.gb_departure.Size = New System.Drawing.Size(329, 90)
        Me.gb_departure.TabIndex = 17
        Me.gb_departure.TabStop = False
        Me.gb_departure.Text = "Salida"
        '
        'lbl_departure_city
        '
        Me.lbl_departure_city.AutoSize = True
        Me.lbl_departure_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_departure_city.Location = New System.Drawing.Point(165, 26)
        Me.lbl_departure_city.Name = "lbl_departure_city"
        Me.lbl_departure_city.Size = New System.Drawing.Size(52, 17)
        Me.lbl_departure_city.TabIndex = 22
        Me.lbl_departure_city.Text = "Ciudad"
        '
        'cb_departure_city
        '
        Me.cb_departure_city.FormattingEnabled = True
        Me.cb_departure_city.Location = New System.Drawing.Point(173, 46)
        Me.cb_departure_city.Name = "cb_departure_city"
        Me.cb_departure_city.Size = New System.Drawing.Size(121, 24)
        Me.cb_departure_city.TabIndex = 21
        '
        'lbl_departure_state
        '
        Me.lbl_departure_state.AutoSize = True
        Me.lbl_departure_state.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_departure_state.Location = New System.Drawing.Point(15, 26)
        Me.lbl_departure_state.Name = "lbl_departure_state"
        Me.lbl_departure_state.Size = New System.Drawing.Size(52, 17)
        Me.lbl_departure_state.TabIndex = 20
        Me.lbl_departure_state.Text = "Estado"
        '
        'cb_departure_state
        '
        Me.cb_departure_state.FormattingEnabled = True
        Me.cb_departure_state.Items.AddRange(New Object() {"Coahuila", "Nuevo Leon"})
        Me.cb_departure_state.Location = New System.Drawing.Point(23, 46)
        Me.cb_departure_state.Name = "cb_departure_state"
        Me.cb_departure_state.Size = New System.Drawing.Size(121, 24)
        Me.cb_departure_state.TabIndex = 19
        '
        'gb_destination
        '
        Me.gb_destination.Controls.Add(Me.lbl_destination_city)
        Me.gb_destination.Controls.Add(Me.cb_destination_city)
        Me.gb_destination.Controls.Add(Me.lbl_destination_state)
        Me.gb_destination.Controls.Add(Me.cb_destination_state)
        Me.gb_destination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gb_destination.Location = New System.Drawing.Point(354, 195)
        Me.gb_destination.Name = "gb_destination"
        Me.gb_destination.Size = New System.Drawing.Size(329, 90)
        Me.gb_destination.TabIndex = 23
        Me.gb_destination.TabStop = False
        Me.gb_destination.Text = "Destino"
        '
        'lbl_destination_city
        '
        Me.lbl_destination_city.AutoSize = True
        Me.lbl_destination_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_destination_city.Location = New System.Drawing.Point(165, 26)
        Me.lbl_destination_city.Name = "lbl_destination_city"
        Me.lbl_destination_city.Size = New System.Drawing.Size(52, 17)
        Me.lbl_destination_city.TabIndex = 22
        Me.lbl_destination_city.Text = "Ciudad"
        '
        'cb_destination_city
        '
        Me.cb_destination_city.FormattingEnabled = True
        Me.cb_destination_city.Location = New System.Drawing.Point(173, 46)
        Me.cb_destination_city.Name = "cb_destination_city"
        Me.cb_destination_city.Size = New System.Drawing.Size(121, 24)
        Me.cb_destination_city.TabIndex = 21
        '
        'lbl_destination_state
        '
        Me.lbl_destination_state.AutoSize = True
        Me.lbl_destination_state.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_destination_state.Location = New System.Drawing.Point(15, 26)
        Me.lbl_destination_state.Name = "lbl_destination_state"
        Me.lbl_destination_state.Size = New System.Drawing.Size(52, 17)
        Me.lbl_destination_state.TabIndex = 20
        Me.lbl_destination_state.Text = "Estado"
        '
        'cb_destination_state
        '
        Me.cb_destination_state.FormattingEnabled = True
        Me.cb_destination_state.Items.AddRange(New Object() {"Coahuila", "Nuevo Leon"})
        Me.cb_destination_state.Location = New System.Drawing.Point(23, 46)
        Me.cb_destination_state.Name = "cb_destination_state"
        Me.cb_destination_state.Size = New System.Drawing.Size(121, 24)
        Me.cb_destination_state.TabIndex = 19
        '
        'lbl_cost
        '
        Me.lbl_cost.AutoSize = True
        Me.lbl_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_cost.Location = New System.Drawing.Point(590, 341)
        Me.lbl_cost.Name = "lbl_cost"
        Me.lbl_cost.Size = New System.Drawing.Size(0, 20)
        Me.lbl_cost.TabIndex = 25
        '
        'lbl_hold_cost
        '
        Me.lbl_hold_cost.AutoSize = True
        Me.lbl_hold_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_hold_cost.Location = New System.Drawing.Point(518, 341)
        Me.lbl_hold_cost.Name = "lbl_hold_cost"
        Me.lbl_hold_cost.Size = New System.Drawing.Size(66, 20)
        Me.lbl_hold_cost.TabIndex = 26
        Me.lbl_hold_cost.Text = "Costo: "
        '
        'bttn_print
        '
        Me.bttn_print.Location = New System.Drawing.Point(522, 398)
        Me.bttn_print.Name = "bttn_print"
        Me.bttn_print.Size = New System.Drawing.Size(140, 40)
        Me.bttn_print.TabIndex = 27
        Me.bttn_print.Text = "Generar Boleto"
        Me.bttn_print.UseVisualStyleBackColor = True
        '
        'pic_destination
        '
        Me.pic_destination.Location = New System.Drawing.Point(183, 321)
        Me.pic_destination.Name = "pic_destination"
        Me.pic_destination.Size = New System.Drawing.Size(315, 179)
        Me.pic_destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_destination.TabIndex = 24
        Me.pic_destination.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 512)
        Me.Controls.Add(Me.bttn_print)
        Me.Controls.Add(Me.lbl_hold_cost)
        Me.Controls.Add(Me.lbl_cost)
        Me.Controls.Add(Me.pic_destination)
        Me.Controls.Add(Me.gb_destination)
        Me.Controls.Add(Me.gb_departure)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_passengers)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.dt_date)
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.nd_age)
        Me.Controls.Add(Me.gb_sexo)
        Me.Controls.Add(Me.txt_surname)
        Me.Controls.Add(Me.lbl_surname)
        Me.Controls.Add(Me.txt_lastname)
        Me.Controls.Add(Me.lbl_lastname)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.gb_sexo.ResumeLayout(False)
        Me.gb_sexo.PerformLayout()
        CType(Me.nd_age, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_departure.ResumeLayout(False)
        Me.gb_departure.PerformLayout()
        Me.gb_destination.ResumeLayout(False)
        Me.gb_destination.PerformLayout()
        CType(Me.pic_destination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents txt_surname As TextBox
    Friend WithEvents lbl_surname As Label
    Friend WithEvents gb_sexo As GroupBox
    Friend WithEvents rb_femenino As RadioButton
    Friend WithEvents rb_masculino As RadioButton
    Friend WithEvents nd_age As NumericUpDown
    Friend WithEvents lbl_age As Label
    Friend WithEvents dt_date As DateTimePicker
    Friend WithEvents lbl_date As Label
    Friend WithEvents cb_passengers As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gb_departure As GroupBox
    Friend WithEvents lbl_departure_city As Label
    Friend WithEvents cb_departure_city As ComboBox
    Friend WithEvents lbl_departure_state As Label
    Friend WithEvents cb_departure_state As ComboBox
    Friend WithEvents gb_destination As GroupBox
    Friend WithEvents lbl_destination_city As Label
    Friend WithEvents cb_destination_city As ComboBox
    Friend WithEvents lbl_destination_state As Label
    Friend WithEvents cb_destination_state As ComboBox
    Friend WithEvents pic_destination As PictureBox
    Friend WithEvents lbl_cost As Label
    Friend WithEvents lbl_hold_cost As Label
    Friend WithEvents bttn_print As Button
    Friend WithEvents lbl_lastname As Label
End Class
