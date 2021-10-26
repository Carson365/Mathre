using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmDigits : Form
	{
		public static FrmMathre BaseForm;
		public static FrmDigits ThisForm;
		public FrmDigits()
		{
			InitializeComponent();
			Load += FormLoad;
			txtNumber.KeyUp += Digits;
			txtNumber.KeyPress += NumericalKeypress;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			lblDigitsListOdds.Text = "";
			lblDigitsListEvens.Text = "";
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmDigits>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Digits(object sender, KeyEventArgs e) // Event Handler for keypresses in the Digits text box (pre-filtered to be only in the proper format)
		{
			lblDigitsCount.Text = txtNumber.Text.Length.ToString(); // Set the length based on the string length
			lblDigitsListEvens.Text = ""; // Clear the Even Number List (happens each keypress)
			lblDigitsListOdds.Text = ""; // Clear the Odd Number List (happens each keypress)
			for (int i = 0; i < txtNumber.Text.Length; i++) // Run the following code for each character in the text box, and note the index of the character.
			{
				char c = txtNumber.Text[i];
				if ((txtNumber.Text.IndexOf(c, i) + 1) % 2 == 0) // Check if the number is even
				{
					lblDigitsListEvens.Text += $"Digit {i + 1}: {c}\r\n"; // Add it to the even list in the proper format
				}
				else if ((txtNumber.Text.IndexOf(c, i) + 1) % 2 == 1) // Check if the number is even
				{
					lblDigitsListOdds.Text += $"Digit {i + 1}: {c}\r\n"; // Add it to the odd list in the proper format
				}
			}
		}
		public void NumericalKeypress(object sender, KeyPressEventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			if (sender is not TextBoxBase) // Ensure the sender is the input form -
				return; // -or else discard it
			if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))) // If a non-backspace, non-number character is pressed
			{
				e.Handled = true;
			}
		}
	}
}
