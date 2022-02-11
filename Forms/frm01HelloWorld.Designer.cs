
namespace Mathre
{
	partial class Frm01HelloWorld
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.picGerman = new System.Windows.Forms.PictureBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.picFrench = new System.Windows.Forms.PictureBox();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.picEnglish = new System.Windows.Forms.PictureBox();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            this.pnlLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGerman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrench)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnglish)).BeginInit();
            this.pnlFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(287, 95);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(426, 51);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Hello World";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.pnlLanguage);
            this.pnlBody.Controls.Add(this.btnReset);
            this.pnlBody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 30;
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLanguage.Controls.Add(this.picGerman);
            this.pnlLanguage.Controls.Add(this.radEnglish);
            this.pnlLanguage.Controls.Add(this.picFrench);
            this.pnlLanguage.Controls.Add(this.radFrench);
            this.pnlLanguage.Controls.Add(this.picEnglish);
            this.pnlLanguage.Controls.Add(this.radGerman);
            this.pnlLanguage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLanguage.Location = new System.Drawing.Point(6, 5);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(414, 43);
            this.pnlLanguage.TabIndex = 31;
            this.pnlLanguage.Tag = "Transparent,Language";
            // 
            // picGerman
            // 
            this.picGerman.Image = global::Mathre.My.Resources.Resources.German;
            this.picGerman.Location = new System.Drawing.Point(287, 9);
            this.picGerman.Name = "picGerman";
            this.picGerman.Size = new System.Drawing.Size(31, 25);
            this.picGerman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGerman.TabIndex = 13;
            this.picGerman.TabStop = false;
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Checked = true;
            this.radEnglish.Location = new System.Drawing.Point(65, 13);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 7;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            // 
            // picFrench
            // 
            this.picFrench.Image = global::Mathre.My.Resources.Resources.French;
            this.picFrench.Location = new System.Drawing.Point(158, 9);
            this.picFrench.Name = "picFrench";
            this.picFrench.Size = new System.Drawing.Size(31, 25);
            this.picFrench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFrench.TabIndex = 11;
            this.picFrench.TabStop = false;
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(195, 13);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(58, 17);
            this.radFrench.TabIndex = 10;
            this.radFrench.Text = "French";
            this.radFrench.UseVisualStyleBackColor = true;
            // 
            // picEnglish
            // 
            this.picEnglish.Image = global::Mathre.My.Resources.Resources.English;
            this.picEnglish.Location = new System.Drawing.Point(28, 9);
            this.picEnglish.Name = "picEnglish";
            this.picEnglish.Size = new System.Drawing.Size(31, 25);
            this.picEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnglish.TabIndex = 12;
            this.picEnglish.TabStop = false;
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(324, 13);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(62, 17);
            this.radGerman.TabIndex = 8;
            this.radGerman.Text = "German";
            this.radGerman.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.pnlBody);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 31;
            // 
            // Frm01HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm01HelloWorld";
            this.Text = "Hello World";
            this.pnlBody.ResumeLayout(false);
            this.pnlLanguage.ResumeLayout(false);
            this.pnlLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGerman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrench)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnglish)).EndInit();
            this.pnlFrame.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		internal System.Windows.Forms.Panel pnlFrame;
		internal System.Windows.Forms.Label lblTitle;
		internal System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.PictureBox picEnglish;
		internal System.Windows.Forms.PictureBox picFrench;
		internal System.Windows.Forms.PictureBox picGerman;
		internal System.Windows.Forms.RadioButton radEnglish;
		internal System.Windows.Forms.RadioButton radFrench;
		internal System.Windows.Forms.RadioButton radGerman;
		internal System.Windows.Forms.Button btnReset;
		internal System.Windows.Forms.Panel pnlLanguage;
	}
}