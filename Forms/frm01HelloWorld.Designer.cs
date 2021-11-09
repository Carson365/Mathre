﻿
namespace Mathre
{
	partial class FrmHelloWorld
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblHelloWorldTitle = new System.Windows.Forms.Label();
            this.pnlHelloWorld = new System.Windows.Forms.Panel();
            this.picHelloWorldGerman = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldFrench = new System.Windows.Forms.RadioButton();
            this.btnHelloWorldEnglish = new System.Windows.Forms.RadioButton();
            this.picHelloWorldEnglish = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldGerman = new System.Windows.Forms.RadioButton();
            this.picHelloWorldFrench = new System.Windows.Forms.PictureBox();
            this.btnHelloWorldReset = new System.Windows.Forms.Button();
            this.pnlHelloWorldFrame = new System.Windows.Forms.Panel();
            this.pnlHelloWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).BeginInit();
            this.pnlHelloWorldFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorldTitle
            // 
            this.lblHelloWorldTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloWorldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHelloWorldTitle.Location = new System.Drawing.Point(335, 110);
            this.lblHelloWorldTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblHelloWorldTitle.Name = "lblHelloWorldTitle";
            this.lblHelloWorldTitle.Size = new System.Drawing.Size(497, 59);
            this.lblHelloWorldTitle.TabIndex = 29;
            this.lblHelloWorldTitle.Text = "Hello World";
            this.lblHelloWorldTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHelloWorld
            // 
            this.pnlHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHelloWorld.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHelloWorld.Controls.Add(this.picHelloWorldGerman);
            this.pnlHelloWorld.Controls.Add(this.btnHelloWorldFrench);
            this.pnlHelloWorld.Controls.Add(this.btnHelloWorldEnglish);
            this.pnlHelloWorld.Controls.Add(this.picHelloWorldEnglish);
            this.pnlHelloWorld.Controls.Add(this.btnHelloWorldGerman);
            this.pnlHelloWorld.Controls.Add(this.picHelloWorldFrench);
            this.pnlHelloWorld.Controls.Add(this.btnHelloWorldReset);
            this.pnlHelloWorld.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlHelloWorld.Location = new System.Drawing.Point(335, 190);
            this.pnlHelloWorld.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHelloWorld.Name = "pnlHelloWorld";
            this.pnlHelloWorld.Size = new System.Drawing.Size(497, 121);
            this.pnlHelloWorld.TabIndex = 30;
            // 
            // picHelloWorldGerman
            // 
            this.picHelloWorldGerman.Image = global::Mathre.Properties.Resources.German;
            this.picHelloWorldGerman.Location = new System.Drawing.Point(342, 24);
            this.picHelloWorldGerman.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHelloWorldGerman.Name = "picHelloWorldGerman";
            this.picHelloWorldGerman.Size = new System.Drawing.Size(36, 29);
            this.picHelloWorldGerman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldGerman.TabIndex = 13;
            this.picHelloWorldGerman.TabStop = false;
            // 
            // btnHelloWorldFrench
            // 
            this.btnHelloWorldFrench.AutoSize = true;
            this.btnHelloWorldFrench.Location = new System.Drawing.Point(234, 29);
            this.btnHelloWorldFrench.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHelloWorldFrench.Name = "btnHelloWorldFrench";
            this.btnHelloWorldFrench.Size = new System.Drawing.Size(61, 19);
            this.btnHelloWorldFrench.TabIndex = 10;
            this.btnHelloWorldFrench.Text = "French";
            this.btnHelloWorldFrench.UseVisualStyleBackColor = true;
            // 
            // btnHelloWorldEnglish
            // 
            this.btnHelloWorldEnglish.AutoSize = true;
            this.btnHelloWorldEnglish.Checked = true;
            this.btnHelloWorldEnglish.Location = new System.Drawing.Point(83, 29);
            this.btnHelloWorldEnglish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHelloWorldEnglish.Name = "btnHelloWorldEnglish";
            this.btnHelloWorldEnglish.Size = new System.Drawing.Size(63, 19);
            this.btnHelloWorldEnglish.TabIndex = 7;
            this.btnHelloWorldEnglish.TabStop = true;
            this.btnHelloWorldEnglish.Text = "English";
            this.btnHelloWorldEnglish.UseVisualStyleBackColor = true;
            // 
            // picHelloWorldEnglish
            // 
            this.picHelloWorldEnglish.Image = global::Mathre.Properties.Resources.English;
            this.picHelloWorldEnglish.Location = new System.Drawing.Point(40, 24);
            this.picHelloWorldEnglish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHelloWorldEnglish.Name = "picHelloWorldEnglish";
            this.picHelloWorldEnglish.Size = new System.Drawing.Size(36, 29);
            this.picHelloWorldEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldEnglish.TabIndex = 12;
            this.picHelloWorldEnglish.TabStop = false;
            // 
            // btnHelloWorldGerman
            // 
            this.btnHelloWorldGerman.AutoSize = true;
            this.btnHelloWorldGerman.Location = new System.Drawing.Point(385, 29);
            this.btnHelloWorldGerman.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHelloWorldGerman.Name = "btnHelloWorldGerman";
            this.btnHelloWorldGerman.Size = new System.Drawing.Size(67, 19);
            this.btnHelloWorldGerman.TabIndex = 8;
            this.btnHelloWorldGerman.Text = "German";
            this.btnHelloWorldGerman.UseVisualStyleBackColor = true;
            // 
            // picHelloWorldFrench
            // 
            this.picHelloWorldFrench.Image = global::Mathre.Properties.Resources.French;
            this.picHelloWorldFrench.Location = new System.Drawing.Point(191, 24);
            this.picHelloWorldFrench.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHelloWorldFrench.Name = "picHelloWorldFrench";
            this.picHelloWorldFrench.Size = new System.Drawing.Size(36, 29);
            this.picHelloWorldFrench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelloWorldFrench.TabIndex = 11;
            this.picHelloWorldFrench.TabStop = false;
            // 
            // btnHelloWorldReset
            // 
            this.btnHelloWorldReset.Location = new System.Drawing.Point(197, 70);
            this.btnHelloWorldReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHelloWorldReset.Name = "btnHelloWorldReset";
            this.btnHelloWorldReset.Size = new System.Drawing.Size(88, 27);
            this.btnHelloWorldReset.TabIndex = 9;
            this.btnHelloWorldReset.Text = "Reset";
            this.btnHelloWorldReset.UseVisualStyleBackColor = true;
            // 
            // pnlHelloWorldFrame
            // 
            this.pnlHelloWorldFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHelloWorldFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlHelloWorldFrame.Controls.Add(this.pnlHelloWorld);
            this.pnlHelloWorldFrame.Controls.Add(this.lblHelloWorldTitle);
            this.pnlHelloWorldFrame.Location = new System.Drawing.Point(-9, -23);
            this.pnlHelloWorldFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHelloWorldFrame.Name = "pnlHelloWorldFrame";
            this.pnlHelloWorldFrame.Size = new System.Drawing.Size(1167, 577);
            this.pnlHelloWorldFrame.TabIndex = 31;
            // 
            // FrmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1148, 532);
            this.Controls.Add(this.pnlHelloWorldFrame);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmHelloWorld";
            this.Text = "Hello World";
            this.pnlHelloWorld.ResumeLayout(false);
            this.pnlHelloWorld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldGerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelloWorldFrench)).EndInit();
            this.pnlHelloWorldFrame.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Label lblHelloWorldTitle;
		internal System.Windows.Forms.PictureBox picHelloWorldGerman;
		internal System.Windows.Forms.RadioButton btnHelloWorldFrench;
		internal System.Windows.Forms.PictureBox picHelloWorldEnglish;
		internal System.Windows.Forms.RadioButton btnHelloWorldGerman;
		internal System.Windows.Forms.PictureBox picHelloWorldFrench;
		internal System.Windows.Forms.Button btnHelloWorldReset;
		public System.Windows.Forms.Panel pnlHelloWorld;
		public System.Windows.Forms.RadioButton btnHelloWorldEnglish;
		public System.Windows.Forms.Panel pnlHelloWorldFrame;
	}
}