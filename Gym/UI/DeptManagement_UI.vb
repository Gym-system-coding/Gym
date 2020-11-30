Public Class DeptManagement_UI
    Public Sub HideAll()
        ConfirmMaintainPanel.Hide()
        SearchFieldPanel.Hide()
        ConfirmGamePanel.Hide()
    End Sub

    Private Sub DeptManagement_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAll()
    End Sub
    Private Sub LogoutLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LogoutLink.LinkClicked
        Me.Close()
        Mainpage.M.show()
    End Sub
    Private Sub HomepageLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles HomepageLink.LinkClicked
        HideAll()
    End Sub

    Private Sub ConfirmMaintain_Click(sender As Object, e As EventArgs) Handles ToConfirmMaintain.Click
        HideAll()
        ConfirmMaintainPanel.Show()
    End Sub

    Private Sub AlterStatus_Click(sender As Object, e As EventArgs) Handles ToAlterStatus.Click
        HideAll()
        SearchFieldPanel.Show()

    End Sub


    Private Sub ToConfirmGame_Click(sender As Object, e As EventArgs) Handles ToConfirmGame.Click
        HideAll()
        ConfirmGamePanel.Show()

    End Sub

    Private Sub SearchFieldPanel_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles SearchFieldPanel.Paint
        gymDB.get_court_manage(DataGridView4)
    End Sub

    Private Sub searching_Click(sender As Object, e As EventArgs) Handles searching.Click
        gymDB.get_court_manage(DataGridView4)
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim courtID As String = FieldInput.Text
        If courtID = Nothing Or ComboBox1.Text = Nothing Then
            MsgBox("请先输入场地与时间")
            Return
        End If
        Dim stopTime As String = String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value) & " " & ComboBox1.Text.Substring(0, 2) & ":00:00"
        If gymDB.court_check2(courtID) = False Then
            MsgBox("场地已被禁止")
            Return
        End If
        gymDB.add_court_manage(courtID, stopTime)

    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim courtID As String = FieldInput.Text
        If courtID = Nothing Then
            MsgBox("请先输入场地编号")
            Return
        End If
        If gymDB.court_check2(courtID) = True Then
            MsgBox("场地未禁止")
            Return
        End If

        gymDB.delete_court_manage(courtID)
    End Sub
End Class