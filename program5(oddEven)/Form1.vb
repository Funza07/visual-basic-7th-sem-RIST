Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = TextBox1.Text
        If n Mod 2 = 0 Then
            Label4.Text = "Even Number"
        Else
            Label4.Text = "Odd Number"
        End If
    End Sub
End Class
