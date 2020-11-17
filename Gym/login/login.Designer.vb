<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.IdentityBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameBox
        '
        Me.UsernameBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.UsernameBox.Location = New System.Drawing.Point(103, 50)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(158, 21)
        Me.UsernameBox.TabIndex = 0
        Me.UsernameBox.Text = "用户名"
        '
        'PasswordBox
        '
        Me.PasswordBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.PasswordBox.Location = New System.Drawing.Point(103, 89)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(158, 21)
        Me.PasswordBox.TabIndex = 1
        Me.PasswordBox.Text = "密码"
        '
        'IdentityBox
        '
        Me.IdentityBox.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.IdentityBox.FormattingEnabled = True
        Me.IdentityBox.Items.AddRange(New Object() {"学生", "教师", "体育部门", "管理部门", "维护部门"})
        Me.IdentityBox.Location = New System.Drawing.Point(103, 128)
        Me.IdentityBox.Name = "IdentityBox"
        Me.IdentityBox.Size = New System.Drawing.Size(158, 20)
        Me.IdentityBox.TabIndex = 2
        Me.IdentityBox.Text = "身份"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "登录"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 241)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IdentityBox)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Location = New System.Drawing.Point(200, 500)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "登录"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameBox As Windows.Forms.TextBox
    Friend WithEvents PasswordBox As Windows.Forms.TextBox
    Friend WithEvents IdentityBox As Windows.Forms.ComboBox
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
