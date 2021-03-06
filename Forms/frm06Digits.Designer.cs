
namespace Mathre
{
	partial class Frm06Digits
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
            this.pnlDigitsResultsDisplay = new System.Windows.Forms.Panel();
            this.lblDigitsResultsLabel = new System.Windows.Forms.Label();
            this.lblDigitsListOdds = new System.Windows.Forms.Label();
            this.lblDigitsListEvens = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlText1 = new System.Windows.Forms.Panel();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblDigits = new System.Windows.Forms.Label();
            this.lblDigitsCount = new System.Windows.Forms.Label();
            this.lblDigitsCountLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            this.pnlDigitsResultsDisplay.SuspendLayout();
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
            this.pnlFrame.Controls.Add(this.pnlBody2);
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 33;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Controls.Add(this.pnlDigitsResultsDisplay);
            this.pnlBody2.Location = new System.Drawing.Point(287, 261);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 35;
            // 
            // pnlDigitsResultsDisplay
            // 
            this.pnlDigitsResultsDisplay.AutoScroll = true;
            this.pnlDigitsResultsDisplay.Controls.Add(this.lblDigitsResultsLabel);
            this.pnlDigitsResultsDisplay.Controls.Add(this.lblDigitsListOdds);
            this.pnlDigitsResultsDisplay.Controls.Add(this.lblDigitsListEvens);
            this.pnlDigitsResultsDisplay.Location = new System.Drawing.Point(2, 2);
            this.pnlDigitsResultsDisplay.Name = "pnlDigitsResultsDisplay";
            this.pnlDigitsResultsDisplay.Size = new System.Drawing.Size(422, 132);
            this.pnlDigitsResultsDisplay.TabIndex = 22;
            this.pnlDigitsResultsDisplay.Tag = "Transparent";
            // 
            // lblDigitsResultsLabel
            // 
            this.lblDigitsResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsResultsLabel.Location = new System.Drawing.Point(25, 14);
            this.lblDigitsResultsLabel.Name = "lblDigitsResultsLabel";
            this.lblDigitsResultsLabel.Size = new System.Drawing.Size(373, 27);
            this.lblDigitsResultsLabel.TabIndex = 3;
            this.lblDigitsResultsLabel.Text = "Digits";
            this.lblDigitsResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDigitsListOdds
            // 
            this.lblDigitsListOdds.AutoSize = true;
            this.lblDigitsListOdds.Location = new System.Drawing.Point(124, 45);
            this.lblDigitsListOdds.Name = "lblDigitsListOdds";
            this.lblDigitsListOdds.Size = new System.Drawing.Size(51, 13);
            this.lblDigitsListOdds.TabIndex = 2;
            this.lblDigitsListOdds.Text = "Digit #: #";
            // 
            // lblDigitsListEvens
            // 
            this.lblDigitsListEvens.AutoSize = true;
            this.lblDigitsListEvens.Location = new System.Drawing.Point(247, 45);
            this.lblDigitsListEvens.Name = "lblDigitsListEvens";
            this.lblDigitsListEvens.Size = new System.Drawing.Size(51, 13);
            this.lblDigitsListEvens.TabIndex = 1;
            this.lblDigitsListEvens.Text = "Digit #: #";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlText1);
            this.pnlBody.Controls.Add(this.lblDigits);
            this.pnlBody.Controls.Add(this.lblDigitsCount);
            this.pnlBody.Controls.Add(this.lblDigitsCountLabel);
            this.pnlBody.Location = new System.Drawing.Point(287, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 34;
            // 
            // pnlText1
            // 
            this.pnlText1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlText1.BackColor = System.Drawing.Color.Transparent;
            this.pnlText1.Controls.Add(this.txtNumber);
            this.pnlText1.Location = new System.Drawing.Point(96, 13);
            this.pnlText1.Name = "pnlText1";
            this.pnlText1.Size = new System.Drawing.Size(304, 26);
            this.pnlText1.TabIndex = 36;
            this.pnlText1.Tag = "Transparent,Number";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(0, 0);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(304, 26);
            this.txtNumber.TabIndex = 19;
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDigits.Location = new System.Drawing.Point(18, 16);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(69, 20);
            this.lblDigits.TabIndex = 18;
            this.lblDigits.Text = "Number:";
            // 
            // lblDigitsCount
            // 
            this.lblDigitsCount.AutoSize = true;
            this.lblDigitsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsCount.Location = new System.Drawing.Point(155, 64);
            this.lblDigitsCount.Name = "lblDigitsCount";
            this.lblDigitsCount.Size = new System.Drawing.Size(38, 15);
            this.lblDigitsCount.TabIndex = 21;
            this.lblDigitsCount.Text = "Digits";
            this.lblDigitsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDigitsCountLabel
            // 
            this.lblDigitsCountLabel.AutoSize = true;
            this.lblDigitsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitsCountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDigitsCountLabel.Location = new System.Drawing.Point(18, 61);
            this.lblDigitsCountLabel.Name = "lblDigitsCountLabel";
            this.lblDigitsCountLabel.Size = new System.Drawing.Size(131, 20);
            this.lblDigitsCountLabel.TabIndex = 20;
            this.lblDigitsCountLabel.Text = "Number of Digits:";
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
            this.lblTitle.Text = "Numerical Digit Separator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm06Digits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm06Digits";
            this.Text = "Digit Separator";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlDigitsResultsDisplay.ResumeLayout(false);
            this.pnlDigitsResultsDisplay.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlText1.ResumeLayout(false);
            this.pnlText1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.TextBox txtNumber;
		internal System.Windows.Forms.Label lblDigits;
		private System.Windows.Forms.Label lblDigitsCount;
		internal System.Windows.Forms.Label lblDigitsCountLabel;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Panel pnlDigitsResultsDisplay;
		private System.Windows.Forms.Label lblDigitsResultsLabel;
		private System.Windows.Forms.Label lblDigitsListOdds;
		private System.Windows.Forms.Label lblDigitsListEvens;
		private System.Windows.Forms.Panel pnlText1;
	}
}
