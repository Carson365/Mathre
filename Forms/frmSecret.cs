using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmSecret : Form
	{
		static Frm00Mathre BaseForm;
		readonly static ColorDialog cdlCustom = new();
		readonly List<int> colors = new();
		readonly static Frm01HelloWorld F01 = Application.OpenForms.OfType<Frm01HelloWorld>().Single();
		bool unlocked = false;
		public FrmSecret()
		{
			InitializeComponent();
			Shown += SecretHandler;
			btnCustomColor.Click += CustomColor;
			radSecretDisable.Click += (p, e) => F01.show = true;
			radSecretEnable.Click += (p, e) => F01.show = true;
			txtSecretPassword.KeyUp += SecretHandler;
			chbPopUps.CheckedChanged += (p, e) => Properties.Settings.Default.bPopups = chbPopUps.Checked;
			chbDark.CheckedChanged += (p, e) => { BaseForm.Dark = chbDark.Checked; BaseForm.StartTheme(); }; // Set the Dark Mode
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			chbDark.Checked = BaseForm.Dark;
		}
		public void SecretHandler(object sender, EventArgs e)
		// Check the hash of the input text against the stored value (sha256 hash of "12345")
		{
			System.Security.Cryptography.SHA256 sha = System.Security.Cryptography.SHA256.Create();
			byte[] hash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(txtSecretPassword.Text));
			if (BitConverter.ToString(hash).Replace("-", string.Empty) == "5994471ABB01112AFCC18159F6CC74B4F511B99806DA59B3CAF5A9C173CACFC5") unlocked = true;
			else { unlocked = false; radSecretDisable.Checked = true; }
			radSecretEnable.Enabled = unlocked;
			radSecretDisable.Enabled = unlocked;
			chbDark.Enabled = unlocked;
			chbPopUps.Enabled = unlocked;
			btnCustomColor.Enabled = unlocked;
			lblSecretDescription.ForeColor = unlocked ? (BaseForm.Dark ? Color.White : Color.Black) : (BaseForm.Dark ? Frm00Mathre.Blend(Color.DimGray, Color.Black, 0.8) : Color.Gray);
		}
		public void CustomColor(object sender, EventArgs e)
		// Allow the user to pick a custom theme color. Store past theme colors in a list.
		{
			cdlCustom.Color = Frm00MathreHelpers.SystemColor;
			cdlCustom.SolidColorOnly = true;
			if (!colors.Contains(ColorTranslator.ToOle(Frm00MathreHelpers.SystemColor))) colors.Add(ColorTranslator.ToOle(Frm00MathreHelpers.SystemColor));
			cdlCustom.CustomColors = colors.ToArray();
			if (cdlCustom.ShowDialog() == DialogResult.OK) Frm00MathreHelpers.SystemColor = cdlCustom.Color;
			BaseForm.PaintTheme();
		}
	}
}
