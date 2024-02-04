<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.btn_sellDetail = New System.Windows.Forms.Button()
        Me.btn_sell = New System.Windows.Forms.Button()
        Me.btn_inventory = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Controls.Add(Me.btn_about)
        Me.Panel1.Controls.Add(Me.btn_sellDetail)
        Me.Panel1.Controls.Add(Me.btn_sell)
        Me.Panel1.Controls.Add(Me.btn_inventory)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 682)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 108)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "JUNKYARD " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MANAGEMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SYSTEM"
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_home.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_home.Location = New System.Drawing.Point(53, 221)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(147, 43)
        Me.btn_home.TabIndex = 9
        Me.btn_home.Text = "HOME"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'btn_about
        '
        Me.btn_about.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_about.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_about.Location = New System.Drawing.Point(53, 610)
        Me.btn_about.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(147, 43)
        Me.btn_about.TabIndex = 8
        Me.btn_about.Text = "ABOUT"
        Me.btn_about.UseVisualStyleBackColor = False
        '
        'btn_sellDetail
        '
        Me.btn_sellDetail.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_sellDetail.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_sellDetail.Location = New System.Drawing.Point(53, 545)
        Me.btn_sellDetail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_sellDetail.Name = "btn_sellDetail"
        Me.btn_sellDetail.Size = New System.Drawing.Size(147, 50)
        Me.btn_sellDetail.TabIndex = 7
        Me.btn_sellDetail.Text = "SELL DETAILS"
        Me.btn_sellDetail.UseVisualStyleBackColor = False
        '
        'btn_sell
        '
        Me.btn_sell.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_sell.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_sell.Location = New System.Drawing.Point(53, 433)
        Me.btn_sell.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_sell.Name = "btn_sell"
        Me.btn_sell.Size = New System.Drawing.Size(147, 43)
        Me.btn_sell.TabIndex = 7
        Me.btn_sell.Text = "SELL"
        Me.btn_sell.UseVisualStyleBackColor = False
        '
        'btn_inventory
        '
        Me.btn_inventory.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_inventory.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_inventory.Location = New System.Drawing.Point(53, 486)
        Me.btn_inventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_inventory.Name = "btn_inventory"
        Me.btn_inventory.Size = New System.Drawing.Size(147, 43)
        Me.btn_inventory.TabIndex = 6
        Me.btn_inventory.Text = "INVENTORY"
        Me.btn_inventory.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_delete.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.Location = New System.Drawing.Point(53, 378)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(147, 43)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_update.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_update.Location = New System.Drawing.Point(53, 326)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(147, 43)
        Me.btn_update.TabIndex = 4
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_add.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_add.Location = New System.Drawing.Point(53, 273)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(147, 43)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(53, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 101)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(10, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 45)
        Me.Label1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(250, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1532, 682)
        Me.Panel2.TabIndex = 3
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1782, 682)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_about As Button
    Friend WithEvents btn_sell As Button
    Friend WithEvents btn_inventory As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_sellDetail As Button
End Class
