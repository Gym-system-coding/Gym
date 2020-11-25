<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeptPE_UI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeptPE_UI))
        Me.Root = New System.Windows.Forms.SplitContainer()
        Me.HomepageLink = New System.Windows.Forms.LinkLabel()
        Me.LogoutLink = New System.Windows.Forms.LinkLabel()
        Me.UserName = New System.Windows.Forms.Label()
        Me.WelcomeText = New System.Windows.Forms.Label()
        Me.DeptPEUIText = New System.Windows.Forms.Label()
        Me.SelectSports = New System.Windows.Forms.ComboBox()
        Me.PELabel1 = New System.Windows.Forms.Label()
        Me.SelectRange = New System.Windows.Forms.ComboBox()
        Me.PELabel2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Applying = New System.Windows.Forms.Button()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Root.Panel1.SuspendLayout()
        Me.Root.Panel2.SuspendLayout()
        Me.Root.SuspendLayout()
        Me.SuspendLayout()
        '
        'Root
        '
        Me.Root.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Root.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Root.IsSplitterFixed = True
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Root.Panel1
        '
        Me.Root.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Root.Panel1.Controls.Add(Me.HomepageLink)
        Me.Root.Panel1.Controls.Add(Me.LogoutLink)
        Me.Root.Panel1.Controls.Add(Me.UserName)
        Me.Root.Panel1.Controls.Add(Me.WelcomeText)
        Me.Root.Panel1.Controls.Add(Me.DeptPEUIText)
        Me.Root.Panel1MinSize = 50
        '
        'Root.Panel2
        '
        Me.Root.Panel2.Controls.Add(Me.Applying)
        Me.Root.Panel2.Controls.Add(Me.Label1)
        Me.Root.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Root.Panel2.Controls.Add(Me.PELabel2)
        Me.Root.Panel2.Controls.Add(Me.SelectRange)
        Me.Root.Panel2.Controls.Add(Me.SelectSports)
        Me.Root.Panel2.Controls.Add(Me.PELabel1)
        Me.Root.Size = New System.Drawing.Size(865, 500)
        Me.Root.SplitterDistance = 52
        Me.Root.TabIndex = 0
        '
        'HomepageLink
        '
        Me.HomepageLink.ActiveLinkColor = System.Drawing.Color.White
        Me.HomepageLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomepageLink.AutoSize = True
        Me.HomepageLink.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HomepageLink.LinkColor = System.Drawing.Color.DarkBlue
        Me.HomepageLink.Location = New System.Drawing.Point(823, 2)
        Me.HomepageLink.Name = "HomepageLink"
        Me.HomepageLink.Size = New System.Drawing.Size(42, 22)
        Me.HomepageLink.TabIndex = 9
        Me.HomepageLink.TabStop = True
        Me.HomepageLink.Text = "主页"
        '
        'LogoutLink
        '
        Me.LogoutLink.ActiveLinkColor = System.Drawing.Color.White
        Me.LogoutLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutLink.AutoSize = True
        Me.LogoutLink.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LogoutLink.LinkColor = System.Drawing.Color.DarkBlue
        Me.LogoutLink.Location = New System.Drawing.Point(823, 25)
        Me.LogoutLink.Name = "LogoutLink"
        Me.LogoutLink.Size = New System.Drawing.Size(42, 22)
        Me.LogoutLink.TabIndex = 7
        Me.LogoutLink.TabStop = True
        Me.LogoutLink.Text = "退出"
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
        'WelcomeText
        '
        Me.WelcomeText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WelcomeText.AutoSize = True
        Me.WelcomeText.ForeColor = System.Drawing.Color.White
        Me.WelcomeText.Location = New System.Drawing.Point(774, 9)
        Me.WelcomeText.Name = "WelcomeText"
        Me.WelcomeText.Size = New System.Drawing.Size(29, 12)
        Me.WelcomeText.TabIndex = 4
        Me.WelcomeText.Text = "你好"
        '
        'DeptPEUIText
        '
        Me.DeptPEUIText.AutoSize = True
        Me.DeptPEUIText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeptPEUIText.ForeColor = System.Drawing.Color.Navy
        Me.DeptPEUIText.Location = New System.Drawing.Point(12, 12)
        Me.DeptPEUIText.Name = "DeptPEUIText"
        Me.DeptPEUIText.Size = New System.Drawing.Size(88, 27)
        Me.DeptPEUIText.TabIndex = 0
        Me.DeptPEUIText.Text = "体育部专区"
        Me.DeptPEUIText.UseCompatibleTextRendering = True
        '
        'SelectSports
        '
        Me.SelectSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectSports.FormattingEnabled = True
        Me.SelectSports.Items.AddRange(New Object() {"篮球", "排球", "羽毛球", "乒乓球", "棒垒球", "网球"})
        Me.SelectSports.Location = New System.Drawing.Point(149, 67)
        Me.SelectSports.Name = "SelectSports"
        Me.SelectSports.Size = New System.Drawing.Size(121, 20)
        Me.SelectSports.TabIndex = 4
        '
        'PELabel1
        '
        Me.PELabel1.AutoSize = True
        Me.PELabel1.Location = New System.Drawing.Point(54, 70)
        Me.PELabel1.Name = "PELabel1"
        Me.PELabel1.Size = New System.Drawing.Size(89, 12)
        Me.PELabel1.TabIndex = 3
        Me.PELabel1.Text = "选择体育项目："
        '
        'SelectRange
        '
        Me.SelectRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectRange.FormattingEnabled = True
        Me.SelectRange.Items.AddRange(New Object() {"校级", "国际经济贸易学院", "金融学院", "国际商学院", "法学院", "英语学院", "外语学院", "信息学院", "保险学院", "政府管理学院", "国际关系学院", "中国语言文学学院", "统计学院", "马克思主义学院"})
        Me.SelectRange.Location = New System.Drawing.Point(359, 67)
        Me.SelectRange.Name = "SelectRange"
        Me.SelectRange.Size = New System.Drawing.Size(121, 20)
        Me.SelectRange.TabIndex = 5
        '
        'PELabel2
        '
        Me.PELabel2.AutoSize = True
        Me.PELabel2.Location = New System.Drawing.Point(288, 70)
        Me.PELabel2.Name = "PELabel2"
        Me.PELabel2.Size = New System.Drawing.Size(65, 12)
        Me.PELabel2.TabIndex = 6
        Me.PELabel2.Text = "选择范围："
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yy-mm-dd"
        Me.DateTimePicker1.Location = New System.Drawing.Point(603, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 21)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "选择开始时间："
        '
        'Applying
        '
        Me.Applying.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Applying.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Applying.Location = New System.Drawing.Point(359, 180)
        Me.Applying.Name = "Applying"
        Me.Applying.Size = New System.Drawing.Size(95, 23)
        Me.Applying.TabIndex = 13
        Me.Applying.Text = "申请比赛"
        Me.Applying.UseVisualStyleBackColor = False
        '
        'DeptPE_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(865, 500)
        Me.Controls.Add(Me.Root)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "DeptPE_UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeptPE_UI"
        Me.Root.Panel1.ResumeLayout(False)
        Me.Root.Panel1.PerformLayout()
        Me.Root.Panel2.ResumeLayout(False)
        Me.Root.Panel2.PerformLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Root.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Root As Windows.Forms.SplitContainer
    Public WithEvents DeptPEUIText As Windows.Forms.Label
    Friend WithEvents UserName As Windows.Forms.Label
    Friend WithEvents WelcomeText As Windows.Forms.Label
    Friend WithEvents LogoutLink As Windows.Forms.LinkLabel
    Friend WithEvents HomepageLink As Windows.Forms.LinkLabel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
    Friend WithEvents PELabel2 As Windows.Forms.Label
    Friend WithEvents SelectRange As Windows.Forms.ComboBox
    Friend WithEvents SelectSports As Windows.Forms.ComboBox
    Friend WithEvents PELabel1 As Windows.Forms.Label
    Friend WithEvents Applying As Windows.Forms.Button
End Class
