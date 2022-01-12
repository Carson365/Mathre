// SOURCES:
// Flag Icons: https://www.iconfinder.com/iconsets/flags-37
using Mathre.Forms;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm01HelloWorld : Form, IManager
	{
		private RadioButton StartingLanguage;
		public static Frm00Mathre BaseForm;
		public Frm01HelloWorld()
		{
			InitializeComponent();
			Load += FormLoad;
			btnEnglish.Click += (sender, e) => { lblTitle.Text = "Hello World"; };
			btnFrench.Click += (sender, e) => { lblTitle.Text = "Bonjour le Monde"; };
			btnGerman.Click += (sender, e) => { lblTitle.Text = "Hallo Welt"; };
			btnReset.Click += (sender, e) => { StartingLanguage.PerformClick(); };
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(this); }
			StartingLanguage = pnlLanguage.Controls.OfType<RadioButton>().First(radioButton => radioButton.Checked);
			StartingLanguage.PerformClick();
		}
		public void MenuControl(object sender, EventArgs e) { var ThisForm = Application.OpenForms.OfType<Frm01HelloWorld>().Single(); ThisForm.HelloWorld(sender, e); }
		public void HelloWorld(object sender, EventArgs e)
		{
			if ($"{sender}" == "English") { btnEnglish.PerformClick(); }
			if ($"{sender}" == "French") { btnFrench.PerformClick(); }
			if ($"{sender}" == "German") { btnGerman.PerformClick(); }
			if ($"{sender}" == "Reset") { btnReset.PerformClick(); }
			else if ($"{sender}" == "Secret")
			{
				pnlBody.Controls.OfType<RadioButton>().All(c => { c.Checked = false; return true; });
				lblTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString();
			}
		}
	}
}
