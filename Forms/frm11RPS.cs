// RPS Image: https://www.nicepng.com/png/full/111-1113460_rock-paper-scissors-rock-paper-scissors-svg.png (Modified in various ways with paint.net)
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmRPS : Form
	{
		private FrmMathre BaseForm;
		private FrmRPS ThisForm;
		private int playerscore = 0;
		private int computerscore = 0;
		private int drawamount = 0;
		// NOTE: Set these to static in order to preserve the values when the form is loaded/unloaded
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
		}
		// \/ \/ \/  Sets the computer choice and tallies the scores for each player input
		public void RPSGame(object sender, EventArgs e)
		{
			Random rnd = new();
			int choice = rnd.Next(0, 3);
			pnlRPSChoice2.Controls.OfType<RadioButton>().ElementAt(choice).Checked = true;
			if ((btnRock.Checked && btnScissors2.Checked) || (btnPaper.Checked && btnRock2.Checked) || (btnScissors.Checked && btnPaper2.Checked))
			{
				playerscore++;
				MessageBox.Show("Win!!", "                                        Result                                        ");
				lblPlayerScore.Text = $"{playerscore}";
			}
			else if ((btnRock2.Checked && btnScissors.Checked) || (btnPaper2.Checked && btnRock.Checked) || (btnScissors2.Checked && btnPaper.Checked))
			{
				computerscore++;
				MessageBox.Show("Lose.", "                                        Result                                        ");
				lblComputerScore.Text = $"{computerscore}";
			}
			else
			{
				drawamount++;
				MessageBox.Show("Draw!", "                                        Result                                        ");
				lblDrawCount.Text = $"{drawamount}";
			}
			lblTotalGames.Text = $"{computerscore + playerscore + drawamount}";
		}
		// \/ \/ \/ Sets the proper image for the selected action, for both the player and the computer.
		public void RPSSelect(object sender, EventArgs e)
		{
			if (((RadioButton)sender).Checked)
			{
				((RadioButton)sender).Parent.Parent.Controls.OfType<PictureBox>().Single().Image = ((RadioButton)sender).Name switch
				{
					"btnRock" => My.Resources.Resources.RockPS,
					"btnPaper" => My.Resources.Resources.RPaperS,
					"btnScissors" => My.Resources.Resources.RPScissors,
					"btnRock2" => My.Resources.Resources.RockPS2,
					"btnPaper2" => My.Resources.Resources.RPaperS2,
					"btnScissors2" => My.Resources.Resources.RPScissors2,
					_ => throw new NotImplementedException()
				};
			}
		}
		// \/ \/ \/ Translates menu actions into button inputs
		public void MenuHandler(object sender, EventArgs e)
		{
			((RadioButton)ThisForm.pnlRPSChoice.Controls[$"btn{sender}"]).PerformClick();
		}
	}
}