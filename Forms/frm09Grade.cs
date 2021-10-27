using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmGrade : Form
	{
		public static FrmMathre BaseForm;
		public static FrmGrade ThisForm;
		public FrmGrade()
		{
			InitializeComponent();
			Load += FormLoad;
			txtPoints.KeyUp += GradeCalculator;
			txtTotal.KeyUp += GradeCalculator;
			txtPoints.KeyPress += InputFormatter;
			txtTotal.KeyPress += InputFormatter;
			btnMethod1.Click += GradeCalculator;
			btnMethod2.Click += GradeCalculator;
			btnMethod3.Click += GradeCalculator;
			btnMethod4.Click += GradeCalculator;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmGrade>().Single();
			lblScoreDisplay.Text = "";
			lblPassFail.Text = "";
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void GradeCalculator(object sender, EventArgs e)
		{
			if (!(btnMethod1.Checked | btnMethod2.Checked | btnMethod3.Checked | btnMethod4.Checked))
			{
				btnMethod1.Checked = true;
			}
			double Points = 0;
			double Total = 0;
			if (double.TryParse(txtPoints.Text, out double PointsValue))
			{
				Points = PointsValue;
			}
			if (double.TryParse(txtTotal.Text, out double TotalValue))
			{
				Total = TotalValue;
			}
			lblScoreDisplay.Text = $"{Math.Round((Points / Total * 100), 2)} Percent";

			if (btnMethod1.Checked)
			{
				if (Math.Round((Points / Total * 100), 2) > 63.50)
				{
					lblPassFail.Text = "Pass!";
				}
				if (Math.Round((Points / Total * 100), 2) < 63.50)
				{
					lblPassFail.Text = "";
				}
			}

			if (btnMethod2.Checked)
			{
				if (Math.Round((Points / Total * 100), 2) > 63.50)
				{
					lblPassFail.Text = "Pass!";
				}
				else
				{
					lblPassFail.Text = "Fail. Study More.";
				}
			}

			if (btnMethod3.Checked)
			{
				if (Math.Round((Points / Total * 100), 2) > 91.50)
				{
					lblPassFail.Text = "Pass! A!";
				}
				else if (Math.Round((Points / Total * 100), 2) > 83.50)
				{
					lblPassFail.Text = "Pass! B!";
				}
				else if (Math.Round((Points / Total * 100), 2) > 73.50)
				{
					lblPassFail.Text = "Pass! C!";
				}
				else if (Math.Round((Points / Total * 100), 2) > 63.50)
				{
					lblPassFail.Text = "Pass! D!";
				}
				else
				{
					lblPassFail.Text = "Fail. Study More.";
				}
			}

			if (btnMethod4.Checked)
			{
				lblPassFail.Text = (double)Math.Round((Points / Total * 100), 2) switch
				{
					> 91.50 => "Pass! A!",
					> 83.50 => "Pass! B!",
					> 73.50 => "Pass! C!",
					> 63.50 => "Pass! D!",
					< 63.50 => "Fail. Study More.",
					double.NaN => "",
					_ => "",
				};
			}
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			if (sender is not TextBoxBase textBox)
				return;
			if (e.KeyChar.ToString() == DecimalChar)
			{
				if (textBox.Text.Contains(DecimalChar))
				{
					e.Handled = true;
				}
			}
			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				e.Handled = true;
			}
			string[] decimals = textBox.Text.Split(DecimalChar.ToCharArray());
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
			double Old = 0;
			double New = 0;
			double Total = 0;
			if (double.TryParse(textBox.Text, out double OldValue))
			{
				Old = OldValue;
			}
			if (double.TryParse(e.KeyChar.ToString(), out double NewValue))
			{
				New = NewValue;
			}
			if (double.TryParse($"{Old}{New}", out double TotalValue))
			{
				Total = TotalValue;
			}
			if (Total > 100)
			{
				if ((e.KeyChar >= '0' && e.KeyChar <= '9'))
				{
					if (decimals.Length == 1)
					{
						e.Handled = true;
					}

				}
				Console.WriteLine(decimals.Length);
			}
			if (textBox.Text.Length == 0 && e.KeyChar == '0')
			{
				e.Handled = true;
			}
		}
	}
}