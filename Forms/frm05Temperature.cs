using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmTemperature : Form
	{
		public static FrmMathre BaseForm;
		public static FrmTemperature ThisForm;
		public FrmTemperature()
		{
			InitializeComponent();
			Load += FormLoad;
			btnFahrenheit.Click += Temperature;
			btnCelsius.Click += Temperature;
			btnFahrenheit.CheckedChanged += Temperature;
			btnCelsius.CheckedChanged += Temperature;
			txtTemperature.KeyUp += Temperature;
			txtTemperature.KeyPress += NumericalKeypress;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmTemperature>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Temperature(object sender, EventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			if (ReferenceEquals(sender, BaseForm.mnuTemperatureCelsius))
			{
				ThisForm.btnCelsius.Checked = true;
			}
			else if (ReferenceEquals(sender, BaseForm.mnuTemperatureFahrenheit))
			{
				ThisForm.btnFahrenheit.Checked = true;
			}
			if (!btnCelsius.Checked & !btnFahrenheit.Checked)
			{
				btnCelsius.Checked = true;
			}
			double temp = 0;
			var roundamount = 0;
			if (txtTemperature.Text.Contains(DecimalChar))
			{
				if (txtTemperature.Text[ThisForm.txtTemperature.Text.Length - 1].ToString() != DecimalChar)
				{
					string[] words = txtTemperature.Text.Split(DecimalChar.ToCharArray());
					roundamount = words[1].Length;
				}
			}
			else
			{
				roundamount = 0;
			}
			if (double.TryParse(txtTemperature.Text, out var tempcheck))
			{
				temp = tempcheck;
			}
			if (btnFahrenheit.Checked)
			{
				lblCelsiusDisplay.Text = $"{Math.Round((temp - 32) * 5 / 9, roundamount)} °C"; // Set the Celsius value using the proper math and degree of precision
				lblFahrenheitDisplay.Text = $"{Math.Round(temp, roundamount)} °F"; // Set the Fahrenheit value using the proper degree of precision
			}
			else if (btnCelsius.Checked) // ...
			{
				lblCelsiusDisplay.Text = $"{Math.Round(temp, roundamount)} °C";  // Set the Celsius value using the proper degree of precision
				lblFahrenheitDisplay.Text = $"{Math.Round((temp * 9 / 5) + 32, roundamount)} °F"; // Set the Fahrenheit value using the proper math and degree of precision
			}
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
				if (e.KeyChar != '-')
				{
					e.Handled = true; // Discard the character input
				}
				else if (textBox.SelectionStart != 0)
				{
					e.Handled = true;
				}
			}
		}
	}
}
