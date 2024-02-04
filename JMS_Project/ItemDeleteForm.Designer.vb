<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemDeleteForm
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
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_ItemID = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
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
        Me.JMSDataSet = New JMS_Project.JMSDataSet()
        Me.JunkDataTableAdapter = New JMS_Project.JMSDataSetTableAdapters.JunkDataTableAdapter()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JunkDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label36.Location = New System.Drawing.Point(508, 324)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(315, 41)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "DELETE ITEMS FORM"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox4.Controls.Add(Me.btn_refresh)
        Me.GroupBox4.Controls.Add(Me.btn_delete)
        Me.GroupBox4.Controls.Add(Me.txt_ItemID)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(49, 379)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1429, 278)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DELETE ITEMS"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_refresh.Location = New System.Drawing.Point(594, 199)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(111, 35)
        Me.btn_refresh.TabIndex = 18
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_delete.Location = New System.Drawing.Point(391, 199)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(111, 35)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_ItemID
        '
        Me.txt_ItemID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ItemID.Location = New System.Drawing.Point(518, 134)
        Me.txt_ItemID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ItemID.Name = "txt_ItemID"
        Me.txt_ItemID.Size = New System.Drawing.Size(250, 30)
        Me.txt_ItemID.TabIndex = 9
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(355, 135)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 28)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "Item ID"
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.SAddressDataGridViewTextBoxColumn, Me.SPhoneDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.BuyDateDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.JunkDataBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(4, 5)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 29
        Me.DataGridView4.Size = New System.Drawing.Size(1526, 306)
        Me.DataGridView4.TabIndex = 13
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.Width = 127
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
        Me.SAddressDataGridViewTextBoxColumn.Width = 180
        '
        'SPhoneDataGridViewTextBoxColumn
        '
        Me.SPhoneDataGridViewTextBoxColumn.DataPropertyName = "S_Phone"
        Me.SPhoneDataGridViewTextBoxColumn.HeaderText = "S_Phone"
        Me.SPhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SPhoneDataGridViewTextBoxColumn.Name = "SPhoneDataGridViewTextBoxColumn"
        Me.SPhoneDataGridViewTextBoxColumn.Width = 150
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.Width = 180
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 130
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
        Me.TotalAmountDataGridViewTextBoxColumn.Width = 180
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
        Me.JunkDataBindingSource.DataSource = Me.JMSDataSet
        '
        'JMSDataSet
        '
        Me.JMSDataSet.DataSetName = "JMSDataSet"
        Me.JMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JunkDataTableAdapter
        '
        Me.JunkDataTableAdapter.ClearBeforeFill = True
        '
        'ItemDeleteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1532, 682)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemDeleteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemDeleteForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JunkDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label36 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_ItemID As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents JMSDataSet As JMSDataSet
    Friend WithEvents JunkDataBindingSource As BindingSource
    Friend WithEvents JunkDataTableAdapter As JMSDataSetTableAdapters.JunkDataTableAdapter
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
