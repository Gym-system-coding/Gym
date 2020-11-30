<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeptMaintain_UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeptMaintain_UI))
        Me.Root = New System.Windows.Forms.SplitContainer()
        Me.HomepageLink = New System.Windows.Forms.LinkLabel()
        Me.LogoutLink = New System.Windows.Forms.LinkLabel()
        Me.WelcomeText = New System.Windows.Forms.Label()
        Me.DeptMaintainUIText = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Root.Name = "Root"
        Me.Root.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Root.Panel1
        '
        Me.Root.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Root.Panel1.Controls.Add(Me.HomepageLink)
        Me.Root.Panel1.Controls.Add(Me.LogoutLink)
        Me.Root.Panel1.Controls.Add(Me.WelcomeText)
        Me.Root.Panel1.Controls.Add(Me.DeptMaintainUIText)
        Me.Root.Panel1MinSize = 50
        '
        'Root.Panel2
        '
        Me.Root.Panel2.Controls.Add(Me.DataGridView1)
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
        'DeptMaintainUIText
        '
        Me.DeptMaintainUIText.AutoSize = True
        Me.DeptMaintainUIText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeptMaintainUIText.ForeColor = System.Drawing.Color.Navy
        Me.DeptMaintainUIText.Location = New System.Drawing.Point(12, 12)
        Me.DeptMaintainUIText.Name = "DeptMaintainUIText"
        Me.DeptMaintainUIText.Size = New System.Drawing.Size(105, 27)
        Me.DeptMaintainUIText.TabIndex = 0
        Me.DeptMaintainUIText.Text = "维护部门专区"
        Me.DeptMaintainUIText.UseCompatibleTextRendering = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(154, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(552, 268)
        Me.DataGridView1.TabIndex = 0
        '
        'DeptMaintain_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(865, 500)
        Me.Controls.Add(Me.Root)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 498)
        Me.Name = "DeptMaintain_UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeptMaintain_UI"
        Me.Root.Panel1.ResumeLayout(False)
        Me.Root.Panel1.PerformLayout()
        Me.Root.Panel2.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Root.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Root As Windows.Forms.SplitContainer
    Public WithEvents DeptMaintainUIText As Windows.Forms.Label
    Friend WithEvents WelcomeText As Windows.Forms.Label
    Friend WithEvents LogoutLink As Windows.Forms.LinkLabel
    Friend WithEvents HomepageLink As Windows.Forms.LinkLabel
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
End Class
