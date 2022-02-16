
namespace Mathre
{
	partial class Frm08Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm08Pizza));
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.pnlPizzaViewer = new System.Windows.Forms.Panel();
            this.lblPizzaCostAmount = new System.Windows.Forms.Label();
            this.lblPizzaCost = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlText1 = new System.Windows.Forms.Panel();
            this.txtPizzaSize = new System.Windows.Forms.TextBox();
            this.pnlText2 = new System.Windows.Forms.Panel();
            this.txtPizzaTip = new System.Windows.Forms.TextBox();
            this.pnlDiningType = new System.Windows.Forms.Panel();
            this.radTakeout = new System.Windows.Forms.RadioButton();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.pnlTip = new System.Windows.Forms.Panel();
            this.radDollars = new System.Windows.Forms.RadioButton();
            this.radPercent = new System.Windows.Forms.RadioButton();
            this.lblPizzaTip = new System.Windows.Forms.Label();
            this.imgFavoriteImages = new System.Windows.Forms.ImageList(this.components);
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlText1.SuspendLayout();
            this.pnlText2.SuspendLayout();
            this.pnlDiningType.SuspendLayout();
            this.pnlTip.SuspendLayout();
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
            this.pnlFrame.TabIndex = 33;
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
            this.lblTitle.Text = "Pizza Delivery";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Controls.Add(this.pnlPizzaViewer);
            this.pnlBody2.Controls.Add(this.lblPizzaCostAmount);
            this.pnlBody2.Controls.Add(this.lblPizzaCost);
            this.pnlBody2.Location = new System.Drawing.Point(287, 276);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 81);
            this.pnlBody2.TabIndex = 35;
            // 
            // pnlPizzaViewer
            // 
            this.pnlPizzaViewer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPizzaViewer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPizzaViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPizzaViewer.Location = new System.Drawing.Point(351, 5);
            this.pnlPizzaViewer.Name = "pnlPizzaViewer";
            this.pnlPizzaViewer.Size = new System.Drawing.Size(70, 70);
            this.pnlPizzaViewer.TabIndex = 29;
            this.pnlPizzaViewer.Tag = "Black";
            // 
            // lblPizzaCostAmount
            // 
            this.lblPizzaCostAmount.AutoSize = true;
            this.lblPizzaCostAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaCostAmount.Location = new System.Drawing.Point(70, 33);
            this.lblPizzaCostAmount.Name = "lblPizzaCostAmount";
            this.lblPizzaCostAmount.Size = new System.Drawing.Size(137, 15);
            this.lblPizzaCostAmount.TabIndex = 16;
            this.lblPizzaCostAmount.Text = "Not Enough Information";
            this.lblPizzaCostAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPizzaCost
            // 
            this.lblPizzaCost.AutoSize = true;
            this.lblPizzaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizzaCost.Location = new System.Drawing.Point(18, 30);
            this.lblPizzaCost.Name = "lblPizzaCost";
            this.lblPizzaCost.Size = new System.Drawing.Size(46, 20);
            this.lblPizzaCost.TabIndex = 14;
            this.lblPizzaCost.Text = "Cost:";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlText1);
            this.pnlBody.Controls.Add(this.pnlText2);
            this.pnlBody.Controls.Add(this.pnlDiningType);
            this.pnlBody.Controls.Add(this.lblPizzaSize);
            this.pnlBody.Controls.Add(this.pnlTip);
            this.pnlBody.Controls.Add(this.lblPizzaTip);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 34;
            // 
            // pnlText1
            // 
            this.pnlText1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlText1.BackColor = System.Drawing.Color.Transparent;
            this.pnlText1.Controls.Add(this.txtPizzaSize);
            this.pnlText1.Location = new System.Drawing.Point(127, 13);
            this.pnlText1.Name = "pnlText1";
            this.pnlText1.Size = new System.Drawing.Size(90, 26);
            this.pnlText1.TabIndex = 37;
            this.pnlText1.Tag = "Transparent,Size (Inches)";
            // 
            // txtPizzaSize
            // 
            this.txtPizzaSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtPizzaSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPizzaSize.Location = new System.Drawing.Point(0, 0);
            this.txtPizzaSize.Margin = new System.Windows.Forms.Padding(0);
            this.txtPizzaSize.Name = "txtPizzaSize";
            this.txtPizzaSize.Size = new System.Drawing.Size(90, 26);
            this.txtPizzaSize.TabIndex = 13;
            // 
            // pnlText2
            // 
            this.pnlText2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlText2.BackColor = System.Drawing.Color.Transparent;
            this.pnlText2.Controls.Add(this.txtPizzaTip);
            this.pnlText2.Location = new System.Drawing.Point(55, 61);
            this.pnlText2.Name = "pnlText2";
            this.pnlText2.Size = new System.Drawing.Size(162, 26);
            this.pnlText2.TabIndex = 36;
            this.pnlText2.Tag = "Transparent,Tip";
            // 
            // txtPizzaTip
            // 
            this.txtPizzaTip.BackColor = System.Drawing.SystemColors.Window;
            this.txtPizzaTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPizzaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPizzaTip.Location = new System.Drawing.Point(0, 0);
            this.txtPizzaTip.Margin = new System.Windows.Forms.Padding(0);
            this.txtPizzaTip.Name = "txtPizzaTip";
            this.txtPizzaTip.Size = new System.Drawing.Size(162, 26);
            this.txtPizzaTip.TabIndex = 30;
            // 
            // pnlDiningType
            // 
            this.pnlDiningType.Controls.Add(this.radTakeout);
            this.pnlDiningType.Controls.Add(this.radDelivery);
            this.pnlDiningType.Location = new System.Drawing.Point(220, 12);
            this.pnlDiningType.Name = "pnlDiningType";
            this.pnlDiningType.Size = new System.Drawing.Size(199, 42);
            this.pnlDiningType.TabIndex = 33;
            this.pnlDiningType.Tag = "Transparent";
            // 
            // radTakeout
            // 
            this.radTakeout.AutoSize = true;
            this.radTakeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTakeout.Location = new System.Drawing.Point(8, 3);
            this.radTakeout.Name = "radTakeout";
            this.radTakeout.Size = new System.Drawing.Size(85, 24);
            this.radTakeout.TabIndex = 25;
            this.radTakeout.Text = "Takeout";
            this.radTakeout.UseVisualStyleBackColor = true;
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDelivery.Location = new System.Drawing.Point(109, 4);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(82, 24);
            this.radDelivery.TabIndex = 26;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizzaSize.Location = new System.Drawing.Point(18, 16);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(106, 20);
            this.lblPizzaSize.TabIndex = 9;
            this.lblPizzaSize.Text = "Size (Inches):";
            // 
            // pnlTip
            // 
            this.pnlTip.Controls.Add(this.radDollars);
            this.pnlTip.Controls.Add(this.radPercent);
            this.pnlTip.Location = new System.Drawing.Point(220, 60);
            this.pnlTip.Name = "pnlTip";
            this.pnlTip.Size = new System.Drawing.Size(199, 42);
            this.pnlTip.TabIndex = 27;
            this.pnlTip.Tag = "Transparent";
            // 
            // radDollars
            // 
            this.radDollars.AutoSize = true;
            this.radDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDollars.Location = new System.Drawing.Point(8, 3);
            this.radDollars.Name = "radDollars";
            this.radDollars.Size = new System.Drawing.Size(76, 24);
            this.radDollars.TabIndex = 31;
            this.radDollars.Text = "Dollars";
            this.radDollars.UseVisualStyleBackColor = true;
            // 
            // radPercent
            // 
            this.radPercent.AutoSize = true;
            this.radPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPercent.Location = new System.Drawing.Point(109, 3);
            this.radPercent.Name = "radPercent";
            this.radPercent.Size = new System.Drawing.Size(82, 24);
            this.radPercent.TabIndex = 32;
            this.radPercent.Text = "Percent";
            this.radPercent.UseVisualStyleBackColor = true;
            // 
            // lblPizzaTip
            // 
            this.lblPizzaTip.AutoSize = true;
            this.lblPizzaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaTip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizzaTip.Location = new System.Drawing.Point(18, 64);
            this.lblPizzaTip.Name = "lblPizzaTip";
            this.lblPizzaTip.Size = new System.Drawing.Size(34, 20);
            this.lblPizzaTip.TabIndex = 27;
            this.lblPizzaTip.Text = "Tip:";
            // 
            // imgFavoriteImages
            // 
            this.imgFavoriteImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFavoriteImages.ImageStream")));
            this.imgFavoriteImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFavoriteImages.Images.SetKeyName(0, "LargePizza.png");
            this.imgFavoriteImages.Images.SetKeyName(1, "MediumPizza.png");
            this.imgFavoriteImages.Images.SetKeyName(2, "SmallPizza.png");
            // 
            // Frm08Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm08Pizza";
            this.Text = "Pizza Delivery";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody2.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlText1.ResumeLayout(false);
            this.pnlText1.PerformLayout();
            this.pnlText2.ResumeLayout(false);
            this.pnlText2.PerformLayout();
            this.pnlDiningType.ResumeLayout(false);
            this.pnlDiningType.PerformLayout();
            this.pnlTip.ResumeLayout(false);
            this.pnlTip.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Panel pnlPizzaViewer;
		private System.Windows.Forms.Label lblPizzaCostAmount;
		internal System.Windows.Forms.Label lblPizzaCost;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.Panel pnlDiningType;
		private System.Windows.Forms.RadioButton radTakeout;
		private System.Windows.Forms.RadioButton radDelivery;
		internal System.Windows.Forms.Label lblPizzaSize;
		internal System.Windows.Forms.TextBox txtPizzaTip;
		private System.Windows.Forms.Panel pnlTip;
		private System.Windows.Forms.RadioButton radPercent;
		private System.Windows.Forms.RadioButton radDollars;
		internal System.Windows.Forms.Label lblPizzaTip;
		internal System.Windows.Forms.TextBox txtPizzaSize;
		internal System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.ImageList imgFavoriteImages;
		private System.Windows.Forms.Panel pnlText1;
		private System.Windows.Forms.Panel pnlText2;
	}
}
