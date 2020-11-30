Imports System.Windows.Forms
Public Class Mainpage
    Public Shared M
    Private vbMaximized As FormWindowState

    Private Sub Login_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Loginlink.LinkClicked
        M = Me
        Dim lg As Form = New Login
        lg.Show()
    End Sub
    '---------------add 点击跳转通知正文
    Private Sub Mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gymDB.dbconn()
        gymDB.get_notification(gymDS)
        Dim LVI As ListViewItem
        For i As Integer = 0 To gymDS.Tables("notification").Rows.Count - 1
            LVI = New ListViewItem
            LVI.Text = (gymDS.Tables("notification").Rows(i).Item(2))
            LVI.SubItems.Add(gymDS.Tables("notification").Rows(i).Item(1))
            ListView1.Items.Add(LVI)
        Next
        ListView1.Refresh()
    End Sub

End Class