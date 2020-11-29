<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_UI
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("ddd")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("ddd")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("ddd")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("ddd")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_UI))
        Me.Root = New System.Windows.Forms.SplitContainer()
        Me.HomepageLink = New System.Windows.Forms.LinkLabel()
        Me.Feedback = New System.Windows.Forms.Label()
        Me.LogoutLink = New System.Windows.Forms.LinkLabel()
        Me.Message = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.WelcomeText = New System.Windows.Forms.Label()
        Me.TrainingInfo = New System.Windows.Forms.Label()
        Me.GameInfo = New System.Windows.Forms.Label()
        Me.FieldInfo = New System.Windows.Forms.Label()
        Me.StudentUIText = New System.Windows.Forms.Label()
        Me.FieldPanel = New System.Windows.Forms.Panel()
        Me.FieldContainer = New System.Windows.Forms.SplitContainer()
        Me.MyField = New System.Windows.Forms.Button()
        Me.SearchField = New System.Windows.Forms.Button()
        Me.MyFieldPanel = New System.Windows.Forms.Panel()
        Me.ToShare = New System.Windows.Forms.Button()
        Me.Paying = New System.Windows.Forms.Button()
        Me.Unsubscribe = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SearchFieldPanel = New System.Windows.Forms.Panel()
        Me.searching = New System.Windows.Forms.Button()
        Me.Waiting = New System.Windows.Forms.Button()
        Me.Sharing = New System.Windows.Forms.Button()
        Me.Booking = New System.Windows.Forms.Button()
        Me.InputText1 = New System.Windows.Forms.Label()
        Me.FieldInput = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OptionText2 = New System.Windows.Forms.Label()
        Me.OptionText1 = New System.Windows.Forms.Label()
        Me.SelectField = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MessagePanel = New System.Windows.Forms.Panel()
        Me.MessageContainer = New System.Windows.Forms.SplitContainer()
        Me.Report = New System.Windows.Forms.Button()
        Me.GeneralMessage = New System.Windows.Forms.Button()
        Me.MessageGeneralPanel = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MessageReportPanel = New System.Windows.Forms.Panel()
        Me.FeedbackPanel = New System.Windows.Forms.Panel()
        Me.FeedbackContainer = New System.Windows.Forms.SplitContainer()
        Me.Maintenace = New System.Windows.Forms.Button()
        Me.Problem = New System.Windows.Forms.Button()
        Me.ProblemPanel = New System.Windows.Forms.Panel()
        Me.ProblemSubmit = New System.Windows.Forms.Button()
        Me.ProblemDescribe = New System.Windows.Forms.RichTextBox()
        Me.SelectProblemType = New System.Windows.Forms.ComboBox()
        Me.GymNOInput = New System.Windows.Forms.TextBox()
        Me.ProblemLabel1 = New System.Windows.Forms.Label()
        Me.ProblemLabel2 = New System.Windows.Forms.Label()
        Me.ProblemLabel3 = New System.Windows.Forms.Label()
        Me.MaintenancePanel = New System.Windows.Forms.Panel()
        Me.MaintenanceSubmit = New System.Windows.Forms.Button()
        Me.MaintenanceDescribe = New System.Windows.Forms.RichTextBox()
        Me.SelectMaintenanceType = New System.Windows.Forms.ComboBox()
        Me.MaintenanceInput = New System.Windows.Forms.TextBox()
        Me.MaintenanceLabel1 = New System.Windows.Forms.Label()
        Me.MaintenanceLabel2 = New System.Windows.Forms.Label()
        Me.MaintenanceLabel3 = New System.Windows.Forms.Label()
        Me.TrainingPanel = New System.Windows.Forms.Panel()
        Me.TrainingApplying = New System.Windows.Forms.Button()
        Me.SelectLesson = New System.Windows.Forms.ComboBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.TrainingLabel1 = New System.Windows.Forms.Label()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.JoinGame = New System.Windows.Forms.Button()
        Me.GameLabel3 = New System.Windows.Forms.Label()
        Me.GameLabel2 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Root.Panel1.SuspendLayout()
        Me.Root.Panel2.SuspendLayout()
        Me.Root.SuspendLayout()
        Me.FieldPanel.SuspendLayout()
        CType(Me.FieldContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FieldContainer.Panel1.SuspendLayout()
        Me.FieldContainer.Panel2.SuspendLayout()
        Me.FieldContainer.SuspendLayout()
        Me.MyFieldPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchFieldPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessagePanel.SuspendLayout()
        CType(Me.MessageContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessageContainer.Panel1.SuspendLayout()
        Me.MessageContainer.Panel2.SuspendLayout()
        Me.MessageContainer.SuspendLayout()
        Me.MessageGeneralPanel.SuspendLayout()
        Me.FeedbackPanel.SuspendLayout()
        CType(Me.FeedbackContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FeedbackContainer.Panel1.SuspendLayout()
        Me.FeedbackContainer.Panel2.SuspendLayout()
        Me.FeedbackContainer.SuspendLayout()
        Me.ProblemPanel.SuspendLayout()
        Me.MaintenancePanel.SuspendLayout()
        Me.TrainingPanel.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GamePanel.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Root.Panel1.Controls.Add(Me.Feedback)
        Me.Root.Panel1.Controls.Add(Me.LogoutLink)
        Me.Root.Panel1.Controls.Add(Me.Message)
        Me.Root.Panel1.Controls.Add(Me.UserName)
        Me.Root.Panel1.Controls.Add(Me.WelcomeText)
        Me.Root.Panel1.Controls.Add(Me.TrainingInfo)
        Me.Root.Panel1.Controls.Add(Me.GameInfo)
        Me.Root.Panel1.Controls.Add(Me.FieldInfo)
        Me.Root.Panel1.Controls.Add(Me.StudentUIText)
        Me.Root.Panel1MinSize = 50
        '
        'Root.Panel2
        '
        Me.Root.Panel2.Controls.Add(Me.FieldPanel)
        Me.Root.Panel2.Controls.Add(Me.MessagePanel)
        Me.Root.Panel2.Controls.Add(Me.FeedbackPanel)
        Me.Root.Panel2.Controls.Add(Me.TrainingPanel)
        Me.Root.Panel2.Controls.Add(Me.GamePanel)
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
        'Feedback
        '
        Me.Feedback.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Feedback.ForeColor = System.Drawing.Color.White
        Me.Feedback.Location = New System.Drawing.Point(585, 0)
        Me.Feedback.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Feedback.Name = "Feedback"
        Me.Feedback.Padding = New System.Windows.Forms.Padding(40, 16, 0, 0)
        Me.Feedback.Size = New System.Drawing.Size(143, 65)
        Me.Feedback.TabIndex = 8
        Me.Feedback.Text = "反馈"
        Me.Feedback.UseCompatibleTextRendering = True
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
        'Message
        '
        Me.Message.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Message.ForeColor = System.Drawing.Color.White
        Me.Message.Location = New System.Drawing.Point(732, 0)
        Me.Message.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Message.Name = "Message"
        Me.Message.Padding = New System.Windows.Forms.Padding(40, 16, 0, 0)
        Me.Message.Size = New System.Drawing.Size(143, 65)
        Me.Message.TabIndex = 6
        Me.Message.Text = "通知"
        Me.Message.UseCompatibleTextRendering = True
        '
        'UserName
        '
        Me.UserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserName.AutoSize = True
        Me.UserName.ForeColor = System.Drawing.Color.White
        Me.UserName.Location = New System.Drawing.Point(1032, 34)
        Me.UserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(52, 15)
        Me.UserName.TabIndex = 5
        Me.UserName.Text = "某某某"
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
        'TrainingInfo
        '
        Me.TrainingInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TrainingInfo.ForeColor = System.Drawing.Color.White
        Me.TrainingInfo.Location = New System.Drawing.Point(439, 0)
        Me.TrainingInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TrainingInfo.Name = "TrainingInfo"
        Me.TrainingInfo.Padding = New System.Windows.Forms.Padding(40, 16, 0, 0)
        Me.TrainingInfo.Size = New System.Drawing.Size(143, 65)
        Me.TrainingInfo.TabIndex = 3
        Me.TrainingInfo.Text = "教学"
        Me.TrainingInfo.UseCompatibleTextRendering = True
        '
        'GameInfo
        '
        Me.GameInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GameInfo.ForeColor = System.Drawing.Color.White
        Me.GameInfo.Location = New System.Drawing.Point(292, 0)
        Me.GameInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameInfo.Name = "GameInfo"
        Me.GameInfo.Padding = New System.Windows.Forms.Padding(40, 16, 0, 0)
        Me.GameInfo.Size = New System.Drawing.Size(143, 65)
        Me.GameInfo.TabIndex = 2
        Me.GameInfo.Text = "比赛"
        Me.GameInfo.UseCompatibleTextRendering = True
        '
        'FieldInfo
        '
        Me.FieldInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FieldInfo.ForeColor = System.Drawing.Color.White
        Me.FieldInfo.Location = New System.Drawing.Point(145, 0)
        Me.FieldInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FieldInfo.Name = "FieldInfo"
        Me.FieldInfo.Padding = New System.Windows.Forms.Padding(40, 16, 0, 0)
        Me.FieldInfo.Size = New System.Drawing.Size(143, 65)
        Me.FieldInfo.TabIndex = 1
        Me.FieldInfo.Text = "场地"
        Me.FieldInfo.UseCompatibleTextRendering = True
        '
        'StudentUIText
        '
        Me.StudentUIText.AutoSize = True
        Me.StudentUIText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StudentUIText.ForeColor = System.Drawing.Color.Navy
        Me.StudentUIText.Location = New System.Drawing.Point(0, 15)
        Me.StudentUIText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StudentUIText.Name = "StudentUIText"
        Me.StudentUIText.Size = New System.Drawing.Size(96, 32)
        Me.StudentUIText.TabIndex = 0
        Me.StudentUIText.Text = "学生专区"
        Me.StudentUIText.UseCompatibleTextRendering = True
        '
        'FieldPanel
        '
        Me.FieldPanel.Controls.Add(Me.FieldContainer)
        Me.FieldPanel.Location = New System.Drawing.Point(0, 0)
        Me.FieldPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.FieldPanel.Name = "FieldPanel"
        Me.FieldPanel.Size = New System.Drawing.Size(1153, 555)
        Me.FieldPanel.TabIndex = 0
        Me.FieldPanel.Visible = False
        '
        'FieldContainer
        '
        Me.FieldContainer.Location = New System.Drawing.Point(35, -1)
        Me.FieldContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.FieldContainer.Name = "FieldContainer"
        '
        'FieldContainer.Panel1
        '
        Me.FieldContainer.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FieldContainer.Panel1.Controls.Add(Me.MyField)
        Me.FieldContainer.Panel1.Controls.Add(Me.SearchField)
        Me.FieldContainer.Panel1MinSize = 100
        '
        'FieldContainer.Panel2
        '
        Me.FieldContainer.Panel2.Controls.Add(Me.SearchFieldPanel)
        Me.FieldContainer.Panel2.Controls.Add(Me.MyFieldPanel)
        Me.FieldContainer.Size = New System.Drawing.Size(1119, 556)
        Me.FieldContainer.SplitterDistance = 140
        Me.FieldContainer.SplitterWidth = 1
        Me.FieldContainer.TabIndex = 7
        '
        'MyField
        '
        Me.MyField.BackColor = System.Drawing.Color.AliceBlue
        Me.MyField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyField.Location = New System.Drawing.Point(0, 28)
        Me.MyField.Margin = New System.Windows.Forms.Padding(4)
        Me.MyField.Name = "MyField"
        Me.MyField.Size = New System.Drawing.Size(144, 29)
        Me.MyField.TabIndex = 8
        Me.MyField.Text = "我的场地"
        Me.MyField.UseVisualStyleBackColor = False
        '
        'SearchField
        '
        Me.SearchField.BackColor = System.Drawing.Color.AliceBlue
        Me.SearchField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchField.Location = New System.Drawing.Point(0, 0)
        Me.SearchField.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchField.Name = "SearchField"
        Me.SearchField.Size = New System.Drawing.Size(144, 29)
        Me.SearchField.TabIndex = 7
        Me.SearchField.Text = "查询场地"
        Me.SearchField.UseVisualStyleBackColor = False
        '
        'MyFieldPanel
        '
        Me.MyFieldPanel.Controls.Add(Me.ToShare)
        Me.MyFieldPanel.Controls.Add(Me.Paying)
        Me.MyFieldPanel.Controls.Add(Me.Unsubscribe)
        Me.MyFieldPanel.Controls.Add(Me.DataGridView2)
        Me.MyFieldPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyFieldPanel.Location = New System.Drawing.Point(0, 0)
        Me.MyFieldPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MyFieldPanel.Name = "MyFieldPanel"
        Me.MyFieldPanel.Size = New System.Drawing.Size(978, 556)
        Me.MyFieldPanel.TabIndex = 7
        '
        'ToShare
        '
        Me.ToShare.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToShare.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ToShare.Location = New System.Drawing.Point(677, 109)
        Me.ToShare.Margin = New System.Windows.Forms.Padding(4)
        Me.ToShare.Name = "ToShare"
        Me.ToShare.Size = New System.Drawing.Size(100, 29)
        Me.ToShare.TabIndex = 12
        Me.ToShare.Text = "发起拼场"
        Me.ToShare.UseVisualStyleBackColor = False
        '
        'Paying
        '
        Me.Paying.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Paying.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Paying.Location = New System.Drawing.Point(533, 109)
        Me.Paying.Margin = New System.Windows.Forms.Padding(4)
        Me.Paying.Name = "Paying"
        Me.Paying.Size = New System.Drawing.Size(100, 29)
        Me.Paying.TabIndex = 11
        Me.Paying.Text = "缴费"
        Me.Paying.UseVisualStyleBackColor = False
        '
        'Unsubscribe
        '
        Me.Unsubscribe.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Unsubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Unsubscribe.Location = New System.Drawing.Point(375, 109)
        Me.Unsubscribe.Margin = New System.Windows.Forms.Padding(4)
        Me.Unsubscribe.Name = "Unsubscribe"
        Me.Unsubscribe.Size = New System.Drawing.Size(100, 29)
        Me.Unsubscribe.TabIndex = 10
        Me.Unsubscribe.Text = "退订"
        Me.Unsubscribe.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(129, 216)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.Size = New System.Drawing.Size(724, 36)
        Me.DataGridView2.TabIndex = 0
        '
        'SearchFieldPanel
        '
        Me.SearchFieldPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SearchFieldPanel.Controls.Add(Me.searching)
        Me.SearchFieldPanel.Controls.Add(Me.Waiting)
        Me.SearchFieldPanel.Controls.Add(Me.Sharing)
        Me.SearchFieldPanel.Controls.Add(Me.Booking)
        Me.SearchFieldPanel.Controls.Add(Me.InputText1)
        Me.SearchFieldPanel.Controls.Add(Me.FieldInput)
        Me.SearchFieldPanel.Controls.Add(Me.DataGridView1)
        Me.SearchFieldPanel.Controls.Add(Me.OptionText2)
        Me.SearchFieldPanel.Controls.Add(Me.OptionText1)
        Me.SearchFieldPanel.Controls.Add(Me.SelectField)
        Me.SearchFieldPanel.Controls.Add(Me.ComboBox1)
        Me.SearchFieldPanel.Controls.Add(Me.DateTimePicker1)
        Me.SearchFieldPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchFieldPanel.Location = New System.Drawing.Point(0, 0)
        Me.SearchFieldPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchFieldPanel.Name = "SearchFieldPanel"
        Me.SearchFieldPanel.Size = New System.Drawing.Size(978, 556)
        Me.SearchFieldPanel.TabIndex = 8
        '
        'searching
        '
        Me.searching.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.searching.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searching.Location = New System.Drawing.Point(492, 116)
        Me.searching.Margin = New System.Windows.Forms.Padding(4)
        Me.searching.Name = "searching"
        Me.searching.Size = New System.Drawing.Size(100, 29)
        Me.searching.TabIndex = 12
        Me.searching.Text = "查询"
        Me.searching.UseVisualStyleBackColor = False
        '
        'Waiting
        '
        Me.Waiting.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Waiting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Waiting.Location = New System.Drawing.Point(813, 116)
        Me.Waiting.Margin = New System.Windows.Forms.Padding(4)
        Me.Waiting.Name = "Waiting"
        Me.Waiting.Size = New System.Drawing.Size(100, 29)
        Me.Waiting.TabIndex = 11
        Me.Waiting.Text = "等待"
        Me.Waiting.UseVisualStyleBackColor = False
        '
        'Sharing
        '
        Me.Sharing.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Sharing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sharing.Location = New System.Drawing.Point(707, 116)
        Me.Sharing.Margin = New System.Windows.Forms.Padding(4)
        Me.Sharing.Name = "Sharing"
        Me.Sharing.Size = New System.Drawing.Size(100, 29)
        Me.Sharing.TabIndex = 10
        Me.Sharing.Text = "拼场"
        Me.Sharing.UseVisualStyleBackColor = False
        '
        'Booking
        '
        Me.Booking.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Booking.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Booking.Location = New System.Drawing.Point(600, 116)
        Me.Booking.Margin = New System.Windows.Forms.Padding(4)
        Me.Booking.Name = "Booking"
        Me.Booking.Size = New System.Drawing.Size(100, 29)
        Me.Booking.TabIndex = 9
        Me.Booking.Text = "预约"
        Me.Booking.UseVisualStyleBackColor = False
        '
        'InputText1
        '
        Me.InputText1.AutoSize = True
        Me.InputText1.Location = New System.Drawing.Point(39, 116)
        Me.InputText1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InputText1.Name = "InputText1"
        Me.InputText1.Size = New System.Drawing.Size(82, 15)
        Me.InputText1.TabIndex = 8
        Me.InputText1.Text = "场地编号："
        '
        'FieldInput
        '
        Me.FieldInput.Location = New System.Drawing.Point(134, 113)
        Me.FieldInput.Margin = New System.Windows.Forms.Padding(4)
        Me.FieldInput.Name = "FieldInput"
        Me.FieldInput.Size = New System.Drawing.Size(132, 25)
        Me.FieldInput.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 184)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(884, 320)
        Me.DataGridView1.TabIndex = 6
        '
        'OptionText2
        '
        Me.OptionText2.AutoSize = True
        Me.OptionText2.Location = New System.Drawing.Point(504, 31)
        Me.OptionText2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OptionText2.Name = "OptionText2"
        Me.OptionText2.Size = New System.Drawing.Size(82, 15)
        Me.OptionText2.TabIndex = 5
        Me.OptionText2.Text = "场馆时间："
        '
        'OptionText1
        '
        Me.OptionText1.AutoSize = True
        Me.OptionText1.Location = New System.Drawing.Point(127, 34)
        Me.OptionText1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OptionText1.Name = "OptionText1"
        Me.OptionText1.Size = New System.Drawing.Size(82, 15)
        Me.OptionText1.TabIndex = 4
        Me.OptionText1.Text = "场馆分类："
        '
        'SelectField
        '
        Me.SelectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectField.FormattingEnabled = True
        Me.SelectField.Items.AddRange(New Object() {"篮球场", "排球场", "羽毛球场", "乒乓球场", "网球场", "棒垒球场", "游泳馆", "健身房"})
        Me.SelectField.Location = New System.Drawing.Point(221, 28)
        Me.SelectField.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectField.Name = "SelectField"
        Me.SelectField.Size = New System.Drawing.Size(100, 23)
        Me.SelectField.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"08:00-09:00", "09:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00", "13:00-14:00", "14:00-15:00", "15:00-16:00", "16:00-17:00", "17:00-18:00", "18:00-19:00", "19:00-20:00", "20:00-21:00", "21:00-22:00"})
        Me.ComboBox1.Location = New System.Drawing.Point(784, 26)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(132, 23)
        Me.ComboBox1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(599, 26)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(156, 25)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2020, 11, 30, 0, 0, 0, 0)
        '
        'MessagePanel
        '
        Me.MessagePanel.Controls.Add(Me.MessageContainer)
        Me.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagePanel.Location = New System.Drawing.Point(0, 0)
        Me.MessagePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MessagePanel.Name = "MessagePanel"
        Me.MessagePanel.Size = New System.Drawing.Size(1153, 568)
        Me.MessagePanel.TabIndex = 4
        Me.MessagePanel.Visible = False
        '
        'MessageContainer
        '
        Me.MessageContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.MessageContainer.IsSplitterFixed = True
        Me.MessageContainer.Location = New System.Drawing.Point(91, -1)
        Me.MessageContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.MessageContainer.Name = "MessageContainer"
        '
        'MessageContainer.Panel1
        '
        Me.MessageContainer.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MessageContainer.Panel1.Controls.Add(Me.Report)
        Me.MessageContainer.Panel1.Controls.Add(Me.GeneralMessage)
        '
        'MessageContainer.Panel2
        '
        Me.MessageContainer.Panel2.Controls.Add(Me.MessageGeneralPanel)
        Me.MessageContainer.Panel2.Controls.Add(Me.MessageReportPanel)
        Me.MessageContainer.Size = New System.Drawing.Size(1063, 556)
        Me.MessageContainer.SplitterDistance = 108
        Me.MessageContainer.SplitterWidth = 1
        Me.MessageContainer.TabIndex = 4
        '
        'Report
        '
        Me.Report.BackColor = System.Drawing.Color.AliceBlue
        Me.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Report.Location = New System.Drawing.Point(0, 25)
        Me.Report.Margin = New System.Windows.Forms.Padding(4)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(144, 29)
        Me.Report.TabIndex = 10
        Me.Report.Text = "查看报表"
        Me.Report.UseVisualStyleBackColor = False
        '
        'GeneralMessage
        '
        Me.GeneralMessage.BackColor = System.Drawing.Color.AliceBlue
        Me.GeneralMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GeneralMessage.Location = New System.Drawing.Point(0, 0)
        Me.GeneralMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.GeneralMessage.Name = "GeneralMessage"
        Me.GeneralMessage.Size = New System.Drawing.Size(144, 29)
        Me.GeneralMessage.TabIndex = 9
        Me.GeneralMessage.Text = "查看消息"
        Me.GeneralMessage.UseVisualStyleBackColor = False
        '
        'MessageGeneralPanel
        '
        Me.MessageGeneralPanel.Controls.Add(Me.ListView1)
        Me.MessageGeneralPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageGeneralPanel.Location = New System.Drawing.Point(0, 0)
        Me.MessageGeneralPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MessageGeneralPanel.Name = "MessageGeneralPanel"
        Me.MessageGeneralPanel.Size = New System.Drawing.Size(954, 556)
        Me.MessageGeneralPanel.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup2"
        ListViewGroup3.Header = "ListViewGroup"
        ListViewGroup3.Name = "ListViewGroup3"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(954, 556)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ddd"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ddd"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ddd"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ddd"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ddd"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ddd"
        '
        'MessageReportPanel
        '
        Me.MessageReportPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageReportPanel.Location = New System.Drawing.Point(0, 0)
        Me.MessageReportPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MessageReportPanel.Name = "MessageReportPanel"
        Me.MessageReportPanel.Size = New System.Drawing.Size(954, 556)
        Me.MessageReportPanel.TabIndex = 5
        '
        'FeedbackPanel
        '
        Me.FeedbackPanel.Controls.Add(Me.FeedbackContainer)
        Me.FeedbackPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FeedbackPanel.Location = New System.Drawing.Point(0, 0)
        Me.FeedbackPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.FeedbackPanel.Name = "FeedbackPanel"
        Me.FeedbackPanel.Size = New System.Drawing.Size(1153, 568)
        Me.FeedbackPanel.TabIndex = 3
        Me.FeedbackPanel.Visible = False
        '
        'FeedbackContainer
        '
        Me.FeedbackContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.FeedbackContainer.IsSplitterFixed = True
        Me.FeedbackContainer.Location = New System.Drawing.Point(73, -1)
        Me.FeedbackContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.FeedbackContainer.Name = "FeedbackContainer"
        '
        'FeedbackContainer.Panel1
        '
        Me.FeedbackContainer.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FeedbackContainer.Panel1.Controls.Add(Me.Maintenace)
        Me.FeedbackContainer.Panel1.Controls.Add(Me.Problem)
        '
        'FeedbackContainer.Panel2
        '
        Me.FeedbackContainer.Panel2.Controls.Add(Me.ProblemPanel)
        Me.FeedbackContainer.Panel2.Controls.Add(Me.MaintenancePanel)
        Me.FeedbackContainer.Size = New System.Drawing.Size(1080, 556)
        Me.FeedbackContainer.SplitterDistance = 109
        Me.FeedbackContainer.SplitterWidth = 1
        Me.FeedbackContainer.TabIndex = 1
        '
        'Maintenace
        '
        Me.Maintenace.BackColor = System.Drawing.Color.AliceBlue
        Me.Maintenace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maintenace.Location = New System.Drawing.Point(0, 26)
        Me.Maintenace.Margin = New System.Windows.Forms.Padding(4)
        Me.Maintenace.Name = "Maintenace"
        Me.Maintenace.Size = New System.Drawing.Size(144, 29)
        Me.Maintenace.TabIndex = 10
        Me.Maintenace.Text = "故障报修"
        Me.Maintenace.UseVisualStyleBackColor = False
        '
        'Problem
        '
        Me.Problem.BackColor = System.Drawing.Color.AliceBlue
        Me.Problem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Problem.Location = New System.Drawing.Point(0, 0)
        Me.Problem.Margin = New System.Windows.Forms.Padding(4)
        Me.Problem.Name = "Problem"
        Me.Problem.Size = New System.Drawing.Size(144, 29)
        Me.Problem.TabIndex = 9
        Me.Problem.Text = "问题反馈"
        Me.Problem.UseVisualStyleBackColor = False
        '
        'ProblemPanel
        '
        Me.ProblemPanel.Controls.Add(Me.ProblemSubmit)
        Me.ProblemPanel.Controls.Add(Me.ProblemDescribe)
        Me.ProblemPanel.Controls.Add(Me.SelectProblemType)
        Me.ProblemPanel.Controls.Add(Me.GymNOInput)
        Me.ProblemPanel.Controls.Add(Me.ProblemLabel1)
        Me.ProblemPanel.Controls.Add(Me.ProblemLabel2)
        Me.ProblemPanel.Controls.Add(Me.ProblemLabel3)
        Me.ProblemPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProblemPanel.Location = New System.Drawing.Point(0, 0)
        Me.ProblemPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ProblemPanel.Name = "ProblemPanel"
        Me.ProblemPanel.Size = New System.Drawing.Size(970, 556)
        Me.ProblemPanel.TabIndex = 0
        '
        'ProblemSubmit
        '
        Me.ProblemSubmit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProblemSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProblemSubmit.Location = New System.Drawing.Point(440, 412)
        Me.ProblemSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.ProblemSubmit.Name = "ProblemSubmit"
        Me.ProblemSubmit.Size = New System.Drawing.Size(100, 29)
        Me.ProblemSubmit.TabIndex = 12
        Me.ProblemSubmit.Text = "提交"
        Me.ProblemSubmit.UseVisualStyleBackColor = False
        '
        'ProblemDescribe
        '
        Me.ProblemDescribe.Location = New System.Drawing.Point(255, 180)
        Me.ProblemDescribe.Margin = New System.Windows.Forms.Padding(4)
        Me.ProblemDescribe.Name = "ProblemDescribe"
        Me.ProblemDescribe.Size = New System.Drawing.Size(532, 189)
        Me.ProblemDescribe.TabIndex = 2
        Me.ProblemDescribe.Text = ""
        '
        'SelectProblemType
        '
        Me.SelectProblemType.FormattingEnabled = True
        Me.SelectProblemType.Location = New System.Drawing.Point(536, 71)
        Me.SelectProblemType.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectProblemType.Name = "SelectProblemType"
        Me.SelectProblemType.Size = New System.Drawing.Size(160, 23)
        Me.SelectProblemType.TabIndex = 1
        '
        'GymNOInput
        '
        Me.GymNOInput.Location = New System.Drawing.Point(255, 71)
        Me.GymNOInput.Margin = New System.Windows.Forms.Padding(4)
        Me.GymNOInput.Name = "GymNOInput"
        Me.GymNOInput.Size = New System.Drawing.Size(132, 25)
        Me.GymNOInput.TabIndex = 0
        '
        'ProblemLabel1
        '
        Me.ProblemLabel1.AutoSize = True
        Me.ProblemLabel1.Location = New System.Drawing.Point(173, 75)
        Me.ProblemLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProblemLabel1.Name = "ProblemLabel1"
        Me.ProblemLabel1.Size = New System.Drawing.Size(82, 15)
        Me.ProblemLabel1.TabIndex = 13
        Me.ProblemLabel1.Text = "场馆编号："
        '
        'ProblemLabel2
        '
        Me.ProblemLabel2.AutoSize = True
        Me.ProblemLabel2.Location = New System.Drawing.Point(460, 75)
        Me.ProblemLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProblemLabel2.Name = "ProblemLabel2"
        Me.ProblemLabel2.Size = New System.Drawing.Size(82, 15)
        Me.ProblemLabel2.TabIndex = 14
        Me.ProblemLabel2.Text = "问题类型："
        '
        'ProblemLabel3
        '
        Me.ProblemLabel3.AutoSize = True
        Me.ProblemLabel3.Location = New System.Drawing.Point(176, 184)
        Me.ProblemLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProblemLabel3.Name = "ProblemLabel3"
        Me.ProblemLabel3.Size = New System.Drawing.Size(82, 15)
        Me.ProblemLabel3.TabIndex = 15
        Me.ProblemLabel3.Text = "问题描述："
        '
        'MaintenancePanel
        '
        Me.MaintenancePanel.Controls.Add(Me.MaintenanceSubmit)
        Me.MaintenancePanel.Controls.Add(Me.MaintenanceDescribe)
        Me.MaintenancePanel.Controls.Add(Me.SelectMaintenanceType)
        Me.MaintenancePanel.Controls.Add(Me.MaintenanceInput)
        Me.MaintenancePanel.Controls.Add(Me.MaintenanceLabel1)
        Me.MaintenancePanel.Controls.Add(Me.MaintenanceLabel2)
        Me.MaintenancePanel.Controls.Add(Me.MaintenanceLabel3)
        Me.MaintenancePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaintenancePanel.Location = New System.Drawing.Point(0, 0)
        Me.MaintenancePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenancePanel.Name = "MaintenancePanel"
        Me.MaintenancePanel.Size = New System.Drawing.Size(970, 556)
        Me.MaintenancePanel.TabIndex = 1
        '
        'MaintenanceSubmit
        '
        Me.MaintenanceSubmit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MaintenanceSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaintenanceSubmit.Location = New System.Drawing.Point(440, 412)
        Me.MaintenanceSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenanceSubmit.Name = "MaintenanceSubmit"
        Me.MaintenanceSubmit.Size = New System.Drawing.Size(100, 29)
        Me.MaintenanceSubmit.TabIndex = 26
        Me.MaintenanceSubmit.Text = "提交"
        Me.MaintenanceSubmit.UseVisualStyleBackColor = False
        '
        'MaintenanceDescribe
        '
        Me.MaintenanceDescribe.Location = New System.Drawing.Point(255, 180)
        Me.MaintenanceDescribe.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenanceDescribe.Name = "MaintenanceDescribe"
        Me.MaintenanceDescribe.Size = New System.Drawing.Size(532, 189)
        Me.MaintenanceDescribe.TabIndex = 25
        Me.MaintenanceDescribe.Text = ""
        '
        'SelectMaintenanceType
        '
        Me.SelectMaintenanceType.FormattingEnabled = True
        Me.SelectMaintenanceType.Location = New System.Drawing.Point(536, 71)
        Me.SelectMaintenanceType.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectMaintenanceType.Name = "SelectMaintenanceType"
        Me.SelectMaintenanceType.Size = New System.Drawing.Size(160, 23)
        Me.SelectMaintenanceType.TabIndex = 24
        '
        'MaintenanceInput
        '
        Me.MaintenanceInput.Location = New System.Drawing.Point(255, 71)
        Me.MaintenanceInput.Margin = New System.Windows.Forms.Padding(4)
        Me.MaintenanceInput.Name = "MaintenanceInput"
        Me.MaintenanceInput.Size = New System.Drawing.Size(132, 25)
        Me.MaintenanceInput.TabIndex = 23
        '
        'MaintenanceLabel1
        '
        Me.MaintenanceLabel1.AutoSize = True
        Me.MaintenanceLabel1.Location = New System.Drawing.Point(173, 75)
        Me.MaintenanceLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaintenanceLabel1.Name = "MaintenanceLabel1"
        Me.MaintenanceLabel1.Size = New System.Drawing.Size(82, 15)
        Me.MaintenanceLabel1.TabIndex = 27
        Me.MaintenanceLabel1.Text = "场馆编号："
        '
        'MaintenanceLabel2
        '
        Me.MaintenanceLabel2.AutoSize = True
        Me.MaintenanceLabel2.Location = New System.Drawing.Point(460, 75)
        Me.MaintenanceLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaintenanceLabel2.Name = "MaintenanceLabel2"
        Me.MaintenanceLabel2.Size = New System.Drawing.Size(82, 15)
        Me.MaintenanceLabel2.TabIndex = 28
        Me.MaintenanceLabel2.Text = "故障类型："
        '
        'MaintenanceLabel3
        '
        Me.MaintenanceLabel3.AutoSize = True
        Me.MaintenanceLabel3.Location = New System.Drawing.Point(176, 184)
        Me.MaintenanceLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaintenanceLabel3.Name = "MaintenanceLabel3"
        Me.MaintenanceLabel3.Size = New System.Drawing.Size(82, 15)
        Me.MaintenanceLabel3.TabIndex = 29
        Me.MaintenanceLabel3.Text = "故障描述："
        '
        'TrainingPanel
        '
        Me.TrainingPanel.Controls.Add(Me.TrainingApplying)
        Me.TrainingPanel.Controls.Add(Me.SelectLesson)
        Me.TrainingPanel.Controls.Add(Me.DataGridView5)
        Me.TrainingPanel.Controls.Add(Me.TrainingLabel1)
        Me.TrainingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrainingPanel.Location = New System.Drawing.Point(0, 0)
        Me.TrainingPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TrainingPanel.Name = "TrainingPanel"
        Me.TrainingPanel.Size = New System.Drawing.Size(1153, 568)
        Me.TrainingPanel.TabIndex = 2
        Me.TrainingPanel.Visible = False
        '
        'TrainingApplying
        '
        Me.TrainingApplying.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TrainingApplying.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TrainingApplying.Location = New System.Drawing.Point(653, 56)
        Me.TrainingApplying.Margin = New System.Windows.Forms.Padding(4)
        Me.TrainingApplying.Name = "TrainingApplying"
        Me.TrainingApplying.Size = New System.Drawing.Size(127, 29)
        Me.TrainingApplying.TabIndex = 12
        Me.TrainingApplying.Text = "申请教学"
        Me.TrainingApplying.UseVisualStyleBackColor = False
        '
        'SelectLesson
        '
        Me.SelectLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectLesson.FormattingEnabled = True
        Me.SelectLesson.Items.AddRange(New Object() {"篮球", "排球", "羽毛球", "乒乓球", "棒垒球", "网球"})
        Me.SelectLesson.Location = New System.Drawing.Point(459, 59)
        Me.SelectLesson.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectLesson.Name = "SelectLesson"
        Me.SelectLesson.Size = New System.Drawing.Size(160, 23)
        Me.SelectLesson.TabIndex = 2
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(292, 184)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowTemplate.Height = 23
        Me.DataGridView5.Size = New System.Drawing.Size(552, 250)
        Me.DataGridView5.TabIndex = 1
        '
        'TrainingLabel1
        '
        Me.TrainingLabel1.AutoSize = True
        Me.TrainingLabel1.Location = New System.Drawing.Point(332, 62)
        Me.TrainingLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TrainingLabel1.Name = "TrainingLabel1"
        Me.TrainingLabel1.Size = New System.Drawing.Size(112, 15)
        Me.TrainingLabel1.TabIndex = 0
        Me.TrainingLabel1.Text = "选择体育项目："
        '
        'GamePanel
        '
        Me.GamePanel.Controls.Add(Me.JoinGame)
        Me.GamePanel.Controls.Add(Me.GameLabel3)
        Me.GamePanel.Controls.Add(Me.GameLabel2)
        Me.GamePanel.Controls.Add(Me.DataGridView4)
        Me.GamePanel.Controls.Add(Me.DataGridView3)
        Me.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GamePanel.Location = New System.Drawing.Point(0, 0)
        Me.GamePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(1153, 568)
        Me.GamePanel.TabIndex = 1
        Me.GamePanel.Visible = False
        '
        'JoinGame
        '
        Me.JoinGame.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.JoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.JoinGame.Location = New System.Drawing.Point(971, 148)
        Me.JoinGame.Margin = New System.Windows.Forms.Padding(4)
        Me.JoinGame.Name = "JoinGame"
        Me.JoinGame.Size = New System.Drawing.Size(100, 29)
        Me.JoinGame.TabIndex = 12
        Me.JoinGame.Text = "报名比赛"
        Me.JoinGame.UseVisualStyleBackColor = False
        '
        'GameLabel3
        '
        Me.GameLabel3.AutoSize = True
        Me.GameLabel3.Location = New System.Drawing.Point(71, 328)
        Me.GameLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameLabel3.Name = "GameLabel3"
        Me.GameLabel3.Size = New System.Drawing.Size(67, 15)
        Me.GameLabel3.TabIndex = 5
        Me.GameLabel3.Text = "我的比赛"
        '
        'GameLabel2
        '
        Me.GameLabel2.AutoSize = True
        Me.GameLabel2.Location = New System.Drawing.Point(48, 81)
        Me.GameLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameLabel2.Name = "GameLabel2"
        Me.GameLabel2.Size = New System.Drawing.Size(67, 15)
        Me.GameLabel2.TabIndex = 4
        Me.GameLabel2.Text = "比赛信息"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(209, 328)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowTemplate.Height = 23
        Me.DataGridView4.Size = New System.Drawing.Size(820, 188)
        Me.DataGridView4.TabIndex = 3
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(209, 81)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 23
        Me.DataGridView3.Size = New System.Drawing.Size(688, 188)
        Me.DataGridView3.TabIndex = 1
        '
        'Student_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1153, 625)
        Me.Controls.Add(Me.Root)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(994, 613)
        Me.Name = "Student_UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "student_UI"
        Me.Root.Panel1.ResumeLayout(False)
        Me.Root.Panel1.PerformLayout()
        Me.Root.Panel2.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Root.ResumeLayout(False)
        Me.FieldPanel.ResumeLayout(False)
        Me.FieldContainer.Panel1.ResumeLayout(False)
        Me.FieldContainer.Panel2.ResumeLayout(False)
        CType(Me.FieldContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FieldContainer.ResumeLayout(False)
        Me.MyFieldPanel.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchFieldPanel.ResumeLayout(False)
        Me.SearchFieldPanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessagePanel.ResumeLayout(False)
        Me.MessageContainer.Panel1.ResumeLayout(False)
        Me.MessageContainer.Panel2.ResumeLayout(False)
        CType(Me.MessageContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessageContainer.ResumeLayout(False)
        Me.MessageGeneralPanel.ResumeLayout(False)
        Me.FeedbackPanel.ResumeLayout(False)
        Me.FeedbackContainer.Panel1.ResumeLayout(False)
        Me.FeedbackContainer.Panel2.ResumeLayout(False)
        CType(Me.FeedbackContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FeedbackContainer.ResumeLayout(False)
        Me.ProblemPanel.ResumeLayout(False)
        Me.ProblemPanel.PerformLayout()
        Me.MaintenancePanel.ResumeLayout(False)
        Me.MaintenancePanel.PerformLayout()
        Me.TrainingPanel.ResumeLayout(False)
        Me.TrainingPanel.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Root As Windows.Forms.SplitContainer
    Public WithEvents StudentUIText As Windows.Forms.Label
    Friend WithEvents UserName As Windows.Forms.Label
    Friend WithEvents WelcomeText As Windows.Forms.Label
    Public WithEvents TrainingInfo As Windows.Forms.Label
    Public WithEvents GameInfo As Windows.Forms.Label
    Public WithEvents FieldInfo As Windows.Forms.Label
    Public WithEvents Message As Windows.Forms.Label
    Friend WithEvents LogoutLink As Windows.Forms.LinkLabel
    Public WithEvents Feedback As Windows.Forms.Label
    Friend WithEvents HomepageLink As Windows.Forms.LinkLabel
    Friend WithEvents MessagePanel As Windows.Forms.Panel
    Friend WithEvents FeedbackPanel As Windows.Forms.Panel
    Friend WithEvents TrainingPanel As Windows.Forms.Panel
    Friend WithEvents GamePanel As Windows.Forms.Panel
    Friend WithEvents FieldPanel As Windows.Forms.Panel
    Friend WithEvents TrainingLabel1 As Windows.Forms.Label
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
    Friend WithEvents OptionText2 As Windows.Forms.Label
    Friend WithEvents OptionText1 As Windows.Forms.Label
    Friend WithEvents SelectField As Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents FieldContainer As Windows.Forms.SplitContainer
    Friend WithEvents SearchField As Windows.Forms.Button
    Friend WithEvents MyField As Windows.Forms.Button
    Friend WithEvents SearchFieldPanel As Windows.Forms.Panel
    Friend WithEvents Sharing As Windows.Forms.Button
    Friend WithEvents Booking As Windows.Forms.Button
    Friend WithEvents InputText1 As Windows.Forms.Label
    Friend WithEvents FieldInput As Windows.Forms.TextBox
    Friend WithEvents MyFieldPanel As Windows.Forms.Panel
    Friend WithEvents DataGridView2 As Windows.Forms.DataGridView
    Friend WithEvents Waiting As Windows.Forms.Button
    Friend WithEvents ToShare As Windows.Forms.Button
    Friend WithEvents Paying As Windows.Forms.Button
    Friend WithEvents Unsubscribe As Windows.Forms.Button
    Friend WithEvents DataGridView3 As Windows.Forms.DataGridView
    Friend WithEvents JoinGame As Windows.Forms.Button
    Friend WithEvents GameLabel3 As Windows.Forms.Label
    Friend WithEvents GameLabel2 As Windows.Forms.Label
    Friend WithEvents DataGridView4 As Windows.Forms.DataGridView
    Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As Windows.Forms.ColumnHeader
    Friend WithEvents FeedbackContainer As Windows.Forms.SplitContainer
    Friend WithEvents Maintenace As Windows.Forms.Button
    Friend WithEvents Problem As Windows.Forms.Button
    Friend WithEvents MaintenancePanel As Windows.Forms.Panel
    Friend WithEvents ProblemPanel As Windows.Forms.Panel
    Friend WithEvents SelectLesson As Windows.Forms.ComboBox
    Friend WithEvents DataGridView5 As Windows.Forms.DataGridView
    Friend WithEvents TrainingApplying As Windows.Forms.Button
    Friend WithEvents MessageContainer As Windows.Forms.SplitContainer
    Friend WithEvents Report As Windows.Forms.Button
    Friend WithEvents GeneralMessage As Windows.Forms.Button
    Friend WithEvents MessageGeneralPanel As Windows.Forms.Panel
    Friend WithEvents MessageReportPanel As Windows.Forms.Panel
    Friend WithEvents ProblemLabel1 As Windows.Forms.Label
    Friend WithEvents ProblemSubmit As Windows.Forms.Button
    Friend WithEvents ProblemDescribe As Windows.Forms.RichTextBox
    Friend WithEvents SelectProblemType As Windows.Forms.ComboBox
    Friend WithEvents GymNOInput As Windows.Forms.TextBox
    Friend WithEvents MaintenanceSubmit As Windows.Forms.Button
    Friend WithEvents MaintenanceDescribe As Windows.Forms.RichTextBox
    Friend WithEvents SelectMaintenanceType As Windows.Forms.ComboBox
    Friend WithEvents MaintenanceInput As Windows.Forms.TextBox
    Friend WithEvents MaintenanceLabel1 As Windows.Forms.Label
    Friend WithEvents MaintenanceLabel2 As Windows.Forms.Label
    Friend WithEvents MaintenanceLabel3 As Windows.Forms.Label
    Friend WithEvents ProblemLabel2 As Windows.Forms.Label
    Friend WithEvents ProblemLabel3 As Windows.Forms.Label
    Friend WithEvents searching As Windows.Forms.Button
End Class
