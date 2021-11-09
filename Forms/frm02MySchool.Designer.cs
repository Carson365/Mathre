
namespace Mathre
{
	partial class FrmMySchool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMySchool = new System.Windows.Forms.Panel();
            this.picMySchoolMascot = new System.Windows.Forms.PictureBox();
            this.lblMySchoolMascot = new System.Windows.Forms.Label();
            this.btnMySchoolToggleMascot = new System.Windows.Forms.Button();
            this.lblMySchoolTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMySchool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pnlMySchool);
            this.panel1.Controls.Add(this.lblMySchoolTitle);
            this.panel1.Location = new System.Drawing.Point(-9, -23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 577);
            this.panel1.TabIndex = 32;
            // 
            // pnlMySchool
            // 
            this.pnlMySchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMySchool.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMySchool.Controls.Add(this.picMySchoolMascot);
            this.pnlMySchool.Controls.Add(this.lblMySchoolMascot);
            this.pnlMySchool.Controls.Add(this.btnMySchoolToggleMascot);
            this.pnlMySchool.Location = new System.Drawing.Point(335, 190);
            this.pnlMySchool.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMySchool.Name = "pnlMySchool";
            this.pnlMySchool.Size = new System.Drawing.Size(497, 121);
            this.pnlMySchool.TabIndex = 31;
            // 
            // picMySchoolMascot
            // 
            this.picMySchoolMascot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMySchoolMascot.Image = global::Mathre.Properties.Resources.RedRiver;
            this.picMySchoolMascot.Location = new System.Drawing.Point(313, 22);
            this.picMySchoolMascot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picMySchoolMascot.Name = "picMySchoolMascot";
            this.picMySchoolMascot.Size = new System.Drawing.Size(126, 76);
            this.picMySchoolMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMySchoolMascot.TabIndex = 13;
            this.picMySchoolMascot.TabStop = false;
            this.picMySchoolMascot.Visible = false;
            // 
            // lblMySchoolMascot
            // 
            this.lblMySchoolMascot.AutoSize = true;
            this.lblMySchoolMascot.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMySchoolMascot.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMySchoolMascot.Location = new System.Drawing.Point(58, 31);
            this.lblMySchoolMascot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMySchoolMascot.Name = "lblMySchoolMascot";
            this.lblMySchoolMascot.Size = new System.Drawing.Size(134, 18);
            this.lblMySchoolMascot.TabIndex = 10;
            this.lblMySchoolMascot.Text = "Mascot: Roughriders";
            // 
            // btnMySchoolToggleMascot
            // 
            this.btnMySchoolToggleMascot.Location = new System.Drawing.Point(59, 69);
            this.btnMySchoolToggleMascot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMySchoolToggleMascot.Name = "btnMySchoolToggleMascot";
            this.btnMySchoolToggleMascot.Size = new System.Drawing.Size(154, 27);
            this.btnMySchoolToggleMascot.TabIndex = 9;
            this.btnMySchoolToggleMascot.Text = "Toggle Mascot Visibility";
            this.btnMySchoolToggleMascot.UseVisualStyleBackColor = true;
            // 
            // lblMySchoolTitle
            // 
            this.lblMySchoolTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMySchoolTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMySchoolTitle.Location = new System.Drawing.Point(294, 110);
            this.lblMySchoolTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblMySchoolTitle.Name = "lblMySchoolTitle";
            this.lblMySchoolTitle.Size = new System.Drawing.Size(579, 58);
            this.lblMySchoolTitle.TabIndex = 30;
            this.lblMySchoolTitle.Text = "Red River High School";
            this.lblMySchoolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMySchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1148, 532);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMySchool";
            this.Text = "My School";
            this.panel1.ResumeLayout(false);
            this.pnlMySchool.ResumeLayout(false);
            this.pnlMySchool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlMySchool;
		private System.Windows.Forms.Label lblMySchoolMascot;
		internal System.Windows.Forms.PictureBox picMySchoolMascot;
		internal System.Windows.Forms.Button btnMySchoolToggleMascot;
		internal System.Windows.Forms.Label lblMySchoolTitle;
	}
}