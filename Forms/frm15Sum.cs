using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmSum : Form
	{
		public static FrmMathre BaseForm;
		public static FrmSum ThisForm;
		public static int counter;
		public static int countercount;
		public FrmSum()
		{
			InitializeComponent();
			Load += FormLoad;
			txtStart.TextChanged += Digits;
			txtEnd.TextChanged += Digits;
			txtStart.KeyPress += InputFormatter;
			txtEnd.KeyPress += InputFormatter;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmSum>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Digits(object sender, EventArgs e)
		{
			lblCalculation.Text = "";
			int.TryParse(txtStart.Text, out int a);
			int.TryParse(txtEnd.Text, out int b);
			if (a <= b)
			{
				counter = a;
				countercount = 0;
				while (counter <= b)
				{
					lblCalculation.Text += $"{counter} + ";
					counter++;
					countercount++;
				}
				if (counter > b)
				{
					int value = a;
					for (int i = countercount; i >= 0; i--)
					{
						value += i;
					}
					lblCalculation.Text += $"= {value-1}";
				}
			}
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			if (sender is not TextBoxBase)
				return;
			if ((e.KeyChar != '\b' && e.KeyChar != '-' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				e.Handled = true;
			}
			if (((TextBoxBase)sender).Text.Length > 3)
			{
				e.Handled = true;
			}
		}
	}
}
