Imports System.Data.OleDb
Imports System.Data

Public Class frmStudentRegister
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtName.Text = Nothing Or txtPassword.Text = Nothing Or txtStudentID.Text = Nothing Or txtStudentID.Text = Nothing Then
            MsgBox("Please enter the Input Field correctly!", vbExclamation, "Error")
        End If
        If txtStudentID.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Please enter the Input Field correctly!", vbExclamation, "Error")
        End If

        Dim connection As New OleDbConnection(DBlocation)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Using create As New OleDbCommand("insert into student([Matric_Number],[Password],[Full_Name],[Course],[Phone],[Email]) values(@Matric_Number,@Password,@Full_Name,@Course,@Phone,@Email)", connection)
            create.Parameters.AddWithValue("@Matric_Number", OleDbType.VarChar).Value = txtStudentID.Text.Trim
            create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassConfirm.Text.Trim
            create.Parameters.AddWithValue("@Full_Name", OleDbType.VarChar).Value = txtName.Text.Trim
            create.Parameters.AddWithValue("@Course", OleDbType.VarChar).Value = cbxCourse.Text.Trim
            create.Parameters.AddWithValue("@Phone", OleDbType.VarChar).Value = txtPhone.Text.Trim
            create.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = txtEmail.Text.Trim
            If create.ExecuteNonQuery Then
                MsgBox("Account creation succeed!", vbYes)
                If MsgBoxResult.Yes Then
                    frmStudentLogin.ShowDialog()
                    txtName.Clear()
                    txtStudentID.Clear()
                    txtEmail.Clear()
                    txtPhone.Clear()
                    txtPassword.Clear()
                    txtPassConfirm.Clear()
                    Me.Close()
                End If
            Else
                MsgBox("Registration Error", vbExclamation, "Error")
            End If
        End Using
        connection.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub
End Class