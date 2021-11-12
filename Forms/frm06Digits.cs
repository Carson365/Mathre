using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmDigits : Form
	{
		private FrmMathre BaseForm;
		public FrmDigits()
		{
			InitializeComponent();
			Load += FormLoad;
			txtNumber.KeyUp += Digits;
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
