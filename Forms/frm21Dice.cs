using System;
using System.ComponentModel;
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
			public override void UpButton() { int n = (int)Math.Round((double)Value * ((1 + Math.Sqrt(5)) / 2.0)); if (n < Maximum) Value = n; if (Value == 0) Value = 1; }
			public override void DownButton() { int n = (int)Math.Round((double)Value / ((1 + Math.Sqrt(5)) / 2.0)); if (n >= Minimum) Value = n; if (Value == 0) Value = 1; }
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
			num.KeyUp += (p,e) => { if (txt.Text == "") num.Value = 0; else txt.Text = $"{num.Value}"; };
			num.TextChanged += (s, e) => { if (num.Text.StartsWith("0")) num.Text = num.Text.TrimStart('0'); };
			pnlWager.Controls.Add(num);
			numWager.Hide();
			num.Show();
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			NumericUpDown box = sender as NumericUpDown;
			if (e.KeyChar != '\b' && (e.KeyChar < '0' | e.KeyChar > '9')) e.Handled = true;
			else if (box.Text.Length > 2 && e.KeyChar != '\b') e.Handled = true;
			box.Validate(true);
		}
		public void Wage(object sender, EventArgs e)
		{
		}
	}
}