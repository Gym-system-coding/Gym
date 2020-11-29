Public Class DeptManagement_UI
    Public Sub HideAll()
        ConfirmMaintainPanel.Hide()
        AlterStatusPanel.Hide()
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
        AlterStatusPanel.Show()

    End Sub


    Private Sub ToConfirmGame_Click(sender As Object, e As EventArgs) Handles ToConfirmGame.Click
        HideAll()
        ConfirmGamePanel.Show()

    End Sub
End Class