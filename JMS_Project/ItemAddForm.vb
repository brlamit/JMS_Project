'Imports System.Data.SqlClient

'Public Class ItemAddForm
'    Private Sub ItemAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        'TODO: This line of code loads data into the 'JMSDataSet.JunkData' table. You can move, or remove it, as needed.
'        Me.JunkDataTableAdapter.Fill(Me.JMSDataSet.JunkData)

'    End Sub

'    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

'    End Sub
'End Class
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class itemaddform

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim builder As New SqlConnectionStringBuilder(
            "Server=AMIT\SQLEXPRESS;Database=JMS;Integrated Security=True;")
        builder.TrustServerCertificate = True
        Using connection As New SqlConnection(builder.ConnectionString)

            Try
                connection.Open()


                ' Insert data into the database
                Dim insertQuery As String = "INSERT INTO JunkData (Supplier_Name, S_Address, S_Phone, Item_ID, Item_Name, Quantity, Rate,Buy_Date, Total_Amount) VALUES (@Supplier_Name, @S_Address, @S_Phone, @Item_ID, @Item_Name, @Quantity, @Rate,@Buy_Date, @Total_Amount)"
                'Using connection As New SqlConnection(builder.ConnectionString)
                Using command As New SqlCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@Supplier_Name", txt_suppliername.Text)
                    command.Parameters.AddWithValue("@S_Address", txt_supplieraddress.Text)
                    command.Parameters.AddWithValue("@S_Phone", txt_supplierphone.Text)
                    command.Parameters.AddWithValue("@Item_ID", txt_ItemID.Text)
                    command.Parameters.AddWithValue("@Item_Name", txt_itemname.Text)
                    command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_itemquantity.Text))
                    command.Parameters.AddWithValue("@Rate", Convert.ToDecimal(txt_itemrate.Text))
                    command.Parameters.AddWithValue("@Buy_Date", DateTimePicker1.Value)

                    Dim total As Decimal = Convert.ToDecimal(txt_itemquantity.Text) * Convert.ToDecimal(txt_itemrate.Text)
                    If total >= 0 Then
                        command.Parameters.AddWithValue("@Total_Amount", total)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Data inserted successfully.")
                        Me.JunkDataTableAdapter.Fill(Me.JMSDataSet.JunkData)
                        'Me.JunkDataableAdapter.Fill(Me.JMSDataSet.JunkData)
                    Else
                        MessageBox.Show("Invalid total amount entered. Total amount should be greater than or equal to 0.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        ' Clear input fields
        txt_suppliername.Focus()
        txt_supplieraddress.Focus()
        txt_supplierphone.Focus()
        txt_ItemID.Focus()
        txt_itemname.Focus()
        txt_itemquantity.Focus()
        txt_itemrate.Focus()
        txt_suppliername.Clear()
        txt_supplieraddress.Clear()
        txt_supplierphone.Clear()
        txt_ItemID.Clear()
        txt_itemname.Clear()
        txt_itemquantity.Clear()
        txt_itemrate.Clear()
        DateTimePicker1.Value = DateTime.Now ' Reset the DateTimePicker

        ' Refresh the DataGridView
        ' RefreshDataGridView1()
    End Sub

    'Private Sub RefreshDataGridView1()
    '    Dim builder As New SqlConnectionStringBuilder(
    '    "Server=AMIT\SQLEXPRESS;Database=JMS;Integrated Security=True;")
    '    builder.TrustServerCertificate = True

    '    Using connection As New SqlConnection(builder.ConnectionString)
    '        Try
    '            connection.Open()

    '            ' Select data from the database
    '            Dim selectQuery As String = "SELECT * FROM JunkData"
    '            Using command As New SqlCommand(selectQuery, connection)
    '                Using reader As SqlDataReader = command.ExecuteReader()
    '                    ' Assuming you have a DataGridView named dgvJunkData to display the data
    '                    DataGridView1.Rows.Clear()

    '                    While reader.Read()
    '                        ' Retrieve data from the database
    '                        Dim row As DataGridViewRow = New DataGridViewRow()
    '                        row.CreateCells(DataGridView1)
    '                        row.Cells(0).Value = reader("Supplier_Name")
    '                        row.Cells(1).Value = reader("S_Address")
    '                        row.Cells(2).Value = reader("S_Phone")
    '                        row.Cells(3).Value = reader("Item_ID")
    '                        row.Cells(4).Value = reader("Item_Name")
    '                        row.Cells(5).Value = reader("Quantity")
    '                        row.Cells(6).Value = reader("Rate")
    '                        row.Cells(7).Value = reader("Buy_Date")
    '                        row.Cells(8).Value = reader("Total_Amount")

    '                        DataGridView1.Rows.Add(row)
    '                    End While
    '                End Using
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("Error: " & ex.Message)
    '        Finally
    '            connection.Close()
    '        End Try
    '    End Using
    'End Sub

    Private Sub itemaddform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JMSDataSet.JunkData' table. You can move, or remove it, as needed.
        Me.JunkDataTableAdapter.Fill(Me.JMSDataSet.JunkData)

    End Sub
End Class
