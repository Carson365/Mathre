namespace Mathre
{
	partial class FrmHurricane
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
            this.pnlSecretFrame = new System.Windows.Forms.Panel();
            this.lblHurricaneTitle = new System.Windows.Forms.Label();
            this.pnlHurricaneOutput = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeLabel = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.pnlHurricaneInput = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblMPH = new System.Windows.Forms.TextBox();
            this.lblCategoryLabel = new System.Windows.Forms.Label();
            this.lblDamageLabel = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblKnotsLabel = new System.Windows.Forms.Label();
            this.lblKnots = new System.Windows.Forms.Label();
            this.pnlSecretFrame.SuspendLayout();
            this.pnlHurricaneOutput.SuspendLayout();
            this.pnlHurricaneInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSecretFrame
            // 
            this.pnlSecretFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecretFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecretFrame.Controls.Add(this.lblHurricaneTitle);
            this.pnlSecretFrame.Controls.Add(this.pnlHurricaneOutput);
            this.pnlSecretFrame.Controls.Add(this.pnlHurricaneInput);
            this.pnlSecretFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlSecretFrame.Name = "pnlSecretFrame";
            this.pnlSecretFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlSecretFrame.TabIndex = 34;
            // 
            // lblHurricaneTitle
            // 
            this.lblHurricaneTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHurricaneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHurricaneTitle.Location = new System.Drawing.Point(187, 95);
            this.lblHurricaneTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblHurricaneTitle.Name = "lblHurricaneTitle";
            this.lblHurricaneTitle.Size = new System.Drawing.Size(626, 51);
            this.lblHurricaneTitle.TabIndex = 33;
            this.lblHurricaneTitle.Text = "Hurricane!";
            this.lblHurricaneTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHurricaneOutput
            // 
            this.pnlHurricaneOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHurricaneOutput.BackColor = System.Drawing.Color.Transparent;
            this.pnlHurricaneOutput.Controls.Add(this.lblKnots);
            this.pnlHurricaneOutput.Controls.Add(this.lblKnotsLabel);
            this.pnlHurricaneOutput.Controls.Add(this.lblDamage);
            this.pnlHurricaneOutput.Controls.Add(this.lblCategory);
            this.pnlHurricaneOutput.Controls.Add(this.lblDamageLabel);
            this.pnlHurricaneOutput.Controls.Add(this.lblCategoryLabel);
            this.pnlHurricaneOutput.Controls.Add(this.lblName);
            this.pnlHurricaneOutput.Controls.Add(this.lblType);
            this.pnlHurricaneOutput.Controls.Add(this.lblTypeLabel);
            this.pnlHurricaneOutput.Controls.Add(this.lblNameLabel);
            this.pnlHurricaneOutput.Location = new System.Drawing.Point(287, 276);
            this.pnlHurricaneOutput.Name = "pnlHurricaneOutput";
            this.pnlHurricaneOutput.Size = new System.Drawing.Size(426, 136);
            this.pnlHurricaneOutput.TabIndex = 35;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(126, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "label1";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(119, 61);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(137, 15);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Not Enough Information";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTypeLabel
            // 
            this.lblTypeLabel.AutoSize = true;
            this.lblTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTypeLabel.Location = new System.Drawing.Point(19, 58);
            this.lblTypeLabel.Name = "lblTypeLabel";
            this.lblTypeLabel.Size = new System.Drawing.Size(94, 20);
            this.lblTypeLabel.TabIndex = 14;
            this.lblTypeLabel.Text = "Storm Type:";
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameLabel.Location = new System.Drawing.Point(18, 8);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(102, 20);
            this.lblNameLabel.TabIndex = 27;
            this.lblNameLabel.Text = "Storm Name:";
            // 
            // pnlHurricaneInput
            // 
            this.pnlHurricaneInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHurricaneInput.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHurricaneInput.Controls.Add(this.btnGenerate);
            this.pnlHurricaneInput.Controls.Add(this.btnRandom);
            this.pnlHurricaneInput.Controls.Add(this.lblSpeed);
            this.pnlHurricaneInput.Controls.Add(this.lblMPH);
            this.pnlHurricaneInput.Location = new System.Drawing.Point(287, 165);
            this.pnlHurricaneInput.Name = "pnlHurricaneInput";
            this.pnlHurricaneInput.Size = new System.Drawing.Size(426, 105);
            this.pnlHurricaneInput.TabIndex = 34;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(71, 64);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 23);
            this.btnGenerate.TabIndex = 29;
            this.btnGenerate.Text = "Generate Storm";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(264, 64);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(92, 23);
            this.btnRandom.TabIndex = 28;
            this.btnRandom.Text = "Random Storm";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpeed.Location = new System.Drawing.Point(18, 16);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(145, 20);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "Wind Speed (mph):";
            // 
            // lblMPH
            // 
            this.lblMPH.BackColor = System.Drawing.SystemColors.Window;
            this.lblMPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPH.Location = new System.Drawing.Point(166, 14);
            this.lblMPH.Margin = new System.Windows.Forms.Padding(0);
            this.lblMPH.Name = "lblMPH";
            this.lblMPH.Size = new System.Drawing.Size(253, 26);
            this.lblMPH.TabIndex = 13;
            // 
            // lblCategoryLabel
            // 
            this.lblCategoryLabel.AutoSize = true;
            this.lblCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategoryLabel.Location = new System.Drawing.Point(19, 83);
            this.lblCategoryLabel.Name = "lblCategoryLabel";
            this.lblCategoryLabel.Size = new System.Drawing.Size(124, 20);
            this.lblCategoryLabel.TabIndex = 31;
            this.lblCategoryLabel.Text = "Storm Category:";
            // 
            // lblDamageLabel
            // 
            this.lblDamageLabel.AutoSize = true;
            this.lblDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDamageLabel.Location = new System.Drawing.Point(19, 108);
            this.lblDamageLabel.Name = "lblDamageLabel";
            this.lblDamageLabel.Size = new System.Drawing.Size(121, 20);
            this.lblDamageLabel.TabIndex = 32;
            this.lblDamageLabel.Text = "Storm Damage:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(149, 86);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(137, 15);
            this.lblCategory.TabIndex = 33;
            this.lblCategory.Text = "Not Enough Information";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.Location = new System.Drawing.Point(146, 111);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(137, 15);
            this.lblDamage.TabIndex = 34;
            this.lblDamage.Text = "Not Enough Information";
            this.lblDamage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKnotsLabel
            // 
            this.lblKnotsLabel.AutoSize = true;
            this.lblKnotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnotsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKnotsLabel.Location = new System.Drawing.Point(19, 33);
            this.lblKnotsLabel.Name = "lblKnotsLabel";
            this.lblKnotsLabel.Size = new System.Drawing.Size(101, 20);
            this.lblKnotsLabel.TabIndex = 35;
            this.lblKnotsLabel.Text = "Storm Knots:";
            // 
            // lblKnots
            // 
            this.lblKnots.AutoSize = true;
            this.lblKnots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnots.Location = new System.Drawing.Point(126, 36);
            this.lblKnots.Name = "lblKnots";
            this.lblKnots.Size = new System.Drawing.Size(137, 15);
            this.lblKnots.TabIndex = 36;
            this.lblKnots.Text = "Not Enough Information";
            this.lblKnots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmHurricane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlSecretFrame);
            this.Name = "FrmHurricane";
            this.Text = "Hurricane!";
            this.pnlSecretFrame.ResumeLayout(false);
            this.pnlHurricaneOutput.ResumeLayout(false);
            this.pnlHurricaneOutput.PerformLayout();
            this.pnlHurricaneInput.ResumeLayout(false);
            this.pnlHurricaneInput.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlSecretFrame;
		internal System.Windows.Forms.Label lblHurricaneTitle;
		private System.Windows.Forms.Panel pnlHurricaneOutput;
		private System.Windows.Forms.Label lblType;
		internal System.Windows.Forms.Label lblTypeLabel;
		private System.Windows.Forms.Panel pnlHurricaneInput;
		internal System.Windows.Forms.Label lblSpeed;
		internal System.Windows.Forms.Label lblNameLabel;
		internal System.Windows.Forms.TextBox lblMPH;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnRandom;
		internal System.Windows.Forms.Label lblDamageLabel;
		internal System.Windows.Forms.Label lblCategoryLabel;
		private System.Windows.Forms.Label lblDamage;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblKnots;
		internal System.Windows.Forms.Label lblKnotsLabel;
	}
}