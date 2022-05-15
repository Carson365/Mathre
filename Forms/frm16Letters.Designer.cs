namespace Mathre
{
	partial class Frm16Letters
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
            this.lblOccurrances = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.pnlBody2.SuspendLayout();
            this.pnlBody.SuspendLayout();
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
            this.pnlFrame.TabIndex = 34;
            // 
            // pnlBody2
            // 
            this.pnlBody2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody2.Controls.Add(this.lblOccurrances);
            this.pnlBody2.Controls.Add(this.lblResult);
            this.pnlBody2.Controls.Add(this.lblFind);
            this.pnlBody2.Controls.Add(this.lblSearch);
            this.pnlBody2.Controls.Add(this.lblChar);
            this.pnlBody2.Controls.Add(this.lblText);
            this.pnlBody2.Location = new System.Drawing.Point(287, 261);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 36;
            // 
            // lblOccurrances
            // 
            this.lblOccurrances.AutoSize = true;
            this.lblOccurrances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrances.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOccurrances.Location = new System.Drawing.Point(170, 94);
            this.lblOccurrances.Name = "lblOccurrances";
            this.lblOccurrances.Size = new System.Drawing.Size(99, 20);
            this.lblOccurrances.TabIndex = 14;
            this.lblOccurrances.Text = "Occurrances";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResult.Location = new System.Drawing.Point(66, 94);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(98, 20);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "Occurances:";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFind.Location = new System.Drawing.Point(170, 58);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(132, 20);
            this.lblFind.TabIndex = 12;
            this.lblFind.Text = "Character to Find";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearch.Location = new System.Drawing.Point(170, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(112, 20);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Text to Search";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChar.Location = new System.Drawing.Point(28, 58);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(136, 20);
            this.lblChar.TabIndex = 10;
            this.lblChar.Text = "Character to Find:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblText.Location = new System.Drawing.Point(48, 22);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(116, 20);
            this.lblText.TabIndex = 9;
            this.lblText.Text = "Text to Search:";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.btnSearch);
            this.pnlBody.Location = new System.Drawing.Point(287, 150);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(176, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.lblTitle.Text = "Letter Counter";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm16Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm16Letters";
            this.Text = "Letter Counter";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody2.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblChar;
		internal System.Windows.Forms.Label lblText;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Button btnSearch;
		internal System.Windows.Forms.Label lblSearch;
		internal System.Windows.Forms.Label lblFind;
		internal System.Windows.Forms.Label lblOccurrances;
		internal System.Windows.Forms.Label lblResult;
	}
}