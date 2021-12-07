﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Mathre
{
	public partial class FrmSlots : Form
	{
		public static FrmMathre BaseForm;
		public static FrmSlots ThisForm;
		public int tokens = 100;
		public int change = 0;
		public bool auto = true;
		int counter = 0;
		string PlayerName = "";
		public FrmSlots()
		{
			InitializeComponent();
			Load += FormLoad;
			btnSpin.Click += Gamble;
			chbAuto.CheckedChanged += Autocheck;
			Shown += Loaded;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmSlots>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Loaded(object sender, EventArgs e)
		{
			PlayerName = Interaction.InputBox("What is your Name?", "Slot Machine", "High Roller");
			double Age = 0;
			while (Age == 0)
			{
				string AgeCheck = Interaction.InputBox($"Hello {PlayerName}! What is your Age?", "Slot Machine");
				if (double.TryParse(AgeCheck, out double AgeResult))
				{
					Age = AgeResult;
				}
			}
			if (Age < 18)
			{
				int LegalAge = 18;
				MessageBox.Show($"Sorry, you are under the legal age to gamble ({LegalAge}). Goodbye.", "Ineligible");
				this.Close();
			}
		}
		public async void AutoGamble(object sender, EventArgs e)
		{
			counter = 0;
			while (auto)
			{
				counter++;
				chbMessage.Checked = true;
				Gamble(null, null);
				await Task.Delay(20);
			}
		}
		public void Autocheck(object sender, EventArgs e)
		{
			auto = chbAuto.Checked;
			AutoGamble(null, null);
		}
		public void Gamble(object sender, EventArgs e)
		{
			lblWinIndicator.Text = "";
			if (tokens <= 0)
			{
				Message("No Tokens", null);
			}
			else
			{
				if (tokens == 1 && chbDouble.Checked)
				{
					chbDouble.Checked = false;
				}
				tokens -= (1 + Convert.ToInt32(chbDouble.Checked));
				Random rnd = new(); // Generate random numbers 1-3
				int random1 = rnd.Next(1, 4);
				lbl1.Text = $"{random1}";
				int random2 = rnd.Next(1, 4);
				lbl2.Text = $"{random2}";
				int random3 = rnd.Next(1, 4);
				lbl3.Text = $"{random3}";
				if (random1 == 1 && random2 == 1 && random3 == 1) // Increase the token count and display the jackpot message for each jackpot
				{
					change = (5 + (Convert.ToInt32(chbDouble.Checked) * 5));
					tokens += change;
					Message($"{change} Token Jackpot!", null);
				}
				else if (random1 == 2 && random2 == 2 && random3 == 2)
				{
					change = (10 + (Convert.ToInt32(chbDouble.Checked) * 10));
					tokens += change;
					Message($"{change} Token Jackpot!", null);
				}
				else if (random1 == 3 && random2 == 3 && random3 == 3)
				{
					change = (15 + (Convert.ToInt32(chbDouble.Checked) * 15));
					tokens += change;
					Message($"{change} Token Jackpot!", null);
				}
			}
			lblScore.Text = $"{tokens}";
		}
		public void MenuHandler(object sender, EventArgs e)
		{
			Action A = sender.ToString() switch
			{
				"Spin" => () => ThisForm.btnSpin.PerformClick(),
				"Double Or Nothing" => () => ThisForm.chbDouble.Checked = !ThisForm.chbDouble.Checked,
				_ => () => ThisForm.chbMessage.Checked = !ThisForm.chbMessage.Checked,
			};
			A.Invoke();
		}
		public void Message(object sender, EventArgs e)
		{
			lblScore.Text = $"{tokens}"; // Update score before displaying the message box
			lblWinIndicator.Text = $"{sender}";
			string message = chbAuto.Checked switch
			{
				true => $"It took {counter} attempts to hit a jackpot and you earned {change - (counter + (Convert.ToInt32(chbDouble.Checked))*counter)} tokens.",
				_ => "",
			};
			if (chbMessage.Checked) // Ensure the user wants to see the message box
			{
				MessageBox.Show($"Congratulations {PlayerName}!\nYou have won a {sender}\n{message}", "                                        Result                                        ");
			}
			auto = false;
			chbAuto.Checked = auto;
		}
	}
}