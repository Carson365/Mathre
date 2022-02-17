using System;
using System.Globalization;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm05Temperature : Form, Forms.IManager
	{
		public Frm05Temperature()
		{
			InitializeComponent();
			radFahrenheit.Click += Temperature;
			radCelsius.Click += Temperature;
			radFahrenheit.CheckedChanged += Temperature;
			radCelsius.CheckedChanged += Temperature;
			txtTemperature.TextChanged += Temperature;
			txtTemperature.KeyPress += InputFormatter;
		}
		public void Temperature(object sender, EventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			if ($"{sender}" == "Celsius") radCelsius.Checked = true;
			else if ($"{sender}" == "Fahrenheit") radFahrenheit.Checked = true;
			if (!radCelsius.Checked & !radFahrenheit.Checked) radCelsius.Checked = true;
			double temp = 0;
			int roundamount;
			if (txtTemperature.Text.Contains(DecimalChar) && txtTemperature.Text[txtTemperature.Text.Length - 1].ToString() != DecimalChar)
			{
				string[] words = txtTemperature.Text.Split(DecimalChar.ToCharArray());
				roundamount = words[1].Length;
			}
			else { roundamount = 2; }
			if (double.TryParse(txtTemperature.Text, out var tempcheck)) temp = tempcheck;
			if (radFahrenheit.Checked)
			{
				lblCelsiusDisplay.Text = $"{Math.Round((temp - 32) * 5 / 9, roundamount)} °C";
				lblFahrenheitDisplay.Text = $"{Math.Round(temp, roundamount)} °F";
			}
			else if (radCelsius.Checked)
			{
				lblCelsiusDisplay.Text = $"{Math.Round(temp, roundamount)} °C";
				lblFahrenheitDisplay.Text = $"{Math.Round((temp * 9 / 5) + 32, roundamount)} °F";
			}
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			TextBox textBox = sender as TextBox;
			if (e.KeyChar.ToString() == DecimalChar && textBox.Text.Contains(DecimalChar)) e.Handled = true;
			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				if (e.KeyChar != '-') e.Handled = true;
				else if (textBox.SelectionStart != 0) e.Handled = true;
			}
		}
	}
}
