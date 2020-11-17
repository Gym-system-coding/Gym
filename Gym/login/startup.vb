Imports System.Drawing
Imports System.Windows.Forms
Public Class startup
    Private Sub login_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles loginlink.LinkClicked
        Dim lg As Form = New login
        lg.Show()
    End Sub
End Class