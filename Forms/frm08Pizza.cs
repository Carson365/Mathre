// Images for the Pizza page were sourced from the below links:
// Small: https://preview.redd.it/rkt6dt3nf1841.jpg?auto=webp&s=28216c881e0906e1c893cd7e0bc8290b25151e3c
// Medium : https://image.mlive.com/home/mlive-media/width2048/img/food_impact/photo/hungry-howies-pizza-21b1ef848c80e115.jpg
// Large: https://cloudfront-us-east-1.images.arcpublishing.com/gmg/BCUKGOJJYRABVPC7IK3422PWBE.jpg
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmPizza : Form
	{
		public static FrmMathre BaseForm;
		public static FrmPizza ThisForm;
		public FrmPizza()
		{
			InitializeComponent();
			Load += FormLoad;
			txtPizzaSize.KeyUp += Pizza;
			txtPizzaTip.KeyUp += Pizza;
			btnDelivery.CheckedChanged += Pizza;
			btnTakeout.CheckedChanged += Pizza;
			btnPercent.CheckedChanged += Pizza;
			btnDollars.CheckedChanged += Pizza;
			txtPizzaTip.KeyPress += InputFormatter;
			txtPizzaSize.KeyPress += InputFormatter;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmPizza>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Pizza(object sender, EventArgs e)
		{
			Action a = $"{sender}" switch
			{
				"Delivery" => () => ThisForm.btnDelivery.PerformClick(),
				"Takeout" => () => ThisForm.btnTakeout.PerformClick(),
				"Dollars" => () => ThisForm.btnDollars.PerformClick(),
				"Percent" => () => ThisForm.btnPercent.PerformClick(),
				_ => () => { }
				,
			};
			a.Invoke();
			if (!btnDelivery.Checked & !btnTakeout.Checked)
			{
				btnDelivery.Checked = true;
			}
			if (!btnDollars.Checked & !btnPercent.Checked)
			{
				btnPercent.Checked = true;
			}
			int Size = 0;
			decimal Tip = 0;
			if (int.TryParse(txtPizzaSize.Text, out int SizeText))
			{
				Size = SizeText;
			}
			if (decimal.TryParse(txtPizzaTip.Text, out decimal TipText))
			{
				Tip = TipText;
			}
			decimal Cost = (decimal)(0.75 + 1 + 0.05 * (Size * Size) + (Convert.ToInt32(btnDelivery.Checked) * 1.5));
			if (Size != 0)
			{
				lblPizzaCostAmount.Text = $"${Math.Round(Cost + (Tip * Convert.ToInt32(btnDollars.Checked)) + (Convert.ToInt32(btnPercent.Checked) * ((Tip / 100) * Cost)), 2) }".ToString();
			}
			if (Size == 0)
			{
				lblPizzaCostAmount.Text = "Not Enough Information";
			}
			pnlPizzaViewer.BackgroundImage = Size switch
			{
				0 => null,
				> 13 => imgFavoriteImages.Images["LargePizza.png".ToString()],
				< 12 => imgFavoriteImages.Images["SmallPizza.png".ToString()],
				_ => imgFavoriteImages.Images["MediumPizza.png".ToString()],
			};
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			if (sender is not TextBoxBase textBox)
				return;
			if (e.KeyChar.ToString() == DecimalChar)
			{
				if (ReferenceEquals(sender, txtPizzaTip))
				{
					if (textBox.Text.Contains(DecimalChar))
					{
						e.Handled = true;
					}
				}
				else
				{
					e.Handled = true;
				}
			}
			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				e.Handled = true;
			}
			if (sender == txtPizzaTip)
			{
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
			}
		}
	}
}
