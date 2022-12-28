<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowUpdate
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Book_TitleLabel As System.Windows.Forms.Label
        Dim BorrowerLabel As System.Windows.Forms.Label
        Dim Borrow_DateLabel As System.Windows.Forms.Label
        Dim Return_DateLabel As System.Windows.Forms.Label
        Dim CountLabel As System.Windows.Forms.Label
        Dim GenreLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New DIMS.DATABASEDataSet()
        Me.BorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowTableAdapter = New DIMS.DATABASEDataSetTableAdapters.borrowTableAdapter()
        Me.TableAdapterManager = New DIMS.DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GenreComboBox = New System.Windows.Forms.ComboBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Book_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowerTextBox = New System.Windows.Forms.TextBox()
        Me.Borrow_DateTextBox = New System.Windows.Forms.TextBox()
        Me.Return_DateTextBox = New System.Windows.Forms.TextBox()
        Me.CountTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        Book_TitleLabel = New System.Windows.Forms.Label()
        BorrowerLabel = New System.Windows.Forms.Label()
        Borrow_DateLabel = New System.Windows.Forms.Label()
        Return_DateLabel = New System.Windows.Forms.Label()
        CountLabel = New System.Windows.Forms.Label()
        GenreLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BorrowDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(26, 34)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 17)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'Book_TitleLabel
        '
        Book_TitleLabel.AutoSize = True
        Book_TitleLabel.Location = New System.Drawing.Point(26, 65)
        Book_TitleLabel.Name = "Book_TitleLabel"
        Book_TitleLabel.Size = New System.Drawing.Size(71, 17)
        Book_TitleLabel.TabIndex = 2
        Book_TitleLabel.Text = "Book Title:"
        '
        'BorrowerLabel
        '
        BorrowerLabel.AutoSize = True
        BorrowerLabel.Location = New System.Drawing.Point(26, 96)
        BorrowerLabel.Name = "BorrowerLabel"
        BorrowerLabel.Size = New System.Drawing.Size(68, 17)
        BorrowerLabel.TabIndex = 4
        BorrowerLabel.Text = "Borrower:"
        '
        'Borrow_DateLabel
        '
        Borrow_DateLabel.AutoSize = True
        Borrow_DateLabel.Location = New System.Drawing.Point(26, 127)
        Borrow_DateLabel.Name = "Borrow_DateLabel"
        Borrow_DateLabel.Size = New System.Drawing.Size(87, 17)
        Borrow_DateLabel.TabIndex = 6
        Borrow_DateLabel.Text = "Borrow Date:"
        '
        'Return_DateLabel
        '
        Return_DateLabel.AutoSize = True
        Return_DateLabel.Location = New System.Drawing.Point(26, 158)
        Return_DateLabel.Name = "Return_DateLabel"
        Return_DateLabel.Size = New System.Drawing.Size(84, 17)
        Return_DateLabel.TabIndex = 8
        Return_DateLabel.Text = "Return Date:"
        '
        'CountLabel
        '
        CountLabel.AutoSize = True
        CountLabel.Location = New System.Drawing.Point(26, 220)
        CountLabel.Name = "CountLabel"
        CountLabel.Size = New System.Drawing.Size(48, 17)
        CountLabel.TabIndex = 12
        CountLabel.Text = "Count:"
        '
        'GenreLabel
        '
        GenreLabel.AutoSize = True
        GenreLabel.Location = New System.Drawing.Point(27, 189)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New System.Drawing.Size(47, 17)
        GenreLabel.TabIndex = 13
        GenreLabel.Text = "Genre:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BorrowBindingSource
        '
        Me.BorrowBindingSource.DataMember = "borrow"
        Me.BorrowBindingSource.DataSource = Me.DatabaseDataSet
        '
        'BorrowTableAdapter
        '
        Me.BorrowTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.booksTableAdapter = Nothing
        Me.TableAdapterManager.borrowTableAdapter = Me.BorrowTableAdapter
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DIMS.DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(472, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "List of Borrowed Books by Students"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrint.Location = New System.Drawing.Point(396, 213)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 27)
        Me.btnPrint.TabIndex = 76
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(396, 175)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 27)
        Me.btnSave.TabIndex = 75
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.AliceBlue
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(396, 140)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 27)
        Me.btnDelete.TabIndex = 74
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(396, 106)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 27)
        Me.btnAdd.TabIndex = 73
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLast.Location = New System.Drawing.Point(305, 304)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 31)
        Me.btnLast.TabIndex = 72
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.AliceBlue
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNext.Location = New System.Drawing.Point(210, 304)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 31)
        Me.btnNext.TabIndex = 71
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrevious.Location = New System.Drawing.Point(120, 304)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(77, 31)
        Me.btnPrevious.TabIndex = 70
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.AliceBlue
        Me.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFirst.Location = New System.Drawing.Point(32, 304)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 31)
        Me.btnFirst.TabIndex = 69
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(45, 60)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(301, 27)
        Me.txtSearch.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Enter the book title"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSearch.Location = New System.Drawing.Point(172, 100)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 27)
        Me.btnSearch.TabIndex = 93
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.AliceBlue
        Me.btnReset.Location = New System.Drawing.Point(263, 100)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(74, 27)
        Me.btnReset.TabIndex = 94
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(835, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 150)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Search"
        '
        'pdPrint
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(GenreLabel)
        Me.GroupBox2.Controls.Add(Me.GenreComboBox)
        Me.GroupBox2.Controls.Add(IDLabel)
        Me.GroupBox2.Controls.Add(Me.IDTextBox)
        Me.GroupBox2.Controls.Add(Book_TitleLabel)
        Me.GroupBox2.Controls.Add(Me.Book_TitleTextBox)
        Me.GroupBox2.Controls.Add(BorrowerLabel)
        Me.GroupBox2.Controls.Add(Me.BorrowerTextBox)
        Me.GroupBox2.Controls.Add(Borrow_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Borrow_DateTextBox)
        Me.GroupBox2.Controls.Add(Return_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Return_DateTextBox)
        Me.GroupBox2.Controls.Add(CountLabel)
        Me.GroupBox2.Controls.Add(Me.CountTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 262)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Information"
        '
        'GenreComboBox
        '
        Me.GenreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Genre", True))
        Me.GenreComboBox.FormattingEnabled = True
        Me.GenreComboBox.Items.AddRange(New Object() {"Art", "Business", "Best Seller", "Education", "Fantasy", "Humor", "Mystery", "Philosophy", "Religion", "Romance", "Science Fiction", "Self Help"})
        Me.GenreComboBox.Location = New System.Drawing.Point(119, 186)
        Me.GenreComboBox.Name = "GenreComboBox"
        Me.GenreComboBox.Size = New System.Drawing.Size(121, 25)
        Me.GenreComboBox.TabIndex = 14
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(119, 31)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(131, 25)
        Me.IDTextBox.TabIndex = 1
        '
        'Book_TitleTextBox
        '
        Me.Book_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Book_Title", True))
        Me.Book_TitleTextBox.Location = New System.Drawing.Point(119, 62)
        Me.Book_TitleTextBox.Name = "Book_TitleTextBox"
        Me.Book_TitleTextBox.Size = New System.Drawing.Size(219, 25)
        Me.Book_TitleTextBox.TabIndex = 3
        '
        'BorrowerTextBox
        '
        Me.BorrowerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrower", True))
        Me.BorrowerTextBox.Location = New System.Drawing.Point(119, 93)
        Me.BorrowerTextBox.Name = "BorrowerTextBox"
        Me.BorrowerTextBox.Size = New System.Drawing.Size(131, 25)
        Me.BorrowerTextBox.TabIndex = 5
        '
        'Borrow_DateTextBox
        '
        Me.Borrow_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Borrow_Date", True))
        Me.Borrow_DateTextBox.Location = New System.Drawing.Point(119, 124)
        Me.Borrow_DateTextBox.Name = "Borrow_DateTextBox"
        Me.Borrow_DateTextBox.Size = New System.Drawing.Size(131, 25)
        Me.Borrow_DateTextBox.TabIndex = 7
        '
        'Return_DateTextBox
        '
        Me.Return_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Return_Date", True))
        Me.Return_DateTextBox.Location = New System.Drawing.Point(119, 155)
        Me.Return_DateTextBox.Name = "Return_DateTextBox"
        Me.Return_DateTextBox.Size = New System.Drawing.Size(131, 25)
        Me.Return_DateTextBox.TabIndex = 9
        '
        'CountTextBox
        '
        Me.CountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "Count", True))
        Me.CountTextBox.Location = New System.Drawing.Point(119, 217)
        Me.CountTextBox.Name = "CountTextBox"
        Me.CountTextBox.Size = New System.Drawing.Size(131, 25)
        Me.CountTextBox.TabIndex = 13
        '
        'BorrowDataGridView
        '
        Me.BorrowDataGridView.AutoGenerateColumns = False
        Me.BorrowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.BorrowDataGridView.DataSource = Me.BorrowBindingSource
        Me.BorrowDataGridView.Location = New System.Drawing.Point(493, 52)
        Me.BorrowDataGridView.Name = "BorrowDataGridView"
        Me.BorrowDataGridView.Size = New System.Drawing.Size(737, 246)
        Me.BorrowDataGridView.TabIndex = 96
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Book_Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Book_Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Borrower"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Borrower"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Borrow_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Borrow_Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Return_Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Return_Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Genre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Genre"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Count"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Count"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AliceBlue
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(549, 404)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(87, 36)
        Me.btnBack.TabIndex = 97
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmBorrowUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1242, 490)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.BorrowDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmBorrowUpdate"
        Me.Text = "Books Borrowed by Students"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BorrowDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents BorrowBindingSource As BindingSource
    Friend WithEvents BorrowTableAdapter As DatabaseDataSetTableAdapters.borrowTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pdPrint As Printing.PrintDocument
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Book_TitleTextBox As TextBox
    Friend WithEvents BorrowerTextBox As TextBox
    Friend WithEvents Borrow_DateTextBox As TextBox
    Friend WithEvents Return_DateTextBox As TextBox
    Friend WithEvents CountTextBox As TextBox
    Friend WithEvents BorrowDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents GenreComboBox As ComboBox
    Friend WithEvents btnBack As Button
End Class
