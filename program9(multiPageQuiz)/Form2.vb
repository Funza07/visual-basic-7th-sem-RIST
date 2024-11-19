Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton4.Checked = True Then
            pointss += 1
        End If
        Me.Hide()
        Form3.Show()
    End Sub
End Class