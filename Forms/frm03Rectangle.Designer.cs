
namespace Mathre
{
	partial class Frm03Rectangle
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
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlBody2 = new System.Windows.Forms.Panel();
            this.lblRectangleError = new System.Windows.Forms.Label();
            this.pnlRectangle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlText1 = new System.Windows.Forms.Panel();
            this.txtRectangleDimensions = new System.Windows.Forms.TextBox();
            this.lblRectangleAreaTitle = new System.Windows.Forms.Label();
            this.lblRectangleDimensions = new System.Windows.Forms.Label();
            this.lblRectanglePerimiterTitle = new System.Windows.Forms.Label();
            this.lblRectangleArea = new System.Windows.Forms.Label();
            this.lblRectanglePerimeter = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlText1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.pnlBody2);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 32;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Controls.Add(this.lblRectangleError);
            this.pnlBody2.Controls.Add(this.pnlRectangle);
            this.pnlBody2.Location = new System.Drawing.Point(287, 261);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 33;
            // 
            // lblRectangleError
            // 
            this.lblRectangleError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRectangleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleError.Location = new System.Drawing.Point(52, 44);
            this.lblRectangleError.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleError.Name = "lblRectangleError";
            this.lblRectangleError.Size = new System.Drawing.Size(322, 51);
            this.lblRectangleError.TabIndex = 16;
            this.lblRectangleError.Text = "Invalid Dimensions";
            this.lblRectangleError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRectangle
            // 
            this.pnlRectangle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlRectangle.Location = new System.Drawing.Point(163, 18);
            this.pnlRectangle.MaximumSize = new System.Drawing.Size(100, 100);
            this.pnlRectangle.Name = "pnlRectangle";
            this.pnlRectangle.Size = new System.Drawing.Size(100, 100);
            this.pnlRectangle.TabIndex = 27;
            this.pnlRectangle.Tag = "Black";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 80);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Rectangle Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlText1);
            this.pnlBody.Controls.Add(this.lblRectangleAreaTitle);
            this.pnlBody.Controls.Add(this.lblRectangleDimensions);
            this.pnlBody.Controls.Add(this.lblRectanglePerimiterTitle);
            this.pnlBody.Controls.Add(this.lblRectangleArea);
            this.pnlBody.Controls.Add(this.lblRectanglePerimeter);
            this.pnlBody.Location = new System.Drawing.Point(287, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 32;
            // 
            // pnlText1
            // 
            this.pnlText1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlText1.BackColor = System.Drawing.Color.Transparent;
            this.pnlText1.Controls.Add(this.txtRectangleDimensions);
            this.pnlText1.Location = new System.Drawing.Point(197, 13);
            this.pnlText1.Name = "pnlText1";
            this.pnlText1.Size = new System.Drawing.Size(200, 26);
            this.pnlText1.TabIndex = 34;
            this.pnlText1.Tag = "Transparent,Rectangle Dimensions";
            // 
            // txtRectangleDimensions
            // 
            this.txtRectangleDimensions.BackColor = System.Drawing.SystemColors.Window;
            this.txtRectangleDimensions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRectangleDimensions.Location = new System.Drawing.Point(0, 0);
            this.txtRectangleDimensions.Margin = new System.Windows.Forms.Padding(0);
            this.txtRectangleDimensions.Name = "txtRectangleDimensions";
            this.txtRectangleDimensions.Size = new System.Drawing.Size(200, 26);
            this.txtRectangleDimensions.TabIndex = 20;
            this.txtRectangleDimensions.Tag = "";
            // 
            // lblRectangleAreaTitle
            // 
            this.lblRectangleAreaTitle.AutoSize = true;
            this.lblRectangleAreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleAreaTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleAreaTitle.Location = new System.Drawing.Point(18, 42);
            this.lblRectangleAreaTitle.Name = "lblRectangleAreaTitle";
            this.lblRectangleAreaTitle.Size = new System.Drawing.Size(47, 20);
            this.lblRectangleAreaTitle.TabIndex = 21;
            this.lblRectangleAreaTitle.Text = "Area:";
            // 
            // lblRectangleDimensions
            // 
            this.lblRectangleDimensions.AutoSize = true;
            this.lblRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleDimensions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectangleDimensions.Location = new System.Drawing.Point(18, 16);
            this.lblRectangleDimensions.Name = "lblRectangleDimensions";
            this.lblRectangleDimensions.Size = new System.Drawing.Size(173, 20);
            this.lblRectangleDimensions.TabIndex = 19;
            this.lblRectangleDimensions.Text = "Rectangle Dimensions:";
            // 
            // lblRectanglePerimiterTitle
            // 
            this.lblRectanglePerimiterTitle.AutoSize = true;
            this.lblRectanglePerimiterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectanglePerimiterTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRectanglePerimiterTitle.Location = new System.Drawing.Point(18, 68);
            this.lblRectanglePerimiterTitle.Name = "lblRectanglePerimiterTitle";
            this.lblRectanglePerimiterTitle.Size = new System.Drawing.Size(75, 20);
            this.lblRectanglePerimiterTitle.TabIndex = 22;
            this.lblRectanglePerimiterTitle.Text = "Perimiter:";
            // 
            // lblRectangleArea
            // 
            this.lblRectangleArea.AutoSize = true;
            this.lblRectangleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleArea.Location = new System.Drawing.Point(71, 45);
            this.lblRectangleArea.Name = "lblRectangleArea";
            this.lblRectangleArea.Size = new System.Drawing.Size(32, 15);
            this.lblRectangleArea.TabIndex = 23;
            this.lblRectangleArea.Text = "Area";
            this.lblRectangleArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRectanglePerimeter
            // 
            this.lblRectanglePerimeter.AutoSize = true;
            this.lblRectanglePerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectanglePerimeter.Location = new System.Drawing.Point(99, 71);
            this.lblRectanglePerimeter.Name = "lblRectanglePerimeter";
            this.lblRectanglePerimeter.Size = new System.Drawing.Size(61, 15);
            this.lblRectanglePerimeter.TabIndex = 24;
            this.lblRectanglePerimeter.Text = "Perimeter";
            this.lblRectanglePerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm03Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm03Rectangle";
            this.Text = "Rectangle Calculator";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlText1.ResumeLayout(false);
            this.pnlText1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody2;
		internal System.Windows.Forms.Label lblRectangleError;
		private System.Windows.Forms.Panel pnlRectangle;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblRectangleAreaTitle;
		internal System.Windows.Forms.TextBox txtRectangleDimensions;
		internal System.Windows.Forms.Label lblRectangleDimensions;
		internal System.Windows.Forms.Label lblRectanglePerimiterTitle;
		private System.Windows.Forms.Label lblRectangleArea;
		private System.Windows.Forms.Label lblRectanglePerimeter;
		private System.Windows.Forms.Panel pnlText1;
	}
}
