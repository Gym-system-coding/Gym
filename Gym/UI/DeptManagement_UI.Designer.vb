<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeptManagement_UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeptManagement_UI))
        Me.Root = New System.Windows.Forms.SplitContainer()
        Me.HomepageLink = New System.Windows.Forms.LinkLabel()
        Me.LogoutLink = New System.Windows.Forms.LinkLabel()
        Me.UserName = New System.Windows.Forms.Label()
        Me.WelcomeText = New System.Windows.Forms.Label()
        Me.DeptManagementUIText = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToConfirmGame = New System.Windows.Forms.Button()
        Me.ToAlterStatus = New System.Windows.Forms.Button()
        Me.ToConfirmMaintain = New System.Windows.Forms.Button()
        Me.AlterStatusPanel = New System.Windows.Forms.Panel()
        Me.SearchFieldPanel = New System.Windows.Forms.Panel()
        Me.searching = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.InputText1 = New System.Windows.Forms.Label()
        Me.FieldInput = New System.Windows.Forms.TextBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.OptionText2 = New System.Windows.Forms.Label()
        Me.OptionText1 = New System.Windows.Forms.Label()
        Me.SelectField = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ConfirmMaintainPanel = New System.Windows.Forms.Panel()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ConfirmGamePanel = New System.Windows.Forms.Panel()
        Me.ConfirmGame = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Root.Panel1.SuspendLayout()
        Me.Root.Panel2.SuspendLayout()
        Me.Root.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.AlterStatusPanel.SuspendLayout()
        Me.SearchFieldPanel.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfirmMaintainPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfirmGamePanel.SuspendLayout()
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
        Me.Root.Panel1.Controls.Add(Me.LogoutLink)
        Me.Root.Panel1.Controls.Add(Me.UserName)
        Me.Root.Panel1.Controls.Add(Me.WelcomeText)
        Me.Root.Panel1.Controls.Add(Me.DeptManagementUIText)
        Me.Root.Panel1MinSize = 50
        '
        'Root.Panel2
        '
        Me.Root.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Root.Size = New System.Drawing.Size(1153, 625)
        Me.Root.SplitterDistance = 52
        Me.Root.SplitterWidth = 1
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
        'DeptManagementUIText
        '
        Me.DeptManagementUIText.AutoSize = True
        Me.DeptManagementUIText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeptManagementUIText.ForeColor = System.Drawing.Color.Navy
        Me.DeptManagementUIText.Location = New System.Drawing.Point(16, 15)
        Me.DeptManagementUIText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DeptManagementUIText.Name = "DeptManagementUIText"
        Me.DeptManagementUIText.Size = New System.Drawing.Size(131, 32)
        Me.DeptManagementUIText.TabIndex = 0
        Me.DeptManagementUIText.Text = "管理部门专区"
        Me.DeptManagementUIText.UseCompatibleTextRendering = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToConfirmGame)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToAlterStatus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToConfirmMaintain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.AlterStatusPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ConfirmMaintainPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ConfirmGamePanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(1153, 572)
        Me.SplitContainer1.SplitterDistance = 143
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'ToConfirmGame
        '
        Me.ToConfirmGame.BackColor = System.Drawing.Color.AliceBlue
        Me.ToConfirmGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToConfirmGame.Location = New System.Drawing.Point(0, 28)
        Me.ToConfirmGame.Margin = New System.Windows.Forms.Padding(4)
        Me.ToConfirmGame.Name = "ToConfirmGame"
        Me.ToConfirmGame.Size = New System.Drawing.Size(144, 29)
        Me.ToConfirmGame.TabIndex = 11
        Me.ToConfirmGame.Text = "确认比赛"
        Me.ToConfirmGame.UseVisualStyleBackColor = False
        '
        'ToAlterStatus
        '
        Me.ToAlterStatus.BackColor = System.Drawing.Color.AliceBlue
        Me.ToAlterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToAlterStatus.Location = New System.Drawing.Point(0, 52)
        Me.ToAlterStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.ToAlterStatus.Name = "ToAlterStatus"
        Me.ToAlterStatus.Size = New System.Drawing.Size(144, 29)
        Me.ToAlterStatus.TabIndex = 10
        Me.ToAlterStatus.Text = "场地管理"
        Me.ToAlterStatus.UseVisualStyleBackColor = False
        '
        'ToConfirmMaintain
        '
        Me.ToConfirmMaintain.BackColor = System.Drawing.Color.AliceBlue
        Me.ToConfirmMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToConfirmMaintain.Location = New System.Drawing.Point(0, 0)
        Me.ToConfirmMaintain.Margin = New System.Windows.Forms.Padding(4)
        Me.ToConfirmMaintain.Name = "ToConfirmMaintain"
        Me.ToConfirmMaintain.Size = New System.Drawing.Size(144, 29)
        Me.ToConfirmMaintain.TabIndex = 9
        Me.ToConfirmMaintain.Text = "确认报修"
        Me.ToConfirmMaintain.UseVisualStyleBackColor = False
        '
        'AlterStatusPanel
        '
        Me.AlterStatusPanel.Controls.Add(Me.SearchFieldPanel)
        Me.AlterStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterStatusPanel.Location = New System.Drawing.Point(0, 0)
        Me.AlterStatusPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AlterStatusPanel.Name = "AlterStatusPanel"
        Me.AlterStatusPanel.Size = New System.Drawing.Size(1009, 572)
        Me.AlterStatusPanel.TabIndex = 1
        '
        'SearchFieldPanel
        '
        Me.SearchFieldPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SearchFieldPanel.Controls.Add(Me.searching)
        Me.SearchFieldPanel.Controls.Add(Me.delete)
        Me.SearchFieldPanel.Controls.Add(Me.add)
        Me.SearchFieldPanel.Controls.Add(Me.InputText1)
        Me.SearchFieldPanel.Controls.Add(Me.FieldInput)
        Me.SearchFieldPanel.Controls.Add(Me.DataGridView4)
        Me.SearchFieldPanel.Controls.Add(Me.OptionText2)
        Me.SearchFieldPanel.Controls.Add(Me.OptionText1)
        Me.SearchFieldPanel.Controls.Add(Me.SelectField)
        Me.SearchFieldPanel.Controls.Add(Me.ComboBox1)
        Me.SearchFieldPanel.Controls.Add(Me.DateTimePicker1)
        Me.SearchFieldPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchFieldPanel.Location = New System.Drawing.Point(0, 0)
        Me.SearchFieldPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchFieldPanel.Name = "SearchFieldPanel"
        Me.SearchFieldPanel.Size = New System.Drawing.Size(1009, 572)
        Me.SearchFieldPanel.TabIndex = 9
        '
        'searching
        '
        Me.searching.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.searching.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searching.Location = New System.Drawing.Point(601, 109)
        Me.searching.Margin = New System.Windows.Forms.Padding(4)
        Me.searching.Name = "searching"
        Me.searching.Size = New System.Drawing.Size(100, 29)
        Me.searching.TabIndex = 12
        Me.searching.Text = "查询"
        Me.searching.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete.Location = New System.Drawing.Point(816, 109)
        Me.delete.Margin = New System.Windows.Forms.Padding(4)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(100, 29)
        Me.delete.TabIndex = 10
        Me.delete.Text = "删除"
        Me.delete.UseVisualStyleBackColor = False
        '
        'add
        '
        Me.add.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add.Location = New System.Drawing.Point(709, 109)
        Me.add.Margin = New System.Windows.Forms.Padding(4)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(100, 29)
        Me.add.TabIndex = 9
        Me.add.Text = "添加"
        Me.add.UseVisualStyleBackColor = False
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
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(33, 184)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowTemplate.Height = 23
        Me.DataGridView4.Size = New System.Drawing.Size(884, 320)
        Me.DataGridView4.TabIndex = 6
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
        'ConfirmMaintainPanel
        '
        Me.ConfirmMaintainPanel.Controls.Add(Me.Confirm)
        Me.ConfirmMaintainPanel.Controls.Add(Me.DataGridView1)
        Me.ConfirmMaintainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfirmMaintainPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConfirmMaintainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmMaintainPanel.Name = "ConfirmMaintainPanel"
        Me.ConfirmMaintainPanel.Size = New System.Drawing.Size(1009, 572)
        Me.ConfirmMaintainPanel.TabIndex = 0
        '
        'Confirm
        '
        Me.Confirm.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Confirm.Location = New System.Drawing.Point(476, 70)
        Me.Confirm.Margin = New System.Windows.Forms.Padding(4)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(100, 29)
        Me.Confirm.TabIndex = 10
        Me.Confirm.Text = "确认"
        Me.Confirm.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(196, 205)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(608, 249)
        Me.DataGridView1.TabIndex = 0
        '
        'ConfirmGamePanel
        '
        Me.ConfirmGamePanel.Controls.Add(Me.ConfirmGame)
        Me.ConfirmGamePanel.Controls.Add(Me.DataGridView3)
        Me.ConfirmGamePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfirmGamePanel.Location = New System.Drawing.Point(0, 0)
        Me.ConfirmGamePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmGamePanel.Name = "ConfirmGamePanel"
        Me.ConfirmGamePanel.Size = New System.Drawing.Size(1009, 572)
        Me.ConfirmGamePanel.TabIndex = 1
        '
        'ConfirmGame
        '
        Me.ConfirmGame.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ConfirmGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ConfirmGame.Location = New System.Drawing.Point(480, 88)
        Me.ConfirmGame.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmGame.Name = "ConfirmGame"
        Me.ConfirmGame.Size = New System.Drawing.Size(100, 29)
        Me.ConfirmGame.TabIndex = 12
        Me.ConfirmGame.Text = "确认"
        Me.ConfirmGame.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(200, 222)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 23
        Me.DataGridView3.Size = New System.Drawing.Size(608, 249)
        Me.DataGridView3.TabIndex = 11
        '
        'DeptManagement_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1153, 625)
        Me.Controls.Add(Me.Root)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(994, 613)
        Me.Name = "DeptManagement_UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeptManagement_UI"
        Me.Root.Panel1.ResumeLayout(False)
        Me.Root.Panel1.PerformLayout()
        Me.Root.Panel2.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Root.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.AlterStatusPanel.ResumeLayout(False)
        Me.SearchFieldPanel.ResumeLayout(False)
        Me.SearchFieldPanel.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfirmMaintainPanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfirmGamePanel.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Root As Windows.Forms.SplitContainer
    Public WithEvents DeptManagementUIText As Windows.Forms.Label
    Friend WithEvents UserName As Windows.Forms.Label
    Friend WithEvents WelcomeText As Windows.Forms.Label
    Friend WithEvents LogoutLink As Windows.Forms.LinkLabel
    Friend WithEvents HomepageLink As Windows.Forms.LinkLabel
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents ToAlterStatus As Windows.Forms.Button
    Friend WithEvents ToConfirmMaintain As Windows.Forms.Button
    Friend WithEvents AlterStatusPanel As Windows.Forms.Panel
    Friend WithEvents ConfirmMaintainPanel As Windows.Forms.Panel
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents Confirm As Windows.Forms.Button
    Friend WithEvents ToConfirmGame As Windows.Forms.Button
    Friend WithEvents ConfirmGamePanel As Windows.Forms.Panel
    Friend WithEvents ConfirmGame As Windows.Forms.Button
    Friend WithEvents DataGridView3 As Windows.Forms.DataGridView
    Friend WithEvents SearchFieldPanel As Windows.Forms.Panel
    Friend WithEvents searching As Windows.Forms.Button
    Friend WithEvents delete As Windows.Forms.Button
    Friend WithEvents add As Windows.Forms.Button
    Friend WithEvents InputText1 As Windows.Forms.Label
    Friend WithEvents FieldInput As Windows.Forms.TextBox
    Friend WithEvents DataGridView4 As Windows.Forms.DataGridView
    Friend WithEvents OptionText2 As Windows.Forms.Label
    Friend WithEvents OptionText1 As Windows.Forms.Label
    Friend WithEvents SelectField As Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
End Class
