using Microsoft.VisualBasic;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm13Slots : Form
	{
		public int tokens = 30;
		public int change = 0;
		public bool auto = true;
		public bool loadedonce = false;
		int counter = 0;
		string PlayerName = "";
		int Loading = 4;
		public Frm13Slots()
		{
			InitializeComponent();
			btnSpin.Click += Gamble;
			chbAuto.CheckedChanged += Autocheck;
			VisibleChanged += (p, e) => { if (Loading == 0 && !loadedonce) { loadedonce = true; Loaded(); } Loading--; };
		}
		public void Loaded()
		{
			lblScore.Text = tokens.ToString();
			PlayerName = Interaction.InputBox("What is your Name?", "Slot Machine", "High Roller");
			double Age = 0;
			while (Age == 0)
			{
				string AgeCheck = Interaction.InputBox($"Hello {PlayerName}! What is your Age?", "Slot Machine");
				if (double.TryParse(AgeCheck, out double AgeResult)) Age = AgeResult;
			}
			if (Age < 18) { int LegalAge = 18; MessageBox.Show($"Sorry, you are under the legal age to gamble ({LegalAge}). Goodbye.", "Ineligible"); Close(); }
		}
		public async void AutoGamble(object sender, EventArgs e) { while (auto) { chbMessage.Checked = true; Gamble(null, null); await Task.Delay(20); } }
		public void Autocheck(object sender, EventArgs e) { auto = chbAuto.Checked; AutoGamble(null, null); }
		public void Gamble(object sender, EventArgs e)
		{
			lblWinIndicator.Text = "";
			if (tokens <= 0) Message("No Tokens", null);
			else
			{
				counter++;
				if (tokens == 1 && chbDouble.Checked) chbDouble.Checked = false;
				tokens -= (1 + Convert.ToInt32(chbDouble.Checked));
				Random rnd = new();
				int rnd1 = rnd.Next(1, 4);
				lbl1.Text = $"{rnd1}";
				int rnd2 = rnd.Next(1, 4);
				lbl2.Text = $"{rnd2}";
				int rnd3 = rnd.Next(1, 4);
				lbl3.Text = $"{rnd3}";
				if (rnd1 == 1 && rnd2 == 1 && rnd3 == 1) { change = 5 + (Convert.ToInt32(chbDouble.Checked) * 5); tokens += change; Message($"{change} Token Jackpot!", null); }
				else if (rnd1 == 2 && rnd2 == 2 && rnd3 == 2) { change = 10 + (Convert.ToInt32(chbDouble.Checked) * 10); tokens += change; Message($"{change} Token Jackpot!", null); }
				else if (rnd1 == 3 && rnd2 == 3 && rnd3 == 3) { change = 15 + (Convert.ToInt32(chbDouble.Checked) * 15); tokens += change; Message($"{change} Token Jackpot!", null); }
			}
			lblScore.Text = $"{tokens}";
		}
		public void Message(object sender, EventArgs e)
		{
			lblScore.Text = $"{tokens}";
			lblWinIndicator.Text = $"{sender}";
			int count = change - (counter + (Convert.ToInt32(chbDouble.Checked)) * counter);
			string WonOrLost = count switch { < 0 => "lost", _ => "won" };
			string plural = counter switch { 1 => "", _ => "s" };
			string plural2 = count switch { 1 => "", -1 => "", _ => "s" };
			string message = $"It took {counter} attempt{plural} and you {WonOrLost} {$"{count}".Trim('-')} token{plural2}.\nYou now have {tokens} tokens.";
			if (chbMessage.Checked && sender.ToString() != "No Tokens") MessageBox.Show($"Congratulations {PlayerName}!\nYou have won a {sender}\n\n{message}", "Result");
			else if (chbMessage.Checked) MessageBox.Show($"Sorry {PlayerName}.\nYou have run out of tokens.\n\n{message}", "Result");
			counter = 0;
			auto = false;
			chbAuto.Checked = auto;
		}
	}
}