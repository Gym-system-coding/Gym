Public Class DeptMaintain_UI
    Private Sub LogoutLink_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LogoutLink.LinkClicked
        Me.Close()
        Mainpage.M.show()
    End Sub
End Class