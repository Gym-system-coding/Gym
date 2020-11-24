Public Class student_UI
    Sub HideAll()
        FieldPanel.Hide()
        ChangeColor(FieldInfo, BackColor, "White")
        ChangeColor(FieldInfo, BackColor, "bgcolor")
        ChangeColor(Backcolor1, BackColor, "bgcolor")
        GamePanel.Hide()
        ChangeColor(GameInfo, BackColor, "White")
        ChangeColor(GameInfo, BackColor, "bgcolor")
        ChangeColor(Backcolor2, BackColor, "bgcolor")
        TrainingPanel.Hide()
        ChangeColor(TrainingInfo, BackColor, "White")
        ChangeColor(TrainingInfo, BackColor, "bgcolor")
        ChangeColor(Backcolor3, BackColor, "bgcolor")
        FeedbackPanel.Hide()
        ChangeColor(Feedback, BackColor, "White")
        ChangeColor(Feedback, BackColor, "bgcolor")
        ChangeColor(Backcolor4, BackColor, "bgcolor")
        MessagePanel.Hide()
        ChangeColor(Message, BackColor, "White")
        ChangeColor(Message, BackColor, "bgcolor")
        ChangeColor(Backcolor5, BackColor, "bgcolor")
    End Sub
    Sub ChangeColor(label As Object, type As Object, c As Object)
        Select Case c
            Case "bgcolor"
                c = label.Parent.BackColor
            Case "ActiveBorder"
                c = System.Drawing.SystemColors.ActiveBorder
            Case "White"
                c = System.Drawing.Color.White
            Case "InactiveCaption"
                c = System.Drawing.SystemColors.InactiveCaption
            Case "RoyalBlue"
                c = System.Drawing.Color.RoyalBlue
            Case Else
                MsgBox("no color in store")
                c = label.Forecolor

        End Select

        Select Case type
            Case ForeColor
                label.ForeColor = c
            Case BackColor
                label.Backcolor = c
        End Select

    End Sub
    '---------------------------------------------------------------------------------
    '显示效果
    '顶栏按钮特效
    Private Sub FieldInfo_MouseHover(sender As Object, e As EventArgs) Handles FieldInfo.MouseHover
        ChangeColor(sender, ForeColor, "ActiveBorder")
    End Sub

    Private Sub FieldInfo_MouseLeave(sender As Object, e As EventArgs) Handles FieldInfo.MouseLeave
        ChangeColor(sender, ForeColor, "White")
    End Sub

    Private Sub GameInfo_MouseHover(sender As Object, e As EventArgs) Handles GameInfo.MouseHover
        ChangeColor(sender, ForeColor, "ActiveBorder")
    End Sub

    Private Sub GameInfo_MouseLeave(sender As Object, e As EventArgs) Handles GameInfo.MouseLeave
        ChangeColor(sender, ForeColor, "White")
    End Sub
    Private Sub TrainingInfo_MouseHover(sender As Object, e As EventArgs) Handles TrainingInfo.MouseHover
        ChangeColor(sender, ForeColor, "ActiveBorder")
    End Sub

    Private Sub TrainingInfo_MouseLeave(sender As Object, e As EventArgs) Handles TrainingInfo.MouseLeave
        ChangeColor(sender, ForeColor, "White")
    End Sub

    Private Sub Feedback_MouseHover(sender As Object, e As EventArgs) Handles Feedback.MouseHover
        ChangeColor(sender, ForeColor, "ActiveBorder")
    End Sub

    Private Sub Feedback_MouseLeave(sender As Object, e As EventArgs) Handles Feedback.MouseLeave
        ChangeColor(sender, ForeColor, "White")
    End Sub
    Private Sub Message_MouseHover(sender As Object, e As EventArgs) Handles Message.MouseHover
        ChangeColor(sender, ForeColor, "ActiveBorder")
    End Sub
    Private Sub Message_MouseLeave(sender As Object, e As EventArgs) Handles Message.MouseLeave
        ChangeColor(sender, ForeColor, "White")
    End Sub
    '显示姓名
    Private Sub student_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO 显示姓名
        'UserName.Text=
    End Sub
    '--------------------------------------------------------------------------------
    '顶栏链接跳转
    '返回首页
    Private Sub HomePageLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles HomePageLink.LinkClicked
        HideAll()
    End Sub
    Private Sub LogoutLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LogoutLink.LinkClicked
        'TODO 退出
    End Sub
    '跳转场地信息页面
    Private Sub FieldInfo_Click(sender As Object, e As EventArgs) Handles FieldInfo.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        ChangeColor(Backcolor1, BackColor, "InactiveCaption")
        FieldPanel.Show()
        SelectField.SelectedIndex = 0
        Dim h = CInt(DateTime.Now.Hour.ToString())
        ComboBox1.SelectedIndex = h - 8
    End Sub
    ''跳转比赛信息页面
    Private Sub GameInfo_Click(sender As Object, e As EventArgs) Handles GameInfo.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        ChangeColor(Backcolor2, BackColor, "InactiveCaption")
        GamePanel.Show()
    End Sub
    '跳转培训信息页面
    Private Sub TrainingInfo_Click(sender As Object, e As EventArgs) Handles TrainingInfo.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        ChangeColor(Backcolor3, BackColor, "InactiveCaption")
        TrainingPanel.Show()
    End Sub
    '跳转反馈页面
    Private Sub Feedback_Click(sender As Object, e As EventArgs) Handles Feedback.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        ChangeColor(Backcolor4, BackColor, "InactiveCaption")
        FeedbackPanel.Show()

    End Sub
    '跳转通知页面
    Private Sub Message_Click(sender As Object, e As EventArgs) Handles Message.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        ChangeColor(Backcolor5, BackColor, "InactiveCaption")
        MessagePanel.Show()
    End Sub
End Class