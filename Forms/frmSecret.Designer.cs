namespace Mathre
{
	partial class FrmSecret
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
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.chbDark = new System.Windows.Forms.CheckBox();
            this.chbPopUps = new System.Windows.Forms.CheckBox();
            this.radSecretDisable = new System.Windows.Forms.RadioButton();
            this.lblSecretPrompt = new System.Windows.Forms.Label();
            this.radSecretEnable = new System.Windows.Forms.RadioButton();
            this.txtSecretPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCustomColor = new System.Windows.Forms.Button();
            this.lblSecretDescription = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 32;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.lblSecretDescription);
            this.pnlBody.Controls.Add(this.btnCustomColor);
            this.pnlBody.Controls.Add(this.chbDark);
            this.pnlBody.Controls.Add(this.chbPopUps);
            this.pnlBody.Controls.Add(this.radSecretDisable);
            this.pnlBody.Controls.Add(this.lblSecretPrompt);
            this.pnlBody.Controls.Add(this.radSecretEnable);
            this.pnlBody.Controls.Add(this.txtSecretPassword);
            this.pnlBody.Location = new System.Drawing.Point(287, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 155);
            this.pnlBody.TabIndex = 32;
            // 
            // chbDark
            // 
            this.chbDark.AutoSize = true;
            this.chbDark.Location = new System.Drawing.Point(256, 85);
            this.chbDark.Name = "chbDark";
            this.chbDark.Size = new System.Drawing.Size(79, 17);
            this.chbDark.TabIndex = 13;
            this.chbDark.Text = "Dark Mode";
            this.chbDark.UseVisualStyleBackColor = true;
            // 
            // chbPopUps
            // 
            this.chbPopUps.AutoSize = true;
            this.chbPopUps.Checked = true;
            this.chbPopUps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPopUps.Location = new System.Drawing.Point(256, 59);
            this.chbPopUps.Name = "chbPopUps";
            this.chbPopUps.Size = new System.Drawing.Size(149, 17);
            this.chbPopUps.TabIndex = 12;
            this.chbPopUps.Text = "Enable Pop-Up Messages";
            this.chbPopUps.UseVisualStyleBackColor = true;
            // 
            // radSecretDisable
            // 
            this.radSecretDisable.AutoSize = true;
            this.radSecretDisable.Checked = true;
            this.radSecretDisable.Enabled = false;
            this.radSecretDisable.Location = new System.Drawing.Point(49, 85);
            this.radSecretDisable.Name = "radSecretDisable";
            this.radSecretDisable.Size = new System.Drawing.Size(60, 17);
            this.radSecretDisable.TabIndex = 11;
            this.radSecretDisable.TabStop = true;
            this.radSecretDisable.Text = "Disable";
            this.radSecretDisable.UseVisualStyleBackColor = true;
            // 
            // lblSecretPrompt
            // 
            this.lblSecretPrompt.AutoSize = true;
            this.lblSecretPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretPrompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSecretPrompt.Location = new System.Drawing.Point(77, 20);
            this.lblSecretPrompt.Name = "lblSecretPrompt";
            this.lblSecretPrompt.Size = new System.Drawing.Size(153, 20);
            this.lblSecretPrompt.TabIndex = 9;
            this.lblSecretPrompt.Text = "Enter the Passcode:";
            // 
            // radSecretEnable
            // 
            this.radSecretEnable.AutoSize = true;
            this.radSecretEnable.Enabled = false;
            this.radSecretEnable.Location = new System.Drawing.Point(140, 85);
            this.radSecretEnable.Name = "radSecretEnable";
            this.radSecretEnable.Size = new System.Drawing.Size(58, 17);
            this.radSecretEnable.TabIndex = 10;
            this.radSecretEnable.Text = "Enable";
            this.radSecretEnable.UseVisualStyleBackColor = true;
            // 
            // txtSecretPassword
            // 
            this.txtSecretPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtSecretPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecretPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretPassword.Location = new System.Drawing.Point(236, 18);
            this.txtSecretPassword.Name = "txtSecretPassword";
            this.txtSecretPassword.PasswordChar = '∗';
            this.txtSecretPassword.Size = new System.Drawing.Size(114, 26);
            this.txtSecretPassword.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 80);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Enable Super Secret Settings";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCustomColor
            // 
            this.btnCustomColor.Location = new System.Drawing.Point(116, 113);
            this.btnCustomColor.Name = "btnCustomColor";
            this.btnCustomColor.Size = new System.Drawing.Size(195, 23);
            this.btnCustomColor.TabIndex = 33;
            this.btnCustomColor.Text = "Custom Theme Color";
            this.btnCustomColor.UseVisualStyleBackColor = true;
            // 
            // lblSecretDescription
            // 
            this.lblSecretDescription.AutoSize = true;
            this.lblSecretDescription.Location = new System.Drawing.Point(21, 61);
            this.lblSecretDescription.Name = "lblSecretDescription";
            this.lblSecretDescription.Size = new System.Drawing.Size(205, 13);
            this.lblSecretDescription.TabIndex = 34;
            this.lblSecretDescription.Text = "Custom Languages in Hello World (ctrl + r)";
            // 
            // FrmSecret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "FrmSecret";
            this.Text = "Secret Settings";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.RadioButton radSecretDisable;
		internal System.Windows.Forms.Label lblSecretPrompt;
		internal System.Windows.Forms.RadioButton radSecretEnable;
		internal System.Windows.Forms.TextBox txtSecretPassword;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.CheckBox chbPopUps;
		private System.Windows.Forms.CheckBox chbDark;
		private System.Windows.Forms.Button btnCustomColor;
		private System.Windows.Forms.Label lblSecretDescription;
	}
}
