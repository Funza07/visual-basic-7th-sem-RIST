Imports MySql.Data.MySqlClient

Public Class RegisterForm

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If txtPassword.Text = txtConfirmPassword.Text Then
            Dim connectionString As String = "server=localhost;userid=root;password='';database=testloginpage"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "INSERT INTO users (username, password, email) VALUES (@username, @password, @email)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)

                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Registration Successful!")
                        Dim loginForm As New Form1()
                        loginForm.Show()
                        Me.Hide()
                    Catch ex As MySqlException
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Passwords do not match.")
        End If
    End Sub
End Class