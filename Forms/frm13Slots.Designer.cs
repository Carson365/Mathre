namespace Mathre
{
	partial class FrmSlots
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
            this.pnlSlots = new System.Windows.Forms.Panel();
            this.pnlSlotsGame = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlSlotsActions = new System.Windows.Forms.Panel();
            this.lblWinIndicator = new System.Windows.Forms.Label();
            this.pnlWager = new System.Windows.Forms.Panel();
            this.btnSpin = new System.Windows.Forms.Button();
            this.chbDouble = new System.Windows.Forms.CheckBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.chbMessage = new System.Windows.Forms.CheckBox();
            this.lblSlotsTitle = new System.Windows.Forms.Label();
            this.pnlSlots.SuspendLayout();
            this.pnlSlotsGame.SuspendLayout();
            this.pnlSlotsActions.SuspendLayout();
            this.pnlWager.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSlots
            // 
            this.pnlSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSlots.BackColor = System.Drawing.Color.Transparent;
            this.pnlSlots.Controls.Add(this.pnlSlotsGame);
            this.pnlSlots.Controls.Add(this.pnlSlotsActions);
            this.pnlSlots.Controls.Add(this.lblSlotsTitle);
            this.pnlSlots.Location = new System.Drawing.Point(-8, -20);
            this.pnlSlots.Name = "pnlSlots";
            this.pnlSlots.Size = new System.Drawing.Size(1000, 500);
            this.pnlSlots.TabIndex = 35;
            // 
            // pnlSlotsGame
            // 
            this.pnlSlotsGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSlotsGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlSlotsGame.Controls.Add(this.lbl3);
            this.pnlSlotsGame.Controls.Add(this.lbl2);
            this.pnlSlotsGame.Controls.Add(this.lbl1);
            this.pnlSlotsGame.Location = new System.Drawing.Point(287, 276);
            this.pnlSlotsGame.Name = "pnlSlotsGame";
            this.pnlSlotsGame.Size = new System.Drawing.Size(426, 136);
            this.pnlSlotsGame.TabIndex = 35;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(290, 62);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(71, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Spin Wheel 3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(196, 62);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(71, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Spin Wheel 2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(102, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Spin Wheel 1";
            // 
            // pnlSlotsActions
            // 
            this.pnlSlotsActions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSlotsActions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSlotsActions.Controls.Add(this.lblWinIndicator);
            this.pnlSlotsActions.Controls.Add(this.pnlWager);
            this.pnlSlotsActions.Controls.Add(this.chbMessage);
            this.pnlSlotsActions.Location = new System.Drawing.Point(287, 165);
            this.pnlSlotsActions.Name = "pnlSlotsActions";
            this.pnlSlotsActions.Size = new System.Drawing.Size(426, 105);
            this.pnlSlotsActions.TabIndex = 34;
            // 
            // lblWinIndicator
            // 
            this.lblWinIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWinIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinIndicator.Location = new System.Drawing.Point(11, 13);
            this.lblWinIndicator.Name = "lblWinIndicator";
            this.lblWinIndicator.Size = new System.Drawing.Size(197, 59);
            this.lblWinIndicator.TabIndex = 5;
            this.lblWinIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWager
            // 
            this.pnlWager.Controls.Add(this.btnSpin);
            this.pnlWager.Controls.Add(this.chbDouble);
            this.pnlWager.Controls.Add(this.lblPoints);
            this.pnlWager.Controls.Add(this.lblScore);
            this.pnlWager.Location = new System.Drawing.Point(214, 13);
            this.pnlWager.Name = "pnlWager";
            this.pnlWager.Size = new System.Drawing.Size(199, 79);
            this.pnlWager.TabIndex = 6;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(98, 16);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 4;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            // 
            // chbDouble
            // 
            this.chbDouble.AutoSize = true;
            this.chbDouble.Location = new System.Drawing.Point(78, 45);
            this.chbDouble.Name = "chbDouble";
            this.chbDouble.Size = new System.Drawing.Size(114, 17);
            this.chbDouble.TabIndex = 3;
            this.chbDouble.Text = "Double Or Nothing";
            this.chbDouble.UseVisualStyleBackColor = true;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(7, 21);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(43, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Tokens";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(16, 42);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "100";
            // 
            // chbMessage
            // 
            this.chbMessage.AutoSize = true;
            this.chbMessage.Location = new System.Drawing.Point(14, 75);
            this.chbMessage.Name = "chbMessage";
            this.chbMessage.Size = new System.Drawing.Size(126, 17);
            this.chbMessage.TabIndex = 4;
            this.chbMessage.Text = "Enable Message Box";
            this.chbMessage.UseVisualStyleBackColor = true;
            // 
            // lblSlotsTitle
            // 
            this.lblSlotsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSlotsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotsTitle.Location = new System.Drawing.Point(187, 95);
            this.lblSlotsTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSlotsTitle.Name = "lblSlotsTitle";
            this.lblSlotsTitle.Size = new System.Drawing.Size(626, 51);
            this.lblSlotsTitle.TabIndex = 33;
            this.lblSlotsTitle.Text = "Slot Machine";
            this.lblSlotsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlSlots);
            this.Name = "FrmSlots";
            this.Text = "Slot Machine";
            this.pnlSlots.ResumeLayout(false);
            this.pnlSlotsGame.ResumeLayout(false);
            this.pnlSlotsGame.PerformLayout();
            this.pnlSlotsActions.ResumeLayout(false);
            this.pnlSlotsActions.PerformLayout();
            this.pnlWager.ResumeLayout(false);
            this.pnlWager.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlSlots;
		private System.Windows.Forms.Panel pnlSlotsGame;
		private System.Windows.Forms.Panel pnlSlotsActions;
		private System.Windows.Forms.CheckBox chbMessage;
		internal System.Windows.Forms.Label lblSlotsTitle;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Panel pnlWager;
		private System.Windows.Forms.Button btnSpin;
		private System.Windows.Forms.CheckBox chbDouble;
		private System.Windows.Forms.Label lblPoints;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblWinIndicator;
	}
}