﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("IT_ELECTIVE_SYSTEM.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to or.
        '''</summary>
        Friend ReadOnly Property _or() As String
            Get
                Return ResourceManager.GetString("or", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property account() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("account", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add Student.
        '''</summary>
        Friend ReadOnly Property addStudentBtnText() As String
            Get
                Return ResourceManager.GetString("addStudentBtnText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to COLLEGE MANAGEMENT SYSTEM.
        '''</summary>
        Friend ReadOnly Property appName() As String
            Get
                Return ResourceManager.GetString("appName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property cap() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("cap", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property close() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("close", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property connect2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("connect2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property course() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("course", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Courses.
        '''</summary>
        Friend ReadOnly Property coursesText() As String
            Get
                Return ResourceManager.GetString("coursesText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property dashboard() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("dashboard", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dashboard.
        '''</summary>
        Friend ReadOnly Property dashboardText() As String
            Get
                Return ResourceManager.GetString("dashboardText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property email() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("email", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Email.
        '''</summary>
        Friend ReadOnly Property emailHint() As String
            Get
                Return ResourceManager.GetString("emailHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid username or password..
        '''</summary>
        Friend ReadOnly Property failedLogInCaption() As String
            Get
                Return ResourceManager.GetString("failedLogInCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please try again..
        '''</summary>
        Friend ReadOnly Property failedLogInText() As String
            Get
                Return ResourceManager.GetString("failedLogInText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Annual Fees.
        '''</summary>
        Friend ReadOnly Property feesHint() As String
            Get
                Return ResourceManager.GetString("feesHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to First Name.
        '''</summary>
        Friend ReadOnly Property firstNameHint() As String
            Get
                Return ResourceManager.GetString("firstNameHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ic_eye() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ic_eye", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ic_eye_crossed() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ic_eye_crossed", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ic_user() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ic_user", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Join Us!.
        '''</summary>
        Friend ReadOnly Property joinUsLabel() As String
            Get
                Return ResourceManager.GetString("joinUsLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Last Name.
        '''</summary>
        Friend ReadOnly Property lastNameHint() As String
            Get
                Return ResourceManager.GetString("lastNameHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property log_out() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("log_out", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fields can&apos;t be empty!.
        '''</summary>
        Friend ReadOnly Property logInEmptyFieldsCaption() As String
            Get
                Return ResourceManager.GetString("logInEmptyFieldsCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please provide a username and password..
        '''</summary>
        Friend ReadOnly Property logInEmptyFieldsText() As String
            Get
                Return ResourceManager.GetString("logInEmptyFieldsText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid username or password.
        '''</summary>
        Friend ReadOnly Property logInErrorCaption() As String
            Get
                Return ResourceManager.GetString("logInErrorCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please try again..
        '''</summary>
        Friend ReadOnly Property logInErrorText() As String
            Get
                Return ResourceManager.GetString("logInErrorText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Password can&apos;t be empty!.
        '''</summary>
        Friend ReadOnly Property logInPasswordEmptyCaption() As String
            Get
                Return ResourceManager.GetString("logInPasswordEmptyCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please provide a password..
        '''</summary>
        Friend ReadOnly Property logInPasswordEmptyText() As String
            Get
                Return ResourceManager.GetString("logInPasswordEmptyText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to LOG IN.
        '''</summary>
        Friend ReadOnly Property logInText() As String
            Get
                Return ResourceManager.GetString("logInText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Username can&apos;t be empty!.
        '''</summary>
        Friend ReadOnly Property logInUsernameEmptyCaption() As String
            Get
                Return ResourceManager.GetString("logInUsernameEmptyCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please provide a username..
        '''</summary>
        Friend ReadOnly Property logInUsernameEmptyText() As String
            Get
                Return ResourceManager.GetString("logInUsernameEmptyText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log Out.
        '''</summary>
        Friend ReadOnly Property logOutText() As String
            Get
                Return ResourceManager.GetString("logOutText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property menu() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("menu", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Menu.
        '''</summary>
        Friend ReadOnly Property menuLabelText() As String
            Get
                Return ResourceManager.GetString("menuLabelText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Next.
        '''</summary>
        Friend ReadOnly Property nextBtn() As String
            Get
                Return ResourceManager.GetString("nextBtn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to •.
        '''</summary>
        Friend ReadOnly Property passwordHideText() As String
            Get
                Return ResourceManager.GetString("passwordHideText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Password.
        '''</summary>
        Friend ReadOnly Property passwordHint() As String
            Get
                Return ResourceManager.GetString("passwordHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Phone Number.
        '''</summary>
        Friend ReadOnly Property phoneHint() As String
            Get
                Return ResourceManager.GetString("phoneHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Profile.
        '''</summary>
        Friend ReadOnly Property profileText() As String
            Get
                Return ResourceManager.GetString("profileText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remember me.
        '''</summary>
        Friend ReadOnly Property rememberMeText() As String
            Get
                Return ResourceManager.GetString("rememberMeText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property search() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("search", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Search.
        '''</summary>
        Friend ReadOnly Property searchBtnHint() As String
            Get
                Return ResourceManager.GetString("searchBtnHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Email can&apos;t be empty!.
        '''</summary>
        Friend ReadOnly Property signUpEmailEmptyCaption() As String
            Get
                Return ResourceManager.GetString("signUpEmailEmptyCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please provide an email..
        '''</summary>
        Friend ReadOnly Property signUpEmailEmptyText() As String
            Get
                Return ResourceManager.GetString("signUpEmailEmptyText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to First Name can&apos;t be empty!.
        '''</summary>
        Friend ReadOnly Property signUpFirstNameEmptyCaption() As String
            Get
                Return ResourceManager.GetString("signUpFirstNameEmptyCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please provide a first name..
        '''</summary>
        Friend ReadOnly Property signUpFirstNameEmptyText() As String
            Get
                Return ResourceManager.GetString("signUpFirstNameEmptyText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Last Name can&apos;t be empty!.
        '''</summary>
        Friend ReadOnly Property signUpLastNameEmptyCaption() As String
            Get
                Return ResourceManager.GetString("signUpLastNameEmptyCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please provide a last name..
        '''</summary>
        Friend ReadOnly Property signUpLastNameEmptyText() As String
            Get
                Return ResourceManager.GetString("signUpLastNameEmptyText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SIGN UP.
        '''</summary>
        Friend ReadOnly Property signUpText() As String
            Get
                Return ResourceManager.GetString("signUpText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property students() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("students", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Students.
        '''</summary>
        Friend ReadOnly Property studentsText() As String
            Get
                Return ResourceManager.GetString("studentsText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property teacher() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("teacher", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Teachers.
        '''</summary>
        Friend ReadOnly Property teachersText() As String
            Get
                Return ResourceManager.GetString("teachersText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property user() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("user", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Username.
        '''</summary>
        Friend ReadOnly Property userNameHint() As String
            Get
                Return ResourceManager.GetString("userNameHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property wave() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("wave", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
