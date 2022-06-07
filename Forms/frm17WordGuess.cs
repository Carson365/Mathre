// Sound Effects from zapsplat
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;
namespace Mathre
{

	public partial class Frm17WordGuess : Form
	{
		static Frm01HelloWorld BaseForm;
		string abc = " ";
		readonly List<string> guesses = new();
		int guesscount = 0;
		int correctguesses = 0;
		int totalguesses = 6;
		bool playsounds = false;
		int elapsedtime = 1;
		bool finished = false;
		bool runonce = true;
		int color = 0;
		int runcolors = 10;
		int Loading = 4;
		public Frm17WordGuess()
		{
			InitializeComponent();
			Load += (p, e) => Timer();
			txtP1.TextChanged += Default;
			txtP1.KeyDown += KeyPressEvent;
			txtP2.KeyDown += KeyPressEvent;
			txtP2.TextChanged += Default;
			VisibleChanged += (p, e) => { if (Loading > 0) Loading--; else { playsounds = Visible; Play("Background"); } };
			chbHide.CheckedChanged += (p, e) => { if (chbHide.Checked) txtP1.UseSystemPasswordChar = true; else txtP1.UseSystemPasswordChar = false; };
			chbSounds.CheckedChanged += (p, e) => { playsounds = !playsounds; Play("Background"); };
			BaseForm = Application.OpenForms.OfType<Frm01HelloWorld>().Single();
		}
		public void TickEvent(object sender, EventArgs e) { lblTime.Text = $"{elapsedtime++}"; if (finished) { tmrTime.Stop(); elapsedtime = 0; lblTime.Text = "0"; } }
		public void Timer() { System.Timers.Timer aTimer = new(100); aTimer.Elapsed += FlashScreen; aTimer.Enabled = true; }
		public void Default(object sender, EventArgs e)
		{
			if (sender == txtP1)
			{
				{ finished = true; runonce = true; tmrTime.Tick -= TickEvent; }
				{ guesses.Clear(); guesscount = 0; totalguesses = 6; correctguesses = 0; abc = ""; }
				lblGuessCount.Text = (guesscount - correctguesses).ToString();
				// Sets every non-dash, non-whitespace character to an underscore
				for (int i = 0; i <= txtP1.Text.Length - 1; i++) { abc += Regex.Replace($"{txtP1.Text[i]}", @"((?=[^\-])\S)", "_"); }
				// Sets every underscore to have the proper spacing, and adds spaces before dashes and preexisting spaces as necessary
				lblPhrase.Text = Regex.Replace(Regex.Replace(Regex.Replace($"{abc}", "  ", "   "), @"\s*-", " -"), "_", " _");
			}
			if (sender == txtP2)
			{
				if (runonce) { finished = false; tmrTime.Start(); tmrTime.Tick += TickEvent; runonce = false; }
				if (!guesses.Contains<string>(txtP2.Text.ToLower()) && txtP1.Text.Length > 0)
				{
					bool addonce = false;
					guesscount++;
					totalguesses--;
					guesses.Add(txtP2.Text.ToLower());
					for (int i = 0; i <= txtP1.Text.Length - 1; i++)
					{
						if ($"{txtP1.Text[i]}".ToLower() == txtP2.Text.ToLower())
						{
							abc = abc.Remove(i, 1);
							abc = abc.Insert(i, $"{txtP1.Text[i]}");
							if (!addonce) { correctguesses++; addonce = true; }
							totalguesses++;
							Play("Chime");
						}
						else if (!txtP1.Text.ToLower().Contains(txtP2.Text.ToLower())) { SystemSounds.Asterisk.Play(); }
					}
					lblGuessCount.Text = (guesscount - correctguesses).ToString();
					// Replaces each dash corresponding to a correct letter guess with its respective letter
					lblPhrase.Text = Regex.Replace(Regex.Replace(Regex.Replace($"{abc}", "  ", "   "), "_", " _"), @"_(\w)", @"_ $1");
				}
				{ txtP2.TextChanged -= Default; txtP2.Clear(); txtP2.TextChanged += Default; }
				if (!lblPhrase.Text.Contains('_') && txtP1.Text.Length > 0) { Play("Koolaid"); finished = true; runcolors = 0; if (Properties.Settings.Default.bPopups) MessageBox.Show("YOU HAVE WON"); }
				if (totalguesses < 1) if (Properties.Settings.Default.bPopups) MessageBox.Show("YOU HAVE LOST");
			}
		}
		// https://stackoverflow.com/a/38006788
		[System.Runtime.InteropServices.DllImport("winmm.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
		static extern uint mciSendString(string command, StringBuilder buffer, int buffersize, int hWndCallback);
		public void Play(string file)
		{
			string Sound = string.Format($"{{0}}Resources\\{file}.mp3", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));
			mciSendString(@$"close {file}", null, 0, 0).Equals(true);
			if (playsounds)
			{
				// Gets the location of the file by string, opens it using the native windows API "mciSendString" after ensuring another isn't open, then closes it when done.
				mciSendString(@$"open ""{Sound}"" alias {file}", null, 0, 0).Equals(true);
				if (file == "Background") mciSendString($"play {file} repeat", null, 0, 0).Equals(true);
				else mciSendString($"play {file}", null, 0, 0).Equals(true);
			}
		}
		public void FlashScreen(object sender, ElapsedEventArgs e)
		{
			if (runcolors < 10)
			{
				BackColor = color switch
				{
					0 => System.Drawing.ColorTranslator.FromHtml("#ED8E89"),
					1 => System.Drawing.ColorTranslator.FromHtml("#F7B685"),
					2 => System.Drawing.ColorTranslator.FromHtml("#F3EBA5"),
					3 => System.Drawing.ColorTranslator.FromHtml("#94C691"),
					4 => System.Drawing.ColorTranslator.FromHtml("#9BD6D9"),
					_ => System.Drawing.ColorTranslator.FromHtml("#B4A8E0"),
				};
				if (color > 4) color = 0; else color++;
				runcolors++;
			}
			else BackColor = BaseForm.BackColor;
		}
		public void KeyPressEvent(object sender, KeyEventArgs e)
		{
			TextBox tB = sender as TextBox;
			if (tB.Name == "txtP1") { if (tB.Text.Length > 15 && e.KeyCode != Keys.Back) e.SuppressKeyPress = true; }
			else
			{
				if (totalguesses < 1)
				{
					e.SuppressKeyPress = true;
				}
				else if (txtP1.Text.Length == 0)
				{
					e.SuppressKeyPress = true;
					if (Properties.Settings.Default.bPopups) MessageBox.Show("PLEASE ENTER A WORD TO GUESS");
				}
			}
		}
	}
}