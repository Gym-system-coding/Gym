Public Class DeptMaintain_UI
    Private Sub LogoutLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LogoutLink.LinkClicked
        Me.Close()
        Mainpage.M.show()
    End Sub

    Private Sub DeptMaintain_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gymDB.Maintain_search(DataGridView1)
    End Sub
End Class