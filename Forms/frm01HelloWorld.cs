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
		private string StartingLanguage;
		public static Frm00Mathre BaseForm;
		public Frm01HelloWorld()
		{
			InitializeComponent();
			Load += FormLoad;
			btnHelloWorldFrench.Click += HelloWorld;
			btnHelloWorldReset.Click += HelloWorld;
			btnHelloWorldGerman.Click += HelloWorld;
			btnHelloWorldEnglish.Click += HelloWorld;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(this); }
			StartingLanguage = pnlHelloWorld.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name;
		}
		public void MenuControl(object sender, EventArgs e) { var ThisForm = Application.OpenForms.OfType<Frm01HelloWorld>().Single(); ThisForm.HelloWorld(sender, e); }
		public void HelloWorld(object sender, EventArgs e)
		{
			Console.WriteLine(sender);
			if (ReferenceEquals(sender, btnHelloWorldEnglish) | ReferenceEquals(sender, BaseForm.mnuHelloWorldLanguageEnglish))
			{
				btnHelloWorldEnglish.Checked = true;
				lblHelloWorldTitle.Text = "Hello World";
			}
			if (ReferenceEquals(sender, btnHelloWorldFrench) | ReferenceEquals(sender, BaseForm.mnuHelloWorldLanguageFrench))
			{
				btnHelloWorldFrench.Checked = true;
				lblHelloWorldTitle.Text = "Bonjour le Monde";
			}
			if (ReferenceEquals(sender, btnHelloWorldGerman) | ReferenceEquals(sender, BaseForm.mnuHelloWorldLanguageGerman))
			{
				btnHelloWorldGerman.Checked = true;
				lblHelloWorldTitle.Text = "Hallo Welt";
			}
			if (ReferenceEquals(sender, btnHelloWorldReset) | ReferenceEquals(sender, BaseForm.mnuHelloWorldReset))
			{
				HelloWorld(pnlHelloWorld.Controls[StartingLanguage], null);
			}
			else if (ReferenceEquals(sender, BaseForm.mnuRandomify))
			{
				btnHelloWorldEnglish.Checked = false;
				btnHelloWorldFrench.Checked = false;
				btnHelloWorldGerman.Checked = false;
				lblHelloWorldTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString();
			}
		}
	}
}
