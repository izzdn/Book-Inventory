<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowList
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
        Me.BorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowTableAdapter = New DIMS.DATABASEDataSetTableAdapters.borrowTableAdapter()
        Me.TableAdapterManager = New DIMS.DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.BorrowDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BorrowDataGridView
        '
        Me.BorrowDataGridView.AutoGenerateColumns = False
        Me.BorrowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BorrowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.BorrowDataGridView.DataSource = Me.BorrowBindingSource
        Me.BorrowDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.BorrowDataGridView.Name = "BorrowDataGridView"
        Me.BorrowDataGridView.Size = New System.Drawing.Size(898, 462)
        Me.BorrowDataGridView.TabIndex = 1
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
        'frmBorrowList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 462)
        Me.Controls.Add(Me.BorrowDataGridView)
        Me.Name = "frmBorrowList"
        Me.Text = "frmBorrowList"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents BorrowBindingSource As BindingSource
    Friend WithEvents BorrowTableAdapter As DatabaseDataSetTableAdapters.borrowTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BorrowDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
