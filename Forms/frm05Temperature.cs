using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm05Temperature : Form
	{
		public static Frm00Mathre BaseForm;
		public Frm05Temperature()
		{
			InitializeComponent();
			Load += FormLoad;
			btnFahrenheit.Click += Temperature;
			btnCelsius.Click += Temperature;
			btnFahrenheit.CheckedChanged += Temperature;
			btnCelsius.CheckedChanged += Temperature;
			txtTemperature.KeyUp += Temperature;
			txtTemperature.KeyPress += InputFormatter;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e) { var ThisForm = Application.OpenForms.OfType<Frm05Temperature>().Single(); ThisForm.Temperature(sender, e); }
		public void Temperature(object sender, EventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			if (ReferenceEquals(sender, BaseForm.mnuTemperatureCelsius))
			{
				btnCelsius.Checked = true;
			}
			else if (ReferenceEquals(sender, BaseForm.mnuTemperatureFahrenheit))
			{
				btnFahrenheit.Checked = true;
			}
			if (!btnCelsius.Checked & !btnFahrenheit.Checked)
			{
				btnCelsius.Checked = true;
			}
			double temp = 0;
			int roundamount;
			if (txtTemperature.Text.Contains(DecimalChar) && txtTemperature.Text[txtTemperature.Text.Length - 1].ToString() != DecimalChar)
			{
				string[] words = txtTemperature.Text.Split(DecimalChar.ToCharArray());
				roundamount = words[1].Length;
			}
			else
			{
				roundamount = 2;
			}
			if (double.TryParse(txtTemperature.Text, out var tempcheck))
			{
				temp = tempcheck;
			}
			if (btnFahrenheit.Checked)
			{
				lblCelsiusDisplay.Text = $"{Math.Round((temp - 32) * 5 / 9, roundamount)} °C";
				lblFahrenheitDisplay.Text = $"{Math.Round(temp, roundamount)} °F";
			}
			else if (btnCelsius.Checked)
			{
				lblCelsiusDisplay.Text = $"{Math.Round(temp, roundamount)} °C";
				lblFahrenheitDisplay.Text = $"{Math.Round((temp * 9 / 5) + 32, roundamount)} °F";
			}
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			if (sender is not TextBoxBase textBox)
				return;
			if (e.KeyChar.ToString() == DecimalChar && textBox.Text.Contains(DecimalChar))
			{
				e.Handled = true;
			}
			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				if (e.KeyChar != '-')
				{
					e.Handled = true;
				}
				else if (textBox.SelectionStart != 0)
				{
					e.Handled = true;
				}
			}
		}
	}
}
