// Sound Effects from zapsplat
using Mathre.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm17WordGuess : Form, IManager
	{

		public static Frm00Mathre BaseForm;
		string abc = " ";
		readonly List<string> guesses = new();
		int guesscount = 0;
		int correctguesses = 0;
		int totalguesses = 6;
		public Frm17WordGuess()
		{
			InitializeComponent();
			Load += FormLoad;
			txtP1.TextChanged += Default;
			txtP1.KeyDown += (p, e) => { if (txtP1.Text.Length > 15 && e.KeyCode != Keys.Back) { e.SuppressKeyPress = true; } };
			txtP2.KeyDown += (p, e) => { if (totalguesses < 1) { e.SuppressKeyPress = true; } if (txtP1.Text.Length == 0) { e.SuppressKeyPress = true; MessageBox.Show("PLEASE ENTER A WORD TO GUESS"); } };
			txtP2.TextChanged += Default;
			chbHide.CheckedChanged += (p, e) => { if (chbHide.Checked) { txtP1.UseSystemPasswordChar = true; } else { txtP1.UseSystemPasswordChar = false; } };
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e) { var ThisForm = Application.OpenForms.OfType<FrmTemplate>().Single(); ThisForm.Default(sender, e); }
		public void Default(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, txtP1))
			{
				guesses.Clear();
				guesscount = 0;
				totalguesses = 6;
				correctguesses = 0;
				lblGuessCount.Text = (guesscount - correctguesses).ToString();
				abc = "";
				for (int i = 0; i <= txtP1.Text.Length - 1; i++) { abc += Regex.Replace($"{txtP1.Text[i]}", @"((?=[^\-])\S)", "_"); }
				lblPhrase.Text = Regex.Replace(Regex.Replace(Regex.Replace($"{abc}", "  ", "   "), @"\s*-", " -"), "_", " _");
			}
			if (ReferenceEquals(sender, txtP2))
			{
				if (!guesses.Contains<string>(txtP2.Text.ToLower()) && txtP1.Text.Length > 0)
				{
					guesscount++;
					totalguesses--;
					guesses.Add(txtP2.Text.ToLower());
					for (int i = 0; i <= txtP1.Text.Length - 1; i++)
					{
						if ($"{txtP1.Text[i]}".ToLower() == txtP2.Text.ToLower())
						{
							abc = abc.Remove(i, 1);
							abc = abc.Insert(i, $"{txtP1.Text[i]}");
							correctguesses++;
							totalguesses++;
							Play("Chime");
						}
						else if (! txtP1.Text.ToLower().Contains(txtP2.Text.ToLower())){ SystemSounds.Asterisk.Play(); }
					}
					lblGuessCount.Text = (guesscount - correctguesses).ToString();
					lblPhrase.Text = Regex.Replace(Regex.Replace(Regex.Replace($"{abc}", "  ", "   "), "_", " _"), @"_(\w)", @"_ $1");
				}
				txtP2.TextChanged -= Default;
				txtP2.Clear();
				txtP2.TextChanged += Default;
				if (!lblPhrase.Text.Contains("_") && txtP1.Text.Length > 0) { Play("Koolaid"); MessageBox.Show("YOU HAVE WON"); }
				if (totalguesses < 1) { MessageBox.Show("YOU HAVE LOST"); }
			}
		}
		//https://stackoverflow.com/a/38006788
		[System.Runtime.InteropServices.DllImport("winmm.dll")]
		public static extern uint mciSendString(string lpstrCommand, System.Text.StringBuilder lpstrReturnString, int uReturnLength, IntPtr hWndCallback);
		public void Play(string file)
		{
			string Sound = string.Format($"{{0}}Resources\\{file}.mp3", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));
			mciSendString(@"close temp_alias", null, 0, IntPtr.Zero);
			mciSendString(@$"open ""{Sound}"" alias temp_alias", null, 0, IntPtr.Zero);
			mciSendString("play temp_alias", null, 0, IntPtr.Zero);
			//"play temp_alias repeat"
		}
	}
}