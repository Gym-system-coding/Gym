Imports System.Windows.Forms

Public Class Student_UI
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
    Private Sub Student_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        'TODO 显示姓名
        'UserName.Text =
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
        Me.Close()
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
        ProblemPanel.Hide()
        MaintenancePanel.Hide()
    End Sub
    '跳转通知页面

    '-----------------------------------------------------------
    '场地部分

    Private Sub Message_Click(sender As Object, e As EventArgs) Handles Message.Click
        HideAll()
        ChangeColor(sender, BackColor, "InactiveCaption")
        MessagePanel.Show()
        MessageGeneralPanel.Show()
        MessageReportPanel.Hide()

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
        Dim courtID As String = FieldInput.Text
        If courtID = Nothing Or ComboBox1.Text = Nothing Then
            MsgBox("请先输入场地与时间")
            Return
        End If
        Dim expectedTime As String = String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value) & " " & ComboBox1.Text.Substring(0, 2) & ":00:00"

        If gymDB.court_check(courtID, expectedTime) Then
            MsgBox("此场地暂不开放")
            Return
        End If

        Dim f1 As Boolean = gymDB.appointment_check(courtID, expectedTime)
        Dim f2 As Boolean
        If f1 = False Then
            Dim temp As New Int16
            f2 = gymDB.sharing_application_check(courtID, expectedTime, temp)
        End If
        'TODO 检索条件
        If f1 = False And f2 = True Then
            Dim Pdd = MsgBox("场地已占用。
该场地开放拼场，是否选择拼场？", Buttons:=1)
            If Pdd = 1 Then
                Me.Sharing_Click(Me.Sharing, e)
            End If
            'ElseIf FieldInput.Text = "2" Then
            '    MsgBox("场地已占用")
            'ElseIf FieldInput.Text = "3" Then
            '    MsgBox("信息错误")
            'ElseIf FieldInput.Text = "4" Then
            '    MsgBox("成功预约！")
        Else
            gymDB.appointment(courtID, expectedTime)
            ''设置允许拼场---------------------------------msgbox实现
        End If
    End Sub
    Private Sub Sharing_Click(sender As Object, e As EventArgs) Handles Sharing.Click
        Dim f2 As Boolean
        Dim courtID As String = FieldInput.Text
        If courtID = Nothing Or ComboBox1.Text = Nothing Then
            MsgBox("请先输入场地与时间")
            Return
        End If
        Dim expectedTime As String = String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value) & " " & ComboBox1.Text.Substring(0, 2) & ":00:00"

        If gymDB.court_check(courtID, expectedTime) Then
            MsgBox("此场地暂不开放")
            Return
        End If

        Dim shareID As New Int16
        f2 = gymDB.sharing_application_check(courtID, expectedTime, shareID)
        If f2 Then
            gymDB.sharing_application(courtID, expectedTime, shareID)
        Else
            MsgBox("无可拼场的朋友,您可以等待或换个场地")
            End
            'If FieldInput.Text = "1" Then
            '    MsgBox("成功拼场！")
            'ElseIf FieldInput.Text = "2" Then
            '    MsgBox("场地已占用")
            'ElseIf FieldInput.Text = "3" Then
            '    MsgBox("信息错误")
            'ElseIf FieldInput.Text = "4" Then
            '    Dim b = MsgBox("空场地！是否选择预约？")
            '    If b = 1 Then
            '        Me.Booking_Click(Me.Booking, e)
            '    End If
        End If
    End Sub
    Private Sub Waiting_Click(sender As Object, e As EventArgs) Handles Waiting.Click
        Dim courtID As String = FieldInput.Text
        If courtID = Nothing Or ComboBox1.Text = Nothing Then
            MsgBox("请先输入场地与时间")
            Return
        End If
        Dim expectedTime As String = String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value) & " " & ComboBox1.Text.Substring(0, 2) & ":00:00"

        If gymDB.court_check(courtID, expectedTime) Then
            MsgBox("此场地暂不开放")
            Return
        End If

        '-----------------------------------------------------------------------------------------------
        Dim f3 As Boolean = gymDB.appointment_check(courtID, expectedTime)

        'TODO 检索条件
        If f3 = True Then
            Dim Pdd = MsgBox("当前场地空闲,是否直接预约?", Buttons:=1)
            If Pdd = 1 Then
                Me.Booking_Click(Me.Waiting, e)
            End If

            'ElseIf FieldInput.Text = "2" Then
            '    MsgBox("场地已占用")
            'ElseIf FieldInput.Text = "3" Then
            '    MsgBox("信息错误")
            'ElseIf FieldInput.Text = "4" Then
            '    MsgBox("成功预约！")
        Else
            gymDB.appointment(courtID, expectedTime)
            ''设置允许拼场---------------------------------msgbox实现

        End If
        '-----------------------------------------------------------------------------------------------
        'If FieldInput.Text = "1" Then
        '    Dim Pdd = MsgBox("该场地开放拼场，是否选择拼场？", Buttons:=1)
        '    If Pdd = 1 Then
        '        Me.Sharing_Click(Me.Sharing, e)
        '    End If
        'ElseIf FieldInput.Text = "2" Then
        '    MsgBox("等待成功！")
        'ElseIf FieldInput.Text = "3" Then
        '    MsgBox("信息错误")
        'ElseIf FieldInput.Text = "4" Then
        '    Dim b = MsgBox("空场地！是否选择预约？")
        '    If b = 1 Then
        '        Me.Booking_Click(Me.Booking, e)
        '    End If
        'End If
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
    '比赛部分

    Private Sub DataGridView3_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        'TODO 链接数据库
    End Sub
    Private Sub DataGridView4_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        'TODO 链接数据库
    End Sub
    Private Sub JoinGame_Click(sender As Object, e As EventArgs) Handles JoinGame.Click
        'TODO 跳转选择页面
        MsgBox("比赛报名成功")
    End Sub

    '-------------------------------------------------------------------------------------------------
    '培训部分

    Private Sub TrainingApplying_Click(sender As Object, e As EventArgs) Handles TrainingApplying.Click
        Dim w = Weekday(Now)
        If (w = 1 Or w = 7) Then
            MsgBox("当前不开放申请")
        Else
            'TODO 待完成
            MsgBox("成功申请")
        End If
    End Sub
    Private Sub DataGridView5_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        'TODO 链接数据库
    End Sub
    Private Sub SelectLesson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectLesson.SelectedIndexChanged
        'TODO 待完成
    End Sub

    '-------------------------------------------------------------------------------------------------
    '消息部分

    Private Sub GeneralMessage_Click(sender As Object, e As EventArgs) Handles GeneralMessage.Click
        MessageGeneralPanel.Show()
        MessageReportPanel.Hide()
    End Sub
    Private Sub Report_Click(sender As Object, e As EventArgs) Handles Report.Click
        MessageReportPanel.Show()
        MessageGeneralPanel.Hide()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'TODO 链接数据库
    End Sub

    '-------------------------------------------------------------------------------------------------
    '反馈部分

    Private Sub Problem_Click(sender As Object, e As EventArgs) Handles Problem.Click
        ProblemPanel.Show()
        MaintenancePanel.Hide()
    End Sub
    Private Sub Maintenace_Click(sender As Object, e As EventArgs) Handles Maintenace.Click
        ProblemPanel.Hide()
        MaintenancePanel.Show()
    End Sub
    Private Sub MaintenanceSubmit_Click(sender As Object, e As EventArgs) Handles MaintenanceSubmit.Click
        'TODO 报修按钮
        MsgBox("报修成功")
    End Sub
    Private Sub ProblemSubmit_Click(sender As Object, e As EventArgs) Handles ProblemSubmit.Click
        'TODO 反馈按钮
        MsgBox("问题反馈成功")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub SearchFieldPanel_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles SearchFieldPanel.Paint
        gymDB.time_stadium_info(DataGridView1, Now().ToString("yyyy-MM-dd HH:") & "00:00", 103)
    End Sub

    Private Sub searching_Click(sender As Object, e As EventArgs) Handles searching.Click
        gymDB.time_stadium_info(DataGridView1, String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value) & " " & ComboBox1.Text.Substring(0, 2) & ":00:00", 103)
    End Sub
End Class
'Now().ToString("yyyy-MM-dd HH:mm:ss") 