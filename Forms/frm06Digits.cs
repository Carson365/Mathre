using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmDigits : Form
	{
		public static FrmMathre BaseForm;
		public Dictionary<int, char> newDictionary = new();
		public FrmDigits()
		{
			InitializeComponent();
			Load += FormLoad;
			//txtNumber.KeyUp += Digits;
			txtNumber.TextChanged += New;
			txtNumber.KeyPress += InputFormatter;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			lblDigitsListOdds.Text = "";
			lblDigitsListEvens.Text = "";
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Digits(object sender, KeyEventArgs e)
		{
			lblDigitsCount.Text = txtNumber.Text.Length.ToString();
			lblDigitsListEvens.Text = "";
			lblDigitsListOdds.Text = "";
			for (int i = 0; i < txtNumber.Text.Length; i++)
			{
				char c = txtNumber.Text[i];
				if ((txtNumber.Text.IndexOf(c, i) + 1) % 2 == 0)
				{
					lblDigitsListEvens.Text += $"Digit {i + 1}: {c}\r\n";
				}
				else if ((txtNumber.Text.IndexOf(c, i) + 1) % 2 == 1)
				{
					lblDigitsListOdds.Text += $"Digit {i + 1}: {c}\r\n";
				}
			}
		}
		public void New(object sender, EventArgs e)
		{
			lblDigitsCount.Text = txtNumber.Text.Length.ToString();
			if (txtNumber.Text.Length > newDictionary.Keys.Count)
			{
				newDictionary.Add(txtNumber.Text.Length, txtNumber.Text[txtNumber.Text.Length - 1]);
				lblDigitsListEvens.Text += $"Digit {txtNumber.Text.Length}: {newDictionary[txtNumber.Text.Length]}\r\n";
			}
			else if (txtNumber.Text.Length <= newDictionary.Keys.Count)
			{
				Console.WriteLine(lblDigitsListEvens.Text.Length - 12);
				newDictionary.Remove(txtNumber.Text.Length + 1);
				lblDigitsListEvens.Text = lblDigitsListEvens.Text.Remove(lblDigitsListEvens.Text.Length - 12, 12);
			}
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			if (sender is not TextBoxBase)
				return;
			if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				e.Handled = true;
			}
		}
	}
}
