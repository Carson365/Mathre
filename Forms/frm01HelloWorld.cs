// SOURCES:
// Flag Icons: https://www.iconfinder.com/iconsets/flags-37
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm01HelloWorld : Form
	{
		private RadioButton StartingLanguage;
		static readonly Random rnd = new();
		public bool show = false;
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
			if ($"{sender}" == "Secret" && show)
			{
				pnlLanguage.Controls.OfType<RadioButton>().All(c => c.Checked = false).Equals(true);
				lblTitle.Text = "";
				for (int i = rnd.Next(1, 4); i > 0; i--)
				{
					lblTitle.Text += ((char)rnd.Next(65, 91));
					for (int n = 0; n < rnd.Next(3 - i, 6); n++) lblTitle.Text += ((char)rnd.Next(97, 123));
					lblTitle.Text += ((char)32);
				}
			}
		}
	}
}
