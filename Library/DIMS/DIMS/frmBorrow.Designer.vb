<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBorrow
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim GenreLabel As System.Windows.Forms.Label
        Dim Shelf_LocationLabel As System.Windows.Forms.Label
        Dim AvailabilityLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DatabaseDataSet = New DIMS.DatabaseDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New DIMS.DatabaseDataSetTableAdapters.booksTableAdapter()
        Me.TableAdapterManager = New DIMS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.BooksDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.GenreTextBox = New System.Windows.Forms.TextBox()
        Me.Shelf_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.AvailabilityCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxBookInfo = New System.Windows.Forms.GroupBox()
        Me.gbxSearch = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.gbxDate = New System.Windows.Forms.GroupBox()
        Me.dateBorrow = New System.Windows.Forms.DateTimePicker()
        IDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        GenreLabel = New System.Windows.Forms.Label()
        Shelf_LocationLabel = New System.Windows.Forms.Label()
        AvailabilityLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBookInfo.SuspendLayout()
        Me.gbxSearch.SuspendLayout()
        Me.gbxDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(20, 28)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 16)
        IDLabel.TabIndex = 64
        IDLabel.Text = "ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(20, 54)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(43, 16)
        TitleLabel.TabIndex = 66
        TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.Location = New System.Drawing.Point(20, 80)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(56, 16)
        AuthorLabel.TabIndex = 68
        AuthorLabel.Text = "Author:"
        '
        'GenreLabel
        '
        GenreLabel.AutoSize = True
        GenreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenreLabel.Location = New System.Drawing.Point(20, 106)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New System.Drawing.Size(54, 16)
        GenreLabel.TabIndex = 70
        GenreLabel.Text = "Genre:"
        '
        'Shelf_LocationLabel
        '
        Shelf_LocationLabel.AutoSize = True
        Shelf_LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Shelf_LocationLabel.Location = New System.Drawing.Point(20, 133)
        Shelf_LocationLabel.Name = "Shelf_LocationLabel"
        Shelf_LocationLabel.Size = New System.Drawing.Size(110, 16)
        Shelf_LocationLabel.TabIndex = 72
        Shelf_LocationLabel.Text = "Shelf Location:"
        '
        'AvailabilityLabel
        '
        AvailabilityLabel.AutoSize = True
        AvailabilityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AvailabilityLabel.Location = New System.Drawing.Point(20, 160)
        AvailabilityLabel.Name = "AvailabilityLabel"
        AvailabilityLabel.Size = New System.Drawing.Size(89, 16)
        AvailabilityLabel.TabIndex = 74
        AvailabilityLabel.Text = "Availability:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the book title"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.AliceBlue
        Me.btnReset.Location = New System.Drawing.Point(249, 82)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(74, 27)
        Me.btnReset.TabIndex = 52
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSearch.Location = New System.Drawing.Point(158, 82)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 27)
        Me.btnSearch.TabIndex = 51
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(31, 41)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(293, 27)
        Me.txtSearch.TabIndex = 50
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.DatabaseDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.borrowTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DIMS.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(682, 457)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(74, 23)
        Me.btnBorrow.TabIndex = 63
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(583, 457)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(74, 23)
        Me.btnBack.TabIndex = 64
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'BooksDataGridView
        '
        Me.BooksDataGridView.AutoGenerateColumns = False
        Me.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.BooksDataGridView.DataSource = Me.BooksBindingSource
        Me.BooksDataGridView.Location = New System.Drawing.Point(36, 41)
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.Size = New System.Drawing.Size(741, 162)
        Me.BooksDataGridView.TabIndex = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Author"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Genre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Genre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Shelf_Location"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Shelf_Location"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Availability"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Availability"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(130, 25)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(145, 22)
        Me.IDTextBox.TabIndex = 65
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(130, 51)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.ReadOnly = True
        Me.TitleTextBox.Size = New System.Drawing.Size(241, 22)
        Me.TitleTextBox.TabIndex = 67
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(130, 77)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.ReadOnly = True
        Me.AuthorTextBox.Size = New System.Drawing.Size(145, 22)
        Me.AuthorTextBox.TabIndex = 69
        '
        'GenreTextBox
        '
        Me.GenreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Genre", True))
        Me.GenreTextBox.Location = New System.Drawing.Point(130, 103)
        Me.GenreTextBox.Name = "GenreTextBox"
        Me.GenreTextBox.ReadOnly = True
        Me.GenreTextBox.Size = New System.Drawing.Size(145, 22)
        Me.GenreTextBox.TabIndex = 71
        '
        'Shelf_LocationTextBox
        '
        Me.Shelf_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Shelf_Location", True))
        Me.Shelf_LocationTextBox.Location = New System.Drawing.Point(130, 129)
        Me.Shelf_LocationTextBox.Name = "Shelf_LocationTextBox"
        Me.Shelf_LocationTextBox.ReadOnly = True
        Me.Shelf_LocationTextBox.Size = New System.Drawing.Size(145, 22)
        Me.Shelf_LocationTextBox.TabIndex = 73
        '
        'AvailabilityCheckBox
        '
        Me.AvailabilityCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BooksBindingSource, "Availability", True))
        Me.AvailabilityCheckBox.Location = New System.Drawing.Point(130, 155)
        Me.AvailabilityCheckBox.Name = "AvailabilityCheckBox"
        Me.AvailabilityCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AvailabilityCheckBox.TabIndex = 75
        Me.AvailabilityCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 17)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Select the book on this booklist or search the book title "
        '
        'gbxBookInfo
        '
        Me.gbxBookInfo.BackColor = System.Drawing.Color.Transparent
        Me.gbxBookInfo.Controls.Add(IDLabel)
        Me.gbxBookInfo.Controls.Add(Me.AvailabilityCheckBox)
        Me.gbxBookInfo.Controls.Add(AvailabilityLabel)
        Me.gbxBookInfo.Controls.Add(Me.IDTextBox)
        Me.gbxBookInfo.Controls.Add(Me.Shelf_LocationTextBox)
        Me.gbxBookInfo.Controls.Add(TitleLabel)
        Me.gbxBookInfo.Controls.Add(Shelf_LocationLabel)
        Me.gbxBookInfo.Controls.Add(Me.TitleTextBox)
        Me.gbxBookInfo.Controls.Add(Me.GenreTextBox)
        Me.gbxBookInfo.Controls.Add(AuthorLabel)
        Me.gbxBookInfo.Controls.Add(GenreLabel)
        Me.gbxBookInfo.Controls.Add(Me.AuthorTextBox)
        Me.gbxBookInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBookInfo.Location = New System.Drawing.Point(36, 249)
        Me.gbxBookInfo.Name = "gbxBookInfo"
        Me.gbxBookInfo.Size = New System.Drawing.Size(377, 227)
        Me.gbxBookInfo.TabIndex = 77
        Me.gbxBookInfo.TabStop = False
        Me.gbxBookInfo.Text = "Book Information"
        '
        'gbxSearch
        '
        Me.gbxSearch.BackColor = System.Drawing.Color.Transparent
        Me.gbxSearch.Controls.Add(Me.txtSearch)
        Me.gbxSearch.Controls.Add(Me.Label1)
        Me.gbxSearch.Controls.Add(Me.btnSearch)
        Me.gbxSearch.Controls.Add(Me.btnReset)
        Me.gbxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSearch.Location = New System.Drawing.Point(432, 215)
        Me.gbxSearch.Name = "gbxSearch"
        Me.gbxSearch.Size = New System.Drawing.Size(345, 124)
        Me.gbxSearch.TabIndex = 80
        Me.gbxSearch.TabStop = False
        Me.gbxSearch.Text = "Book Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Student ID :"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(131, 219)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentID.TabIndex = 82
        '
        'gbxDate
        '
        Me.gbxDate.BackColor = System.Drawing.Color.Transparent
        Me.gbxDate.Controls.Add(Me.dateBorrow)
        Me.gbxDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDate.Location = New System.Drawing.Point(432, 345)
        Me.gbxDate.Name = "gbxDate"
        Me.gbxDate.Size = New System.Drawing.Size(345, 87)
        Me.gbxDate.TabIndex = 83
        Me.gbxDate.TabStop = False
        Me.gbxDate.Text = "Date"
        '
        'dateBorrow
        '
        Me.dateBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBorrow.Location = New System.Drawing.Point(85, 35)
        Me.dateBorrow.Name = "dateBorrow"
        Me.dateBorrow.Size = New System.Drawing.Size(221, 22)
        Me.dateBorrow.TabIndex = 0
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(814, 544)
        Me.Controls.Add(Me.gbxDate)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbxSearch)
        Me.Controls.Add(Me.gbxBookInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BooksDataGridView)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBorrow)
        Me.Name = "frmBorrow"
        Me.Text = "Borrow Book"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBookInfo.ResumeLayout(False)
        Me.gbxBookInfo.PerformLayout()
        Me.gbxSearch.ResumeLayout(False)
        Me.gbxSearch.PerformLayout()
        Me.gbxDate.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As DatabaseDataSetTableAdapters.booksTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents BooksDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents GenreTextBox As TextBox
    Friend WithEvents Shelf_LocationTextBox As TextBox
    Friend WithEvents AvailabilityCheckBox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbxBookInfo As GroupBox
    Friend WithEvents gbxSearch As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents gbxDate As GroupBox
    Friend WithEvents dateBorrow As DateTimePicker
End Class
