
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
            this.pnlMySchool = new System.Windows.Forms.Panel();
            this.picMySchoolMascot = new System.Windows.Forms.PictureBox();
            this.lblMySchoolMascot = new System.Windows.Forms.Label();
            this.btnMySchoolToggleMascot = new System.Windows.Forms.Button();
            this.lblMySchoolTitle = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlMySchool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.pnlMySchool);
            this.pnlFrame.Controls.Add(this.lblMySchoolTitle);
            this.pnlFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlFrame.TabIndex = 32;
            // 
            // pnlMySchool
            // 
            this.pnlMySchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMySchool.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMySchool.Controls.Add(this.picMySchoolMascot);
            this.pnlMySchool.Controls.Add(this.lblMySchoolMascot);
            this.pnlMySchool.Controls.Add(this.btnMySchoolToggleMascot);
            this.pnlMySchool.Location = new System.Drawing.Point(287, 165);
            this.pnlMySchool.Name = "pnlMySchool";
            this.pnlMySchool.Size = new System.Drawing.Size(426, 105);
            this.pnlMySchool.TabIndex = 31;
            // 
            // picMySchoolMascot
            // 
            this.picMySchoolMascot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMySchoolMascot.Image = global::Mathre.My.Resources.Resources.RedRiver;
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
            // lblMySchoolTitle
            // 
            this.lblMySchoolTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMySchoolTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySchoolTitle.Location = new System.Drawing.Point(252, 95);
            this.lblMySchoolTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblMySchoolTitle.Name = "lblMySchoolTitle";
            this.lblMySchoolTitle.Size = new System.Drawing.Size(496, 50);
            this.lblMySchoolTitle.TabIndex = 30;
            this.lblMySchoolTitle.Text = "Red River High School";
            this.lblMySchoolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlMySchool.ResumeLayout(false);
            this.pnlMySchool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMySchoolMascot)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlMySchool;
		private System.Windows.Forms.Label lblMySchoolMascot;
		internal System.Windows.Forms.PictureBox picMySchoolMascot;
		internal System.Windows.Forms.Button btnMySchoolToggleMascot;
		internal System.Windows.Forms.Label lblMySchoolTitle;
	}
}