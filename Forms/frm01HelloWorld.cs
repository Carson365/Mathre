// Flag icons are sourced from the free icon set at https://www.iconfinder.com/iconsets/flags-37
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmHelloWorld : Form
	{
		private string StartingLanguage;
		public static FrmMathre BaseForm;
		public static FrmHelloWorld ThisForm;

		public FrmHelloWorld()
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
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmHelloWorld>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(this);
			}
			StartingLanguage = pnlHelloWorld.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name;
		}
		public void HelloWorld(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, btnHelloWorldEnglish) | ReferenceEquals(sender, BaseForm.mnuHelloWorldLanguageEnglish))
			{
				ThisForm.btnHelloWorldEnglish.Checked = true;
				ThisForm.lblHelloWorldTitle.Text = "Hello World";
			}
			else if (ReferenceEquals(sender, btnHelloWorldFrench) | ReferenceEquals(sender, BaseForm.mnuHelloWorldLanguageFrench))
			{
				ThisForm.btnHelloWorldFrench.Checked = true;
				ThisForm.lblHelloWorldTitle.Text = "Bonjour le Monde";
			}
			if (ReferenceEquals(sender, btnHelloWorldGerman) | ReferenceEquals(sender, BaseForm.mnuHelloWorldLanguageGerman))
			{
				ThisForm.btnHelloWorldGerman.Checked = true;
				ThisForm.lblHelloWorldTitle.Text = "Hallo Welt";
			}
			else if (ReferenceEquals(sender, btnHelloWorldReset) | ReferenceEquals(sender, BaseForm.mnuHelloWorldReset))
			{
				HelloWorld(pnlHelloWorld.Controls[StartingLanguage], null);
			}
			else if (ReferenceEquals(sender, BaseForm.mnuRandomify))
			{
				ThisForm.btnHelloWorldEnglish.Checked = false;
				ThisForm.btnHelloWorldFrench.Checked = false;
				ThisForm.btnHelloWorldGerman.Checked = false;
				ThisForm.lblHelloWorldTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString();
			}
		}
	}
}
