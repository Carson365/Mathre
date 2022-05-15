namespace Mathre
{
	partial class Frm26Prizes
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlBody3 = new System.Windows.Forms.Panel();
            this.lblConstruction = new System.Windows.Forms.Label();
            this.lblScoreboard = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.pnlBody3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.pnlBody3);
            this.pnlFrame.Controls.Add(this.pnlBody2);
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 34;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Location = new System.Drawing.Point(370, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(260, 260);
            this.pnlBody.TabIndex = 39;
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
            this.lblTitle.Text = "Hidden Prizes";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody2.Controls.Add(this.lblY);
            this.pnlBody2.Controls.Add(this.btnPlay);
            this.pnlBody2.Controls.Add(this.lblX);
            this.pnlBody2.Controls.Add(this.nudY);
            this.pnlBody2.Controls.Add(this.nudX);
            this.pnlBody2.Location = new System.Drawing.Point(636, 150);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(155, 260);
            this.pnlBody2.TabIndex = 34;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(94, 70);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(45, 13);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "Y Count";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(15, 70);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(45, 13);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X Count";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(91, 86);
            this.nudY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(51, 20);
            this.nudY.TabIndex = 7;
            this.nudY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(12, 86);
            this.nudX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(51, 20);
            this.nudX.TabIndex = 6;
            this.nudX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Location = new System.Drawing.Point(23, 119);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(108, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Hide the Prizes!";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // pnlBody3
            // 
            this.pnlBody3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody3.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody3.Controls.Add(this.lblConstruction);
            this.pnlBody3.Controls.Add(this.lblScoreboard);
            this.pnlBody3.Location = new System.Drawing.Point(209, 150);
            this.pnlBody3.Name = "pnlBody3";
            this.pnlBody3.Size = new System.Drawing.Size(155, 260);
            this.pnlBody3.TabIndex = 35;
            // 
            // lblConstruction
            // 
            this.lblConstruction.AutoSize = true;
            this.lblConstruction.Location = new System.Drawing.Point(28, 101);
            this.lblConstruction.Name = "lblConstruction";
            this.lblConstruction.Size = new System.Drawing.Size(98, 13);
            this.lblConstruction.TabIndex = 1;
            this.lblConstruction.Text = "Under Construction";
            // 
            // lblScoreboard
            // 
            this.lblScoreboard.AutoSize = true;
            this.lblScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreboard.Location = new System.Drawing.Point(39, 39);
            this.lblScoreboard.Name = "lblScoreboard";
            this.lblScoreboard.Size = new System.Drawing.Size(65, 20);
            this.lblScoreboard.TabIndex = 0;
            this.lblScoreboard.Text = "Scores";
            // 
            // Frm26Prizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm26Prizes";
            this.Text = "Hidden Prizes";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.pnlBody3.ResumeLayout(false);
            this.pnlBody3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.NumericUpDown nudY;
		private System.Windows.Forms.NumericUpDown nudX;
		private System.Windows.Forms.Panel pnlBody3;
		private System.Windows.Forms.Label lblConstruction;
		private System.Windows.Forms.Label lblScoreboard;
	}
}