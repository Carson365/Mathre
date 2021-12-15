namespace Mathre
{
	partial class FrmSum
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
            this.pnlDigitsResults = new System.Windows.Forms.Panel();
            this.pnlDigitsResultsDisplay = new System.Windows.Forms.Panel();
            this.lblMath = new System.Windows.Forms.Label();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlDigitsResults.SuspendLayout();
            this.pnlDigitsResultsDisplay.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.pnlDigitsResults);
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 33;
            // 
            // pnlDigitsResults
            // 
            this.pnlDigitsResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDigitsResults.BackColor = System.Drawing.Color.Transparent;
            this.pnlDigitsResults.Controls.Add(this.pnlDigitsResultsDisplay);
            this.pnlDigitsResults.Location = new System.Drawing.Point(287, 276);
            this.pnlDigitsResults.Name = "pnlDigitsResults";
            this.pnlDigitsResults.Size = new System.Drawing.Size(426, 136);
            this.pnlDigitsResults.TabIndex = 38;
            // 
            // pnlDigitsResultsDisplay
            // 
            this.pnlDigitsResultsDisplay.AutoScroll = true;
            this.pnlDigitsResultsDisplay.Controls.Add(this.lblMath);
            this.pnlDigitsResultsDisplay.Controls.Add(this.lblCalculation);
            this.pnlDigitsResultsDisplay.Location = new System.Drawing.Point(2, 2);
            this.pnlDigitsResultsDisplay.Name = "pnlDigitsResultsDisplay";
            this.pnlDigitsResultsDisplay.Size = new System.Drawing.Size(422, 132);
            this.pnlDigitsResultsDisplay.TabIndex = 22;
            this.pnlDigitsResultsDisplay.Tag = "Transparent";
            // 
            // lblMath
            // 
            this.lblMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMath.Location = new System.Drawing.Point(25, 14);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(373, 27);
            this.lblMath.TabIndex = 3;
            this.lblMath.Text = "Math:";
            this.lblMath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoEllipsis = true;
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Location = new System.Drawing.Point(124, 45);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(59, 13);
            this.lblCalculation.TabIndex = 2;
            this.lblCalculation.Text = "Calculation";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.lblEnd);
            this.pnlBody.Controls.Add(this.txtEnd);
            this.pnlBody.Controls.Add(this.lblStart);
            this.pnlBody.Controls.Add(this.txtStart);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 37;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnd.Location = new System.Drawing.Point(34, 63);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(123, 20);
            this.lblEnd.TabIndex = 10;
            this.lblEnd.Text = "Ending Number:";
            // 
            // txtEnd
            // 
            this.txtEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(163, 61);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(114, 26);
            this.txtEnd.TabIndex = 11;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStart.Location = new System.Drawing.Point(28, 20);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(129, 20);
            this.lblStart.TabIndex = 9;
            this.lblStart.Text = "Starting Number:";
            // 
            // txtStart
            // 
            this.txtStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(163, 18);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(114, 26);
            this.txtStart.TabIndex = 9;
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
            this.lblTitle.Text = "Sum Numbers";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "FrmSum";
            this.Text = "Sum Numbers";
            this.pnlFrame.ResumeLayout(false);
            this.pnlDigitsResults.ResumeLayout(false);
            this.pnlDigitsResultsDisplay.ResumeLayout(false);
            this.pnlDigitsResultsDisplay.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlDigitsResults;
		private System.Windows.Forms.Panel pnlDigitsResultsDisplay;
		private System.Windows.Forms.Label lblMath;
		private System.Windows.Forms.Label lblCalculation;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblEnd;
		internal System.Windows.Forms.TextBox txtEnd;
		internal System.Windows.Forms.Label lblStart;
		internal System.Windows.Forms.TextBox txtStart;
	}
}