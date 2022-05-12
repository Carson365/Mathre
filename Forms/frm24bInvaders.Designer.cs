namespace Mathre
{
	partial class Frm24bInvaders
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
            this.picShooter = new System.Windows.Forms.PictureBox();
            this.picShot = new System.Windows.Forms.PictureBox();
            this.picInvader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvader)).BeginInit();
            this.SuspendLayout();
            // 
            // picShooter
            // 
            this.picShooter.BackColor = System.Drawing.Color.Transparent;
            this.picShooter.Image = global::Mathre.Resources.Shooter;
            this.picShooter.Location = new System.Drawing.Point(1, 386);
            this.picShooter.Name = "picShooter";
            this.picShooter.Size = new System.Drawing.Size(50, 50);
            this.picShooter.TabIndex = 0;
            this.picShooter.TabStop = false;
            // 
            // picShot
            // 
            this.picShot.BackColor = System.Drawing.Color.Red;
            this.picShot.Location = new System.Drawing.Point(152, 338);
            this.picShot.Name = "picShot";
            this.picShot.Size = new System.Drawing.Size(10, 20);
            this.picShot.TabIndex = 1;
            this.picShot.TabStop = false;
            this.picShot.Visible = false;
            // 
            // picInvader
            // 
            this.picInvader.Image = global::Mathre.Resources.Invader;
            this.picInvader.Location = new System.Drawing.Point(1, 1);
            this.picInvader.Name = "picInvader";
            this.picInvader.Size = new System.Drawing.Size(50, 50);
            this.picInvader.TabIndex = 2;
            this.picInvader.TabStop = false;
            this.picInvader.Visible = false;
            // 
            // Frm24bInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 431);
            this.Controls.Add(this.picInvader);
            this.Controls.Add(this.picShot);
            this.Controls.Add(this.picShooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm24bInvaders";
            this.Text = "EZ Invaders";
            ((System.ComponentModel.ISupportInitialize)(this.picShooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvader)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox picShot;
		private System.Windows.Forms.PictureBox picInvader;
		public System.Windows.Forms.PictureBox picShooter;
	}
}