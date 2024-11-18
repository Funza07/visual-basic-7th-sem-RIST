Public Class Form1
    Dim num1, num2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label5.Text = num1 + num2
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label5.Text = num1 - num2
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label5.Text = num1 * num2
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        If num2 = 0 Then
            MsgBox("Second Number cannot be 0")
        Else
            Label5.Text = num1 / num2
        End If
    End Sub
End Class
