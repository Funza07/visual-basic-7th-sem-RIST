Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, k, flag, startt, endd As Integer
        ListBox1.Items.Clear()
        startt = TextBox1.Text
        endd = TextBox2.Text
        For j = startt To endd
            flag = 1
            For k = 2 To j \ 2
                If j Mod k = 0 Then
                    flag = 0
                    Exit For
                End If
            Next
            If flag = 1 And j > 1 Then
                ListBox1.Items.Add(j)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
