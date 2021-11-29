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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHurricane));
            this.pnlHurricaneFrame = new System.Windows.Forms.Panel();
            this.pnlHurricaneList = new System.Windows.Forms.Panel();
            this.lstHurricaneList = new System.Windows.Forms.ListView();
            this.lblHurricaneTitle = new System.Windows.Forms.Label();
            this.pnlHurricaneOutput = new System.Windows.Forms.Panel();
            this.llbName = new System.Windows.Forms.LinkLabel();
            this.picHurricaneType = new System.Windows.Forms.PictureBox();
            this.chbDamage = new System.Windows.Forms.CheckBox();
            this.lblKnots = new System.Windows.Forms.Label();
            this.lblKnotsLabel = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryLabel = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeLabel = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.pnlHurricaneInput = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtMPH = new System.Windows.Forms.TextBox();
            this.imgHurricanes = new System.Windows.Forms.ImageList(this.components);
            this.pnlHurricaneFrame.SuspendLayout();
            this.pnlHurricaneList.SuspendLayout();
            this.pnlHurricaneOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHurricaneType)).BeginInit();
            this.pnlHurricaneInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHurricaneFrame
            // 
            this.pnlHurricaneFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHurricaneFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlHurricaneFrame.Controls.Add(this.pnlHurricaneList);
            this.pnlHurricaneFrame.Controls.Add(this.lblHurricaneTitle);
            this.pnlHurricaneFrame.Controls.Add(this.pnlHurricaneOutput);
            this.pnlHurricaneFrame.Controls.Add(this.pnlHurricaneInput);
            this.pnlHurricaneFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlHurricaneFrame.Name = "pnlHurricaneFrame";
            this.pnlHurricaneFrame.Size = new System.Drawing.Size(1200, 500);
            this.pnlHurricaneFrame.TabIndex = 34;
            // 
            // pnlHurricaneList
            // 
            this.pnlHurricaneList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHurricaneList.Controls.Add(this.lstHurricaneList);
            this.pnlHurricaneList.Location = new System.Drawing.Point(466, 165);
            this.pnlHurricaneList.Name = "pnlHurricaneList";
            this.pnlHurricaneList.Size = new System.Drawing.Size(600, 247);
            this.pnlHurricaneList.TabIndex = 37;
            // 
            // lstHurricaneList
            // 
            this.lstHurricaneList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHurricaneList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHurricaneList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstHurricaneList.HideSelection = false;
            this.lstHurricaneList.Location = new System.Drawing.Point(3, 3);
            this.lstHurricaneList.Name = "lstHurricaneList";
            this.lstHurricaneList.Size = new System.Drawing.Size(594, 241);
            this.lstHurricaneList.TabIndex = 36;
            this.lstHurricaneList.UseCompatibleStateImageBehavior = false;
            this.lstHurricaneList.View = System.Windows.Forms.View.Details;
            // 
            // lblHurricaneTitle
            // 
            this.lblHurricaneTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHurricaneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHurricaneTitle.Location = new System.Drawing.Point(287, 95);
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
            this.pnlHurricaneOutput.Controls.Add(this.llbName);
            this.pnlHurricaneOutput.Controls.Add(this.picHurricaneType);
            this.pnlHurricaneOutput.Controls.Add(this.chbDamage);
            this.pnlHurricaneOutput.Controls.Add(this.lblKnots);
            this.pnlHurricaneOutput.Controls.Add(this.lblKnotsLabel);
            this.pnlHurricaneOutput.Controls.Add(this.lblCategory);
            this.pnlHurricaneOutput.Controls.Add(this.lblCategoryLabel);
            this.pnlHurricaneOutput.Controls.Add(this.lblType);
            this.pnlHurricaneOutput.Controls.Add(this.lblTypeLabel);
            this.pnlHurricaneOutput.Controls.Add(this.lblNameLabel);
            this.pnlHurricaneOutput.Location = new System.Drawing.Point(135, 276);
            this.pnlHurricaneOutput.Name = "pnlHurricaneOutput";
            this.pnlHurricaneOutput.Size = new System.Drawing.Size(325, 136);
            this.pnlHurricaneOutput.TabIndex = 35;
            // 
            // llbName
            // 
            this.llbName.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbName.AutoSize = true;
            this.llbName.DisabledLinkColor = System.Drawing.Color.Black;
            this.llbName.Enabled = false;
            this.llbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbName.Location = new System.Drawing.Point(213, 10);
            this.llbName.Name = "llbName";
            this.llbName.Size = new System.Drawing.Size(51, 20);
            this.llbName.TabIndex = 39;
            this.llbName.TabStop = true;
            this.llbName.Text = "Name";
            // 
            // picHurricaneType
            // 
            this.picHurricaneType.Location = new System.Drawing.Point(22, 10);
            this.picHurricaneType.Name = "picHurricaneType";
            this.picHurricaneType.Size = new System.Drawing.Size(117, 117);
            this.picHurricaneType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHurricaneType.TabIndex = 38;
            this.picHurricaneType.TabStop = false;
            // 
            // chbDamage
            // 
            this.chbDamage.AutoSize = true;
            this.chbDamage.Location = new System.Drawing.Point(157, 110);
            this.chbDamage.Name = "chbDamage";
            this.chbDamage.Size = new System.Drawing.Size(151, 17);
            this.chbDamage.TabIndex = 37;
            this.chbDamage.Text = "Display Expected Damage";
            this.chbDamage.UseVisualStyleBackColor = true;
            // 
            // lblKnots
            // 
            this.lblKnots.AutoSize = true;
            this.lblKnots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnots.Location = new System.Drawing.Point(213, 38);
            this.lblKnots.Name = "lblKnots";
            this.lblKnots.Size = new System.Drawing.Size(14, 15);
            this.lblKnots.TabIndex = 36;
            this.lblKnots.Text = "0";
            this.lblKnots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKnotsLabel
            // 
            this.lblKnotsLabel.AutoSize = true;
            this.lblKnotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnotsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKnotsLabel.Location = new System.Drawing.Point(153, 35);
            this.lblKnotsLabel.Name = "lblKnotsLabel";
            this.lblKnotsLabel.Size = new System.Drawing.Size(54, 20);
            this.lblKnotsLabel.TabIndex = 35;
            this.lblKnotsLabel.Text = "Knots:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(236, 88);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(14, 15);
            this.lblCategory.TabIndex = 33;
            this.lblCategory.Text = "0";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoryLabel
            // 
            this.lblCategoryLabel.AutoSize = true;
            this.lblCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategoryLabel.Location = new System.Drawing.Point(153, 85);
            this.lblCategoryLabel.Name = "lblCategoryLabel";
            this.lblCategoryLabel.Size = new System.Drawing.Size(77, 20);
            this.lblCategoryLabel.TabIndex = 31;
            this.lblCategoryLabel.Text = "Category:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(206, 63);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(14, 15);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "0";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTypeLabel
            // 
            this.lblTypeLabel.AutoSize = true;
            this.lblTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTypeLabel.Location = new System.Drawing.Point(153, 60);
            this.lblTypeLabel.Name = "lblTypeLabel";
            this.lblTypeLabel.Size = new System.Drawing.Size(47, 20);
            this.lblTypeLabel.TabIndex = 14;
            this.lblTypeLabel.Text = "Type:";
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameLabel.Location = new System.Drawing.Point(152, 10);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(55, 20);
            this.lblNameLabel.TabIndex = 27;
            this.lblNameLabel.Text = "Name:";
            // 
            // pnlHurricaneInput
            // 
            this.pnlHurricaneInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHurricaneInput.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHurricaneInput.Controls.Add(this.btnCalculate);
            this.pnlHurricaneInput.Controls.Add(this.btnRandom);
            this.pnlHurricaneInput.Controls.Add(this.lblSpeed);
            this.pnlHurricaneInput.Controls.Add(this.txtMPH);
            this.pnlHurricaneInput.Location = new System.Drawing.Point(135, 165);
            this.pnlHurricaneInput.Name = "pnlHurricaneInput";
            this.pnlHurricaneInput.Size = new System.Drawing.Size(325, 105);
            this.pnlHurricaneInput.TabIndex = 34;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(177, 64);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 23);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate Storm Impact";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(22, 64);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(141, 23);
            this.btnRandom.TabIndex = 28;
            this.btnRandom.Text = "Generate Random Storm";
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
            // txtMPH
            // 
            this.txtMPH.BackColor = System.Drawing.SystemColors.Window;
            this.txtMPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPH.Location = new System.Drawing.Point(166, 14);
            this.txtMPH.Margin = new System.Windows.Forms.Padding(0);
            this.txtMPH.Name = "txtMPH";
            this.txtMPH.Size = new System.Drawing.Size(152, 26);
            this.txtMPH.TabIndex = 13;
            // 
            // imgHurricanes
            // 
            this.imgHurricanes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHurricanes.ImageStream")));
            this.imgHurricanes.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHurricanes.Images.SetKeyName(0, "Cat1.png");
            this.imgHurricanes.Images.SetKeyName(1, "Cat2.png");
            this.imgHurricanes.Images.SetKeyName(2, "Cat3.png");
            this.imgHurricanes.Images.SetKeyName(3, "Cat4.png");
            this.imgHurricanes.Images.SetKeyName(4, "Cat5.png");
            this.imgHurricanes.Images.SetKeyName(5, "TS0.png");
            this.imgHurricanes.Images.SetKeyName(6, "TD0.png");
            // 
            // FrmHurricane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.pnlHurricaneFrame);
            this.Name = "FrmHurricane";
            this.Text = "Hurricane!";
            this.pnlHurricaneFrame.ResumeLayout(false);
            this.pnlHurricaneList.ResumeLayout(false);
            this.pnlHurricaneOutput.ResumeLayout(false);
            this.pnlHurricaneOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHurricaneType)).EndInit();
            this.pnlHurricaneInput.ResumeLayout(false);
            this.pnlHurricaneInput.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlHurricaneFrame;
		internal System.Windows.Forms.Label lblHurricaneTitle;
		private System.Windows.Forms.Panel pnlHurricaneOutput;
		private System.Windows.Forms.Label lblType;
		internal System.Windows.Forms.Label lblTypeLabel;
		private System.Windows.Forms.Panel pnlHurricaneInput;
		internal System.Windows.Forms.Label lblSpeed;
		internal System.Windows.Forms.Label lblNameLabel;
		internal System.Windows.Forms.TextBox txtMPH;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnRandom;
		internal System.Windows.Forms.Label lblCategoryLabel;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblKnots;
		internal System.Windows.Forms.Label lblKnotsLabel;
		private System.Windows.Forms.CheckBox chbDamage;
		private System.Windows.Forms.PictureBox picHurricaneType;
		private System.Windows.Forms.ImageList imgHurricanes;
		private System.Windows.Forms.LinkLabel llbName;
		private System.Windows.Forms.ListView lstHurricaneList;
		private System.Windows.Forms.Panel pnlHurricaneList;
	}
}