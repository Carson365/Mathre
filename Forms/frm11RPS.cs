// SOURCES:
// RPS Image: https://www.nicepng.com/png/full/111-1113460_rock-paper-scissors-rock-paper-scissors-svg.png (Modified in various ways with paint.net)
using Mathre.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm11RPS : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		private int playerscore = 0;
		private int computerscore = 0;
		private int drawamount = 0;
		private int points = 20;
		private int wager = 0;
		public Frm11RPS()
		{
			InitializeComponent();
			Load += FormLoad;
			radRock.CheckedChanged += RPSSelect;
			radPaper.CheckedChanged += RPSSelect;
			radScissors.CheckedChanged += RPSSelect;
			radRock.Click += RPSGame;
			radPaper.Click += RPSGame;
			radScissors.Click += RPSGame;
			radRock2.CheckedChanged += RPSSelect;
			radPaper2.CheckedChanged += RPSSelect;
			radScissors2.CheckedChanged += RPSSelect;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
			picRPS.Image = imgRPS.Images["RPS.png"];
			picRPS2.Image = imgRPS.Images["RPS.png"];
		}
		public void MenuControl(object sender, EventArgs e)
		{
			Action a = $"{((ToolStripMenuItem)sender).Name}".Substring(0, 3) switch
			{
				"btn" => () => ((Button)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).PerformClick(),
				"rad" => () => ((RadioButton)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).PerformClick(),
				"chb" => () => ((CheckBox)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).Checked ^= true,
				_ => null,
			};
			a?.Invoke();
		}
		public void RPSGame(object sender, EventArgs e)
		{
			wager = (int)numWager.Value;
			Random rnd = new();
			int choice = rnd.Next(0, 3);
			pnlRPSChoice2.Controls.OfType<RadioButton>().ElementAt(choice).Checked = true;
			if ((radRock.Checked && radScissors2.Checked) || (radPaper.Checked && radRock2.Checked) || (radScissors.Checked && radPaper2.Checked))
			{
				playerscore++;
				lblPlayerScore.Text = $"{playerscore}";
				lblTotalGames.Text = $"{computerscore + playerscore + drawamount}";
				points += wager;
				lblScore.Text = points.ToString();
				Message("Win!!", null);
			}
			else if ((radRock2.Checked && radScissors.Checked) || (radPaper2.Checked && radRock.Checked) || (radScissors2.Checked && radPaper.Checked))
			{
				computerscore++;
				lblComputerScore.Text = $"{computerscore}";
				lblTotalGames.Text = $"{computerscore + playerscore + drawamount}";
				points -= wager;
				lblScore.Text = points.ToString();
				Message("Lose.", null);
			}
			else { drawamount++; lblDrawCount.Text = $"{drawamount}"; lblTotalGames.Text = $"{computerscore + playerscore + drawamount}"; Message("Draw!", null); }
		}
		public void RPSSelect(object sender, EventArgs e)
		{
			if (((RadioButton)sender).Checked)
			{
				((RadioButton)sender).Parent.Parent.Controls.OfType<PictureBox>().Single().Image = ((RadioButton)sender).Name switch
				{
					"radRock" => imgRPS.Images["RockPS.png"],
					"radPaper" => imgRPS.Images["RPaperS.png"],
					"radScissors" => imgRPS.Images["RPScissors.png"],
					"radRock2" => imgRPS.Images["RockPS2.png"],
					"radPaper2" => imgRPS.Images["RPaperS2.png"],
					"radScissors2" => imgRPS.Images["RPScissors2.png"],
					_ => throw new NotImplementedException()
				};
			}
		}
		public void Message(object sender, EventArgs e)
		{
			lblWinIndicator.Text = $"{sender}";
			if (chbDisableMessagebox.Checked) { MessageBox.Show($"{sender}", "Result"); }
		}
	}
}