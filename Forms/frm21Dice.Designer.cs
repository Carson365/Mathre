namespace Mathre
{
	partial class Frm21Dice
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlWager = new System.Windows.Forms.Panel();
            this.numWager = new System.Windows.Forms.NumericUpDown();
            this.lblWager = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWagerTitle = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlWager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWager)).BeginInit();
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
            this.pnlFrame.TabIndex = 34;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Location = new System.Drawing.Point(287, 276);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 38;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlWager);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 32;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 95);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWager
            // 
            this.pnlWager.Controls.Add(this.numWager);
            this.pnlWager.Controls.Add(this.lblWager);
            this.pnlWager.Controls.Add(this.lblPoints);
            this.pnlWager.Controls.Add(this.lblScore);
            this.pnlWager.Controls.Add(this.lblWagerTitle);
            this.pnlWager.Location = new System.Drawing.Point(3, 3);
            this.pnlWager.Name = "pnlWager";
            this.pnlWager.Size = new System.Drawing.Size(138, 99);
            this.pnlWager.TabIndex = 35;
            // 
            // numWager
            // 
            this.numWager.Location = new System.Drawing.Point(78, 59);
            this.numWager.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWager.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWager.Name = "numWager";
            this.numWager.ReadOnly = true;
            this.numWager.Size = new System.Drawing.Size(41, 20);
            this.numWager.TabIndex = 5;
            this.numWager.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWager
            // 
            this.lblWager.AutoSize = true;
            this.lblWager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWager.Location = new System.Drawing.Point(80, 43);
            this.lblWager.Name = "lblWager";
            this.lblWager.Size = new System.Drawing.Size(39, 13);
            this.lblWager.TabIndex = 3;
            this.lblWager.Text = "Wager";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(20, 43);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(20, 59);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(31, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "1000";
            // 
            // lblWagerTitle
            // 
            this.lblWagerTitle.AutoSize = true;
            this.lblWagerTitle.Location = new System.Drawing.Point(21, 20);
            this.lblWagerTitle.Name = "lblWagerTitle";
            this.lblWagerTitle.Size = new System.Drawing.Size(96, 13);
            this.lblWagerTitle.TabIndex = 0;
            this.lblWagerTitle.Text = "Wager Your Points";
            // 
            // Frm21Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm21Dice";
            this.Text = "Dice Game";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlWager.ResumeLayout(false);
            this.pnlWager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWager)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlWager;
		private System.Windows.Forms.NumericUpDown numWager;
		private System.Windows.Forms.Label lblWager;
		private System.Windows.Forms.Label lblPoints;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblWagerTitle;
	}
}