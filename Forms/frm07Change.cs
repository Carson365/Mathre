using System;
using System.Globalization;
using System.Windows.Forms;

namespace Mathre
{
	public partial class Frm07Change : Form, Forms.IManager
	{
		public static Frm00Mathre BaseForm;
		public Frm07Change()
		{
			InitializeComponent();
			txtPaidAmount.TextChanged += ChangeMaker;
			txtPaidAmount.KeyPress += InputFormatter;
		}
		public void ChangeMaker(object sender, EventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			string[] decimals = txtPaidAmount.Text.Split(DecimalChar.ToCharArray());
			int Bills = 0;
			int Coins = 0;
			if (int.TryParse(decimals[0], out int BillsAmount)) Bills = BillsAmount;
			if (decimals.Length > 1 && int.TryParse(decimals[1], out int CoinsAmount)) Coins = CoinsAmount;
			lblHundredsCount.Text = (Bills / 100).ToString();
			lblFiftiesCount.Text = (Bills % 100 / 50).ToString();
			lblTwentiesCount.Text = (Bills % 100 % 50 / 20).ToString();
			lblTensCount.Text = (Bills % 100 % 50 % 20 / 10).ToString();
			lblFivesCount.Text = (Bills % 100 % 50 % 20 % 10 / 5).ToString();
			lblOnesCount.Text = (Bills % 100 % 50 % 20 % 10 % 5 / 1).ToString();
			lblQuartersCount.Text = (Coins / 25).ToString();
			lblDimesCount.Text = (Coins % 25 / 10).ToString();
			lblNickelsCount.Text = (Coins % 25 % 10 / 5).ToString();
			lblPenniesCount.Text = (Coins % 25 % 10 % 5 / 1).ToString();
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			TextBox textBox = sender as TextBox;
			if (e.KeyChar.ToString() == DecimalChar) { if (textBox.Text.Contains(DecimalChar)) e.Handled = true; }
			else if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')) e.Handled = true;
			string[] decimals = textBox.Text.Split(DecimalChar.ToCharArray());
			if (decimals.Length > 1 && e.KeyChar != '\b' && decimals[1].Length > 1 && textBox.SelectionStart > textBox.Text.IndexOf(DecimalChar)) e.Handled = true;
		}
	}
}