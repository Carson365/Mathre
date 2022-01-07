using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmSecret : Form
	{
		public static Frm00Mathre BaseForm;
		public static FrmSecret ThisForm;
		public FrmSecret()
		{
			InitializeComponent();
			Load += FormLoad;
			btnSecretDisable.Click += SecretHandler;
			btnSecretEnable.Click += SecretHandler;
			txtSecretPassword.KeyUp += SecretHandler;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmSecret>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void SecretHandler(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, txtSecretPassword))
			{
				string hashedvalue;
				if (string.IsNullOrEmpty(txtSecretPassword.Text)) hashedvalue = string.Empty;
				using (var sha = new System.Security.Cryptography.SHA256Managed())
				{
					byte[] textData = System.Text.Encoding.UTF8.GetBytes(txtSecretPassword.Text);
					byte[] hash = sha.ComputeHash(textData);
					hashedvalue = BitConverter.ToString(hash).Replace("-", string.Empty);
				}
				if (hashedvalue == "5994471ABB01112AFCC18159F6CC74B4F511B99806DA59B3CAF5A9C173CACFC5") { btnSecretEnable.Enabled = true; btnSecretDisable.Enabled = true; }
				else { btnSecretEnable.Enabled = false; btnSecretDisable.Enabled = false; btnSecretDisable.Checked = true; }
				if (btnSecretEnable.Enabled == false) { BaseForm.mnuSecret.Enabled = false; }
			}
			if (ReferenceEquals(sender, btnSecretEnable)) { BaseForm.mnuSecret.Enabled = true; btnSecretEnable.Checked = true; }
			if (ReferenceEquals(sender, btnSecretDisable)) { BaseForm.mnuSecret.Enabled = false; btnSecretDisable.Checked = true; }
		}
	}
}
