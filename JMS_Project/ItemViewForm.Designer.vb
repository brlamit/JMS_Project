<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemViewForm
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_itemid = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
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
        Me.JMSDataSet5 = New JMS_Project.JMSDataSet5()
        Me.JunkDataTableAdapter = New JMS_Project.JMSDataSet5TableAdapters.JunkDataTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JunkDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JMSDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label18.Location = New System.Drawing.Point(593, 330)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(275, 41)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "VIEW INVENTORY"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Controls.Add(Me.txt_itemid)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(435, 397)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(562, 211)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VIEW INVENTORY"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_search.Location = New System.Drawing.Point(222, 132)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(111, 35)
        Me.btn_search.TabIndex = 16
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_itemid
        '
        Me.txt_itemid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_itemid.Location = New System.Drawing.Point(274, 75)
        Me.txt_itemid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_itemid.Name = "txt_itemid"
        Me.txt_itemid.Size = New System.Drawing.Size(250, 30)
        Me.txt_itemid.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(62, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 28)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Item ID"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.SAddressDataGridViewTextBoxColumn, Me.SPhoneDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.BuyDateDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.JunkDataBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(1522, 302)
        Me.DataGridView2.TabIndex = 13
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
        Me.SupplierNameDataGridViewTextBoxColumn.Width = 125
        '
        'SAddressDataGridViewTextBoxColumn
        '
        Me.SAddressDataGridViewTextBoxColumn.DataPropertyName = "S_Address"
        Me.SAddressDataGridViewTextBoxColumn.HeaderText = "S_Address"
        Me.SAddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SAddressDataGridViewTextBoxColumn.Name = "SAddressDataGridViewTextBoxColumn"
        Me.SAddressDataGridViewTextBoxColumn.Width = 125
        '
        'SPhoneDataGridViewTextBoxColumn
        '
        Me.SPhoneDataGridViewTextBoxColumn.DataPropertyName = "S_Phone"
        Me.SPhoneDataGridViewTextBoxColumn.HeaderText = "S_Phone"
        Me.SPhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SPhoneDataGridViewTextBoxColumn.Name = "SPhoneDataGridViewTextBoxColumn"
        Me.SPhoneDataGridViewTextBoxColumn.Width = 125
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.Width = 125
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 125
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        Me.RateDataGridViewTextBoxColumn.Width = 125
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.Width = 125
        '
        'BuyDateDataGridViewTextBoxColumn
        '
        Me.BuyDateDataGridViewTextBoxColumn.DataPropertyName = "Buy_Date"
        Me.BuyDateDataGridViewTextBoxColumn.HeaderText = "Buy_Date"
        Me.BuyDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BuyDateDataGridViewTextBoxColumn.Name = "BuyDateDataGridViewTextBoxColumn"
        Me.BuyDateDataGridViewTextBoxColumn.Width = 125
        '
        'JunkDataBindingSource
        '
        Me.JunkDataBindingSource.DataMember = "JunkData"
        Me.JunkDataBindingSource.DataSource = Me.JMSDataSet5
        '
        'JMSDataSet5
        '
        Me.JMSDataSet5.DataSetName = "JMSDataSet5"
        Me.JMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JunkDataTableAdapter
        '
        Me.JunkDataTableAdapter.ClearBeforeFill = True
        '
        'ItemViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1532, 682)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemViewForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JunkDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JMSDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_itemid As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents JMSDataSet5 As JMSDataSet5
    Friend WithEvents JunkDataBindingSource As BindingSource
    Friend WithEvents JunkDataTableAdapter As JMSDataSet5TableAdapters.JunkDataTableAdapter
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
