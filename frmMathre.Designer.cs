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
            mnuBaseLayer = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuLanguage = new ToolStripMenuItem();
            _mnuEnglish = new ToolStripMenuItem();
            _mnuEnglish.Click += new EventHandler(Buttons);
            _mnuFrench = new ToolStripMenuItem();
            _mnuFrench.Click += new EventHandler(Buttons);
            _mnuGerman = new ToolStripMenuItem();
            _mnuGerman.Click += new EventHandler(Buttons);
            _mnuReset = new ToolStripMenuItem();
            _mnuReset.Click += new EventHandler(Buttons);
            mnuSecret = new ToolStripMenuItem();
            mnuRecolor = new ToolStripMenuItem();
            mnuDarkMode = new ToolStripMenuItem();
            mnuTechnicolor = new ToolStripMenuItem();
            _mnuRandomify = new ToolStripMenuItem();
            _mnuRandomify.Click += new EventHandler(Buttons);
            _mnuExit = new ToolStripMenuItem();
            _mnuExit.Click += new EventHandler(Buttons);
            mnuEdit = new ToolStripMenuItem();
            mnuView = new ToolStripMenuItem();
            tabMathre = new TabControl();
            tabHelloWorld = new TabPage();
            grpHelloWorld = new CustomGroupBox();
            PictureBox1 = new PictureBox();
            btnFrench = new RadioButton();
            PictureBox2 = new PictureBox();
            PictureBox3 = new PictureBox();
            btnReset = new Button();
            btnGerman = new RadioButton();
            btnEnglish = new RadioButton();
            lblHelloWorld = new Label();
            tabMySchool = new TabPage();
            TabUnknown = new TabPage();
            tabSecret = new TabPage();
            lblSecretTitle = new Label();
            grpSecret = new CustomGroupBox();
            _btnSecretDisable = new RadioButton();
            _btnSecretDisable.Click += new EventHandler(SecretHandler);
            _btnSecretEnable = new RadioButton();
            _btnSecretEnable.Click += new EventHandler(SecretHandler);
            _btnSecretEnable.EnabledChanged += new EventHandler(SecretHandler);
            _btnSecretEnable.Click += new EventHandler(SecretHandler);
            _btnSecretEnable.EnabledChanged += new EventHandler(SecretHandler);
            txtSecretPassword = new TextBox();
            lblSecretPrompt = new Label();
            mnuBaseLayer.SuspendLayout();
            tabMathre.SuspendLayout();
            tabHelloWorld.SuspendLayout();
            grpHelloWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            tabSecret.SuspendLayout();
            grpSecret.SuspendLayout();
            SuspendLayout();
            // 
            // mnuBaseLayer
            // 
            mnuBaseLayer.BackColor = SystemColors.ControlLightLight;
            mnuBaseLayer.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit, mnuView });
            mnuBaseLayer.Location = new Point(0, 0);
            mnuBaseLayer.Name = "mnuBaseLayer";
            mnuBaseLayer.Padding = new Padding(0);
            mnuBaseLayer.RenderMode = ToolStripRenderMode.Professional;
            mnuBaseLayer.Size = new Size(1047, 24);
            mnuBaseLayer.TabIndex = 0;
            mnuBaseLayer.Text = "Menu";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuLanguage, _mnuReset, mnuSecret, _mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 24);
            mnuFile.Text = "File";
            // 
            // mnuLanguage
            // 
            mnuLanguage.DropDownItems.AddRange(new ToolStripItem[] { _mnuEnglish, _mnuFrench, _mnuGerman });
            mnuLanguage.Name = "mnuLanguage";
            mnuLanguage.Size = new Size(184, 22);
            mnuLanguage.Text = "Language";
            // 
            // mnuEnglish
            // 
            _mnuEnglish.Name = "_mnuEnglish";
            _mnuEnglish.Size = new Size(116, 22);
            _mnuEnglish.Text = "English";
            // 
            // mnuFrench
            // 
            _mnuFrench.Name = "_mnuFrench";
            _mnuFrench.Size = new Size(116, 22);
            _mnuFrench.Text = "French";
            // 
            // mnuGerman
            // 
            _mnuGerman.Name = "_mnuGerman";
            _mnuGerman.Size = new Size(116, 22);
            _mnuGerman.Text = "German";
            // 
            // mnuReset
            // 
            _mnuReset.Name = "_mnuReset";
            _mnuReset.Size = new Size(184, 22);
            _mnuReset.Text = "Reset";
            // 
            // mnuSecret
            // 
            mnuSecret.DropDownItems.AddRange(new ToolStripItem[] { mnuRecolor, _mnuRandomify });
            mnuSecret.Enabled = false;
            mnuSecret.Name = "mnuSecret";
            mnuSecret.Size = new Size(184, 22);
            mnuSecret.Text = "Super Secret Settings";
            // 
            // mnuRecolor
            // 
            mnuRecolor.DropDownItems.AddRange(new ToolStripItem[] { mnuDarkMode, mnuTechnicolor });
            mnuRecolor.Enabled = false;
            mnuRecolor.Name = "mnuRecolor";
            mnuRecolor.Size = new Size(132, 22);
            mnuRecolor.Text = "Recolor";
            // 
            // mnuDarkMode
            // 
            mnuDarkMode.Enabled = false;
            mnuDarkMode.Name = "mnuDarkMode";
            mnuDarkMode.Size = new Size(135, 22);
            mnuDarkMode.Text = "Dark Mode";
            // 
            // mnuTechnicolor
            // 
            mnuTechnicolor.Enabled = false;
            mnuTechnicolor.Name = "mnuTechnicolor";
            mnuTechnicolor.Size = new Size(135, 22);
            mnuTechnicolor.Text = "Technicolor";
            // 
            // mnuRandomify
            // 
            _mnuRandomify.Name = "_mnuRandomify";
            _mnuRandomify.Size = new Size(132, 22);
            _mnuRandomify.Text = "Randomify";
            // 
            // mnuExit
            // 
            _mnuExit.Name = "_mnuExit";
            _mnuExit.Size = new Size(184, 22);
            _mnuExit.Text = "Exit";
            // 
            // mnuEdit
            // 
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(39, 24);
            mnuEdit.Text = "Edit";
            // 
            // mnuView
            // 
            mnuView.Enabled = false;
            mnuView.Name = "mnuView";
            mnuView.Size = new Size(44, 24);
            mnuView.Text = "View";
            // 
            // tabMathre
            // 
            tabMathre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            tabMathre.Controls.Add(tabHelloWorld);
            tabMathre.Controls.Add(tabMySchool);
            tabMathre.Controls.Add(TabUnknown);
            tabMathre.Controls.Add(tabSecret);
            tabMathre.Location = new Point(0, 29);
            tabMathre.Margin = new Padding(0);
            tabMathre.Name = "tabMathre";
            tabMathre.Padding = new Point(0, 0);
            tabMathre.SelectedIndex = 0;
            tabMathre.Size = new Size(1052, 512);
            tabMathre.SizeMode = TabSizeMode.FillToRight;
            tabMathre.TabIndex = 4;
            // 
            // tabHelloWorld
            // 
            tabHelloWorld.Controls.Add(grpHelloWorld);
            tabHelloWorld.Controls.Add(lblHelloWorld);
            tabHelloWorld.Location = new Point(4, 22);
            tabHelloWorld.Margin = new Padding(0);
            tabHelloWorld.Name = "tabHelloWorld";
            tabHelloWorld.Padding = new Padding(3);
            tabHelloWorld.Size = new Size(1044, 486);
            tabHelloWorld.TabIndex = 0;
            tabHelloWorld.Text = "Hello World";
            tabHelloWorld.UseVisualStyleBackColor = true;
            // 
            // grpHelloWorld
            // 
            grpHelloWorld.Anchor = AnchorStyles.None;
            grpHelloWorld.AutoSize = true;
            grpHelloWorld.BackColor = SystemColors.Control;
            grpHelloWorld.BorderColor = Color.Black;
            grpHelloWorld.Controls.Add(PictureBox1);
            grpHelloWorld.Controls.Add(btnFrench);
            grpHelloWorld.Controls.Add(PictureBox2);
            grpHelloWorld.Controls.Add(PictureBox3);
            grpHelloWorld.Controls.Add(btnReset);
            grpHelloWorld.Controls.Add(btnGerman);
            grpHelloWorld.Controls.Add(btnEnglish);
            grpHelloWorld.Location = new Point(309, 191);
            grpHelloWorld.Name = "grpHelloWorld";
            grpHelloWorld.Size = new Size(426, 105);
            grpHelloWorld.TabIndex = 7;
            grpHelloWorld.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.German;
            PictureBox1.Location = new Point(293, 21);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(31, 25);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 13;
            PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.English;
            PictureBox2.Location = new Point(34, 21);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(31, 25);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 12;
            PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            PictureBox3.Image = My.Resources.Resources.French;
            PictureBox3.Location = new Point(164, 21);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(31, 25);
            PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox3.TabIndex = 11;
            PictureBox3.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(169, 61);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnGerman
            // 
            btnGerman.AutoSize = true;
            btnGerman.Location = new Point(330, 25);
            btnGerman.Name = "btnGerman";
            btnGerman.Size = new Size(62, 17);
            btnGerman.TabIndex = 8;
            btnGerman.Text = "German";
            btnGerman.UseVisualStyleBackColor = true;
            // 
            // btnEnglish
            // 
            btnEnglish.AutoSize = true;
            btnEnglish.Checked = true;
            btnEnglish.Location = new Point(71, 25);
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Size = new Size(59, 17);
            btnEnglish.TabIndex = 7;
            btnEnglish.TabStop = true;
            btnEnglish.Text = "English";
            btnEnglish.UseVisualStyleBackColor = true;
            // 
            // btnFrench
            // 
            btnFrench.AutoSize = true;
            btnFrench.Location = new Point(201, 25);
            btnFrench.Name = "btnFrench";
            btnFrench.Size = new Size(58, 17);
            btnFrench.TabIndex = 10;
            btnFrench.Text = "French";
            btnFrench.UseVisualStyleBackColor = true;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.Anchor = AnchorStyles.None;
            lblHelloWorld.Font = new Font("Microsoft Sans Serif", 32.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblHelloWorld.Location = new Point(309, 122);
            lblHelloWorld.Margin = new Padding(0);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(426, 51);
            lblHelloWorld.TabIndex = 5;
            lblHelloWorld.Text = "Hello World";
            lblHelloWorld.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabMySchool
            // 
            tabMySchool.Location = new Point(4, 22);
            tabMySchool.Name = "tabMySchool";
            tabMySchool.Padding = new Padding(3);
            tabMySchool.Size = new Size(1044, 486);
            tabMySchool.TabIndex = 1;
            tabMySchool.Text = "My School";
            tabMySchool.UseVisualStyleBackColor = true;
            // 
            // TabUnknown
            // 
            TabUnknown.Location = new Point(4, 22);
            TabUnknown.Name = "TabUnknown";
            TabUnknown.Padding = new Padding(3);
            TabUnknown.Size = new Size(1044, 486);
            TabUnknown.TabIndex = 2;
            TabUnknown.Text = "...";
            TabUnknown.UseVisualStyleBackColor = true;
            // 
            // tabSecret
            // 
            tabSecret.Controls.Add(lblSecretTitle);
            tabSecret.Controls.Add(grpSecret);
            tabSecret.Location = new Point(4, 22);
            tabSecret.Name = "tabSecret";
            tabSecret.Size = new Size(1044, 486);
            tabSecret.TabIndex = 3;
            tabSecret.Text = "Secret Settings Page";
            tabSecret.UseVisualStyleBackColor = true;
            // 
            // lblSecretTitle
            // 
            lblSecretTitle.Anchor = AnchorStyles.None;
            lblSecretTitle.Font = new Font("Microsoft Sans Serif", 32.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSecretTitle.Location = new Point(209, 122);
            lblSecretTitle.Margin = new Padding(0);
            lblSecretTitle.Name = "lblSecretTitle";
            lblSecretTitle.Size = new Size(626, 51);
            lblSecretTitle.TabIndex = 9;
            lblSecretTitle.Text = "Enable Super Secret Settings";
            lblSecretTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpSecret
            // 
            grpSecret.Anchor = AnchorStyles.None;
            grpSecret.AutoSize = true;
            grpSecret.BackColor = SystemColors.Control;
            grpSecret.BorderColor = Color.Black;
            grpSecret.Controls.Add(_btnSecretDisable);
            grpSecret.Controls.Add(_btnSecretEnable);
            grpSecret.Controls.Add(txtSecretPassword);
            grpSecret.Controls.Add(lblSecretPrompt);
            grpSecret.Location = new Point(309, 191);
            grpSecret.Name = "grpSecret";
            grpSecret.Size = new Size(426, 119);
            grpSecret.TabIndex = 8;
            grpSecret.TabStop = false;
            // 
            // btnSecretDisable
            // 
            _btnSecretDisable.AutoSize = true;
            _btnSecretDisable.Checked = true;
            _btnSecretDisable.Enabled = false;
            _btnSecretDisable.Location = new Point(85, 78);
            _btnSecretDisable.Name = "_btnSecretDisable";
            _btnSecretDisable.Size = new Size(60, 17);
            _btnSecretDisable.TabIndex = 11;
            _btnSecretDisable.TabStop = true;
            _btnSecretDisable.Text = "Disable";
            _btnSecretDisable.UseVisualStyleBackColor = true;
            // 
            // btnSecretEnable
            // 
            _btnSecretEnable.AutoSize = true;
            _btnSecretEnable.Enabled = false;
            _btnSecretEnable.Location = new Point(283, 79);
            _btnSecretEnable.Name = "_btnSecretEnable";
            _btnSecretEnable.Size = new Size(58, 17);
            _btnSecretEnable.TabIndex = 10;
            _btnSecretEnable.Text = "Enable";
            _btnSecretEnable.UseVisualStyleBackColor = true;
            // 
            // txtSecretPassword
            // 
            txtSecretPassword.BackColor = SystemColors.Window;
            txtSecretPassword.BorderStyle = BorderStyle.FixedSingle;
            txtSecretPassword.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            txtSecretPassword.Location = new Point(261, 22);
            txtSecretPassword.Name = "txtSecretPassword";
            txtSecretPassword.PasswordChar = '∗';
            txtSecretPassword.Size = new Size(114, 26);
            txtSecretPassword.TabIndex = 9;
            // 
            // lblSecretPrompt
            // 
            lblSecretPrompt.AutoSize = true;
            lblSecretPrompt.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblSecretPrompt.Location = new Point(52, 24);
            lblSecretPrompt.Name = "lblSecretPrompt";
            lblSecretPrompt.Size = new Size(153, 20);
            lblSecretPrompt.TabIndex = 9;
            lblSecretPrompt.Text = "Enter the Passcode:";
            // 
            // FrmMathre
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1047, 526);
            Controls.Add(tabMathre);
            Controls.Add(mnuBaseLayer);
            ForeColor = SystemColors.ControlText;
            KeyPreview = true;
            MainMenuStrip = mnuBaseLayer;
            MinimumSize = new Size(500, 350);
            Name = "FrmMathre";
            Text = "Hello World";
            mnuBaseLayer.ResumeLayout(false);
            mnuBaseLayer.PerformLayout();
            tabMathre.ResumeLayout(false);
            tabHelloWorld.ResumeLayout(false);
            tabHelloWorld.PerformLayout();
            grpHelloWorld.ResumeLayout(false);
            grpHelloWorld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            tabSecret.ResumeLayout(false);
            tabSecret.PerformLayout();
            grpSecret.ResumeLayout(false);
            grpSecret.PerformLayout();
            Load += new EventHandler(FormLoad);
            KeyDown += new KeyEventHandler(KeyboardShortcuts);
            ResumeLayout(false);
            PerformLayout();
        }

        internal MenuStrip mnuBaseLayer;
        internal ToolStripMenuItem mnuFile;
        internal ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem _mnuReset;

        internal ToolStripMenuItem mnuReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _mnuReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mnuReset != null)
                {
                    _mnuReset.Click -= Buttons;
                }

                _mnuReset = value;
                if (_mnuReset != null)
                {
                    _mnuReset.Click += Buttons;
                }
            }
        }

        internal ToolStripMenuItem mnuSecret;
        internal ToolStripMenuItem mnuRecolor;
        internal ToolStripMenuItem mnuDarkMode;
        internal ToolStripMenuItem mnuTechnicolor;
        private ToolStripMenuItem _mnuRandomify;

        internal ToolStripMenuItem mnuRandomify
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _mnuRandomify;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mnuRandomify != null)
                {
                    _mnuRandomify.Click -= Buttons;
                }

                _mnuRandomify = value;
                if (_mnuRandomify != null)
                {
                    _mnuRandomify.Click += Buttons;
                }
            }
        }

        internal ToolStripMenuItem mnuView;
        private ToolStripMenuItem _mnuExit;

        internal ToolStripMenuItem mnuExit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _mnuExit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mnuExit != null)
                {
                    _mnuExit.Click -= Buttons;
                }

                _mnuExit = value;
                if (_mnuExit != null)
                {
                    _mnuExit.Click += Buttons;
                }
            }
        }

        internal TabControl tabMathre;
        internal TabPage tabHelloWorld;
        internal TabPage tabMySchool;
        internal Label lblHelloWorld;
        internal TabPage TabUnknown;
        internal ToolStripMenuItem mnuLanguage;
        private ToolStripMenuItem _mnuEnglish;

        internal ToolStripMenuItem mnuEnglish
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _mnuEnglish;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mnuEnglish != null)
                {
                    _mnuEnglish.Click -= Buttons;
                }

                _mnuEnglish = value;
                if (_mnuEnglish != null)
                {
                    _mnuEnglish.Click += Buttons;
                }
            }
        }

        private ToolStripMenuItem _mnuFrench;

        internal ToolStripMenuItem mnuFrench
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _mnuFrench;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mnuFrench != null)
                {
                    _mnuFrench.Click -= Buttons;
                }

                _mnuFrench = value;
                if (_mnuFrench != null)
                {
                    _mnuFrench.Click += Buttons;
                }
            }
        }

        private ToolStripMenuItem _mnuGerman;

        internal ToolStripMenuItem mnuGerman
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _mnuGerman;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mnuGerman != null)
                {
                    _mnuGerman.Click -= Buttons;
                }

                _mnuGerman = value;
                if (_mnuGerman != null)
                {
                    _mnuGerman.Click += Buttons;
                }
            }
        }

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
        private RadioButton _btnSecretDisable;

        internal RadioButton btnSecretDisable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSecretDisable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSecretDisable != null)
                {
                    _btnSecretDisable.Click -= SecretHandler;
                }

                _btnSecretDisable = value;
                if (_btnSecretDisable != null)
                {
                    _btnSecretDisable.Click += SecretHandler;
                }
            }
        }

        private RadioButton _btnSecretEnable;

        internal RadioButton btnSecretEnable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSecretEnable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSecretEnable != null)
                {
                    _btnSecretEnable.Click -= SecretHandler;
                    _btnSecretEnable.EnabledChanged -= SecretHandler;
                }

                _btnSecretEnable = value;
                if (_btnSecretEnable != null)
                {
                    _btnSecretEnable.Click += SecretHandler;
                    _btnSecretEnable.EnabledChanged += SecretHandler;
                }
            }
        }
    }
}