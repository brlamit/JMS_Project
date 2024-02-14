Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class login
    Public Shared Property Username As String
    Public Shared Property SellerName As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnregister1.Click
        Hide()
        register.Show()
    End Sub
    Private Sub CheckBox_Upass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Upass.CheckedChanged
        If CheckBox_Upass.Checked = True Then
            txt_Upassword.UseSystemPasswordChar = False
        Else
            txt_Upassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private connection As SqlConnection ' Declare connection at class level

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize connection with SqlConnectionStringBuilder
        connection = New SqlConnection(New SqlConnectionStringBuilder With {
            .DataSource = "AMIT\SQLEXPRESS",
            .InitialCatalog = "JMS",
            .IntegratedSecurity = True,
            .TrustServerCertificate = True ' For testing, remove in production
        }.ConnectionString)
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txt_Username.Text
        Dim password As String = txt_Upassword.Text

        Try
            connection.Open()

            ' Debugging statement
            ' Console.WriteLine("Checking authentication for Username: " & username)

            ' Assuming your table is named "login" and has columns "Username" and "Password"
            Dim query As String = "SELECT COUNT(*) FROM login WHERE Username=@Username AND Password=@Password"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", HashPassword(password)) ' Use hashed password

                ' ExecuteScalar returns the number of rows that match the query
                Dim count As Integer = CInt(command.ExecuteScalar())

                ' Debugging statement
                ' Console.WriteLine("Rows found: " & count)

                ' If count is 1, the user is authenticated
                If count = 1 Then
                    login.Username = username

                    login.SellerName = username
                    ' MessageBox.Show("Authentication successful!")
                    Me.Hide()
                    Dim home As New Dashboard()
                    home.Show()

                Else
                    MessageBox.Show("Authentication failed. Invalid username or password.")
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions (display an error message, log the error, etc.)
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Function HashPassword(password As String) As String
        ' Implement a secure password hashing algorithm here, such as BCrypt
        ' Replace this with your preferred hashing implementation
        Return password
    End Function
End Class