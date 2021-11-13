// RPS Image: https://www.nicepng.com/png/full/111-1113460_rock-paper-scissors-rock-paper-scissors-svg.png (Modified in various ways with paint.net)
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmRPS : Form
	{
		public static FrmMathre BaseForm;
		public static FrmRPS ThisForm;
		private int playerscore = 0;
		private int computerscore = 0;
		private int drawamount = 0;
		private int points = 20;
		private int wager = 0;
		public FrmRPS()
		{
			InitializeComponent();
			Load += FormLoad;
			btnRock.CheckedChanged += RPSSelect;
			btnPaper.CheckedChanged += RPSSelect;
			btnScissors.CheckedChanged += RPSSelect;
			btnRock.Click += RPSGame;
			btnPaper.Click += RPSGame;
			btnScissors.Click += RPSGame;
			btnRock2.CheckedChanged += RPSSelect;
			btnPaper2.CheckedChanged += RPSSelect;
			btnScissors2.CheckedChanged += RPSSelect;
		}
		// /\ /\ /\ Introduction of global variables and event handlers
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmRPS>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
			picRPS.Image = imgRPS.Images["RPS.png"];
			picRPS2.Image = imgRPS.Images["RPS.png"];
		}
		// \/ \/ \/  Sets the computer choice and tallies the scores for each player input
		public void RPSGame(object sender, EventArgs e)
		{
			wager = (int)numWager.Value;
			Random rnd = new();
			int choice = rnd.Next(0, 3);
			pnlRPSChoice2.Controls.OfType<RadioButton>().ElementAt(choice).Checked = true;
			if ((btnRock.Checked && btnScissors2.Checked) || (btnPaper.Checked && btnRock2.Checked) || (btnScissors.Checked && btnPaper2.Checked))
			{
				playerscore++;
				lblPlayerScore.Text = $"{playerscore}";
				lblTotalGames.Text = $"{computerscore + playerscore + drawamount}";
				points += wager; //Accumulator
				lblScore.Text = points.ToString();
				Message("Win!!", null); // Subprocedure
			}
			else if ((btnRock2.Checked && btnScissors.Checked) || (btnPaper2.Checked && btnRock.Checked) || (btnScissors2.Checked && btnPaper.Checked))
			{
				computerscore++;
				lblComputerScore.Text = $"{computerscore}";
				lblTotalGames.Text = $"{computerscore + playerscore + drawamount}";
				points -= wager; //Accumulator
				lblScore.Text = points.ToString();
				Message("Lose.", null); // Subprocedure
			}
			else
			{
				drawamount++;
				lblDrawCount.Text = $"{drawamount}";
				lblTotalGames.Text = $"{computerscore + playerscore + drawamount}";
				Message("Draw!", null); // Subprocedure
			}
		}
		// \/ \/ \/ Sets the proper image for the selected action, for both the player and the computer.
		public void RPSSelect(object sender, EventArgs e)
		{
			if (((RadioButton)sender).Checked)
			{
				((RadioButton)sender).Parent.Parent.Controls.OfType<PictureBox>().Single().Image = ((RadioButton)sender).Name switch
				{
					"btnRock" => imgRPS.Images["RockPS.png"],
					"btnPaper" => imgRPS.Images["RPaperS.png"],
					"btnScissors" => imgRPS.Images["RPScissors.png"],
					"btnRock2" => imgRPS.Images["RockPS2.png"],
					"btnPaper2" => imgRPS.Images["RPaperS2.png"],
					"btnScissors2" => imgRPS.Images["RPScissors2.png"],
					_ => throw new NotImplementedException()
				};
			}
		}
		// \/ \/ \/ Translates menu actions into button inputs
		public void MenuHandler(object sender, EventArgs e)
		{
			((RadioButton)ThisForm.pnlRPSChoice.Controls[$"btn{sender}"]).PerformClick();
		}
		// \/ \/ \/ Display the messagebox if desired
		public void Message(object sender, EventArgs e)
		{
			lblWinIndicator.Text = $"{sender}";
			if (chbDisableMessagebox.Checked) // Checkbox
			{
				MessageBox.Show($"{sender}", "                                        Result                                        ");
			}
		}
	}
}
