Imports System.Data.SqlClient

' This should be put to splashscreen event and change the main form
' But I forgot to do that and now this create it's on instance without actually closing it
' Note don't change this to the splashscreen events or you will get a symbol loading error because the system loads things concurrently and doesn't want us to access first the controls
Public Class SplashScreen
    Private seconds As Integer                                                              ' If how many seconds will the splashscreen show.
    Private _usermodel As UserModel = New UserModel()                                       ' For database transactions
    Private _connection As SqlConnection = New SqlConnection(UserModel.CONNECTIONS_STRING)  ' Connection for the database, only one instance because we are only working with the database once
    Private _hasLoggedIn As Boolean                                                         ' If the user is currently logged in

    ''' <summary>
    ''' Performs all the neccessary checks, initialize all the things, and start timers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _usermodel.OpenConnection(_connection)
        _hasLoggedIn = _usermodel.hasLoggedIn(_connection)
        LoadTimer.Start()
    End Sub

    ''' <summary>
    ''' Tick event of the timer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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
End Class
