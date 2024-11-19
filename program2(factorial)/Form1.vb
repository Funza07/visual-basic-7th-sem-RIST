Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, fact As Integer
        n = TextBox1.Text
        fact = 1
        For i = 1 To n
            fact *= i
        Next
        Label4.Text = fact
    End Sub
End Class
