<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ticket))
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_company = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.pic_destination = New System.Windows.Forms.PictureBox()
        Me.lbl_holder_data = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.Label()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_destination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_logo
        '
        Me.pic_logo.Image = Global.Autobuses.My.Resources.Resources.Logo
        Me.pic_logo.Location = New System.Drawing.Point(3, 2)
        Me.pic_logo.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(438, 188)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 0
        Me.pic_logo.TabStop = False
        '
        'lbl_company
        '
        Me.lbl_company.AutoSize = True
        Me.lbl_company.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_company.Location = New System.Drawing.Point(448, 29)
        Me.lbl_company.Name = "lbl_company"
        Me.lbl_company.Size = New System.Drawing.Size(167, 24)
        Me.lbl_company.TabIndex = 1
        Me.lbl_company.Text = "Grupo Camiones"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_address.Location = New System.Drawing.Point(466, 62)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(394, 20)
        Me.lbl_address.TabIndex = 2
        Me.lbl_address.Text = "Luis Echeverria y Libertad Sn, Bellavista, Saltillo"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_phone.Location = New System.Drawing.Point(466, 97)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(224, 20)
        Me.lbl_phone.TabIndex = 3
        Me.lbl_phone.Text = "Teléfono: 01 844 893 1263"
        '
        'pic_destination
        '
        Me.pic_destination.Location = New System.Drawing.Point(463, 229)
        Me.pic_destination.Name = "pic_destination"
        Me.pic_destination.Size = New System.Drawing.Size(435, 245)
        Me.pic_destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_destination.TabIndex = 4
        Me.pic_destination.TabStop = False
        '
        'lbl_holder_data
        '
        Me.lbl_holder_data.AutoSize = True
        Me.lbl_holder_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_holder_data.Location = New System.Drawing.Point(81, 257)
        Me.lbl_holder_data.Name = "lbl_holder_data"
        Me.lbl_holder_data.Size = New System.Drawing.Size(128, 200)
        Me.lbl_holder_data.TabIndex = 5
        Me.lbl_holder_data.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apellidos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sexo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edad:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No. Boletos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fecha de Salida:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salida:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Desti" &
    "no:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precio:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total:"
        '
        'txt_data
        '
        Me.txt_data.AutoSize = True
        Me.txt_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data.Location = New System.Drawing.Point(215, 257)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(0, 20)
        Me.txt_data.TabIndex = 6
        '
        'Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 554)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.lbl_holder_data)
        Me.Controls.Add(Me.pic_destination)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.lbl_company)
        Me.Controls.Add(Me.pic_logo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ticket"
        Me.Text = "Ticket"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_destination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_company As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_phone As Label
    Friend WithEvents pic_destination As PictureBox
    Friend WithEvents lbl_holder_data As Label
    Friend WithEvents txt_data As Label
End Class
