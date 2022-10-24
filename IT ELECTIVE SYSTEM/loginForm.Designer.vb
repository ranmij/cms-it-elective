<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.mainWindow = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.signUpPanel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.signUpPanel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.signUpNextBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.closePanel1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.signUpUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.signUpPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.signUpEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.joinUsLabel = New System.Windows.Forms.Label()
        Me.signUpUser = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.closePanel2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.birthDayPicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lastNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.firstNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.closeLogInForm = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.onErrorMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.onEmptyMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.logInBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.orLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.signUpBtn = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.userName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.checkBoxControl = New Guna.UI2.WinForms.Guna2CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.signUpPanel2.SuspendLayout()
        Me.signUpPanel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainWindow
        '
        Me.mainWindow.AnimateWindow = True
        Me.mainWindow.ContainerControl = Me
        Me.mainWindow.DockIndicatorTransparencyValue = 0.6R
        Me.mainWindow.ResizeForm = False
        Me.mainWindow.TransparentWhileDrag = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.connect2
        Me.PictureBox1.Location = New System.Drawing.Point(19, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 252)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(440, 459)
        Me.Guna2Panel1.TabIndex = 10
        '
        'signUpPanel2
        '
        Me.signUpPanel2.Controls.Add(Me.Guna2ComboBox1)
        Me.signUpPanel2.Controls.Add(Me.joinUsLabel)
        Me.signUpPanel2.Controls.Add(Me.signUpUser)
        Me.signUpPanel2.Controls.Add(Me.closePanel2)
        Me.signUpPanel2.Controls.Add(Me.birthDayPicker)
        Me.signUpPanel2.Controls.Add(Me.lastNameTextBox)
        Me.signUpPanel2.Controls.Add(Me.firstNameTextBox)
        Me.signUpPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.signUpPanel2.Location = New System.Drawing.Point(0, 0)
        Me.signUpPanel2.Name = "signUpPanel2"
        Me.signUpPanel2.Size = New System.Drawing.Size(302, 459)
        Me.signUpPanel2.TabIndex = 5
        Me.signUpPanel2.Visible = False
        '
        'signUpPanel1
        '
        Me.signUpPanel1.Controls.Add(Me.signUpPanel2)
        Me.signUpPanel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.signUpPanel1.Controls.Add(Me.signUpNextBtn)
        Me.signUpPanel1.Controls.Add(Me.closePanel1)
        Me.signUpPanel1.Controls.Add(Me.signUpUsername)
        Me.signUpPanel1.Controls.Add(Me.signUpPassword)
        Me.signUpPanel1.Controls.Add(Me.signUpEmail)
        Me.signUpPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.signUpPanel1.Location = New System.Drawing.Point(444, 0)
        Me.signUpPanel1.Name = "signUpPanel1"
        Me.signUpPanel1.Size = New System.Drawing.Size(302, 459)
        Me.signUpPanel1.TabIndex = 12
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.account
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.InitialImage = CType(resources.GetObject("Guna2CirclePictureBox1.InitialImage"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(123, 84)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(53, 53)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2CirclePictureBox1.TabIndex = 13
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'signUpNextBtn
        '
        Me.signUpNextBtn.AutoRoundedCorners = True
        Me.signUpNextBtn.BorderRadius = 16
        Me.signUpNextBtn.BorderThickness = 2
        Me.signUpNextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signUpNextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signUpNextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpNextBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpNextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signUpNextBtn.FillColor = System.Drawing.Color.Black
        Me.signUpNextBtn.FillColor2 = System.Drawing.Color.Black
        Me.signUpNextBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.signUpNextBtn.ForeColor = System.Drawing.Color.White
        Me.signUpNextBtn.HoverState.BorderColor = System.Drawing.Color.Black
        Me.signUpNextBtn.HoverState.FillColor = System.Drawing.Color.White
        Me.signUpNextBtn.HoverState.FillColor2 = System.Drawing.Color.White
        Me.signUpNextBtn.HoverState.ForeColor = System.Drawing.Color.Black
        Me.signUpNextBtn.Location = New System.Drawing.Point(186, 300)
        Me.signUpNextBtn.Name = "signUpNextBtn"
        Me.signUpNextBtn.Size = New System.Drawing.Size(81, 34)
        Me.signUpNextBtn.TabIndex = 9
        '
        'closePanel1
        '
        Me.closePanel1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.closePanel1.HoverState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closePanel1.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closePanel1.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closePanel1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.closePanel1.ImageRotate = 0!
        Me.closePanel1.ImageSize = New System.Drawing.Size(16, 16)
        Me.closePanel1.Location = New System.Drawing.Point(260, 3)
        Me.closePanel1.Name = "closePanel1"
        Me.closePanel1.PressedState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closePanel1.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closePanel1.Size = New System.Drawing.Size(37, 30)
        Me.closePanel1.TabIndex = 8
        '
        'signUpUsername
        '
        Me.signUpUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.signUpUsername.DefaultText = ""
        Me.signUpUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.signUpUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.signUpUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.signUpUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.signUpUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.signUpUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.signUpUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.signUpUsername.IconLeft = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.ic_user
        Me.signUpUsername.Location = New System.Drawing.Point(37, 157)
        Me.signUpUsername.Name = "signUpUsername"
        Me.signUpUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.signUpUsername.PlaceholderText = ""
        Me.signUpUsername.SelectedText = ""
        Me.signUpUsername.Size = New System.Drawing.Size(230, 30)
        Me.signUpUsername.TabIndex = 2
        '
        'signUpPassword
        '
        Me.signUpPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.signUpPassword.DefaultText = ""
        Me.signUpPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.signUpPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.signUpPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.signUpPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.signUpPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.signUpPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.signUpPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.signUpPassword.IconRight = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.ic_eye_crossed
        Me.signUpPassword.Location = New System.Drawing.Point(37, 252)
        Me.signUpPassword.Name = "signUpPassword"
        Me.signUpPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.signUpPassword.PlaceholderText = ""
        Me.signUpPassword.SelectedText = ""
        Me.signUpPassword.Size = New System.Drawing.Size(230, 30)
        Me.signUpPassword.TabIndex = 1
        '
        'signUpEmail
        '
        Me.signUpEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.signUpEmail.DefaultText = ""
        Me.signUpEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.signUpEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.signUpEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.signUpEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.signUpEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.signUpEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUpEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.signUpEmail.IconLeft = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.email
        Me.signUpEmail.Location = New System.Drawing.Point(37, 206)
        Me.signUpEmail.Name = "signUpEmail"
        Me.signUpEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.signUpEmail.PlaceholderText = ""
        Me.signUpEmail.SelectedText = ""
        Me.signUpEmail.Size = New System.Drawing.Size(230, 30)
        Me.signUpEmail.TabIndex = 0
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(35, 240)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(230, 36)
        Me.Guna2ComboBox1.TabIndex = 10
        '
        'joinUsLabel
        '
        Me.joinUsLabel.AutoSize = True
        Me.joinUsLabel.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.joinUsLabel.Location = New System.Drawing.Point(97, 100)
        Me.joinUsLabel.Name = "joinUsLabel"
        Me.joinUsLabel.Size = New System.Drawing.Size(0, 30)
        Me.joinUsLabel.TabIndex = 9
        '
        'signUpUser
        '
        Me.signUpUser.AutoRoundedCorners = True
        Me.signUpUser.BorderRadius = 16
        Me.signUpUser.BorderThickness = 2
        Me.signUpUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.signUpUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.signUpUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.signUpUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.signUpUser.FillColor = System.Drawing.Color.Black
        Me.signUpUser.FillColor2 = System.Drawing.Color.Black
        Me.signUpUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.signUpUser.ForeColor = System.Drawing.Color.White
        Me.signUpUser.HoverState.BorderColor = System.Drawing.Color.Black
        Me.signUpUser.HoverState.FillColor = System.Drawing.Color.White
        Me.signUpUser.HoverState.FillColor2 = System.Drawing.Color.White
        Me.signUpUser.HoverState.ForeColor = System.Drawing.Color.Black
        Me.signUpUser.Location = New System.Drawing.Point(186, 338)
        Me.signUpUser.Name = "signUpUser"
        Me.signUpUser.Size = New System.Drawing.Size(81, 34)
        Me.signUpUser.TabIndex = 8
        '
        'closePanel2
        '
        Me.closePanel2.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.closePanel2.HoverState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closePanel2.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closePanel2.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closePanel2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.closePanel2.ImageRotate = 0!
        Me.closePanel2.ImageSize = New System.Drawing.Size(16, 16)
        Me.closePanel2.Location = New System.Drawing.Point(260, 3)
        Me.closePanel2.Name = "closePanel2"
        Me.closePanel2.PressedState.Image = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.close
        Me.closePanel2.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closePanel2.Size = New System.Drawing.Size(37, 30)
        Me.closePanel2.TabIndex = 7
        '
        'birthDayPicker
        '
        Me.birthDayPicker.BackColor = System.Drawing.Color.Transparent
        Me.birthDayPicker.BorderColor = System.Drawing.Color.Transparent
        Me.birthDayPicker.BorderRadius = 3
        Me.birthDayPicker.Checked = True
        Me.birthDayPicker.FillColor = System.Drawing.Color.White
        Me.birthDayPicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.birthDayPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.birthDayPicker.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.birthDayPicker.IndicateFocus = True
        Me.birthDayPicker.Location = New System.Drawing.Point(37, 292)
        Me.birthDayPicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.birthDayPicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.birthDayPicker.Name = "birthDayPicker"
        Me.birthDayPicker.Size = New System.Drawing.Size(230, 36)
        Me.birthDayPicker.TabIndex = 5
        Me.birthDayPicker.UseTransparentBackground = True
        Me.birthDayPicker.Value = New Date(2022, 10, 13, 22, 31, 1, 779)
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastNameTextBox.DefaultText = ""
        Me.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.lastNameTextBox.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastNameTextBox.Location = New System.Drawing.Point(35, 191)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lastNameTextBox.PlaceholderText = ""
        Me.lastNameTextBox.SelectedText = ""
        Me.lastNameTextBox.Size = New System.Drawing.Size(230, 30)
        Me.lastNameTextBox.TabIndex = 4
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstNameTextBox.DefaultText = ""
        Me.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.firstNameTextBox.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstNameTextBox.Location = New System.Drawing.Point(35, 143)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNameTextBox.PlaceholderText = ""
        Me.firstNameTextBox.SelectedText = ""
        Me.firstNameTextBox.Size = New System.Drawing.Size(230, 30)
        Me.firstNameTextBox.TabIndex = 3
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
        Me.closeLogInForm.Location = New System.Drawing.Point(706, 3)
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
        'password
        '
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.DefaultText = ""
        Me.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.password.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.IconRight = CType(resources.GetObject("password.IconRight"), System.Drawing.Image)
        Me.password.Location = New System.Drawing.Point(479, 207)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.password.PlaceholderText = ""
        Me.password.SelectedText = ""
        Me.password.Size = New System.Drawing.Size(222, 33)
        Me.password.TabIndex = 22
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
        Me.logInBtn.Location = New System.Drawing.Point(479, 273)
        Me.logInBtn.Name = "logInBtn"
        Me.logInBtn.Size = New System.Drawing.Size(222, 29)
        Me.logInBtn.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Hello Again!"
        '
        'orLabel
        '
        Me.orLabel.BackColor = System.Drawing.Color.Transparent
        Me.orLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orLabel.Location = New System.Drawing.Point(583, 319)
        Me.orLabel.Name = "orLabel"
        Me.orLabel.Size = New System.Drawing.Size(3, 2)
        Me.orLabel.TabIndex = 19
        Me.orLabel.Text = Nothing
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(606, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(95, 1)
        Me.Panel2.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(479, 330)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 1)
        Me.Panel1.TabIndex = 17
        '
        'signUpBtn
        '
        Me.signUpBtn.BackColor = System.Drawing.Color.Transparent
        Me.signUpBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUpBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.signUpBtn.Location = New System.Drawing.Point(569, 352)
        Me.signUpBtn.Name = "signUpBtn"
        Me.signUpBtn.Size = New System.Drawing.Size(3, 2)
        Me.signUpBtn.TabIndex = 16
        Me.signUpBtn.Text = Nothing
        '
        'userName
        '
        Me.userName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.userName.DefaultText = ""
        Me.userName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.userName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.userName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.userName.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.userName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userName.IconLeft = CType(resources.GetObject("userName.IconLeft"), System.Drawing.Image)
        Me.userName.Location = New System.Drawing.Point(479, 154)
        Me.userName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.userName.Name = "userName"
        Me.userName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userName.PlaceholderText = ""
        Me.userName.SelectedText = ""
        Me.userName.Size = New System.Drawing.Size(222, 33)
        Me.userName.TabIndex = 15
        '
        'checkBoxControl
        '
        Me.checkBoxControl.AutoSize = True
        Me.checkBoxControl.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkBoxControl.CheckedState.BorderRadius = 0
        Me.checkBoxControl.CheckedState.BorderThickness = 0
        Me.checkBoxControl.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkBoxControl.Location = New System.Drawing.Point(479, 251)
        Me.checkBoxControl.Name = "checkBoxControl"
        Me.checkBoxControl.Size = New System.Drawing.Size(15, 14)
        Me.checkBoxControl.TabIndex = 23
        Me.checkBoxControl.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkBoxControl.UncheckedState.BorderRadius = 0
        Me.checkBoxControl.UncheckedState.BorderThickness = 0
        Me.checkBoxControl.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(746, 459)
        Me.Controls.Add(Me.signUpPanel1)
        Me.Controls.Add(Me.checkBoxControl)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.logInBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.orLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.signUpBtn)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.closeLogInForm)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.signUpPanel2.ResumeLayout(False)
        Me.signUpPanel2.PerformLayout()
        Me.signUpPanel1.ResumeLayout(False)
        Me.signUpPanel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainWindow As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents signUpPanel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents signUpPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents signUpEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents signUpUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lastNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents firstNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents closePanel2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents closePanel1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents closeLogInForm As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents birthDayPicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents signUpUser As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents signUpNextBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents joinUsLabel As Label
    Friend WithEvents onErrorMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents onEmptyMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents signUpPanel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents logInBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label1 As Label
    Friend WithEvents orLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents signUpBtn As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents userName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents checkBoxControl As Guna.UI2.WinForms.Guna2CheckBox
End Class
