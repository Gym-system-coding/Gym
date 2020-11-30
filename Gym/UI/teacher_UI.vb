Imports System.Data.SqlClient

Public Class Teacher_UI
    Private Sub RefreshLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RefreshLink.LinkClicked

    End Sub

    Private Sub LogoutLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LogoutLink.LinkClicked
        Me.Close()
        Mainpage.M.show()
    End Sub

    Private Sub Teacher_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UserName.Text = Name
        UserName.Text = gymDB.searchname("teacher")
        Dim sqlstring = "SELECT [courtID] 场地号
      ,[courseID] 课程号
      ,[startTime] 开始时间
  FROM [gym_test].[dbo].[course_schedule]
  WHERE gym_test.dbo.course_schedule.ID=" & accountID
        gymDB.datagrid_show(Me.DataGridView1, sqlstring)

    End Sub
End Class