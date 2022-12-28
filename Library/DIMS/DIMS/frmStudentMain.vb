Imports System.Data.OleDb
Imports System.Data

Public Class frmStudentMain
    Private Sub BorrowToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrowToolStripMenuItem1.Click
        frmBorrow.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim strResp As String
        strResp = MsgBox("Do you want to logout from this account?", vbYesNo, "User's Confirmation")
        If strResp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem1.Click
        Dim connection As New System.Data.OleDb.OleDbConnection(DBlocation)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM borrow WHERE Borrower = '" & mdlVariable.namee & "'", connection)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            frmReturn.ShowDialog()
        Else
            MsgBox("You did not borrow any book!", vbExclamation, "Error")
        End If
        connection.Close()
    End Sub
End Class