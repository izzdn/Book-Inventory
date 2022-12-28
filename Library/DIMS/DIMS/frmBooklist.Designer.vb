<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooklist
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
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BooksDataGridView.AutoGenerateColumns = False
        Me.BooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BooksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.BooksDataGridView.DataSource = Me.BooksBindingSource
        Me.BooksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BooksDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.BooksDataGridView.Name = "BooksDataGridView"
        Me.BooksDataGridView.ReadOnly = True
        Me.BooksDataGridView.Size = New System.Drawing.Size(900, 426)
        Me.BooksDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Author"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Genre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Genre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Shelf_Location"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Shelf_Location"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Availability"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Availability"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'frmBooklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 426)
        Me.Controls.Add(Me.BooksDataGridView)
        Me.Name = "frmBooklist"
        Me.Text = "BookList"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
