<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splashScreen
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
        Me.appName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pauseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.formAnim = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.windowAnim = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.SuspendLayout()
        '
        'appName
        '
        Me.appName.BackColor = System.Drawing.Color.Transparent
        Me.appName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.appName.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appName.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.appName.Location = New System.Drawing.Point(51, 117)
        Me.appName.Name = "appName"
        Me.appName.Size = New System.Drawing.Size(3, 2)
        Me.appName.TabIndex = 0
        Me.appName.Text = Nothing
        Me.appName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pauseTimer
        '
        '
        'formAnim
        '
        Me.formAnim.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE
        Me.formAnim.BorderRadius = 5
        Me.formAnim.ContainerControl = Me
        Me.formAnim.DockIndicatorTransparencyValue = 0.6R
        Me.formAnim.ResizeForm = False
        Me.formAnim.TransparentWhileDrag = True
        '
        'windowAnim
        '
        Me.windowAnim.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        Me.windowAnim.TargetForm = Me
        '
        'splashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImage = Global.IT_ELECTIVE_SYSTEM.My.Resources.Resources.wave
        Me.ClientSize = New System.Drawing.Size(499, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.appName)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "splashScreen"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents appName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pauseTimer As Timer
    Friend WithEvents formAnim As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents windowAnim As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
