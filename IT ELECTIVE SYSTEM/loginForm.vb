Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class loginForm
    Dim isHidden As Boolean = False
    Private userModel As UserModel = New UserModel()
    Private connection As SqlConnection = userModel.getSqlConnection()

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
        signUpBtn.Text = My.Resources.signUpText
        logInBtn.Text = My.Resources.logInText
        orLabel.Text = My.Resources._or
        signUpNextBtn.Text = My.Resources.nextBtn
        joinUsLabel.Text = My.Resources.joinUsLabel
        signUpUser.Text = My.Resources.signUpText
        signUpPanel1.Visible = False
        signUpEmail.PlaceholderText = My.Resources.emailHint
        signUpUsername.PlaceholderText = My.Resources.userNameHint
        signUpPassword.PlaceholderText = My.Resources.passwordHint
        userName.PlaceholderText = My.Resources.userNameHint    ' Log in
        password.PlaceholderText = My.Resources.passwordHint    ' Log in
        firstNameTextBox.PlaceholderText = My.Resources.firstNameHint
        lastNameTextBox.PlaceholderText = My.Resources.lastNameHint
        checkBoxControl.Text = My.Resources.rememberMeText
    End Sub

    Private Sub password_IconRightClick(sender As Object, e As EventArgs) Handles password.IconRightClick
        hidePassword(password)
    End Sub

    Private Sub signUpBtn_Click(sender As Object, e As EventArgs) Handles signUpBtn.Click
        If Not signUpPanel1.Visible Then
            signUpPanel1.Visible = True
        Else
            signUpPanel1.Visible = False
        End If
    End Sub

    Private Sub signUpPassword_IconRightClick(sender As Object, e As EventArgs) Handles signUpPassword.IconRightClick
        hidePassword(signUpPassword)
    End Sub

    Private Sub closePanel2_Click(sender As Object, e As EventArgs) Handles closePanel2.Click
        signUpPanel2.Visible = False
    End Sub

    Private Sub closePanel1_Click(sender As Object, e As EventArgs) Handles closePanel1.Click
        signUpPanel1.Visible = False
    End Sub

    Private Sub closeLogInForm_Click(sender As Object, e As EventArgs) Handles closeLogInForm.Click
        Me.Close()
    End Sub


    Private Sub signUpNextBtn_Click(sender As Object, e As EventArgs) Handles signUpNextBtn.Click
        signUpPanel2.Visible = True
    End Sub

    Private Sub signUpUser_Click(sender As Object, e As EventArgs) Handles signUpUser.Click
        Dim textBoxes() As String = {firstNameTextBox.Text, lastNameTextBox.Text, birthDayPicker.Value.ToString()}
    End Sub

    Private Sub logInBtn_Click(sender As Object, e As EventArgs) Handles logInBtn.Click
        ' Check the fields
        If userName.Text = Nothing And password.Text = Nothing Then
            onEmptyMessageDialog.Caption = My.Resources.logInEmptyFieldsCaption
            onEmptyMessageDialog.Text = My.Resources.logInEmptyFieldsText
            onEmptyMessageDialog.Show()
        ElseIf password.Text = Nothing Then
            onEmptyMessageDialog.Caption = My.Resources.logInPasswordEmptyCaption
            onEmptyMessageDialog.Text = My.Resources.logInPasswordEmptyText
            onEmptyMessageDialog.Show()
        ElseIf userName.Text = Nothing Then
            onEmptyMessageDialog.Caption = My.Resources.logInUsernameEmptyCaption
            onEmptyMessageDialog.Text = My.Resources.logInUsernameEmptyText
            onEmptyMessageDialog.Show()
        Else
            'TO DO
            If connection.State = ConnectionState.Open Then
                If userModel.logIn(connection, userName.Text, password.Text) = True Then
                    Me.Close()
                    mainForm.Show()
                Else
                    onErrorMessageDialog.Caption = My.Resources.failedLogInCaption
                    onErrorMessageDialog.Text = My.Resources.failedLogInText
                    onErrorMessageDialog.Show()
                End If
            End If
        End If
    End Sub

End Class