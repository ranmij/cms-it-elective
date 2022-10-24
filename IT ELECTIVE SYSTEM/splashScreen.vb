Imports System.Data.SqlClient

Public Class splashScreen
    Dim seconds As Integer
    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appName.Text = My.Resources.appName
        pauseTimer.Interval = 1000
        pauseTimer.Start()

    End Sub

    Private Sub pauseTimer_Tick(sender As Object, e As EventArgs) Handles pauseTimer.Tick
        seconds += 1
        If seconds > 5 Then
            pauseTimer.Stop()
            pauseTimer.Enabled = False
            Me.Hide()
            loginForm.Show()
        End If
    End Sub
End Class
