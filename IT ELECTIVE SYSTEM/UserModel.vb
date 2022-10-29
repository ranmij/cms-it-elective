Imports System.Data.SqlClient
Public Class UserModel
    Public Shared CONNECTIONS_STRING As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Applications\VS\projects\cms-it-elective\IT ELECTIVE SYSTEM\cmsdb.mdf;Integrated Security=True" 'My.Settings.cmsdbConnectionString  ' The database string connection, change this if you cloned the project.
    Private _command As SqlCommand                                                  ' Command instance of the all the commands that we are going to perform

    ''' <summary>
    ''' To open the connection
    ''' </summary>
    ''' <param name="connection">SqlConnection - The instance that we will open</param>
    Public Sub OpenConnection(connection As SqlConnection)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    ''' <summary>
    ''' Check if the user is currently logged in
    ''' </summary>
    ''' <param name="connection"></param>
    ''' <returns>True if the user has previously logged in otherwise false</returns>
    Public Function hasLoggedIn(connection As SqlConnection) As Boolean
        _command = New SqlCommand("SELECT user_id FROM current_usr", connection)
        Try
            Using dataReader As SqlDataReader = _command.ExecuteReader
                With dataReader
                    If .HasRows Then
                        Return True
                    End If
                    Return False
                End With
            End Using
        Catch ex As Exception
            Return False
        Finally
            _command.Dispose()
        End Try

    End Function

    ''' <summary>
    ''' Insert the current user so that the user doesn't need to log in when the app starts again.
    ''' This should be in local sqlite but again, i am too exhausted to code it, maybe next time when I developed another system
    ''' </summary>
    ''' <param name="connection">sqlconnection</param>
    ''' <param name="user_id">the user id of the user</param>
    ''' <returns>True if the current user is inserted otherwise false</returns>
    Public Function currentUser(connection As SqlConnection, user_id As Integer) As Boolean
        _command = New SqlCommand($"INSERT INTO current_usr VALUES ({user_id});", connection)
        If _command.ExecuteNonQuery() <> 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    ''' <summary>
    ''' Pefrom all the database interaction when the user logs in.
    ''' In addition to that, the code written here is bad practice.
    ''' This should be written in async but fvck I don't want to hahaah.
    ''' It works anyway lol
    ''' </summary>
    ''' <param name="connection"></param>
    ''' <param name="username">Username of the user</param>
    ''' <param name="password">Password of the user</param>
    ''' <returns>True if the user has logged in otherwise false</returns>
    Public Function logIn(connection As SqlConnection, username As String, password As String) As Boolean
        Dim selectCon As New SqlConnection(CONNECTIONS_STRING)
        OpenConnection(selectCon)
        Dim user_id As Integer = 0
        Dim passwordHash As String = Nothing
        _command = New SqlCommand($"SELECT user_id, password FROM users WHERE username = '{username}'", selectCon)
        Try
            Using dataReader As SqlDataReader = _command.ExecuteReader
                With dataReader
                    If .HasRows Then
                        dataReader.Read()
                        user_id = .Item("user_id")
                        passwordHash = .Item("password")
                        _command.Dispose()
                        If currentUser(connection, user_id) AndAlso BCrypt.Net.BCrypt.Verify(password, passwordHash) Then
                            Return True
                        End If
                    End If
                    Return False
                End With
            End Using
        Catch ex As Exception
            Return False
        Finally
            _command.Dispose()
            connection.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' For string validations
    ''' </summary>
    ''' <param name="str">TextBox.Text - the string to be checked</param>
    ''' <returns>Valid string</returns>
    Private Function validString(str As String) As String
        Dim cleanString As String = Trim(str)
        Return cleanString
    End Function

    Private Function getId(connection As SqlConnection) As Integer
        _command = New SqlCommand("SELECT user_id FROM current_usr", connection)
        Dim dataReader As SqlDataReader
        Try
            dataReader = _command.ExecuteReader
            With dataReader
                If .HasRows Then
                    .Read()
                    Return .Item("user_id")
                End If
                Return False
            End With
        Catch ex As System.InvalidOperationException
            Return False
        Catch ex As Exception
            Return False
        Finally
            _command.Dispose()
            connection.Close()
        End Try
    End Function

    ''' <summary>
    ''' For the sign up action
    ''' </summary>
    ''' <param name="connection"></param>
    ''' <param name="values">These are the textboxes values</param>
    ''' <returns>True if the user successfully signed up otherwise false</returns>
    Public Function signUp(connection As SqlConnection, values() As String) As Boolean
        _command = New SqlCommand($"INSERT INTO users (first_name, last_name, birth_date, gender, email, username, password) VALUES ('{values(0)}', '{values(1)}', '{values(2)}', '{values(3)}', '{values(4)}', '{values(5)}', '{BCrypt.Net.BCrypt.HashPassword(values(6))}')", connection)
        If _command.ExecuteNonQuery() <> 0 Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' When the user signs up
    ''' </summary>
    ''' <param name="connection"></param>
    ''' <returns>True if the user has successfully logged out otherwise false</returns>
    Public Function logOut(connection As SqlConnection) As Boolean
        _command = New SqlCommand("SELECT user_id FROM current_usr", connection)
        Dim user_id As Integer = getId(connection)
        connection.Close()
        OpenConnection(connection)
        Dim deleteCommand = New SqlCommand($"DELETE FROM current_usr WHERE user_id = {user_id}", connection)
        If deleteCommand.ExecuteNonQuery() <> 0 Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Use to get all the info of the user
    ''' </summary>
    ''' <param name="connection"></param>
    ''' <returns>Array of objects that the sql operation retrieve</returns>
    Public Function getUser(connection As SqlConnection) As Object()
        Dim user_id As Integer = getId(connection)
        OpenConnection(connection)
        _command = New SqlCommand($"SELECT first_name, last_name, birth_date, gender, email FROM users WHERE user_id = {user_id}", connection)
        Const selectedLength = 4
        Try
            Dim dataReader As SqlDataReader = _command.ExecuteReader
            With dataReader
                If .HasRows Then
                    .Read()
                    Dim values(selectedLength) As Object
                    .GetValues(values)
                    If values.Count() <> 0 Then
                        Return values
                    End If

                End If
                Return Nothing
            End With
        Catch ex As System.InvalidOperationException
            Console.WriteLine("Invalidddd")
            Return Nothing
        Finally
            _command.Dispose()
            connection.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Use to get how many entries do we have in the tables
    ''' </summary>
    ''' <param name="connection"></param>
    ''' <returns>Array of objects containing the count of the entries</returns>
    Public Function getCount(connection As SqlConnection) As Object()
        _command = New SqlCommand("SELECT COUNT(S.id) AS students_count, COUNT(C.id) AS courses_count, COUNT(T.id) AS teachers_count FROM students AS S FULL OUTER JOIN courses AS C ON S.id = C.id FULL OUTER JOIN teachers AS T ON S.id = T.id", connection)
        Try
            Dim dataReader As SqlDataReader = _command.ExecuteReader
            With dataReader
                If .HasRows Then
                    .Read()
                    Dim values(3) As Object
                    .GetValues(values)
                    If values.Count() <> 0 Then
                        Return values
                    End If
                End If
                Return Nothing
            End With
        Catch ex As Exception
            Return Nothing
        Finally
            _command.Dispose()
            connection.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Get the teacher information
    ''' </summary>
    ''' <param name="connection"></param>
    ''' <param name="id">id of the teacher</param>
    ''' <returns></returns>
    Public Function getTeacher(connection As SqlConnection, id As Integer) As Object()
        _command = New SqlCommand($"SELECT first_name, last_name, birth_date, gender, degree FROM teachers WHERE id = {id}", connection)
        Const selectedLength = 4
        Try
            Using dataReader = _command.ExecuteReader
                With dataReader
                    If .HasRows Then
                        .Read()
                        Dim values(selectedLength) As Object
                        .GetValues(values)
                        If values.Count() <> 0 Then
                            Return values
                        End If
                    End If
                    Return Nothing
                End With
            End Using
        Catch ex As Exception
            Return Nothing
        Finally
            _command.Dispose()
            connection.Dispose()
        End Try
    End Function
End Class
