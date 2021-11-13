
namespace Mathre
{
	partial class FrmPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizza));
            this.pnlSecretFrame = new System.Windows.Forms.Panel();
            this.lblPizzaTitle = new System.Windows.Forms.Label();
            this.pnlPizzaCost = new System.Windows.Forms.Panel();
            this.pnlPizzaViewer = new System.Windows.Forms.Panel();
            this.lblPizzaCostAmount = new System.Windows.Forms.Label();
            this.lblPizzaCost = new System.Windows.Forms.Label();
            this.pnlPizza = new System.Windows.Forms.Panel();
            this.pnlDiningType = new System.Windows.Forms.Panel();
            this.btnTakeout = new System.Windows.Forms.RadioButton();
            this.btnDelivery = new System.Windows.Forms.RadioButton();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.txtPizzaTip = new System.Windows.Forms.TextBox();
            this.pnlTip = new System.Windows.Forms.Panel();
            this.btnPercent = new System.Windows.Forms.RadioButton();
            this.btnDollars = new System.Windows.Forms.RadioButton();
            this.lblPizzaTip = new System.Windows.Forms.Label();
            this.txtPizzaSize = new System.Windows.Forms.TextBox();
            this.imgFavoriteImages = new System.Windows.Forms.ImageList(this.components);
            this.pnlSecretFrame.SuspendLayout();
            this.pnlPizzaCost.SuspendLayout();
            this.pnlPizza.SuspendLayout();
            this.pnlDiningType.SuspendLayout();
            this.pnlTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSecretFrame
            // 
            this.pnlSecretFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecretFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecretFrame.Controls.Add(this.lblPizzaTitle);
            this.pnlSecretFrame.Controls.Add(this.pnlPizzaCost);
            this.pnlSecretFrame.Controls.Add(this.pnlPizza);
            this.pnlSecretFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlSecretFrame.Name = "pnlSecretFrame";
            this.pnlSecretFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlSecretFrame.TabIndex = 33;
            // 
            // lblPizzaTitle
            // 
            this.lblPizzaTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPizzaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaTitle.Location = new System.Drawing.Point(187, 95);
            this.lblPizzaTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblPizzaTitle.Name = "lblPizzaTitle";
            this.lblPizzaTitle.Size = new System.Drawing.Size(626, 51);
            this.lblPizzaTitle.TabIndex = 33;
            this.lblPizzaTitle.Text = "Pizza Delivery";
            this.lblPizzaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPizzaCost
            // 
            this.pnlPizzaCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPizzaCost.BackColor = System.Drawing.Color.Transparent;
            this.pnlPizzaCost.Controls.Add(this.pnlPizzaViewer);
            this.pnlPizzaCost.Controls.Add(this.lblPizzaCostAmount);
            this.pnlPizzaCost.Controls.Add(this.lblPizzaCost);
            this.pnlPizzaCost.Location = new System.Drawing.Point(287, 276);
            this.pnlPizzaCost.Name = "pnlPizzaCost";
            this.pnlPizzaCost.Size = new System.Drawing.Size(426, 81);
            this.pnlPizzaCost.TabIndex = 35;
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
            // pnlPizza
            // 
            this.pnlPizza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPizza.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPizza.Controls.Add(this.pnlDiningType);
            this.pnlPizza.Controls.Add(this.lblPizzaSize);
            this.pnlPizza.Controls.Add(this.txtPizzaTip);
            this.pnlPizza.Controls.Add(this.pnlTip);
            this.pnlPizza.Controls.Add(this.lblPizzaTip);
            this.pnlPizza.Controls.Add(this.txtPizzaSize);
            this.pnlPizza.Location = new System.Drawing.Point(287, 165);
            this.pnlPizza.Name = "pnlPizza";
            this.pnlPizza.Size = new System.Drawing.Size(426, 105);
            this.pnlPizza.TabIndex = 34;
            // 
            // pnlDiningType
            // 
            this.pnlDiningType.Controls.Add(this.btnTakeout);
            this.pnlDiningType.Controls.Add(this.btnDelivery);
            this.pnlDiningType.Location = new System.Drawing.Point(220, 12);
            this.pnlDiningType.Name = "pnlDiningType";
            this.pnlDiningType.Size = new System.Drawing.Size(199, 42);
            this.pnlDiningType.TabIndex = 33;
            this.pnlDiningType.Tag = "Transparent";
            // 
            // btnTakeout
            // 
            this.btnTakeout.AutoSize = true;
            this.btnTakeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeout.Location = new System.Drawing.Point(8, 3);
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.Size = new System.Drawing.Size(85, 24);
            this.btnTakeout.TabIndex = 25;
            this.btnTakeout.Text = "Takeout";
            this.btnTakeout.UseVisualStyleBackColor = true;
            // 
            // btnDelivery
            // 
            this.btnDelivery.AutoSize = true;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.Location = new System.Drawing.Point(109, 4);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(82, 24);
            this.btnDelivery.TabIndex = 26;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
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
            // txtPizzaTip
            // 
            this.txtPizzaTip.BackColor = System.Drawing.SystemColors.Window;
            this.txtPizzaTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPizzaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPizzaTip.Location = new System.Drawing.Point(55, 61);
            this.txtPizzaTip.Margin = new System.Windows.Forms.Padding(0);
            this.txtPizzaTip.Name = "txtPizzaTip";
            this.txtPizzaTip.Size = new System.Drawing.Size(162, 26);
            this.txtPizzaTip.TabIndex = 30;
            // 
            // pnlTip
            // 
            this.pnlTip.Controls.Add(this.btnPercent);
            this.pnlTip.Controls.Add(this.btnDollars);
            this.pnlTip.Location = new System.Drawing.Point(220, 60);
            this.pnlTip.Name = "pnlTip";
            this.pnlTip.Size = new System.Drawing.Size(199, 42);
            this.pnlTip.TabIndex = 27;
            this.pnlTip.Tag = "Transparent";
            // 
            // btnPercent
            // 
            this.btnPercent.AutoSize = true;
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.Location = new System.Drawing.Point(109, 3);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(82, 24);
            this.btnPercent.TabIndex = 32;
            this.btnPercent.Text = "Percent";
            this.btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnDollars
            // 
            this.btnDollars.AutoSize = true;
            this.btnDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDollars.Location = new System.Drawing.Point(8, 3);
            this.btnDollars.Name = "btnDollars";
            this.btnDollars.Size = new System.Drawing.Size(76, 24);
            this.btnDollars.TabIndex = 31;
            this.btnDollars.Text = "Dollars";
            this.btnDollars.UseVisualStyleBackColor = true;
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
            // txtPizzaSize
            // 
            this.txtPizzaSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtPizzaSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPizzaSize.Location = new System.Drawing.Point(127, 13);
            this.txtPizzaSize.Margin = new System.Windows.Forms.Padding(0);
            this.txtPizzaSize.Name = "txtPizzaSize";
            this.txtPizzaSize.Size = new System.Drawing.Size(90, 26);
            this.txtPizzaSize.TabIndex = 13;
            // 
            // imgFavoriteImages
            // 
            this.imgFavoriteImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFavoriteImages.ImageStream")));
            this.imgFavoriteImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFavoriteImages.Images.SetKeyName(0, "LargePizza.png");
            this.imgFavoriteImages.Images.SetKeyName(1, "MediumPizza.png");
            this.imgFavoriteImages.Images.SetKeyName(2, "SmallPizza.png");
            // 
            // FrmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlSecretFrame);
            this.Name = "FrmPizza";
            this.Text = "Pizza Delivery";
            this.pnlSecretFrame.ResumeLayout(false);
            this.pnlPizzaCost.ResumeLayout(false);
            this.pnlPizzaCost.PerformLayout();
            this.pnlPizza.ResumeLayout(false);
            this.pnlPizza.PerformLayout();
            this.pnlDiningType.ResumeLayout(false);
            this.pnlDiningType.PerformLayout();
            this.pnlTip.ResumeLayout(false);
            this.pnlTip.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlSecretFrame;
		private System.Windows.Forms.Panel pnlPizzaCost;
		private System.Windows.Forms.Panel pnlPizzaViewer;
		private System.Windows.Forms.Label lblPizzaCostAmount;
		internal System.Windows.Forms.Label lblPizzaCost;
		private System.Windows.Forms.Panel pnlPizza;
		private System.Windows.Forms.Panel pnlDiningType;
		private System.Windows.Forms.RadioButton btnTakeout;
		private System.Windows.Forms.RadioButton btnDelivery;
		internal System.Windows.Forms.Label lblPizzaSize;
		internal System.Windows.Forms.TextBox txtPizzaTip;
		private System.Windows.Forms.Panel pnlTip;
		private System.Windows.Forms.RadioButton btnPercent;
		private System.Windows.Forms.RadioButton btnDollars;
		internal System.Windows.Forms.Label lblPizzaTip;
		internal System.Windows.Forms.TextBox txtPizzaSize;
		internal System.Windows.Forms.Label lblPizzaTitle;
		public System.Windows.Forms.ImageList imgFavoriteImages;
	}
}
