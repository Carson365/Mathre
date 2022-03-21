using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm21Dice : Form
	{
		readonly Random rnd = new();
		readonly System.Timers.Timer aTimer = new(2000);
		public Frm21Dice()
		{
			InitializeComponent();
			Shown += Default;
			Load += FormLoad;
			aTimer.Elapsed += FormLoad;
		}
		class MyNUD : NumericUpDown
		{
			public override void UpButton() { int n = (int)Math.Round((double)Value * ((1 + Math.Sqrt(5)) / 2.0)); if (n < Maximum) Value = n; if (Value == 0) Value = 1; }
			public override void DownButton() { int n = (int)Math.Round((double)Value / ((1 + Math.Sqrt(5)) / 2.0)); if (n >= Minimum) Value = n; if (Value == 0) Value = 1; }
		}
		public void FormLoad(object sender, EventArgs e)
		{
			aTimer.Enabled = true;
			var loopfour = 1;
			while (loopfour < 6)
			{
				int num = rnd.Next(1, 7);
				((Panel)Controls.Find($"pnlDie{loopfour}", true)[0]).BackgroundImage = imgDice.Images[$"die{num}.gif".ToString()];
				loopfour++;
			}
		}
		public void Default(object sender, EventArgs e)
		{
			MyNUD num = new();
			num.Size = numWager.Size;
			num.Location = numWager.Location;
			num.Value = 1;
			num.Minimum = 0;
			num.Maximum = 1000;
			num.KeyPress += InputFormatter;
			TextBox txt = (TextBox)num.Controls[1];
			num.KeyUp += (p,e) => { if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) if (txt.Text == "") num.Value = 0; else txt.Text = $"{num.Value}"; };
			num.KeyDown += (p,e) => { if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) if (txt.Text == "") num.Value = 0; };
			pnlWager.Controls.Add(num);
			numWager.Hide();
			num.Show();
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
		}
	}
}