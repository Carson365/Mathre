﻿namespace Mathre
{
	partial class Frm23Friends
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFriendsTitle = new System.Windows.Forms.Label();
            this.lblFriendsList = new System.Windows.Forms.Label();
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
            this.pnlBody2.Controls.Add(this.lblFriendsList);
            this.pnlBody2.Controls.Add(this.lblFriendsTitle);
            this.pnlBody2.Location = new System.Drawing.Point(287, 276);
            this.pnlBody2.Name = "pnlBody2";
            this.pnlBody2.Size = new System.Drawing.Size(426, 136);
            this.pnlBody2.TabIndex = 38;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.txtSearch);
            this.pnlBody.Controls.Add(this.btnSearch);
            this.pnlBody.Controls.Add(this.btnSort);
            this.pnlBody.Controls.Add(this.btnInput);
            this.pnlBody.Location = new System.Drawing.Point(287, 165);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(426, 105);
            this.pnlBody.TabIndex = 32;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(163, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(285, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(50, 52);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(85, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "&Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(171, 41);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(85, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "&Input Contacts";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 95);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(626, 51);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "My Friends";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriendsTitle
            // 
            this.lblFriendsTitle.AutoSize = true;
            this.lblFriendsTitle.Location = new System.Drawing.Point(109, 28);
            this.lblFriendsTitle.Name = "lblFriendsTitle";
            this.lblFriendsTitle.Size = new System.Drawing.Size(60, 13);
            this.lblFriendsTitle.TabIndex = 0;
            this.lblFriendsTitle.Text = "Friends List";
            // 
            // lblFriendsList
            // 
            this.lblFriendsList.AutoSize = true;
            this.lblFriendsList.Location = new System.Drawing.Point(109, 56);
            this.lblFriendsList.Name = "lblFriendsList";
            this.lblFriendsList.Size = new System.Drawing.Size(47, 13);
            this.lblFriendsList.TabIndex = 1;
            this.lblFriendsList.Text = "[Friends]";
            // 
            // Frm23Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlFrame);
            this.Name = "Frm23Friends";
            this.Text = "My Friends";
            this.pnlFrame.ResumeLayout(false);
            this.pnlBody2.ResumeLayout(false);
            this.pnlBody2.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlFrame;
		private System.Windows.Forms.Panel pnlBody2;
		private System.Windows.Forms.Panel pnlBody;
		internal System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblFriendsList;
		private System.Windows.Forms.Label lblFriendsTitle;
	}
}