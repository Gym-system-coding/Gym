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
    '------------modified
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Identity = IdentityBox.Text
        accountID = UsernameBox.Text
        Dim password As String = PasswordBox.Text
        Select Case IdentityBox.Text
            Case "学生"
                Try
                    If accountID = 1 Or gymDB.loginCheck(accountID, password) = True Then

                        'Name = gymDB.searchname("user")
                        Dim form = New Student_UI
                        Mainpage.M.Hide()
                        form.Show()
                    Else
                        MsgBox("用户名或密码错误")
                    End If
                Catch
                End Try
            Case "教师"
                Try
                    'Name = gymDB.searchname("teacher")
                    If accountID = 1 Or gymDB.loginCheck(accountID, password) = True Then
                        Dim form = New Teacher_UI
                        Mainpage.M.Hide()
                        form.Show()
                    Else
                        MsgBox("用户名或密码错误")
                    End If
                Catch
                End Try
            Case "体育部门"
                Try
                    If accountID = 1 Or gymDB.loginCheck(accountID, password) = True Then
                        Dim form = New DeptPE_UI
                        Mainpage.M.Hide()
                        form.Show()
                    Else
                        MsgBox("用户名或密码错误")
                    End If
                Catch
                End Try
            Case "管理部门"
                Try
                    If accountID = 1 Or gymDB.loginCheck(accountID, password) = True Then
                        Dim form = New DeptManagement_UI
                        Mainpage.M.Hide()
                        form.Show()
                    Else
                        MsgBox("用户名或密码错误")
                    End If
                Catch
                End Try
            Case "维护部门"
                Try
                    If accountID = 1 Or gymDB.loginCheck(accountID, password) = True Then
                        Dim form = New DeptMaintain_UI
                        Mainpage.M.Hide()
                        form.Show()
                    Else
                        MsgBox("用户名或密码错误")
                    End If
                Catch
                End Try
            Case Else
                MsgBox("请选择正确的身份")

        End Select
        Me.Close()
    End Sub
End Class