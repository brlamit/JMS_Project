<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox_Upass = New System.Windows.Forms.CheckBox()
        Me.txt_Upassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnregister1 = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(136, 43)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 125)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(395, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 30)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_Username
        '
        Me.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Username.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txt_Username.Location = New System.Drawing.Point(58, 14)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(263, 23)
        Me.txt_Username.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.CheckBox_Upass)
        Me.Panel2.Controls.Add(Me.txt_Upassword)
        Me.Panel2.Location = New System.Drawing.Point(40, 318)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 46)
        Me.Panel2.TabIndex = 56
        '
        'CheckBox_Upass
        '
        Me.CheckBox_Upass.AutoSize = True
        Me.CheckBox_Upass.Location = New System.Drawing.Point(298, 18)
        Me.CheckBox_Upass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox_Upass.Name = "CheckBox_Upass"
        Me.CheckBox_Upass.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox_Upass.TabIndex = 1
        Me.CheckBox_Upass.UseVisualStyleBackColor = True
        '
        'txt_Upassword
        '
        Me.txt_Upassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Upassword.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txt_Upassword.Location = New System.Drawing.Point(60, 14)
        Me.txt_Upassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Upassword.Name = "txt_Upassword"
        Me.txt_Upassword.Size = New System.Drawing.Size(261, 23)
        Me.txt_Upassword.TabIndex = 4
        Me.txt_Upassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(149, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 41)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Sign In"
        '
        'btnregister1
        '
        Me.btnregister1.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btnregister1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnregister1.Location = New System.Drawing.Point(41, 466)
        Me.btnregister1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnregister1.Name = "btnregister1"
        Me.btnregister1.Size = New System.Drawing.Size(323, 40)
        Me.btnregister1.TabIndex = 58
        Me.btnregister1.Text = "Register"
        Me.btnregister1.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.Location = New System.Drawing.Point(41, 416)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(323, 46)
        Me.btnLogin.TabIndex = 57
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.txt_Username)
        Me.Panel1.Location = New System.Drawing.Point(40, 262)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 46)
        Me.Panel1.TabIndex = 55
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 560)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnregister1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckBox_Upass As CheckBox
    Friend WithEvents txt_Upassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnregister1 As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
End Class
