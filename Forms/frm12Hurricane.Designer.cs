namespace Mathre
{
	partial class FrmHurricane
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
            this.pnlSecretFrame = new System.Windows.Forms.Panel();
            this.lblHurricaneTitle = new System.Windows.Forms.Label();
            this.pnlPizzaCost = new System.Windows.Forms.Panel();
            this.lblPizzaCostAmount = new System.Windows.Forms.Label();
            this.lblPizzaCost = new System.Windows.Forms.Label();
            this.pnlPizza = new System.Windows.Forms.Panel();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.lblPizzaTip = new System.Windows.Forms.Label();
            this.txtPizzaSize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSecretFrame.SuspendLayout();
            this.pnlPizzaCost.SuspendLayout();
            this.pnlPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSecretFrame
            // 
            this.pnlSecretFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecretFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecretFrame.Controls.Add(this.lblHurricaneTitle);
            this.pnlSecretFrame.Controls.Add(this.pnlPizzaCost);
            this.pnlSecretFrame.Controls.Add(this.pnlPizza);
            this.pnlSecretFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlSecretFrame.Name = "pnlSecretFrame";
            this.pnlSecretFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlSecretFrame.TabIndex = 34;
            // 
            // lblHurricaneTitle
            // 
            this.lblHurricaneTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHurricaneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHurricaneTitle.Location = new System.Drawing.Point(187, 95);
            this.lblHurricaneTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblHurricaneTitle.Name = "lblHurricaneTitle";
            this.lblHurricaneTitle.Size = new System.Drawing.Size(626, 51);
            this.lblHurricaneTitle.TabIndex = 33;
            this.lblHurricaneTitle.Text = "Hurricane!";
            this.lblHurricaneTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPizzaCost
            // 
            this.pnlPizzaCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPizzaCost.BackColor = System.Drawing.Color.Transparent;
            this.pnlPizzaCost.Controls.Add(this.label1);
            this.pnlPizzaCost.Controls.Add(this.lblPizzaCostAmount);
            this.pnlPizzaCost.Controls.Add(this.lblPizzaCost);
            this.pnlPizzaCost.Controls.Add(this.lblPizzaTip);
            this.pnlPizzaCost.Location = new System.Drawing.Point(287, 276);
            this.pnlPizzaCost.Name = "pnlPizzaCost";
            this.pnlPizzaCost.Size = new System.Drawing.Size(426, 136);
            this.pnlPizzaCost.TabIndex = 35;
            // 
            // lblPizzaCostAmount
            // 
            this.lblPizzaCostAmount.AutoSize = true;
            this.lblPizzaCostAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaCostAmount.Location = new System.Drawing.Point(101, 58);
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
            this.lblPizzaCost.Location = new System.Drawing.Point(18, 55);
            this.lblPizzaCost.Name = "lblPizzaCost";
            this.lblPizzaCost.Size = new System.Drawing.Size(77, 20);
            this.lblPizzaCost.TabIndex = 14;
            this.lblPizzaCost.Text = "Category:";
            // 
            // pnlPizza
            // 
            this.pnlPizza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPizza.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPizza.Controls.Add(this.button2);
            this.pnlPizza.Controls.Add(this.button1);
            this.pnlPizza.Controls.Add(this.lblPizzaSize);
            this.pnlPizza.Controls.Add(this.txtPizzaSize);
            this.pnlPizza.Location = new System.Drawing.Point(287, 165);
            this.pnlPizza.Name = "pnlPizza";
            this.pnlPizza.Size = new System.Drawing.Size(426, 105);
            this.pnlPizza.TabIndex = 34;
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizzaSize.Location = new System.Drawing.Point(18, 16);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(145, 20);
            this.lblPizzaSize.TabIndex = 9;
            this.lblPizzaSize.Text = "Wind Speed (mph):";
            // 
            // lblPizzaTip
            // 
            this.lblPizzaTip.AutoSize = true;
            this.lblPizzaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaTip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPizzaTip.Location = new System.Drawing.Point(18, 10);
            this.lblPizzaTip.Name = "lblPizzaTip";
            this.lblPizzaTip.Size = new System.Drawing.Size(102, 20);
            this.lblPizzaTip.TabIndex = 27;
            this.lblPizzaTip.Text = "Storm Name:";
            // 
            // txtPizzaSize
            // 
            this.txtPizzaSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtPizzaSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPizzaSize.Location = new System.Drawing.Point(166, 14);
            this.txtPizzaSize.Margin = new System.Windows.Forms.Padding(0);
            this.txtPizzaSize.Name = "txtPizzaSize";
            this.txtPizzaSize.Size = new System.Drawing.Size(253, 26);
            this.txtPizzaSize.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Random Storm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Generate Storm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // FrmHurricane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlSecretFrame);
            this.Name = "FrmHurricane";
            this.Text = "Hurricane!";
            this.pnlSecretFrame.ResumeLayout(false);
            this.pnlPizzaCost.ResumeLayout(false);
            this.pnlPizzaCost.PerformLayout();
            this.pnlPizza.ResumeLayout(false);
            this.pnlPizza.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlSecretFrame;
		internal System.Windows.Forms.Label lblHurricaneTitle;
		private System.Windows.Forms.Panel pnlPizzaCost;
		private System.Windows.Forms.Label lblPizzaCostAmount;
		internal System.Windows.Forms.Label lblPizzaCost;
		private System.Windows.Forms.Panel pnlPizza;
		internal System.Windows.Forms.Label lblPizzaSize;
		internal System.Windows.Forms.Label lblPizzaTip;
		internal System.Windows.Forms.TextBox txtPizzaSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}