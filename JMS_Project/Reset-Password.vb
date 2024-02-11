Imports System.Data.SqlClient

Public Class Reset_Password
    ' Define your SQL connection string
    Dim connectionString As String = "Server=AMIT\SQLEXPRESS;Database=JMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"

    ' Dim connectionString As String = "Server=AMIT\SQLEXPRESS;Database=JMS;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)

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
    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        ' Retrieve username and passwords from textboxes
        Dim username As String = txt_Username.Text
        Dim newPassword As String = txt_Upassword.Text
        Dim confirmedPassword As String = txt_maskedpass.Text

        ' Validate if both passwords match
        If newPassword = confirmedPassword Then
            ' Check if the username exists in the database
            If CheckUsernameExistence(username) Then
                ' Update the password in the database
                UpdatePassword(username, newPassword)
                MessageBox.Show("Password reset successfully!")
                Dim login As New login()
                login.Show()
                Me.Dispose()
            Else
                MessageBox.Show("Username not found. Please enter a valid username.")
            End If
        Else
            MessageBox.Show("Passwords do not match. Please re-enter.")
        End If
    End Sub
    ' Function to check if the username exists in the database
    Private Function CheckUsernameExistence(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM login WHERE username = @Username"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)

                Try
                    conn.Open()
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        Return Convert.ToInt32(result) > 0
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error checking username existence: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub UpdatePassword(username As String, newPassword As String)
        Dim query As String = "UPDATE login SET password = @Password WHERE username = @Username"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Password", newPassword)
                cmd.Parameters.AddWithValue("@Username", username)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error updating password: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim log As New login()
        log.Show()
        Me.Dispose()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class