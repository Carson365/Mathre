namespace Mathre
{
	partial class FrmVideoGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideoGames));
            this.pnlVideoGamesFrame = new System.Windows.Forms.Panel();
            this.lblVideoGamesTitle = new System.Windows.Forms.Label();
            this.pnlVideoGamesDisplay = new System.Windows.Forms.Panel();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostText = new System.Windows.Forms.Label();
            this.pnlConsole = new System.Windows.Forms.Panel();
            this.btnXB1 = new System.Windows.Forms.RadioButton();
            this.btnPS4 = new System.Windows.Forms.RadioButton();
            this.pnlVideoGames = new System.Windows.Forms.Panel();
            this.pnlMinecraft = new System.Windows.Forms.Panel();
            this.pnlStardew = new System.Windows.Forms.Panel();
            this.pnlDoom = new System.Windows.Forms.Panel();
            this.pnlDiningType = new System.Windows.Forms.Panel();
            this.txtMinecraft = new System.Windows.Forms.TextBox();
            this.lblTotalMinecraft = new System.Windows.Forms.Label();
            this.txtStardew = new System.Windows.Forms.TextBox();
            this.lblTotalStardew = new System.Windows.Forms.Label();
            this.txtDoom = new System.Windows.Forms.TextBox();
            this.lblTotalDoom = new System.Windows.Forms.Label();
            this.imgGames = new System.Windows.Forms.ImageList(this.components);
            this.pnlVideoGamesFrame.SuspendLayout();
            this.pnlVideoGamesDisplay.SuspendLayout();
            this.pnlConsole.SuspendLayout();
            this.pnlVideoGames.SuspendLayout();
            this.pnlDiningType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVideoGamesFrame
            // 
            this.pnlVideoGamesFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVideoGamesFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlVideoGamesFrame.Controls.Add(this.lblVideoGamesTitle);
            this.pnlVideoGamesFrame.Controls.Add(this.pnlVideoGamesDisplay);
            this.pnlVideoGamesFrame.Controls.Add(this.pnlVideoGames);
            this.pnlVideoGamesFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlVideoGamesFrame.Name = "pnlVideoGamesFrame";
            this.pnlVideoGamesFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlVideoGamesFrame.TabIndex = 35;
            // 
            // lblVideoGamesTitle
            // 
            this.lblVideoGamesTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVideoGamesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoGamesTitle.Location = new System.Drawing.Point(187, 95);
            this.lblVideoGamesTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblVideoGamesTitle.Name = "lblVideoGamesTitle";
            this.lblVideoGamesTitle.Size = new System.Drawing.Size(626, 51);
            this.lblVideoGamesTitle.TabIndex = 33;
            this.lblVideoGamesTitle.Text = "Video Game Orders";
            this.lblVideoGamesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlVideoGamesDisplay
            // 
            this.pnlVideoGamesDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlVideoGamesDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pnlVideoGamesDisplay.Controls.Add(this.lblCost);
            this.pnlVideoGamesDisplay.Controls.Add(this.lblCostText);
            this.pnlVideoGamesDisplay.Controls.Add(this.pnlConsole);
            this.pnlVideoGamesDisplay.Location = new System.Drawing.Point(287, 326);
            this.pnlVideoGamesDisplay.Name = "pnlVideoGamesDisplay";
            this.pnlVideoGamesDisplay.Size = new System.Drawing.Size(426, 81);
            this.pnlVideoGamesDisplay.TabIndex = 35;
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(300, 3);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(70, 75);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "lblCost";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCostText
            // 
            this.lblCostText.Location = new System.Drawing.Point(172, 3);
            this.lblCostText.Name = "lblCostText";
            this.lblCostText.Size = new System.Drawing.Size(132, 75);
            this.lblCostText.TabIndex = 1;
            this.lblCostText.Text = "lblCostText";
            this.lblCostText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlConsole
            // 
            this.pnlConsole.Controls.Add(this.btnXB1);
            this.pnlConsole.Controls.Add(this.btnPS4);
            this.pnlConsole.Location = new System.Drawing.Point(3, 3);
            this.pnlConsole.Name = "pnlConsole";
            this.pnlConsole.Size = new System.Drawing.Size(122, 75);
            this.pnlConsole.TabIndex = 0;
            this.pnlConsole.Tag = "Black";
            // 
            // btnXB1
            // 
            this.btnXB1.AutoSize = true;
            this.btnXB1.Location = new System.Drawing.Point(25, 44);
            this.btnXB1.Name = "btnXB1";
            this.btnXB1.Size = new System.Drawing.Size(72, 17);
            this.btnXB1.TabIndex = 1;
            this.btnXB1.Text = "Xbox One";
            this.btnXB1.UseVisualStyleBackColor = true;
            // 
            // btnPS4
            // 
            this.btnPS4.AutoSize = true;
            this.btnPS4.Checked = true;
            this.btnPS4.Location = new System.Drawing.Point(19, 13);
            this.btnPS4.Name = "btnPS4";
            this.btnPS4.Size = new System.Drawing.Size(85, 17);
            this.btnPS4.TabIndex = 0;
            this.btnPS4.TabStop = true;
            this.btnPS4.Text = "Playstation 4";
            this.btnPS4.UseVisualStyleBackColor = true;
            // 
            // pnlVideoGames
            // 
            this.pnlVideoGames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlVideoGames.BackColor = System.Drawing.SystemColors.Control;
            this.pnlVideoGames.Controls.Add(this.pnlMinecraft);
            this.pnlVideoGames.Controls.Add(this.pnlStardew);
            this.pnlVideoGames.Controls.Add(this.pnlDoom);
            this.pnlVideoGames.Controls.Add(this.pnlDiningType);
            this.pnlVideoGames.Location = new System.Drawing.Point(287, 165);
            this.pnlVideoGames.Name = "pnlVideoGames";
            this.pnlVideoGames.Size = new System.Drawing.Size(426, 155);
            this.pnlVideoGames.TabIndex = 34;
            // 
            // pnlMinecraft
            // 
            this.pnlMinecraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMinecraft.Location = new System.Drawing.Point(321, 6);
            this.pnlMinecraft.Name = "pnlMinecraft";
            this.pnlMinecraft.Size = new System.Drawing.Size(80, 100);
            this.pnlMinecraft.TabIndex = 36;
            this.pnlMinecraft.Tag = "Black";
            // 
            // pnlStardew
            // 
            this.pnlStardew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlStardew.Location = new System.Drawing.Point(183, 6);
            this.pnlStardew.Name = "pnlStardew";
            this.pnlStardew.Size = new System.Drawing.Size(80, 100);
            this.pnlStardew.TabIndex = 35;
            this.pnlStardew.Tag = "Black";
            // 
            // pnlDoom
            // 
            this.pnlDoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlDoom.Location = new System.Drawing.Point(45, 6);
            this.pnlDoom.Name = "pnlDoom";
            this.pnlDoom.Size = new System.Drawing.Size(80, 100);
            this.pnlDoom.TabIndex = 34;
            this.pnlDoom.Tag = "Black";
            // 
            // pnlDiningType
            // 
            this.pnlDiningType.Controls.Add(this.txtMinecraft);
            this.pnlDiningType.Controls.Add(this.lblTotalMinecraft);
            this.pnlDiningType.Controls.Add(this.txtStardew);
            this.pnlDiningType.Controls.Add(this.lblTotalStardew);
            this.pnlDiningType.Controls.Add(this.txtDoom);
            this.pnlDiningType.Controls.Add(this.lblTotalDoom);
            this.pnlDiningType.Location = new System.Drawing.Point(3, 112);
            this.pnlDiningType.Name = "pnlDiningType";
            this.pnlDiningType.Size = new System.Drawing.Size(420, 40);
            this.pnlDiningType.TabIndex = 33;
            this.pnlDiningType.Tag = "Transparent";
            // 
            // txtMinecraft
            // 
            this.txtMinecraft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMinecraft.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinecraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinecraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinecraft.Location = new System.Drawing.Point(340, 7);
            this.txtMinecraft.Margin = new System.Windows.Forms.Padding(0);
            this.txtMinecraft.Name = "txtMinecraft";
            this.txtMinecraft.Size = new System.Drawing.Size(58, 26);
            this.txtMinecraft.TabIndex = 34;
            // 
            // lblTotalMinecraft
            // 
            this.lblTotalMinecraft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalMinecraft.AutoSize = true;
            this.lblTotalMinecraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMinecraft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalMinecraft.Location = new System.Drawing.Point(293, 10);
            this.lblTotalMinecraft.Name = "lblTotalMinecraft";
            this.lblTotalMinecraft.Size = new System.Drawing.Size(44, 20);
            this.lblTotalMinecraft.TabIndex = 33;
            this.lblTotalMinecraft.Text = "Total";
            // 
            // txtStardew
            // 
            this.txtStardew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStardew.BackColor = System.Drawing.SystemColors.Window;
            this.txtStardew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStardew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStardew.Location = new System.Drawing.Point(202, 7);
            this.txtStardew.Margin = new System.Windows.Forms.Padding(0);
            this.txtStardew.Name = "txtStardew";
            this.txtStardew.Size = new System.Drawing.Size(58, 26);
            this.txtStardew.TabIndex = 32;
            // 
            // lblTotalStardew
            // 
            this.lblTotalStardew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalStardew.AutoSize = true;
            this.lblTotalStardew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStardew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalStardew.Location = new System.Drawing.Point(155, 10);
            this.lblTotalStardew.Name = "lblTotalStardew";
            this.lblTotalStardew.Size = new System.Drawing.Size(44, 20);
            this.lblTotalStardew.TabIndex = 31;
            this.lblTotalStardew.Text = "Total";
            // 
            // txtDoom
            // 
            this.txtDoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDoom.BackColor = System.Drawing.SystemColors.Window;
            this.txtDoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoom.Location = new System.Drawing.Point(64, 7);
            this.txtDoom.Margin = new System.Windows.Forms.Padding(0);
            this.txtDoom.Name = "txtDoom";
            this.txtDoom.Size = new System.Drawing.Size(58, 26);
            this.txtDoom.TabIndex = 30;
            // 
            // lblTotalDoom
            // 
            this.lblTotalDoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalDoom.AutoSize = true;
            this.lblTotalDoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDoom.Location = new System.Drawing.Point(17, 10);
            this.lblTotalDoom.Name = "lblTotalDoom";
            this.lblTotalDoom.Size = new System.Drawing.Size(44, 20);
            this.lblTotalDoom.TabIndex = 27;
            this.lblTotalDoom.Text = "Total";
            // 
            // imgGames
            // 
            this.imgGames.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgGames.ImageStream")));
            this.imgGames.TransparentColor = System.Drawing.Color.Transparent;
            this.imgGames.Images.SetKeyName(0, "Doom-XB1.jpg");
            this.imgGames.Images.SetKeyName(1, "Minecraft-XB1.jpg");
            this.imgGames.Images.SetKeyName(2, "Stardew-XB1.jpg");
            this.imgGames.Images.SetKeyName(3, "Stardew-PS4.jpg");
            this.imgGames.Images.SetKeyName(4, "Minecraft-PS4.jpg");
            this.imgGames.Images.SetKeyName(5, "Doom-PS4.jpg");
            // 
            // FrmVideoGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlVideoGamesFrame);
            this.Name = "FrmVideoGames";
            this.Text = "Video Game Orders";
            this.pnlVideoGamesFrame.ResumeLayout(false);
            this.pnlVideoGamesDisplay.ResumeLayout(false);
            this.pnlConsole.ResumeLayout(false);
            this.pnlConsole.PerformLayout();
            this.pnlVideoGames.ResumeLayout(false);
            this.pnlDiningType.ResumeLayout(false);
            this.pnlDiningType.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlVideoGamesFrame;
		internal System.Windows.Forms.Label lblVideoGamesTitle;
		private System.Windows.Forms.Panel pnlVideoGamesDisplay;
		private System.Windows.Forms.Panel pnlVideoGames;
		internal System.Windows.Forms.TextBox txtDoom;
		internal System.Windows.Forms.Label lblTotalDoom;
		private System.Windows.Forms.Panel pnlDiningType;
		internal System.Windows.Forms.TextBox txtMinecraft;
		internal System.Windows.Forms.Label lblTotalMinecraft;
		internal System.Windows.Forms.TextBox txtStardew;
		internal System.Windows.Forms.Label lblTotalStardew;
		private System.Windows.Forms.Panel pnlConsole;
		private System.Windows.Forms.RadioButton btnXB1;
		private System.Windows.Forms.RadioButton btnPS4;
		private System.Windows.Forms.Panel pnlMinecraft;
		private System.Windows.Forms.Panel pnlStardew;
		private System.Windows.Forms.Panel pnlDoom;
		private System.Windows.Forms.ImageList imgGames;
		private System.Windows.Forms.Label lblCostText;
		private System.Windows.Forms.Label lblCost;
	}
}
