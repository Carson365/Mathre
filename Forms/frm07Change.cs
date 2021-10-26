using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmChange : Form
	{
		public static FrmMathre main;
		public static FrmChange CM;
		public FrmChange()
		{
			InitializeComponent();
			Load += FormLoad;
			txtPaidAmount.KeyUp += ChangeMaker;
			txtPaidAmount.KeyPress += NumericalKeypress;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			CM = Application.OpenForms.OfType<FrmChange>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
		public void ChangeMaker(object sender, EventArgs e) // Event Handler for keypresses in the Digits text box (pre-filtered to be only in the proper format)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			string[] decimals = txtPaidAmount.Text.Split(DecimalChar.ToCharArray()); // Split the input using the spaces as separators
			int Bills = 0;
			int Coins = 0;
			if (int.TryParse(decimals[0], out int BillsAmount)) // Check whether the first substring is a number
			{
				Bills = BillsAmount; // Assign the width value to the first substring if numeric
			}
			if (decimals.Length > 1) // Ensure there is more than one substring
			{
				if (int.TryParse(decimals[1], out int CoinsAmount)) // Check whether the second substring is a number
				{
					Coins = CoinsAmount; // Assign the width value to the first substring if numeric
				}
			}
			lblHundredsCount.Text = (Bills / 100).ToString(); // Integer division to determine how many whole 100s the dollar value can be divided by
			lblFiftiesCount.Text = (Bills % 100 / 50).ToString(); // Use mod division to determine the remainder after checking for hundreds, then integer division to see how many whole 50s the number can be divided by
			lblTwentiesCount.Text = (Bills % 100 % 50 / 20).ToString(); // ...
			lblTensCount.Text = (Bills % 100 % 50 % 20 / 10).ToString(); // ...
			lblFivesCount.Text = (Bills % 100 % 50 % 20 % 10 / 5).ToString(); // ...
			lblOnesCount.Text = (Bills % 100 % 50 % 20 % 10 % 5 / 1).ToString(); // ...
			lblQuartersCount.Text = (Coins / 25).ToString(); // Perform the same process for the coins
			lblDimesCount.Text = (Coins % 25 / 10).ToString(); // ...
			lblNickelsCount.Text = (Coins % 25 % 10 / 5).ToString(); // ...
			lblPenniesCount.Text = (Coins % 25 % 10 % 5 / 1).ToString(); // ...
		}
		public void NumericalKeypress(object sender, KeyPressEventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			if (sender is not TextBoxBase textBox) // Ensure the sender is the input form -
				return; // -or else discard it
			if (e.KeyChar.ToString() == DecimalChar) // If the pressed key is the user's decimal separator
			{
				if (textBox.Text.Contains(DecimalChar)) // If there are not multiple number groups and there is already a decimal separator
				{
					e.Handled = true; // Discard the decimal separator input
				}
			}
			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))) // If a non-backspace, non-number character is pressed
			{
				e.Handled = true;
			}
			string[] decimals = textBox.Text.Split(DecimalChar.ToCharArray()); // Split the input using the spaces as separators
			if (decimals.Length > 1 && e.KeyChar != '\b')
			{
				if (decimals[1].Length > 1)
				{
					if (textBox.SelectionStart > textBox.Text.IndexOf(DecimalChar))
					{
						e.Handled = true;
					}
				}
			}
		}
	}
}
