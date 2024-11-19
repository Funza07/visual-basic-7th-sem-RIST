Public Class Form1
    Dim n As New ArrayList()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = TextBox1.Text
        n.Add(num)
        ListBox1.Items.Add(num)
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To n.Count - 1
            For j = i To n.Count - 1
                If (n(i) > n(j)) Then
                    Dim temp As Integer = n(i)
                    n(i) = n(j)
                    n(j) = temp
                End If
            Next
        Next
        ListBox1.Items.Clear()
        For i = 0 To n.Count - 1
            ListBox1.Items.Add(n(i))
        Next
    End Sub
End Class
