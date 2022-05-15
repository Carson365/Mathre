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
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
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
            this.pnlBody.Controls.Add(this.lblY);
            this.pnlBody.Controls.Add(this.lblX);
            this.pnlBody.Controls.Add(this.nudY);
            this.pnlBody.Controls.Add(this.nudX);
            this.pnlBody.Controls.Add(this.btnPlay);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 32;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(67, 50);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(108, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Hide the Prizes!";
            this.btnPlay.UseVisualStyleBackColor = true;
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
            this.lblTitle.Text = "Hidden Prizes";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(224, 50);
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
            this.nudX.TabIndex = 1;
            this.nudX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(327, 50);
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
            this.nudY.TabIndex = 2;
            this.nudY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(221, 34);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(45, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X Count";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(324, 34);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(45, 13);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y Count";
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
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.NumericUpDown nudY;
		private System.Windows.Forms.NumericUpDown nudX;
	}
}