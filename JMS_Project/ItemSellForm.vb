Imports System.Data.SqlClient

Public Class ItemSellForm
    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick
        ' Handle the CellClick event to populate input fields with selected row's data
        Dim rowIndex As Integer = e.RowIndex

        If rowIndex >= 0 AndAlso rowIndex < DataGridView5.Rows.Count Then
            Dim selectedRow As DataGridViewRow = DataGridView5.Rows(rowIndex)

            ' Populate the input fields with the selected row's data
            txt_id.Text = selectedRow.Cells(0).Value.ToString()
            'txt_suppliername.Text = selectedRow.Cells(1).Value.ToString()
            'txt_supplieraddress.Text = selectedRow.Cells(2).Value.ToString()
            'txt_supplierphone.Text = selectedRow.Cells(3).Value.ToString()

            txt_itemname.Text = selectedRow.Cells(4).Value.ToString()
            txt_itemquantity.Text = selectedRow.Cells(5).Value.ToString()
            txt_itemrate.Text = selectedRow.Cells(6).Value.ToString()
            'DateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells(8).Value)
        End If
    End Sub
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
                                txt_id.Text = reader("Item_ID").ToString()
                                'txt_suppliername.Text = reader("Supplier_Name").ToString()
                                'txt_supplieraddress.Text = reader("S_Address").ToString()
                                'txt_supplierphone.Text = reader("S_Phone").ToString()
                                txt_itemname.Text = reader("Item_Name").ToString()
                                txt_itemquantity.Text = reader("Quantity").ToString()
                                txt_itemrate.Text = reader("Rate").ToString()
                                'DateTimePicker1.Value = Convert.ToDateTime(reader("Buy_Date"))
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


    'Public Class Login
    '    ' Assuming you have a shared property to store the username
    '    Public Shared Property Username As String
    '    Public Shared Property SellerName As String
    'End Class
    Private Function GetSellerName() As String
        ' Retrieve and return the seller's name from your login information
        ' Assuming you have a shared property to store the username
        If Not String.IsNullOrEmpty(Login.SellerName) Then
            Return Login.SellerName
            'Else
            '    ' Handle the case where the username is empty or not set
            '    Return "Unknown Seller"
        End If
    End Function
    Private Sub ItemSellForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JMSDataSet1.JunkData' table. You can move, or remove it, as needed.
        Me.JunkDataTableAdapter.Fill(Me.JMSDataSet1.JunkData)

    End Sub
    Private Sub txt_Squantity_TextChanged(sender As Object, e As EventArgs) Handles txt_Squantity.TextChanged
        ' Recalculate and update total amount when quantity changes
        UpdateTotalAmount()
    End Sub

    Private Sub txt_Srate_TextChanged(sender As Object, e As EventArgs) Handles txt_Srate.TextChanged
        ' Recalculate and update total amount when rate changes
        UpdateTotalAmount()
    End Sub

    Private Sub UpdateTotalAmount()
        ' Calculate and display the total amount
        Try
            Dim quantity As Integer = Convert.ToInt32(txt_Squantity.Text)
            Dim rate As Decimal = Convert.ToDecimal(txt_Srate.Text)
            Dim totalAmount As Decimal = quantity * rate

            txt_Tamount.Text = totalAmount.ToString()
        Catch ex As Exception
            ' Handle the case where conversion or calculation fails
            txt_Tamount.Text = "Invalid"
        End Try
    End Sub


    Private Sub txt_Ramount_TextChanged(sender As Object, e As EventArgs) Handles txt_Ramount.TextChanged
        ' Recalculate and update change amount when received amount changes
        UpdateChangeAmount()
    End Sub

    Private Sub UpdateChangeAmount()
        ' Calculate and display the change amount
        Try
            Dim receivedAmount As Decimal = Convert.ToDecimal(txt_Ramount.Text)
            Dim totalAmount As Decimal = Convert.ToDecimal(txt_Tamount.Text)
            Dim changeAmount As Decimal = receivedAmount - totalAmount

            txt_Camount.Text = changeAmount.ToString()
        Catch ex As Exception
            ' Handle the case where conversion or calculation fails
            txt_Camount.Text = "Invalid"
        End Try
    End Sub
    Private Sub btn_sell_Click(sender As Object, e As EventArgs) Handles btn_sell.Click
        Dim builder As New SqlConnectionStringBuilder("Server=AMIT\SQLEXPRESS;Database=JMS;Integrated Security=True;")

        builder.TrustServerCertificate = True

        Using connection As New SqlConnection(builder.ConnectionString)
            Try
                connection.Open()

                ' Check if the Item_ID is provided
                If Not String.IsNullOrEmpty(txt_id.Text.Trim()) Then
                    ' Get the current quantity from the database
                    Dim currentQuantity As Integer = 0

                    Dim selectQuantityQuery As String = "SELECT Quantity FROM JunkData WHERE Item_ID = @Item_ID"

                    Using selectCommand As New SqlCommand(selectQuantityQuery, connection)
                        selectCommand.Parameters.AddWithValue("@Item_ID", txt_id.Text)

                        ' Use SqlDataReader to read the current quantity
                        Using reader As SqlDataReader = selectCommand.ExecuteReader()
                            If reader.Read() Then
                                currentQuantity = Convert.ToInt32(reader("Quantity"))
                            End If
                        End Using
                    End Using

                    ' Check if there is enough quantity to sell
                    If currentQuantity >= Convert.ToInt32(txt_Squantity.Text) Then
                        ' Calculate the new quantity after selling
                        Dim newQuantity As Integer = currentQuantity - Convert.ToInt32(txt_Squantity.Text)

                        ' Update the quantity in the database
                        Dim updateQuantityQuery As String = "UPDATE JunkData SET Quantity = @Quantity WHERE Item_ID = @Item_ID"

                        Using updateCommand As New SqlCommand(updateQuantityQuery, connection)
                            updateCommand.Parameters.AddWithValue("@Quantity", newQuantity)
                            updateCommand.Parameters.AddWithValue("@Item_ID", txt_id.Text)

                            ' Execute the update query
                            updateCommand.ExecuteNonQuery()

                            ' Insert data into the SELLDETAILS table
                            Dim insertQuery As String = "INSERT INTO SELLDETAILS (Item_ID, Item_Name, Quantity, Sell_Rate, Total_Amount, Received_Amount, Change_Amount, Sell_Date, Seller_Name) VALUES (@Item_ID, @Item_Name, @Quantity, @Sell_Rate, @Total_Amount, @Received_Amount, @Change_Amount, @Sell_Date, @Seller_Name)"

                            Using command As New SqlCommand(insertQuery, connection)
                                command.Parameters.AddWithValue("@Item_ID", txt_id.Text)
                                command.Parameters.AddWithValue("@Item_Name", txt_itemname.Text)
                                command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_Squantity.Text))
                                command.Parameters.AddWithValue("@Sell_Rate", Convert.ToDecimal(txt_Srate.Text))
                                command.Parameters.AddWithValue("@Total_Amount", Convert.ToDecimal(txt_Tamount.Text))
                                command.Parameters.AddWithValue("@Received_Amount", Convert.ToDecimal(txt_Ramount.Text))
                                command.Parameters.AddWithValue("@Change_Amount", Convert.ToDecimal(txt_Camount.Text))
                                command.Parameters.AddWithValue("@Sell_Date", DateTime.Now)

                                ' Retrieve the seller name
                                Dim sellerName As String = GetSellerName()

                                ' Check if sellerName is Nothing or empty before adding it to parameters
                                If Not String.IsNullOrEmpty(sellerName) Then
                                    command.Parameters.AddWithValue("@Seller_Name", sellerName)
                                Else
                                    ' Handle the case where sellerName is Nothing or empty
                                    command.Parameters.AddWithValue("@Seller_Name", DBNull.Value)
                                End If

                                ' Execute the insert query
                                command.ExecuteNonQuery()

                                MessageBox.Show("Item Sold Successfully.")
                                Me.JunkDataTableAdapter.Fill(Me.JMSDataSet1.JunkData)
                            End Using
                        End Using
                    Else
                        MessageBox.Show("Not enough quantity available to sell.")
                    End If
                Else
                    MessageBox.Show("Please enter Item_ID for updating.")
                End If
            Catch ex As SqlException
                MessageBox.Show("SQL Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub






    '    Try
    '        ' Check if the Item_ID is provided for updating
    '        If Not String.IsNullOrEmpty(txt_ItemID.Text.Trim()) Then
    '            ' Update the corresponding data in the database using ItemID as the unique identifier
    '            Dim insertQuery As String = "INSERT INTO SELLDETAILS ( Item_ID, Item_Name, Quantity, Sell_Rate,Total_Amount, Received_Amount, Change_Amount, Sell_Date, Seller_Name ) VALUES (@Item_ID, @Item_Name, @Quantity, @Sell_Rate, @Total_Amount, @Received_Amount, @Change_Amount, @Sell_Date, @Seller_Name )"

    '            'Dim updateQuery As String = "INSERT INTO SELLDETAILS ( Item_ID = @Item_ID, Item_Name = @Item_Name ,Quantity = @Quantity, Rate = @Rate, Total_Amount = @Total_Amount, Received_Amount = @Received_Amount ,Change_Amount = @Change_Amount, Sell_Date = @Sell_Date, Seller_Name = @Seller_Name WHERE Item_ID = @Item_ID"

    '            Using connection As New SqlConnection("Server=AMIT\SQLEXPRESS; Database=JMS; Integrated Security=true")
    '                Using command As New SqlCommand(insertQuery, connection)
    '                    ' Add parameters for update
    '                    command.Parameters.AddWithValue("@Item_ID", txt_id.Text)
    '                    command.Parameters.AddWithValue("@Item_Name", txt_itemname.Text)
    '                    command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_Squantity.Text))
    '                    command.Parameters.AddWithValue("@Sell_Rate", Convert.ToDecimal(txt_Srate.Text))
    '                    command.Parameters.AddWithValue("@Total_Amount", Convert.ToDecimal(txt_Tamount.Text)) ' Use the recalculated total amount
    '                    command.Parameters.AddWithValue("@Received_Amount", Convert.ToDecimal(txt_Ramount.Text))
    '                    command.Parameters.AddWithValue("@Change_Amount", Convert.ToDecimal(txt_Camount.Text))
    '                    command.Parameters.AddWithValue("@Sell_Date", DateTime.Now) ' Provide a valid sell date
    '                    command.Parameters.AddWithValue("@Seller_Name", GetSellerName)

    '                    connection.Open()
    '                    command.ExecuteNonQuery()
    '                    MessageBox.Show("Item Selled Successfully.")

    '                    ' Refresh the DataGridView to reflect the changes
    '                    Me.JunkDataTableAdapter.Fill(Me.JMSDataSet1.JunkData)
    '                End Using
    '            End Using
    '        Else
    '            ' Item_ID is not provided for updating
    '            MessageBox.Show("Please enter Item_ID for updating.")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error updating data: " & ex.Message)
    '    End Try
    'End Sub

    Private Function CalculateTotalAmount() As Decimal
        ' Calculate the total amount based on your logic
        Return Convert.ToInt32(txt_Squantity.Text) * Convert.ToDecimal(txt_Srate.Text)
    End Function


End Class