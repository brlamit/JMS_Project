Imports System.Data.SqlClient

Public Class SellDetailForm
    Private Sub SellDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'JMSDataSet2.SELLDETAILS' table. You can move, or remove it, as needed.
        Me.SELLDETAILSTableAdapter.Fill(Me.JMSDataSet2.SELLDETAILS)
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            ' Check if the Item_ID is provided for searching
            If Not String.IsNullOrEmpty(txt_ItemID.Text.Trim()) Then
                ' Search for the record with the specified Item_ID
                Dim searchQuery As String = "SELECT * FROM SELLDETAILS WHERE Item_ID = @Item_ID"

                Using connection As New SqlConnection("Server=AMIT\SQLEXPRESS; Database=JMS; Integrated Security=true")
                    Using command As New SqlCommand(searchQuery, connection)
                        ' Add parameter for search
                        command.Parameters.AddWithValue("@Item_ID", txt_ItemID.Text)

                        connection.Open()

                        ' Use SqlDataAdapter to fill a DataTable with the result
                        Dim dataTable As New DataTable()

                        Using adapter As New SqlDataAdapter(command)
                            adapter.Fill(dataTable)
                        End Using

                        ' Display the result in the DataGridView
                        DataGridView1.DataSource = dataTable
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
End Class
