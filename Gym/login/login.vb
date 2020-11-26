Public Class Login
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

    Private Sub IdentityBox_LostFocus(sender As Object, e As EventArgs) Handles IdentityBox.LostFocus
        If IdentityBox.Text = "身份" Then
            IdentityBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If True Then    'todo 待改 根据用户户名
            Select Case IdentityBox.Text

                Case "学生"
                    Dim form = New Student_UI
                    form.Show()
                    Mainpage.M.Hide()
                    Me.Close()
                Case "教师"
                    Dim form = New Teacher_UI
                    form.Show()
                    Mainpage.M.Hide()
                    Me.Close()
                Case "体育部门"
                    Dim form = New DeptPE_UI
                    form.Show()
                    Mainpage.M.Hide()
                    Me.Close()
                Case "管理部门"
                    Dim form = New DeptManagement_UI
                    form.Show()
                    Mainpage.M.Hide()
                    Me.Close()
                Case "维护部门"
                    Dim form = New DeptMaintain_UI
                    form.Show()
                    Mainpage.M.Hide()
                    Me.Close()
                Case Else
                    MsgBox("类型错误")
            End Select

        End If
    End Sub
End Class