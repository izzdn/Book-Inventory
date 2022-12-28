Imports System.Data.OleDb
Imports System.Data

Public Class frmBorrow
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub frmBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.DatabaseDataSet.books)
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
    Dim connection As New OleDbConnection(DBlocation)
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Dim counter As Integer = 0
        Dim counter1 As String
        Dim tarikh1 As Date = Today
        Dim tarikh2 As String = ""
        Dim strResp As String
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If AvailabilityCheckBox.Checked Then
            strResp = MsgBox("Are you sure you want to borrow this book?", vbYesNo, "User's Confirmation")
            If strResp = vbYes Then
                Using update1 As New OleDbCommand("UPDATE [books] SET [Availability] = " & 0 & " WHERE [ID] = '" & IDTextBox.Text & "'", connection)
                    update1.Parameters.AddWithValue("@Availability", OleDbType.Boolean).Value = "0"
                    If update1.ExecuteNonQuery Then
                        Using insert1 As New OleDbCommand("UPDATE borrow SET [Borrower] = '" & txtStudentID.Text & "',[Borrow_Date] ='" & tarikh1 & "',[Return_Date] ='" & tarikh2 & "' WHERE ID ='" & IDTextBox.Text & "'", connection)
                            insert1.Parameters.AddWithValue("@Borrower", OleDbType.VarChar).Value = txtStudentID.Text
                            insert1.Parameters.AddWithValue("@Borrow_Date", OleDbType.VarChar).Value = tarikh1
                            insert1.Parameters.AddWithValue("@Return_Date", OleDbType.VarChar).Value = tarikh2
                            If insert1.ExecuteNonQuery Then
                                Using cmd As New OleDbCommand("SELECT Count FROM borrow WHERE ID ='" & IDTextBox.Text & "'", connection)
                                    Dim sdr1 As OleDbDataReader = cmd.ExecuteReader()
                                    If (sdr1.Read() = True) Then
                                        counter = Val(sdr1("Count").ToString())
                                        counter = counter + 1
                                        Using apdate As New OleDbCommand("UPDATE borrow SET [Count] = '" & counter & "' WHERE ID ='" & IDTextBox.Text & "'", connection)
                                            counter1 = counter.ToString()
                                            apdate.Parameters.AddWithValue("@Count", OleDbType.VarChar).Value = counter
                                            apdate.ExecuteNonQuery()
                                            Dim strResp1 As String
                                            strResp1 = MsgBox("Book borrowed! Do You want to Borrow More?", vbYesNo)
                                            If strResp1 = vbNo Then
                                                Me.Close()
                                            End If
                                        End Using
                                    End If
                                End Using
                            Else
                                MsgBox("Book failed to borrow", vbExclamation, "Error")
                            End If
                        End Using
                    End If
                End Using
            End If
        Else
            MsgBox("The book is not available", vbOK, "Error")
        End If
        connection.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class