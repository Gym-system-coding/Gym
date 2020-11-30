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
        Me.WelcomeText = New System.Windows.Forms.Label()
        Me.DeptPEUIText = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Applying = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PELabel2 = New System.Windows.Forms.Label()
        Me.SelectRange = New System.Windows.Forms.ComboBox()
        Me.SelectSports = New System.Windows.Forms.ComboBox()
        Me.PELabel1 = New System.Windows.Forms.Label()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Root.Panel1.SuspendLayout()
        Me.Root.Panel2.SuspendLayout()
        Me.Root.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Root
        '
        Me.Root.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Root.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Root.IsSplitterFixed = True
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Margin = New System.Windows.Forms.Padding(4)
        Me.Root.Name = "Root"
        Me.Root.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Root.Panel1
        '
        Me.Root.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Root.Panel1.Controls.Add(Me.HomepageLink)
        Me.Root.Panel1.Controls.Add(Me.LogoutLink)
        Me.Root.Panel1.Controls.Add(Me.WelcomeText)
        Me.Root.Panel1.Controls.Add(Me.DeptPEUIText)
        Me.Root.Panel1MinSize = 50
        '
        'Root.Panel2
        '
        Me.Root.Panel2.Controls.Add(Me.Button1)
        Me.Root.Panel2.Controls.Add(Me.DataGridView1)
        Me.Root.Panel2.Controls.Add(Me.ComboBox1)
        Me.Root.Panel2.Controls.Add(Me.TextBox1)
        Me.Root.Panel2.Controls.Add(Me.Label2)
        Me.Root.Panel2.Controls.Add(Me.Applying)
        Me.Root.Panel2.Controls.Add(Me.Label1)
        Me.Root.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Root.Panel2.Controls.Add(Me.PELabel2)
        Me.Root.Panel2.Controls.Add(Me.SelectRange)
        Me.Root.Panel2.Controls.Add(Me.SelectSports)
        Me.Root.Panel2.Controls.Add(Me.PELabel1)
        Me.Root.Size = New System.Drawing.Size(1153, 625)
        Me.Root.SplitterDistance = 52
        Me.Root.SplitterWidth = 5
        Me.Root.TabIndex = 0
        '
        'HomepageLink
        '
        Me.HomepageLink.ActiveLinkColor = System.Drawing.Color.White
        Me.HomepageLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomepageLink.AutoSize = True
        Me.HomepageLink.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HomepageLink.LinkColor = System.Drawing.Color.DarkBlue
        Me.HomepageLink.Location = New System.Drawing.Point(1097, 2)
        Me.HomepageLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HomepageLink.Name = "HomepageLink"
        Me.HomepageLink.Size = New System.Drawing.Size(52, 27)
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
        Me.LogoutLink.Location = New System.Drawing.Point(1097, 31)
        Me.LogoutLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogoutLink.Name = "LogoutLink"
        Me.LogoutLink.Size = New System.Drawing.Size(52, 27)
        Me.LogoutLink.TabIndex = 7
        Me.LogoutLink.TabStop = True
        Me.LogoutLink.Text = "退出"
        '
        'WelcomeText
        '
        Me.WelcomeText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WelcomeText.AutoSize = True
        Me.WelcomeText.ForeColor = System.Drawing.Color.White
        Me.WelcomeText.Location = New System.Drawing.Point(1032, 11)
        Me.WelcomeText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WelcomeText.Name = "WelcomeText"
        Me.WelcomeText.Size = New System.Drawing.Size(37, 15)
        Me.WelcomeText.TabIndex = 4
        Me.WelcomeText.Text = "你好"
        '
        'DeptPEUIText
        '
        Me.DeptPEUIText.AutoSize = True
        Me.DeptPEUIText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeptPEUIText.ForeColor = System.Drawing.Color.Navy
        Me.DeptPEUIText.Location = New System.Drawing.Point(16, 15)
        Me.DeptPEUIText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DeptPEUIText.Name = "DeptPEUIText"
        Me.DeptPEUIText.Size = New System.Drawing.Size(110, 32)
        Me.DeptPEUIText.TabIndex = 0
        Me.DeptPEUIText.Text = "体育部专区"
        Me.DeptPEUIText.UseCompatibleTextRendering = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(997, 263)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 29)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "刷新"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(75, 312)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(994, 180)
        Me.DataGridView1.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"08:00-09:00", "09:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00", "13:00-14:00", "14:00-15:00", "15:00-16:00", "16:00-17:00", "17:00-18:00", "18:00-19:00", "19:00-20:00", "20:00-21:00", "21:00-22:00"})
        Me.ComboBox1.Location = New System.Drawing.Point(827, 84)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 23)
        Me.ComboBox1.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(199, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "比赛场地编号:"
        '
        'Applying
        '
        Me.Applying.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Applying.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Applying.Location = New System.Drawing.Point(477, 213)
        Me.Applying.Margin = New System.Windows.Forms.Padding(4)
        Me.Applying.Name = "Applying"
        Me.Applying.Size = New System.Drawing.Size(127, 29)
        Me.Applying.TabIndex = 13
        Me.Applying.Text = "申请比赛"
        Me.Applying.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "选择开始时间："
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yy-mm-dd"
        Me.DateTimePicker1.Location = New System.Drawing.Point(601, 79)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(171, 25)
        Me.DateTimePicker1.TabIndex = 7
        '
        'PELabel2
        '
        Me.PELabel2.AutoSize = True
        Me.PELabel2.Location = New System.Drawing.Point(478, 146)
        Me.PELabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PELabel2.Name = "PELabel2"
        Me.PELabel2.Size = New System.Drawing.Size(82, 15)
        Me.PELabel2.TabIndex = 6
        Me.PELabel2.Text = "选择范围："
        Me.PELabel2.Visible = False
        '
        'SelectRange
        '
        Me.SelectRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.SelectRange.FormattingEnabled = True
        Me.SelectRange.Items.AddRange(New Object() {"校级", "国际经济贸易学院", "金融学院", "国际商学院", "法学院", "英语学院", "外语学院", "信息学院", "保险学院", "政府管理学院", "国际关系学院", "中国语言文学学院", "统计学院", "马克思主义学院"})
        Me.SelectRange.Location = New System.Drawing.Point(601, 138)
        Me.SelectRange.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectRange.Name = "SelectRange"
        Me.SelectRange.Size = New System.Drawing.Size(160, 23)
        Me.SelectRange.TabIndex = 5
        Me.SelectRange.Visible = False
        '
        'SelectSports
        '
        Me.SelectSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectSports.FormattingEnabled = True
        Me.SelectSports.Items.AddRange(New Object() {"篮球", "排球", "羽毛球", "乒乓球", "棒垒球", "网球"})
        Me.SelectSports.Location = New System.Drawing.Point(199, 84)
        Me.SelectSports.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectSports.Name = "SelectSports"
        Me.SelectSports.Size = New System.Drawing.Size(160, 23)
        Me.SelectSports.TabIndex = 4
        '
        'PELabel1
        '
        Me.PELabel1.AutoSize = True
        Me.PELabel1.Location = New System.Drawing.Point(72, 88)
        Me.PELabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PELabel1.Name = "PELabel1"
        Me.PELabel1.Size = New System.Drawing.Size(112, 15)
        Me.PELabel1.TabIndex = 3
        Me.PELabel1.Text = "选择体育项目："
        '
        'DeptPE_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1153, 625)
        Me.Controls.Add(Me.Root)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(994, 613)
        Me.Name = "DeptPE_UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeptPE_UI"
        Me.Root.Panel1.ResumeLayout(False)
        Me.Root.Panel1.PerformLayout()
        Me.Root.Panel2.ResumeLayout(False)
        Me.Root.Panel2.PerformLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Root.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Root As Windows.Forms.SplitContainer
    Public WithEvents DeptPEUIText As Windows.Forms.Label
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
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
