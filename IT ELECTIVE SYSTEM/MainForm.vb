
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class MainForm
    Private isOpen As Boolean = False                       ' The state of the left side panel
    Private _usermodel As UserModel = New UserModel()       ' Use for database transactions
    Private Const sidePanelMinWidth = 44                    ' The minimum width of the left side panel
    Private Const sidePanelMaxWidth = 210                   ' The maximu width of the left side panel

    ''' <summary>
    ''' When the system triggered this form then the load will be triggered too
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CmsdbDataSet.students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.CmsdbDataSet.students)
        'TODO: This line of code loads data into the 'CmsdbDataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.CmsdbDataSet.courses)
        'TODO: This line of code loads data into the 'CmsdbDataSet.teachers' table. You can move, or remove it, as needed.
        Me.TeachersTableAdapter.Fill(Me.CmsdbDataSet.teachers)
        Dim gradientBtns() As Guna2GradientTileButton = {studentsBtnShadow, logOutBtnShadow, coursesBtnShadow, teachersBtnShadow, dashBoardBtnShadow, profileBtnShadow}
        Dim gradientShadows() As Guna2GradientTileButton = {studentShadow, logOutShadow, courseShadow, teachersShadow, dashboardShadow, profileShadow}
        For index = 0 To gradientBtns.Length - 1
            gradientBtns(index).Visible = False
            gradientBtns(index).Width = 0
            gradientShadows(index).Parent.Controls.SetChildIndex(gradientShadows(index), 0)
            gradientBtns(index).Parent.Controls.SetChildIndex(gradientBtns(index), 0)
        Next
        menuLabel.Visible = False
        sidePanel.Parent.Controls.SetChildIndex(sidePanel, 0)
    End Sub

    ''' <summary>
    ''' This is the transition of the side panel
    ''' </summary>
    ''' <param name="obj">Guna2GradientTileButton - When the menu and close button is clicked</param>
    Private Sub rollShadows(obj As Guna2GradientTileButton)
        If obj.Width < 166 Then
            obj.Width += 40
            If obj.Width > 166 Then
                Dim temp As Integer = obj.Width - 166
                obj.Width -= temp
            End If
        End If
    End Sub
    ''' <summary>
    ''' To change the color of the image button when the sidePanel is opened
    ''' </summary>
    ''' <param name="obj">Guna2ImageButton - The target icon to change the color</param>
    ''' <param name="color">Color - Color that we will use</param>
    Private Sub changeShadowColor(obj As Guna2ImageButton, color As Color)
        If isOpen Then
            obj.BackColor = color
        End If
    End Sub
    ''' <summary>
    ''' This is for the hover state of the icons, to transition the gradienttilebutton.
    ''' Well that shouldn't be a gradienttilebutton since it doesnt function as  button but I'm too exhausted to change it :>
    ''' </summary>
    ''' <param name="obj">Guna2GradientTileButton - The target shadow we want to change</param>
    ''' <param name="ticks">System.Windows.Form.Timer - The timer we will start when the icon is hovered</param>
    ''' <param name="icon">Guna2ImageButton - The icon that the user hovers</param>
    ''' <param name="hover">Boolean - If the mouse is still on the icon or leaving</param>
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

    ''' <summary>
    ''' This function closes the panels so that we can only view one panel at a time.
    ''' </summary>
    Private Sub closePanel()
        Dim panels() As Guna2Panel = {studentPanel, coursePanel, teachersPanel, dashBoardPanel, profilePanel}
        For index = 0 To panels.Length - 1
            panels(index).Visible = False
        Next
    End Sub

    ''' <summary>
    ''' This is a custom tick events that I created, this consumed lots of time to figure out how to implement it
    ''' turns out creating a custom procedure is allowed.
    ''' </summary>
    ''' <param name="sender">Mainform.Timer - Timer that will be send by the system when ticks triggered</param>
    ''' <param name="e">System.EventArgs - The event args e.g tick</param>
    Private Sub OnCustomeTimerTick(sender As Object, e As EventArgs) Handles onStudentHoverTimer.Tick, onCourseHoverTimer.Tick, onTeacherHoverTimer.Tick, onDashboardHoverTimer.Tick,
            onLogOutHoverTimer.Tick, onProfileHoverTimer.Tick
        If sender.Equals(onStudentHoverTimer) Then
            rollShadows(studentsBtnShadow)
        ElseIf sender.Equals(onCourseHoverTimer) Then
            rollShadows(studentsBtnShadow)
        ElseIf sender.Equals(onTeacherHoverTimer) Then
            rollShadows(teachersBtnShadow)
        ElseIf sender.Equals(onDashboardHoverTimer) Then
            rollShadows(dashBoardBtnShadow)
        ElseIf sender.Equals(onProfileHoverTimer) Then
            rollShadows(profileBtnShadow)
        ElseIf sender.Equals(onLogOutHoverTimer) Then
            rollShadows(logOutBtnShadow)
        End If
    End Sub

    ''' <summary>
    ''' A custom click for buttons in the form, this is only applied to closing and opening events
    ''' </summary>
    ''' <param name="sender">Object - Any control that will be clicked apart from the icons that open a panel </param>
    ''' <param name="e">System.EventArgs - The event that will be triggered</param>
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
    ''' <summary>
    ''' The separate click events for some controls that won't affect the other click events
    ''' </summary>
    ''' <param name="sender">Object - These are the controls that will be clicked</param>
    ''' <param name="e">EventArgs</param>
    Protected Sub CustomOnClick(sender As Object, e As EventArgs) Handles logOutBtnIcon.Click, teachersBtnIcon.Click, studentBtnIcon.Click, profileBtnIcon.Click, dashboardBtnIcon.Click, coursesBtnIcon.Click
        Dim connection As SqlConnection = New SqlConnection(UserModel.CONNECTIONS_STRING)
        _usermodel.OpenConnection(connection)
        closePanel()
        If sender.Equals(studentBtnIcon) Then
            studentPanel.Visible = True
        ElseIf sender.Equals(coursesBtnIcon) Then
            coursePanel.Visible = True
        ElseIf sender.Equals(teachersBtnIcon) Then
            Dim index As Integer = tTeachersGridView.Rows.Item(0).Cells.Item(0).Value
            Dim result() = _usermodel.getTeacher(connection, Convert.ToInt32(index))
            Dim age = Date.Now.Year - Convert.ToDateTime(result(2)).Year
            tNameData.Text = result(0).ToString & " " & result(1).ToString
            tGenderData.Text = If(result(3) = "M", "Male", "Female")
            tBirthData.Text = Convert.ToDateTime(result(2)).ToShortDateString()
            tDegreeData.Text = result(4).ToString
            tAgeData.Text = age
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
    ''' <summary>
    ''' This for the hover events transition to animate the Controls in the current window
    ''' </summary>
    ''' <param name="sender">Control</param>
    ''' <param name="e">System.EventArgs</param>
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
    ''' <summary>
    ''' This function will be triggered when the mouse leave a certain control in the UI
    ''' </summary>
    ''' <param name="sender">Control</param>
    ''' <param name="e">System.EventArgs</param>
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
    ''' <summary>
    ''' Will be trigged when a row or a cell is clicked in the teacher's data grid view panel
    ''' </summary>
    ''' <param name="sender">DataGridView - The data grid view</param>
    ''' <param name="e">DataGridViewCellEventArgs - The cell events when clicked</param>
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
