
namespace Mathre
{
	partial class FrmSecret
	{
		/// <summary>
		/// Required designer variable.
	protected override void Dispose(bool disposing)
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlSecretFrame = new System.Windows.Forms.Panel();
            this.pnlSecret = new System.Windows.Forms.Panel();
            this.btnSecretDisable = new System.Windows.Forms.RadioButton();
            this.lblSecretPrompt = new System.Windows.Forms.Label();
            this.btnSecretEnable = new System.Windows.Forms.RadioButton();
            this.txtSecretPassword = new System.Windows.Forms.TextBox();
            this.lblSecretTitle = new System.Windows.Forms.Label();
            this.pnlSecretFrame.SuspendLayout();
            this.pnlSecret.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSecretFrame
            // 
            this.pnlSecretFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecretFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecretFrame.Controls.Add(this.pnlSecret);
            this.pnlSecretFrame.Controls.Add(this.lblSecretTitle);
            this.pnlSecretFrame.Location = new System.Drawing.Point(-8, -20);
            this.pnlSecretFrame.Name = "pnlSecretFrame";
            this.pnlSecretFrame.Size = new System.Drawing.Size(1000, 500);
            this.pnlSecretFrame.TabIndex = 32;
            // 
            // pnlSecret
            // 
            this.pnlSecret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSecret.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSecret.Controls.Add(this.btnSecretDisable);
            this.pnlSecret.Controls.Add(this.lblSecretPrompt);
            this.pnlSecret.Controls.Add(this.btnSecretEnable);
            this.pnlSecret.Controls.Add(this.txtSecretPassword);
            this.pnlSecret.Location = new System.Drawing.Point(287, 165);
            this.pnlSecret.Name = "pnlSecret";
            this.pnlSecret.Size = new System.Drawing.Size(426, 105);
            this.pnlSecret.TabIndex = 32;
            // 
            // btnSecretDisable
            // 
            this.btnSecretDisable.AutoSize = true;
            this.btnSecretDisable.Checked = true;
            this.btnSecretDisable.Enabled = false;
            this.btnSecretDisable.Location = new System.Drawing.Point(85, 66);
            this.btnSecretDisable.Name = "btnSecretDisable";
            this.btnSecretDisable.Size = new System.Drawing.Size(60, 17);
            this.btnSecretDisable.TabIndex = 11;
            this.btnSecretDisable.TabStop = true;
            this.btnSecretDisable.Text = "Disable";
            this.btnSecretDisable.UseVisualStyleBackColor = true;
            // 
            // lblSecretPrompt
            // 
            this.lblSecretPrompt.AutoSize = true;
            this.lblSecretPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretPrompt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSecretPrompt.Location = new System.Drawing.Point(52, 23);
            this.lblSecretPrompt.Name = "lblSecretPrompt";
            this.lblSecretPrompt.Size = new System.Drawing.Size(153, 20);
            this.lblSecretPrompt.TabIndex = 9;
            this.lblSecretPrompt.Text = "Enter the Passcode:";
            // 
            // btnSecretEnable
            // 
            this.btnSecretEnable.AutoSize = true;
            this.btnSecretEnable.Enabled = false;
            this.btnSecretEnable.Location = new System.Drawing.Point(283, 67);
            this.btnSecretEnable.Name = "btnSecretEnable";
            this.btnSecretEnable.Size = new System.Drawing.Size(58, 17);
            this.btnSecretEnable.TabIndex = 10;
            this.btnSecretEnable.Text = "Enable";
            this.btnSecretEnable.UseVisualStyleBackColor = true;
            // 
            // txtSecretPassword
            // 
            this.txtSecretPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtSecretPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecretPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretPassword.Location = new System.Drawing.Point(261, 21);
            this.txtSecretPassword.Name = "txtSecretPassword";
            this.txtSecretPassword.PasswordChar = '∗';
            this.txtSecretPassword.Size = new System.Drawing.Size(114, 26);
            this.txtSecretPassword.TabIndex = 9;
            // 
            // lblSecretTitle
            // 
            this.lblSecretTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecretTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretTitle.Location = new System.Drawing.Point(187, 95);
            this.lblSecretTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSecretTitle.Name = "lblSecretTitle";
            this.lblSecretTitle.Size = new System.Drawing.Size(626, 51);
            this.lblSecretTitle.TabIndex = 31;
            this.lblSecretTitle.Text = "Enable Super Secret Settings";
            this.lblSecretTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSecret
