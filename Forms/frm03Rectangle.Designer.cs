
namespace Mathre
{
	partial class FrmRectangle
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
            this.pnlHelloWorldFrame = new System.Windows.Forms.Panel();
            this.pnlRectangleContainer = new System.Windows.Forms.Panel();
            this.lblRectangleError = new System.Windows.Forms.Label();
            this.pnlRectangle = new System.Windows.Forms.Panel();
            this.lblRectangleTitle = new System.Windows.Forms.Label();
            this.pnlRectangleControls = new System.Windows.Forms.Panel();
            this.lblRectangleAreaTitle = new System.Windows.Forms.Label();
            this.txtRectangleDimensions = new System.Windows.Forms.TextBox();
            this.lblRectangleDimensions = new System.Windows.Forms.Label();
            this.lblRectanglePerimiterTitle = new System.Windows.Forms.Label();
            this.lblRectangleArea = new System.Windows.Forms.Label();
            this.lblRectanglePerimeter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHelloWorldFrame.SuspendLayout();
            this.pnlRectangleContainer.SuspendLayout();
            this.pnlRectangleControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHelloWorldFrame
            // 
            this.pnlHelloWorldFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHelloWorldFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlHelloWorldFrame.Controls.Add(this.pnlRectangleContainer);
            this.pnlHelloWorldFrame.Controls.Add(this.lblRectangleTitle);
            this.pnlHelloWorldFrame.Controls.Add(this.pnlRectangleControls);
            this.pnlHelloWorldFrame.Location = new System.Drawing.Point(-9, -23);
            this.pnlHelloWorldFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHelloWorldFrame.Name = "pnlHelloWorldFrame";
            this.pnlHelloWorldFrame.Size = new System.Drawing.Size(1167, 577);
            this.pnlHelloWorldFrame.TabIndex = 32;
            // 
            // pnlRectangleContainer
            // 
            this.pnlRectangleContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangleContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlRectangleContainer.Controls.Add(this.lblRectangleError);
            this.pnlRectangleContainer.Controls.Add(this.pnlRectangle);
            this.pnlRectangleContainer.Location = new System.Drawing.Point(335, 318);
            this.pnlRectangleContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlRectangleContainer.Name = "pnlRectangleContainer";
            this.pnlRectangleContainer.Size = new System.Drawing.Size(497, 157);
            this.pnlRectangleContainer.TabIndex = 33;
            // 
            // lblRectangleError
            // 
            this.lblRectangleError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRectangleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRectangleError.Location = new System.Drawing.Point(61, 51);
            this.lblRectangleError.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleError.Name = "lblRectangleError";
            this.lblRectangleError.Size = new System.Drawing.Size(375, 59);
            this.lblRectangleError.TabIndex = 16;
            this.lblRectangleError.Text = "Invalid Dimensions";
            this.lblRectangleError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRectangle
            // 
            this.pnlRectangle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlRectangle.Location = new System.Drawing.Point(190, 21);
            this.pnlRectangle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlRectangle.MaximumSize = new System.Drawing.Size(117, 115);
            this.pnlRectangle.Name = "pnlRectangle";
            this.pnlRectangle.Size = new System.Drawing.Size(117, 115);
            this.pnlRectangle.TabIndex = 27;
            this.pnlRectangle.Tag = "Black";
            // 
            // lblRectangleTitle
            // 
            this.lblRectangleTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRectangleTitle.Location = new System.Drawing.Point(218, 110);
            this.lblRectangleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleTitle.Name = "lblRectangleTitle";
            this.lblRectangleTitle.Size = new System.Drawing.Size(730, 59);
            this.lblRectangleTitle.TabIndex = 31;
            this.lblRectangleTitle.Text = "Rectangle Calculator";
            this.lblRectangleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRectangleControls
            // 
            this.pnlRectangleControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangleControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRectangleControls.Controls.Add(this.pictureBox1);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleAreaTitle);
            this.pnlRectangleControls.Controls.Add(this.txtRectangleDimensions);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleDimensions);
            this.pnlRectangleControls.Controls.Add(this.lblRectanglePerimiterTitle);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleArea);
            this.pnlRectangleControls.Controls.Add(this.lblRectanglePerimeter);
            this.pnlRectangleControls.Location = new System.Drawing.Point(335, 190);
            this.pnlRectangleControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlRectangleControls.Name = "pnlRectangleControls";
            this.pnlRectangleControls.Size = new System.Drawing.Size(497, 121);
            this.pnlRectangleControls.TabIndex = 32;
            // 
            // lblRectangleAreaTitle
            // 
            this.lblRectangleAreaTitle.AutoSize = true;
            this.lblRectangleAreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRectangleAreaTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleAreaTitle.Location = new System.Drawing.Point(21, 48);
            this.lblRectangleAreaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRectangleAreaTitle.Name = "lblRectangleAreaTitle";
            this.lblRectangleAreaTitle.Size = new System.Drawing.Size(47, 20);
            this.lblRectangleAreaTitle.TabIndex = 21;
            this.lblRectangleAreaTitle.Text = "Area:";
            // 
            // txtRectangleDimensions
            // 
            this.txtRectangleDimensions.BackColor = System.Drawing.SystemColors.Window;
            this.txtRectangleDimensions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRectangleDimensions.Location = new System.Drawing.Point(253, 15);
            this.txtRectangleDimensions.Margin = new System.Windows.Forms.Padding(0);
            this.txtRectangleDimensions.Name = "txtRectangleDimensions";
            this.txtRectangleDimensions.Size = new System.Drawing.Size(204, 26);
            this.txtRectangleDimensions.TabIndex = 20;
            // 
            // lblRectangleDimensions
            // 
            this.lblRectangleDimensions.AutoSize = true;
            this.lblRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRectangleDimensions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleDimensions.Location = new System.Drawing.Point(21, 18);
            this.lblRectangleDimensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRectangleDimensions.Name = "lblRectangleDimensions";
            this.lblRectangleDimensions.Size = new System.Drawing.Size(173, 20);
            this.lblRectangleDimensions.TabIndex = 19;
            this.lblRectangleDimensions.Text = "Rectangle Dimensions:";
            // 
            // lblRectanglePerimiterTitle
            // 
            this.lblRectanglePerimiterTitle.AutoSize = true;
            this.lblRectanglePerimiterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRectanglePerimiterTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectanglePerimiterTitle.Location = new System.Drawing.Point(21, 78);
            this.lblRectanglePerimiterTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRectanglePerimiterTitle.Name = "lblRectanglePerimiterTitle";
            this.lblRectanglePerimiterTitle.Size = new System.Drawing.Size(75, 20);
            this.lblRectanglePerimiterTitle.TabIndex = 22;
            this.lblRectanglePerimiterTitle.Text = "Perimiter:";
            // 
            // lblRectangleArea
            // 
            this.lblRectangleArea.AutoSize = true;
            this.lblRectangleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRectangleArea.Location = new System.Drawing.Point(83, 52);
            this.lblRectangleArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRectangleArea.Name = "lblRectangleArea";
            this.lblRectangleArea.Size = new System.Drawing.Size(32, 15);
            this.lblRectangleArea.TabIndex = 23;
            this.lblRectangleArea.Text = "Area";
            this.lblRectangleArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRectanglePerimeter
            // 
            this.lblRectanglePerimeter.AutoSize = true;
            this.lblRectanglePerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRectanglePerimeter.Location = new System.Drawing.Point(115, 82);
            this.lblRectanglePerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRectanglePerimeter.Name = "lblRectanglePerimeter";
            this.lblRectanglePerimeter.Size = new System.Drawing.Size(61, 15);
            this.lblRectanglePerimeter.TabIndex = 24;
            this.lblRectanglePerimeter.Text = "Perimeter";
            this.lblRectanglePerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Mathre.Properties.Resources.EnterKey;
            this.pictureBox1.Location = new System.Drawing.Point(456, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1148, 532);
            this.Controls.Add(this.pnlHelloWorldFrame);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRectangle";
            this.Text = "Rectangle Calculator";
            this.pnlHelloWorldFrame.ResumeLayout(false);
            this.pnlRectangleContainer.ResumeLayout(false);
            this.pnlRectangleControls.ResumeLayout(false);
            this.pnlRectangleControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlHelloWorldFrame;
		private System.Windows.Forms.Panel pnlRectangleContainer;
		internal System.Windows.Forms.Label lblRectangleError;
		private System.Windows.Forms.Panel pnlRectangle;
		internal System.Windows.Forms.Label lblRectangleTitle;
		private System.Windows.Forms.Panel pnlRectangleControls;
		internal System.Windows.Forms.Label lblRectangleAreaTitle;
		internal System.Windows.Forms.TextBox txtRectangleDimensions;
		internal System.Windows.Forms.Label lblRectangleDimensions;
		internal System.Windows.Forms.Label lblRectanglePerimiterTitle;
		private System.Windows.Forms.Label lblRectangleArea;
		private System.Windows.Forms.Label lblRectanglePerimeter;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
