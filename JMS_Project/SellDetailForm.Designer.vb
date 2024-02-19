<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellDetailForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChangeAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELLDETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JMSDataSet2 = New JMS_Project.JMSDataSet2()
        Me.SELLDETAILSTableAdapter = New JMS_Project.JMSDataSet2TableAdapters.SELLDETAILSTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_ItemID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELLDETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JMSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.SellRateDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.ReceivedAmountDataGridViewTextBoxColumn, Me.ChangeAmountDataGridViewTextBoxColumn, Me.SellDateDataGridViewTextBoxColumn, Me.SellerNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SELLDETAILSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 8)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1508, 378)
        Me.DataGridView1.TabIndex = 0
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.Width = 140
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
        'SellRateDataGridViewTextBoxColumn
        '
        Me.SellRateDataGridViewTextBoxColumn.DataPropertyName = "Sell_Rate"
        Me.SellRateDataGridViewTextBoxColumn.HeaderText = "Sell_Rate"
        Me.SellRateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SellRateDataGridViewTextBoxColumn.Name = "SellRateDataGridViewTextBoxColumn"
        Me.SellRateDataGridViewTextBoxColumn.Width = 140
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.Width = 150
        '
        'ReceivedAmountDataGridViewTextBoxColumn
        '
        Me.ReceivedAmountDataGridViewTextBoxColumn.DataPropertyName = "Received_Amount"
        Me.ReceivedAmountDataGridViewTextBoxColumn.HeaderText = "Received_Amount"
        Me.ReceivedAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReceivedAmountDataGridViewTextBoxColumn.Name = "ReceivedAmountDataGridViewTextBoxColumn"
        Me.ReceivedAmountDataGridViewTextBoxColumn.Width = 150
        '
        'ChangeAmountDataGridViewTextBoxColumn
        '
        Me.ChangeAmountDataGridViewTextBoxColumn.DataPropertyName = "Change_Amount"
        Me.ChangeAmountDataGridViewTextBoxColumn.HeaderText = "Change_Amount"
        Me.ChangeAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ChangeAmountDataGridViewTextBoxColumn.Name = "ChangeAmountDataGridViewTextBoxColumn"
        Me.ChangeAmountDataGridViewTextBoxColumn.Width = 150
        '
        'SellDateDataGridViewTextBoxColumn
        '
        Me.SellDateDataGridViewTextBoxColumn.DataPropertyName = "Sell_Date"
        Me.SellDateDataGridViewTextBoxColumn.HeaderText = "Sell_Date"
        Me.SellDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SellDateDataGridViewTextBoxColumn.Name = "SellDateDataGridViewTextBoxColumn"
        Me.SellDateDataGridViewTextBoxColumn.Width = 200
        '
        'SellerNameDataGridViewTextBoxColumn
        '
        Me.SellerNameDataGridViewTextBoxColumn.DataPropertyName = "Seller_Name"
        Me.SellerNameDataGridViewTextBoxColumn.HeaderText = "Seller_Name"
        Me.SellerNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SellerNameDataGridViewTextBoxColumn.Name = "SellerNameDataGridViewTextBoxColumn"
        Me.SellerNameDataGridViewTextBoxColumn.Width = 200
        '
        'SELLDETAILSBindingSource
        '
        Me.SELLDETAILSBindingSource.DataMember = "SELLDETAILS"
        Me.SELLDETAILSBindingSource.DataSource = Me.JMSDataSet2
        '
        'JMSDataSet2
        '
        Me.JMSDataSet2.DataSetName = "JMSDataSet2"
        Me.JMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELLDETAILSTableAdapter
        '
        Me.SELLDETAILSTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.txt_ItemID)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(299, 458)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(818, 232)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEARCH ITEMS"
        '
        'txt_ItemID
        '
        Me.txt_ItemID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ItemID.Location = New System.Drawing.Point(345, 86)
        Me.txt_ItemID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ItemID.Name = "txt_ItemID"
        Me.txt_ItemID.Size = New System.Drawing.Size(250, 30)
        Me.txt_ItemID.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(225, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 28)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Item ID"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_search.Location = New System.Drawing.Point(310, 149)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(111, 35)
        Me.btn_search.TabIndex = 16
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label27.Location = New System.Drawing.Point(587, 412)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(316, 35)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "VIEW SELL DETAILS"
        '
        'SellDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1528, 723)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SellDetailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SellDetailForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELLDETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JMSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents JMSDataSet2 As JMSDataSet2
    Friend WithEvents SELLDETAILSBindingSource As BindingSource
    Friend WithEvents SELLDETAILSTableAdapter As JMSDataSet2TableAdapters.SELLDETAILSTableAdapter
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChangeAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_ItemID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents Label27 As Label
End Class
