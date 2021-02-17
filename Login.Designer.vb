<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.bttn_login = New System.Windows.Forms.Button()
        Me.pic_login = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.lbl_pwd = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_error = New System.Windows.Forms.Label()
        CType(Me.pic_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttn_login
        '
        Me.bttn_login.BackColor = System.Drawing.Color.PaleGreen
        Me.bttn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bttn_login.Location = New System.Drawing.Point(397, 237)
        Me.bttn_login.Name = "bttn_login"
        Me.bttn_login.Size = New System.Drawing.Size(140, 40)
        Me.bttn_login.TabIndex = 0
        Me.bttn_login.Text = "Ingresar"
        Me.bttn_login.UseVisualStyleBackColor = False
        '
        'pic_login
        '
        Me.pic_login.Image = Global.Autobuses.My.Resources.Resources.side_img
        Me.pic_login.Location = New System.Drawing.Point(34, 61)
        Me.pic_login.Name = "pic_login"
        Me.pic_login.Size = New System.Drawing.Size(245, 214)
        Me.pic_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_login.TabIndex = 1
        Me.pic_login.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Autobuses.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(291, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_user.Location = New System.Drawing.Point(351, 86)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(68, 20)
        Me.lbl_user.TabIndex = 3
        Me.lbl_user.Text = "Usuario:"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_user.Location = New System.Drawing.Point(449, 83)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(100, 26)
        Me.txt_user.TabIndex = 4
        '
        'txt_pwd
        '
        Me.txt_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_pwd.Location = New System.Drawing.Point(449, 167)
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.Size = New System.Drawing.Size(100, 26)
        Me.txt_pwd.TabIndex = 7
        '
        'lbl_pwd
        '
        Me.lbl_pwd.AutoSize = True
        Me.lbl_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_pwd.Location = New System.Drawing.Point(351, 167)
        Me.lbl_pwd.Name = "lbl_pwd"
        Me.lbl_pwd.Size = New System.Drawing.Size(96, 20)
        Me.lbl_pwd.TabIndex = 6
        Me.lbl_pwd.Text = "Contraseña:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Autobuses.My.Resources.Resources.key
        Me.PictureBox3.Location = New System.Drawing.Point(291, 154)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'txt_error
        '
        Me.txt_error.AutoSize = True
        Me.txt_error.Location = New System.Drawing.Point(304, 295)
        Me.txt_error.Name = "txt_error"
        Me.txt_error.Size = New System.Drawing.Size(0, 13)
        Me.txt_error.TabIndex = 8
        '
        'Login
        '
        Me.ClientSize = New System.Drawing.Size(600, 341)
        Me.Controls.Add(Me.txt_error)
        Me.Controls.Add(Me.txt_pwd)
        Me.Controls.Add(Me.lbl_pwd)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pic_login)
        Me.Controls.Add(Me.bttn_login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.pic_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttn_login As Button
    Friend WithEvents pic_login As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents lbl_pwd As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_error As Label
End Class
