Public Class login
    Private Sub UsernameBox_LostFocus(sender As Object, e As EventArgs) Handles UsernameBox.LostFocus
        If UsernameBox.Text = "" Then
            UsernameBox.Text = "用户名"
            UsernameBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        End If
    End Sub

    Private Sub UsernameBox_GotFocus(sender As Object, e As EventArgs) Handles UsernameBox.GotFocus
        If UsernameBox.Text = "用户名" Then
            UsernameBox.Text = ""
            UsernameBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        End If
    End Sub
    Private Sub PasswordBox_GotFocus(sender As Object, e As EventArgs) Handles PasswordBox.GotFocus
        If PasswordBox.Text = "密码" Then
            PasswordBox.Text = ""
            PasswordBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            PasswordBox.PasswordChar = "*"

        End If
    End Sub

    Private Sub PasswordBox_LostFocus(sender As Object, e As EventArgs) Handles PasswordBox.LostFocus
        If PasswordBox.Text = "" Then
            PasswordBox.PasswordChar = ""
            PasswordBox.Text = "密码"
            PasswordBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        End If
    End Sub
    Private Sub IdentityBox_GotFocus(sender As Object, e As EventArgs) Handles IdentityBox.GotFocus
        IdentityBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
    End Sub
End Class