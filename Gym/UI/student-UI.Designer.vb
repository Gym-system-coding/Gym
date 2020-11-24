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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student_UI))
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
        Me.OptionText2 = New System.Windows.Forms.Label()
        Me.OptionText1 = New System.Windows.Forms.Label()
        Me.SelectField = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MessagePanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FeedbackPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrainingPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FieldContainer = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Field_MyinfoPanel = New System.Windows.Forms.Panel()
        Me.Field_SearchPanel = New System.Windows.Forms.Panel()
        Me.FieldNOInput = New System.Windows.Forms.TextBox()
        Me.InputText1 = New System.Windows.Forms.Label()
        Me.Booking = New System.Windows.Forms.Button()
        Me.Sharing = New System.Windows.Forms.Button()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Root.Panel1.SuspendLayout()
        Me.Root.Panel2.SuspendLayout()
        Me.Root.SuspendLayout()
        Me.FieldPanel.SuspendLayout()
        Me.MessagePanel.SuspendLayout()
        Me.FeedbackPanel.SuspendLayout()
        Me.TrainingPanel.SuspendLayout()
        Me.GamePanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FieldContainer.Panel1.SuspendLayout()
        Me.FieldContainer.Panel2.SuspendLayout()
        Me.FieldContainer.SuspendLayout()
        Me.Field_SearchPanel.SuspendLayout()
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
        Me.Root.Panel2.Controls.Add(Me.MessagePanel)
        Me.Root.Panel2.Controls.Add(Me.FeedbackPanel)
        Me.Root.Panel2.Controls.Add(Me.TrainingPanel)
        Me.Root.Panel2.Controls.Add(Me.GamePanel)
        Me.Root.Panel2.Controls.Add(Me.FieldPanel)
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
        'Feedback
        '
        Me.Feedback.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Feedback.ForeColor = System.Drawing.Color.White
        Me.Feedback.Location = New System.Drawing.Point(439, 0)
        Me.Feedback.Name = "Feedback"
        Me.Feedback.Padding = New System.Windows.Forms.Padding(30, 13, 0, 0)
        Me.Feedback.Size = New System.Drawing.Size(107, 52)
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
        Me.LogoutLink.Location = New System.Drawing.Point(823, 25)
        Me.LogoutLink.Name = "LogoutLink"
        Me.LogoutLink.Size = New System.Drawing.Size(42, 22)
        Me.LogoutLink.TabIndex = 7
        Me.LogoutLink.TabStop = True
        Me.LogoutLink.Text = "退出"
        '
        'Message
        '
        Me.Message.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Message.ForeColor = System.Drawing.Color.White
        Me.Message.Location = New System.Drawing.Point(549, 0)
        Me.Message.Name = "Message"
        Me.Message.Padding = New System.Windows.Forms.Padding(30, 13, 0, 0)
        Me.Message.Size = New System.Drawing.Size(107, 52)
        Me.Message.TabIndex = 6
        Me.Message.Text = "通知"
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
        'TrainingInfo
        '
        Me.TrainingInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TrainingInfo.ForeColor = System.Drawing.Color.White
        Me.TrainingInfo.Location = New System.Drawing.Point(329, 0)
        Me.TrainingInfo.Name = "TrainingInfo"
        Me.TrainingInfo.Padding = New System.Windows.Forms.Padding(30, 13, 0, 0)
        Me.TrainingInfo.Size = New System.Drawing.Size(107, 52)
        Me.TrainingInfo.TabIndex = 3
        Me.TrainingInfo.Text = "培训"
        Me.TrainingInfo.UseCompatibleTextRendering = True
        '
        'GameInfo
        '
        Me.GameInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GameInfo.ForeColor = System.Drawing.Color.White
        Me.GameInfo.Location = New System.Drawing.Point(219, 0)
        Me.GameInfo.Name = "GameInfo"
        Me.GameInfo.Padding = New System.Windows.Forms.Padding(30, 13, 0, 0)
        Me.GameInfo.Size = New System.Drawing.Size(107, 52)
        Me.GameInfo.TabIndex = 2
        Me.GameInfo.Text = "比赛"
        Me.GameInfo.UseCompatibleTextRendering = True
        '
        'FieldInfo
        '
        Me.FieldInfo.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FieldInfo.ForeColor = System.Drawing.Color.White
        Me.FieldInfo.Location = New System.Drawing.Point(109, 0)
        Me.FieldInfo.Name = "FieldInfo"
        Me.FieldInfo.Padding = New System.Windows.Forms.Padding(30, 13, 0, 0)
        Me.FieldInfo.Size = New System.Drawing.Size(107, 52)
        Me.FieldInfo.TabIndex = 1
        Me.FieldInfo.Text = "场地"
        Me.FieldInfo.UseCompatibleTextRendering = True
        '
        'StudentUIText
        '
        Me.StudentUIText.AutoSize = True
        Me.StudentUIText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StudentUIText.ForeColor = System.Drawing.Color.Navy
        Me.StudentUIText.Location = New System.Drawing.Point(0, 12)
        Me.StudentUIText.Name = "StudentUIText"
        Me.StudentUIText.Size = New System.Drawing.Size(77, 27)
        Me.StudentUIText.TabIndex = 0
        Me.StudentUIText.Text = "学生专区"
        Me.StudentUIText.UseCompatibleTextRendering = True
        '
        'FieldPanel
        '
        Me.FieldPanel.Controls.Add(Me.FieldContainer)
        Me.FieldPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldPanel.Location = New System.Drawing.Point(0, 0)
        Me.FieldPanel.Name = "FieldPanel"
        Me.FieldPanel.Size = New System.Drawing.Size(865, 444)
        Me.FieldPanel.TabIndex = 0
        Me.FieldPanel.Visible = False
        '
        'OptionText2
        '
        Me.OptionText2.AutoSize = True
        Me.OptionText2.Location = New System.Drawing.Point(378, 25)
        Me.OptionText2.Name = "OptionText2"
        Me.OptionText2.Size = New System.Drawing.Size(65, 12)
        Me.OptionText2.TabIndex = 5
        Me.OptionText2.Text = "场馆时间："
        '
        'OptionText1
        '
        Me.OptionText1.AutoSize = True
        Me.OptionText1.Location = New System.Drawing.Point(95, 27)
        Me.OptionText1.Name = "OptionText1"
        Me.OptionText1.Size = New System.Drawing.Size(65, 12)
        Me.OptionText1.TabIndex = 4
        Me.OptionText1.Text = "场馆分类："
        '
        'SelectField
        '
        Me.SelectField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectField.FormattingEnabled = True
        Me.SelectField.Items.AddRange(New Object() {"篮球场", "排球场", "羽毛球场", "乒乓球场", "网球场", "棒垒球场", "游泳馆", "健身房"})
        Me.SelectField.Location = New System.Drawing.Point(166, 22)
        Me.SelectField.Name = "SelectField"
        Me.SelectField.Size = New System.Drawing.Size(76, 20)
        Me.SelectField.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"8:00-9:00", "9:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00", "13:00-14:00", "14:00-15:00", "15:00-16:00", "16:00-17:00", "17:00-18:00", "18:00-19:00", "19:00-20:00", "20:00-21:00", "21:00-22:00"})
        Me.ComboBox1.Location = New System.Drawing.Point(588, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox1.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(449, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 21)
        Me.DateTimePicker1.TabIndex = 1
        '
        'MessagePanel
        '
        Me.MessagePanel.Controls.Add(Me.Label5)
        Me.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagePanel.Location = New System.Drawing.Point(0, 0)
        Me.MessagePanel.Name = "MessagePanel"
        Me.MessagePanel.Size = New System.Drawing.Size(865, 444)
        Me.MessagePanel.TabIndex = 4
        Me.MessagePanel.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "MessagePanel"
        '
        'FeedbackPanel
        '
        Me.FeedbackPanel.Controls.Add(Me.Label4)
        Me.FeedbackPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FeedbackPanel.Location = New System.Drawing.Point(0, 0)
        Me.FeedbackPanel.Name = "FeedbackPanel"
        Me.FeedbackPanel.Size = New System.Drawing.Size(865, 444)
        Me.FeedbackPanel.TabIndex = 3
        Me.FeedbackPanel.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "FeedbackPanel"
        '
        'TrainingPanel
        '
        Me.TrainingPanel.Controls.Add(Me.Label3)
        Me.TrainingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrainingPanel.Location = New System.Drawing.Point(0, 0)
        Me.TrainingPanel.Name = "TrainingPanel"
        Me.TrainingPanel.Size = New System.Drawing.Size(865, 444)
        Me.TrainingPanel.TabIndex = 2
        Me.TrainingPanel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TrainingPanel"
        '
        'GamePanel
        '
        Me.GamePanel.Controls.Add(Me.Label1)
        Me.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GamePanel.Location = New System.Drawing.Point(0, 0)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(865, 444)
        Me.GamePanel.TabIndex = 1
        Me.GamePanel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GamePanel"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(234, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(454, 256)
        Me.DataGridView1.TabIndex = 6
        '
        'FieldContainer
        '
        Me.FieldContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldContainer.Location = New System.Drawing.Point(0, 0)
        Me.FieldContainer.Name = "FieldContainer"
        '
        'FieldContainer.Panel1
        '
        Me.FieldContainer.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FieldContainer.Panel1.Controls.Add(Me.Button2)
        Me.FieldContainer.Panel1.Controls.Add(Me.Button1)
        Me.FieldContainer.Panel1MinSize = 100
        '
        'FieldContainer.Panel2
        '
        Me.FieldContainer.Panel2.Controls.Add(Me.Field_SearchPanel)
        Me.FieldContainer.Panel2.Controls.Add(Me.Field_MyinfoPanel)
        Me.FieldContainer.Size = New System.Drawing.Size(865, 444)
        Me.FieldContainer.SplitterDistance = 109
        Me.FieldContainer.SplitterWidth = 1
        Me.FieldContainer.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.AliceBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, -5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.AliceBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Field_MyinfoPanel
        '
        Me.Field_MyinfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Field_MyinfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.Field_MyinfoPanel.Name = "Field_MyinfoPanel"
        Me.Field_MyinfoPanel.Size = New System.Drawing.Size(755, 444)
        Me.Field_MyinfoPanel.TabIndex = 7
        '
        'Field_SearchPanel
        '
        Me.Field_SearchPanel.BackColor = System.Drawing.Color.White
        Me.Field_SearchPanel.Controls.Add(Me.Sharing)
        Me.Field_SearchPanel.Controls.Add(Me.Booking)
        Me.Field_SearchPanel.Controls.Add(Me.InputText1)
        Me.Field_SearchPanel.Controls.Add(Me.FieldNOInput)
        Me.Field_SearchPanel.Controls.Add(Me.DataGridView1)
        Me.Field_SearchPanel.Controls.Add(Me.OptionText2)
        Me.Field_SearchPanel.Controls.Add(Me.OptionText1)
        Me.Field_SearchPanel.Controls.Add(Me.SelectField)
        Me.Field_SearchPanel.Controls.Add(Me.ComboBox1)
        Me.Field_SearchPanel.Controls.Add(Me.DateTimePicker1)
        Me.Field_SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Field_SearchPanel.Location = New System.Drawing.Point(0, 0)
        Me.Field_SearchPanel.Name = "Field_SearchPanel"
        Me.Field_SearchPanel.Size = New System.Drawing.Size(755, 444)
        Me.Field_SearchPanel.TabIndex = 8
        '
        'FieldNOInput
        '
        Me.FieldNOInput.Location = New System.Drawing.Point(234, 79)
        Me.FieldNOInput.Name = "FieldNOInput"
        Me.FieldNOInput.Size = New System.Drawing.Size(100, 21)
        Me.FieldNOInput.TabIndex = 7
        '
        'InputText1
        '
        Me.InputText1.AutoSize = True
        Me.InputText1.Location = New System.Drawing.Point(151, 82)
        Me.InputText1.Name = "InputText1"
        Me.InputText1.Size = New System.Drawing.Size(65, 12)
        Me.InputText1.TabIndex = 8
        Me.InputText1.Text = "场馆编号："
        '
        'Booking
        '
        Me.Booking.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Booking.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Booking.Location = New System.Drawing.Point(439, 77)
        Me.Booking.Name = "Booking"
        Me.Booking.Size = New System.Drawing.Size(75, 23)
        Me.Booking.TabIndex = 9
        Me.Booking.Text = "预约"
        Me.Booking.UseVisualStyleBackColor = False
        '
        'Sharing
        '
        Me.Sharing.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Sharing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sharing.Location = New System.Drawing.Point(588, 71)
        Me.Sharing.Name = "Sharing"
        Me.Sharing.Size = New System.Drawing.Size(75, 23)
        Me.Sharing.TabIndex = 10
        Me.Sharing.Text = "拼场"
        Me.Sharing.UseVisualStyleBackColor = False
        '
        'student_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(865, 500)
        Me.Controls.Add(Me.Root)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "student_UI"
        Me.Text = "student_UI"
        Me.Root.Panel1.ResumeLayout(False)
        Me.Root.Panel1.PerformLayout()
        Me.Root.Panel2.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Root.ResumeLayout(False)
        Me.FieldPanel.ResumeLayout(False)
        Me.MessagePanel.ResumeLayout(False)
        Me.MessagePanel.PerformLayout()
        Me.FeedbackPanel.ResumeLayout(False)
        Me.FeedbackPanel.PerformLayout()
        Me.TrainingPanel.ResumeLayout(False)
        Me.TrainingPanel.PerformLayout()
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FieldContainer.Panel1.ResumeLayout(False)
        Me.FieldContainer.Panel2.ResumeLayout(False)
        CType(Me.FieldContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FieldContainer.ResumeLayout(False)
        Me.Field_SearchPanel.ResumeLayout(False)
        Me.Field_SearchPanel.PerformLayout()
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
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
    Friend WithEvents OptionText2 As Windows.Forms.Label
    Friend WithEvents OptionText1 As Windows.Forms.Label
    Friend WithEvents SelectField As Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents FieldContainer As Windows.Forms.SplitContainer
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Field_SearchPanel As Windows.Forms.Panel
    Friend WithEvents Sharing As Windows.Forms.Button
    Friend WithEvents Booking As Windows.Forms.Button
    Friend WithEvents InputText1 As Windows.Forms.Label
    Friend WithEvents FieldNOInput As Windows.Forms.TextBox
    Friend WithEvents Field_MyinfoPanel As Windows.Forms.Panel
End Class
