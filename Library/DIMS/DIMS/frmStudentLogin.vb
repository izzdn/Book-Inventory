Imports System.Data.OleDb
Imports System.Data


Public Class frmStudentLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Please enter your Username and Password correctly!", vbExclamation, "Error")
            txtPassword.Focus()
            txtUsername.Focus()
        Else

            Dim connection As New OleDbConnection(DBlocation)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM student WHERE [Matric_Number] = '" & txtUsername.Text & "' AND [Password]= '" & txtPassword.Text & "' ", connection)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                Me.Hide()
                frmStudentMain.txtName.Text = sdr("Full_Name").ToString()
                frmStudentMain.txtMatric.Text = sdr("Matric_Number").ToString()
                frmStudentMain.txtCourse.Text = sdr("Course").ToString()
                frmStudentMain.txtEmail.Text = sdr("Email").ToString()
                frmStudentMain.txtPhone.Text = sdr("Phone").ToString()
                frmBorrow.txtStudentID.Text = sdr("Matric_Number").ToString()
                mdlVariable.namee = (sdr("Matric_Number").ToString())
                frmStudentMain.ShowDialog()
                txtUsername.Clear()
                txtPassword.Clear()
            Else
                MsgBox("Invalid Username or Password!", vbExclamation, "Error")
                lblForget.Visible = True
            End If
            connection.Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtUsername.Clear()
        txtPassword.Clear()
        Close()
    End Sub

    Private Sub lblForget_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForget.LinkClicked
        frmForgetPassword.ShowDialog()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

End Class