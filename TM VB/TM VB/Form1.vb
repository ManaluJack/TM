Public Class FormLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtusername.Focus()
        If txtusername.Text = "admin" And txtpassword.Text = "admin" Then
            Me.Hide()
            FrmLoad.Show()
        End If
    End Sub

    Private Sub cbpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbpassword.CheckedChanged
        If cbpassword.Checked = False Then
            txtpassword.PasswordChar = "*"
        Else
            txtpassword.PasswordChar = txtpassword.Text
        End If
    End Sub

    Private Sub user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Hide()
            FrmLoad.Show()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
    End Sub
End Class