using System;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmDigits : Form
	{
		public static FrmMathre BaseForm;
		public OrderedDictionary betterDictionary = new();
		public FrmDigits()
		{
			InitializeComponent();
			Load += FormLoad;
			txtNumber.TextChanged += Digits;
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
		public void Digits(object sender, EventArgs e)
		{
			int.TryParse(lblDigitsCount.Text, out int a);
			if (txtNumber.Text.Length > a)
			{
				var label = (txtNumber.SelectionStart % 2) switch { 0 => lblDigitsListEvens, _ => lblDigitsListOdds };
				if (label.Text.Contains($"Digit {txtNumber.SelectionStart}:"))
				{
					DigitsRedo(null, null);
				}
				else
				{
					label.Text += $"Digit {txtNumber.SelectionStart}: {txtNumber.Text[txtNumber.SelectionStart - 1]}\r\n";
				}
			}
			else
			{
				if (txtNumber.SelectionStart == txtNumber.Text.Length)
				{
					var label = (txtNumber.SelectionStart % 2) switch { 1 => lblDigitsListEvens, _ => lblDigitsListOdds };
					label.Text = label.Text.Remove(label.Text.Length - 13);
				}
				else
				{
					DigitsRedo(null, null);
				}
			}
			lblDigitsCount.Text = $"{txtNumber.Text.Length}";
		}
		public void DigitsRedo(object sender, KeyEventArgs e)
		{
			lblDigitsListEvens.Text = "";
			lblDigitsListOdds.Text = "";
			for (int i = 0; i < txtNumber.Text.Length; i++)
			{
				char c = txtNumber.Text[i];
				var label = ((txtNumber.Text.IndexOf(c, i) + 1) % 2) switch { 0 => lblDigitsListEvens, _ => lblDigitsListOdds };
				label.Text += $"Digit {i + 1}: {c}\r\n";
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
