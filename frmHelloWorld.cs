using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmHelloWorld : Form
	{
		public static string StartingLanguage;
		public static FrmMathre main;
		public static FrmHelloWorld HW;

		public FrmHelloWorld()
		{
			InitializeComponent();
			Load += FormLoad;
			btnHelloWorldFrench.Click += HelloWorld;
			btnHelloWorldReset.Click += HelloWorld;
			btnHelloWorldGerman.Click += HelloWorld;
			btnHelloWorldEnglish.Click += HelloWorld;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			HW = Application.OpenForms.OfType<FrmHelloWorld>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(this);
			}
			StartingLanguage = pnlHelloWorld.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name; // Store the default checked radio button in grpHelloWorld
		}
		public void HelloWorld(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, btnHelloWorldEnglish) | ReferenceEquals(sender, main.mnuHelloWorldLanguageEnglish))
			{
				HW.btnHelloWorldEnglish.Checked = true;
				HW.lblHelloWorldTitle.Text = "Hello World"; // Sets lblHelloWorld to English
			}
			else if (ReferenceEquals(sender, btnHelloWorldFrench) | ReferenceEquals(sender, main.mnuHelloWorldLanguageFrench)) // If the event is caused by the French button or menu item:
			{
				HW.btnHelloWorldFrench.Checked = true;
				HW.lblHelloWorldTitle.Text = "Bonjour le Monde"; // Sets lblHelloWorld to French
			}
			else if (ReferenceEquals(sender, btnHelloWorldGerman) | ReferenceEquals(sender, main.mnuHelloWorldLanguageGerman)) // If the event is caused by the German button or menu item:
			{
				HW.btnHelloWorldGerman.Checked = true;
				HW.lblHelloWorldTitle.Text = "Hallo Welt"; // Sets lblHelloWorld to German
			}
			else if (ReferenceEquals(sender, btnHelloWorldReset) | ReferenceEquals(sender, main.mnuHelloWorldReset))  // If the event is caused by the Reset button or menu item:
			{
				HelloWorld(pnlHelloWorld.Controls[StartingLanguage], null); // Call back to the Buttons Sub with the pre-stored initially checked radio button substituted as sender in order to reset both the buttons and the label to their initial value
			}
			else if (ReferenceEquals(sender, main.mnuRandomify))
			{
				HW.btnHelloWorldEnglish.Checked = false;
				HW.btnHelloWorldFrench.Checked = false;
				HW.btnHelloWorldGerman.Checked = false;
				HW.lblHelloWorldTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString(); // Uses a random value between 0 and 1 with modification to 'randomify' the lblHelloWorld value
			}
		}
	}
}
