<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentMain
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
        Me.gbxInformation = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtMatric = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxInformation.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInformation
        '
        Me.gbxInformation.BackColor = System.Drawing.Color.Transparent
        Me.gbxInformation.Controls.Add(Me.txtPhone)
        Me.gbxInformation.Controls.Add(Me.lblPhone)
        Me.gbxInformation.Controls.Add(Me.txtEmail)
        Me.gbxInformation.Controls.Add(Me.lblEmail)
        Me.gbxInformation.Controls.Add(Me.txtCourse)
        Me.gbxInformation.Controls.Add(Me.txtMatric)
        Me.gbxInformation.Controls.Add(Me.txtName)
        Me.gbxInformation.Controls.Add(Me.Label3)
        Me.gbxInformation.Controls.Add(Me.Label2)
        Me.gbxInformation.Controls.Add(Me.Label1)
        Me.gbxInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbxInformation.Location = New System.Drawing.Point(214, 167)
        Me.gbxInformation.Name = "gbxInformation"
        Me.gbxInformation.Size = New System.Drawing.Size(372, 195)
        Me.gbxInformation.TabIndex = 4
        Me.gbxInformation.TabStop = False
        Me.gbxInformation.Text = "STUDENT INFORMATION"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(134, 151)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(208, 23)
        Me.txtPhone.TabIndex = 9
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(17, 154)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(111, 17)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone Number :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(134, 122)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(208, 23)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(17, 125)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(50, 17)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email :"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(134, 93)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(208, 23)
        Me.txtCourse.TabIndex = 5
        '
        'txtMatric
        '
        Me.txtMatric.Location = New System.Drawing.Point(134, 63)
        Me.txtMatric.Name = "txtMatric"
        Me.txtMatric.ReadOnly = True
        Me.txtMatric.Size = New System.Drawing.Size(208, 23)
        Me.txtMatric.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(134, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(208, 23)
        Me.txtName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matric Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.BooksToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem1.Text = "Logout"
        '
        'BooksToolStripMenuItem1
        '
        Me.BooksToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowToolStripMenuItem1, Me.ReturnToolStripMenuItem1})
        Me.BooksToolStripMenuItem1.Name = "BooksToolStripMenuItem1"
        Me.BooksToolStripMenuItem1.Size = New System.Drawing.Size(51, 20)
        Me.BooksToolStripMenuItem1.Text = "Books"
        '
        'BorrowToolStripMenuItem1
        '
        Me.BorrowToolStripMenuItem1.Name = "BorrowToolStripMenuItem1"
        Me.BorrowToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.BorrowToolStripMenuItem1.Text = "Borrow"
        '
        'ReturnToolStripMenuItem1
        '
        Me.ReturnToolStripMenuItem1.Name = "ReturnToolStripMenuItem1"
        Me.ReturnToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ReturnToolStripMenuItem1.Text = "Return"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Logout"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowToolStripMenuItem, Me.ReturnToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'BorrowToolStripMenuItem
        '
        Me.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem"
        Me.BorrowToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.BorrowToolStripMenuItem.Text = "Borrow"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'frmStudentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbxInformation)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStudentMain"
        Me.Text = "Student Main"
        Me.gbxInformation.ResumeLayout(False)
        Me.gbxInformation.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxInformation As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtMatric As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BorrowToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem1 As ToolStripMenuItem
End Class
