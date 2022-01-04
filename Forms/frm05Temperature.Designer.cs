
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
            this.pnlSecretFrame = new System.Windows.Forms.Panel();
            this.pnlTemperatureResults = new System.Windows.Forms.Panel();
            this.lblCelsiusDisplay = new System.Windows.Forms.Label();
            this.lblFahrenheitDisplayLabel = new System.Windows.Forms.Label();
            this.lblFahrenheitDisplay = new System.Windows.Forms.Label();
            this.lblCelsiusDisplayLabel = new System.Windows.Forms.Label();
            this.pnlTemperature = new System.Windows.Forms.Panel();
            this.btnCelsius = new System.Windows.Forms.RadioButton();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.RadioButton();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTemperatureTitle = new System.Windows.Forms.Label();
            this.pnlSecretFrame.SuspendLayout();
            this.pnlTemperatureResults.SuspendLayout();
            this.pnlTemperature.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSecretFrame
            // 
            this.pnlSecretFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecretFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecretFrame.Controls.Add(this.pnlTemperatureResults);
            this.pnlSecretFrame.Controls.Add(this.pnlTemperature);
            this.pnlSecretFrame.Controls.Add(this.lblTemperatureTitle);
            this.pnlSecretFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlSecretFrame.Name = "pnlSecretFrame";
            this.pnlSecretFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlSecretFrame.TabIndex = 33;
            // 
            // pnlTemperatureResults
            // 
            this.pnlTemperatureResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTemperatureResults.BackColor = System.Drawing.Color.Transparent;
            this.pnlTemperatureResults.Controls.Add(this.lblCelsiusDisplay);
            this.pnlTemperatureResults.Controls.Add(this.lblFahrenheitDisplayLabel);
            this.pnlTemperatureResults.Controls.Add(this.lblFahrenheitDisplay);
            this.pnlTemperatureResults.Controls.Add(this.lblCelsiusDisplayLabel);
            this.pnlTemperatureResults.Location = new System.Drawing.Point(287, 276);
            this.pnlTemperatureResults.Name = "pnlTemperatureResults";
            this.pnlTemperatureResults.Size = new System.Drawing.Size(426, 81);
            this.pnlTemperatureResults.TabIndex = 36;
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
            // pnlTemperature
            // 
            this.pnlTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTemperature.Controls.Add(this.btnCelsius);
            this.pnlTemperature.Controls.Add(this.txtTemperature);
            this.pnlTemperature.Controls.Add(this.btnFahrenheit);
            this.pnlTemperature.Controls.Add(this.lblTemperature);
            this.pnlTemperature.Location = new System.Drawing.Point(287, 165);
            this.pnlTemperature.Name = "pnlTemperature";
            this.pnlTemperature.Size = new System.Drawing.Size(426, 105);
            this.pnlTemperature.TabIndex = 35;
            // 
            // btnCelsius
            // 
            this.btnCelsius.AutoSize = true;
            this.btnCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelsius.Location = new System.Drawing.Point(275, 61);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(78, 24);
            this.btnCelsius.TabIndex = 26;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.SystemColors.Window;
            this.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(148, 13);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(269, 26);
            this.txtTemperature.TabIndex = 13;
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.AutoSize = true;
            this.btnFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrenheit.Location = new System.Drawing.Point(73, 61);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(104, 24);
            this.btnFahrenheit.TabIndex = 25;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
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
            // lblTemperatureTitle
            // 
            this.lblTemperatureTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemperatureTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureTitle.Location = new System.Drawing.Point(187, 95);
            this.lblTemperatureTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemperatureTitle.Name = "lblTemperatureTitle";
            this.lblTemperatureTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTemperatureTitle.TabIndex = 34;
            this.lblTemperatureTitle.Text = "Temperature Converter";
            this.lblTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm05Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlSecretFrame);
            this.Name = "Frm05Temperature";
            this.Text = "Temperature Converter";
            this.pnlSecretFrame.ResumeLayout(false);
            this.pnlTemperatureResults.ResumeLayout(false);
            this.pnlTemperatureResults.PerformLayout();
            this.pnlTemperature.ResumeLayout(false);
            this.pnlTemperature.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlSecretFrame;
		private System.Windows.Forms.Panel pnlTemperatureResults;
		private System.Windows.Forms.Label lblCelsiusDisplay;
		internal System.Windows.Forms.Label lblFahrenheitDisplayLabel;
		private System.Windows.Forms.Label lblFahrenheitDisplay;
		internal System.Windows.Forms.Label lblCelsiusDisplayLabel;
		private System.Windows.Forms.Panel pnlTemperature;
		private System.Windows.Forms.RadioButton btnCelsius;
		internal System.Windows.Forms.TextBox txtTemperature;
		private System.Windows.Forms.RadioButton btnFahrenheit;
		internal System.Windows.Forms.Label lblTemperature;
		internal System.Windows.Forms.Label lblTemperatureTitle;
	}
}
