
namespace Mathre
{
	partial class Frm09Grade
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.lblPassFail = new System.Windows.Forms.Label();
            this.lblScoreDisplay = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.radMethod1 = new System.Windows.Forms.RadioButton();
            this.radMethod2 = new System.Windows.Forms.RadioButton();
            this.radMethod3 = new System.Windows.Forms.RadioButton();
            this.radMethod4 = new System.Windows.Forms.RadioButton();
            this.btnMethod5 = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.pnlMethod5Entered = new System.Windows.Forms.Panel();
            this.lblGradesEntered = new System.Windows.Forms.Label();
            this.lblGradesEnteredCount = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlMethod5Entered.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Controls.Add(this.pnlBody2);
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 34;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 95);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Grade Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Controls.Add(this.lblPassFail);
            this.pnlBody2.Controls.Add(this.lblScoreDisplay);
            this.pnlBody2.Controls.Add(this.lblScore);
            this.pnlBody2.Location = new System.Drawing.Point(287, 326);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 81);
            this.pnlBody2.TabIndex = 35;
            // 
            // lblPassFail
            // 
            this.lblPassFail.AutoSize = true;
            this.lblPassFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassFail.Location = new System.Drawing.Point(202, 25);
            this.lblPassFail.Name = "lblPassFail";
            this.lblPassFail.Size = new System.Drawing.Size(77, 30);
            this.lblPassFail.TabIndex = 17;
            this.lblPassFail.Text = "Pass!";
            this.lblPassFail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScoreDisplay
            // 
            this.lblScoreDisplay.AutoSize = true;
            this.lblScoreDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreDisplay.Location = new System.Drawing.Point(79, 33);
            this.lblScoreDisplay.Name = "lblScoreDisplay";
            this.lblScoreDisplay.Size = new System.Drawing.Size(105, 15);
            this.lblScoreDisplay.TabIndex = 16;
            this.lblScoreDisplay.Text = "Score Percentage";
            this.lblScoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore.Location = new System.Drawing.Point(18, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 20);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "Score:";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.radMethod1);
            this.pnlBody.Controls.Add(this.radMethod2);
            this.pnlBody.Controls.Add(this.radMethod3);
            this.pnlBody.Controls.Add(this.radMethod4);
            this.pnlBody.Controls.Add(this.btnMethod5);
            this.pnlBody.Controls.Add(this.btnRandom);
            this.pnlBody.Controls.Add(this.pnlMethod5Entered);
            this.pnlBody.Controls.Add(this.lblPoints);
            this.pnlBody.Controls.Add(this.txtTotal);
            this.pnlBody.Controls.Add(this.lblTotal);
            this.pnlBody.Controls.Add(this.txtPoints);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 155);
            this.pnlBody.TabIndex = 34;
            // 
            // radMethod1
            // 
            this.radMethod1.AutoSize = true;
            this.radMethod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMethod1.Location = new System.Drawing.Point(216, 14);
            this.radMethod1.Name = "radMethod1";
            this.radMethod1.Size = new System.Drawing.Size(94, 24);
            this.radMethod1.TabIndex = 38;
            this.radMethod1.Text = "Method 1";
            this.radMethod1.UseVisualStyleBackColor = true;
            // 
            // radMethod2
            // 
            this.radMethod2.AutoSize = true;
            this.radMethod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMethod2.Location = new System.Drawing.Point(325, 15);
            this.radMethod2.Name = "radMethod2";
            this.radMethod2.Size = new System.Drawing.Size(94, 24);
            this.radMethod2.TabIndex = 39;
            this.radMethod2.Text = "Method 2";
            this.radMethod2.UseVisualStyleBackColor = true;
            // 
            // radMethod3
            // 
            this.radMethod3.AutoSize = true;
            this.radMethod3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMethod3.Location = new System.Drawing.Point(216, 49);
            this.radMethod3.Name = "radMethod3";
            this.radMethod3.Size = new System.Drawing.Size(94, 24);
            this.radMethod3.TabIndex = 40;
            this.radMethod3.Text = "Method 3";
            this.radMethod3.UseVisualStyleBackColor = true;
            // 
            // radMethod4
            // 
            this.radMethod4.AutoSize = true;
            this.radMethod4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMethod4.Location = new System.Drawing.Point(325, 49);
            this.radMethod4.Name = "radMethod4";
            this.radMethod4.Size = new System.Drawing.Size(94, 24);
            this.radMethod4.TabIndex = 41;
            this.radMethod4.Text = "Method 4";
            this.radMethod4.UseVisualStyleBackColor = true;
            // 
            // btnMethod5
            // 
            this.btnMethod5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMethod5.Location = new System.Drawing.Point(9, 82);
            this.btnMethod5.Name = "btnMethod5";
            this.btnMethod5.Size = new System.Drawing.Size(199, 23);
            this.btnMethod5.TabIndex = 36;
            this.btnMethod5.Text = "Calculate with Method 5";
            this.btnMethod5.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRandom.Location = new System.Drawing.Point(9, 119);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(199, 23);
            this.btnRandom.TabIndex = 37;
            this.btnRandom.Text = "Calculate Random Grade";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // pnlMethod5Entered
            // 
            this.pnlMethod5Entered.Controls.Add(this.lblGradesEntered);
            this.pnlMethod5Entered.Controls.Add(this.lblGradesEnteredCount);
            this.pnlMethod5Entered.Location = new System.Drawing.Point(210, 79);
            this.pnlMethod5Entered.Name = "pnlMethod5Entered";
            this.pnlMethod5Entered.Size = new System.Drawing.Size(209, 65);
            this.pnlMethod5Entered.TabIndex = 34;
            this.pnlMethod5Entered.Tag = "Black";
            // 
            // lblGradesEntered
            // 
            this.lblGradesEntered.AutoSize = true;
            this.lblGradesEntered.Location = new System.Drawing.Point(7, 26);
            this.lblGradesEntered.Name = "lblGradesEntered";
            this.lblGradesEntered.Size = new System.Drawing.Size(154, 13);
            this.lblGradesEntered.TabIndex = 1;
            this.lblGradesEntered.Text = "Grades Entered with Method 5:";
            // 
            // lblGradesEnteredCount
            // 
            this.lblGradesEnteredCount.AutoSize = true;
            this.lblGradesEnteredCount.Location = new System.Drawing.Point(167, 26);
            this.lblGradesEnteredCount.Name = "lblGradesEnteredCount";
            this.lblGradesEnteredCount.Size = new System.Drawing.Size(35, 13);
            this.lblGradesEnteredCount.TabIndex = 0;
            this.lblGradesEnteredCount.Text = "Count";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPoints.Location = new System.Drawing.Point(18, 15);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(53, 20);
            this.lblPoints.TabIndex = 9;
            this.lblPoints.Text = "Points";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(74, 49);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(133, 26);
            this.txtTotal.TabIndex = 30;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(27, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total";
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.SystemColors.Window;
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(74, 12);
            this.txtPoints.Margin = new System.Windows.Forms.Padding(0);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(133, 26);
            this.txtPoints.TabIndex = 13;
            // 
            // Frm09Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm09Grade";
            this.Text = "Grade Calculator";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody2.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlMethod5Entered.ResumeLayout(false);
            this.pnlMethod5Entered.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Label lblScoreDisplay;
		internal System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblPoints;
		internal System.Windows.Forms.TextBox txtTotal;
		internal System.Windows.Forms.Label lblTotal;
		internal System.Windows.Forms.TextBox txtPoints;
		private System.Windows.Forms.Label lblPassFail;
		private System.Windows.Forms.Button btnMethod5;
		private System.Windows.Forms.Panel pnlMethod5Entered;
		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Label lblGradesEntered;
		private System.Windows.Forms.Label lblGradesEnteredCount;
		private System.Windows.Forms.RadioButton radMethod4;
		private System.Windows.Forms.RadioButton radMethod3;
		private System.Windows.Forms.RadioButton radMethod1;
		private System.Windows.Forms.RadioButton radMethod2;
	}
}
