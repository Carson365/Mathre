using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm26Prizes : Form
	{
		Button[,] Buttons;
		Panel Contain = new();
		int ButtonsX = 5;
		int ButtonsY = 5;
		int guesses = 0;
		bool b1 = false;
		bool b2 = false;
		readonly Random rnd = new();
		public Frm26Prizes()
		{
			InitializeComponent();
			HandleCreated += (p, e) => { Setup(); foreach (Button b in Buttons) b.Enabled = false; };
			btnPlay.Click += Play;
			Contain.Tag = "Transparent";
		}
		private void Setup()
		{
			Buttons = new Button[ButtonsX, ButtonsY];
			for (int y = 0; y < Buttons.GetLength(1); y++) // Iterate for Y values
			{
				for (int x = 0; x < Buttons.GetLength(0); x++) // Iterate for X values
				{
					// Configure the button
					Button b = new()
					{
						Size = new System.Drawing.Size(42, 42),
						Location = new System.Drawing.Point(11 + 49 * x, 11 + 49 * y),
					};
					b.Click += Guess;
					b.Enabled = true;
					// Add it to the form and the tracking array
					Contain.Controls.Add(b);
					Buttons[x, y] = b;
				}
			}
			// Set the container size and location, then add it to the form
			Contain.Width = Buttons[ButtonsX - 1, ButtonsY - 1].Right + 11;
			Contain.Height = Buttons[ButtonsX - 1, ButtonsY - 1].Bottom + 11;
			Contain.Location = new System.Drawing.Point((pnlBody.Width - Contain.Width) / 2, (pnlBody.Height - Contain.Height) / 2);
			pnlBody.Controls.Add(Contain);
			Generate();
		}
		private void Generate()
		{
			// Two different random X values
			int rndX1 = rnd.Next(ButtonsX);
			int rndX2 = rnd.Next(ButtonsX);
			while (rndX2 == rndX1) rndX2 = rnd.Next(ButtonsX);
			// Two different random Y values
			int rndY1 = rnd.Next(ButtonsY);
			int rndY2 = rnd.Next(ButtonsY);
			while (rndY2 == rndY1) rndY2 = rnd.Next(ButtonsY);
			// Set the button tag for the click event
			Buttons[rndX1, rndY1].Tag = "1";
			Buttons[rndX2, rndY2].Tag = "2";
		}
		private void Play(object sender, EventArgs e)
		{
			// Regenerate Grid 
			foreach (Button b in Buttons) Contain.Controls.Remove(b);
			Controls.Remove(Contain);
			ButtonsX = Convert.ToInt16(nudX.Value);
			ButtonsY = Convert.ToInt16(nudY.Value);
			Setup();
			Contain.Invalidate(); // Fix visual bugs
		}
		private void Guess(object sender, EventArgs e)
		{
			if (sender is Button b && b.Text == "") // Ensure each button is only pressed once
			{
				if ($"{b.Tag}" == "1") { b.Text = "Comp"; b1 = true; b.BackColor = System.Drawing.Color.PaleGreen; }
				else if ($"{b.Tag}" == "2") { b.Text = "uter"; b2 = true; b.BackColor = System.Drawing.Color.PaleGreen; }
				else b.Text = "X";
				guesses++;
				if (guesses == 5 || b1 && b2) // end the game after 5 guesses or two correct
				{
					string un = (b1 && b2) switch { false => "un", _ => "" };
					string winlose = (b1 && b2) switch { false => "Lose.", _ => "Win!" };
					foreach (Button btn in Buttons) // Show where the correct guesses were
					{
						btn.Enabled = false;
						if ($"{btn.Tag}" == "1" && btn.Text == "") { btn.Text = "Comp"; btn.BackColor = System.Drawing.Color.LightCoral; }
						else if ($"{btn.Tag}" == "2" && btn.Text == "") { btn.Text = "uter"; btn.BackColor = System.Drawing.Color.LightCoral; }
					}
					guesses = 0;
					b1 = false;
					b2 = false;
					MessageBox.Show($"You {winlose}\nYou were {un}able to find both word fragments.");
					Play(null, null); // Comment this line out to restart the game manually
				}
			}
		}
	}
}
