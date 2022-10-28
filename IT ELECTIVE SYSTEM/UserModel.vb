Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Runtime.Remoting.Messaging

Public Class UserModel
    Public Const CONNECTIONS_STRING As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Applications\VS\projects\cms-it-elective\IT ELECTIVE SYSTEM\cmsdb.mdf;Integrated Security=True"
    Private Const VALID_CHARACTER As String = "1234567890abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private _sqlConnection As SqlConnection = New SqlConnection(CONNECTIONS_STRING)
    Private _command As SqlCommand

    Public Sub OpenConnection(connection As SqlConnection)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub
    Public Function hasLoggedIn(connection As SqlConnection) As Boolean
        _command = New SqlCommand("SELECT user_id FROM current_usr", connection)
        Dim dataReader As SqlDataReader
        Try
            dataReader = _command.ExecuteReader
            With dataReader
                If .HasRows Then
                    Return True
                End If
                Return False
            End With
        Catch ex As Exception
            Return False
        Finally
            _command.Dispose()
        End Try

    End Function

    Public Function currentUser(connection As SqlConnection, user_id As Integer) As Boolean
        Dim sqlCommand As SqlCommand = New SqlCommand($"INSERT INTO current_usr (user_id) VALUES ({user_id})", connection)
        If sqlCommand.ExecuteNonQuery() <> 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    ' WHEN THE USER LOGGED IN
    ' TO DO : SANITIZE STRING, ENCRYPT PASSWORD
    Public Function logIn(connection As SqlConnection, username As String, password As String) As Boolean
        Dim user_id As Integer
        _command = New SqlCommand($"SELECT user_id FROM users WHERE username = {username} AND password = {password}", connection)
        Dim dataReader As SqlDataReader
        Try
            dataReader = _command.ExecuteReader
            Using dataReader
                With dataReader
                    If .HasRows Then
                        dataReader.Read()
                        user_id = .Item("user_id")
                        _command.Dispose()
                        connection.Close()
                        OpenConnection(connection)
                        If currentUser(connection, user_id) Then
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

    ' TO DO
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
    Public Function signUp(connection As SqlConnection, values() As String) As Boolean
        Dim placeHolder() As String = {"@fname", "@lname", "@birth", "@gender", "@email", "@usrname", "@passwd"}
        _command = New SqlCommand($"INSERT INTO users (first_name, last_name, birth_date, gender, email, username, password) VALUES ('{values(0)}', '{values(1)}', '{values(2)}', '{values(3)}', '{values(4)}', '{values(5)}', '{values(6)}')", connection)
        If _command.ExecuteNonQuery() <> 0 Then
            Return True
        End If
        Return False
    End Function

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
