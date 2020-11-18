<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_UI
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Message = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrainingInfo = New System.Windows.Forms.Label()
        Me.GameInfo = New System.Windows.Forms.Label()
        Me.FieldInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logout = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Logout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Message)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UserName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TrainingInfo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GameInfo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FieldInfo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(865, 500)
        Me.SplitContainer1.SplitterDistance = 52
        Me.SplitContainer1.TabIndex = 0
        '
        'Message
        '
        Me.Message.AutoSize = True
        Me.Message.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Message.ForeColor = System.Drawing.Color.White
        Me.Message.Location = New System.Drawing.Point(470, 10)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(46, 31)
        Me.Message.TabIndex = 6
        Me.Message.Text = "消息"
        Me.Message.UseCompatibleTextRendering = True
        '
        'UserName
        '
        Me.UserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserName.AutoSize = True
        Me.UserName.ForeColor = System.Drawing.Color.White
        Me.UserName.Location = New System.Drawing.Point(774, 27)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(41, 12)
        Me.UserName.TabIndex = 5
        Me.UserName.Text = "某某某"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(774, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "你好"
        '
        'TrainingInfo
        '
        Me.TrainingInfo.AutoSize = True
        Me.TrainingInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TrainingInfo.ForeColor = System.Drawing.Color.White
        Me.TrainingInfo.Location = New System.Drawing.Point(360, 10)
        Me.TrainingInfo.Name = "TrainingInfo"
        Me.TrainingInfo.Size = New System.Drawing.Size(46, 31)
        Me.TrainingInfo.TabIndex = 3
        Me.TrainingInfo.Text = "培训"
        Me.TrainingInfo.UseCompatibleTextRendering = True
        '
        'GameInfo
        '
        Me.GameInfo.AutoSize = True
        Me.GameInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GameInfo.ForeColor = System.Drawing.Color.White
        Me.GameInfo.Location = New System.Drawing.Point(250, 10)
        Me.GameInfo.Name = "GameInfo"
        Me.GameInfo.Size = New System.Drawing.Size(46, 31)
        Me.GameInfo.TabIndex = 2
        Me.GameInfo.Text = "比赛"
        Me.GameInfo.UseCompatibleTextRendering = True
        '
        'FieldInfo
        '
        Me.FieldInfo.AutoSize = True
        Me.FieldInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FieldInfo.ForeColor = System.Drawing.Color.White
        Me.FieldInfo.Location = New System.Drawing.Point(140, 10)
        Me.FieldInfo.Name = "FieldInfo"
        Me.FieldInfo.Size = New System.Drawing.Size(46, 31)
        Me.FieldInfo.TabIndex = 1
        Me.FieldInfo.Text = "场地"
        Me.FieldInfo.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(0, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "学生专区"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Logout
        '
        Me.Logout.ActiveLinkColor = System.Drawing.Color.White
        Me.Logout.AutoSize = True
        Me.Logout.Dock = System.Windows.Forms.DockStyle.Right
        Me.Logout.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Logout.LinkColor = System.Drawing.Color.DarkBlue
        Me.Logout.Location = New System.Drawing.Point(823, 0)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(42, 22)
        Me.Logout.TabIndex = 7
        Me.Logout.TabStop = True
        Me.Logout.Text = "退出"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(580, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "其他"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'student_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 500)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "student_UI"
        Me.Text = "student_UI"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Public WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents UserName As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Public WithEvents TrainingInfo As Windows.Forms.Label
    Public WithEvents GameInfo As Windows.Forms.Label
    Public WithEvents FieldInfo As Windows.Forms.Label
    Public WithEvents Message As Windows.Forms.Label
    Friend WithEvents Logout As Windows.Forms.LinkLabel
    Public WithEvents Label2 As Windows.Forms.Label
End Class
