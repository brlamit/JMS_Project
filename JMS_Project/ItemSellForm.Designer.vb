<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ItemSellForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_Camount = New System.Windows.Forms.TextBox()
        Me.txt_Ramount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Tamount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Srate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Squantity = New System.Windows.Forms.TextBox()
        Me.btn_sell = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JunkDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JMSDataSet1 = New JMS_Project.JMSDataSet1()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_itemrate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_itemquantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_itemname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_ItemID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.JunkDataTableAdapter = New JMS_Project.JMSDataSet1TableAdapters.JunkDataTableAdapter()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JunkDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JMSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label28.Location = New System.Drawing.Point(646, 330)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(185, 41)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "SALE ITEMS"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox5.Controls.Add(Me.txt_Camount)
        Me.GroupBox5.Controls.Add(Me.txt_Ramount)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txt_Tamount)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txt_Srate)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.txt_Squantity)
        Me.GroupBox5.Controls.Add(Me.btn_sell)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.Location = New System.Drawing.Point(994, 373)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(515, 298)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SALE ITEMS"
        '
        'txt_Camount
        '
        Me.txt_Camount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Camount.Location = New System.Drawing.Point(200, 214)
        Me.txt_Camount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Camount.Name = "txt_Camount"
        Me.txt_Camount.Size = New System.Drawing.Size(250, 30)
        Me.txt_Camount.TabIndex = 25
        '
        'txt_Ramount
        '
        Me.txt_Ramount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Ramount.Location = New System.Drawing.Point(200, 172)
        Me.txt_Ramount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Ramount.Name = "txt_Ramount"
        Me.txt_Ramount.Size = New System.Drawing.Size(250, 30)
        Me.txt_Ramount.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 28)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Change Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Received Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 28)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Total Amount"
        '
        'txt_Tamount
        '
        Me.txt_Tamount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Tamount.Location = New System.Drawing.Point(200, 124)
        Me.txt_Tamount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Tamount.Name = "txt_Tamount"
        Me.txt_Tamount.Size = New System.Drawing.Size(250, 30)
        Me.txt_Tamount.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 28)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Sell Rate"
        '
        'txt_Srate
        '
        Me.txt_Srate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Srate.Location = New System.Drawing.Point(200, 76)
        Me.txt_Srate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Srate.Name = "txt_Srate"
        Me.txt_Srate.Size = New System.Drawing.Size(250, 30)
        Me.txt_Srate.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 28)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Quantity"
        '
        'txt_Squantity
        '
        Me.txt_Squantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Squantity.Location = New System.Drawing.Point(200, 27)
        Me.txt_Squantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Squantity.Name = "txt_Squantity"
        Me.txt_Squantity.Size = New System.Drawing.Size(250, 30)
        Me.txt_Squantity.TabIndex = 19
        '
        'btn_sell
        '
        Me.btn_sell.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_sell.Location = New System.Drawing.Point(92, 259)
        Me.btn_sell.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_sell.Name = "btn_sell"
        Me.btn_sell.Size = New System.Drawing.Size(111, 35)
        Me.btn_sell.TabIndex = 16
        Me.btn_sell.Text = "Sell"
        Me.btn_sell.UseVisualStyleBackColor = False
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.SAddressDataGridViewTextBoxColumn, Me.SPhoneDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.BuyDateDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.JunkDataBindingSource
        Me.DataGridView5.Location = New System.Drawing.Point(4, 7)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 29
        Me.DataGridView5.Size = New System.Drawing.Size(1524, 311)
        Me.DataGridView5.TabIndex = 14
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.Width = 125
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.Width = 200
        '
        'SAddressDataGridViewTextBoxColumn
        '
        Me.SAddressDataGridViewTextBoxColumn.DataPropertyName = "S_Address"
        Me.SAddressDataGridViewTextBoxColumn.HeaderText = "S_Address"
        Me.SAddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SAddressDataGridViewTextBoxColumn.Name = "SAddressDataGridViewTextBoxColumn"
        Me.SAddressDataGridViewTextBoxColumn.Width = 190
        '
        'SPhoneDataGridViewTextBoxColumn
        '
        Me.SPhoneDataGridViewTextBoxColumn.DataPropertyName = "S_Phone"
        Me.SPhoneDataGridViewTextBoxColumn.HeaderText = "S_Phone"
        Me.SPhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SPhoneDataGridViewTextBoxColumn.Name = "SPhoneDataGridViewTextBoxColumn"
        Me.SPhoneDataGridViewTextBoxColumn.Width = 160
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.Width = 190
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 135
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        Me.RateDataGridViewTextBoxColumn.Width = 135
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.Width = 135
        '
        'BuyDateDataGridViewTextBoxColumn
        '
        Me.BuyDateDataGridViewTextBoxColumn.DataPropertyName = "Buy_Date"
        Me.BuyDateDataGridViewTextBoxColumn.HeaderText = "Buy_Date"
        Me.BuyDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BuyDateDataGridViewTextBoxColumn.Name = "BuyDateDataGridViewTextBoxColumn"
        Me.BuyDateDataGridViewTextBoxColumn.Width = 200
        '
        'JunkDataBindingSource
        '
        Me.JunkDataBindingSource.DataMember = "JunkData"
        Me.JunkDataBindingSource.DataSource = Me.JMSDataSet1
        '
        'JMSDataSet1
        '
        Me.JMSDataSet1.DataSetName = "JMSDataSet1"
        Me.JMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.txt_itemrate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_itemquantity)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_itemname)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(457, 373)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(515, 298)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM DETEILS"
        '
        'txt_itemrate
        '
        Me.txt_itemrate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_itemrate.Location = New System.Drawing.Point(180, 197)
        Me.txt_itemrate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_itemrate.Name = "txt_itemrate"
        Me.txt_itemrate.Size = New System.Drawing.Size(250, 30)
        Me.txt_itemrate.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 28)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Item ID"
        '
        'txt_itemquantity
        '
        Me.txt_itemquantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_itemquantity.Location = New System.Drawing.Point(180, 149)
        Me.txt_itemquantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_itemquantity.Name = "txt_itemquantity"
        Me.txt_itemquantity.Size = New System.Drawing.Size(250, 30)
        Me.txt_itemquantity.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 28)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Buy Rate"
        '
        'txt_itemname
        '
        Me.txt_itemname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_itemname.Location = New System.Drawing.Point(180, 101)
        Me.txt_itemname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(250, 30)
        Me.txt_itemname.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 28)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Quantity"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_id.Location = New System.Drawing.Point(180, 52)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(250, 30)
        Me.txt_id.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 28)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Item Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.txt_ItemID)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 373)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(411, 298)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEARCH ITEMS"
        '
        'txt_ItemID
        '
        Me.txt_ItemID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ItemID.Location = New System.Drawing.Point(146, 105)
        Me.txt_ItemID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ItemID.Name = "txt_ItemID"
        Me.txt_ItemID.Size = New System.Drawing.Size(250, 30)
        Me.txt_ItemID.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 28)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Item ID"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_search.Location = New System.Drawing.Point(110, 192)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(111, 35)
        Me.btn_search.TabIndex = 16
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'JunkDataTableAdapter
        '
        Me.JunkDataTableAdapter.ClearBeforeFill = True
        '
        'ItemSellForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1528, 723)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DataGridView5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemSellForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemSellForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JunkDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_sell As Button
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents txt_Ramount As TextBox
    Friend WithEvents txt_Tamount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Srate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Squantity As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_itemrate As TextBox
    Friend WithEvents txt_itemquantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_itemname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_ItemID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_Camount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents JMSDataSet1 As JMSDataSet1
    Friend WithEvents JunkDataBindingSource As BindingSource
    Friend WithEvents JunkDataTableAdapter As JMSDataSet1TableAdapters.JunkDataTableAdapter
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
