using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmPizza : Form
	{
		public static FrmMathre main;
		public static FrmPizza PD;
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
			txtPizzaTip.KeyPress += NumericalKeypress;
			txtPizzaSize.KeyPress += NumericalKeypress;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			PD = Application.OpenForms.OfType<FrmPizza>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
		public void Pizza(object sender, EventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			if (ReferenceEquals(sender, main.mnuPizzaDelivery)) //Set the buttons' appearances based on their checked state
			{
				PD.btnDelivery.Checked = true; // ...
			}
			else if (ReferenceEquals(sender, main.mnuPizzaTakeout)) // ...
			{
				PD.btnTakeout.Checked = true; // ...
			}
			if (!btnDelivery.Checked & !btnTakeout.Checked) // ...
			{
				btnDelivery.Checked = true; // ...
			}
			if (ReferenceEquals(sender, main.mnuPizzaDollars)) // ...
			{
				PD.btnDollars.Checked = true; // ...
			}
			else if (ReferenceEquals(sender, main.mnuPizzaPercent)) // ...
			{
				PD.btnPercent.Checked = true; // ...
			}
			if (!btnDollars.Checked & !btnPercent.Checked) // ...
			{
				btnPercent.Checked = true; // ...
			}
			int Size = 0;
			double Tip = 0;
			if (int.TryParse(txtPizzaSize.Text, out int SizeText)) // Ensure the value is numeric
			{
				Size = SizeText;
			}
			if (double.TryParse(txtPizzaTip.Text, out double TipText)) // Ensure the value is numeric
			{
				Tip = TipText;
			}
			double Cost = 0.75 + 1 + 0.05 * (Size * Size) + (Convert.ToInt32(btnDelivery.Checked) * 1.5); // Do math to get the proper price for a pizza before a tip
			if (Size != 0)
			{
				lblPizzaCostAmount.Text = $"${Math.Round(Cost + (Tip * Convert.ToInt32(btnDollars.Checked)) + (Convert.ToInt32(btnPercent.Checked) * ((Tip / 100) * Cost)), 2) }".ToString(); // Add a tip in dollars or percent based on the selected option and ensure it is rounded to the nearest penny
			}
			if (Size == 0)
			{
				pnlPizzaViewer.BackgroundImage = null; // hide the image if no size is given
				lblPizzaCostAmount.Text = "Not Enough Information";
			}
			else if (Size < 12) // set the proper image for the given size
			{
				pnlPizzaViewer.BackgroundImage = main.imgFavoriteImages.Images["SmallPizza.png".ToString()]; // ...
			}
			else if (Size > 13)
			{
				pnlPizzaViewer.BackgroundImage = main.imgFavoriteImages.Images["LargePizza.png".ToString()]; // ...
			}
			else if (Size is not 0)
			{
				pnlPizzaViewer.BackgroundImage = main.imgFavoriteImages.Images["MediumPizza.png".ToString()]; // ...
			}
		}
		public void NumericalKeypress(object sender, KeyPressEventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			if (sender is not TextBoxBase textBox) // Ensure the sender is the input form -
				return; // -or else discard it
			if (e.KeyChar.ToString() == DecimalChar) // If the pressed key is the user's decimal separator
			{
				if (ReferenceEquals(sender, txtPizzaTip))
				{
					if (textBox.Text.Contains(DecimalChar)) // If there are not multiple number groups and there is already a decimal separator
					{
						e.Handled = true; // Discard the decimal separator input
					}
				}
				else
				{
					e.Handled = true;
				}
			}
			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))) // If a non-backspace, non-number character is pressed
			{
				e.Handled = true;
			}
			if (sender == txtPizzaTip)
			{
				string[] decimals = textBox.Text.Split(DecimalChar.ToCharArray()); // Split the input using the spaces as separators
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
