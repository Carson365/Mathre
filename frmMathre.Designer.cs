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


			this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMathre));
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabUnknown = new System.Windows.Forms.TabPage();
            this.tabSecret = new System.Windows.Forms.TabPage();
            this.lblSecretTitle = new System.Windows.Forms.Label();
            this.grpSecret = new Mathre.CustomGroupBox();
            this.btnSecretDisable = new System.Windows.Forms.RadioButton();
            this.btnSecretEnable = new System.Windows.Forms.RadioButton();
            this.txtSecretPassword = new System.Windows.Forms.TextBox();
            this.lblSecretPrompt = new System.Windows.Forms.Label();
            this.tabMyFavorites = new System.Windows.Forms.TabPage();
            this.customGroupBox1 = new Mathre.CustomGroupBox();
            this.customGroupBox2 = new Mathre.CustomGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customGroupBox3 = new Mathre.CustomGroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabRectangle = new System.Windows.Forms.TabPage();
            this.grpRectangleContainer = new Mathre.CustomGroupBox();
            this.grpRectangle = new Mathre.CustomGroupBox();
            this.lblRectangleTitle = new System.Windows.Forms.Label();
            this.grpRectangleControls = new Mathre.CustomGroupBox();
            this.btnRectangleEnter = new System.Windows.Forms.Button();
            this.lblRectangleAreaTitle = new System.Windows.Forms.Label();
            this.txtRectangleDimensions = new System.Windows.Forms.TextBox();
            this.lblRectangleDimensions = new System.Windows.Forms.Label();
            this.lblRectanglePerimiterTitle = new System.Windows.Forms.Label();
            this.lblRectangleArea = new System.Windows.Forms.Label();
            this.lblRectanglePerimeter = new System.Windows.Forms.Label();
            this.tabMySchool = new System.Windows.Forms.TabPage();
            this.lblMySchoolTitle = new System.Windows.Forms.Label();
            this.grpMySchool = new Mathre.CustomGroupBox();
            this.lblMySchoolMascot = new System.Windows.Forms.Label();
            this.picMySchoolMascot = new System.Windows.Forms.PictureBox();
            this.btnMySchoolToggleMascot = new System.Windows.Forms.Button();
            this.tabHelloWorld = new System.Windows.Forms.TabPage();
            this.grpHelloWorld = new Mathre.CustomGroupBox();
            this.picHelloWorldGerman = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldFrench = new System.Windows.Forms.RadioButton();
            this.picHelloWorldEnglish = new System.Windows.Forms.PictureBox();
            this.picHelloWorldFrench = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldReset = new System.Windows.Forms.Button();
            this.btnHelloWorldGerman = new System.Windows.Forms.RadioButton();
            this.btnHelloWorldEnglish = new System.Windows.Forms.RadioButton();
            this.lblHelloWorldTitle = new System.Windows.Forms.Label();
            this.tabMathre = new System.Windows.Forms.TabControl();
            this.lblRectangleError = new System.Windows.Forms.Label();
            this.mnuBaseLayer.SuspendLayout();
            this.tabSecret.SuspendLayout();
            this.grpSecret.SuspendLayout();
            this.tabMyFavorites.SuspendLayout();
            this.customGroupBox1.SuspendLayout();
            this.customGroupBox3.SuspendLayout();
            this.tabRectangle.SuspendLayout();
            this.grpRectangleContainer.SuspendLayout();
            this.grpRectangleControls.SuspendLayout();
            this.tabMySchool.SuspendLayout();
            this.grpMySchool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).BeginInit();
            this.tabHelloWorld.SuspendLayout();
            this.grpHelloWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).BeginInit();
            this.tabMathre.SuspendLayout();
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
            // 
            // mnuDarkMode
            // 
            this.mnuDarkMode.Enabled = false;
            this.mnuDarkMode.Name = "mnuDarkMode";
            this.mnuDarkMode.Size = new System.Drawing.Size(135, 22);
            this.mnuDarkMode.Text = "Dark Mode";
            // 
            // mnuTechnicolor
            // 
            this.mnuTechnicolor.Enabled = false;
            this.mnuTechnicolor.Name = "mnuTechnicolor";
            this.mnuTechnicolor.Size = new System.Drawing.Size(135, 22);
            this.mnuTechnicolor.Text = "Technicolor";
            // 
            // mnuRandomify
            // 
            this.mnuRandomify.Name = "mnuRandomify";
            this.mnuRandomify.Size = new System.Drawing.Size(132, 22);
            this.mnuRandomify.Text = "Randomify";
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
            this.mnuHelloWorldLanguage.Size = new System.Drawing.Size(126, 22);
            this.mnuHelloWorldLanguage.Text = "Language";
            // 
            // mnuHelloWorldLanguageEnglish
            // 
            this.mnuHelloWorldLanguageEnglish.Image = global::Mathre.My.Resources.Resources.EnglishAtScale;
            this.mnuHelloWorldLanguageEnglish.Name = "mnuHelloWorldLanguageEnglish";
            this.mnuHelloWorldLanguageEnglish.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageEnglish.Text = "English";
            // 
            // mnuHelloWorldLanguageFrench
            // 
            this.mnuHelloWorldLanguageFrench.Image = global::Mathre.My.Resources.Resources.French;
            this.mnuHelloWorldLanguageFrench.Name = "mnuHelloWorldLanguageFrench";
            this.mnuHelloWorldLanguageFrench.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageFrench.Text = "French";
            // 
            // mnuHelloWorldLanguageGerman
            // 
            this.mnuHelloWorldLanguageGerman.Image = global::Mathre.My.Resources.Resources.German;
            this.mnuHelloWorldLanguageGerman.Name = "mnuHelloWorldLanguageGerman";
            this.mnuHelloWorldLanguageGerman.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageGerman.Text = "German";
            // 
            // mnuHelloWorldReset
            // 
            this.mnuHelloWorldReset.Name = "mnuHelloWorldReset";
            this.mnuHelloWorldReset.Size = new System.Drawing.Size(126, 22);
            this.mnuHelloWorldReset.Text = "Reset";
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
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(184, 22);
            this.mnuExit.Text = "Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Enabled = false;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuView
            // 
            this.mnuView.Enabled = false;
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 24);
            this.mnuView.Text = "View";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "English.png");
            this.imageList1.Images.SetKeyName(1, "English1.png");
            this.imageList1.Images.SetKeyName(2, "EnterKey.png");
            this.imageList1.Images.SetKeyName(3, "French.png");
            this.imageList1.Images.SetKeyName(4, "German.png");
            this.imageList1.Images.SetKeyName(5, "RedRiver.png");
            // 
            // tabUnknown
            // 
            this.tabUnknown.Location = new System.Drawing.Point(4, 22);
            this.tabUnknown.Name = "tabUnknown";
            this.tabUnknown.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnknown.Size = new System.Drawing.Size(1044, 486);
            this.tabUnknown.TabIndex = 2;
            this.tabUnknown.Text = "...";
            this.tabUnknown.UseVisualStyleBackColor = true;
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
            this.lblSecretTitle.Location = new System.Drawing.Point(209, 71);
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
            this.grpSecret.Location = new System.Drawing.Point(309, 140);
            this.grpSecret.Name = "grpSecret";
            this.grpSecret.Size = new System.Drawing.Size(426, 105);
            this.grpSecret.TabIndex = 8;
            this.grpSecret.TabStop = false;
            // 
            // btnSecretDisable
            // 
            this.btnSecretDisable.AutoSize = true;
            this.btnSecretDisable.Checked = true;
            this.btnSecretDisable.Enabled = false;
            this.btnSecretDisable.Location = new System.Drawing.Point(85, 66);
            this.btnSecretDisable.Name = "btnSecretDisable";
            this.btnSecretDisable.Size = new System.Drawing.Size(60, 17);
            this.btnSecretDisable.TabIndex = 11;
            this.btnSecretDisable.TabStop = true;
            this.btnSecretDisable.Text = "Disable";
            this.btnSecretDisable.UseVisualStyleBackColor = true;
            // 
            // btnSecretEnable
            // 
            this.btnSecretEnable.AutoSize = true;
            this.btnSecretEnable.Enabled = false;
            this.btnSecretEnable.Location = new System.Drawing.Point(283, 67);
            this.btnSecretEnable.Name = "btnSecretEnable";
            this.btnSecretEnable.Size = new System.Drawing.Size(58, 17);
            this.btnSecretEnable.TabIndex = 10;
            this.btnSecretEnable.Text = "Enable";
            this.btnSecretEnable.UseVisualStyleBackColor = true;
            // 
            // txtSecretPassword
            // 
            this.txtSecretPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtSecretPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecretPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretPassword.Location = new System.Drawing.Point(261, 21);
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
            this.lblSecretPrompt.Location = new System.Drawing.Point(52, 23);
            this.lblSecretPrompt.Name = "lblSecretPrompt";
            this.lblSecretPrompt.Size = new System.Drawing.Size(153, 20);
            this.lblSecretPrompt.TabIndex = 9;
            this.lblSecretPrompt.Text = "Enter the Passcode:";
            // 
            // tabMyFavorites
            // 
            this.tabMyFavorites.Controls.Add(this.customGroupBox1);
            this.tabMyFavorites.Controls.Add(this.label1);
            this.tabMyFavorites.Controls.Add(this.customGroupBox3);
            this.tabMyFavorites.Location = new System.Drawing.Point(4, 22);
            this.tabMyFavorites.Name = "tabMyFavorites";
            this.tabMyFavorites.Size = new System.Drawing.Size(1044, 486);
            this.tabMyFavorites.TabIndex = 5;
            this.tabMyFavorites.Text = "My Favorites";
            this.tabMyFavorites.UseVisualStyleBackColor = true;
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.customGroupBox1.Controls.Add(this.customGroupBox2);
            this.customGroupBox1.Location = new System.Drawing.Point(309, 270);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(426, 136);
            this.customGroupBox1.TabIndex = 18;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox2";
            // 
            // customGroupBox2
            // 
            this.customGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customGroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.customGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.customGroupBox2.Location = new System.Drawing.Point(22, 19);
            this.customGroupBox2.MaximumSize = new System.Drawing.Size(100, 100);
            this.customGroupBox2.Name = "customGroupBox2";
            this.customGroupBox2.Size = new System.Drawing.Size(100, 100);
            this.customGroupBox2.TabIndex = 14;
            this.customGroupBox2.TabStop = false;
            this.customGroupBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "My Favorite __________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customGroupBox3
            // 
            this.customGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customGroupBox3.AutoSize = true;
            this.customGroupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.customGroupBox3.BorderColor = System.Drawing.Color.Black;
            this.customGroupBox3.Controls.Add(this.radioButton5);
            this.customGroupBox3.Controls.Add(this.radioButton4);
            this.customGroupBox3.Controls.Add(this.radioButton3);
            this.customGroupBox3.Controls.Add(this.radioButton2);
            this.customGroupBox3.Controls.Add(this.radioButton1);
            this.customGroupBox3.Location = new System.Drawing.Point(309, 149);
            this.customGroupBox3.Name = "customGroupBox3";
            this.customGroupBox3.Size = new System.Drawing.Size(426, 113);
            this.customGroupBox3.TabIndex = 16;
            this.customGroupBox3.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(176, 70);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(68, 24);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Movie";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(240, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 24);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Food";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(328, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 24);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Color";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(328, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 24);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hobby";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(20, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 24);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Actor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabRectangle
            // 
            this.tabRectangle.Controls.Add(this.grpRectangleContainer);
            this.tabRectangle.Controls.Add(this.lblRectangleTitle);
            this.tabRectangle.Controls.Add(this.grpRectangleControls);
            this.tabRectangle.Location = new System.Drawing.Point(4, 22);
            this.tabRectangle.Name = "tabRectangle";
            this.tabRectangle.Size = new System.Drawing.Size(1044, 486);
            this.tabRectangle.TabIndex = 4;
            this.tabRectangle.Text = "Rectangle Calculator";
            this.tabRectangle.UseVisualStyleBackColor = true;
            // 
            // grpRectangleContainer
            // 
            this.grpRectangleContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpRectangleContainer.BorderColor = System.Drawing.Color.Black;
            this.grpRectangleContainer.Controls.Add(this.lblRectangleError);
            this.grpRectangleContainer.Controls.Add(this.grpRectangle);
            this.grpRectangleContainer.Location = new System.Drawing.Point(309, 261);
            this.grpRectangleContainer.Name = "grpRectangleContainer";
            this.grpRectangleContainer.Size = new System.Drawing.Size(426, 136);
            this.grpRectangleContainer.TabIndex = 15;
            this.grpRectangleContainer.TabStop = false;
            this.grpRectangleContainer.Text = "customGroupBox2";
            // 
            // grpRectangle
            // 
            this.grpRectangle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpRectangle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.grpRectangle.BorderColor = System.Drawing.Color.Black;
            this.grpRectangle.Location = new System.Drawing.Point(163, 17);
            this.grpRectangle.MaximumSize = new System.Drawing.Size(100, 100);
            this.grpRectangle.Name = "grpRectangle";
            this.grpRectangle.Size = new System.Drawing.Size(100, 100);
            this.grpRectangle.TabIndex = 14;
            this.grpRectangle.TabStop = false;
            this.grpRectangle.Visible = false;
            // 
            // lblRectangleTitle
            // 
            this.lblRectangleTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleTitle.Location = new System.Drawing.Point(209, 71);
            this.lblRectangleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleTitle.Name = "lblRectangleTitle";
            this.lblRectangleTitle.Size = new System.Drawing.Size(626, 51);
            this.lblRectangleTitle.TabIndex = 11;
            this.lblRectangleTitle.Text = "Rectangle Calculator";
            this.lblRectangleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRectangleControls
            // 
            this.grpRectangleControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpRectangleControls.AutoSize = true;
            this.grpRectangleControls.BackColor = System.Drawing.SystemColors.Control;
            this.grpRectangleControls.BorderColor = System.Drawing.Color.Black;
            this.grpRectangleControls.Controls.Add(this.btnRectangleEnter);
            this.grpRectangleControls.Controls.Add(this.lblRectangleAreaTitle);
            this.grpRectangleControls.Controls.Add(this.txtRectangleDimensions);
            this.grpRectangleControls.Controls.Add(this.lblRectangleDimensions);
            this.grpRectangleControls.Controls.Add(this.lblRectanglePerimiterTitle);
            this.grpRectangleControls.Controls.Add(this.lblRectangleArea);
            this.grpRectangleControls.Controls.Add(this.lblRectanglePerimeter);
            this.grpRectangleControls.Location = new System.Drawing.Point(309, 140);
            this.grpRectangleControls.Name = "grpRectangleControls";
            this.grpRectangleControls.Size = new System.Drawing.Size(426, 105);
            this.grpRectangleControls.TabIndex = 10;
            this.grpRectangleControls.TabStop = false;
            // 
            // btnRectangleEnter
            // 
            this.btnRectangleEnter.BackColor = System.Drawing.SystemColors.Control;
            this.btnRectangleEnter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRectangleEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangleEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangleEnter.Image")));
            this.btnRectangleEnter.Location = new System.Drawing.Point(391, 13);
            this.btnRectangleEnter.Margin = new System.Windows.Forms.Padding(0);
            this.btnRectangleEnter.Name = "btnRectangleEnter";
            this.btnRectangleEnter.Size = new System.Drawing.Size(26, 26);
            this.btnRectangleEnter.TabIndex = 18;
            this.btnRectangleEnter.UseVisualStyleBackColor = false;
            // 
            // lblRectangleAreaTitle
            // 
            this.lblRectangleAreaTitle.AutoSize = true;
            this.lblRectangleAreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleAreaTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleAreaTitle.Location = new System.Drawing.Point(18, 42);
            this.lblRectangleAreaTitle.Name = "lblRectangleAreaTitle";
            this.lblRectangleAreaTitle.Size = new System.Drawing.Size(47, 20);
            this.lblRectangleAreaTitle.TabIndex = 14;
            this.lblRectangleAreaTitle.Text = "Area:";
            // 
            // txtRectangleDimensions
            // 
            this.txtRectangleDimensions.BackColor = System.Drawing.SystemColors.Window;
            this.txtRectangleDimensions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRectangleDimensions.Location = new System.Drawing.Point(217, 13);
            this.txtRectangleDimensions.Margin = new System.Windows.Forms.Padding(0);
            this.txtRectangleDimensions.Name = "txtRectangleDimensions";
            this.txtRectangleDimensions.Size = new System.Drawing.Size(175, 26);
            this.txtRectangleDimensions.TabIndex = 13;
            // 
            // lblRectangleDimensions
            // 
            this.lblRectangleDimensions.AutoSize = true;
            this.lblRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleDimensions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleDimensions.Location = new System.Drawing.Point(18, 16);
            this.lblRectangleDimensions.Name = "lblRectangleDimensions";
            this.lblRectangleDimensions.Size = new System.Drawing.Size(173, 20);
            this.lblRectangleDimensions.TabIndex = 9;
            this.lblRectangleDimensions.Text = "Rectangle Dimensions:";
            // 
            // lblRectanglePerimiterTitle
            // 
            this.lblRectanglePerimiterTitle.AutoSize = true;
            this.lblRectanglePerimiterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectanglePerimiterTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectanglePerimiterTitle.Location = new System.Drawing.Point(18, 68);
            this.lblRectanglePerimiterTitle.Name = "lblRectanglePerimiterTitle";
            this.lblRectanglePerimiterTitle.Size = new System.Drawing.Size(75, 20);
            this.lblRectanglePerimiterTitle.TabIndex = 15;
            this.lblRectanglePerimiterTitle.Text = "Perimiter:";
            // 
            // lblRectangleArea
            // 
            this.lblRectangleArea.AutoSize = true;
            this.lblRectangleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleArea.Location = new System.Drawing.Point(71, 45);
            this.lblRectangleArea.Name = "lblRectangleArea";
            this.lblRectangleArea.Size = new System.Drawing.Size(32, 15);
            this.lblRectangleArea.TabIndex = 16;
            this.lblRectangleArea.Text = "Area";
            this.lblRectangleArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRectanglePerimeter
            // 
            this.lblRectanglePerimeter.AutoSize = true;
            this.lblRectanglePerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectanglePerimeter.Location = new System.Drawing.Point(99, 71);
            this.lblRectanglePerimeter.Name = "lblRectanglePerimeter";
            this.lblRectanglePerimeter.Size = new System.Drawing.Size(61, 15);
            this.lblRectanglePerimeter.TabIndex = 17;
            this.lblRectanglePerimeter.Text = "Perimeter";
            this.lblRectanglePerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabMySchool
            // 
            this.tabMySchool.Controls.Add(this.lblMySchoolTitle);
            this.tabMySchool.Controls.Add(this.grpMySchool);
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
            this.lblMySchoolTitle.Location = new System.Drawing.Point(274, 71);
            this.lblMySchoolTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblMySchoolTitle.Name = "lblMySchoolTitle";
            this.lblMySchoolTitle.Size = new System.Drawing.Size(496, 51);
            this.lblMySchoolTitle.TabIndex = 8;
            this.lblMySchoolTitle.Text = "Red River High School";
            this.lblMySchoolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpMySchool
            // 
            this.grpMySchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMySchool.AutoSize = true;
            this.grpMySchool.BackColor = System.Drawing.SystemColors.Control;
            this.grpMySchool.BorderColor = System.Drawing.Color.Black;
            this.grpMySchool.Controls.Add(this.lblMySchoolMascot);
            this.grpMySchool.Controls.Add(this.picMySchoolMascot);
            this.grpMySchool.Controls.Add(this.btnMySchoolToggleMascot);
            this.grpMySchool.Location = new System.Drawing.Point(309, 140);
            this.grpMySchool.Name = "grpMySchool";
            this.grpMySchool.Size = new System.Drawing.Size(426, 105);
            this.grpMySchool.TabIndex = 9;
            this.grpMySchool.TabStop = false;
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
            // 
            // tabHelloWorld
            // 
            this.tabHelloWorld.BackColor = System.Drawing.Color.White;
            this.tabHelloWorld.Controls.Add(this.grpHelloWorld);
            this.tabHelloWorld.Controls.Add(this.lblHelloWorldTitle);
            this.tabHelloWorld.Location = new System.Drawing.Point(4, 22);
            this.tabHelloWorld.Margin = new System.Windows.Forms.Padding(0);
            this.tabHelloWorld.Name = "tabHelloWorld";
            this.tabHelloWorld.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelloWorld.Size = new System.Drawing.Size(1044, 486);
            this.tabHelloWorld.TabIndex = 0;
            this.tabHelloWorld.Text = "Hello World";
            // 
            // grpHelloWorld
            // 
            this.grpHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpHelloWorld.AutoSize = true;
            this.grpHelloWorld.BackColor = System.Drawing.SystemColors.Control;
            this.grpHelloWorld.BorderColor = System.Drawing.Color.Black;
            this.grpHelloWorld.Controls.Add(this.picHelloWorldGerman);
            this.grpHelloWorld.Controls.Add(this.btnHelloWorldFrench);
            this.grpHelloWorld.Controls.Add(this.picHelloWorldEnglish);
            this.grpHelloWorld.Controls.Add(this.picHelloWorldFrench);
            this.grpHelloWorld.Controls.Add(this.btnHelloWorldReset);
            this.grpHelloWorld.Controls.Add(this.btnHelloWorldGerman);
            this.grpHelloWorld.Controls.Add(this.btnHelloWorldEnglish);
            this.grpHelloWorld.Location = new System.Drawing.Point(309, 140);
            this.grpHelloWorld.Name = "grpHelloWorld";
            this.grpHelloWorld.Size = new System.Drawing.Size(426, 105);
            this.grpHelloWorld.TabIndex = 7;
            this.grpHelloWorld.TabStop = false;
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
            // 
            // lblHelloWorldTitle
            // 
            this.lblHelloWorldTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloWorldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldTitle.Location = new System.Drawing.Point(309, 71);
            this.lblHelloWorldTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblHelloWorldTitle.Name = "lblHelloWorldTitle";
            this.lblHelloWorldTitle.Size = new System.Drawing.Size(426, 51);
            this.lblHelloWorldTitle.TabIndex = 5;
            this.lblHelloWorldTitle.Text = "Hello World";
            this.lblHelloWorldTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMathre
            // 
            this.tabMathre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMathre.Controls.Add(this.tabHelloWorld);
            this.tabMathre.Controls.Add(this.tabMySchool);
            this.tabMathre.Controls.Add(this.tabRectangle);
            this.tabMathre.Controls.Add(this.tabMyFavorites);
            this.tabMathre.Controls.Add(this.tabSecret);
            this.tabMathre.Controls.Add(this.tabUnknown);
            this.tabMathre.Location = new System.Drawing.Point(0, 29);
            this.tabMathre.Margin = new System.Windows.Forms.Padding(0);
            this.tabMathre.Name = "tabMathre";
            this.tabMathre.Padding = new System.Drawing.Point(0, 0);
            this.tabMathre.SelectedIndex = 0;
            this.tabMathre.Size = new System.Drawing.Size(1052, 512);
            this.tabMathre.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMathre.TabIndex = 4;
            // 
            // lblRectangleError
            // 
            this.lblRectangleError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRectangleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleError.Location = new System.Drawing.Point(52, 43);
            this.lblRectangleError.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleError.Name = "lblRectangleError";
            this.lblRectangleError.Size = new System.Drawing.Size(322, 51);
            this.lblRectangleError.TabIndex = 16;
            this.lblRectangleError.Text = "Invalid Dimensions";
            this.lblRectangleError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmMathre";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.FormLoad);
            this.mnuBaseLayer.ResumeLayout(false);
            this.mnuBaseLayer.PerformLayout();
            this.tabSecret.ResumeLayout(false);
            this.tabSecret.PerformLayout();
            this.grpSecret.ResumeLayout(false);
            this.grpSecret.PerformLayout();
            this.tabMyFavorites.ResumeLayout(false);
            this.tabMyFavorites.PerformLayout();
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox3.ResumeLayout(false);
            this.customGroupBox3.PerformLayout();
            this.tabRectangle.ResumeLayout(false);
            this.tabRectangle.PerformLayout();
            this.grpRectangleContainer.ResumeLayout(false);
            this.grpRectangleControls.ResumeLayout(false);
            this.grpRectangleControls.PerformLayout();
            this.tabMySchool.ResumeLayout(false);
            this.tabMySchool.PerformLayout();
            this.grpMySchool.ResumeLayout(false);
            this.grpMySchool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).EndInit();
            this.tabHelloWorld.ResumeLayout(false);
            this.tabHelloWorld.PerformLayout();
            this.grpHelloWorld.ResumeLayout(false);
            this.grpHelloWorld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).EndInit();
            this.tabMathre.ResumeLayout(false);
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
        private ToolStripMenuItem mnuHelloWorld;
        private ToolStripMenuItem mnuMySchool;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuHelloWorldLanguage;
        private ToolStripMenuItem mnuHelloWorldLanguageEnglish;
        private ToolStripMenuItem mnuHelloWorldLanguageFrench;
        private ToolStripMenuItem mnuHelloWorldLanguageGerman;
        private ToolStripMenuItem mnuHelloWorldReset;
        private ToolStripMenuItem mnuMySchoolToggleMascot;
		private ImageList imageList1;
		internal TabPage tabUnknown;
		internal TabPage tabSecret;
		internal Label lblSecretTitle;
		internal CustomGroupBox grpSecret;
		internal RadioButton btnSecretDisable;
		internal RadioButton btnSecretEnable;
		internal TextBox txtSecretPassword;
		internal Label lblSecretPrompt;
		internal TabPage tabMyFavorites;
		private CustomGroupBox customGroupBox1;
		private CustomGroupBox customGroupBox2;
		internal Label label1;
		internal CustomGroupBox customGroupBox3;
		private RadioButton radioButton5;
		private RadioButton radioButton4;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		internal TabPage tabRectangle;
		private CustomGroupBox grpRectangleContainer;
		private CustomGroupBox grpRectangle;
		internal Label lblRectangleTitle;
		internal CustomGroupBox grpRectangleControls;
		private Button btnRectangleEnter;
		internal Label lblRectangleAreaTitle;
		internal TextBox txtRectangleDimensions;
		internal Label lblRectangleDimensions;
		internal Label lblRectanglePerimiterTitle;
		private Label lblRectangleArea;
		private Label lblRectanglePerimeter;
		internal TabPage tabMySchool;
		internal Label lblMySchoolTitle;
		internal CustomGroupBox grpMySchool;
		private Label lblMySchoolMascot;
		internal PictureBox picMySchoolMascot;
		internal Button btnMySchoolToggleMascot;
		internal TabPage tabHelloWorld;
		internal CustomGroupBox grpHelloWorld;
		internal PictureBox picHelloWorldGerman;
		internal RadioButton btnHelloWorldFrench;
		internal PictureBox picHelloWorldEnglish;
		internal PictureBox picHelloWorldFrench;
		internal Button btnHelloWorldReset;
		internal RadioButton btnHelloWorldGerman;
		internal RadioButton btnHelloWorldEnglish;
		internal Label lblHelloWorldTitle;
		internal TabControl tabMathre;
		internal Label lblRectangleError;
	}
}
