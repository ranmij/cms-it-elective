Imports System.Data.SqlClient
Imports System.Security.Authentication.ExtendedProtection
Imports Guna.UI2.WinForms

Public Class LoginForm
    Dim isHidden As Boolean = False
    Private _userModel As UserModel = New UserModel()

    Private Sub hidePassword(textBox As Guna2TextBox)
        If isHidden Then
            isHidden = False
            textBox.IconRight = My.Resources.ic_eye_crossed
            textBox.PasswordChar = My.Resources.passwordHideText
        Else
            isHidden = True
            textBox.IconRight = My.Resources.ic_eye
            textBox.PasswordChar = Nothing
        End If
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization of texts and other values
    End Sub

    Private Sub password_IconRightClick(sender As Object, e As EventArgs) Handles passwordLTextBox.IconRightClick
        hidePassword(passwordLTextBox)
    End Sub

    Private Sub signUpBtn_Click(sender As Object, e As EventArgs) Handles signUpBtn.Click
        If Not signupPanelF.Visible Then
            signupPanelF.Visible = True
        Else
            signupPanelF.Visible = False
        End If
    End Sub

    Private Sub signUpPassword_IconRightClick(sender As Object, e As EventArgs) Handles passwordSTextBox.IconRightClick
        hidePassword(passwordSTextBox)
    End Sub

    Private Sub closeSPanelS_Click(sender As Object, e As EventArgs) Handles closeSPanelS.Click
        signupPanelS.Visible = False
    End Sub

    Private Sub closeSPanelF_Click(sender As Object, e As EventArgs) Handles closeSPanelF.Click
        signupPanelF.Visible = False
    End Sub

    Private Sub closeLogInForm_Click(sender As Object, e As EventArgs) Handles closeLogInForm.Click
        Me.Close()
    End Sub


    Private Sub signUpNextBtn_Click(sender As Object, e As EventArgs) Handles signUpNextBtn.Click
        signupPanelS.Visible = True
    End Sub

    ' TO DO FIX THIS STRING LITTERALS
    Private Sub signUpUser_Click(sender As Object, e As EventArgs) Handles signUpUser.Click
        Dim _connection As SqlConnection = New SqlConnection(UserModel.CONNECTIONS_STRING)
        _userModel.OpenConnection(_connection)
        Dim gender = If(maleSRadioBtn.Checked, "M", "F")
        Dim textBoxesValues() As String = {firstNameSTextBox.Text, lastNameSTextBox.Text, birthDayPicker.Value.ToString("MM/dd/yyyy").Substring(0, 10), gender, emailSTextBox.Text, usernameSTextBox.Text, passwordSTextBox.Text}
        Dim textBoxes() As Object = {firstNameSTextBox, lastNameSTextBox, emailSTextBox, usernameSTextBox, passwordSTextBox}
        Dim radioBtn() As Object = {maleSRadioBtn, femaleSRadioBtn}
        If textBoxes.All(Function(element) Not String.IsNullOrEmpty(element.Text)) AndAlso radioBtn.Any(Function(element) element.Checked) Then
            If _userModel.signUp(_connection, textBoxesValues) Then
                signupPanelS.Visible = False
                signupPanelF.Visible = False
                onEmptyMessageDialog.Caption = "Success!"
                onEmptyMessageDialog.Text = "Your account has been created."
                onEmptyMessageDialog.Show()
            Else
                onEmptyMessageDialog.Caption = "Failed!"
                onEmptyMessageDialog.Text = "Your account has not been created."
                onEmptyMessageDialog.Show()
            End If
        Else
            For Each textBox As Guna2TextBox In textBoxes
                If String.IsNullOrEmpty(textBox.Text) Then
                    textBox.BorderColor = Color.Red
                Else
                    textBox.BorderColor = Color.FromArgb(213, 218, 223)
                End If
            Next
        End If
        _connection.Close()
    End Sub

    Private Sub logInBtn_Click(sender As Object, e As EventArgs) Handles logInBtn.Click
        Dim _connection As SqlConnection = New SqlConnection(UserModel.CONNECTIONS_STRING)
        _userModel.OpenConnection(_connection)
        ' Check the fields
        If String.IsNullOrEmpty(usernameLTextBox.Text) AndAlso String.IsNullOrEmpty(passwordLTextBox.Text) Then
            onEmptyMessageDialog.Caption = My.Resources.logInEmptyFieldsCaption
            onEmptyMessageDialog.Text = My.Resources.logInEmptyFieldsText
            onEmptyMessageDialog.Show()
        ElseIf String.IsNullOrEmpty(passwordLTextBox.Text) Then
            onEmptyMessageDialog.Caption = My.Resources.logInPasswordEmptyCaption
            onEmptyMessageDialog.Text = My.Resources.logInPasswordEmptyText
            onEmptyMessageDialog.Show()
        ElseIf String.IsNullOrEmpty(usernameLTextBox.Text) Then
            onEmptyMessageDialog.Caption = My.Resources.logInUsernameEmptyCaption
            onEmptyMessageDialog.Text = My.Resources.logInUsernameEmptyText
            onEmptyMessageDialog.Show()
        Else
            'TO DO sanitize the string
            If _connection.State = ConnectionState.Open Then
                If _userModel.logIn(_connection, usernameLTextBox.Text, passwordLTextBox.Text) Then
                    Me.Close()
                    MainForm.Show()
                Else
                    onErrorMessageDialog.Caption = My.Resources.failedLogInCaption
                    onErrorMessageDialog.Text = My.Resources.failedLogInText
                    onErrorMessageDialog.Show()
                End If
            End If
        End If
        _connection.Close()
    End Sub

#Region "MouseEvents"
    Private Sub CustomOnMouseHover(sender As Object, e As EventArgs) Handles closeLogInForm.MouseHover, closeLogInForm.MouseHover, closeSPanelS.MouseHover, closeSPanelF.MouseHover
        TryCast(sender, Guna2ImageButton).BackColor = Color.Red
    End Sub

    Private Sub CustomOnMouseLeave(sender As Object, E As EventArgs) Handles closeLogInForm.MouseLeave, closeSPanelS.MouseLeave, closeSPanelF.MouseLeave
        TryCast(sender, Guna2ImageButton).BackColor = Color.Transparent
    End Sub
#End Region
End Class