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
		public static int total;
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
				total = 0;
				while (counter <= b)
				{
					lblCalculation.Text += $"{counter} + ";
					total += counter;
					counter++;
					countercount++;
				}
				if (counter > b)
				{
					if (lblCalculation.Text.Length > 0)
					{
						lblCalculation.Text = lblCalculation.Text.Remove(lblCalculation.Text.Length - 2, 2);
					}
					lblCalculation.Text += $"\n= {total}";
				}
			}
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			if (sender is TextBoxBase)
			{
				if ((e.KeyChar != '\b' && e.KeyChar != '-' && (e.KeyChar < '0' | e.KeyChar > '9')))
				{
					e.Handled = true;
				}
				else if (((TextBoxBase)sender).Text.Length > 2 && e.KeyChar != '\b')
				{
					e.Handled = true;
				}
			}
		}
	}
}
