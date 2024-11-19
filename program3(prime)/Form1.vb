Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i, flag As Integer
        n = TextBox1.Text
        i = n / 2
        flag = 1
        For j = 2 To i
            If n Mod i = 0 Then
                flag = 0
                Exit For
            End If
        Next
        If flag = 0 Then
            Label4.Text = "Not Prime"
        Else
            Label4.Text = "Prime"
        End If
    End Sub
End Class
