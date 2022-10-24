Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms

Public Class mainForm

    Private isOpen As Boolean = False
    Private panels() As Guna2Panel = {studentPanel, coursePanel}
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            icon.BackColor = Color.White
        End If
    End Sub

    Private Sub closePanel()
        Dim panels() As Guna2Panel = {studentPanel, coursePanel, teachersPanel, dashBoardPanel, profilePanel}
        For index = 0 To panels.Length - 1
            panels(index).Visible = False
        Next
    End Sub

    Private Sub menuBtn_MouseHover(sender As Object, e As EventArgs) Handles menuBtn.MouseHover
        menuBtn.BackColor = Color.Gray
    End Sub

    Private Sub menuBtn_MouseLeave(sender As Object, e As EventArgs) Handles menuBtn.MouseLeave
        menuBtn.BackColor = Color.White
    End Sub

    Private Sub logOutBtnIcon_MouseHover(sender As Object, e As EventArgs) Handles logOutBtnIcon.MouseHover
        onMouseHoverChangeState(logOutBtnShadow, onLogOutHoverTimer, logOutBtnIcon, True)
    End Sub

    Private Sub logOutBtnIcon_MouseLeave(sender As Object, e As EventArgs) Handles logOutBtnIcon.MouseLeave
        onMouseHoverChangeState(logOutBtnShadow, onLogOutHoverTimer, logOutBtnIcon, False)
    End Sub

    Private Sub dashboardBtnIcon_MouseHover(sender As Object, e As EventArgs) Handles dashboardBtnIcon.MouseHover
        onMouseHoverChangeState(dashBoardBtnShadow, onDashboardHoverTimer, dashboardBtnIcon, True)
    End Sub

    Private Sub dashboardBtnIcon_MouseLeave(sender As Object, e As EventArgs) Handles dashboardBtnIcon.MouseLeave
        onMouseHoverChangeState(dashBoardBtnShadow, onDashboardHoverTimer, dashboardBtnIcon, False)
    End Sub

    Private Sub teachersBtnIcon_MouseHover(sender As Object, e As EventArgs) Handles teachersBtnIcon.MouseHover
        onMouseHoverChangeState(teachersBtnShadow, onTeacherHoverTimer, teachersBtnIcon, True)
    End Sub

    Private Sub teachersBtnIcon_MouseLeave(sender As Object, e As EventArgs) Handles teachersBtnIcon.MouseLeave
        onMouseHoverChangeState(teachersBtnShadow, onTeacherHoverTimer, teachersBtnIcon, False)
    End Sub

    Private Sub coursesBtnIcon_MouseHover(sender As Object, e As EventArgs) Handles coursesBtnIcon.MouseHover
        onMouseHoverChangeState(coursesBtnShadow, onCourseHoverTimer, coursesBtnIcon, True)
    End Sub

    Private Sub coursesBtnIcon_MouseLeave(sender As Object, e As EventArgs) Handles coursesBtnIcon.MouseLeave
        onMouseHoverChangeState(coursesBtnShadow, onCourseHoverTimer, coursesBtnIcon, False)
    End Sub

    Private Sub studentBtnIcon_MouseHover(sender As Object, e As EventArgs) Handles studentBtnIcon.MouseHover
        onMouseHoverChangeState(studentsBtnShadow, onStudentHoverTimer, studentBtnIcon, True)
    End Sub

    Private Sub studentBtnIcon_MouseLeave(sender As Object, e As EventArgs) Handles studentBtnIcon.MouseLeave
        onMouseHoverChangeState(studentsBtnShadow, onStudentHoverTimer, studentBtnIcon, False)
    End Sub

    Private Sub profileBtnIcon_MouseHover(sender As Object, e As EventArgs) Handles profileBtnIcon.MouseHover
        onMouseHoverChangeState(profileBtnShadow, onProfileHoverTimer, profileBtnIcon, True)
    End Sub

    Private Sub profileBtnIcon_MouseLeave(sender As Object, e As EventArgs) Handles profileBtnIcon.MouseLeave
        onMouseHoverChangeState(profileBtnShadow, onProfileHoverTimer, profileBtnIcon, False)
    End Sub

    Private Sub closeBtn_MouseHover(sender As Object, e As EventArgs) Handles closeBtn.MouseHover
        closeBtn.BackColor = Color.Red
    End Sub

    Private Sub closeBtn_MouseLeave(sender As Object, e As EventArgs) Handles closeBtn.MouseLeave
        closeBtn.BackColor = Color.White
    End Sub

    'Transition of shadows
    Private Sub onStudentHoverTimer_Tick(sender As Object, e As EventArgs) Handles onStudentHoverTimer.Tick
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

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub menuBtn_Click(sender As Object, e As EventArgs) Handles menuBtn.Click
        sidePanel.Width = 210
        menuBtn.Visible = False
        closeMenuBtn.Visible = True
        isOpen = True
        menuLabel.Visible = True

    End Sub

    Private Sub closeMenuBtn_Click(sender As Object, e As EventArgs) Handles closeMenuBtn.Click
        closeMenuBtn.Visible = False
        menuBtn.Visible = True
        isOpen = False
        sidePanel.Width = 44
        menuLabel.Visible = False
    End Sub

    Private Sub studentShadow_MouseHover(sender As Object, e As EventArgs) Handles studentShadow.MouseHover
        changeShadowColor(studentBtnIcon, Color.DodgerBlue)
    End Sub

    Private Sub studentShadow_MouseLeave(sender As Object, e As EventArgs) Handles studentShadow.MouseLeave
        changeShadowColor(studentBtnIcon, Color.White)
    End Sub

    Private Sub courseShadow_MouseHover(sender As Object, e As EventArgs) Handles courseShadow.MouseHover
        changeShadowColor(coursesBtnIcon, Color.DodgerBlue)
    End Sub

    Private Sub courseShadow_MouseLeave(sender As Object, e As EventArgs) Handles courseShadow.MouseLeave
        changeShadowColor(coursesBtnIcon, Color.White)
    End Sub

    Private Sub teachersShadow_MouseLeave(sender As Object, e As EventArgs) Handles teachersShadow.MouseLeave
        changeShadowColor(teachersBtnIcon, Color.White)
    End Sub

    Private Sub teachersShadow_MouseHover(sender As Object, e As EventArgs) Handles teachersShadow.MouseHover
        changeShadowColor(teachersBtnIcon, Color.DodgerBlue)
    End Sub

    Private Sub dashboardShadow_MouseHover(sender As Object, e As EventArgs) Handles dashboardShadow.MouseHover
        changeShadowColor(dashboardBtnIcon, Color.DodgerBlue)
    End Sub

    Private Sub dashboardShadow_MouseLeave(sender As Object, e As EventArgs) Handles dashboardShadow.MouseLeave
        changeShadowColor(dashboardBtnIcon, Color.White)
    End Sub

    Private Sub logOutShadow_MouseHover(sender As Object, e As EventArgs) Handles logOutShadow.MouseHover
        changeShadowColor(logOutBtnIcon, Color.DodgerBlue)
    End Sub

    Private Sub logOutShadow_MouseLeave(sender As Object, e As EventArgs) Handles logOutShadow.MouseLeave
        changeShadowColor(logOutBtnIcon, Color.White)
    End Sub

    Private Sub profileShadow_MouseHover(sender As Object, e As EventArgs) Handles profileShadow.MouseHover
        changeShadowColor(profileBtnIcon, Color.DodgerBlue)
    End Sub

    Private Sub profileShadow_MouseLeave(sender As Object, e As EventArgs) Handles profileShadow.MouseLeave
        changeShadowColor(profileBtnIcon, Color.White)
    End Sub

    Private Sub studentBtnIcon_Click(sender As Object, e As EventArgs) Handles studentBtnIcon.Click
        closePanel()
        studentPanel.Visible = True
    End Sub

    Private Sub coursesBtnIcon_Click(sender As Object, e As EventArgs) Handles coursesBtnIcon.Click
        closePanel()
        coursePanel.Visible = True
    End Sub

    Private Sub teachersBtnIcon_Click(sender As Object, e As EventArgs) Handles teachersBtnIcon.Click
        closePanel()
        teachersPanel.Visible = True
    End Sub

    Private Sub dashboardBtnIcon_Click(sender As Object, e As EventArgs) Handles dashboardBtnIcon.Click
        closePanel()
        dashBoardPanel.Visible = True
    End Sub

    Private Sub profileBtnIcon_Click(sender As Object, e As EventArgs) Handles profileBtnIcon.Click
        closePanel()
        profilePanel.Visible = True
    End Sub

    Private Sub logOutBtnIcon_Click(sender As Object, e As EventArgs) Handles logOutBtnIcon.Click
        Me.Hide()
        loginForm.Show()
    End Sub
End Class