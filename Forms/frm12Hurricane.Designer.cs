namespace Mathre
{
	partial class Frm12Hurricane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm12Hurricane));
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlHurricaneList = new System.Windows.Forms.Panel();
            this.lstHurricaneList = new System.Windows.Forms.ListView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody2 = new System.Windows.Forms.Panel();
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlText1 = new System.Windows.Forms.Panel();
            this.txtMPH = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.imgHurricanes = new System.Windows.Forms.ImageList(this.components);
            this.pnlFrame.SuspendLayout();
            this.pnlHurricaneList.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHurricaneType)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.pnlText1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.pnlHurricaneList);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Controls.Add(this.pnlBody2);
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1200, 500);
            this.pnlFrame.TabIndex = 34;
            // 
            // pnlHurricaneList
            // 
            this.pnlHurricaneList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHurricaneList.Controls.Add(this.lstHurricaneList);
            this.pnlHurricaneList.Location = new System.Drawing.Point(466, 150);
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
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(287, 80);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Hurricane!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Controls.Add(this.llbName);
            this.pnlBody2.Controls.Add(this.picHurricaneType);
            this.pnlBody2.Controls.Add(this.chbDamage);
            this.pnlBody2.Controls.Add(this.lblKnots);
            this.pnlBody2.Controls.Add(this.lblKnotsLabel);
            this.pnlBody2.Controls.Add(this.lblCategory);
            this.pnlBody2.Controls.Add(this.lblCategoryLabel);
            this.pnlBody2.Controls.Add(this.lblType);
            this.pnlBody2.Controls.Add(this.lblTypeLabel);
            this.pnlBody2.Controls.Add(this.lblNameLabel);
            this.pnlBody2.Location = new System.Drawing.Point(135, 261);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(325, 136);
            this.pnlBody2.TabIndex = 35;
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
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlText1);
            this.pnlBody.Controls.Add(this.btnRandom);
            this.pnlBody.Controls.Add(this.btnCalculate);
            this.pnlBody.Controls.Add(this.lblSpeed);
            this.pnlBody.Location = new System.Drawing.Point(135, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(325, 105);
            this.pnlBody.TabIndex = 34;
            // 
            // pnlText1
            // 
            this.pnlText1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlText1.BackColor = System.Drawing.Color.Transparent;
            this.pnlText1.Controls.Add(this.txtMPH);
            this.pnlText1.Location = new System.Drawing.Point(173, 13);
            this.pnlText1.Name = "pnlText1";
            this.pnlText1.Size = new System.Drawing.Size(145, 26);
            this.pnlText1.TabIndex = 37;
            this.pnlText1.Tag = "Transparent,Wind Speed (MPH)";
            // 
            // txtMPH
            // 
            this.txtMPH.BackColor = System.Drawing.SystemColors.Window;
            this.txtMPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMPH.Location = new System.Drawing.Point(0, 0);
            this.txtMPH.Margin = new System.Windows.Forms.Padding(0);
            this.txtMPH.Name = "txtMPH";
            this.txtMPH.Size = new System.Drawing.Size(145, 26);
            this.txtMPH.TabIndex = 13;
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
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(177, 64);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 23);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate Storm Impact";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpeed.Location = new System.Drawing.Point(18, 16);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(149, 20);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "Wind Speed (MPH):";
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
            // Frm12Hurricane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm12Hurricane";
            this.Text = "Hurricane!";
            this.pnlFrame.ResumeLayout(false);
            this.pnlHurricaneList.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHurricaneType)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlText1.ResumeLayout(false);
            this.pnlText1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Label lblType;
		internal System.Windows.Forms.Label lblTypeLabel;
		private System.Windows.Forms.Panel pnlBody;
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
		private System.Windows.Forms.Panel pnlText1;
	}
}