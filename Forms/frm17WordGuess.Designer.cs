﻿namespace Mathre
{
	partial class Frm17WordGuess
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
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.chbSounds = new System.Windows.Forms.CheckBox();
            this.chbHide = new System.Windows.Forms.CheckBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblGuessCount = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            this.pnlBody.SuspendLayout();
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
            this.pnlBody2.Controls.Add(this.lblPhrase);
            this.pnlBody2.Location = new System.Drawing.Point(287, 276);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 36;
            // 
            // lblPhrase
            // 
            this.lblPhrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblPhrase.Location = new System.Drawing.Point(0, 0);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(426, 136);
            this.lblPhrase.TabIndex = 25;
            this.lblPhrase.Text = "Word To Guess";
            this.lblPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.lblTime);
            this.pnlBody.Controls.Add(this.lblElapsed);
            this.pnlBody.Controls.Add(this.chbSounds);
            this.pnlBody.Controls.Add(this.chbHide);
            this.pnlBody.Controls.Add(this.lblPlayer2);
            this.pnlBody.Controls.Add(this.lblPlayer1);
            this.pnlBody.Controls.Add(this.lblGuessCount);
            this.pnlBody.Controls.Add(this.txtP2);
            this.pnlBody.Controls.Add(this.txtP1);
            this.pnlBody.Controls.Add(this.lblGuesses);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 32;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(408, 87);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 30;
            this.lblTime.Text = "0";
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Location = new System.Drawing.Point(331, 87);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(71, 13);
            this.lblElapsed.TabIndex = 29;
            this.lblElapsed.Text = "ElapsedTime:";
            // 
            // chbSounds
            // 
            this.chbSounds.AutoSize = true;
            this.chbSounds.Checked = true;
            this.chbSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSounds.Location = new System.Drawing.Point(309, 38);
            this.chbSounds.Name = "chbSounds";
            this.chbSounds.Size = new System.Drawing.Size(85, 17);
            this.chbSounds.TabIndex = 28;
            this.chbSounds.Text = "Play Sounds";
            this.chbSounds.UseVisualStyleBackColor = true;
            // 
            // chbHide
            // 
            this.chbHide.AutoSize = true;
            this.chbHide.Location = new System.Drawing.Point(309, 15);
            this.chbHide.Name = "chbHide";
            this.chbHide.Size = new System.Drawing.Size(48, 17);
            this.chbHide.TabIndex = 27;
            this.chbHide.Text = "Hide";
            this.chbHide.UseVisualStyleBackColor = true;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(11, 69);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(69, 13);
            this.lblPlayer2.TabIndex = 24;
            this.lblPlayer2.Text = "Player 2 char";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(11, 22);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(73, 13);
            this.lblPlayer1.TabIndex = 23;
            this.lblPlayer1.Text = "Player 1 string";
            // 
            // lblGuessCount
            // 
            this.lblGuessCount.AutoSize = true;
            this.lblGuessCount.Location = new System.Drawing.Point(408, 63);
            this.lblGuessCount.Name = "lblGuessCount";
            this.lblGuessCount.Size = new System.Drawing.Size(13, 13);
            this.lblGuessCount.TabIndex = 26;
            this.lblGuessCount.Text = "0";
            // 
            // txtP2
            // 
            this.txtP2.BackColor = System.Drawing.SystemColors.Window;
            this.txtP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP2.Location = new System.Drawing.Point(103, 56);
            this.txtP2.Margin = new System.Windows.Forms.Padding(0);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(200, 26);
            this.txtP2.TabIndex = 22;
            // 
            // txtP1
            // 
            this.txtP1.BackColor = System.Drawing.SystemColors.Window;
            this.txtP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP1.Location = new System.Drawing.Point(103, 9);
            this.txtP1.Margin = new System.Windows.Forms.Padding(0);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(200, 26);
            this.txtP1.TabIndex = 21;
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Location = new System.Drawing.Point(306, 63);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(96, 13);
            this.lblGuesses.TabIndex = 25;
            this.lblGuesses.Text = "Incorrect Guesses:";
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
            this.lblTitle.Text = "Word Guess Game";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            // 
            // Frm17WordGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm17WordGuess";
            this.Text = "Word Guess Game";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Label lblPlayer2;
		private System.Windows.Forms.Label lblPlayer1;
		internal System.Windows.Forms.TextBox txtP2;
		internal System.Windows.Forms.TextBox txtP1;
		private System.Windows.Forms.Label lblPhrase;
		private System.Windows.Forms.Label lblGuesses;
		private System.Windows.Forms.Label lblGuessCount;
		private System.Windows.Forms.CheckBox chbHide;
		private System.Windows.Forms.CheckBox chbSounds;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblElapsed;
		private System.Windows.Forms.Timer tmrTime;
	}
}