namespace Mathre
{
	partial class FrmAcronym
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
            this.lblAcronym = new System.Windows.Forms.Label();
            this.lblAcronymPrompt = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.pnlFrame.TabIndex = 33;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.lblAcronym);
            this.pnlBody.Controls.Add(this.lblAcronymPrompt);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 32;
            // 
            // lblAcronym
            // 
            this.lblAcronym.AutoSize = true;
            this.lblAcronym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcronym.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAcronym.Location = new System.Drawing.Point(163, 20);
            this.lblAcronym.Name = "lblAcronym";
            this.lblAcronym.Size = new System.Drawing.Size(71, 20);
            this.lblAcronym.TabIndex = 10;
            this.lblAcronym.Text = "Acronym";
            // 
            // lblAcronymPrompt
            // 
            this.lblAcronymPrompt.AutoSize = true;
            this.lblAcronymPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcronymPrompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAcronymPrompt.Location = new System.Drawing.Point(28, 20);
            this.lblAcronymPrompt.Name = "lblAcronymPrompt";
            this.lblAcronymPrompt.Size = new System.Drawing.Size(75, 20);
            this.lblAcronymPrompt.TabIndex = 9;
            this.lblAcronymPrompt.Text = "Acronym:";
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
            this.lblTitle.Text = "Acronym Maker";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAcronym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "FrmAcronym";
            this.Text = "Acronym Maker";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblAcronymPrompt;
		internal System.Windows.Forms.Label lblTitle;
		internal System.Windows.Forms.Label lblAcronym;
	}
}