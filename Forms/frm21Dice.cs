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
		public Frm21Dice()
		{
			InitializeComponent();
			Shown += Default;
			Load += Game;
			btnRoll.Click += Wage;
			aTimer.Elapsed += Game;
		}
		class MyNUD : NumericUpDown
		{
			public override void UpButton() { int n = (int)Math.Round((double)Value * ((1 + Math.Sqrt(5)) / 2.0)); if (n < Maximum) Value = n; if (Value == 0) Value = 1; }
			public override void DownButton() { int n = (int)Math.Round((double)Value / ((1 + Math.Sqrt(5)) / 2.0)); if (n >= Minimum) Value = n; if (Value == 0) Value = 1; }
		}
		public void Game(object sender, EventArgs e)
		{
			var loopfour = 1;
			while (loopfour < 3 && aTimer.Interval < 300)
			{
				int num = rnd.Next(1, 7);
				((Panel)Controls.Find($"pnlDie{loopfour}", true)[0]).BackgroundImage = imgDice.Images[$"die{num}.gif".ToString()];
				Dice[loopfour] = num;
				loopfour++;
			}
			aTimer.Enabled = false;
			if (aTimer.Interval < 300)
			{
				aTimer.Enabled = true;
				aTimer.Interval += 25;
			}
			else Invoke(new Action(() => { lblScore.Text = $"{Convert.ToInt32(lblScore.Text) + (int)numW.Value * 3 * (Dice.Sum() % 2) - (int)numW.Value}"; }));
		}
		public void Default(object sender, EventArgs e)
		{
			numW.Size = numWager.Size;
			numW.Location = numWager.Location;
			numW.Value = 1;
			numW.Minimum = 0;
			numW.Maximum = 1000;
			numW.KeyPress += InputFormatter;
			TextBox txt = (TextBox)numW.Controls[1];
			numW.KeyUp += (p, e) => { if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) if (txt.Text == "") numW.Value = 0; else txt.Text = $"{numW.Value}"; };
			numW.KeyDown += (p, e) => { if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) if (txt.Text == "") numW.Value = 0; };
			pnlWager.Controls.Add(numW);
			numWager.Hide();
			numW.Show();
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			NumericUpDown box = sender as NumericUpDown;
			if (e.KeyChar != '\b' && e.KeyChar != '-' && (e.KeyChar < '0' | e.KeyChar > '9')) e.Handled = true;
			else if (box.Text.Length > 2 && e.KeyChar != '\b') e.Handled = true;
			box.Validate(true);
		}
		public void Wage(object sender, EventArgs e)
		{
			aTimer.Interval = 150;
			Game(null, null);
		}
	}
}