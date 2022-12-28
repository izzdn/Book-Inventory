<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffMain
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
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayBookListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateBookListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayBorrowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayBorrowListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayFavouriteGenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksBorrowedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.gbxInformation.Controls.Add(Me.txtStaffID)
        Me.gbxInformation.Controls.Add(Me.txtName)
        Me.gbxInformation.Controls.Add(Me.Label2)
        Me.gbxInformation.Controls.Add(Me.Label4)
        Me.gbxInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInformation.Location = New System.Drawing.Point(214, 166)
        Me.gbxInformation.Name = "gbxInformation"
        Me.gbxInformation.Size = New System.Drawing.Size(372, 185)
        Me.gbxInformation.TabIndex = 15
        Me.gbxInformation.TabStop = False
        Me.gbxInformation.Text = "STAFF INFORMATION"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(126, 124)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(208, 23)
        Me.txtPhone.TabIndex = 9
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(17, 127)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(111, 17)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone Number :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(126, 94)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(208, 23)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(17, 98)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(50, 17)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email :"
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(126, 64)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.Size = New System.Drawing.Size(208, 23)
        Me.txtStaffID.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(126, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(208, 23)
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Staff ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Staff Name :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.BooksToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'BooksToolStripMenuItem1
        '
        Me.BooksToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayBookListToolStripMenuItem, Me.UpdateBookListToolStripMenuItem, Me.DisplayBorrowerToolStripMenuItem, Me.DisplayBorrowListToolStripMenuItem, Me.DisplayFavouriteGenreToolStripMenuItem})
        Me.BooksToolStripMenuItem1.Name = "BooksToolStripMenuItem1"
        Me.BooksToolStripMenuItem1.Size = New System.Drawing.Size(51, 20)
        Me.BooksToolStripMenuItem1.Text = "Books"
        '
        'DisplayBookListToolStripMenuItem
        '
        Me.DisplayBookListToolStripMenuItem.Name = "DisplayBookListToolStripMenuItem"
        Me.DisplayBookListToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DisplayBookListToolStripMenuItem.Text = "Display BookList"
        '
        'UpdateBookListToolStripMenuItem
        '
        Me.UpdateBookListToolStripMenuItem.Name = "UpdateBookListToolStripMenuItem"
        Me.UpdateBookListToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.UpdateBookListToolStripMenuItem.Text = "Update BookList"
        '
        'DisplayBorrowerToolStripMenuItem
        '
        Me.DisplayBorrowerToolStripMenuItem.Name = "DisplayBorrowerToolStripMenuItem"
        Me.DisplayBorrowerToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DisplayBorrowerToolStripMenuItem.Text = "Display BorrowList"
        '
        'DisplayBorrowListToolStripMenuItem
        '
        Me.DisplayBorrowListToolStripMenuItem.Name = "DisplayBorrowListToolStripMenuItem"
        Me.DisplayBorrowListToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DisplayBorrowListToolStripMenuItem.Text = "Update BorrowList"
        '
        'DisplayFavouriteGenreToolStripMenuItem
        '
        Me.DisplayFavouriteGenreToolStripMenuItem.Name = "DisplayFavouriteGenreToolStripMenuItem"
        Me.DisplayFavouriteGenreToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DisplayFavouriteGenreToolStripMenuItem.Text = "Display Most Popular Book"
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
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookListToolStripMenuItem, Me.UpdateBookToolStripMenuItem, Me.BooksBorrowedToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'BookListToolStripMenuItem
        '
        Me.BookListToolStripMenuItem.Name = "BookListToolStripMenuItem"
        Me.BookListToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BookListToolStripMenuItem.Text = "BookList"
        '
        'UpdateBookToolStripMenuItem
        '
        Me.UpdateBookToolStripMenuItem.Name = "UpdateBookToolStripMenuItem"
        Me.UpdateBookToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.UpdateBookToolStripMenuItem.Text = "Update Book"
        '
        'BooksBorrowedToolStripMenuItem
        '
        Me.BooksBorrowedToolStripMenuItem.Name = "BooksBorrowedToolStripMenuItem"
        Me.BooksBorrowedToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BooksBorrowedToolStripMenuItem.Text = "Books Borrowed"
        '
        'frmStaffMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbxInformation)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStaffMain"
        Me.Text = "Staff Main"
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
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksBorrowedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DisplayBookListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateBookListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayBorrowerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayBorrowListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayFavouriteGenreToolStripMenuItem As ToolStripMenuItem
End Class
