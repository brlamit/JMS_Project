Imports System.Data.SqlClient

Public Class ItemDeleteForm
    Private Sub ItemDeleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JMSDataSet.JunkData' table. You can move, or remove it, as needed.
        Me.JunkDataTableAdapter.Fill(Me.JMSDataSet.JunkData)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            ' Check if the Item_ID is provided for deletion
            If Not String.IsNullOrEmpty(txt_ItemID.Text.Trim()) Then
                ' Delete the record with the specified Item_ID
                Dim deleteQuery As String = "DELETE FROM JunkData WHERE Item_ID = @Item_ID"

                Using connection As New SqlConnection("Server=AMIT\SQLEXPRESS; Database=JMS; Integrated Security=true")
                    Using command As New SqlCommand(deleteQuery, connection)
                        ' Add parameter for deletion
                        command.Parameters.AddWithValue("@Item_ID", txt_ItemID.Text)

                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Data deleted successfully
                            MessageBox.Show("Data deleted successfully.")

                            ' Refresh the DataGridView to reflect the changes
                            Me.JunkDataTableAdapter.Fill(Me.JMSDataSet.JunkData)
                        Else
                            ' No rows were affected, indicating that the Item_ID was not found
                            MessageBox.Show("No record found for the specified Item_ID.")
                        End If
                    End Using
                End Using
            Else
                ' Item_ID is not provided for deletion
                MessageBox.Show("Please enter Item_ID for deletion.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        txt_ItemID.Focus()
        txt_ItemID.Clear()
    End Sub
End Class
