namespace Mathre
{
	partial class FrmRPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRPS));
            this.pnlRPS = new System.Windows.Forms.Panel();
            this.pnlRPSGame = new System.Windows.Forms.Panel();
            this.pnlComputer = new System.Windows.Forms.Panel();
            this.pnlRPSChoice2 = new System.Windows.Forms.Panel();
            this.btnRock2 = new System.Windows.Forms.RadioButton();
            this.btnPaper2 = new System.Windows.Forms.RadioButton();
            this.btnScissors2 = new System.Windows.Forms.RadioButton();
            this.picRPS2 = new System.Windows.Forms.PictureBox();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.pnlRPSChoice = new System.Windows.Forms.Panel();
            this.btnRock = new System.Windows.Forms.RadioButton();
            this.btnPaper = new System.Windows.Forms.RadioButton();
            this.btnScissors = new System.Windows.Forms.RadioButton();
            this.picRPS = new System.Windows.Forms.PictureBox();
            this.pnlRPSSelect = new System.Windows.Forms.Panel();
            this.pnlScoreDisplay = new System.Windows.Forms.Panel();
            this.lblDrawCount = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblRPSTitle = new System.Windows.Forms.Label();
            this.pnlRPS.SuspendLayout();
            this.pnlRPSGame.SuspendLayout();
            this.pnlComputer.SuspendLayout();
            this.pnlRPSChoice2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRPS2)).BeginInit();
            this.pnlPlayer.SuspendLayout();
            this.pnlRPSChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRPS)).BeginInit();
            this.pnlRPSSelect.SuspendLayout();
            this.pnlScoreDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRPS
            // 
            this.pnlRPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRPS.BackColor = System.Drawing.Color.Transparent;
            this.pnlRPS.Controls.Add(this.pnlRPSGame);
            this.pnlRPS.Controls.Add(this.pnlRPSSelect);
            this.pnlRPS.Controls.Add(this.lblRPSTitle);
            this.pnlRPS.Location = new System.Drawing.Point(-8, -20);
            this.pnlRPS.Name = "pnlRPS";
            this.pnlRPS.Size = new System.Drawing.Size(1000, 500);
            this.pnlRPS.TabIndex = 34;
            // 
            // pnlRPSGame
            // 
            this.pnlRPSGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRPSGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlRPSGame.Controls.Add(this.pnlComputer);
            this.pnlRPSGame.Controls.Add(this.pnlPlayer);
            this.pnlRPSGame.Location = new System.Drawing.Point(287, 276);
            this.pnlRPSGame.Name = "pnlRPSGame";
            this.pnlRPSGame.Size = new System.Drawing.Size(426, 136);
            this.pnlRPSGame.TabIndex = 35;
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
            this.pnlRPSChoice2.Controls.Add(this.btnRock2);
            this.pnlRPSChoice2.Controls.Add(this.btnPaper2);
            this.pnlRPSChoice2.Controls.Add(this.btnScissors2);
            this.pnlRPSChoice2.Location = new System.Drawing.Point(9, 93);
            this.pnlRPSChoice2.Name = "pnlRPSChoice2";
            this.pnlRPSChoice2.Size = new System.Drawing.Size(196, 32);
            this.pnlRPSChoice2.TabIndex = 10;
            this.pnlRPSChoice2.Tag = "Transparent";
            // 
            // btnRock2
            // 
            this.btnRock2.AutoSize = true;
            this.btnRock2.BackColor = System.Drawing.Color.Transparent;
            this.btnRock2.Enabled = false;
            this.btnRock2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRock2.Location = new System.Drawing.Point(5, 8);
            this.btnRock2.Name = "btnRock2";
            this.btnRock2.Size = new System.Drawing.Size(51, 17);
            this.btnRock2.TabIndex = 5;
            this.btnRock2.TabStop = true;
            this.btnRock2.Text = "Rock";
            this.btnRock2.UseVisualStyleBackColor = false;
            // 
            // btnPaper2
            // 
            this.btnPaper2.AutoSize = true;
            this.btnPaper2.Enabled = false;
            this.btnPaper2.Location = new System.Drawing.Point(70, 8);
            this.btnPaper2.Name = "btnPaper2";
            this.btnPaper2.Size = new System.Drawing.Size(53, 17);
            this.btnPaper2.TabIndex = 6;
            this.btnPaper2.TabStop = true;
            this.btnPaper2.Text = "Paper";
            this.btnPaper2.UseVisualStyleBackColor = true;
            // 
            // btnScissors2
            // 
            this.btnScissors2.AutoSize = true;
            this.btnScissors2.Enabled = false;
            this.btnScissors2.Location = new System.Drawing.Point(129, 8);
            this.btnScissors2.Name = "btnScissors2";
            this.btnScissors2.Size = new System.Drawing.Size(64, 17);
            this.btnScissors2.TabIndex = 7;
            this.btnScissors2.TabStop = true;
            this.btnScissors2.Text = "Scissors";
            this.btnScissors2.UseVisualStyleBackColor = true;
            // 
            // picRPS2
            // 
            this.picRPS2.Image = ((System.Drawing.Image)(resources.GetObject("picRPS2.Image")));
            this.picRPS2.Location = new System.Drawing.Point(9, 11);
            this.picRPS2.Name = "picRPS2";
            this.picRPS2.Size = new System.Drawing.Size(180, 76);
            this.picRPS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRPS2.TabIndex = 4;
            this.picRPS2.TabStop = false;
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
            this.pnlRPSChoice.Controls.Add(this.btnRock);
            this.pnlRPSChoice.Controls.Add(this.btnPaper);
            this.pnlRPSChoice.Controls.Add(this.btnScissors);
            this.pnlRPSChoice.Location = new System.Drawing.Point(9, 93);
            this.pnlRPSChoice.Name = "pnlRPSChoice";
            this.pnlRPSChoice.Size = new System.Drawing.Size(196, 32);
            this.pnlRPSChoice.TabIndex = 10;
            this.pnlRPSChoice.Tag = "Transparent";
            // 
            // btnRock
            // 
            this.btnRock.AutoSize = true;
            this.btnRock.Location = new System.Drawing.Point(5, 8);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(51, 17);
            this.btnRock.TabIndex = 5;
            this.btnRock.TabStop = true;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            // 
            // btnPaper
            // 
            this.btnPaper.AutoSize = true;
            this.btnPaper.Location = new System.Drawing.Point(70, 8);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(53, 17);
            this.btnPaper.TabIndex = 6;
            this.btnPaper.TabStop = true;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            // 
            // btnScissors
            // 
            this.btnScissors.AutoSize = true;
            this.btnScissors.Location = new System.Drawing.Point(129, 8);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(64, 17);
            this.btnScissors.TabIndex = 7;
            this.btnScissors.TabStop = true;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            // 
            // picRPS
            // 
            this.picRPS.Image = ((System.Drawing.Image)(resources.GetObject("picRPS.Image")));
            this.picRPS.Location = new System.Drawing.Point(9, 11);
            this.picRPS.Name = "picRPS";
            this.picRPS.Size = new System.Drawing.Size(180, 76);
            this.picRPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRPS.TabIndex = 4;
            this.picRPS.TabStop = false;
            // 
            // pnlRPSSelect
            // 
            this.pnlRPSSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRPSSelect.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRPSSelect.Controls.Add(this.pnlScoreDisplay);
            this.pnlRPSSelect.Location = new System.Drawing.Point(287, 165);
            this.pnlRPSSelect.Name = "pnlRPSSelect";
            this.pnlRPSSelect.Size = new System.Drawing.Size(426, 105);
            this.pnlRPSSelect.TabIndex = 34;
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
            // lblRPSTitle
            // 
            this.lblRPSTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRPSTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPSTitle.Location = new System.Drawing.Point(187, 95);
            this.lblRPSTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblRPSTitle.Name = "lblRPSTitle";
            this.lblRPSTitle.Size = new System.Drawing.Size(626, 51);
            this.lblRPSTitle.TabIndex = 33;
            this.lblRPSTitle.Text = "Rock Paper Scissors";
            this.lblRPSTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlRPS);
            this.Name = "FrmRPS";
            this.Text = "Rock Paper Scissors";
            this.pnlRPS.ResumeLayout(false);
            this.pnlRPSGame.ResumeLayout(false);
            this.pnlComputer.ResumeLayout(false);
            this.pnlRPSChoice2.ResumeLayout(false);
            this.pnlRPSChoice2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRPS2)).EndInit();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlRPSChoice.ResumeLayout(false);
            this.pnlRPSChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRPS)).EndInit();
            this.pnlRPSSelect.ResumeLayout(false);
            this.pnlScoreDisplay.ResumeLayout(false);
            this.pnlScoreDisplay.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlRPS;
		private System.Windows.Forms.Panel pnlRPSSelect;
		internal System.Windows.Forms.Label lblRPSTitle;
		private System.Windows.Forms.Panel pnlScoreDisplay;
		private System.Windows.Forms.PictureBox picRPS;
		private System.Windows.Forms.Panel pnlRPSChoice;
		private System.Windows.Forms.RadioButton btnPaper;
		private System.Windows.Forms.RadioButton btnScissors;
		private System.Windows.Forms.RadioButton btnRock;
		private System.Windows.Forms.Panel pnlPlayer;
		private System.Windows.Forms.Panel pnlRPSGame;
		private System.Windows.Forms.Panel pnlComputer;
		private System.Windows.Forms.Panel pnlRPSChoice2;
		private System.Windows.Forms.RadioButton btnPaper2;
		private System.Windows.Forms.RadioButton btnScissors2;
		private System.Windows.Forms.RadioButton btnRock2;
		private System.Windows.Forms.PictureBox picRPS2;
		private System.Windows.Forms.Label lblComputerScore;
		private System.Windows.Forms.Label lblTotalGames;
		private System.Windows.Forms.Label lblPlayerScore;
		private System.Windows.Forms.Label lblComputer;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblPlayer;
		private System.Windows.Forms.Label lblDrawCount;
		private System.Windows.Forms.Label lblDraw;
	}
}