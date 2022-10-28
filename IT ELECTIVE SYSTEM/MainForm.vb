Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class MainForm
    Private isOpen As Boolean = False
    Private _usermodel As UserModel = New UserModel()
    Private Const sidePanelMinWidth = 44
    Private Const sidePanelMaxWidth = 210
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CmsdbDataSet.teachers' table. You can move, or remove it, as needed.
        Me.TeachersTableAdapter.Fill(Me.CmsdbDataSet.teachers)
        Dim gradientBtns() As Guna2GradientTileButton = {studentsBtnShadow, logOutBtnShadow, coursesBtnShadow, teachersBtnShadow, dashBoardBtnShadow, profileBtnShadow}
        Dim shadowStrings() As String = {My.Resources.studentsText, My.Resources.logOutText, My.Resources.coursesText, My.Resources.teachersText, My.Resources.dashboardText, My.Resources.profileText}
        Dim gradientShadows() As Guna2GradientTileButton = {studentShadow, logOutShadow, courseShadow, teachersShadow, dashboardShadow, profileShadow}
        For index = 0 To gradientBtns.Length - 1
            gradientBtns(index).Visible = False
            gradientBtns(index).Width = 0
            gradientBtns(index).Text = shadowStrings(index)
            gradientShadows(index).Text = shadowStrings(index)
            gradientShadows(index).Parent.Controls.SetChildIndex(gradientShadows(index), 0)
            gradientBtns(index).Parent.Controls.SetChildIndex(gradientBtns(index), 0)
        Next
        menuLabel.Visible = False
        sidePanel.Parent.Controls.SetChildIndex(sidePanel, 0)
    End Sub

    'To show the shadow transitions
    Private Sub rollShadows(obj As Guna2GradientTileButton)
        If obj.Width < 166 Then
            obj.Width += 40
            If obj.Width > 166 Then
                Dim temp As Integer = obj.Width - 166
                obj.Width -= temp
            End If
        End If
    End Sub

    Private Sub changeShadowColor(obj As Guna2ImageButton, color As Color)
        If isOpen Then
            obj.BackColor = color
        End If
    End Sub

    Private Sub onMouseHoverChangeState(obj As Guna2GradientTileButton, ticks As Timer, icon As Guna2ImageButton, hover As Boolean)
        If Not isOpen And hover Then
            obj.Visible = True
            icon.BackColor = Color.Gray
            ticks.Start()
        Else
            obj.Visible = False
            ticks.Stop()
            icon.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub closePanel()
        Dim panels() As Guna2Panel = {studentPanel, coursePanel, teachersPanel, dashBoardPanel, profilePanel}
        For index = 0 To panels.Length - 1
            panels(index).Visible = False
        Next
    End Sub

    'Transition of shadows
    Private Sub onStudentHoverTimer_Tick(sender As Object, e As EventArgs) Handles onStudentHoverTimer.Tick
        Console.WriteLine(sender.Equals(onStudentHoverTimer))
        rollShadows(studentsBtnShadow)
    End Sub

    Private Sub onCourseHoverTimer_Tick(sender As Object, e As EventArgs) Handles onCourseHoverTimer.Tick
        rollShadows(coursesBtnShadow)
    End Sub

    Private Sub onTeacherHoverTimer_Tick(sender As Object, e As EventArgs) Handles onTeacherHoverTimer.Tick
        rollShadows(teachersBtnShadow)
    End Sub

    Private Sub onDashboardHoverTimer_Tick(sender As Object, e As EventArgs) Handles onDashboardHoverTimer.Tick
        rollShadows(dashBoardBtnShadow)
    End Sub

    Private Sub onLogOutHoverTimer_Tick(sender As Object, e As EventArgs) Handles onLogOutHoverTimer.Tick
        rollShadows(logOutBtnShadow)
    End Sub

    Private Sub onProfileHoverTimer_Tick(sender As Object, e As EventArgs) Handles onProfileHoverTimer.Tick
        rollShadows(profileBtnShadow)
    End Sub

    Protected Sub CustomClickAction(sender As Object, e As EventArgs) Handles closeMenuBtn.Click, menuBtn.Click, closeBtn.Click
        If sender.Equals(closeMenuBtn) Then
            closeMenuBtn.Visible = False
            menuBtn.Visible = True
            isOpen = False
            sidePanel.Width = sidePanelMinWidth
            menuLabel.Visible = False
        ElseIf sender.Equals(menuBtn) Then
            sidePanel.Width = sidePanelMaxWidth
            menuBtn.Visible = False
            closeMenuBtn.Visible = True
            isOpen = True
            menuLabel.Visible = True
        ElseIf sender.Equals(closeBtn) Then
            Me.Close()
        End If
    End Sub

#Region "OnClickEvents"
    Protected Sub CustomOnClick(sender As Object, e As EventArgs) Handles logOutBtnIcon.Click, teachersBtnIcon.Click, studentBtnIcon.Click, profileBtnIcon.Click, dashboardBtnIcon.Click, coursesBtnIcon.Click
        Dim connection As SqlConnection = New SqlConnection(UserModel.CONNECTIONS_STRING)
        _usermodel.OpenConnection(connection)
        closePanel()
        If sender.Equals(studentBtnIcon) Then
            studentPanel.Visible = True
        ElseIf sender.Equals(coursesBtnIcon) Then
            coursePanel.Visible = True
        ElseIf sender.Equals(teachersBtnIcon) Then
            teachersPanel.Visible = True
        ElseIf sender.Equals(dashboardBtnIcon) Then
            Dim dashBoardData() = _usermodel.getCount(connection)
            dStudentsCountData.Text = dashBoardData(0).ToString
            dCoursesCountData.Text = dashBoardData(1).ToString
            dTeachersCountData.Text = dashBoardData(2).ToString
            dashBoardPanel.Visible = True
        ElseIf sender.Equals(profileBtnIcon) Then
            Dim userInfo = _usermodel.getUser(connection)
            pNameData.Text = userInfo(0).ToString & " " & userInfo(1).ToString
            pBirthData.Text = Convert.ToDateTime(userInfo(2)).ToShortDateString()
            pGenderData.Text = If(userInfo(3).ToString = "M", "Male", "Female")
            pEmailData.Text = userInfo(4).ToString()
            profilePanel.Visible = True
        ElseIf sender.Equals(logOutBtnIcon) Then
            If _usermodel.logOut(connection) Then
                Me.Close()
                LoginForm.Show()
            End If

        End If
    End Sub
#End Region
#Region "OnMouseHoverEvents"
    Protected Sub CustomHoverEffects(sender As Object, e As EventArgs) Handles profileBtnIcon.MouseHover, teachersBtnIcon.MouseHover,
            studentBtnIcon.MouseHover, dashboardBtnIcon.MouseHover, coursesBtnIcon.MouseHover, logOutBtnIcon.MouseHover, teachersShadow.MouseHover,
            studentShadow.MouseHover, profileShadow.MouseHover, logOutShadow.MouseHover, dashboardShadow.MouseHover, courseShadow.MouseHover, menuBtn.MouseHover,
            closeBtn.MouseHover
        If sender.Equals(studentBtnIcon) Then
            onMouseHoverChangeState(studentsBtnShadow, onStudentHoverTimer, studentBtnIcon, True)
        ElseIf sender.Equals(coursesBtnIcon) Then
            onMouseHoverChangeState(coursesBtnShadow, onCourseHoverTimer, coursesBtnIcon, True)
        ElseIf sender.Equals(teachersBtnIcon) Then
            onMouseHoverChangeState(teachersBtnShadow, onTeacherHoverTimer, teachersBtnIcon, True)
        ElseIf sender.Equals(dashboardBtnIcon) Then
            onMouseHoverChangeState(dashBoardBtnShadow, onDashboardHoverTimer, dashboardBtnIcon, True)
        ElseIf sender.Equals(profileBtnIcon) Then
            onMouseHoverChangeState(profileBtnShadow, onProfileHoverTimer, profileBtnIcon, True)
        ElseIf sender.Equals(logOutBtnIcon) Then
            onMouseHoverChangeState(logOutBtnShadow, onLogOutHoverTimer, logOutBtnIcon, True)
        ElseIf sender.Equals(studentShadow) Then
            changeShadowColor(studentBtnIcon, Color.DodgerBlue)
        ElseIf sender.Equals(courseShadow) Then
            changeShadowColor(coursesBtnIcon, Color.DodgerBlue)
        ElseIf sender.Equals(teachersShadow) Then
            changeShadowColor(teachersBtnIcon, Color.DodgerBlue)
        ElseIf sender.Equals(dashboardShadow) Then
            changeShadowColor(dashboardBtnIcon, Color.DodgerBlue)
        ElseIf sender.Equals(profileShadow) Then
            changeShadowColor(profileBtnIcon, Color.DodgerBlue)
        ElseIf sender.Equals(logOutShadow) Then
            changeShadowColor(logOutBtnIcon, Color.DodgerBlue)
        ElseIf sender.Equals(menuBtn) Then
            menuBtn.BackColor = Color.Gray
        ElseIf sender.Equals(closeBtn) Then
            closeBtn.BackColor = Color.Red
        End If
    End Sub
#End Region
#Region "OnMouseLeaveEvents"
    Protected Sub CustomLeaveEffects(sender As Object, e As EventArgs) Handles profileBtnIcon.MouseLeave, teachersBtnIcon.MouseLeave, studentBtnIcon.MouseLeave,
        logOutBtnIcon.MouseLeave, dashboardBtnIcon.MouseLeave, coursesBtnIcon.MouseLeave, teachersShadow.MouseLeave, studentShadow.MouseLeave,
        profileShadow.MouseLeave, logOutShadow.MouseLeave, dashboardShadow.MouseLeave, courseShadow.MouseLeave, menuBtn.MouseLeave, closeBtn.MouseLeave
        If sender.Equals(studentBtnIcon) Then
            onMouseHoverChangeState(studentsBtnShadow, onStudentHoverTimer, studentBtnIcon, False)
        ElseIf sender.Equals(coursesBtnIcon) Then
            onMouseHoverChangeState(coursesBtnShadow, onCourseHoverTimer, coursesBtnIcon, False)
        ElseIf sender.Equals(teachersBtnIcon) Then
            onMouseHoverChangeState(teachersBtnShadow, onTeacherHoverTimer, teachersBtnIcon, False)
        ElseIf sender.Equals(dashboardBtnIcon) Then
            onMouseHoverChangeState(dashBoardBtnShadow, onDashboardHoverTimer, dashboardBtnIcon, False)
        ElseIf sender.Equals(profileBtnIcon) Then
            onMouseHoverChangeState(profileBtnShadow, onProfileHoverTimer, profileBtnIcon, False)
        ElseIf sender.Equals(logOutBtnIcon) Then
            onMouseHoverChangeState(logOutBtnShadow, onLogOutHoverTimer, logOutBtnIcon, False)
        ElseIf sender.Equals(studentShadow) Then
            changeShadowColor(studentBtnIcon, Color.Transparent)
        ElseIf sender.Equals(courseShadow) Then
            changeShadowColor(coursesBtnIcon, Color.Transparent)
        ElseIf sender.Equals(teachersShadow) Then
            changeShadowColor(teachersBtnIcon, Color.Transparent)
        ElseIf sender.Equals(dashboardShadow) Then
            changeShadowColor(dashboardBtnIcon, Color.Transparent)
        ElseIf sender.Equals(profileShadow) Then
            changeShadowColor(profileBtnIcon, Color.Transparent)
        ElseIf sender.Equals(logOutShadow) Then
            changeShadowColor(logOutBtnIcon, Color.Transparent)
        ElseIf sender.Equals(menuBtn) Then
            menuBtn.BackColor = Color.Transparent
        ElseIf sender.Equals(closeBtn) Then
            closeBtn.BackColor = Color.Transparent
        End If
    End Sub
#End Region
    Private Sub tTeachersGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tTeachersGridView.CellClick
        Dim connection As New SqlConnection(UserModel.CONNECTIONS_STRING)
        _usermodel.OpenConnection(connection)
        Dim index As Integer = tTeachersGridView.CurrentRow.Cells.Item(0).Value
        Dim result() = _usermodel.getTeacher(connection, Convert.ToInt32(index))
        Dim age = Date.Now.Year - Convert.ToDateTime(result(2)).Year
        tNameData.Text = result(0).ToString & " " & result(1).ToString
        tGenderData.Text = If(result(3) = "M", "Male", "Female")
        tBirthData.Text = Convert.ToDateTime(result(2)).ToShortDateString()
        tDegreeData.Text = result(4).ToString
        tAgeData.Text = age


    End Sub
End Class
