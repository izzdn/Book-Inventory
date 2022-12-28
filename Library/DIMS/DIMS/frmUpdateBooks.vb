Public Class frmUpdateBooks
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub frmUpdateBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.DatabaseDataSet.books)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.BooksBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strResp As String
        strResp = MsgBox("Are sure to delete?", vbYesNo, "System Confirmation")
        If strResp = vbYes Then
            Me.BooksBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Data has been removed")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
        MsgBox("Data has been saved successfully")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        pdPrint.Print()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.BooksBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.BooksBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.BooksBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.BooksBindingSource.MoveLast()
    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        e.Graphics.DrawString("Date / Time: " & Now.ToString, New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 500, 30)
        e.Graphics.DrawString("UiTM Library ", New Font("Berlin Sans FB Demi", 30, FontStyle.Bold), Brushes.Black, 300, 90)
        e.Graphics.DrawString("BOOK ID : " & vbTab & IDTextBox.Text, New Font("Goudy Old Style", 14, FontStyle.Bold), Brushes.Black, 75, 160)
        e.Graphics.DrawString(String.Format("{0,30}{1,30}", "TITLE: ", TitleTextBox.Text), New Font("Goudy Old Style", 14, FontStyle.Bold), Brushes.Black, 300, 160)

        e.Graphics.DrawString("Title: ", New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 100, 210)
        e.Graphics.DrawString(TitleTextBox.Text, New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 250, 210)
        e.Graphics.DrawString("Author: ", New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 100, 240)
        e.Graphics.DrawString(AuthorTextBox.Text, New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 250, 240)
        e.Graphics.DrawString("Shelf Location: ", New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 100, 270)
        e.Graphics.DrawString(Shelf_LocationComboBox.Text, New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 250, 270)
        e.Graphics.DrawString("Genre: ", New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 100, 300)
        e.Graphics.DrawString(GenreComboBox.Text, New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 250, 300)
        If AvailabilityCheckBox.Checked = True Then
            e.Graphics.DrawString("Available: ", New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 100, 330)
            e.Graphics.DrawString("Yes", New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 250, 330)
        Else
            e.Graphics.DrawString("Available: ", New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 100, 330)
            e.Graphics.DrawString("No", New Font("Goudy Old Style", 12, FontStyle.Bold), Brushes.Black, 250, 330)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text <> String.Empty Then
            BooksBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSearch.Text & "')" &
            "OR (Title LIKE '" & txtSearch.Text & "')" &
            "OR (Author LIKE '" & txtSearch.Text & "')" &
            "OR (Genre LIKE '" & txtSearch.Text & "')" &
            "OR (Shelf_Location LIKE '" & txtSearch.Text & "')"

            If BooksBindingSource.Count <> 0 Then
                With BooksDataGridView
                    .DataSource = BooksBindingSource
                End With
            Else
                MsgBox(txtSearch.Text & "was not found in a database!", MsgBoxStyle.Information, "No Result")
                BooksBindingSource.Filter = Nothing
                With BooksDataGridView
                    .ClearSelection()
                    .ReadOnly = True
                    .DataSource = BooksBindingSource
                End With
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSearch.Clear()
        BooksBindingSource.Filter = Nothing
        With BooksDataGridView
            .ClearSelection()
            .ReadOnly = True
            .DataSource = BooksBindingSource
        End With
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class