
namespace Mathre
{
	partial class Frm04MyFavorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm04MyFavorites));
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.pnlFavoriteImage = new System.Windows.Forms.Panel();
            this.lblFavoriteInfo = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.radFavoriteMovie = new System.Windows.Forms.RadioButton();
            this.radFavoriteHobby = new System.Windows.Forms.RadioButton();
            this.radFavoriteColor = new System.Windows.Forms.RadioButton();
            this.radFavoriteActor = new System.Windows.Forms.RadioButton();
            this.radFavoriteFruit = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgFavoriteImages = new System.Windows.Forms.ImageList(this.components);
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
            this.pnlFrame.TabIndex = 33;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Controls.Add(this.pnlFavoriteImage);
            this.pnlBody2.Controls.Add(this.lblFavoriteInfo);
            this.pnlBody2.Location = new System.Drawing.Point(287, 261);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 36;
            // 
            // pnlFavoriteImage
            // 
            this.pnlFavoriteImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFavoriteImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlFavoriteImage.Location = new System.Drawing.Point(19, 18);
            this.pnlFavoriteImage.Name = "pnlFavoriteImage";
            this.pnlFavoriteImage.Size = new System.Drawing.Size(100, 100);
            this.pnlFavoriteImage.TabIndex = 26;
            // 
            // lblFavoriteInfo
            // 
            this.lblFavoriteInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFavoriteInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFavoriteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoriteInfo.Location = new System.Drawing.Point(137, 18);
            this.lblFavoriteInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblFavoriteInfo.Name = "lblFavoriteInfo";
            this.lblFavoriteInfo.Size = new System.Drawing.Size(270, 100);
            this.lblFavoriteInfo.TabIndex = 20;
            this.lblFavoriteInfo.Text = "My Favorite __________";
            this.lblFavoriteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.radFavoriteMovie);
            this.pnlBody.Controls.Add(this.radFavoriteHobby);
            this.pnlBody.Controls.Add(this.radFavoriteColor);
            this.pnlBody.Controls.Add(this.radFavoriteActor);
            this.pnlBody.Controls.Add(this.radFavoriteFruit);
            this.pnlBody.Location = new System.Drawing.Point(287, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 34;
            // 
            // radFavoriteMovie
            // 
            this.radFavoriteMovie.AutoSize = true;
            this.radFavoriteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFavoriteMovie.Location = new System.Drawing.Point(102, 55);
            this.radFavoriteMovie.Name = "radFavoriteMovie";
            this.radFavoriteMovie.Size = new System.Drawing.Size(68, 24);
            this.radFavoriteMovie.TabIndex = 24;
            this.radFavoriteMovie.Text = "Movie";
            this.radFavoriteMovie.UseVisualStyleBackColor = true;
            // 
            // radFavoriteHobby
            // 
            this.radFavoriteHobby.AutoSize = true;
            this.radFavoriteHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFavoriteHobby.Location = new System.Drawing.Point(252, 55);
            this.radFavoriteHobby.Name = "radFavoriteHobby";
            this.radFavoriteHobby.Size = new System.Drawing.Size(73, 24);
            this.radFavoriteHobby.TabIndex = 21;
            this.radFavoriteHobby.Text = "Hobby";
            this.radFavoriteHobby.UseVisualStyleBackColor = true;
            // 
            // radFavoriteColor
            // 
            this.radFavoriteColor.AutoSize = true;
            this.radFavoriteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFavoriteColor.Location = new System.Drawing.Point(334, 26);
            this.radFavoriteColor.Name = "radFavoriteColor";
            this.radFavoriteColor.Size = new System.Drawing.Size(64, 24);
            this.radFavoriteColor.TabIndex = 22;
            this.radFavoriteColor.Text = "Color";
            this.radFavoriteColor.UseVisualStyleBackColor = true;
            // 
            // radFavoriteActor
            // 
            this.radFavoriteActor.AutoSize = true;
            this.radFavoriteActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFavoriteActor.Location = new System.Drawing.Point(28, 26);
            this.radFavoriteActor.Name = "radFavoriteActor";
            this.radFavoriteActor.Size = new System.Drawing.Size(65, 24);
            this.radFavoriteActor.TabIndex = 20;
            this.radFavoriteActor.Text = "Actor";
            this.radFavoriteActor.UseVisualStyleBackColor = true;
            // 
            // radFavoriteFruit
            // 
            this.radFavoriteFruit.AutoSize = true;
            this.radFavoriteFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFavoriteFruit.Location = new System.Drawing.Point(184, 26);
            this.radFavoriteFruit.Name = "radFavoriteFruit";
            this.radFavoriteFruit.Size = new System.Drawing.Size(59, 24);
            this.radFavoriteFruit.TabIndex = 23;
            this.radFavoriteFruit.Text = "Fruit";
            this.radFavoriteFruit.UseVisualStyleBackColor = true;
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
            this.lblTitle.Text = "My Favorite __________";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFavoriteImages
            // 
            this.imgFavoriteImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFavoriteImages.ImageStream")));
            this.imgFavoriteImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFavoriteImages.Images.SetKeyName(0, "Actor.jpg");
            this.imgFavoriteImages.Images.SetKeyName(1, "Fruit.jpg");
            this.imgFavoriteImages.Images.SetKeyName(2, "Hobby.jpg");
            this.imgFavoriteImages.Images.SetKeyName(3, "Movie.jpg");
            // 
            // Frm04MyFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm04MyFavorites";
            this.Text = "My Favorites";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.RadioButton radFavoriteMovie;
		private System.Windows.Forms.RadioButton radFavoriteHobby;
		private System.Windows.Forms.RadioButton radFavoriteColor;
		private System.Windows.Forms.RadioButton radFavoriteActor;
		private System.Windows.Forms.RadioButton radFavoriteFruit;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Panel pnlFavoriteImage;
		internal System.Windows.Forms.Label lblFavoriteInfo;
		public System.Windows.Forms.ImageList imgFavoriteImages;
	}
}
