
namespace Mathre
{
	partial class FrmGrade
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
            this.pnlGradeFrame = new System.Windows.Forms.Panel();
            this.lblGradeTitle = new System.Windows.Forms.Label();
            this.pnlGradeDisplay = new System.Windows.Forms.Panel();
            this.lblPassFail = new System.Windows.Forms.Label();
            this.lblScoreDisplay = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlGrade = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGradesEntered = new System.Windows.Forms.Label();
            this.lblGradesEnteredCount = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnMethod5 = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.pnlDiningType = new System.Windows.Forms.Panel();
            this.btnMethod4 = new System.Windows.Forms.RadioButton();
            this.btnMethod3 = new System.Windows.Forms.RadioButton();
            this.btnMethod1 = new System.Windows.Forms.RadioButton();
            this.btnMethod2 = new System.Windows.Forms.RadioButton();
            this.pnlGradeFrame.SuspendLayout();
            this.pnlGradeDisplay.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDiningType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGradeFrame
            // 
            this.pnlGradeFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGradeFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGradeFrame.Controls.Add(this.lblGradeTitle);
            this.pnlGradeFrame.Controls.Add(this.pnlGradeDisplay);
            this.pnlGradeFrame.Controls.Add(this.pnlGrade);
            this.pnlGradeFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlGradeFrame.Name = "pnlGradeFrame";
            this.pnlGradeFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlGradeFrame.TabIndex = 34;
            // 
            // lblGradeTitle
            // 
            this.lblGradeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGradeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeTitle.Location = new System.Drawing.Point(187, 95);
            this.lblGradeTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblGradeTitle.Name = "lblGradeTitle";
            this.lblGradeTitle.Size = new System.Drawing.Size(626, 51);
            this.lblGradeTitle.TabIndex = 33;
            this.lblGradeTitle.Text = "Grade Calculator";
            this.lblGradeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGradeDisplay
            // 
            this.pnlGradeDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGradeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlGradeDisplay.Controls.Add(this.lblPassFail);
            this.pnlGradeDisplay.Controls.Add(this.lblScoreDisplay);
            this.pnlGradeDisplay.Controls.Add(this.lblScore);
            this.pnlGradeDisplay.Location = new System.Drawing.Point(287, 326);
            this.pnlGradeDisplay.Name = "pnlGradeDisplay";
            this.pnlGradeDisplay.Size = new System.Drawing.Size(426, 81);
            this.pnlGradeDisplay.TabIndex = 35;
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
            // pnlGrade
            // 
            this.pnlGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGrade.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGrade.Controls.Add(this.panel1);
            this.pnlGrade.Controls.Add(this.btnRandom);
            this.pnlGrade.Controls.Add(this.btnMethod5);
            this.pnlGrade.Controls.Add(this.lblPoints);
            this.pnlGrade.Controls.Add(this.txtTotal);
            this.pnlGrade.Controls.Add(this.lblTotal);
            this.pnlGrade.Controls.Add(this.txtPoints);
            this.pnlGrade.Controls.Add(this.pnlDiningType);
            this.pnlGrade.Location = new System.Drawing.Point(287, 165);
            this.pnlGrade.Name = "pnlGrade";
            this.pnlGrade.Size = new System.Drawing.Size(426, 155);
            this.pnlGrade.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGradesEntered);
            this.panel1.Controls.Add(this.lblGradesEnteredCount);
            this.panel1.Location = new System.Drawing.Point(210, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 65);
            this.panel1.TabIndex = 34;
            this.panel1.Tag = "Black";
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
            // pnlDiningType
            // 
            this.pnlDiningType.Controls.Add(this.btnMethod4);
            this.pnlDiningType.Controls.Add(this.btnMethod3);
            this.pnlDiningType.Controls.Add(this.btnMethod1);
            this.pnlDiningType.Controls.Add(this.btnMethod2);
            this.pnlDiningType.Location = new System.Drawing.Point(210, 11);
            this.pnlDiningType.Name = "pnlDiningType";
            this.pnlDiningType.Size = new System.Drawing.Size(209, 65);
            this.pnlDiningType.TabIndex = 33;
            this.pnlDiningType.Tag = "Transparent";
            // 
            // btnMethod4
            // 
            this.btnMethod4.AutoSize = true;
            this.btnMethod4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethod4.Location = new System.Drawing.Point(112, 38);
            this.btnMethod4.Name = "btnMethod4";
            this.btnMethod4.Size = new System.Drawing.Size(94, 24);
            this.btnMethod4.TabIndex = 32;
            this.btnMethod4.Text = "Method 4";
            this.btnMethod4.UseVisualStyleBackColor = true;
            // 
            // btnMethod3
            // 
            this.btnMethod3.AutoSize = true;
            this.btnMethod3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethod3.Location = new System.Drawing.Point(3, 38);
            this.btnMethod3.Name = "btnMethod3";
            this.btnMethod3.Size = new System.Drawing.Size(94, 24);
            this.btnMethod3.TabIndex = 31;
            this.btnMethod3.Text = "Method 3";
            this.btnMethod3.UseVisualStyleBackColor = true;
            // 
            // btnMethod1
            // 
            this.btnMethod1.AutoSize = true;
            this.btnMethod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethod1.Location = new System.Drawing.Point(3, 3);
            this.btnMethod1.Name = "btnMethod1";
            this.btnMethod1.Size = new System.Drawing.Size(94, 24);
            this.btnMethod1.TabIndex = 25;
            this.btnMethod1.Text = "Method 1";
            this.btnMethod1.UseVisualStyleBackColor = true;
            // 
            // btnMethod2
            // 
            this.btnMethod2.AutoSize = true;
            this.btnMethod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethod2.Location = new System.Drawing.Point(112, 4);
            this.btnMethod2.Name = "btnMethod2";
            this.btnMethod2.Size = new System.Drawing.Size(94, 24);
            this.btnMethod2.TabIndex = 26;
            this.btnMethod2.Text = "Method 2";
            this.btnMethod2.UseVisualStyleBackColor = true;
            // 
            // FrmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlGradeFrame);
            this.Name = "FrmGrade";
            this.Text = "Grade Calculator";
            this.pnlGradeFrame.ResumeLayout(false);
            this.pnlGradeDisplay.ResumeLayout(false);
            this.pnlGradeDisplay.PerformLayout();
            this.pnlGrade.ResumeLayout(false);
            this.pnlGrade.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDiningType.ResumeLayout(false);
            this.pnlDiningType.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlGradeFrame;
		internal System.Windows.Forms.Label lblGradeTitle;
		private System.Windows.Forms.Panel pnlGradeDisplay;
		private System.Windows.Forms.Label lblScoreDisplay;
		internal System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Panel pnlGrade;
		internal System.Windows.Forms.Label lblPoints;
		internal System.Windows.Forms.TextBox txtTotal;
		internal System.Windows.Forms.Label lblTotal;
		internal System.Windows.Forms.TextBox txtPoints;
		private System.Windows.Forms.Panel pnlDiningType;
		private System.Windows.Forms.RadioButton btnMethod4;
		private System.Windows.Forms.RadioButton btnMethod3;
		private System.Windows.Forms.RadioButton btnMethod1;
		private System.Windows.Forms.RadioButton btnMethod2;
		private System.Windows.Forms.Label lblPassFail;
		private System.Windows.Forms.Button btnMethod5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Label lblGradesEntered;
		private System.Windows.Forms.Label lblGradesEnteredCount;
	}
}
