Imports System.Data.OleDb
Imports System.Data

Public Class frmForgetPassword
    Dim flag As Integer = 0
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtPhone.Text.Length < 10 Or txtPhone.Text = Nothing Then
            MsgBox("Invalid Phone Number", vbOK, "Error")
        End If

        Dim connection As New OleDbConnection(DBlocation)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If flag = 0 Then
            Using command As New OleDbCommand("SELECT COUNT (*) FROM student WHERE Phone = '" & txtPhone.Text & "' AND [Email]= '" & txtEmail.Text & "' ", connection)
                command.Parameters.AddWithValue("@Phone", OleDbType.VarChar).Value = txtPhone.Text.Trim
                command.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = txtEmail.Text.Trim

                Dim count = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    txtPassword.Enabled = True
                    txtConfirmPass.Enabled = True
                    flag = 1
                Else
                    MsgBox("Invalid Phone Number or Email Address", vbOK, "Error")
                End If
            End Using
        End If
        If flag = 1 Then
            If txtPassword.Text = Nothing Then
                MsgBox("Please enter the Input Field correctly!", vbExclamation, "Error")
            End If
            Using update As New OleDbCommand("UPDATE student SET [Password] = '" & txtConfirmPass.Text & "' WHERE (Phone = '" & txtPhone.Text & "') AND (Email = '" & txtEmail.Text & "') ", connection)
                update.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtConfirmPass.Text.Trim
                If update.ExecuteNonQuery Then
                    MsgBox("Account Updated!", vbYes, "Update Success")
                    Me.Close()
                    flag = 0
                Else
                    MsgBox("Account Update Error!", vbExclamation, "Error")
                End If
            End Using
        End If
        connection.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub
End Class