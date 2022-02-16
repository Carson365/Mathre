
namespace Mathre
{
	partial class Frm05Temperature
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
            this.lblCelsiusDisplay = new System.Windows.Forms.Label();
            this.lblFahrenheitDisplayLabel = new System.Windows.Forms.Label();
            this.lblFahrenheitDisplay = new System.Windows.Forms.Label();
            this.lblCelsiusDisplayLabel = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlText1 = new System.Windows.Forms.Panel();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.radFahrenheit = new System.Windows.Forms.RadioButton();
            this.radCelsius = new System.Windows.Forms.RadioButton();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.pnlBody2.Controls.Add(this.lblCelsiusDisplay);
            this.pnlBody2.Controls.Add(this.lblFahrenheitDisplayLabel);
            this.pnlBody2.Controls.Add(this.lblFahrenheitDisplay);
            this.pnlBody2.Controls.Add(this.lblCelsiusDisplayLabel);
            this.pnlBody2.Location = new System.Drawing.Point(287, 276);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 81);
            this.pnlBody2.TabIndex = 36;
            // 
            // lblCelsiusDisplay
            // 
            this.lblCelsiusDisplay.AutoSize = true;
            this.lblCelsiusDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsiusDisplay.Location = new System.Drawing.Point(199, 46);
            this.lblCelsiusDisplay.Name = "lblCelsiusDisplay";
            this.lblCelsiusDisplay.Size = new System.Drawing.Size(78, 15);
            this.lblCelsiusDisplay.TabIndex = 17;
            this.lblCelsiusDisplay.Text = "Temperature";
            this.lblCelsiusDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFahrenheitDisplayLabel
            // 
            this.lblFahrenheitDisplayLabel.AutoSize = true;
            this.lblFahrenheitDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheitDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFahrenheitDisplayLabel.Location = new System.Drawing.Point(18, 17);
            this.lblFahrenheitDisplayLabel.Name = "lblFahrenheitDisplayLabel";
            this.lblFahrenheitDisplayLabel.Size = new System.Drawing.Size(201, 20);
            this.lblFahrenheitDisplayLabel.TabIndex = 14;
            this.lblFahrenheitDisplayLabel.Text = "Temperature in Fahrenheit:";
            // 
            // lblFahrenheitDisplay
            // 
            this.lblFahrenheitDisplay.AutoSize = true;
            this.lblFahrenheitDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheitDisplay.Location = new System.Drawing.Point(225, 20);
            this.lblFahrenheitDisplay.Name = "lblFahrenheitDisplay";
            this.lblFahrenheitDisplay.Size = new System.Drawing.Size(78, 15);
            this.lblFahrenheitDisplay.TabIndex = 16;
            this.lblFahrenheitDisplay.Text = "Temperature";
            this.lblFahrenheitDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCelsiusDisplayLabel
            // 
            this.lblCelsiusDisplayLabel.AutoSize = true;
            this.lblCelsiusDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsiusDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCelsiusDisplayLabel.Location = new System.Drawing.Point(18, 43);
            this.lblCelsiusDisplayLabel.Name = "lblCelsiusDisplayLabel";
            this.lblCelsiusDisplayLabel.Size = new System.Drawing.Size(175, 20);
            this.lblCelsiusDisplayLabel.TabIndex = 15;
            this.lblCelsiusDisplayLabel.Text = "Temperature in Celsius:";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlText1);
            this.pnlBody.Controls.Add(this.radFahrenheit);
            this.pnlBody.Controls.Add(this.radCelsius);
            this.pnlBody.Controls.Add(this.lblTemperature);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 35;
            // 
            // pnlText1
            // 
            this.pnlText1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlText1.BackColor = System.Drawing.Color.Transparent;
            this.pnlText1.Controls.Add(this.txtTemperature);
            this.pnlText1.Location = new System.Drawing.Point(128, 13);
            this.pnlText1.Name = "pnlText1";
            this.pnlText1.Size = new System.Drawing.Size(269, 26);
            this.pnlText1.TabIndex = 37;
            this.pnlText1.Tag = "Transparent,Temperature";
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.SystemColors.Window;
            this.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(0, 0);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(269, 26);
            this.txtTemperature.TabIndex = 13;
            // 
            // radFahrenheit
            // 
            this.radFahrenheit.AutoSize = true;
            this.radFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFahrenheit.Location = new System.Drawing.Point(73, 61);
            this.radFahrenheit.Name = "radFahrenheit";
            this.radFahrenheit.Size = new System.Drawing.Size(104, 24);
            this.radFahrenheit.TabIndex = 25;
            this.radFahrenheit.Text = "Fahrenheit";
            this.radFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radCelsius
            // 
            this.radCelsius.AutoSize = true;
            this.radCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCelsius.Location = new System.Drawing.Point(275, 61);
            this.radCelsius.Name = "radCelsius";
            this.radCelsius.Size = new System.Drawing.Size(78, 24);
            this.radCelsius.TabIndex = 26;
            this.radCelsius.Text = "Celsius";
            this.radCelsius.UseVisualStyleBackColor = true;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTemperature.Location = new System.Drawing.Point(18, 16);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(104, 20);
            this.lblTemperature.TabIndex = 9;
            this.lblTemperature.Text = "Temperature:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 95);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Temperature Converter";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm05Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm05Temperature";
            this.Text = "Temperature Converter";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody2.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlText1.ResumeLayout(false);
            this.pnlText1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Label lblCelsiusDisplay;
		internal System.Windows.Forms.Label lblFahrenheitDisplayLabel;
		private System.Windows.Forms.Label lblFahrenheitDisplay;
		internal System.Windows.Forms.Label lblCelsiusDisplayLabel;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.RadioButton radCelsius;
		internal System.Windows.Forms.TextBox txtTemperature;
		private System.Windows.Forms.RadioButton radFahrenheit;
		internal System.Windows.Forms.Label lblTemperature;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlText1;
	}
}
