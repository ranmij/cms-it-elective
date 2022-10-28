<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LogInFormStyle = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pictureBoxConnect = New System.Windows.Forms.PictureBox()
        Me.leftPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.signupPanelS = New Guna.UI2.WinForms.Guna2Panel()
        Me.genderSLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.femaleSRadioBtn = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.maleSRadioBtn = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.birthDateSLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lastNameSLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.firstNameSLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.joinUsLabel = New System.Windows.Forms.Label()
        Me.signUpUser = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.closeSPanelS = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.birthDayPicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lastNameSTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.firstNameSTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.signupPanelF = New Guna.UI2.WinForms.Guna2Panel()
        Me.passwordSLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.emailSLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.signUpNextBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.usernameSLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.closeSPanelF = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.usernameSTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwordSTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.emailSTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.closeLogInForm = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.onErrorMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.onEmptyMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.passwordLTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.logInBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.orLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.signUpBtn = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.usernameLTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.rememberCheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.logInPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.passwordLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.usernameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.rightLinePanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.leftLinePanel = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.pictureBoxConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.leftPanel.SuspendLayout()
        Me.signupPanelS.SuspendLayout()
        Me.signupPanelF.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logInPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogInFormStyle
        '
        Me.LogInFormStyle.AnimateWindow = True
        Me.LogInFormStyle.BorderRadius = 5
        Me.LogInFormStyle.ContainerControl = Me
        Me.LogInFormStyle.DockIndicatorTransparencyValue = 0.6R
        Me.LogInFormStyle.ResizeForm = False
        Me.LogInFormStyle.TransparentWhileDrag = True
        '
        'pictureBoxConnect
        '
        Me.pictureBoxConnect.BackgroundImage = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.connect2
        Me.pictureBoxConnect.Location = New System.Drawing.Point(19, 100)
        Me.pictureBoxConnect.Name = "pictureBoxConnect"
        Me.pictureBoxConnect.Size = New System.Drawing.Size(397, 252)
        Me.pictureBoxConnect.TabIndex = 9
        Me.pictureBoxConnect.TabStop = False
        '
        'leftPanel
        '
        Me.leftPanel.BorderColor = System.Drawing.Color.Transparent
        Me.leftPanel.Controls.Add(Me.pictureBoxConnect)
        Me.leftPanel.CustomBorderColor = System.Drawing.Color.Black
        Me.leftPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.Location = New System.Drawing.Point(0, 0)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(440, 459)
        Me.leftPanel.TabIndex = 10
        '
        'signupPanelS
        '
        Me.signupPanelS.Controls.Add(Me.genderSLabel)
        Me.signupPanelS.Controls.Add(Me.femaleSRadioBtn)
        Me.signupPanelS.Controls.Add(Me.maleSRadioBtn)
        Me.signupPanelS.Controls.Add(Me.birthDateSLabel)
        Me.signupPanelS.Controls.Add(Me.lastNameSLabel)
        Me.signupPanelS.Controls.Add(Me.firstNameSLabel)
        Me.signupPanelS.Controls.Add(Me.joinUsLabel)
        Me.signupPanelS.Controls.Add(Me.signUpUser)
        Me.signupPanelS.Controls.Add(Me.closeSPanelS)
        Me.signupPanelS.Controls.Add(Me.birthDayPicker)
        Me.signupPanelS.Controls.Add(Me.lastNameSTextBox)
        Me.signupPanelS.Controls.Add(Me.firstNameSTextBox)
        Me.signupPanelS.Dock = System.Windows.Forms.DockStyle.Right
        Me.signupPanelS.Location = New System.Drawing.Point(0, 0)
        Me.signupPanelS.Name = "signupPanelS"
        Me.signupPanelS.Size = New System.Drawing.Size(306, 459)
        Me.signupPanelS.TabIndex = 5
        Me.signupPanelS.Visible = False
        '
        'genderSLabel
        '
        Me.genderSLabel.BackColor = System.Drawing.Color.Transparent
        Me.genderSLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderSLabel.Location = New System.Drawing.Point(45, 304)
        Me.genderSLabel.Name = "genderSLabel"
        Me.genderSLabel.Size = New System.Drawing.Size(44, 19)
        Me.genderSLabel.TabIndex = 33
        Me.genderSLabel.Text = "Gender"
        '
        'femaleSRadioBtn
        '
        Me.femaleSRadioBtn.AutoSize = True
        Me.femaleSRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.femaleSRadioBtn.CheckedState.BorderThickness = 0
        Me.femaleSRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.femaleSRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White
        Me.femaleSRadioBtn.CheckedState.InnerOffset = -4
        Me.femaleSRadioBtn.Location = New System.Drawing.Point(114, 329)
        Me.femaleSRadioBtn.Name = "femaleSRadioBtn"
        Me.femaleSRadioBtn.Size = New System.Drawing.Size(61, 19)
        Me.femaleSRadioBtn.TabIndex = 32
        Me.femaleSRadioBtn.Text = "Female"
        Me.femaleSRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.femaleSRadioBtn.UncheckedState.BorderThickness = 2
        Me.femaleSRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.femaleSRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'maleSRadioBtn
        '
        Me.maleSRadioBtn.AutoSize = True
        Me.maleSRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maleSRadioBtn.CheckedState.BorderThickness = 0
        Me.maleSRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maleSRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White
        Me.maleSRadioBtn.CheckedState.InnerOffset = -4
        Me.maleSRadioBtn.Location = New System.Drawing.Point(45, 329)
        Me.maleSRadioBtn.Name = "maleSRadioBtn"
        Me.maleSRadioBtn.Size = New System.Drawing.Size(49, 19)
        Me.maleSRadioBtn.TabIndex = 31
        Me.maleSRadioBtn.Text = "Male"
        Me.maleSRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.maleSRadioBtn.UncheckedState.BorderThickness = 2
        Me.maleSRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.maleSRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'birthDateSLabel
        '
        Me.birthDateSLabel.BackColor = System.Drawing.Color.Transparent
        Me.birthDateSLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthDateSLabel.Location = New System.Drawing.Point(45, 237)
        Me.birthDateSLabel.Name = "birthDateSLabel"
        Me.birthDateSLabel.Size = New System.Drawing.Size(58, 19)
        Me.birthDateSLabel.TabIndex = 30
        Me.birthDateSLabel.Text = "Birth Date"
        '
        'lastNameSLabel
        '
        Me.lastNameSLabel.BackColor = System.Drawing.Color.Transparent
        Me.lastNameSLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameSLabel.Location = New System.Drawing.Point(45, 173)
        Me.lastNameSLabel.Name = "lastNameSLabel"
        Me.lastNameSLabel.Size = New System.Drawing.Size(61, 19)
        Me.lastNameSLabel.TabIndex = 29
        Me.lastNameSLabel.Text = "Last Name"
        '
        'firstNameSLabel
        '
        Me.firstNameSLabel.BackColor = System.Drawing.Color.Transparent
        Me.firstNameSLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameSLabel.Location = New System.Drawing.Point(45, 105)
        Me.firstNameSLabel.Name = "firstNameSLabel"
        Me.firstNameSLabel.Size = New System.Drawing.Size(62, 19)
        Me.firstNameSLabel.TabIndex = 28
        Me.firstNameSLabel.Text = "First Name"
        '
        'joinUsLabel
        '
        Me.joinUsLabel.AutoSize = True
        Me.joinUsLabel.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.joinUsLabel.Location = New System.Drawing.Point(120, 59)
        Me.joinUsLabel.Name = "joinUsLabel"
        Me.joinUsLabel.Size = New System.Drawing.Size(81, 30)
        Me.joinUsLabel.TabIndex = 9
        Me.joinUsLabel.Text = "Join Us!"
        '
        'signUpUser
        '
        Me.signUpUser.AutoRoundedCorners = True
        Me.signUpUser.BorderRadius = 13
        Me.signUpUser.BorderThickness = 2
        Me.signUpUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signUpUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signUpUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signUpUser.FillColor = System.Drawing.Color.Black
        Me.signUpUser.FillColor2 = System.Drawing.Color.Black
        Me.signUpUser.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUpUser.ForeColor = System.Drawing.Color.White
        Me.signUpUser.HoverState.BorderColor = System.Drawing.Color.Black
        Me.signUpUser.HoverState.FillColor = System.Drawing.Color.White
        Me.signUpUser.HoverState.FillColor2 = System.Drawing.Color.White
        Me.signUpUser.HoverState.ForeColor = System.Drawing.Color.Black
        Me.signUpUser.Location = New System.Drawing.Point(186, 356)
        Me.signUpUser.Name = "signUpUser"
        Me.signUpUser.Size = New System.Drawing.Size(81, 29)
        Me.signUpUser.TabIndex = 8
        Me.signUpUser.Text = "Sign Up"
        '
        'closeSPanelS
        '
        Me.closeSPanelS.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.closeSPanelS.HoverState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeSPanelS.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeSPanelS.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeSPanelS.ImageOffset = New System.Drawing.Point(0, 0)
        Me.closeSPanelS.ImageRotate = 0!
        Me.closeSPanelS.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeSPanelS.Location = New System.Drawing.Point(268, 0)
        Me.closeSPanelS.Name = "closeSPanelS"
        Me.closeSPanelS.PressedState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeSPanelS.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeSPanelS.Size = New System.Drawing.Size(37, 30)
        Me.closeSPanelS.TabIndex = 7
        '
        'birthDayPicker
        '
        Me.birthDayPicker.BackColor = System.Drawing.Color.Transparent
        Me.birthDayPicker.BorderColor = System.Drawing.Color.Transparent
        Me.birthDayPicker.BorderRadius = 3
        Me.birthDayPicker.Checked = True
        Me.birthDayPicker.CustomFormat = "DD-MM-YYYY"
        Me.birthDayPicker.FillColor = System.Drawing.Color.White
        Me.birthDayPicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.birthDayPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.birthDayPicker.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.birthDayPicker.IndicateFocus = True
        Me.birthDayPicker.Location = New System.Drawing.Point(45, 262)
        Me.birthDayPicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.birthDayPicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.birthDayPicker.Name = "birthDayPicker"
        Me.birthDayPicker.Size = New System.Drawing.Size(222, 36)
        Me.birthDayPicker.TabIndex = 5
        Me.birthDayPicker.UseTransparentBackground = True
        Me.birthDayPicker.Value = New Date(2022, 10, 13, 22, 31, 1, 779)
        '
        'lastNameSTextBox
        '
        Me.lastNameSTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastNameSTextBox.DefaultText = ""
        Me.lastNameSTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastNameSTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastNameSTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastNameSTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastNameSTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.lastNameSTextBox.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.lastNameSTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastNameSTextBox.Location = New System.Drawing.Point(45, 198)
        Me.lastNameSTextBox.Name = "lastNameSTextBox"
        Me.lastNameSTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lastNameSTextBox.PlaceholderText = ""
        Me.lastNameSTextBox.SelectedText = ""
        Me.lastNameSTextBox.Size = New System.Drawing.Size(222, 30)
        Me.lastNameSTextBox.TabIndex = 4
        '
        'firstNameSTextBox
        '
        Me.firstNameSTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstNameSTextBox.DefaultText = ""
        Me.firstNameSTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstNameSTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstNameSTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNameSTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNameSTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.firstNameSTextBox.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.firstNameSTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstNameSTextBox.Location = New System.Drawing.Point(45, 130)
        Me.firstNameSTextBox.Name = "firstNameSTextBox"
        Me.firstNameSTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNameSTextBox.PlaceholderText = ""
        Me.firstNameSTextBox.SelectedText = ""
        Me.firstNameSTextBox.Size = New System.Drawing.Size(222, 30)
        Me.firstNameSTextBox.TabIndex = 3
        '
        'signupPanelF
        '
        Me.signupPanelF.Controls.Add(Me.signupPanelS)
        Me.signupPanelF.Controls.Add(Me.passwordSLabel)
        Me.signupPanelF.Controls.Add(Me.emailSLabel)
        Me.signupPanelF.Controls.Add(Me.signUpNextBtn)
        Me.signupPanelF.Controls.Add(Me.usernameSLabel)
        Me.signupPanelF.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.signupPanelF.Controls.Add(Me.closeSPanelF)
        Me.signupPanelF.Controls.Add(Me.usernameSTextBox)
        Me.signupPanelF.Controls.Add(Me.passwordSTextBox)
        Me.signupPanelF.Controls.Add(Me.emailSTextBox)
        Me.signupPanelF.Dock = System.Windows.Forms.DockStyle.Right
        Me.signupPanelF.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupPanelF.Location = New System.Drawing.Point(0, 0)
        Me.signupPanelF.Name = "signupPanelF"
        Me.signupPanelF.Size = New System.Drawing.Size(306, 459)
        Me.signupPanelF.TabIndex = 12
        Me.signupPanelF.Visible = False
        '
        'passwordSLabel
        '
        Me.passwordSLabel.BackColor = System.Drawing.Color.Transparent
        Me.passwordSLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordSLabel.Location = New System.Drawing.Point(45, 275)
        Me.passwordSLabel.Name = "passwordSLabel"
        Me.passwordSLabel.Size = New System.Drawing.Size(53, 19)
        Me.passwordSLabel.TabIndex = 29
        Me.passwordSLabel.Text = "Password"
        '
        'emailSLabel
        '
        Me.emailSLabel.BackColor = System.Drawing.Color.Transparent
        Me.emailSLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailSLabel.Location = New System.Drawing.Point(45, 208)
        Me.emailSLabel.Name = "emailSLabel"
        Me.emailSLabel.Size = New System.Drawing.Size(33, 19)
        Me.emailSLabel.TabIndex = 28
        Me.emailSLabel.Text = "Email"
        '
        'signUpNextBtn
        '
        Me.signUpNextBtn.AutoRoundedCorners = True
        Me.signUpNextBtn.BorderRadius = 13
        Me.signUpNextBtn.BorderThickness = 2
        Me.signUpNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signUpNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signUpNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpNextBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signUpNextBtn.FillColor = System.Drawing.Color.Black
        Me.signUpNextBtn.FillColor2 = System.Drawing.Color.Black
        Me.signUpNextBtn.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUpNextBtn.ForeColor = System.Drawing.Color.White
        Me.signUpNextBtn.HoverState.BorderColor = System.Drawing.Color.Black
        Me.signUpNextBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.signUpNextBtn.HoverState.FillColor2 = System.Drawing.Color.White
        Me.signUpNextBtn.HoverState.ForeColor = System.Drawing.Color.Black
        Me.signUpNextBtn.Location = New System.Drawing.Point(186, 342)
        Me.signUpNextBtn.Name = "signUpNextBtn"
        Me.signUpNextBtn.Size = New System.Drawing.Size(81, 29)
        Me.signUpNextBtn.TabIndex = 9
        Me.signUpNextBtn.Text = "Next"
        '
        'usernameSLabel
        '
        Me.usernameSLabel.BackColor = System.Drawing.Color.Transparent
        Me.usernameSLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameSLabel.Location = New System.Drawing.Point(45, 143)
        Me.usernameSLabel.Name = "usernameSLabel"
        Me.usernameSLabel.Size = New System.Drawing.Size(58, 19)
        Me.usernameSLabel.TabIndex = 27
        Me.usernameSLabel.Text = "Username"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.account
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.InitialImage = CType(resources.GetObject("Guna2CirclePictureBox1.InitialImage"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(125, 74)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(53, 53)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2CirclePictureBox1.TabIndex = 13
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'closeSPanelF
        '
        Me.closeSPanelF.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.closeSPanelF.HoverState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeSPanelF.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeSPanelF.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeSPanelF.ImageOffset = New System.Drawing.Point(0, 0)
        Me.closeSPanelF.ImageRotate = 0!
        Me.closeSPanelF.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeSPanelF.Location = New System.Drawing.Point(269, 0)
        Me.closeSPanelF.Name = "closeSPanelF"
        Me.closeSPanelF.PressedState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeSPanelF.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeSPanelF.Size = New System.Drawing.Size(37, 30)
        Me.closeSPanelF.TabIndex = 8
        '
        'usernameSTextBox
        '
        Me.usernameSTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameSTextBox.DefaultText = ""
        Me.usernameSTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernameSTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernameSTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameSTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameSTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.usernameSTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usernameSTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameSTextBox.Location = New System.Drawing.Point(45, 168)
        Me.usernameSTextBox.Name = "usernameSTextBox"
        Me.usernameSTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameSTextBox.PlaceholderText = ""
        Me.usernameSTextBox.SelectedText = ""
        Me.usernameSTextBox.Size = New System.Drawing.Size(222, 30)
        Me.usernameSTextBox.TabIndex = 2
        '
        'passwordSTextBox
        '
        Me.passwordSTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordSTextBox.DefaultText = ""
        Me.passwordSTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordSTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordSTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordSTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordSTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.passwordSTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passwordSTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordSTextBox.IconRight = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.ic_eye_crossed
        Me.passwordSTextBox.Location = New System.Drawing.Point(45, 300)
        Me.passwordSTextBox.Name = "passwordSTextBox"
        Me.passwordSTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.passwordSTextBox.PlaceholderText = ""
        Me.passwordSTextBox.SelectedText = ""
        Me.passwordSTextBox.Size = New System.Drawing.Size(222, 30)
        Me.passwordSTextBox.TabIndex = 1
        '
        'emailSTextBox
        '
        Me.emailSTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailSTextBox.DefaultText = ""
        Me.emailSTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.emailSTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.emailSTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailSTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailSTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.emailSTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailSTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emailSTextBox.Location = New System.Drawing.Point(45, 233)
        Me.emailSTextBox.Name = "emailSTextBox"
        Me.emailSTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailSTextBox.PlaceholderText = ""
        Me.emailSTextBox.SelectedText = ""
        Me.emailSTextBox.Size = New System.Drawing.Size(222, 30)
        Me.emailSTextBox.TabIndex = 0
        '
        'closeLogInForm
        '
        Me.closeLogInForm.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.closeLogInForm.HoverState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeLogInForm.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeLogInForm.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeLogInForm.ImageOffset = New System.Drawing.Point(0, 0)
        Me.closeLogInForm.ImageRotate = 0!
        Me.closeLogInForm.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeLogInForm.Location = New System.Drawing.Point(268, 0)
        Me.closeLogInForm.Name = "closeLogInForm"
        Me.closeLogInForm.PressedState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closeLogInForm.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeLogInForm.Size = New System.Drawing.Size(37, 30)
        Me.closeLogInForm.TabIndex = 12
        '
        'onErrorMessageDialog
        '
        Me.onErrorMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.onErrorMessageDialog.Caption = Nothing
        Me.onErrorMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.[Error]
        Me.onErrorMessageDialog.Parent = Me
        Me.onErrorMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.onErrorMessageDialog.Text = Nothing
        '
        'onEmptyMessageDialog
        '
        Me.onEmptyMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.onEmptyMessageDialog.Caption = Nothing
        Me.onEmptyMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        Me.onEmptyMessageDialog.Parent = Me
        Me.onEmptyMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.onEmptyMessageDialog.Text = Nothing
        '
        'passwordLTextBox
        '
        Me.passwordLTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordLTextBox.DefaultText = ""
        Me.passwordLTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordLTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordLTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordLTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordLTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.passwordLTextBox.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.passwordLTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordLTextBox.IconRight = CType(resources.GetObject("passwordLTextBox.IconRight"), System.Drawing.Image)
        Me.passwordLTextBox.Location = New System.Drawing.Point(45, 223)
        Me.passwordLTextBox.Name = "passwordLTextBox"
        Me.passwordLTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.passwordLTextBox.PlaceholderText = ""
        Me.passwordLTextBox.SelectedText = ""
        Me.passwordLTextBox.Size = New System.Drawing.Size(222, 33)
        Me.passwordLTextBox.TabIndex = 22
        '
        'logInBtn
        '
        Me.logInBtn.AutoRoundedCorners = True
        Me.logInBtn.BorderRadius = 13
        Me.logInBtn.BorderThickness = 2
        Me.logInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logInBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logInBtn.FillColor = System.Drawing.Color.Black
        Me.logInBtn.FillColor2 = System.Drawing.Color.Black
        Me.logInBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.logInBtn.ForeColor = System.Drawing.Color.White
        Me.logInBtn.HoverState.BorderColor = System.Drawing.Color.Black
        Me.logInBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.logInBtn.HoverState.FillColor2 = System.Drawing.Color.White
        Me.logInBtn.HoverState.ForeColor = System.Drawing.Color.Black
        Me.logInBtn.Location = New System.Drawing.Point(45, 289)
        Me.logInBtn.Name = "logInBtn"
        Me.logInBtn.Size = New System.Drawing.Size(222, 29)
        Me.logInBtn.TabIndex = 21
        Me.logInBtn.Text = "LOG IN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Hello Again!"
        '
        'orLabel
        '
        Me.orLabel.BackColor = System.Drawing.Color.Transparent
        Me.orLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orLabel.Location = New System.Drawing.Point(148, 331)
        Me.orLabel.Name = "orLabel"
        Me.orLabel.Size = New System.Drawing.Size(16, 19)
        Me.orLabel.TabIndex = 19
        Me.orLabel.Text = "or"
        '
        'signUpBtn
        '
        Me.signUpBtn.BackColor = System.Drawing.Color.Transparent
        Me.signUpBtn.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUpBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.signUpBtn.Location = New System.Drawing.Point(136, 356)
        Me.signUpBtn.Name = "signUpBtn"
        Me.signUpBtn.Size = New System.Drawing.Size(42, 17)
        Me.signUpBtn.TabIndex = 16
        Me.signUpBtn.Text = "Sign Up"
        '
        'usernameLTextBox
        '
        Me.usernameLTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameLTextBox.DefaultText = ""
        Me.usernameLTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernameLTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernameLTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameLTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameLTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.usernameLTextBox.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.usernameLTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameLTextBox.Location = New System.Drawing.Point(45, 155)
        Me.usernameLTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.usernameLTextBox.Name = "usernameLTextBox"
        Me.usernameLTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameLTextBox.PlaceholderText = ""
        Me.usernameLTextBox.SelectedText = ""
        Me.usernameLTextBox.Size = New System.Drawing.Size(222, 33)
        Me.usernameLTextBox.TabIndex = 15
        '
        'rememberCheckBox
        '
        Me.rememberCheckBox.AutoSize = True
        Me.rememberCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rememberCheckBox.CheckedState.BorderRadius = 0
        Me.rememberCheckBox.CheckedState.BorderThickness = 0
        Me.rememberCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rememberCheckBox.Location = New System.Drawing.Point(45, 266)
        Me.rememberCheckBox.Name = "rememberCheckBox"
        Me.rememberCheckBox.Size = New System.Drawing.Size(101, 19)
        Me.rememberCheckBox.TabIndex = 23
        Me.rememberCheckBox.Text = "Remember me"
        Me.rememberCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rememberCheckBox.UncheckedState.BorderRadius = 0
        Me.rememberCheckBox.UncheckedState.BorderThickness = 0
        Me.rememberCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'logInPanel
        '
        Me.logInPanel.Controls.Add(Me.signupPanelF)
        Me.logInPanel.Controls.Add(Me.passwordLabel)
        Me.logInPanel.Controls.Add(Me.usernameLabel)
        Me.logInPanel.Controls.Add(Me.rightLinePanel)
        Me.logInPanel.Controls.Add(Me.leftLinePanel)
        Me.logInPanel.Controls.Add(Me.closeLogInForm)
        Me.logInPanel.Controls.Add(Me.rememberCheckBox)
        Me.logInPanel.Controls.Add(Me.usernameLTextBox)
        Me.logInPanel.Controls.Add(Me.passwordLTextBox)
        Me.logInPanel.Controls.Add(Me.signUpBtn)
        Me.logInPanel.Controls.Add(Me.logInBtn)
        Me.logInPanel.Controls.Add(Me.Label1)
        Me.logInPanel.Controls.Add(Me.orLabel)
        Me.logInPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.logInPanel.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logInPanel.Location = New System.Drawing.Point(440, 0)
        Me.logInPanel.Name = "logInPanel"
        Me.logInPanel.Size = New System.Drawing.Size(306, 459)
        Me.logInPanel.TabIndex = 24
        '
        'passwordLabel
        '
        Me.passwordLabel.BackColor = System.Drawing.Color.Transparent
        Me.passwordLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.Location = New System.Drawing.Point(45, 198)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(53, 19)
        Me.passwordLabel.TabIndex = 27
        Me.passwordLabel.Text = "Password"
        '
        'usernameLabel
        '
        Me.usernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.usernameLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLabel.Location = New System.Drawing.Point(45, 130)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(58, 19)
        Me.usernameLabel.TabIndex = 26
        Me.usernameLabel.Text = "Username"
        '
        'rightLinePanel
        '
        Me.rightLinePanel.FillColor = System.Drawing.Color.Black
        Me.rightLinePanel.Location = New System.Drawing.Point(172, 342)
        Me.rightLinePanel.Name = "rightLinePanel"
        Me.rightLinePanel.Size = New System.Drawing.Size(95, 1)
        Me.rightLinePanel.TabIndex = 25
        '
        'leftLinePanel
        '
        Me.leftLinePanel.FillColor = System.Drawing.Color.Black
        Me.leftLinePanel.Location = New System.Drawing.Point(45, 342)
        Me.leftLinePanel.Name = "leftLinePanel"
        Me.leftLinePanel.Size = New System.Drawing.Size(95, 1)
        Me.leftLinePanel.TabIndex = 24
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(746, 459)
        Me.Controls.Add(Me.logInPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pictureBoxConnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.leftPanel.ResumeLayout(False)
        Me.signupPanelS.ResumeLayout(False)
        Me.signupPanelS.PerformLayout()
        Me.signupPanelF.ResumeLayout(False)
        Me.signupPanelF.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logInPanel.ResumeLayout(False)
        Me.logInPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogInFormStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pictureBoxConnect As PictureBox
    Friend WithEvents leftPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents signupPanelF As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents passwordSTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents emailSTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernameSTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lastNameSTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents firstNameSTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents closeSPanelS As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents closeSPanelF As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents closeLogInForm As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents birthDayPicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents signUpUser As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents signUpNextBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents joinUsLabel As Label
    Friend WithEvents onErrorMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents onEmptyMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents signupPanelS As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents passwordLTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents logInBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents orLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents signUpBtn As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents usernameLTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rememberCheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents logInPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents usernameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents rightLinePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents leftLinePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents passwordLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents passwordSLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents emailSLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents usernameSLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lastNameSLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents firstNameSLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents femaleSRadioBtn As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents maleSRadioBtn As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents birthDateSLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents genderSLabel As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
