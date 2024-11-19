Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton3.Checked = True Then
            pointss += 1
        End If
        Me.Hide()
        Form2.Show()
    End Sub
End Class
