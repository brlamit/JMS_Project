<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reset_Password))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CheckBox_Upass = New System.Windows.Forms.CheckBox()
        Me.txt_Upassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox_Mpass = New System.Windows.Forms.CheckBox()
        Me.txt_maskedpass = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(68, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 50)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Reset Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.CheckBox_Upass)
        Me.Panel2.Controls.Add(Me.txt_Upassword)
        Me.Panel2.Location = New System.Drawing.Point(59, 286)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 46)
        Me.Panel2.TabIndex = 62
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 62
        Me.PictureBox3.TabStop = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txt_Username)
        Me.Panel1.Location = New System.Drawing.Point(59, 181)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 46)
        Me.Panel1.TabIndex = 61
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
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
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btn_reset.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btn_reset.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_reset.Location = New System.Drawing.Point(57, 466)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(323, 46)
        Me.btn_reset.TabIndex = 63
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.CheckBox_Mpass)
        Me.Panel3.Controls.Add(Me.txt_maskedpass)
        Me.Panel3.Location = New System.Drawing.Point(59, 381)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 46)
        Me.Panel3.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'CheckBox_Mpass
        '
        Me.CheckBox_Mpass.AutoSize = True
        Me.CheckBox_Mpass.Location = New System.Drawing.Point(298, 18)
        Me.CheckBox_Mpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox_Mpass.Name = "CheckBox_Mpass"
        Me.CheckBox_Mpass.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox_Mpass.TabIndex = 1
        Me.CheckBox_Mpass.UseVisualStyleBackColor = True
        '
        'txt_maskedpass
        '
        Me.txt_maskedpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_maskedpass.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txt_maskedpass.Location = New System.Drawing.Point(60, 14)
        Me.txt_maskedpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_maskedpass.Name = "txt_maskedpass"
        Me.txt_maskedpass.Size = New System.Drawing.Size(261, 23)
        Me.txt_maskedpass.TabIndex = 4
        Me.txt_maskedpass.UseSystemPasswordChar = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(393, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 30)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(4, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 31)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(54, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(54, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(54, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 25)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Re-enter Password"
        '
        'Reset_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 560)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reset_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset_Password"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CheckBox_Upass As CheckBox
    Friend WithEvents txt_Upassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox_Mpass As CheckBox
    Friend WithEvents txt_maskedpass As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
