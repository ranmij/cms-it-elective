Imports System.Data.SqlClient

Public Class SplashScreen
    Private seconds As Integer
    Private _usermodel As UserModel = New UserModel()
    Private _connection As SqlConnection = New SqlConnection(UserModel.CONNECTIONS_STRING)
    Private _hasLoggedIn As Boolean
    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _usermodel.OpenConnection(_connection)
        _hasLoggedIn = _usermodel.hasLoggedIn(_connection)
        LoadTimer.Start()
    End Sub

    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        seconds += 1
        If seconds > 5 Then
            LoadTimer.Stop()
            LoadTimer.Enabled = False
            Me.Hide()
            If _hasLoggedIn Then
                MainForm.Show()
            Else
                LoginForm.Show()
            End If
        End If
    End Sub

    Private Sub appName_Click(sender As Object, e As EventArgs) Handles appName.Click

    End Sub
End Class
