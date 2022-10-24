Imports System.Data.SqlClient

Public Class UserModel

    Private Const CONNECTIONS_STRING As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\cmsdb.mdf;Integrated Security=True"
    Private Const VALID_CHARACTER As String = "1234567890abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private ReadOnly _sqlConnection As SqlConnection = New SqlConnection(CONNECTIONS_STRING)
    Private _command As SqlCommand

    Private Sub connect()
        If _sqlConnection.State = ConnectionState.Closed Then
            _sqlConnection.Open()
        End If
    End Sub

    Public ReadOnly Property getSqlConnection() As SqlConnection
        Get
            connect()
            Return _sqlConnection
        End Get
    End Property

    Public Function hasLoggedIn(connection As SqlConnection) As Boolean
        _command = New SqlCommand("SELECT COUNT(user_id) AS result FROM current_user", connection)
        Dim dataReader As SqlDataReader
        Try
            dataReader = _command.ExecuteReader
            Using dataReader
                With dataReader
                    If .HasRows Then
                        _command.Dispose()
                        Return True
                    Else
                        _command.Dispose()
                        Return False
                    End If
                End With
            End Using
        Catch ex As Exception
            ' Perform nothing
        Finally
            connection.Close()
        End Try
        _command.Dispose()
        Return False
    End Function

    ' WHEN THE USER LOGGED IN
    ' TO DO : SANITIZE STRING, ENCRYPT PASSWORD
    Public Function logIn(connection As SqlConnection, username As String, password As String) As Boolean

        _command = New SqlCommand("SELECT user_id FROM users WHERE username = @username AND password = @password", connection)
        _command.Parameters.AddWithValue("@username", username)
        _command.Parameters.AddWithValue("@password", password)
        Dim dataReader As SqlDataReader
        Try
            dataReader = _command.ExecuteReader
            Using dataReader
                With dataReader
                    If .HasRows Then
                        dataReader.Read()
                        Dim insertCommand As SqlCommand = New SqlCommand("INSERT INTO current_user (id, user_id) VALUES (1, @)", connection)
                        insertCommand.Parameters.AddWithValue("@user_id", .Item("user_id"))
                        _command.Dispose()
                        Return True
                    Else
                        _command.Dispose()
                        Return False
                    End If
                End With
            End Using
        Catch ex As Exception
            _command.Dispose()
            Return False
        End Try
    End Function

    ' TO DO
    Private Function validString(str As String) As String
        Dim cleanString As String = Trim(str)
        Return cleanString
    End Function

    Public Function signUp(connection As SqlConnection, values() As String) As Boolean
        Dim placeHolder() As String = {"@fname", "@lname", "@birth", "@gender", "@usrname", "@passwd"}
        _command = New SqlCommand("INSERT INTO users (first_name, last_name, birth_date, gender, username, password) VALUES ('@fname', '@lname', '@birth', '@gender', '@usrname', '@passwd')", connection)
        For i = 0 To placeHolder.Length - 1
            _command.Parameters.AddWithValue(placeHolder(i), values(i))
        Next
        If _command.ExecuteNonQuery() <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
