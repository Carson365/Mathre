using Mathre.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmSecret : Form, IManager
	{
		public static Frm00Mathre BaseForm;
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
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e)
		{
			Action a = $"{((ToolStripMenuItem)sender).Name}".Substring(0, 3) switch
			{
				"btn" => () => ((Button)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).PerformClick(),
				"rad" => () => ((RadioButton)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).PerformClick(),
				"chb" => () => ((CheckBox)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).Checked ^= true,
				_ => null,
			};
			a?.Invoke();
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
				if (btnSecretEnable.Enabled == false) { BaseForm.hidden = true; }
			}
			if (ReferenceEquals(sender, btnSecretEnable)) { BaseForm.hidden = false; btnSecretEnable.Checked = true; }
			if (ReferenceEquals(sender, btnSecretDisable)) { BaseForm.hidden = true; btnSecretDisable.Checked = true; }
		}
	}
}
