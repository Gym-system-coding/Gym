Imports System.Windows.Forms
Public Class Mainpage
    Public Shared M
    Private Sub Login_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Loginlink.LinkClicked
        M = Me
        Dim lg As Form = New login
        lg.Show()
    End Sub
End Class