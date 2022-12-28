Imports System.Data.OleDb
Imports System.Data

Public Class frmReturn
    Dim connection As New System.Data.OleDb.OleDbConnection(DBlocation)
    Private Sub btReturn_Click(sender As Object, e As EventArgs) Handles btReturn.Click
        Dim TarikhPinjam As Date
        TarikhPinjam = Convert.ToDateTime(mdlVariable.tarikh)
        Dim Todayy As Date = Today
        Dim TP As Integer
        Dim TT As Integer
        Dim betul As String = "-1"
        Dim kosong As String = ""
        TP = Microsoft.VisualBasic.DateAndTime.Day(TarikhPinjam)
        TT = Microsoft.VisualBasic.DateAndTime.Day(Todayy)
        Dim Fine As Double
        Dim Diff As Integer = (TT - TP)
        If (Diff) > 7 Then
            Fine = (Diff - 7) * 0.5
            MsgBox("Please pay RM " & Format(Fine, "0.00") & " For Turned in Late", vbOKOnly, "Turned in Late")
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Using update1 As New OleDbCommand("UPDATE borrow SET [Borrow_Date] = '" & kosong.Trim & "' WHERE Book_Title = '" & mdlVariable.buuku & "'", connection)
                update1.Parameters.AddWithValue("@Borrow_Date", OleDbType.VarChar).Value = kosong.Trim
                Using update2 As New OleDbCommand("UPDATE borrow SET [Return_Date] = '" & Todayy & "' WHERE Book_Title = '" & mdlVariable.buuku & "'", connection)
                    update2.Parameters.AddWithValue("@Return_Date", OleDbType.VarChar).Value = Todayy
                    Using update3 As New OleDbCommand("UPDATE books SET [Availability] = '" & -1 & "' WHERE Title = '" & mdlVariable.buuku & "'", connection)
                        update3.Parameters.AddWithValue("@Availability", OleDbType.Boolean).Value = -1
                        update3.ExecuteNonQuery()
                        Using update4 As New OleDbCommand("UPDATE borrow SET [Borrower] = '' WHERE Book_Title = '" & mdlVariable.buuku & "'", connection)
                            update4.Parameters.AddWithValue("@Borrower", OleDbType.VarChar).Value = kosong.Trim
                            update4.ExecuteNonQuery()
                        End Using
                    End Using
                    update2.ExecuteNonQuery()
                End Using
                update1.ExecuteNonQuery()
            End Using
        Else
            MsgBox("Thank You For Using our service", vbOKOnly, "Thank You!")
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Using apdate As New OleDbCommand("UPDATE borrow SET [Borrow_Date] = '" & kosong & "' WHERE Book_Title = '" & mdlVariable.buuku & "'", connection)
                apdate.Parameters.AddWithValue("@Borrow_Date", OleDbType.VarChar).Value = kosong.Trim
                Using apdate1 As New OleDbCommand("UPDATE borrow SET [Return_Date] = '" & Todayy & "' WHERE Book_Title = '" & mdlVariable.buuku & "'", connection)
                    apdate1.Parameters.AddWithValue("@Return_Date", OleDbType.DBDate).Value = Todayy
                    Using apdate2 As New OleDbCommand("UPDATE books SET [Availability] = '" & -1 & "' WHERE Title = '" & mdlVariable.buuku & "'", connection)
                        apdate2.Parameters.AddWithValue("@Availability", OleDbType.Boolean).Value = -1
                        Using apdate3 As New OleDbCommand("UPDATE borrow SET [Borrower] = '' WHERE Book_Title = '" & mdlVariable.buuku & "'", connection)
                            apdate3.Parameters.AddWithValue("@Borrower", OleDbType.VarChar).Value = kosong.Trim
                            apdate3.ExecuteNonQuery()
                        End Using
                        apdate2.ExecuteNonQuery()
                    End Using
                    apdate1.ExecuteNonQuery()
                End Using
                apdate.ExecuteNonQuery()
            End Using
        End If
        cbBook.Items.Remove(cbBook.SelectedItem)
        tbAuthor.Clear()
        tbBookID.Clear()
        tbGenre.Clear()
        tbShelf.Clear()
    End Sub

    Private Sub cbBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBook.SelectedIndexChanged
        Dim connection As New System.Data.OleDb.OleDbConnection(DBlocation)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        mdlVariable.buuku = cbBook.SelectedItem
        Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT * FROM books WHERE Title = '" & mdlVariable.buuku & "'", connection)
        Dim sdr1 As OleDbDataReader = cmd1.ExecuteReader()
        If (sdr1.Read() = True) Then
            Me.tbAuthor.Text = sdr1("Author").ToString()
            Me.tbBookID.Text = sdr1("ID").ToString()
            Me.tbGenre.Text = sdr1("Genre").ToString()
            Me.tbShelf.Text = sdr1("Shelf_Location").ToString()

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT Borrow_Date FROM [borrow] WHERE Book_Title = '" & mdlVariable.buuku & "'", connection)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                mdlVariable.tarikh = sdr("Borrow_Date").ToString()
            End If
        End If
    End Sub

    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM borrow WHERE Borrower = '" & mdlVariable.namee & "'", connection)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        Do While (sdr.Read() = True)
            cbBook.Items.Add(sdr("Book_Title").ToString())
        Loop
        connection.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        cbBook.Items.Clear()
        tbAuthor.Clear()
        tbBookID.Clear()
        tbGenre.Clear()
        tbShelf.Clear()
        Close()
    End Sub
End Class