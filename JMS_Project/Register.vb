Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class register
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox_Upass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Upass.CheckedChanged
        If CheckBox_Upass.Checked = True Then
            txt_Upassword.UseSystemPasswordChar = False
        Else
            txt_Upassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox_Mpass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Mpass.CheckedChanged
        If CheckBox_Mpass.Checked = True Then
            txt_maskedpass.UseSystemPasswordChar = False
        Else
            txt_maskedpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        login.Show()
    End Sub
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim builder As New SqlClient.SqlConnectionStringBuilder(
            "Server=AMIT\SQLEXPRESS;Database=JMS;Integrated Security=True;")
        builder.TrustServerCertificate = True

        Using connection As New SqlClient.SqlConnection(builder.ConnectionString)
            Try
                connection.Open()

                ' Check if the username already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM register WHERE Username = @Username"
                Using checkCommand As New SqlClient.SqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@Username", txt_username.Text)
                    Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Username already taken. Please choose a different username.")
                        Return ' Exit the method if the username is not unique
                    End If
                End Using

                ' Insert data into the database
                Dim insertQuery As String = "INSERT INTO register (first_name, last_name, username, address, password, gender, dateofbirth, phone, email) VALUES (@first_name, @last_name, @username, @address, @password, @gender, @dateofbirth, @phoneno, @email)"
                Using command As New SqlClient.SqlCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@first_name", txt_firstname.Text)
                    command.Parameters.AddWithValue("@last_name", txt_lastname.Text)
                    command.Parameters.AddWithValue("@username", txt_username.Text)
                    command.Parameters.AddWithValue("@address", txt_address.Text)
                    command.Parameters.AddWithValue("@password", HashPassword(txt_Upassword.Text))
                    command.Parameters.AddWithValue("@gender", GetSelectedGender())
                    command.Parameters.AddWithValue("@dateofbirth", dob_picker.Value)
                    command.Parameters.AddWithValue("@phoneno", txt_phoneno.Text)
                    command.Parameters.AddWithValue("@email", txt_email.Text)

                    ' Execute the query
                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registration successful.")
                ' Clear input fields
                Me.Dispose()

                login.Show()

                ClearInputFields()

            Catch ex As Exception
                MessageBox.Show($"Error occurred during registration. Details: {ex.Message}")
                Console.WriteLine("Error: " & ex.ToString())
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
    Private Function HashPassword(password As String) As String

        Return password ' Replace with actual hashing implementation
    End Function

    Private Function GetSelectedGender() As String
        ' Determine and return the selected gender
        If RadioButton_male.Checked Then
            Return "Male"
        ElseIf RadioButton_female.Checked Then
            Return "Female"
        Else
            Return String.Empty
        End If
    End Function

    Private Sub ClearInputFields()
        ' Clear all input fields
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_username.Clear()
        txt_address.Clear()
        txt_Upassword.Clear()
        txt_maskedpass.Clear()
        RadioButton_male.Checked = False
        RadioButton_female.Checked = False
        dob_picker.Value = DateTime.Now
        txt_phoneno.Clear()
        txt_email.Clear()
    End Sub
End Class
