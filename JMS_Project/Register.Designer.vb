<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox_Mpass = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Upass = New System.Windows.Forms.CheckBox()
        Me.dob_picker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.RadioButton_female = New System.Windows.Forms.RadioButton()
        Me.RadioButton_male = New System.Windows.Forms.RadioButton()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_phoneno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Upassword = New System.Windows.Forms.TextBox()
        Me.txt_maskedpass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.txt_firstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(432, 3)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 30)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox_Mpass
        '
        Me.CheckBox_Mpass.AutoSize = True
        Me.CheckBox_Mpass.Location = New System.Drawing.Point(385, 362)
        Me.CheckBox_Mpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox_Mpass.Name = "CheckBox_Mpass"
        Me.CheckBox_Mpass.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox_Mpass.TabIndex = 72
        Me.CheckBox_Mpass.UseVisualStyleBackColor = True
        '
        'CheckBox_Upass
        '
        Me.CheckBox_Upass.AutoSize = True
        Me.CheckBox_Upass.Location = New System.Drawing.Point(194, 363)
        Me.CheckBox_Upass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox_Upass.Name = "CheckBox_Upass"
        Me.CheckBox_Upass.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox_Upass.TabIndex = 71
        Me.CheckBox_Upass.UseVisualStyleBackColor = True
        '
        'dob_picker
        '
        Me.dob_picker.Location = New System.Drawing.Point(228, 415)
        Me.dob_picker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dob_picker.Name = "dob_picker"
        Me.dob_picker.Size = New System.Drawing.Size(180, 22)
        Me.dob_picker.TabIndex = 70
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(136, 546)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 31)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_register.ForeColor = System.Drawing.Color.White
        Me.btn_register.Location = New System.Drawing.Point(135, 511)
        Me.btn_register.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(167, 31)
        Me.btn_register.TabIndex = 54
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'RadioButton_female
        '
        Me.RadioButton_female.AutoSize = True
        Me.RadioButton_female.Location = New System.Drawing.Point(106, 415)
        Me.RadioButton_female.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton_female.Name = "RadioButton_female"
        Me.RadioButton_female.Size = New System.Drawing.Size(74, 20)
        Me.RadioButton_female.TabIndex = 69
        Me.RadioButton_female.TabStop = True
        Me.RadioButton_female.Text = "Female"
        Me.RadioButton_female.UseVisualStyleBackColor = True
        '
        'RadioButton_male
        '
        Me.RadioButton_male.AutoSize = True
        Me.RadioButton_male.Location = New System.Drawing.Point(37, 415)
        Me.RadioButton_male.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton_male.Name = "RadioButton_male"
        Me.RadioButton_male.Size = New System.Drawing.Size(58, 20)
        Me.RadioButton_male.TabIndex = 68
        Me.RadioButton_male.TabStop = True
        Me.RadioButton_male.Text = "Male"
        Me.RadioButton_male.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(228, 470)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(180, 22)
        Me.txt_email.TabIndex = 67
        '
        'txt_phoneno
        '
        Me.txt_phoneno.Location = New System.Drawing.Point(36, 471)
        Me.txt_phoneno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_phoneno.Name = "txt_phoneno"
        Me.txt_phoneno.Size = New System.Drawing.Size(180, 22)
        Me.txt_phoneno.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(229, 435)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 28)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "E-mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(34, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 28)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Phone No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(229, 383)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 28)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Date Of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(37, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 28)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Gender"
        '
        'txt_Upassword
        '
        Me.txt_Upassword.Location = New System.Drawing.Point(37, 359)
        Me.txt_Upassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Upassword.Name = "txt_Upassword"
        Me.txt_Upassword.Size = New System.Drawing.Size(180, 22)
        Me.txt_Upassword.TabIndex = 61
        Me.txt_Upassword.UseSystemPasswordChar = True
        '
        'txt_maskedpass
        '
        Me.txt_maskedpass.Location = New System.Drawing.Point(228, 358)
        Me.txt_maskedpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_maskedpass.Name = "txt_maskedpass"
        Me.txt_maskedpass.Size = New System.Drawing.Size(180, 22)
        Me.txt_maskedpass.TabIndex = 60
        Me.txt_maskedpass.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(229, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 28)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Confirm Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(37, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 28)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Password"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(229, 303)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(180, 22)
        Me.txt_address.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(228, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 28)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Address"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(37, 305)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(180, 22)
        Me.txt_username.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(37, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 28)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Username"
        '
        'txt_lastname
        '
        Me.txt_lastname.Location = New System.Drawing.Point(229, 248)
        Me.txt_lastname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(180, 22)
        Me.txt_lastname.TabIndex = 51
        '
        'txt_firstname
        '
        Me.txt_firstname.Location = New System.Drawing.Point(37, 248)
        Me.txt_firstname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.Size = New System.Drawing.Size(180, 22)
        Me.txt_firstname.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(229, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(37, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 28)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "First Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 67)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 45)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Registration Form"
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(480, 600)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBox_Mpass)
        Me.Controls.Add(Me.CheckBox_Upass)
        Me.Controls.Add(Me.dob_picker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.RadioButton_female)
        Me.Controls.Add(Me.RadioButton_male)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_phoneno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Upassword)
        Me.Controls.Add(Me.txt_maskedpass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_lastname)
        Me.Controls.Add(Me.txt_firstname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox_Mpass As CheckBox
    Friend WithEvents CheckBox_Upass As CheckBox
    Friend WithEvents dob_picker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents RadioButton_female As RadioButton
    Friend WithEvents RadioButton_male As RadioButton
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_phoneno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Upassword As TextBox
    Friend WithEvents txt_maskedpass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents txt_firstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
