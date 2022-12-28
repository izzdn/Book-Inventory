Imports System.Data.OleDb
Imports System.Data

Public Class frmStaffMain
    Private Sub DisplayBookListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayBookListToolStripMenuItem.Click
        frmBooklist.ShowDialog()
    End Sub

    Private Sub UpdateBookListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBookListToolStripMenuItem.Click
        frmUpdateBooks.ShowDialog()
    End Sub

    Private Sub DisplayBorrowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayBorrowerToolStripMenuItem.Click
        frmBorrowList.ShowDialog()
    End Sub

    Private Sub DisplayBorrowListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayBorrowListToolStripMenuItem.Click
        frmBorrowUpdate.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim strResp As String
        strResp = MsgBox("Do you want to logout from this account?", vbYesNo, "User's Confirmation")
        If strResp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub DisplayFavouriteGenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayFavouriteGenreToolStripMenuItem.Click
        Dim connection As New OleDbConnection(DBlocation)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim temp As Integer = 0
        Dim highest As String
        Dim title As String = " "
        Dim index As Integer
        Using cmd1 As New OleDbCommand("SELECT COUNT (*) FROM borrow ", connection)
            Dim counter = Convert.ToInt32(cmd1.ExecuteScalar())
            If counter > 0 Then
                Using cmd2 As New OleDbCommand("SELECT Count FROM borrow", connection)
                    Dim sdr1 As OleDbDataReader = cmd2.ExecuteReader()
                    Do While (sdr1.Read() = True)
                        index = Val(sdr1("Count"))
                        If index > temp Then
                            temp = index
                        End If
                    Loop
                    highest = temp.ToString()
                    Using cmd3 As New OleDbCommand("SELECT Book_Title From borrow WHERE Count ='" & highest & "'", connection)
                        Dim sdr2 As OleDbDataReader = cmd3.ExecuteReader()
                        If (sdr2.Read() = True) Then
                            title = sdr2("Book_Title").ToString()
                        End If
                    End Using
                    MsgBox("The most popular book borrowed is " & title & " which is " & highest & " times borrowed!", vbInformation, "Popular Book")
                End Using
            End If
        End Using
        connection.Close()
    End Sub
End Class