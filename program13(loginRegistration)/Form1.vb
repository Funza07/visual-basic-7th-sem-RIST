Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim connectionString As String = "server=localhost;userid=root;password='';database=testloginpage"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT * FROM users WHERE username = @username AND password = @password"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        MessageBox.Show("Login Successful!")
                        Me.Hide()
                        Form2.Show()
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim registerForm As New registerForm()
        registerForm.Show()
        Me.Hide()
    End Sub
End Class
