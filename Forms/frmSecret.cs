using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmSecret : Form
	{
		public static Frm00Mathre BaseForm;
		public FrmSecret()
		{
			InitializeComponent();
			btnSecretDisable.Click += SecretHandler;
			btnSecretEnable.Click += SecretHandler;
			txtSecretPassword.KeyUp += SecretHandler;
			chbPopUps.CheckedChanged += (p, e) => Properties.Settings.Default.bPopups = chbPopUps.Checked;
			chbDark.CheckedChanged += (p, e) =>
			{
				foreach (Control c in BaseForm.Controls) Recurse(c); BaseForm.Dark = true;
				foreach (ToolStripMenuItem ti in BaseForm.mnuBaseLayer.Items)
				{
					Recurse(ti);
				}
			};
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
		}
		public void Recurse(object o)
		{
			if (o is ToolStripMenuItem ti) { foreach (ToolStripItem a in ti.DropDownItems) Recurse(a); TSITheme(ti); }
			else if (o is ToolStripTextBox tb) { tb.BackColor = Color.Gray; }
			else if (o is Control c)
			{
				foreach (Control a in c.Controls) Recurse(a); DarkMode(c);
			}
		}

		private void TSITheme(ToolStripMenuItem ti)
		{
			ti.DropDown.BackColor = Color.DimGray;
			ti.DropDown.ForeColor = Color.White;
		}

		public void DarkMode(Control c)
		{
			if (c is Form f)
			{
				f.BackColor = BaseForm.Blend(Color.DimGray, Color.Black, 0.5);
			}
			else if (c is Panel pnl)
			{
				if (pnl.Name != "pnlFrame")
				{
					if (pnl.BackColor != Color.Transparent) pnl.BackColor = Color.Gray;
					else pnl.BackColor = Color.DimGray;
				}
				else pnl.BackColor = BaseForm.Blend(Color.DimGray, Color.Black, 0.5);
			}

			else if (c is TextBox) { c.BackColor = Color.Gray; }
			else if (c is ListView || c is MenuStrip || c is TabControl) { c.BackColor = Color.DimGray; }
			else if (c is NumericUpDown || c is Button || c.Parent is UpDownBase) { c.BackColor = Color.DimGray; }
			else if (c is ListView lv) lv.ForeColor = Color.DimGray;
			else c.BackColor = Color.Transparent;
			{ c.ForeColor = Color.White; }
			//if (c is MenuStrip m) m.ForeColor = Color.Black;
			if (c is Button btn)
			{
				btn.FlatStyle = FlatStyle.Flat;
				btn.FlatAppearance.BorderColor = BaseForm.BackColor;
				btn.FlatAppearance.BorderSize = 1;
			}
		}
		public void SecretHandler(object sender, EventArgs e)
		{
			if (sender == txtSecretPassword)
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
			}
			Frm01HelloWorld F01 = Application.OpenForms.OfType<Frm01HelloWorld>().Single();
			if (sender == btnSecretEnable) F01.show = true;
			if (sender == btnSecretDisable) F01.show = true;
		}
	}
}
