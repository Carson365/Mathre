
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRectangle));
            this.pnlHelloWorldFrame = new System.Windows.Forms.Panel();
            this.pnlRectangleContainer = new System.Windows.Forms.Panel();
            this.lblRectangleError = new System.Windows.Forms.Label();
            this.pnlRectangle = new System.Windows.Forms.Panel();
            this.lblRectangleTitle = new System.Windows.Forms.Label();
            this.pnlRectangleControls = new System.Windows.Forms.Panel();
            this.btnRectangleCalculate = new System.Windows.Forms.Button();
            this.lblRectangleAreaTitle = new System.Windows.Forms.Label();
            this.txtRectangleDimensions = new System.Windows.Forms.TextBox();
            this.lblRectangleDimensions = new System.Windows.Forms.Label();
            this.lblRectanglePerimiterTitle = new System.Windows.Forms.Label();
            this.lblRectangleArea = new System.Windows.Forms.Label();
            this.lblRectanglePerimeter = new System.Windows.Forms.Label();
            this.pnlHelloWorldFrame.SuspendLayout();
            this.pnlRectangleContainer.SuspendLayout();
            this.pnlRectangleControls.SuspendLayout();
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
            this.pnlHelloWorldFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlHelloWorldFrame.Name = "pnlHelloWorldFrame";
            this.pnlHelloWorldFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlHelloWorldFrame.TabIndex = 32;
            // 
            // pnlRectangleContainer
            // 
            this.pnlRectangleContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangleContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlRectangleContainer.Controls.Add(this.lblRectangleError);
            this.pnlRectangleContainer.Controls.Add(this.pnlRectangle);
            this.pnlRectangleContainer.Location = new System.Drawing.Point(287, 276);
            this.pnlRectangleContainer.Name = "pnlRectangleContainer";
            this.pnlRectangleContainer.Size = new System.Drawing.Size(426, 136);
            this.pnlRectangleContainer.TabIndex = 33;
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
            // lblRectangleTitle
            // 
            this.lblRectangleTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRectangleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangleTitle.Location = new System.Drawing.Point(187, 95);
            this.lblRectangleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblRectangleTitle.Name = "lblRectangleTitle";
            this.lblRectangleTitle.Size = new System.Drawing.Size(626, 51);
            this.lblRectangleTitle.TabIndex = 31;
            this.lblRectangleTitle.Text = "Rectangle Calculator";
            this.lblRectangleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRectangleControls
            // 
            this.pnlRectangleControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRectangleControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRectangleControls.Controls.Add(this.btnRectangleCalculate);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleAreaTitle);
            this.pnlRectangleControls.Controls.Add(this.txtRectangleDimensions);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleDimensions);
            this.pnlRectangleControls.Controls.Add(this.lblRectanglePerimiterTitle);
            this.pnlRectangleControls.Controls.Add(this.lblRectangleArea);
            this.pnlRectangleControls.Controls.Add(this.lblRectanglePerimeter);
            this.pnlRectangleControls.Location = new System.Drawing.Point(287, 165);
            this.pnlRectangleControls.Name = "pnlRectangleControls";
            this.pnlRectangleControls.Size = new System.Drawing.Size(426, 105);
            this.pnlRectangleControls.TabIndex = 32;
            // 
            // btnRectangleCalculate
            // 
            this.btnRectangleCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnRectangleCalculate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRectangleCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangleCalculate.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangleCalculate.Image")));
            this.btnRectangleCalculate.Location = new System.Drawing.Point(391, 13);
            this.btnRectangleCalculate.Margin = new System.Windows.Forms.Padding(0);
            this.btnRectangleCalculate.Name = "btnRectangleCalculate";
            this.btnRectangleCalculate.Size = new System.Drawing.Size(26, 26);
            this.btnRectangleCalculate.TabIndex = 25;
            this.btnRectangleCalculate.UseVisualStyleBackColor = false;
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
            // txtRectangleDimensions
            // 
            this.txtRectangleDimensions.BackColor = System.Drawing.SystemColors.Window;
            this.txtRectangleDimensions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRectangleDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRectangleDimensions.Location = new System.Drawing.Point(217, 13);
            this.txtRectangleDimensions.Margin = new System.Windows.Forms.Padding(0);
            this.txtRectangleDimensions.Name = "txtRectangleDimensions";
            this.txtRectangleDimensions.Size = new System.Drawing.Size(175, 26);
            this.txtRectangleDimensions.TabIndex = 20;
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
            // FrmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlHelloWorldFrame);
            this.Name = "FrmRectangle";
            this.Text = "Rectangle Calculator";
            this.pnlHelloWorldFrame.ResumeLayout(false);
            this.pnlRectangleContainer.ResumeLayout(false);
            this.pnlRectangleControls.ResumeLayout(false);
            this.pnlRectangleControls.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlHelloWorldFrame;
		private System.Windows.Forms.Panel pnlRectangleContainer;
		internal System.Windows.Forms.Label lblRectangleError;
		private System.Windows.Forms.Panel pnlRectangle;
		internal System.Windows.Forms.Label lblRectangleTitle;
		private System.Windows.Forms.Panel pnlRectangleControls;
		private System.Windows.Forms.Button btnRectangleCalculate;
		internal System.Windows.Forms.Label lblRectangleAreaTitle;
		internal System.Windows.Forms.TextBox txtRectangleDimensions;
		internal System.Windows.Forms.Label lblRectangleDimensions;
		internal System.Windows.Forms.Label lblRectanglePerimiterTitle;
		private System.Windows.Forms.Label lblRectangleArea;
		private System.Windows.Forms.Label lblRectanglePerimeter;
	}
}
