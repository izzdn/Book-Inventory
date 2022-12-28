Public Class frmBooklist
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frmBooklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.DatabaseDataSet.books)

    End Sub

    Private Sub BooksDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BooksDataGridView.CellContentClick

    End Sub
End Class