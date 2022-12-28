Public Class frmMain
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Me.Hide()
        frmStudentLogin.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Me.Hide()
        frmStaffLogin.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        frmStudentRegister.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim strResp As String
        strResp = MsgBox("Are you sure to close this program?", vbYesNo, "User's Confirmation")
        If strResp = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
