<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateBooks
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
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim GenreLabel As System.Windows.Forms.Label
        Dim Shelf_LocationLabel As System.Windows.Forms.Label
        Dim AvailabilityLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New DIMS.DATABASEDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New DIMS.DATABASEDataSetTableAdapters.booksTableAdapter()
        Me.TableAdapterManager = New DIMS.DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.BooksDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.GenreComboBox = New System.Windows.Forms.ComboBox()
        Me.Shelf_LocationComboBox = New System.Windows.Forms.ComboBox()
        Me.AvailabilityCheckBox = New System.Windows.Forms.CheckBox()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        GenreLabel = New System.Windows.Forms.Label()
        Shelf_LocationLabel = New System.Windows.Forms.Label()
        AvailabilityLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(24, 69)
        IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(34, 25)
        IDLabel.TabIndex = 57
        IDLabel.Text = "ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(24, 109)
        TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(53, 25)
        TitleLabel.TabIndex = 59
        TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.Location = New System.Drawing.Point(24, 149)
        AuthorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(75, 25)
        AuthorLabel.TabIndex = 61
        AuthorLabel.Text = "Author:"
        '
        'GenreLabel
        '
        GenreLabel.AutoSize = True
        GenreLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenreLabel.Location = New System.Drawing.Point(24, 189)
        GenreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New System.Drawing.Size(67, 25)
        GenreLabel.TabIndex = 63
        GenreLabel.Text = "Genre:"
        '
        'Shelf_LocationLabel
        '
        Shelf_LocationLabel.AutoSize = True
        Shelf_LocationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Shelf_LocationLabel.Location = New System.Drawing.Point(24, 231)
        Shelf_LocationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Shelf_LocationLabel.Name = "Shelf_LocationLabel"
        Shelf_LocationLabel.Size = New System.Drawing.Size(133, 25)
        Shelf_LocationLabel.TabIndex = 65
        Shelf_LocationLabel.Text = "Shelf Location:"
        '
        'AvailabilityLabel
        '
        AvailabilityLabel.AutoSize = True
        AvailabilityLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AvailabilityLabel.Location = New System.Drawing.Point(24, 275)
        AvailabilityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AvailabilityLabel.Name = "AvailabilityLabel"
        AvailabilityLabel.Size = New System.Drawing.Size(107, 25)
        AvailabilityLabel.TabIndex = 67
        AvailabilityLabel.Text = "Availability:"
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
        Me.TableAdapterManager.UpdateOrder = DIMS.DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BooksDataGridView
        '
        Me.BooksDataGridView.AllowUserToAddRows = False
        Me.BooksDataGridView.AllowUserToDeleteRows = False
        Me.BooksDataGridView.AutoGenerateColumns = False
        Me.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.BooksDataGridView.DataSource = Me.BooksBindingSource
        Me.BooksDataGridView.Location = New System.Drawing.Point(694, 65)
        Me.BooksDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.Size = New System.Drawing.Size(982, 408)
        Me.BooksDataGridView.TabIndex = 1
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
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.AliceBlue
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(424, 145)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(111, 42)
        Me.btnReset.TabIndex = 49
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(300, 145)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(111, 42)
        Me.btnSearch.TabIndex = 48
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(76, 78)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(438, 39)
        Me.txtSearch.TabIndex = 47
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.AliceBlue
        Me.btnLast.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLast.Location = New System.Drawing.Point(412, 452)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(106, 42)
        Me.btnLast.TabIndex = 53
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.AliceBlue
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNext.Location = New System.Drawing.Point(298, 452)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(106, 42)
        Me.btnNext.TabIndex = 52
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrevious.Location = New System.Drawing.Point(184, 452)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(106, 42)
        Me.btnPrevious.TabIndex = 51
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.AliceBlue
        Me.btnFirst.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFirst.Location = New System.Drawing.Point(69, 452)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(106, 42)
        Me.btnFirst.TabIndex = 50
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrint.Location = New System.Drawing.Point(561, 315)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(110, 42)
        Me.btnPrint.TabIndex = 57
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(561, 257)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 42)
        Me.btnSave.TabIndex = 56
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.AliceBlue
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(561, 203)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 42)
        Me.btnDelete.TabIndex = 55
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(561, 151)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 42)
        Me.btnAdd.TabIndex = 54
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(189, 65)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(286, 28)
        Me.IDTextBox.TabIndex = 58
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(189, 105)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(286, 28)
        Me.TitleTextBox.TabIndex = 60
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Author", True))
        Me.AuthorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(189, 145)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(286, 28)
        Me.AuthorTextBox.TabIndex = 62
        '
        'GenreComboBox
        '
        Me.GenreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Genre", True))
        Me.GenreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreComboBox.FormattingEnabled = True
        Me.GenreComboBox.Items.AddRange(New Object() {"Art", "Business", "Best Seller", "Education", "Fantasy", "Humor", "Mystery", "Philosophy", "Religion", "Romance", "Science Fiction", "Self Help"})
        Me.GenreComboBox.Location = New System.Drawing.Point(189, 185)
        Me.GenreComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GenreComboBox.Name = "GenreComboBox"
        Me.GenreComboBox.Size = New System.Drawing.Size(158, 30)
        Me.GenreComboBox.TabIndex = 64
        '
        'Shelf_LocationComboBox
        '
        Me.Shelf_LocationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Shelf_Location", True))
        Me.Shelf_LocationComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Shelf_LocationComboBox.FormattingEnabled = True
        Me.Shelf_LocationComboBox.Items.AddRange(New Object() {"RC-1111", "RC-1112", "RC-1113", "RC-1114", "RC-1115"})
        Me.Shelf_LocationComboBox.Location = New System.Drawing.Point(189, 226)
        Me.Shelf_LocationComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Shelf_LocationComboBox.Name = "Shelf_LocationComboBox"
        Me.Shelf_LocationComboBox.Size = New System.Drawing.Size(158, 30)
        Me.Shelf_LocationComboBox.TabIndex = 66
        '
        'AvailabilityCheckBox
        '
        Me.AvailabilityCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BooksBindingSource, "Availability", True))
        Me.AvailabilityCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailabilityCheckBox.Location = New System.Drawing.Point(192, 268)
        Me.AvailabilityCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AvailabilityCheckBox.Name = "AvailabilityCheckBox"
        Me.AvailabilityCheckBox.Size = New System.Drawing.Size(158, 57)
        Me.AvailabilityCheckBox.TabIndex = 68
        Me.AvailabilityCheckBox.Text = "Tick if book available"
        Me.AvailabilityCheckBox.UseVisualStyleBackColor = True
        '
        'pdPrint
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1074, 488)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(603, 205)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 25)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Enter the book title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(657, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "List of Books "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(IDLabel)
        Me.GroupBox2.Controls.Add(Me.AvailabilityCheckBox)
        Me.GroupBox2.Controls.Add(AvailabilityLabel)
        Me.GroupBox2.Controls.Add(Me.Shelf_LocationComboBox)
        Me.GroupBox2.Controls.Add(Me.IDTextBox)
        Me.GroupBox2.Controls.Add(Shelf_LocationLabel)
        Me.GroupBox2.Controls.Add(TitleLabel)
        Me.GroupBox2.Controls.Add(Me.GenreComboBox)
        Me.GroupBox2.Controls.Add(Me.TitleTextBox)
        Me.GroupBox2.Controls.Add(GenreLabel)
        Me.GroupBox2.Controls.Add(AuthorLabel)
        Me.GroupBox2.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(40, 65)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(504, 351)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Information"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AliceBlue
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(795, 595)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 56)
        Me.btnBack.TabIndex = 98
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmUpdateBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DIMS.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1710, 711)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.BooksDataGridView)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmUpdateBooks"
        Me.Text = "Update Books Information"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As DatabaseDataSetTableAdapters.booksTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BooksDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents GenreComboBox As ComboBox
    Friend WithEvents Shelf_LocationComboBox As ComboBox
    Friend WithEvents AvailabilityCheckBox As CheckBox
    Friend WithEvents pdPrint As Printing.PrintDocument
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBack As Button
End Class
