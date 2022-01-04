using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm09Grade : Form
	{
		public static Frm00Mathre BaseForm;
		public static Frm09Grade ThisForm;
		public static int abc = 0;
		public Frm09Grade()
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
			btnMethod5.Click += GradeCalculator;
			btnRandom.Click += GradeCalculator;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			ThisForm = Application.OpenForms.OfType<Frm09Grade>().Single();
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
				if (Points == 0 && Total == 0)
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
					lblPassFail.Text = "Fail. F.";
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
					< 63.50 => "Fail. F.",
					double.NaN => "",
					_ => "",
				};
			}
			if (ReferenceEquals(sender, btnMethod5))
			{
				abc++;
				string result = (double)Math.Round((Points / Total * 100), 2) switch
				{
					> 91.50 => "Pass! A!",
					> 83.50 => "Pass! B!",
					> 73.50 => "Pass! C!",
					> 63.50 => "Pass! D!",
					< 63.50 => "Fail. F.",
					double.NaN => "Error",
					_ => "Error",
				};
				lblGradesEnteredCount.Text = $"{abc}";
				MessageBox.Show(result, "                                        Result                                        ");
			}
			if (ReferenceEquals(sender, btnRandom))
			{
				double score = Math.Round(100 * VBMath.Rnd());
				txtPoints.Text = $"{score}";
				txtTotal.Text = $"{score + Math.Round(11 * VBMath.Rnd())}";
				GradeCalculator(null, null);
			}
		}
		public void ButtonSelector(object sender, EventArgs e)
		{
			Action a = $"{sender}" switch
			{
				"Method 1" => () => ThisForm.btnMethod1.PerformClick(),
				"Method 2" => () => ThisForm.btnMethod2.PerformClick(),
				"Method 3" => () => ThisForm.btnMethod3.PerformClick(),
				"Method 4" => () => ThisForm.btnMethod4.PerformClick(),
				"Method 5" => () => ThisForm.GradeCalculator(ThisForm.btnMethod5, null),
				_ => () => ThisForm.GradeCalculator(ThisForm.btnRandom, null)
			};
			a.Invoke();
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
				e.Handled = true;
			}
			string[] decimals = textBox.Text.Split(DecimalChar.ToCharArray());
			if (decimals.Length > 1 && e.KeyChar != '\b' && decimals[1].Length > 1 && textBox.SelectionStart > textBox.Text.IndexOf(DecimalChar))
			{
				e.Handled = true;
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
			if (Total > 100 && e.KeyChar >= '0' && e.KeyChar <= '9' && decimals.Length == 1)
			{
				e.Handled = true;
			}
			if (textBox.Text.Length == 0 && e.KeyChar == '0')
			{
				e.Handled = true;
			}
		}
	}
}
