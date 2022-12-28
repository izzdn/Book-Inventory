<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(262, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(277, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "New User? Click button below to register"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Tan
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegister.Location = New System.Drawing.Point(340, 331)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(121, 48)
        Me.btnRegister.TabIndex = 38
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.Tan
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.White
        Me.btnStaff.Location = New System.Drawing.Point(417, 230)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(144, 50)
        Me.btnStaff.TabIndex = 37
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.Tan
        Me.btnStudent.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnStudent.Location = New System.Drawing.Point(239, 230)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(144, 50)
        Me.btnStudent.TabIndex = 36
        Me.btnStudent.Text = "Student"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(358, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Log in As"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.DIMS.My.Resources.Resources.bg4
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 40
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
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Main Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
