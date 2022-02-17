// SOURCES:
// Flag Icons: https://www.iconfinder.com/iconsets/flags-37
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm01HelloWorld : Form
	{
		private RadioButton StartingLanguage;
		public Frm01HelloWorld()
		{
			InitializeComponent();
			Load += (p, e) => { StartingLanguage = pnlLanguage.Controls.OfType<RadioButton>().First(radioButton => radioButton.Checked); StartingLanguage.PerformClick(); };
			radEnglish.Click += (s, e) => lblTitle.Text = "Hello World";
			radFrench.Click += (s, e) => lblTitle.Text = "Bonjour le Monde";
			radGerman.Click += (s, e) => lblTitle.Text = "Hallo Welt";
			btnReset.Click += (s, e) => StartingLanguage.PerformClick();
		}
		public void HelloWorld(object sender, EventArgs e)
		{
			if ($"{sender}" == "English") radEnglish.PerformClick();
			if ($"{sender}" == "French") radFrench.PerformClick();
			if ($"{sender}" == "German") radGerman.PerformClick();
			if ($"{sender}" == "Reset") btnReset.PerformClick();
			else if ($"{sender}" == "Secret")
			{
				pnlBody.Controls.OfType<RadioButton>().All(c => { c.Checked = false; return true; });
				lblTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString();
			}
		}
	}
}
