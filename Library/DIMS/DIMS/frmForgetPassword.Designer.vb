<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgetPassword
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
        Me.gbxCheck = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbxUpdate = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbxCheck.SuspendLayout()
        Me.gbxUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCheck
        '
        Me.gbxCheck.BackColor = System.Drawing.Color.Transparent
        Me.gbxCheck.Controls.Add(Me.txtPhone)
        Me.gbxCheck.Controls.Add(Me.txtEmail)
        Me.gbxCheck.Controls.Add(Me.Label2)
        Me.gbxCheck.Controls.Add(Me.Label3)
        Me.gbxCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCheck.Location = New System.Drawing.Point(123, 156)
        Me.gbxCheck.Name = "gbxCheck"
        Me.gbxCheck.Size = New System.Drawing.Size(252, 144)
        Me.gbxCheck.TabIndex = 31
        Me.gbxCheck.TabStop = False
        Me.gbxCheck.Text = "Student Information"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(12, 52)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 21)
        Me.txtPhone.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(12, 105)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(226, 21)
        Me.txtEmail.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'gbxUpdate
        '
        Me.gbxUpdate.BackColor = System.Drawing.Color.Transparent
        Me.gbxUpdate.Controls.Add(Me.txtPassword)
        Me.gbxUpdate.Controls.Add(Me.Label6)
        Me.gbxUpdate.Controls.Add(Me.txtConfirmPass)
        Me.gbxUpdate.Controls.Add(Me.Label5)
        Me.gbxUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxUpdate.Location = New System.Drawing.Point(403, 156)
        Me.gbxUpdate.Name = "gbxUpdate"
        Me.gbxUpdate.Size = New System.Drawing.Size(272, 144)
        Me.gbxUpdate.TabIndex = 30
        Me.gbxUpdate.TabStop = False
        Me.gbxUpdate.Text = "Update Account"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(21, 65)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 21)
        Me.txtPassword.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(141, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Confirm Password"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(144, 65)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(100, 21)
        Me.txtConfirmPass.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password"
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(403, 306)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(87, 36)
        Me.btnEnter.TabIndex = 29
        Me.btnEnter.Text = "Update"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(578, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Enter the details below with registered Information and insert A new Password"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(288, 306)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(87, 36)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbxCheck)
        Me.Controls.Add(Me.gbxUpdate)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmForgetPassword"
        Me.Text = "Forget Password"
        Me.gbxCheck.ResumeLayout(False)
        Me.gbxCheck.PerformLayout()
        Me.gbxUpdate.ResumeLayout(False)
        Me.gbxUpdate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxCheck As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbxUpdate As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
