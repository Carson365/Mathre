namespace Mathre
{
	partial class Frm13Slots
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
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlWager = new System.Windows.Forms.Panel();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.chbDouble = new System.Windows.Forms.CheckBox();
            this.lblWinIndicator = new System.Windows.Forms.Label();
            this.chbAuto = new System.Windows.Forms.CheckBox();
            this.chbMessage = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlWager.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.pnlBody2);
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 35;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Controls.Add(this.lbl3);
            this.pnlBody2.Controls.Add(this.lbl2);
            this.pnlBody2.Controls.Add(this.lbl1);
            this.pnlBody2.Location = new System.Drawing.Point(287, 261);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 35;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(290, 62);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(71, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Spin Wheel 3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(196, 62);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(71, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Spin Wheel 2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(102, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Spin Wheel 1";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlWager);
            this.pnlBody.Controls.Add(this.lblWinIndicator);
            this.pnlBody.Controls.Add(this.chbAuto);
            this.pnlBody.Controls.Add(this.chbMessage);
            this.pnlBody.Location = new System.Drawing.Point(287, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 34;
            // 
            // pnlWager
            // 
            this.pnlWager.Controls.Add(this.btnSpin);
            this.pnlWager.Controls.Add(this.lblPoints);
            this.pnlWager.Controls.Add(this.lblScore);
            this.pnlWager.Controls.Add(this.chbDouble);
            this.pnlWager.Location = new System.Drawing.Point(214, 13);
            this.pnlWager.Name = "pnlWager";
            this.pnlWager.Size = new System.Drawing.Size(199, 79);
            this.pnlWager.TabIndex = 6;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(98, 16);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 4;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(7, 21);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(43, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Tokens";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(16, 42);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "100";
            // 
            // chbDouble
            // 
            this.chbDouble.AutoSize = true;
            this.chbDouble.Location = new System.Drawing.Point(78, 45);
            this.chbDouble.Name = "chbDouble";
            this.chbDouble.Size = new System.Drawing.Size(114, 17);
            this.chbDouble.TabIndex = 3;
            this.chbDouble.Text = "Double Or Nothing";
            this.chbDouble.UseVisualStyleBackColor = true;
            // 
            // lblWinIndicator
            // 
            this.lblWinIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWinIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinIndicator.Location = new System.Drawing.Point(11, 13);
            this.lblWinIndicator.Name = "lblWinIndicator";
            this.lblWinIndicator.Size = new System.Drawing.Size(197, 59);
            this.lblWinIndicator.TabIndex = 5;
            this.lblWinIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbAuto
            // 
            this.chbAuto.AutoSize = true;
            this.chbAuto.Location = new System.Drawing.Point(105, 75);
            this.chbAuto.Name = "chbAuto";
            this.chbAuto.Size = new System.Drawing.Size(71, 17);
            this.chbAuto.TabIndex = 7;
            this.chbAuto.Text = "Auto Play";
            this.chbAuto.UseVisualStyleBackColor = true;
            // 
            // chbMessage
            // 
            this.chbMessage.AutoSize = true;
            this.chbMessage.Location = new System.Drawing.Point(11, 75);
            this.chbMessage.Name = "chbMessage";
            this.chbMessage.Size = new System.Drawing.Size(79, 17);
            this.chbMessage.TabIndex = 4;
            this.chbMessage.Text = "Detail View";
            this.chbMessage.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 80);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Slot Machine";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm13Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm13Slots";
            this.Text = "Slot Machine";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody2.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlWager.ResumeLayout(false);
            this.pnlWager.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.CheckBox chbMessage;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Panel pnlWager;
		private System.Windows.Forms.Button btnSpin;
		private System.Windows.Forms.CheckBox chbDouble;
		private System.Windows.Forms.Label lblPoints;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblWinIndicator;
		private System.Windows.Forms.CheckBox chbAuto;
	}
}