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
            this.mnuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTechnicolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRandomify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMathre = new System.Windows.Forms.TabControl();
            this.tabHelloWorld = new System.Windows.Forms.TabPage();
            this.grpHelloWorld = new Mathre.CustomGroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFrench = new System.Windows.Forms.RadioButton();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.RadioButton();
            this.btnEnglish = new System.Windows.Forms.RadioButton();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.tabMySchool = new System.Windows.Forms.TabPage();
            this.TabUnknown = new System.Windows.Forms.TabPage();
            this.tabSecret = new System.Windows.Forms.TabPage();
            this.lblSecretTitle = new System.Windows.Forms.Label();
            this.grpSecret = new Mathre.CustomGroupBox();
            this.btnSecretDisable = new System.Windows.Forms.RadioButton();
            this.btnSecretEnable = new System.Windows.Forms.RadioButton();
            this.txtSecretPassword = new System.Windows.Forms.TextBox();
            this.lblSecretPrompt = new System.Windows.Forms.Label();
            this.mnuBaseLayer.SuspendLayout();
            this.tabMathre.SuspendLayout();
            this.tabHelloWorld.SuspendLayout();
            this.grpHelloWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
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
            this.mnuLanguage,
            this.mnuReset,
            this.mnuSecret});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuLanguage
            // 
            this.mnuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnglish,
            this.mnuFrench,
            this.mnuGerman});
            this.mnuLanguage.Name = "mnuLanguage";
            this.mnuLanguage.Size = new System.Drawing.Size(184, 22);
            this.mnuLanguage.Text = "Language";
            // 
            // mnuEnglish
            // 
            this.mnuEnglish.Name = "mnuEnglish";
            this.mnuEnglish.Size = new System.Drawing.Size(180, 22);
            this.mnuEnglish.Text = "English";
            this.mnuEnglish.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuFrench
            // 
            this.mnuFrench.Name = "mnuFrench";
            this.mnuFrench.Size = new System.Drawing.Size(180, 22);
            this.mnuFrench.Text = "French";
            this.mnuFrench.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuGerman
            // 
            this.mnuGerman.Name = "mnuGerman";
            this.mnuGerman.Size = new System.Drawing.Size(180, 22);
            this.mnuGerman.Text = "German";
            this.mnuGerman.Click += new System.EventHandler(this.Buttons);
            // 
            // _mnuReset
            // 
            this.mnuReset.Name = "_mnuReset";
            this.mnuReset.Size = new System.Drawing.Size(184, 22);
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.Buttons);
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
            // _mnuRandomify
            // 
            this.mnuRandomify.Name = "_mnuRandomify";
            this.mnuRandomify.Size = new System.Drawing.Size(132, 22);
            this.mnuRandomify.Text = "Randomify";
            this.mnuRandomify.Click += new System.EventHandler(this.Buttons);
            // 
            // mnuEdit
            // 
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
            // tabMathre
            // 
            this.tabMathre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMathre.Controls.Add(this.tabHelloWorld);
            this.tabMathre.Controls.Add(this.tabMySchool);
            this.tabMathre.Controls.Add(this.TabUnknown);
            this.tabMathre.Controls.Add(this.tabSecret);
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
            this.tabHelloWorld.Controls.Add(this.grpHelloWorld);
            this.tabHelloWorld.Controls.Add(this.lblHelloWorld);
            this.tabHelloWorld.Location = new System.Drawing.Point(4, 22);
            this.tabHelloWorld.Margin = new System.Windows.Forms.Padding(0);
            this.tabHelloWorld.Name = "tabHelloWorld";
            this.tabHelloWorld.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelloWorld.Size = new System.Drawing.Size(1044, 486);
            this.tabHelloWorld.TabIndex = 0;
            this.tabHelloWorld.Text = "Hello World";
            this.tabHelloWorld.UseVisualStyleBackColor = true;
            // 
            // grpHelloWorld
            // 
            this.grpHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpHelloWorld.AutoSize = true;
            this.grpHelloWorld.BackColor = System.Drawing.SystemColors.Control;
            this.grpHelloWorld.BorderColor = System.Drawing.Color.Black;
            this.grpHelloWorld.Controls.Add(this.PictureBox1);
            this.grpHelloWorld.Controls.Add(this.btnFrench);
            this.grpHelloWorld.Controls.Add(this.PictureBox2);
            this.grpHelloWorld.Controls.Add(this.PictureBox3);
            this.grpHelloWorld.Controls.Add(this.btnReset);
            this.grpHelloWorld.Controls.Add(this.btnGerman);
            this.grpHelloWorld.Controls.Add(this.btnEnglish);
            this.grpHelloWorld.Location = new System.Drawing.Point(309, 191);
            this.grpHelloWorld.Name = "grpHelloWorld";
            this.grpHelloWorld.Size = new System.Drawing.Size(426, 105);
            this.grpHelloWorld.TabIndex = 7;
            this.grpHelloWorld.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Mathre.My.Resources.Resources.German;
            this.PictureBox1.Location = new System.Drawing.Point(293, 21);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(31, 25);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 13;
            this.PictureBox1.TabStop = false;
            // 
            // btnFrench
            // 
            this.btnFrench.AutoSize = true;
            this.btnFrench.Location = new System.Drawing.Point(201, 25);
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.Size = new System.Drawing.Size(58, 17);
            this.btnFrench.TabIndex = 10;
            this.btnFrench.Text = "French";
            this.btnFrench.UseVisualStyleBackColor = true;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Mathre.My.Resources.Resources.English;
            this.PictureBox2.Location = new System.Drawing.Point(34, 21);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(31, 25);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::Mathre.My.Resources.Resources.French;
            this.PictureBox3.Location = new System.Drawing.Point(164, 21);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(31, 25);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 11;
            this.PictureBox3.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnGerman
            // 
            this.btnGerman.AutoSize = true;
            this.btnGerman.Location = new System.Drawing.Point(330, 25);
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.Size = new System.Drawing.Size(62, 17);
            this.btnGerman.TabIndex = 8;
            this.btnGerman.Text = "German";
            this.btnGerman.UseVisualStyleBackColor = true;
            // 
            // btnEnglish
            // 
            this.btnEnglish.AutoSize = true;
            this.btnEnglish.Checked = true;
            this.btnEnglish.Location = new System.Drawing.Point(71, 25);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(59, 17);
            this.btnEnglish.TabIndex = 7;
            this.btnEnglish.TabStop = true;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(309, 122);
            this.lblHelloWorld.Margin = new System.Windows.Forms.Padding(0);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(426, 51);
            this.lblHelloWorld.TabIndex = 5;
            this.lblHelloWorld.Text = "Hello World";
            this.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMySchool
            // 
            this.tabMySchool.Location = new System.Drawing.Point(4, 22);
            this.tabMySchool.Name = "tabMySchool";
            this.tabMySchool.Padding = new System.Windows.Forms.Padding(3);
            this.tabMySchool.Size = new System.Drawing.Size(1044, 486);
            this.tabMySchool.TabIndex = 1;
            this.tabMySchool.Text = "My School";
            this.tabMySchool.UseVisualStyleBackColor = true;
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
            // _btnSecretDisable
            // 
            this.btnSecretDisable.AutoSize = true;
            this.btnSecretDisable.Checked = true;
            this.btnSecretDisable.Enabled = false;
            this.btnSecretDisable.Location = new System.Drawing.Point(85, 78);
            this.btnSecretDisable.Name = "_btnSecretDisable";
            this.btnSecretDisable.Size = new System.Drawing.Size(60, 17);
            this.btnSecretDisable.TabIndex = 11;
            this.btnSecretDisable.TabStop = true;
            this.btnSecretDisable.Text = "Disable";
            this.btnSecretDisable.UseVisualStyleBackColor = true;
            this.btnSecretDisable.Click += new System.EventHandler(this.SecretHandler);
            // 
            // _btnSecretEnable
            // 
            this.btnSecretEnable.AutoSize = true;
            this.btnSecretEnable.Enabled = false;
            this.btnSecretEnable.Location = new System.Drawing.Point(283, 79);
            this.btnSecretEnable.Name = "_btnSecretEnable";
            this.btnSecretEnable.Size = new System.Drawing.Size(58, 17);
            this.btnSecretEnable.TabIndex = 10;
            this.btnSecretEnable.Text = "Enable";
            this.btnSecretEnable.UseVisualStyleBackColor = true;
            this.btnSecretEnable.EnabledChanged += new System.EventHandler(this.SecretHandler);
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
            this.lblSecretPrompt.Location = new System.Drawing.Point(52, 24);
            this.lblSecretPrompt.Name = "lblSecretPrompt";
            this.lblSecretPrompt.Size = new System.Drawing.Size(153, 20);
            this.lblSecretPrompt.TabIndex = 9;
            this.lblSecretPrompt.Text = "Enter the Passcode:";
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
            this.grpHelloWorld.ResumeLayout(false);
            this.grpHelloWorld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
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
        internal ToolStripMenuItem mnuReset;
        internal ToolStripMenuItem mnuSecret;
        internal ToolStripMenuItem mnuRecolor;
        internal ToolStripMenuItem mnuDarkMode;
        internal ToolStripMenuItem mnuTechnicolor;
        internal ToolStripMenuItem mnuRandomify;
        internal ToolStripMenuItem mnuView;
        internal TabControl tabMathre;
        internal TabPage tabHelloWorld;
        internal TabPage tabMySchool;
        internal Label lblHelloWorld;
        internal TabPage TabUnknown;
        internal ToolStripMenuItem mnuLanguage;
        internal ToolStripMenuItem mnuEnglish;
        internal ToolStripMenuItem mnuFrench;
        internal ToolStripMenuItem mnuGerman;
        internal CustomGroupBox grpHelloWorld;
        internal PictureBox PictureBox1;
        internal RadioButton btnFrench;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox3;
        internal Button btnReset;
        internal RadioButton btnGerman;
        internal RadioButton btnEnglish;
        internal TabPage tabSecret;
        internal CustomGroupBox grpSecret;
        internal Label lblSecretPrompt;
        internal TextBox txtSecretPassword;
        internal Label lblSecretTitle;
        internal RadioButton btnSecretDisable;
        internal RadioButton btnSecretEnable;
    }
}