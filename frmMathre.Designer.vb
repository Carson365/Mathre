<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMathre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mnuBaseLayer = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFrench = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGerman = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSecret = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRecolor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDarkMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTechnicolor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRandomify = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabMathre = New System.Windows.Forms.TabControl()
        Me.tabHelloWorld = New System.Windows.Forms.TabPage()
        Me.grpHelloWorld = New Mathre.CustomGroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFrench = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnGerman = New System.Windows.Forms.RadioButton()
        Me.btnEnglish = New System.Windows.Forms.RadioButton()
        Me.lblHelloWorld = New System.Windows.Forms.Label()
        Me.tabMySchool = New System.Windows.Forms.TabPage()
        Me.TabUnknown = New System.Windows.Forms.TabPage()
        Me.tabSecret = New System.Windows.Forms.TabPage()
        Me.lblSecretTitle = New System.Windows.Forms.Label()
        Me.grpSecret = New Mathre.CustomGroupBox()
        Me.btnSecretDisable = New System.Windows.Forms.RadioButton()
        Me.btnSecretEnable = New System.Windows.Forms.RadioButton()
        Me.txtSecretPassword = New System.Windows.Forms.TextBox()
        Me.lblSecretPrompt = New System.Windows.Forms.Label()
        Me.mnuBaseLayer.SuspendLayout()
        Me.tabMathre.SuspendLayout()
        Me.tabHelloWorld.SuspendLayout()
        Me.grpHelloWorld.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSecret.SuspendLayout()
        Me.grpSecret.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuBaseLayer
        '
        Me.mnuBaseLayer.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuBaseLayer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView})
        Me.mnuBaseLayer.Location = New System.Drawing.Point(0, 0)
        Me.mnuBaseLayer.Name = "mnuBaseLayer"
        Me.mnuBaseLayer.Padding = New System.Windows.Forms.Padding(0)
        Me.mnuBaseLayer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuBaseLayer.Size = New System.Drawing.Size(1047, 24)
        Me.mnuBaseLayer.TabIndex = 0
        Me.mnuBaseLayer.Text = "Menu"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLanguage, Me.mnuReset, Me.mnuSecret, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 24)
        Me.mnuFile.Text = "File"
        '
        'mnuLanguage
        '
        Me.mnuLanguage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEnglish, Me.mnuFrench, Me.mnuGerman})
        Me.mnuLanguage.Name = "mnuLanguage"
        Me.mnuLanguage.Size = New System.Drawing.Size(184, 22)
        Me.mnuLanguage.Text = "Language"
        '
        'mnuEnglish
        '
        Me.mnuEnglish.Name = "mnuEnglish"
        Me.mnuEnglish.Size = New System.Drawing.Size(116, 22)
        Me.mnuEnglish.Text = "English"
        '
        'mnuFrench
        '
        Me.mnuFrench.Name = "mnuFrench"
        Me.mnuFrench.Size = New System.Drawing.Size(116, 22)
        Me.mnuFrench.Text = "French"
        '
        'mnuGerman
        '
        Me.mnuGerman.Name = "mnuGerman"
        Me.mnuGerman.Size = New System.Drawing.Size(116, 22)
        Me.mnuGerman.Text = "German"
        '
        'mnuReset
        '
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(184, 22)
        Me.mnuReset.Text = "Reset"
        '
        'mnuSecret
        '
        Me.mnuSecret.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRecolor, Me.mnuRandomify})
        Me.mnuSecret.Enabled = False
        Me.mnuSecret.Name = "mnuSecret"
        Me.mnuSecret.Size = New System.Drawing.Size(184, 22)
        Me.mnuSecret.Text = "Super Secret Settings"
        '
        'mnuRecolor
        '
        Me.mnuRecolor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDarkMode, Me.mnuTechnicolor})
        Me.mnuRecolor.Enabled = False
        Me.mnuRecolor.Name = "mnuRecolor"
        Me.mnuRecolor.Size = New System.Drawing.Size(132, 22)
        Me.mnuRecolor.Text = "Recolor"
        '
        'mnuDarkMode
        '
        Me.mnuDarkMode.Enabled = False
        Me.mnuDarkMode.Name = "mnuDarkMode"
        Me.mnuDarkMode.Size = New System.Drawing.Size(135, 22)
        Me.mnuDarkMode.Text = "Dark Mode"
        '
        'mnuTechnicolor
        '
        Me.mnuTechnicolor.Enabled = False
        Me.mnuTechnicolor.Name = "mnuTechnicolor"
        Me.mnuTechnicolor.Size = New System.Drawing.Size(135, 22)
        Me.mnuTechnicolor.Text = "Technicolor"
        '
        'mnuRandomify
        '
        Me.mnuRandomify.Name = "mnuRandomify"
        Me.mnuRandomify.Size = New System.Drawing.Size(132, 22)
        Me.mnuRandomify.Text = "Randomify"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(184, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 24)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuView
        '
        Me.mnuView.Enabled = False
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 24)
        Me.mnuView.Text = "View"
        '
        'tabMathre
        '
        Me.tabMathre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMathre.Controls.Add(Me.tabHelloWorld)
        Me.tabMathre.Controls.Add(Me.tabMySchool)
        Me.tabMathre.Controls.Add(Me.TabUnknown)
        Me.tabMathre.Controls.Add(Me.tabSecret)
        Me.tabMathre.Location = New System.Drawing.Point(0, 29)
        Me.tabMathre.Margin = New System.Windows.Forms.Padding(0)
        Me.tabMathre.Name = "tabMathre"
        Me.tabMathre.Padding = New System.Drawing.Point(0, 0)
        Me.tabMathre.SelectedIndex = 0
        Me.tabMathre.Size = New System.Drawing.Size(1052, 512)
        Me.tabMathre.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabMathre.TabIndex = 4
        '
        'tabHelloWorld
        '
        Me.tabHelloWorld.Controls.Add(Me.grpHelloWorld)
        Me.tabHelloWorld.Controls.Add(Me.lblHelloWorld)
        Me.tabHelloWorld.Location = New System.Drawing.Point(4, 22)
        Me.tabHelloWorld.Margin = New System.Windows.Forms.Padding(0)
        Me.tabHelloWorld.Name = "tabHelloWorld"
        Me.tabHelloWorld.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHelloWorld.Size = New System.Drawing.Size(1044, 486)
        Me.tabHelloWorld.TabIndex = 0
        Me.tabHelloWorld.Text = "Hello World"
        Me.tabHelloWorld.UseVisualStyleBackColor = True
        '
        'grpHelloWorld
        '
        Me.grpHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpHelloWorld.AutoSize = True
        Me.grpHelloWorld.BackColor = System.Drawing.SystemColors.Control
        Me.grpHelloWorld.BorderColor = System.Drawing.Color.Black
        Me.grpHelloWorld.Controls.Add(Me.PictureBox1)
        Me.grpHelloWorld.Controls.Add(Me.btnFrench)
        Me.grpHelloWorld.Controls.Add(Me.PictureBox2)
        Me.grpHelloWorld.Controls.Add(Me.PictureBox3)
        Me.grpHelloWorld.Controls.Add(Me.btnReset)
        Me.grpHelloWorld.Controls.Add(Me.btnGerman)
        Me.grpHelloWorld.Controls.Add(Me.btnEnglish)
        Me.grpHelloWorld.Location = New System.Drawing.Point(309, 191)
        Me.grpHelloWorld.Name = "grpHelloWorld"
        Me.grpHelloWorld.Size = New System.Drawing.Size(426, 105)
        Me.grpHelloWorld.TabIndex = 7
        Me.grpHelloWorld.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mathre.My.Resources.Resources.German
        Me.PictureBox1.Location = New System.Drawing.Point(293, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnFrench
        '
        Me.btnFrench.AutoSize = True
        Me.btnFrench.Location = New System.Drawing.Point(201, 25)
        Me.btnFrench.Name = "btnFrench"
        Me.btnFrench.Size = New System.Drawing.Size(58, 17)
        Me.btnFrench.TabIndex = 10
        Me.btnFrench.Text = "French"
        Me.btnFrench.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Mathre.My.Resources.Resources.English
        Me.PictureBox2.Location = New System.Drawing.Point(34, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Mathre.My.Resources.Resources.French
        Me.PictureBox3.Location = New System.Drawing.Point(164, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(169, 61)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnGerman
        '
        Me.btnGerman.AutoSize = True
        Me.btnGerman.Location = New System.Drawing.Point(330, 25)
        Me.btnGerman.Name = "btnGerman"
        Me.btnGerman.Size = New System.Drawing.Size(62, 17)
        Me.btnGerman.TabIndex = 8
        Me.btnGerman.Text = "German"
        Me.btnGerman.UseVisualStyleBackColor = True
        '
        'btnEnglish
        '
        Me.btnEnglish.AutoSize = True
        Me.btnEnglish.Checked = True
        Me.btnEnglish.Location = New System.Drawing.Point(71, 25)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(59, 17)
        Me.btnEnglish.TabIndex = 7
        Me.btnEnglish.TabStop = True
        Me.btnEnglish.Text = "English"
        Me.btnEnglish.UseVisualStyleBackColor = True
        '
        'lblHelloWorld
        '
        Me.lblHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHelloWorld.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelloWorld.Location = New System.Drawing.Point(309, 122)
        Me.lblHelloWorld.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHelloWorld.Name = "lblHelloWorld"
        Me.lblHelloWorld.Size = New System.Drawing.Size(426, 51)
        Me.lblHelloWorld.TabIndex = 5
        Me.lblHelloWorld.Text = "Hello World"
        Me.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabMySchool
        '
        Me.tabMySchool.Location = New System.Drawing.Point(4, 22)
        Me.tabMySchool.Name = "tabMySchool"
        Me.tabMySchool.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMySchool.Size = New System.Drawing.Size(1044, 486)
        Me.tabMySchool.TabIndex = 1
        Me.tabMySchool.Text = "My School"
        Me.tabMySchool.UseVisualStyleBackColor = True
        '
        'TabUnknown
        '
        Me.TabUnknown.Location = New System.Drawing.Point(4, 22)
        Me.TabUnknown.Name = "TabUnknown"
        Me.TabUnknown.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUnknown.Size = New System.Drawing.Size(1044, 486)
        Me.TabUnknown.TabIndex = 2
        Me.TabUnknown.Text = "..."
        Me.TabUnknown.UseVisualStyleBackColor = True
        '
        'tabSecret
        '
        Me.tabSecret.Controls.Add(Me.lblSecretTitle)
        Me.tabSecret.Controls.Add(Me.grpSecret)
        Me.tabSecret.Location = New System.Drawing.Point(4, 22)
        Me.tabSecret.Name = "tabSecret"
        Me.tabSecret.Size = New System.Drawing.Size(1044, 486)
        Me.tabSecret.TabIndex = 3
        Me.tabSecret.Text = "Secret Settings Page"
        Me.tabSecret.UseVisualStyleBackColor = True
        '
        'lblSecretTitle
        '
        Me.lblSecretTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSecretTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretTitle.Location = New System.Drawing.Point(209, 122)
        Me.lblSecretTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSecretTitle.Name = "lblSecretTitle"
        Me.lblSecretTitle.Size = New System.Drawing.Size(626, 51)
        Me.lblSecretTitle.TabIndex = 9
        Me.lblSecretTitle.Text = "Enable Super Secret Settings"
        Me.lblSecretTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpSecret
        '
        Me.grpSecret.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSecret.AutoSize = True
        Me.grpSecret.BackColor = System.Drawing.SystemColors.Control
        Me.grpSecret.BorderColor = System.Drawing.Color.Black
        Me.grpSecret.Controls.Add(Me.btnSecretDisable)
        Me.grpSecret.Controls.Add(Me.btnSecretEnable)
        Me.grpSecret.Controls.Add(Me.txtSecretPassword)
        Me.grpSecret.Controls.Add(Me.lblSecretPrompt)
        Me.grpSecret.Location = New System.Drawing.Point(309, 191)
        Me.grpSecret.Name = "grpSecret"
        Me.grpSecret.Size = New System.Drawing.Size(426, 119)
        Me.grpSecret.TabIndex = 8
        Me.grpSecret.TabStop = False
        '
        'btnSecretDisable
        '
        Me.btnSecretDisable.AutoSize = True
        Me.btnSecretDisable.Checked = True
        Me.btnSecretDisable.Enabled = False
        Me.btnSecretDisable.Location = New System.Drawing.Point(85, 78)
        Me.btnSecretDisable.Name = "btnSecretDisable"
        Me.btnSecretDisable.Size = New System.Drawing.Size(60, 17)
        Me.btnSecretDisable.TabIndex = 11
        Me.btnSecretDisable.TabStop = True
        Me.btnSecretDisable.Text = "Disable"
        Me.btnSecretDisable.UseVisualStyleBackColor = True
        '
        'btnSecretEnable
        '
        Me.btnSecretEnable.AutoSize = True
        Me.btnSecretEnable.Enabled = False
        Me.btnSecretEnable.Location = New System.Drawing.Point(283, 79)
        Me.btnSecretEnable.Name = "btnSecretEnable"
        Me.btnSecretEnable.Size = New System.Drawing.Size(58, 17)
        Me.btnSecretEnable.TabIndex = 10
        Me.btnSecretEnable.Text = "Enable"
        Me.btnSecretEnable.UseVisualStyleBackColor = True
        '
        'txtSecretPassword
        '
        Me.txtSecretPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtSecretPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecretPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretPassword.Location = New System.Drawing.Point(261, 22)
        Me.txtSecretPassword.Name = "txtSecretPassword"
        Me.txtSecretPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8727)
        Me.txtSecretPassword.Size = New System.Drawing.Size(114, 26)
        Me.txtSecretPassword.TabIndex = 9
        '
        'lblSecretPrompt
        '
        Me.lblSecretPrompt.AutoSize = True
        Me.lblSecretPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretPrompt.Location = New System.Drawing.Point(52, 24)
        Me.lblSecretPrompt.Name = "lblSecretPrompt"
        Me.lblSecretPrompt.Size = New System.Drawing.Size(153, 20)
        Me.lblSecretPrompt.TabIndex = 9
        Me.lblSecretPrompt.Text = "Enter the Passcode:"
        '
        'FrmMathre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1047, 526)
        Me.Controls.Add(Me.tabMathre)
        Me.Controls.Add(Me.mnuBaseLayer)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuBaseLayer
        Me.MinimumSize = New System.Drawing.Size(500, 350)
        Me.Name = "FrmMathre"
        Me.Text = "Hello World"
        Me.mnuBaseLayer.ResumeLayout(False)
        Me.mnuBaseLayer.PerformLayout()
        Me.tabMathre.ResumeLayout(False)
        Me.tabHelloWorld.ResumeLayout(False)
        Me.tabHelloWorld.PerformLayout()
        Me.grpHelloWorld.ResumeLayout(False)
        Me.grpHelloWorld.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSecret.ResumeLayout(False)
        Me.tabSecret.PerformLayout()
        Me.grpSecret.ResumeLayout(False)
        Me.grpSecret.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuBaseLayer As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuReset As ToolStripMenuItem
    Friend WithEvents mnuSecret As ToolStripMenuItem
    Friend WithEvents mnuRecolor As ToolStripMenuItem
    Friend WithEvents mnuDarkMode As ToolStripMenuItem
    Friend WithEvents mnuTechnicolor As ToolStripMenuItem
    Friend WithEvents mnuRandomify As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents tabMathre As TabControl
    Friend WithEvents tabHelloWorld As TabPage
    Friend WithEvents tabMySchool As TabPage
    Friend WithEvents lblHelloWorld As Label
    Friend WithEvents TabUnknown As TabPage
    Friend WithEvents mnuLanguage As ToolStripMenuItem
    Friend WithEvents mnuEnglish As ToolStripMenuItem
    Friend WithEvents mnuFrench As ToolStripMenuItem
    Friend WithEvents mnuGerman As ToolStripMenuItem
    Friend WithEvents grpHelloWorld As CustomGroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFrench As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnGerman As RadioButton
    Friend WithEvents btnEnglish As RadioButton
    Friend WithEvents tabSecret As TabPage
    Friend WithEvents grpSecret As CustomGroupBox
    Friend WithEvents lblSecretPrompt As Label
    Friend WithEvents txtSecretPassword As TextBox
    Friend WithEvents lblSecretTitle As Label
    Friend WithEvents btnSecretDisable As RadioButton
    Friend WithEvents btnSecretEnable As RadioButton
End Class
