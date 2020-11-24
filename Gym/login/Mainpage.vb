Imports System.Windows.Forms
Public Class Mainpage
    Public Shared M
    Private Sub login_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles loginlink.LinkClicked
        M = Me
        Dim lg As Form = New login
        lg.Show()
    End Sub
End Class