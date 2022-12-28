Public Class frmBorrowList
    Private Sub BorrowBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frmBorrowList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.DatabaseDataSet.borrow)

    End Sub

    Private Sub BorrowDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BorrowDataGridView.CellContentClick

    End Sub
End Class