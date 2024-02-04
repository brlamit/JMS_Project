Imports System.Data.SqlClient

Public Class itemupdateform
    Private Sub itemupdateform_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JMSDataSet4.JunkData' table. You can move, or remove it, as needed.
        Me.JunkDataTableAdapter.Fill(Me.JMSDataSet4.JunkData)

    End Sub
    Dim connection As New SqlConnection("Server=AMIT\SQLEXPRESS; Database=JMS; Integrated Security=true")



    'Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
    '    ' Handle the CellClick event to populate input fields with selected row's data
    '    Dim rowIndex As Integer = e.RowIndex

    '    If rowIndex >= 0 AndAlso rowIndex < DataGridView2.Rows.Count Then
    '        Dim selectedRow As DataGridViewRow = DataGridView2.Rows(rowIndex)

    '        ' Populate the input fields with the selected row's data
    '        txt_ItemID.Text = selectedRow.Cells(0).Value.ToString()
    '        txt_suppliername.Text = selectedRow.Cells(1).Value.ToString()
    '        txt_supplieraddress.Text = selectedRow.Cells(2).Value.ToString()
    '        txt_supplierphone.Text = selectedRow.Cells(3).Value.ToString()

    '        txt_itemname.Text = selectedRow.Cells(4).Value.ToString()
    '        txt_itemquantity.Text = selectedRow.Cells(5).Value.ToString()
    '        txt_itemrate.Text = selectedRow.Cells(6).Value.ToString()
    '        DateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells(8).Value)
    '    End If
    'End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            ' Check if the Item_ID is provided for updating
            If Not String.IsNullOrEmpty(txt_ItemID.Text.Trim()) Then
                ' Update the corresponding data in the database using ItemID as the unique identifier
                Dim updateQuery As String = "UPDATE JunkData SET Supplier_Name = @Supplier_Name, S_Address = @S_Address, S_Phone = @S_Phone, Item_Name = @Item_Name, Quantity = @Quantity, Rate = @Rate, Total_Amount = @Total_Amount, Buy_Date = @Buy_Date WHERE Item_ID = @Item_ID"

                Using connection As New SqlConnection("Server=AMIT\SQLEXPRESS; Database=JMS; Integrated Security=true")
                    Using command As New SqlCommand(updateQuery, connection)
                        ' Add parameters for update
                        command.Parameters.AddWithValue("@Item_ID", txt_ItemID.Text)
                        command.Parameters.AddWithValue("@Supplier_Name", txt_suppliername.Text)
                        command.Parameters.AddWithValue("@S_Address", txt_supplieraddress.Text)
                        command.Parameters.AddWithValue("@S_Phone", txt_supplierphone.Text)
                        command.Parameters.AddWithValue("@Item_Name", txt_itemname.Text)
                        command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_itemquantity.Text))
                        command.Parameters.AddWithValue("@Rate", Convert.ToDecimal(txt_itemrate.Text))
                        command.Parameters.AddWithValue("@Total_Amount", CalculateTotalAmount()) ' Use the recalculated total amount
                        command.Parameters.AddWithValue("@Buy_Date", DateTimePicker1.Value)

                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Data updated successfully.")

                        ' Refresh the DataGridView to reflect the changes
                        Me.JunkDataTableAdapter.Fill(Me.JMSDataSet4.JunkData)
                    End Using
                End Using
            Else
                ' Item_ID is not provided for updating
                MessageBox.Show("Please enter Item_ID for updating.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        End Try
    End Sub

    Private Function CalculateTotalAmount() As Decimal
        ' Calculate the total amount based on your logic
        Return Convert.ToInt32(txt_itemquantity.Text) * Convert.ToDecimal(txt_itemrate.Text)
    End Function

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            ' Check if the Item_ID is provided for searching
            If Not String.IsNullOrEmpty(txt_ItemID.Text.Trim()) Then
                ' Search for the record with the specified Item_ID
                Dim searchQuery As String = "SELECT * FROM JunkData WHERE Item_ID = @Item_ID"

                Using connection As New SqlConnection("Server=AMIT\SQLEXPRESS; Database=JMS; Integrated Security=true")
                    Using command As New SqlCommand(searchQuery, connection)
                        ' Add parameter for search
                        command.Parameters.AddWithValue("@Item_ID", txt_ItemID.Text)

                        connection.Open()

                        ' Use SqlDataReader to read the result
                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                ' Record found, populate the input fields with the data
                                'txt_ItemID.Text = reader("Item_ID)").ToString()
                                txt_suppliername.Text = reader("Supplier_Name").ToString()
                                txt_supplieraddress.Text = reader("S_Address").ToString()
                                txt_supplierphone.Text = reader("S_Phone").ToString()
                                txt_itemname.Text = reader("Item_Name").ToString()
                                txt_itemquantity.Text = reader("Quantity").ToString()
                                txt_itemrate.Text = reader("Rate").ToString()
                                DateTimePicker1.Value = Convert.ToDateTime(reader("Buy_Date"))
                            Else
                                ' Record not found
                                MessageBox.Show("Record not found for the specified Item_ID.")
                            End If
                        End Using
                    End Using
                End Using
            Else
                ' Item_ID is not provided for searching
                MessageBox.Show("Please enter Item_ID for searching.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching data: " & ex.Message)
        End Try
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




End Class
