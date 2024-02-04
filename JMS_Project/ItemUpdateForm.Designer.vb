<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemupdateform
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ItemID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_itemrate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_itemquantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_itemname = New System.Windows.Forms.TextBox()
        Me.txt_supplierphone = New System.Windows.Forms.TextBox()
        Me.txt_supplieraddress = New System.Windows.Forms.TextBox()
        Me.txt_suppliername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.JMSDataSet = New JMS_Project.JMSDataSet()
        Me.JunkDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JunkDataTableAdapter = New JMS_Project.JMSDataSetTableAdapters.JunkDataTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JunkDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.JMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JunkDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JunkDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ItemID)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.txt_itemrate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_itemquantity)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_itemname)
        Me.GroupBox1.Controls.Add(Me.txt_supplierphone)
        Me.GroupBox1.Controls.Add(Me.txt_supplieraddress)
        Me.GroupBox1.Controls.Add(Me.txt_suppliername)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 374)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1429, 293)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UPDATE ITEMS"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_search.Location = New System.Drawing.Point(1046, 38)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(111, 41)
        Me.btn_search.TabIndex = 23
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Item ID"
        '
        'txt_ItemID
        '
        Me.txt_ItemID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ItemID.Location = New System.Drawing.Point(592, 38)
        Me.txt_ItemID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ItemID.Name = "txt_ItemID"
        Me.txt_ItemID.Size = New System.Drawing.Size(250, 30)
        Me.txt_ItemID.TabIndex = 20
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(201, 248)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 34)
        Me.DateTimePicker1.TabIndex = 18
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_refresh.Location = New System.Drawing.Point(1046, 194)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(111, 35)
        Me.btn_refresh.TabIndex = 17
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_update.Location = New System.Drawing.Point(1046, 118)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(111, 41)
        Me.btn_update.TabIndex = 16
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txt_itemrate
        '
        Me.txt_itemrate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_itemrate.Location = New System.Drawing.Point(647, 192)
        Me.txt_itemrate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_itemrate.Name = "txt_itemrate"
        Me.txt_itemrate.Size = New System.Drawing.Size(250, 30)
        Me.txt_itemrate.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(502, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Rate"
        '
        'txt_itemquantity
        '
        Me.txt_itemquantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_itemquantity.Location = New System.Drawing.Point(647, 144)
        Me.txt_itemquantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_itemquantity.Name = "txt_itemquantity"
        Me.txt_itemquantity.Size = New System.Drawing.Size(250, 30)
        Me.txt_itemquantity.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(502, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 28)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Quantity"
        '
        'txt_itemname
        '
        Me.txt_itemname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_itemname.Location = New System.Drawing.Point(647, 96)
        Me.txt_itemname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(250, 30)
        Me.txt_itemname.TabIndex = 9
        '
        'txt_supplierphone
        '
        Me.txt_supplierphone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_supplierphone.Location = New System.Drawing.Point(201, 196)
        Me.txt_supplierphone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_supplierphone.Name = "txt_supplierphone"
        Me.txt_supplierphone.Size = New System.Drawing.Size(250, 30)
        Me.txt_supplierphone.TabIndex = 8
        '
        'txt_supplieraddress
        '
        Me.txt_supplieraddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_supplieraddress.Location = New System.Drawing.Point(201, 148)
        Me.txt_supplieraddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_supplieraddress.Name = "txt_supplieraddress"
        Me.txt_supplieraddress.Size = New System.Drawing.Size(250, 30)
        Me.txt_supplieraddress.TabIndex = 7
        '
        'txt_suppliername
        '
        Me.txt_suppliername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_suppliername.Location = New System.Drawing.Point(201, 100)
        Me.txt_suppliername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_suppliername.Name = "txt_suppliername"
        Me.txt_suppliername.Size = New System.Drawing.Size(250, 30)
        Me.txt_suppliername.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Phone No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(502, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Item Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Supplier Name"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label27.Location = New System.Drawing.Point(544, 324)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(350, 35)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = " ITEMS UPDATE FORM"
        '
        'JMSDataSet
        '
        Me.JMSDataSet.DataSetName = "JMSDataSet"
        Me.JMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JunkDataBindingSource
        '
        Me.JunkDataBindingSource.DataMember = "JunkData"
        Me.JunkDataBindingSource.DataSource = Me.JMSDataSet
        '
        'JunkDataTableAdapter
        '
        Me.JunkDataTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DataGridView2.DataSource = Me.JunkDataBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(6, 7)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(1521, 306)
        Me.DataGridView2.TabIndex = 18
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Item_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item_ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Supplier_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Supplier_Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "S_Address"
        Me.DataGridViewTextBoxColumn2.HeaderText = "S_Address"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "S_Phone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "S_Phone"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Item_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Item_Name"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Rate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Rate"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Total_Amount"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total_Amount"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 180
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Buy_Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Buy_Date"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'JunkDataBindingSource1
        '
        Me.JunkDataBindingSource1.DataMember = "JunkData"
        Me.JunkDataBindingSource1.DataSource = Me.JMSDataSet
        '
        'itemupdateform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1532, 682)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label27)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "itemupdateform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "itemupdateform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.JMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JunkDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JunkDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_ItemID As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_itemrate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_itemquantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_itemname As TextBox
    Friend WithEvents txt_supplierphone As TextBox
    Friend WithEvents txt_supplieraddress As TextBox
    Friend WithEvents txt_suppliername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents JMSDataSet As JMSDataSet
    Friend WithEvents JunkDataBindingSource As BindingSource
    Friend WithEvents JunkDataTableAdapter As JMSDataSetTableAdapters.JunkDataTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents JunkDataBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Button
End Class
