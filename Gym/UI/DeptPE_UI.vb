Public Class DeptPE_UI
    Private Sub LogoutLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LogoutLink.LinkClicked
        Me.Close()
        Mainpage.M.show()
    End Sub

    Private Sub Applying_Click(sender As Object, e As EventArgs) Handles Applying.Click
        Dim matchID As String = "0" & SelectSports.SelectedIndex + 1 & ""
        Dim courtID As Int16 = TextBox1.Text
        Dim startTime As DateTime = String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value) & " " & ComboBox1.Text.Substring(0, 2) & ":00:00"
        'Dim type As String = SelectRange.Text
        If matchID = Nothing Or courtID = Nothing Or ComboBox1.Text = Nothing Then
            MsgBox("请输入完整信息")

        End If
        MsgBox(matchID & courtID & ComboBox1.Text)
        gymDB.add_match(matchID, startTime, courtID)
    End Sub

    Private Sub DeptPE_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gymDB.match_search(DataGridView1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gymDB.match_search(DataGridView1)
    End Sub
End Class