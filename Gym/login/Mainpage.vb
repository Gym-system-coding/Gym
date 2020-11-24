Imports System.Drawing
Imports System.Windows.Forms
Public Class Mainpage
    Private Sub login_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles loginlink.LinkClicked
        Dim lg As Form = New login
        lg.Show()
        Me.Hide()
    End Sub
End Class