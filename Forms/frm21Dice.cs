using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm21Dice : Form
	{
		readonly Random rnd = new();
		readonly System.Timers.Timer aTimer = new(275);
		int[] Dice = { 0, 0, 0, 0, 0 };
		MyNUD numW = new();
		bool buttonsent = false;
		public Frm21Dice()
		{
			InitializeComponent();
			Shown += Default;
			Load += Game;
			btnRoll.Click += Wage;
			aTimer.Elapsed += Game;
		}
		// Custom NumericUpDown for Fib Sequence
		class MyNUD : NumericUpDown
		{
			public override void UpButton() { int n = (int)Math.Round((double)Value * ((1 + Math.Sqrt(5)) / 2.0)); if (n < Maximum) Value = n; else Value = Maximum; if (Value == 0) Value = 1; }
			public override void DownButton() { int n = (int)Math.Round((double)Value / ((1 + Math.Sqrt(5)) / 2.0)); if (n >= Minimum) Value = n; if (Value == 0) Value = 1; }
		}
		public void Game(object sender, EventArgs e)
		{
			// Since this is run on a timer, we need to store the initial sender
			if (sender is Button button && button.Name == "btnRoll") buttonsent = true;
			var loopfour = 1;
			while (loopfour < 3 && aTimer.Interval < 300)
			{
				// Generates a random number for each die
				int num = rnd.Next(1, 7);
				((Panel)Controls.Find($"pnlDie{loopfour}", true)[0]).BackgroundImage = imgDice.Images[$"die{num}.gif".ToString()];
				// Store the die value in a global array
				Dice[loopfour] = num;
				loopfour++;
			}
			aTimer.Enabled = false;
			//Slow down the timer over time
			if (aTimer.Interval < 300) { aTimer.Enabled = true; aTimer.Interval += 25; }
			else if (buttonsent)
			{
				buttonsent = false;
				//Calculate and apply the new score, set the new maximum score
				Invoke(new Action(() => { lblScore.Text = $"{Convert.ToInt32(lblScore.Text) + (int)numW.Value * 3 * (Dice.Sum() % 2) - (int)numW.Value}"; numW.Maximum = Convert.ToInt32(lblScore.Text); }));
			}
		}
		// Set up the overriden NumericUpDown
		public void Default(object sender, EventArgs e)
		{
			numW.Size = numWager.Size;
			numW.Location = numWager.Location;
			numW.Value = 1;
			numW.Minimum = 0;
			numW.Maximum = 1000;
			numW.KeyPress += InputFormatter;
			TextBox txt = (TextBox)numW.Controls[1];
			numW.KeyUp += (p, e) => { if (txt.Text == "") numW.Value = 1; else txt.Text = $"{numW.Value}"; };
			numW.TextChanged += (s, e) => { if (numW.Text.StartsWith("0")) numW.Text = numW.Text.TrimStart('0'); };
			pnlWager.Controls.Add(numW);
			numWager.Hide();
			numW.Show();
		}
		// Ensure all user input is formatted correctly. (the zero management and text replacement was tough to do in a way that feels natural)
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			NumericUpDown box = sender as NumericUpDown;
			TextBox txt = (TextBox)numW.Controls[1];
			if (e.KeyChar != '\b' && (e.KeyChar < '0' | e.KeyChar > '9')) e.Handled = true;
			else if (e.KeyChar != '\b' && Convert.ToInt32(box.Text.Remove(txt.SelectionStart, txt.SelectionLength).Insert(((TextBox)numW.Controls[1]).SelectionStart, $"{e.KeyChar}")) > numW.Maximum ) e.Handled = true;
			box.Validate(true);
		}
		// The actual roll action
		public void Wage(object sender, EventArgs e)
		{
			if (((TextBox)numW.Controls[1]).Text == "") numW.Text = "1";
			aTimer.Interval = 150;
			Game(sender, null);
		}
	}
}