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
			((System.ComponentModel.ISupportInitialize)(this.picShooter)).BeginInit();
			this.SuspendLayout();
			// 
			// picShooter
			// 
			this.picShooter.Image = global::Mathre.Resources.Invader;
			this.picShooter.Location = new System.Drawing.Point(282, 190);
			this.picShooter.Name = "picShooter";
			this.picShooter.Size = new System.Drawing.Size(50, 50);
			this.picShooter.TabIndex = 0;
			this.picShooter.TabStop = false;
			// 
			// Frm24bInvadersGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 431);
			this.Controls.Add(this.picShooter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm24bInvadersGame";
			this.Text = "EZ Invaders";
			((System.ComponentModel.ISupportInitialize)(this.picShooter)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picShooter;
	}
}