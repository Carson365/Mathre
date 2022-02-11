namespace Mathre
{
	partial class Frm11RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm11RPS));
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.pnlRPSChoice = new System.Windows.Forms.Panel();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.picRPS = new System.Windows.Forms.PictureBox();
            this.pnlComputer = new System.Windows.Forms.Panel();
            this.pnlRPSChoice2 = new System.Windows.Forms.Panel();
            this.radRock2 = new System.Windows.Forms.RadioButton();
            this.radPaper2 = new System.Windows.Forms.RadioButton();
            this.radScissors2 = new System.Windows.Forms.RadioButton();
            this.picRPS2 = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlWager = new System.Windows.Forms.Panel();
            this.numWager = new System.Windows.Forms.NumericUpDown();
            this.lblWager = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWagerTitle = new System.Windows.Forms.Label();
            this.lblWinIndicator = new System.Windows.Forms.Label();
            this.chbDisableMessagebox = new System.Windows.Forms.CheckBox();
            this.pnlScoreDisplay = new System.Windows.Forms.Panel();
            this.lblDrawCount = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgRPS = new System.Windows.Forms.ImageList(this.components);
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            this.pnlRPSChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRPS)).BeginInit();
            this.pnlComputer.SuspendLayout();
            this.pnlRPSChoice2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRPS2)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.pnlWager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWager)).BeginInit();
            this.pnlScoreDisplay.SuspendLayout();
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
            this.pnlBody2.Controls.Add(this.pnlPlayer);
            this.pnlBody2.Controls.Add(this.pnlComputer);
            this.pnlBody2.Location = new System.Drawing.Point(287, 276);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 35;
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Controls.Add(this.pnlRPSChoice);
            this.pnlPlayer.Controls.Add(this.picRPS);
            this.pnlPlayer.Location = new System.Drawing.Point(0, 0);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(214, 136);
            this.pnlPlayer.TabIndex = 12;
            // 
            // pnlRPSChoice
            // 
            this.pnlRPSChoice.Controls.Add(this.radRock);
            this.pnlRPSChoice.Controls.Add(this.radPaper);
            this.pnlRPSChoice.Controls.Add(this.radScissors);
            this.pnlRPSChoice.Location = new System.Drawing.Point(9, 93);
            this.pnlRPSChoice.Name = "pnlRPSChoice";
            this.pnlRPSChoice.Size = new System.Drawing.Size(196, 32);
            this.pnlRPSChoice.TabIndex = 10;
            this.pnlRPSChoice.Tag = "Transparent,Player";
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(5, 8);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 5;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(70, 8);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 6;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(129, 8);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 7;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            // 
            // picRPS
            // 
            this.picRPS.ErrorImage = null;
            this.picRPS.InitialImage = null;
            this.picRPS.Location = new System.Drawing.Point(9, 11);
            this.picRPS.Name = "picRPS";
            this.picRPS.Size = new System.Drawing.Size(180, 76);
            this.picRPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRPS.TabIndex = 4;
            this.picRPS.TabStop = false;
            // 
            // pnlComputer
            // 
            this.pnlComputer.Controls.Add(this.pnlRPSChoice2);
            this.pnlComputer.Controls.Add(this.picRPS2);
            this.pnlComputer.Location = new System.Drawing.Point(212, 0);
            this.pnlComputer.Name = "pnlComputer";
            this.pnlComputer.Size = new System.Drawing.Size(214, 136);
            this.pnlComputer.TabIndex = 14;
            // 
            // pnlRPSChoice2
            // 
            this.pnlRPSChoice2.Controls.Add(this.radRock2);
            this.pnlRPSChoice2.Controls.Add(this.radPaper2);
            this.pnlRPSChoice2.Controls.Add(this.radScissors2);
            this.pnlRPSChoice2.Location = new System.Drawing.Point(9, 93);
            this.pnlRPSChoice2.Name = "pnlRPSChoice2";
            this.pnlRPSChoice2.Size = new System.Drawing.Size(196, 32);
            this.pnlRPSChoice2.TabIndex = 10;
            this.pnlRPSChoice2.Tag = "Transparent,Computer";
            // 
            // radRock2
            // 
            this.radRock2.AutoSize = true;
            this.radRock2.BackColor = System.Drawing.Color.Transparent;
            this.radRock2.Enabled = false;
            this.radRock2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radRock2.Location = new System.Drawing.Point(5, 8);
            this.radRock2.Name = "radRock2";
            this.radRock2.Size = new System.Drawing.Size(51, 17);
            this.radRock2.TabIndex = 5;
            this.radRock2.TabStop = true;
            this.radRock2.Text = "Rock";
            this.radRock2.UseVisualStyleBackColor = false;
            // 
            // radPaper2
            // 
            this.radPaper2.AutoSize = true;
            this.radPaper2.Enabled = false;
            this.radPaper2.Location = new System.Drawing.Point(70, 8);
            this.radPaper2.Name = "radPaper2";
            this.radPaper2.Size = new System.Drawing.Size(53, 17);
            this.radPaper2.TabIndex = 6;
            this.radPaper2.TabStop = true;
            this.radPaper2.Text = "Paper";
            this.radPaper2.UseVisualStyleBackColor = true;
            // 
            // radScissors2
            // 
            this.radScissors2.AutoSize = true;
            this.radScissors2.Enabled = false;
            this.radScissors2.Location = new System.Drawing.Point(129, 8);
            this.radScissors2.Name = "radScissors2";
            this.radScissors2.Size = new System.Drawing.Size(64, 17);
            this.radScissors2.TabIndex = 7;
            this.radScissors2.TabStop = true;
            this.radScissors2.Text = "Scissors";
            this.radScissors2.UseVisualStyleBackColor = true;
            // 
            // picRPS2
            // 
            this.picRPS2.ErrorImage = null;
            this.picRPS2.InitialImage = null;
            this.picRPS2.Location = new System.Drawing.Point(9, 11);
            this.picRPS2.Name = "picRPS2";
            this.picRPS2.Size = new System.Drawing.Size(180, 76);
            this.picRPS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRPS2.TabIndex = 4;
            this.picRPS2.TabStop = false;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlWager);
            this.pnlBody.Controls.Add(this.lblWinIndicator);
            this.pnlBody.Controls.Add(this.chbDisableMessagebox);
            this.pnlBody.Controls.Add(this.pnlScoreDisplay);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 34;
            // 
            // pnlWager
            // 
            this.pnlWager.Controls.Add(this.numWager);
            this.pnlWager.Controls.Add(this.lblWager);
            this.pnlWager.Controls.Add(this.lblPoints);
            this.pnlWager.Controls.Add(this.lblScore);
            this.pnlWager.Controls.Add(this.lblWagerTitle);
            this.pnlWager.Location = new System.Drawing.Point(138, 13);
            this.pnlWager.Name = "pnlWager";
            this.pnlWager.Size = new System.Drawing.Size(105, 79);
            this.pnlWager.TabIndex = 6;
            // 
            // numWager
            // 
            this.numWager.Location = new System.Drawing.Point(61, 47);
            this.numWager.Name = "numWager";
            this.numWager.Size = new System.Drawing.Size(41, 20);
            this.numWager.TabIndex = 5;
            // 
            // lblWager
            // 
            this.lblWager.AutoSize = true;
            this.lblWager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWager.Location = new System.Drawing.Point(63, 31);
            this.lblWager.Name = "lblWager";
            this.lblWager.Size = new System.Drawing.Size(39, 13);
            this.lblWager.TabIndex = 3;
            this.lblWager.Text = "Wager";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(3, 31);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(3, 47);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "20";
            // 
            // lblWagerTitle
            // 
            this.lblWagerTitle.AutoSize = true;
            this.lblWagerTitle.Location = new System.Drawing.Point(4, 8);
            this.lblWagerTitle.Name = "lblWagerTitle";
            this.lblWagerTitle.Size = new System.Drawing.Size(96, 13);
            this.lblWagerTitle.TabIndex = 0;
            this.lblWagerTitle.Text = "Wager Your Points";
            // 
            // lblWinIndicator
            // 
            this.lblWinIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWinIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinIndicator.Location = new System.Drawing.Point(11, 13);
            this.lblWinIndicator.Name = "lblWinIndicator";
            this.lblWinIndicator.Size = new System.Drawing.Size(121, 59);
            this.lblWinIndicator.TabIndex = 5;
            this.lblWinIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbDisableMessagebox
            // 
            this.chbDisableMessagebox.AutoSize = true;
            this.chbDisableMessagebox.Location = new System.Drawing.Point(14, 75);
            this.chbDisableMessagebox.Name = "chbDisableMessagebox";
            this.chbDisableMessagebox.Size = new System.Drawing.Size(126, 17);
            this.chbDisableMessagebox.TabIndex = 4;
            this.chbDisableMessagebox.Text = "Enable Message Box";
            this.chbDisableMessagebox.UseVisualStyleBackColor = true;
            // 
            // pnlScoreDisplay
            // 
            this.pnlScoreDisplay.Controls.Add(this.lblDrawCount);
            this.pnlScoreDisplay.Controls.Add(this.lblComputerScore);
            this.pnlScoreDisplay.Controls.Add(this.lblTotalGames);
            this.pnlScoreDisplay.Controls.Add(this.lblDraw);
            this.pnlScoreDisplay.Controls.Add(this.lblPlayerScore);
            this.pnlScoreDisplay.Controls.Add(this.lblComputer);
            this.pnlScoreDisplay.Controls.Add(this.lblTotal);
            this.pnlScoreDisplay.Controls.Add(this.lblPlayer);
            this.pnlScoreDisplay.Location = new System.Drawing.Point(249, 13);
            this.pnlScoreDisplay.Name = "pnlScoreDisplay";
            this.pnlScoreDisplay.Size = new System.Drawing.Size(164, 79);
            this.pnlScoreDisplay.TabIndex = 3;
            // 
            // lblDrawCount
            // 
            this.lblDrawCount.AutoSize = true;
            this.lblDrawCount.Location = new System.Drawing.Point(121, 25);
            this.lblDrawCount.Name = "lblDrawCount";
            this.lblDrawCount.Size = new System.Drawing.Size(13, 13);
            this.lblDrawCount.TabIndex = 11;
            this.lblDrawCount.Text = "0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Location = new System.Drawing.Point(59, 25);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(13, 13);
            this.lblComputerScore.TabIndex = 9;
            this.lblComputerScore.Text = "0";
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.AutoSize = true;
            this.lblTotalGames.Location = new System.Drawing.Point(51, 58);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(13, 13);
            this.lblTotalGames.TabIndex = 8;
            this.lblTotalGames.Text = "0";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.Location = new System.Drawing.Point(121, 8);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(32, 13);
            this.lblDraw.TabIndex = 10;
            this.lblDraw.Text = "Draw";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(11, 25);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(13, 13);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "0";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(59, 8);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(52, 13);
            this.lblComputer.TabIndex = 6;
            this.lblComputer.Text = "Computer";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(11, 58);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(11, 8);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Player";
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
            this.lblTitle.Text = "Rock Paper Scissors";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgRPS
            // 
            this.imgRPS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgRPS.ImageStream")));
            this.imgRPS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgRPS.Images.SetKeyName(0, "RockPS.png");
            this.imgRPS.Images.SetKeyName(1, "RockPS2.png");
            this.imgRPS.Images.SetKeyName(2, "RPaperS.png");
            this.imgRPS.Images.SetKeyName(3, "RPaperS2.png");
            this.imgRPS.Images.SetKeyName(4, "RPS.png");
            this.imgRPS.Images.SetKeyName(5, "RPScissors.png");
            this.imgRPS.Images.SetKeyName(6, "RPScissors2.png");
            // 
            // Frm11RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm11RPS";
            this.Text = "Rock Paper Scissors";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlPlayer.ResumeLayout(false);
            this.pnlRPSChoice.ResumeLayout(false);
            this.pnlRPSChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRPS)).EndInit();
            this.pnlComputer.ResumeLayout(false);
            this.pnlRPSChoice2.ResumeLayout(false);
            this.pnlRPSChoice2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRPS2)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlWager.ResumeLayout(false);
            this.pnlWager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWager)).EndInit();
            this.pnlScoreDisplay.ResumeLayout(false);
            this.pnlScoreDisplay.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlScoreDisplay;
		private System.Windows.Forms.PictureBox picRPS;
		private System.Windows.Forms.Panel pnlRPSChoice;
		private System.Windows.Forms.RadioButton radPaper;
		private System.Windows.Forms.RadioButton radScissors;
		private System.Windows.Forms.RadioButton radRock;
		private System.Windows.Forms.Panel pnlPlayer;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Panel pnlComputer;
		private System.Windows.Forms.Panel pnlRPSChoice2;
		private System.Windows.Forms.RadioButton radPaper2;
		private System.Windows.Forms.RadioButton radScissors2;
		private System.Windows.Forms.RadioButton radRock2;
		private System.Windows.Forms.PictureBox picRPS2;
		private System.Windows.Forms.Label lblComputerScore;
		private System.Windows.Forms.Label lblTotalGames;
		private System.Windows.Forms.Label lblPlayerScore;
		private System.Windows.Forms.Label lblComputer;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblPlayer;
		private System.Windows.Forms.Label lblDrawCount;
		private System.Windows.Forms.Label lblDraw;
		private System.Windows.Forms.Label lblWinIndicator;
		private System.Windows.Forms.CheckBox chbDisableMessagebox;
		private System.Windows.Forms.Panel pnlWager;
		private System.Windows.Forms.NumericUpDown numWager;
		private System.Windows.Forms.Label lblWager;
		private System.Windows.Forms.Label lblPoints;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblWagerTitle;
		private System.Windows.Forms.ImageList imgRPS;
	}
}