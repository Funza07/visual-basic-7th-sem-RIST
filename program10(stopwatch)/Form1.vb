Imports System.Diagnostics
Imports System.Reflection.Emit
Imports System.Timers

Public Class Form1
    Dim stopwatch As New Stopwatch()
    Dim timer As New System.Windows.Forms.Timer()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler timer.Tick, AddressOf UpdateLabel
        timer.Interval = 100
        Label1.Text = "00:00:00.000"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stopwatch.Start()
        timer.Start()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If stopwatch.IsRunning Then
            ListBox1.Items.Add("Checkpoint: " & stopwatch.Elapsed.ToString("hh\:mm\:ss\.fff"))
        Else
            MessageBox.Show("Timer is not running. Please start the timer first.", "Error")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
            MessageBox.Show("Timer Stopped at: " & stopwatch.Elapsed.ToString("hh\:mm\:ss\.fff"), "Timer Stopped")
        Else
            MessageBox.Show("Timer is not running.", "Error")
        End If
    End Sub
    Private Sub UpdateLabel(sender As Object, e As EventArgs)
        If stopwatch.IsRunning Then
            Label1.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss\.fff")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "00:00:00.000"
        ListBox1.Items.Clear()
    End Sub
End Class
