
namespace Mathre
{
	partial class Frm02MySchool
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.picMySchoolMascot = new System.Windows.Forms.PictureBox();
            this.lblMySchoolMascot = new System.Windows.Forms.Label();
            this.btnMySchoolToggleMascot = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).BeginInit();
            this.SuspendLayout();
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
            this.pnlFrame.TabIndex = 32;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.picMySchoolMascot);
            this.pnlBody.Controls.Add(this.lblMySchoolMascot);
            this.pnlBody.Controls.Add(this.btnMySchoolToggleMascot);
            this.pnlBody.Location = new System.Drawing.Point(287, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 31;
            // 
            // picMySchoolMascot
            // 
            this.picMySchoolMascot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMySchoolMascot.Image = global::Mathre.Resources.RedRiver;
            this.picMySchoolMascot.Location = new System.Drawing.Point(268, 19);
            this.picMySchoolMascot.Name = "picMySchoolMascot";
            this.picMySchoolMascot.Size = new System.Drawing.Size(108, 66);
            this.picMySchoolMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMySchoolMascot.TabIndex = 13;
            this.picMySchoolMascot.TabStop = false;
            this.picMySchoolMascot.Visible = false;
            // 
            // lblMySchoolMascot
            // 
            this.lblMySchoolMascot.AutoSize = true;
            this.lblMySchoolMascot.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySchoolMascot.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMySchoolMascot.Location = new System.Drawing.Point(50, 27);
            this.lblMySchoolMascot.Name = "lblMySchoolMascot";
            this.lblMySchoolMascot.Size = new System.Drawing.Size(134, 18);
            this.lblMySchoolMascot.TabIndex = 10;
            this.lblMySchoolMascot.Text = "Mascot: Roughriders";
            // 
            // btnMySchoolToggleMascot
            // 
            this.btnMySchoolToggleMascot.Location = new System.Drawing.Point(51, 60);
            this.btnMySchoolToggleMascot.Name = "btnMySchoolToggleMascot";
            this.btnMySchoolToggleMascot.Size = new System.Drawing.Size(132, 23);
            this.btnMySchoolToggleMascot.TabIndex = 9;
            this.btnMySchoolToggleMascot.Text = "Toggle Mascot Visibility";
            this.btnMySchoolToggleMascot.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(252, 80);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 50);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Red River High School";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm02MySchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm02MySchool";
            this.Text = "My School";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.Label lblMySchoolMascot;
		internal System.Windows.Forms.PictureBox picMySchoolMascot;
		internal System.Windows.Forms.Button btnMySchoolToggleMascot;
		internal System.Windows.Forms.Label lblTitle;
	}
}