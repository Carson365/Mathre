using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmHelloWorld : Form
	{
		public static string StartingValue; // Define a global variable to store the starting value of the lblHelloWorld Label
		public static string AccentColor; // Define a global variable to store the starting value of the System Accent Color
		public static Color SystemColor; // Define a global color to store the converted value of the System Accent Color
		public object Placeholder; // Define a global object to use to send blank events between event handlers

		public FrmHelloWorld()
		{
			InitializeComponent();
			btnHelloWorldFrench.Click += HelloWorld2;
			Load += FormLoad;
			btnHelloWorldReset.Click += HelloWorld2;
			btnHelloWorldGerman.Click += HelloWorld2;
			btnHelloWorldEnglish.Click += HelloWorld2;
			//mnuHelloWorldReset.Click += HelloWorld;
			//mnuHelloWorldLanguageGerman.Click += HelloWorld;
			//mnuHelloWorldLanguageFrench.Click += HelloWorld;
			//mnuHelloWorldLanguageEnglish.Click += HelloWorld;
			//mnuRandomify.Click += HelloWorld;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM"); // Navigate to this windows directory key
			AccentColor = Conversions.ToString(ColorKey.GetValue("AccentColor")); // Set the systemcolor variable to the value of the AccentColor field within the windows directory key
			ColorKey.Close(); // Stop registry access
			StartingValue = pnlHelloWorld.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name; // Store the default checked radio button in grpHelloWorld
			SystemColor = ColorTranslator.FromWin32(Conversions.ToInteger(AccentColor)); // Translate the system accent color to a usable format
			var mainForm = Application.OpenForms.OfType<FrmMathre>().Single();
			foreach (Control c in Controls)
			{
				mainForm.GetAllControls(c);
			}
		}
		public void HelloWorld2(object sender, EventArgs e)
		{
			Console.WriteLine(sender);
			FrmMathre main = new();
			if (ReferenceEquals(sender, btnHelloWorldEnglish) || ReferenceEquals(sender, main.mnuHelloWorldLanguageEnglish))
			{
				btnHelloWorldEnglish.Checked = true;
				lblHelloWorldTitle.Text = "Hello World";
			}
			else if (ReferenceEquals(sender, btnHelloWorldFrench))
			{
				btnHelloWorldFrench.Checked = true;
				lblHelloWorldTitle.Text = "Bonjour le Monde";
			}
			else if (ReferenceEquals(sender, btnHelloWorldGerman))
			{
				btnHelloWorldGerman.Checked = true;
				lblHelloWorldTitle.Text = "Hallo Welt";
			}
			else if (ReferenceEquals(sender, btnHelloWorldReset))
			{
				HelloWorld2(pnlHelloWorld.Controls[StartingValue], null);
			}
			//else if (ReferenceEquals(sender, mnuRandomify))
			//{
			//	btnHelloWorldEnglish.Checked = false;
			//	btnHelloWorldFrench.Checked = false;
			//	btnHelloWorldGerman.Checked = false;
			//	lblHelloWorldTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString(); // Uses a random value between 0 and 1 with modification to 'randomify' the lblHelloWorld value
			//}
		}
	}
}

