<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassConfirm = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cbxCourse = New System.Windows.Forms.ComboBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.lblStudID = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(392, 220)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(91, 17)
        Me.lblEmail.TabIndex = 103
        Me.lblEmail.Text = "Email address"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(236, 220)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(101, 17)
        Me.lblPhone.TabIndex = 102
        Me.lblPhone.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(236, 248)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(119, 20)
        Me.txtPhone.TabIndex = 101
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(395, 248)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(174, 20)
        Me.txtEmail.TabIndex = 100
        '
        'txtPassConfirm
        '
        Me.txtPassConfirm.Location = New System.Drawing.Point(395, 315)
        Me.txtPassConfirm.Name = "txtPassConfirm"
        Me.txtPassConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassConfirm.Size = New System.Drawing.Size(121, 20)
        Me.txtPassConfirm.TabIndex = 99
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(392, 287)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(118, 17)
        Me.lblConfirm.TabIndex = 98
        Me.lblConfirm.Text = "Confirm Password"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(392, 159)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(50, 17)
        Me.lblCourse.TabIndex = 97
        Me.lblCourse.Text = "Course"
        '
        'cbxCourse
        '
        Me.cbxCourse.FormattingEnabled = True
        Me.cbxCourse.Items.AddRange(New Object() {"AC110", "AC120", "AD110", "AM110", "AM120", "AP111", "AP114", "BA111", "BA114", "CS110", "CS111", "CS112", "CS143", "EC111", "EC110", "EH110", "EM110", "FH111", "FH112"})
        Me.cbxCourse.Location = New System.Drawing.Point(395, 185)
        Me.cbxCourse.Name = "cbxCourse"
        Me.cbxCourse.Size = New System.Drawing.Size(119, 21)
        Me.cbxCourse.TabIndex = 96
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(237, 185)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(118, 20)
        Me.txtStudentID.TabIndex = 95
        '
        'lblStudID
        '
        Me.lblStudID.AutoSize = True
        Me.lblStudID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudID.Location = New System.Drawing.Point(239, 159)
        Me.lblStudID.Name = "lblStudID"
        Me.lblStudID.Size = New System.Drawing.Size(73, 17)
        Me.lblStudID.TabIndex = 94
        Me.lblStudID.Text = "Student ID"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(236, 128)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(249, 20)
        Me.txtName.TabIndex = 93
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(237, 98)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 17)
        Me.lblName.TabIndex = 92
        Me.lblName.Text = "Full Name"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(237, 373)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 43)
        Me.btnBack.TabIndex = 91
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(388, 373)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(113, 43)
        Me.btnLogin.TabIndex = 90
        Me.btnLogin.Text = "Create"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(237, 315)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtPassword.TabIndex = 89
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(234, 287)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(66, 17)
        Me.lblPass.TabIndex = 88
        Me.lblPass.Text = "Password"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(232, 35)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(250, 25)
        Me.lblRegister.TabIndex = 87
        Me.lblRegister.Text = "REGISTER YOUR ACCOUNT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 17)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Fill in the Information box below :"
        '
        'frmStudentRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPassConfirm)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.cbxCourse)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.lblStudID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblRegister)
        Me.Name = "frmStudentRegister"
        Me.Text = "Student Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassConfirm As TextBox
    Friend WithEvents lblConfirm As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents cbxCourse As ComboBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents lblStudID As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents Label1 As Label
End Class
