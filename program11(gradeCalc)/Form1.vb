Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, ee, p As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = TextBox4.Text
        ee = TextBox5.Text
        p = ((a + b + c + d + ee) / 50) * 100
        TextBox7.Text = Str(p) + "%"
        If p >= 90 Then
            TextBox6.Text = "A"
        ElseIf p < 90 And p >= 80 Then
            TextBox6.Text = "B"
        ElseIf p < 80 And p >= 70 Then
            TextBox6.Text = "C"
        ElseIf p < 70 And p >= 60 Then
            TextBox6.Text = "D"
        ElseIf p < 60 Then
            TextBox6.Text = "E"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
End Class
