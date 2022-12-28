Imports System.Data.OleDb
Imports System.Data

Public Class frmStaffLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Please enter your Username and Password correctly!", vbExclamation, "Error")
            txtPassword.Focus()
            txtUsername.Focus()
        Else
            Me.Hide()
            Dim connection As New OleDbConnection(DBlocation)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM staff WHERE Username = '" & txtUsername.Text & "' AND [Password]= '" & txtPassword.Text & "' ", connection)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                frmStaffMain.txtName.Text = sdr("StaffName").ToString()
                frmStaffMain.txtStaffID.Text = sdr("StaffID").ToString()
                frmStaffMain.txtEmail.Text = sdr("Email").ToString()
                frmStaffMain.txtPhone.Text = sdr("Phone").ToString()
                frmStaffMain.ShowDialog()
                txtUsername.Clear()
                txtPassword.Clear()
                Me.Close()
            Else
                MsgBox("Invalid Username or Password!", vbExclamation, "Error")
            End If
            connection.Close()
            txtUsername.Clear()
            txtPassword.Clear()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class