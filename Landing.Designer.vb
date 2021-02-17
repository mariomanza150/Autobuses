<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Landing))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.bttn_go_login = New System.Windows.Forms.Button()
        Me.bttn_exit = New System.Windows.Forms.Button()
        Me.side_img = New System.Windows.Forms.PictureBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.side_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Image = Global.Autobuses.My.Resources.Resources.Logo
        Me.logo.Location = New System.Drawing.Point(38, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(549, 169)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'bttn_go_login
        '
        Me.bttn_go_login.BackColor = System.Drawing.Color.PaleGreen
        Me.bttn_go_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.bttn_go_login.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bttn_go_login.Location = New System.Drawing.Point(359, 229)
        Me.bttn_go_login.Name = "bttn_go_login"
        Me.bttn_go_login.Size = New System.Drawing.Size(140, 60)
        Me.bttn_go_login.TabIndex = 1
        Me.bttn_go_login.Text = "Entrar"
        Me.bttn_go_login.UseVisualStyleBackColor = False
        '
        'bttn_exit
        '
        Me.bttn_exit.BackColor = System.Drawing.Color.Pink
        Me.bttn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.bttn_exit.Location = New System.Drawing.Point(359, 320)
        Me.bttn_exit.Name = "bttn_exit"
        Me.bttn_exit.Size = New System.Drawing.Size(140, 60)
        Me.bttn_exit.TabIndex = 2
        Me.bttn_exit.Text = "Salir"
        Me.bttn_exit.UseVisualStyleBackColor = False
        '
        'side_img
        '
        Me.side_img.Image = Global.Autobuses.My.Resources.Resources.side_img
        Me.side_img.Location = New System.Drawing.Point(97, 219)
        Me.side_img.Name = "side_img"
        Me.side_img.Size = New System.Drawing.Size(183, 176)
        Me.side_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.side_img.TabIndex = 0
        Me.side_img.TabStop = False
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 407)
        Me.Controls.Add(Me.side_img)
        Me.Controls.Add(Me.bttn_exit)
        Me.Controls.Add(Me.bttn_go_login)
        Me.Controls.Add(Me.logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Landing"
        Me.Text = "Sistema de Boletos"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.side_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents bttn_go_login As Button
    Friend WithEvents bttn_exit As Button
    Friend WithEvents side_img As PictureBox
End Class
