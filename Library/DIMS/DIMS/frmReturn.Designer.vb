<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbShelf = New System.Windows.Forms.TextBox()
        Me.tbBookID = New System.Windows.Forms.TextBox()
        Me.tbGenre = New System.Windows.Forms.TextBox()
        Me.tbAuthor = New System.Windows.Forms.TextBox()
        Me.btReturn = New System.Windows.Forms.Button()
        Me.cbBook = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 28)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Shelf Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 28)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Genre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 28)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Book ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 28)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Please Choose Book That You Want To Return"
        '
        'tbShelf
        '
        Me.tbShelf.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbShelf.Location = New System.Drawing.Point(168, 212)
        Me.tbShelf.Name = "tbShelf"
        Me.tbShelf.ReadOnly = True
        Me.tbShelf.Size = New System.Drawing.Size(198, 33)
        Me.tbShelf.TabIndex = 27
        '
        'tbBookID
        '
        Me.tbBookID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBookID.Location = New System.Drawing.Point(168, 39)
        Me.tbBookID.Name = "tbBookID"
        Me.tbBookID.ReadOnly = True
        Me.tbBookID.Size = New System.Drawing.Size(198, 33)
        Me.tbBookID.TabIndex = 26
        '
        'tbGenre
        '
        Me.tbGenre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGenre.Location = New System.Drawing.Point(168, 157)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.ReadOnly = True
        Me.tbGenre.Size = New System.Drawing.Size(198, 33)
        Me.tbGenre.TabIndex = 25
        '
        'tbAuthor
        '
        Me.tbAuthor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAuthor.Location = New System.Drawing.Point(168, 97)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.ReadOnly = True
        Me.tbAuthor.Size = New System.Drawing.Size(198, 33)
        Me.tbAuthor.TabIndex = 24
        '
        'btReturn
        '
        Me.btReturn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btReturn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReturn.Location = New System.Drawing.Point(397, 499)
        Me.btReturn.Name = "btReturn"
        Me.btReturn.Size = New System.Drawing.Size(168, 61)
        Me.btReturn.TabIndex = 23
        Me.btReturn.Text = "Return"
        Me.btReturn.UseVisualStyleBackColor = False
        '
        'cbBook
        '
        Me.cbBook.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBook.FormattingEnabled = True
        Me.cbBook.Location = New System.Drawing.Point(155, 140)
        Me.cbBook.Name = "cbBook"
        Me.cbBook.Size = New System.Drawing.Size(464, 31)
        Me.cbBook.TabIndex = 22
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(199, 499)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(168, 61)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tbBookID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbShelf)
        Me.GroupBox1.Controls.Add(Me.tbAuthor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbGenre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(199, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 279)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Information:"
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(784, 592)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btReturn)
        Me.Controls.Add(Me.cbBook)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmReturn"
        Me.Text = "Return Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbShelf As TextBox
    Friend WithEvents tbBookID As TextBox
    Friend WithEvents tbGenre As TextBox
    Friend WithEvents tbAuthor As TextBox
    Friend WithEvents btReturn As Button
    Friend WithEvents cbBook As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
