using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm21Dice : Form
	{
		public Frm21Dice()
		{
			InitializeComponent();
			Shown += Default;
		}
		class MyNUD : NumericUpDown
		{
			public override void UpButton() { int n = (int)Math.Round((double)Value * ((1 + Math.Sqrt(5)) / 2.0)); if (n < Maximum) Value = n; }
			public override void DownButton() { int n = (int)Math.Round((double)Value / ((1 + Math.Sqrt(5)) / 2.0)); if (n >= Minimum) Value = n; }
		}
		public void Default(object sender, EventArgs e)
		{
			MyNUD numer = new();
			numer.Size = numWager.Size;
			numer.Location = numWager.Location;
			numer.Value = 1;
			numer.Minimum = 1;
			numer.Maximum = 1000;
			numer.KeyPress += InputFormatter;
			pnlWager.Controls.Add(numer);
			numWager.Hide();
			numer.Show();
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