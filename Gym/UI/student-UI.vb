Public Class student_UI
    Sub HideAll()
        FieldPanel.Hide()
        ChangeColor(FieldInfo, BackColor, "White")
        ChangeColor(FieldInfo, BackColor, "bgcolor")
        GamePanel.Hide()
        ChangeColor(GameInfo, BackColor, "White")
        ChangeColor(GameInfo, BackColor, "bgcolor")
        TrainingPanel.Hide()
        ChangeColor(TrainingInfo, BackColor, "White")
        ChangeColor(TrainingInfo, BackColor, "bgcolor")
        FeedbackPanel.Hide()
        ChangeColor(Feedback, BackColor, "White")
        ChangeColor(Feedback, BackColor, "bgcolor")
        MessagePanel.Hide()
        ChangeColor(Message, BackColor, "White")
        ChangeColor(Message, BackColor, "bgcolor")
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
        Me.FieldInfo_Click(Me.FieldInfo, e)
        Me.SearchField_Click(Me.SearchField, e)

    End Sub

    '--------------------------------------------------------------------------------

    '顶栏链接跳转
    '返回首页
    Private Sub HomePageLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles HomepageLink.LinkClicked
        HideAll()
    End Sub
    Private Sub LogoutLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LogoutLink.LinkClicked
        Dim main = New Mainpage
        Me.Close()
        'main.Show()
        Mainpage.M.show()
    End Sub
    '跳转场地信息页面
    Private Sub FieldInfo_Click(sender As Object, e As EventArgs) Handles FieldInfo.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        FieldPanel.Show()
        SelectField.SelectedIndex = 0
        Dim h = CInt(DateTime.Now.Hour.ToString())
        If (h >= 8 And h <= 21) Then
            ComboBox1.SelectedIndex = h - 8
        Else
            ComboBox1.SelectedIndex = 0
        End If
        SearchField.Show()
    End Sub
    ''跳转比赛信息页面
    Private Sub GameInfo_Click(sender As Object, e As EventArgs) Handles GameInfo.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        GamePanel.Show()
    End Sub
    '跳转培训信息页面
    Private Sub TrainingInfo_Click(sender As Object, e As EventArgs) Handles TrainingInfo.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        TrainingPanel.Show()
    End Sub
    '跳转反馈页面
    Private Sub Feedback_Click(sender As Object, e As EventArgs) Handles Feedback.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        FeedbackPanel.Show()

    End Sub
    '跳转通知页面

    '-----------------------------------------------------------

    Private Sub Message_Click(sender As Object, e As EventArgs) Handles Message.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        MessagePanel.Show()
    End Sub
    '跳转1-子页面：搜索场地信息页面
    Private Sub SearchField_Click(sender As Object, e As EventArgs) Handles SearchField.Click
        MyFieldPanel.Hide()
        SearchFieldPanel.Show()
    End Sub
    '跳转1-子页面：我的场地信息页面
    Private Sub MyField_Click(sender As Object, e As EventArgs) Handles MyField.Click
        SearchFieldPanel.Hide()
        MyFieldPanel.Show()
    End Sub
    '功能按钮11
    Private Sub Booking_Click(sender As Object, e As EventArgs) Handles Booking.Click
        'TODO 检索条件
        If FieldInput.Text = "1" Then
            Dim Pdd = MsgBox("场地已占用。
该场地开放拼场，是否选择拼场？", Buttons:=1)
            If Pdd = 1 Then
                Me.Sharing_Click(Me.Sharing, e)
            End If
        ElseIf FieldInput.Text = "2" Then
            MsgBox("场地已占用")
        ElseIf FieldInput.Text = "3" Then
            MsgBox("信息错误")
        ElseIf FieldInput.Text = "4" Then
            MsgBox("成功预约！")
        End If
    End Sub
    Private Sub Sharing_Click(sender As Object, e As EventArgs) Handles Sharing.Click
        If FieldInput.Text = "1" Then
            MsgBox("成功拼场！")
        ElseIf FieldInput.Text = "2" Then
            MsgBox("场地已占用")
        ElseIf FieldInput.Text = "3" Then
            MsgBox("信息错误")
        ElseIf FieldInput.Text = "4" Then
            Dim b = MsgBox("空场地！是否选择预约？")
            If b = 1 Then
                Me.Booking_Click(Me.Booking, e)
            End If
        End If
    End Sub
    Private Sub Waiting_Click(sender As Object, e As EventArgs) Handles Waiting.Click
        If FieldInput.Text = "1" Then
            Dim Pdd = MsgBox("该场地开放拼场，是否选择拼场？", Buttons:=1)
            If Pdd = 1 Then
                Me.Sharing_Click(Me.Sharing, e)
            End If
        ElseIf FieldInput.Text = "2" Then
            MsgBox("等待成功！")
        ElseIf FieldInput.Text = "3" Then
            MsgBox("信息错误")
        ElseIf FieldInput.Text = "4" Then
            Dim b = MsgBox("空场地！是否选择预约？")
            If b = 1 Then
                Me.Booking_Click(Me.Booking, e)
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'TODO 链接数据库
    End Sub
    '功能按钮12
    Private Sub Unsubscribe_Click(sender As Object, e As EventArgs) Handles Unsubscribe.Click
        MsgBox("退订成功")
    End Sub
    Private Sub Paying_Click(sender As Object, e As EventArgs) Handles Paying.Click
        MsgBox("缴费成功")
    End Sub
    Private Sub ToShare_Click(sender As Object, e As EventArgs) Handles ToShare.Click
        MsgBox("已发起拼场")
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        'TODO 链接数据库
    End Sub


    '-------------------------------------------------------------------------------------------------

    Private Sub DataGridView3_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        'TODO 链接数据库
    End Sub
    Private Sub DataGridView4_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        'TODO 链接数据库
    End Sub

    Private Sub JoinGame_Click(sender As Object, e As EventArgs) Handles JoinGame.Click
        'TODO 跳转选择页面
    End Sub


    '-------------------------------------------------------------------------------------------------
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'TODO 链接数据库
    End Sub
End Class