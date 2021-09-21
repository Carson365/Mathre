using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Mathre
{
    [DesignerGenerated()]
    public partial class FrmMathre : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.mnuBaseLayer = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTechnicolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRandomify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMySchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMySchoolToggleMascot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMathre = new System.Windows.Forms.TabControl();
            this.tabHelloWorld = new System.Windows.Forms.TabPage();
            this.grpHelloWorldGroupBox = new Mathre.CustomGroupBox();
            this.picHelloWorldGerman = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldFrench = new System.Windows.Forms.RadioButton();
            this.picHelloWorldEnglish = new System.Windows.Forms.PictureBox();
            this.picHelloWorldFrench = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldReset = new System.Windows.Forms.Button();
            this.btnHelloWorldGerman = new System.Windows.Forms.RadioButton();
            this.btnHelloWorldEnglish = new System.Windows.Forms.RadioButton();
            this.lblHelloWorldTitle = new System.Windows.Forms.Label();
            this.tabMySchool = new System.Windows.Forms.TabPage();
            this.lblMySchoolTitle = new System.Windows.Forms.Label();
            this.customGroupBox1 = new Mathre.CustomGroupBox();
            this.lblMySchoolMascot = new System.Windows.Forms.Label();
            this.picMySchoolMascot = new System.Windows.Forms.PictureBox();
            this.btnMySchoolToggleMascot = new System.Windows.Forms.Button();
            this.tabSecret = new System.Windows.Forms.TabPage();
            this.lblSecretTitle = new System.Windows.Forms.Label();
            this.grpSecret = new Mathre.CustomGroupBox();
            this.btnSecretDisable = new System.Windows.Forms.RadioButton();
            this.btnSecretEnable = new System.Windows.Forms.RadioButton();
            this.txtSecretPassword = new System.Windows.Forms.TextBox();
            this.lblSecretPrompt = new System.Windows.Forms.Label();
            this.TabUnknown = new System.Windows.Forms.TabPage();
            this.mnuBaseLayer.SuspendLayout();
            this.tabMathre.SuspendLayout();
            this.tabHelloWorld.SuspendLayout();
            this.grpHelloWorldGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).BeginInit();
            this.tabMySchool.SuspendLayout();
            this.customGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).BeginInit();
            this.tabSecret.SuspendLayout();
            this.grpSecret.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBaseLayer
            // 
            this.mnuBaseLayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuBaseLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView});
            this.mnuBaseLayer.Location = new System.Drawing.Point(0, 0);
            this.mnuBaseLayer.Name = "mnuBaseLayer";
            this.mnuBaseLayer.Padding = new System.Windows.Forms.Padding(0);
            this.mnuBaseLayer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuBaseLayer.Size = new System.Drawing.Size(1047, 24);
            this.mnuBaseLayer.TabIndex = 0;
            this.mnuBaseLayer.Text = "Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSecret,
            this.mnuHelloWorld,
            this.mnuMySchool,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuSecret
            // 
            this.mnuSecret.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecolor,
            this.mnuRandomify});
            this.mnuSecret.Enabled = false;
            this.mnuSecret.Name = "mnuSecret";
            this.mnuSecret.Size = new System.Drawing.Size(184, 22);
            this.mnuSecret.Text = "Super Secret Settings";
            this.mnuSecret.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuRecolor
            // 
            this.mnuRecolor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDarkMode,
            this.mnuTechnicolor});
            this.mnuRecolor.Enabled = false;
            this.mnuRecolor.Name = "mnuRecolor";
            this.mnuRecolor.Size = new System.Drawing.Size(132, 22);
            this.mnuRecolor.Text = "Recolor";
            this.mnuRecolor.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuDarkMode
            // 
            this.mnuDarkMode.Enabled = false;
            this.mnuDarkMode.Name = "mnuDarkMode";
            this.mnuDarkMode.Size = new System.Drawing.Size(135, 22);
            this.mnuDarkMode.Text = "Dark Mode";
            this.mnuDarkMode.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuTechnicolor
            // 
            this.mnuTechnicolor.Enabled = false;
            this.mnuTechnicolor.Name = "mnuTechnicolor";
            this.mnuTechnicolor.Size = new System.Drawing.Size(135, 22);
            this.mnuTechnicolor.Text = "Technicolor";
            this.mnuTechnicolor.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuRandomify
            // 
            this.mnuRandomify.Name = "mnuRandomify";
            this.mnuRandomify.Size = new System.Drawing.Size(132, 22);
            this.mnuRandomify.Text = "Randomify";
            this.mnuRandomify.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuHelloWorld
            // 
            this.mnuHelloWorld.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelloWorldLanguage,
            this.mnuHelloWorldReset});
            this.mnuHelloWorld.Name = "mnuHelloWorld";
            this.mnuHelloWorld.Size = new System.Drawing.Size(184, 22);
            this.mnuHelloWorld.Text = "Hello World";
            // 
            // mnuHelloWorldLanguage
            // 
            this.mnuHelloWorldLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelloWorldLanguageEnglish,
            this.mnuHelloWorldLanguageFrench,
            this.mnuHelloWorldLanguageGerman});
            this.mnuHelloWorldLanguage.Name = "mnuHelloWorldLanguage";
            this.mnuHelloWorldLanguage.Size = new System.Drawing.Size(180, 22);
            this.mnuHelloWorldLanguage.Text = "Language";
            // 
            // mnuHelloWorldLanguageEnglish
            // 
            this.mnuHelloWorldLanguageEnglish.Image = global::Mathre.My.Resources.Resources.EnglishAtScale;
            this.mnuHelloWorldLanguageEnglish.Name = "mnuHelloWorldLanguageEnglish";
            this.mnuHelloWorldLanguageEnglish.Size = new System.Drawing.Size(180, 22);
            this.mnuHelloWorldLanguageEnglish.Text = "English";
            this.mnuHelloWorldLanguageEnglish.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuHelloWorldLanguageFrench
            // 
            this.mnuHelloWorldLanguageFrench.Image = global::Mathre.My.Resources.Resources.French;
            this.mnuHelloWorldLanguageFrench.Name = "mnuHelloWorldLanguageFrench";
            this.mnuHelloWorldLanguageFrench.Size = new System.Drawing.Size(180, 22);
            this.mnuHelloWorldLanguageFrench.Text = "French";
            this.mnuHelloWorldLanguageFrench.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuHelloWorldLanguageGerman
            // 
            this.mnuHelloWorldLanguageGerman.Image = global::Mathre.My.Resources.Resources.German;
            this.mnuHelloWorldLanguageGerman.Name = "mnuHelloWorldLanguageGerman";
            this.mnuHelloWorldLanguageGerman.Size = new System.Drawing.Size(180, 22);
            this.mnuHelloWorldLanguageGerman.Text = "German";
            this.mnuHelloWorldLanguageGerman.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuHelloWorldReset
            // 
            this.mnuHelloWorldReset.Name = "mnuHelloWorldReset";
            this.mnuHelloWorldReset.Size = new System.Drawing.Size(180, 22);
            this.mnuHelloWorldReset.Text = "Reset";
            this.mnuHelloWorldReset.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuMySchool
            // 
            this.mnuMySchool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMySchoolToggleMascot});
            this.mnuMySchool.Name = "mnuMySchool";
            this.mnuMySchool.Size = new System.Drawing.Size(184, 22);
            this.mnuMySchool.Text = "My School";
            // 
            // mnuMySchoolToggleMascot
            // 
            this.mnuMySchoolToggleMascot.Name = "mnuMySchoolToggleMascot";
            this.mnuMySchoolToggleMascot.Size = new System.Drawing.Size(198, 22);
            this.mnuMySchoolToggleMascot.Text = "Toggle Mascot Visibility";
            this.mnuMySchoolToggleMascot.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(184, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 24);
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuView
            // 
            this.mnuView.Enabled = false;
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 24);
            this.mnuView.Text = "View";
            this.mnuView.Click += new System.EventHandler(this.Buttons);
            // 
            // tabMathre
            // 
            this.tabMathre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMathre.Controls.Add(this.tabHelloWorld);
            this.tabMathre.Controls.Add(this.tabMySchool);
            this.tabMathre.Controls.Add(this.tabSecret);
            this.tabMathre.Controls.Add(this.TabUnknown);
            this.tabMathre.Location = new System.Drawing.Point(0, 29);
            this.tabMathre.Margin = new System.Windows.Forms.Padding(0);
            this.tabMathre.Name = "tabMathre";
            this.tabMathre.Padding = new System.Drawing.Point(0, 0);
            this.tabMathre.SelectedIndex = 0;
            this.tabMathre.Size = new System.Drawing.Size(1052, 512);
            this.tabMathre.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMathre.TabIndex = 4;
            // 
            // tabHelloWorld
            // 
            this.tabHelloWorld.Controls.Add(this.grpHelloWorldGroupBox);
            this.tabHelloWorld.Controls.Add(this.lblHelloWorldTitle);
            this.tabHelloWorld.Location = new System.Drawing.Point(4, 22);
            this.tabHelloWorld.Margin = new System.Windows.Forms.Padding(0);
            this.tabHelloWorld.Name = "tabHelloWorld";
            this.tabHelloWorld.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelloWorld.Size = new System.Drawing.Size(1044, 486);
            this.tabHelloWorld.TabIndex = 0;
            this.tabHelloWorld.Text = "Hello World";
            this.tabHelloWorld.UseVisualStyleBackColor = true;
            // 
            // grpHelloWorldGroupBox
            // 
            this.grpHelloWorldGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpHelloWorldGroupBox.AutoSize = true;
            this.grpHelloWorldGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.grpHelloWorldGroupBox.BorderColor = System.Drawing.Color.Black;
            this.grpHelloWorldGroupBox.Controls.Add(this.picHelloWorldGerman);
            this.grpHelloWorldGroupBox.Controls.Add(this.btnHelloWorldFrench);
            this.grpHelloWorldGroupBox.Controls.Add(this.picHelloWorldEnglish);
            this.grpHelloWorldGroupBox.Controls.Add(this.picHelloWorldFrench);
            this.grpHelloWorldGroupBox.Controls.Add(this.btnHelloWorldReset);
            this.grpHelloWorldGroupBox.Controls.Add(this.btnHelloWorldGerman);
            this.grpHelloWorldGroupBox.Controls.Add(this.btnHelloWorldEnglish);
            this.grpHelloWorldGroupBox.Location = new System.Drawing.Point(309, 191);
            this.grpHelloWorldGroupBox.Name = "grpHelloWorldGroupBox";
            this.grpHelloWorldGroupBox.Size = new System.Drawing.Size(426, 105);
            this.grpHelloWorldGroupBox.TabIndex = 7;
            this.grpHelloWorldGroupBox.TabStop = false;
            // 
            // picHelloWorldGerman
            // 
            this.picHelloWorldGerman.Image = global::Mathre.My.Resources.Resources.German;
            this.picHelloWorldGerman.Location = new System.Drawing.Point(293, 21);
            this.picHelloWorldGerman.Name = "picHelloWorldGerman";
            this.picHelloWorldGerman.Size = new System.Drawing.Size(31, 25);
            this.picHelloWorldGerman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldGerman.TabIndex = 13;
            this.picHelloWorldGerman.TabStop = false;
            // 
            // btnHelloWorldFrench
            // 
            this.btnHelloWorldFrench.AutoSize = true;
            this.btnHelloWorldFrench.Location = new System.Drawing.Point(201, 25);
            this.btnHelloWorldFrench.Name = "btnHelloWorldFrench";
            this.btnHelloWorldFrench.Size = new System.Drawing.Size(58, 17);
            this.btnHelloWorldFrench.TabIndex = 10;
            this.btnHelloWorldFrench.Text = "French";
            this.btnHelloWorldFrench.UseVisualStyleBackColor = true;
            this.btnHelloWorldFrench.Click += new System.EventHandler(this.Buttons);
            // 
            // picHelloWorldEnglish
            // 
            this.picHelloWorldEnglish.Image = global::Mathre.My.Resources.Resources.English;
            this.picHelloWorldEnglish.Location = new System.Drawing.Point(34, 21);
            this.picHelloWorldEnglish.Name = "picHelloWorldEnglish";
            this.picHelloWorldEnglish.Size = new System.Drawing.Size(31, 25);
            this.picHelloWorldEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldEnglish.TabIndex = 12;
            this.picHelloWorldEnglish.TabStop = false;
            // 
            // picHelloWorldFrench
            // 
            this.picHelloWorldFrench.Image = global::Mathre.My.Resources.Resources.French;
            this.picHelloWorldFrench.Location = new System.Drawing.Point(164, 21);
            this.picHelloWorldFrench.Name = "picHelloWorldFrench";
            this.picHelloWorldFrench.Size = new System.Drawing.Size(31, 25);
            this.picHelloWorldFrench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldFrench.TabIndex = 11;
            this.picHelloWorldFrench.TabStop = false;
            // 
            // btnHelloWorldReset
            // 
            this.btnHelloWorldReset.Location = new System.Drawing.Point(169, 61);
            this.btnHelloWorldReset.Name = "btnHelloWorldReset";
            this.btnHelloWorldReset.Size = new System.Drawing.Size(75, 23);
            this.btnHelloWorldReset.TabIndex = 9;
            this.btnHelloWorldReset.Text = "Reset";
            this.btnHelloWorldReset.UseVisualStyleBackColor = true;
            this.btnHelloWorldReset.Click += new System.EventHandler(this.Buttons);
            // 
            // btnHelloWorldGerman
            // 
            this.btnHelloWorldGerman.AutoSize = true;
            this.btnHelloWorldGerman.Location = new System.Drawing.Point(330, 25);
            this.btnHelloWorldGerman.Name = "btnHelloWorldGerman";
            this.btnHelloWorldGerman.Size = new System.Drawing.Size(62, 17);
            this.btnHelloWorldGerman.TabIndex = 8;
            this.btnHelloWorldGerman.Text = "German";
            this.btnHelloWorldGerman.UseVisualStyleBackColor = true;
            this.btnHelloWorldGerman.Click += new System.EventHandler(this.Buttons);
            // 
            // btnHelloWorldEnglish
            // 
            this.btnHelloWorldEnglish.AutoSize = true;
            this.btnHelloWorldEnglish.Checked = true;
            this.btnHelloWorldEnglish.Location = new System.Drawing.Point(71, 25);
            this.btnHelloWorldEnglish.Name = "btnHelloWorldEnglish";
            this.btnHelloWorldEnglish.Size = new System.Drawing.Size(59, 17);
            this.btnHelloWorldEnglish.TabIndex = 7;
            this.btnHelloWorldEnglish.TabStop = true;
            this.btnHelloWorldEnglish.Text = "English";
            this.btnHelloWorldEnglish.UseVisualStyleBackColor = true;
            this.btnHelloWorldEnglish.Click += new System.EventHandler(this.Buttons);
            // 
            // lblHelloWorldTitle
            // 
            this.lblHelloWorldTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloWorldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldTitle.Location = new System.Drawing.Point(309, 122);
            this.lblHelloWorldTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblHelloWorldTitle.Name = "lblHelloWorldTitle";
            this.lblHelloWorldTitle.Size = new System.Drawing.Size(426, 51);
            this.lblHelloWorldTitle.TabIndex = 5;
            this.lblHelloWorldTitle.Text = "Hello World";
            this.lblHelloWorldTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMySchool
            // 
            this.tabMySchool.Controls.Add(this.lblMySchoolTitle);
            this.tabMySchool.Controls.Add(this.customGroupBox1);
            this.tabMySchool.Location = new System.Drawing.Point(4, 22);
            this.tabMySchool.Name = "tabMySchool";
            this.tabMySchool.Padding = new System.Windows.Forms.Padding(3);
            this.tabMySchool.Size = new System.Drawing.Size(1044, 486);
            this.tabMySchool.TabIndex = 1;
            this.tabMySchool.Text = "My School";
            this.tabMySchool.UseVisualStyleBackColor = true;
            // 
            // lblMySchoolTitle
            // 
            this.lblMySchoolTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMySchoolTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySchoolTitle.Location = new System.Drawing.Point(274, 122);
            this.lblMySchoolTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblMySchoolTitle.Name = "lblMySchoolTitle";
            this.lblMySchoolTitle.Size = new System.Drawing.Size(496, 51);
            this.lblMySchoolTitle.TabIndex = 8;
            this.lblMySchoolTitle.Text = "Red River High School";
            this.lblMySchoolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customGroupBox1.AutoSize = true;
            this.customGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.customGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.customGroupBox1.Controls.Add(this.lblMySchoolMascot);
            this.customGroupBox1.Controls.Add(this.picMySchoolMascot);
            this.customGroupBox1.Controls.Add(this.btnMySchoolToggleMascot);
            this.customGroupBox1.Location = new System.Drawing.Point(309, 191);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(426, 105);
            this.customGroupBox1.TabIndex = 9;
            this.customGroupBox1.TabStop = false;
            // 
            // lblMySchoolMascot
            // 
            this.lblMySchoolMascot.AutoSize = true;
            this.lblMySchoolMascot.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySchoolMascot.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMySchoolMascot.Location = new System.Drawing.Point(50, 27);
            this.lblMySchoolMascot.Name = "lblMySchoolMascot";
            this.lblMySchoolMascot.Size = new System.Drawing.Size(134, 18);
            this.lblMySchoolMascot.TabIndex = 10;
            this.lblMySchoolMascot.Text = "Mascot: Roughriders";
            // 
            // picMySchoolMascot
            // 
            this.picMySchoolMascot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMySchoolMascot.Image = global::Mathre.My.Resources.Resources.RedRiver;
            this.picMySchoolMascot.Location = new System.Drawing.Point(268, 19);
            this.picMySchoolMascot.Name = "picMySchoolMascot";
            this.picMySchoolMascot.Size = new System.Drawing.Size(108, 66);
            this.picMySchoolMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMySchoolMascot.TabIndex = 13;
            this.picMySchoolMascot.TabStop = false;
            this.picMySchoolMascot.Visible = false;
            // 
            // btnMySchoolToggleMascot
            // 
            this.btnMySchoolToggleMascot.Location = new System.Drawing.Point(51, 60);
            this.btnMySchoolToggleMascot.Name = "btnMySchoolToggleMascot";
            this.btnMySchoolToggleMascot.Size = new System.Drawing.Size(132, 23);
            this.btnMySchoolToggleMascot.TabIndex = 9;
            this.btnMySchoolToggleMascot.Text = "Toggle Mascot Visibility";
            this.btnMySchoolToggleMascot.UseVisualStyleBackColor = true;
            this.btnMySchoolToggleMascot.Click += new System.EventHandler(this.Buttons);
            // 
            // tabSecret
            // 
            this.tabSecret.Controls.Add(this.lblSecretTitle);
            this.tabSecret.Controls.Add(this.grpSecret);
            this.tabSecret.Location = new System.Drawing.Point(4, 22);
            this.tabSecret.Name = "tabSecret";
            this.tabSecret.Size = new System.Drawing.Size(1044, 486);
            this.tabSecret.TabIndex = 3;
            this.tabSecret.Text = "Secret Settings Page";
            this.tabSecret.UseVisualStyleBackColor = true;
            // 
            // lblSecretTitle
            // 
            this.lblSecretTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecretTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretTitle.Location = new System.Drawing.Point(209, 122);
            this.lblSecretTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSecretTitle.Name = "lblSecretTitle";
            this.lblSecretTitle.Size = new System.Drawing.Size(626, 51);
            this.lblSecretTitle.TabIndex = 9;
            this.lblSecretTitle.Text = "Enable Super Secret Settings";
            this.lblSecretTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSecret
            // 
            this.grpSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSecret.AutoSize = true;
            this.grpSecret.BackColor = System.Drawing.SystemColors.Control;
            this.grpSecret.BorderColor = System.Drawing.Color.Black;
            this.grpSecret.Controls.Add(this.btnSecretDisable);
            this.grpSecret.Controls.Add(this.btnSecretEnable);
            this.grpSecret.Controls.Add(this.txtSecretPassword);
            this.grpSecret.Controls.Add(this.lblSecretPrompt);
            this.grpSecret.Location = new System.Drawing.Point(309, 191);
            this.grpSecret.Name = "grpSecret";
            this.grpSecret.Size = new System.Drawing.Size(426, 119);
            this.grpSecret.TabIndex = 8;
            this.grpSecret.TabStop = false;
            // 
            // btnSecretDisable
            // 
            this.btnSecretDisable.AutoSize = true;
            this.btnSecretDisable.Checked = true;
            this.btnSecretDisable.Enabled = false;
            this.btnSecretDisable.Location = new System.Drawing.Point(85, 78);
            this.btnSecretDisable.Name = "btnSecretDisable";
            this.btnSecretDisable.Size = new System.Drawing.Size(60, 17);
            this.btnSecretDisable.TabIndex = 11;
            this.btnSecretDisable.TabStop = true;
            this.btnSecretDisable.Text = "Disable";
            this.btnSecretDisable.UseVisualStyleBackColor = true;
            this.btnSecretDisable.Click += new System.EventHandler(this.SecretHandler);
            // 
            // btnSecretEnable
            // 
            this.btnSecretEnable.AutoSize = true;
            this.btnSecretEnable.Enabled = false;
            this.btnSecretEnable.Location = new System.Drawing.Point(283, 79);
            this.btnSecretEnable.Name = "btnSecretEnable";
            this.btnSecretEnable.Size = new System.Drawing.Size(58, 17);
            this.btnSecretEnable.TabIndex = 10;
            this.btnSecretEnable.Text = "Enable";
            this.btnSecretEnable.UseVisualStyleBackColor = true;
            this.btnSecretEnable.Click += new System.EventHandler(this.SecretHandler);
            // 
            // txtSecretPassword
            // 
            this.txtSecretPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtSecretPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecretPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretPassword.Location = new System.Drawing.Point(261, 22);
            this.txtSecretPassword.Name = "txtSecretPassword";
            this.txtSecretPassword.PasswordChar = '∗';
            this.txtSecretPassword.Size = new System.Drawing.Size(114, 26);
            this.txtSecretPassword.TabIndex = 9;
            // 
            // lblSecretPrompt
            // 
            this.lblSecretPrompt.AutoSize = true;
            this.lblSecretPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretPrompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSecretPrompt.Location = new System.Drawing.Point(52, 24);
            this.lblSecretPrompt.Name = "lblSecretPrompt";
            this.lblSecretPrompt.Size = new System.Drawing.Size(153, 20);
            this.lblSecretPrompt.TabIndex = 9;
            this.lblSecretPrompt.Text = "Enter the Passcode:";
            // 
            // TabUnknown
            // 
            this.TabUnknown.Location = new System.Drawing.Point(4, 22);
            this.TabUnknown.Name = "TabUnknown";
            this.TabUnknown.Padding = new System.Windows.Forms.Padding(3);
            this.TabUnknown.Size = new System.Drawing.Size(1044, 486);
            this.TabUnknown.TabIndex = 2;
            this.TabUnknown.Text = "...";
            this.TabUnknown.UseVisualStyleBackColor = true;
            // 
            // FrmMathre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1047, 526);
            this.Controls.Add(this.tabMathre);
            this.Controls.Add(this.mnuBaseLayer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuBaseLayer;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FrmMathre";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardShortcuts);
            this.mnuBaseLayer.ResumeLayout(false);
            this.mnuBaseLayer.PerformLayout();
            this.tabMathre.ResumeLayout(false);
            this.tabHelloWorld.ResumeLayout(false);
            this.tabHelloWorld.PerformLayout();
            this.grpHelloWorldGroupBox.ResumeLayout(false);
            this.grpHelloWorldGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).EndInit();
            this.tabMySchool.ResumeLayout(false);
            this.tabMySchool.PerformLayout();
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).EndInit();
            this.tabSecret.ResumeLayout(false);
            this.tabSecret.PerformLayout();
            this.grpSecret.ResumeLayout(false);
            this.grpSecret.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal MenuStrip mnuBaseLayer;
        internal ToolStripMenuItem mnuFile;
        internal ToolStripMenuItem mnuEdit;
        internal ToolStripMenuItem mnuSecret;
        internal ToolStripMenuItem mnuRecolor;
        internal ToolStripMenuItem mnuDarkMode;
        internal ToolStripMenuItem mnuTechnicolor;
        internal ToolStripMenuItem mnuRandomify;
        internal ToolStripMenuItem mnuView;
        internal TabControl tabMathre;
        internal TabPage tabHelloWorld;
        internal TabPage tabMySchool;
        internal Label lblHelloWorldTitle;
        internal TabPage TabUnknown;
        internal CustomGroupBox grpHelloWorldGroupBox;
        internal PictureBox picHelloWorldGerman;
        internal RadioButton btnHelloWorldFrench;
        internal PictureBox picHelloWorldEnglish;
        internal PictureBox picHelloWorldFrench;
        internal Button btnHelloWorldReset;
        internal RadioButton btnHelloWorldGerman;
        internal RadioButton btnHelloWorldEnglish;
        internal TabPage tabSecret;
        internal CustomGroupBox grpSecret;
        internal Label lblSecretPrompt;
        internal TextBox txtSecretPassword;
        internal Label lblSecretTitle;
        internal RadioButton btnSecretDisable;
        internal RadioButton btnSecretEnable;
        internal CustomGroupBox customGroupBox1;
        internal PictureBox picMySchoolMascot;
        internal Button btnMySchoolToggleMascot;
        internal Label lblMySchoolTitle;
        private Label lblMySchoolMascot;
        private ToolStripMenuItem mnuHelloWorld;
        private ToolStripMenuItem mnuMySchool;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuHelloWorldLanguage;
        private ToolStripMenuItem mnuHelloWorldLanguageEnglish;
        private ToolStripMenuItem mnuHelloWorldLanguageFrench;
        private ToolStripMenuItem mnuHelloWorldLanguageGerman;
        private ToolStripMenuItem mnuHelloWorldReset;
        private ToolStripMenuItem mnuMySchoolToggleMascot;
    }
}
