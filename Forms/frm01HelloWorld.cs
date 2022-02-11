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
			radEnglish.Click += (sender, e) => { lblTitle.Text = "Hello World"; };
			radFrench.Click += (sender, e) => { lblTitle.Text = "Bonjour le Monde"; };
			radGerman.Click += (sender, e) => { lblTitle.Text = "Hallo Welt"; };
			btnReset.Click += (sender, e) => { StartingLanguage.PerformClick(); };
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(this); }
			StartingLanguage = pnlLanguage.Controls.OfType<RadioButton>().First(radioButton => radioButton.Checked);
			StartingLanguage.PerformClick();
		}
		public void MenuControl(object sender, EventArgs e)
		{
			var senderName = ((ToolStripMenuItem)sender).Name;
			Action a = senderName.Substring(0, 3) switch
			{
				"btn" => () => ((Button)Controls.Find(senderName, true)[0]).PerformClick(),
				"rad" => () => ((RadioButton)Controls.Find(senderName, true)[0]).PerformClick(),
				"chb" => () => ((CheckBox)Controls.Find(senderName, true)[0]).Checked ^= true,
				_ => null,
			};
			a?.Invoke();
		}
		public void HelloWorld(object sender, EventArgs e)
		{
			if ($"{sender}" == "English") { radEnglish.PerformClick(); }
			if ($"{sender}" == "French") { radFrench.PerformClick(); }
			if ($"{sender}" == "German") { radGerman.PerformClick(); }
			if ($"{sender}" == "Reset") { btnReset.PerformClick(); }
			else if ($"{sender}" == "Secret")
			{
				pnlBody.Controls.OfType<RadioButton>().All(c => { c.Checked = false; return true; });
				lblTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString();
			}
		}
	}
}
