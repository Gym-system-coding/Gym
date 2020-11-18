Public Class student_UI
    Private Sub FieldInfo_Click(sender As Object, e As EventArgs) Handles FieldInfo.Click
        'TODO 跳转场地预约界面
    End Sub

    Private Sub FieldInfo_MouseHover(sender As Object, e As EventArgs) Handles FieldInfo.MouseHover
        FieldInfo.ForeColor = System.Drawing.SystemColors.ActiveBorder
    End Sub

    Private Sub FieldInfo_MouseLeave(sender As Object, e As EventArgs) Handles FieldInfo.MouseLeave
        FieldInfo.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub GameInfo_Click(sender As Object, e As EventArgs) Handles GameInfo.Click
        'TODO 跳转比赛报名界面
    End Sub

    Private Sub GameInfo_MouseHover(sender As Object, e As EventArgs) Handles GameInfo.MouseHover
        GameInfo.ForeColor = System.Drawing.SystemColors.ActiveBorder
    End Sub

    Private Sub GameInfo_MouseLeave(sender As Object, e As EventArgs) Handles GameInfo.MouseLeave
        GameInfo.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub TrainingInfo_Click(sender As Object, e As EventArgs) Handles TrainingInfo.Click
        'TODO 跳转培训界面
    End Sub
    Private Sub TrainingInfo_MouseHover(sender As Object, e As EventArgs) Handles TrainingInfo.MouseHover
        TrainingInfo.ForeColor = System.Drawing.SystemColors.ActiveBorder
    End Sub

    Private Sub TrainingInfo_MouseLeave(sender As Object, e As EventArgs) Handles TrainingInfo.MouseLeave
        TrainingInfo.ForeColor = System.Drawing.Color.White

    End Sub

    Private Sub Message_Click(sender As Object, e As EventArgs) Handles Message.Click
        'TODO 跳转消息界面
    End Sub

    Private Sub Message_MouseHover(sender As Object, e As EventArgs) Handles Message.MouseHover
        Message.ForeColor = System.Drawing.SystemColors.ActiveBorder
    End Sub

    Private Sub Message_MouseLeave(sender As Object, e As EventArgs) Handles Message.MouseLeave
        Message.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub Logout_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Logout.LinkClicked
        'TODO 退出
    End Sub

    Private Sub student_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO 显示姓名
        'UserName.Text=
    End Sub
End Class