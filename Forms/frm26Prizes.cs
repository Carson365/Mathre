using System;
using System.Drawing;
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
						Size = new Size(42, 42),
						Location = new Point(11 + 49 * x, 11 + 49 * y),
						BackColor = Color.LightGray
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
			Contain.Location = new Point((pnlBody.Width - Contain.Width) / 2, (pnlBody.Height - Contain.Height) / 2);
			pnlBody.Controls.Add(Contain);
			Generate();
		}
		private void Generate()
		{
			// Two random X values
			int rndX1 = rnd.Next(ButtonsX);
			int rndX2 = rnd.Next(ButtonsX);
			// Two random Y values
			int rndY1 = rnd.Next(ButtonsY);
			int rndY2 = rnd.Next(ButtonsY);
			// Ensure there's no overlap
			while (rndY2 == rndY1 && rndX2 == rndX1) { rndX2 = rnd.Next(ButtonsX); rndY2 = rnd.Next(ButtonsY); }
			// Set the button tag for the click event
			Buttons[rndX1, rndY1].Tag = "1";
			Buttons[rndX2, rndY2].Tag = "2";
		}
		private void Play(object sender, EventArgs e)
		{
			// Reset the variables
			guesses = 0;
			b1 = false;
			b2 = false;
			// Regenerate Grid
			foreach (Button b in Buttons) Contain.Controls.Remove(b);
			Controls.Remove(Contain);
			ButtonsX = Convert.ToInt16(nudX.Value);
			ButtonsY = Convert.ToInt16(nudY.Value);
			Setup();
			Contain.Invalidate(); // Fix visual bugs
		}
		private async void Guess(object sender, EventArgs e)
		{
			if (sender is Button b && b.Text == "") // Ensure each button is only pressed once
			{
				if ($"{b.Tag}" == "1") { b.Text = "Comp"; b1 = true; b.BackColor = Color.PaleGreen; }
				else if ($"{b.Tag}" == "2") { b.Text = "uter"; b2 = true; b.BackColor = Color.PaleGreen; }
				else b.Text = "X";
				guesses++;
				if (guesses == 5 || b1 && b2) // end the game after 5 guesses or two correct
				{
					string un = (b1 && b2) switch { false => "un", _ => "" };
					string winlose = (b1 && b2) switch { false => "lose.", _ => "win a computer!" };
					foreach (Button btn in Buttons) // Show where the correct guesses were
					{
						btn.Enabled = false;
						if ($"{btn.Tag}" == "1" && btn.Text == "") { btn.Text = "Comp"; btn.BackColor = Color.LightCoral; }
						else if ($"{btn.Tag}" == "2" && btn.Text == "") { btn.Text = "uter"; btn.BackColor = Color.LightCoral; }
					}
					btnPlay.Enabled = false; // Ensure the animation isn't skipped
					foreach (Button btn in SpiralMatrix(Buttons)) // Show the win/lose animation
					{
						// Change the color if it has none, or if it is green and you have lost.
						if (btn.BackColor == Color.White || !((b1 && b2) ? btn.BackColor == Color.PaleGreen : btn.BackColor == Color.LightCoral)) btn.BackColor = (b1 && b2) switch
						{
							true => HSVToRGB(1F / rnd.Next(2, 6), 1F / 3, 1),
							_ => HSVToRGB(Convert.ToSingle(1 / (20 / Convert.ToDouble(rnd.Next(18, 21)))), 1F / 2, 1)
						};
						await System.Threading.Tasks.Task.Delay(100);
					}
					btnPlay.Enabled = true;
					MessageBox.Show($"You {winlose}\nYou were {un}able to find both word fragments.");
					Play(null, null); // Comment this line out to restart the game manually
				}
			}
		}
		// https://stackoverflow.com/a/12774782 Flatten a 2D Array into a spiral matrix (modified)
		private Button[] SpiralMatrix(Button[,] arr)
		{
			Button[] temp;
			int entries = 0;
			int rows = arr.GetLength(0);
			int cols = arr.GetLength(1);
			temp = new Button[rows * cols];
			int top = 0, bottom = rows - 1, left = 0, right = cols - 1;
			int dir = rnd.Next(1, 5);
			while (top <= bottom && left <= right)
			{
				if (dir == 1) { for (int i = left; i <= right; ++i) { temp[entries] = arr[top, i]; entries++; } ++top; dir = 2; } // Left -> Right
				else if (dir == 2) { for (int i = top; i <= bottom; ++i) { temp[entries] = arr[i, right]; entries++; } --right; dir = 3; } // Top -> Bottom
				else if (dir == 3) { for (int i = right; i >= left; --i) { temp[entries] = arr[bottom, i]; entries++; } --bottom; dir = 4; } // Right -> Left
				else if (dir == 4) { for (int i = bottom; i >= top; --i) { temp[entries] = arr[i, left]; entries++; } ++left; dir = 1; } // Bottom -> Top
			}
			return temp;
		}
		// https://stackoverflow.com/a/70996160 Convert HSV to RGB
		private Color HSVToRGB(float h, float s, float v)
		{
			Func<float, int> f = delegate (float n)
			{
				float k = (n + h * 6) % 6;
				return (int)((v - (v * s * (Math.Max(0, Math.Min(Math.Min(k, 4 - k), 1))))) * 255);
			};
			return Color.FromArgb(f(5), f(3), f(1));
		}
	}
}
