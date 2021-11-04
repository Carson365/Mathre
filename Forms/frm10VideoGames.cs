// SOURCES:
// Stardew / PS4 : https://m.media-amazon.com/images/I/81VgMy0mHYL._SL100_.jpg
// Stardew / XB1 : https://m.media-amazon.com/images/I/81ELSb3bhGL._SL100_.jpg
// Minecraft / PS4 : https://m.media-amazon.com/images/I/71AKO+U6F6L._SL100_.jpg
// Minecraft / XB1 : https://m.media-amazon.com/images/I/71QpSBZtkqL._SL100_.jpg
// Doom / PS4 : https://m.media-amazon.com/images/I/91uV7r7aAhL._SL100_.jpg
// Doom / XB1 : https://m.media-amazon.com/images/I/61bF5-QAX+L._SL100_.jpg
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmVideoGames : Form
	{
		public static FrmMathre BaseForm;
		public static FrmVideoGames ThisForm;
		public FrmVideoGames()
		{
			InitializeComponent();
			Load += FormLoad;
			btnPS4.Click += ImageSetter;
			btnXB1.Click += ImageSetter;
			txtDoom.TextChanged += Cost;
			txtStardew.TextChanged += Cost;
			txtMinecraft.TextChanged += Cost;
			txtDoom.KeyPress += InputFormatter;
			txtStardew.KeyPress += InputFormatter;
			txtMinecraft.KeyPress += InputFormatter;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmVideoGames>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
			ImageSetter(null, null);
			lblCost.Text = "";
			lblCostText.Text = "";
		}
		public void Transfer(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, BaseForm.mnuXB1))
			{
				ThisForm.btnXB1.Checked = true;
			}
			else if (ReferenceEquals(sender, BaseForm.mnuPS4))
			{
				ThisForm.btnPS4.Checked = true;
			}
			ThisForm.ImageSetter(null, null);
		}
		public void ImageSetter(object sender, EventArgs e)
		{
			
			if (btnPS4.Checked)
			{
				pnlDoom.BackgroundImage = imgGames.Images["Doom-PS4.jpg"];
				pnlMinecraft.BackgroundImage = imgGames.Images["Minecraft-PS4.jpg"];
				pnlStardew.BackgroundImage = imgGames.Images["Stardew-PS4.jpg"];
			}
			else
			{
				pnlDoom.BackgroundImage = imgGames.Images["Doom-XB1.jpg"];
				pnlMinecraft.BackgroundImage = imgGames.Images["Minecraft-XB1.jpg"];
				pnlStardew.BackgroundImage = imgGames.Images["Stardew-XB1.jpg"];
			}
		}
		public void Cost(object sender, EventArgs e)
		{
			int Doom = int.Parse(txtDoom.Text);
			int Stardew = int.Parse(txtStardew.Text);
			int Minecraft = int.Parse(txtMinecraft.Text);
			if (txtDoom.Text != "" | txtStardew.Text != "" | txtMinecraft.Text != "")
			{
				int A = (Doom+Minecraft+Stardew);
				string B = A switch { not 1 => "s", _ => "" };
				int C = (A / 3);
				string D = C switch { not 1 => "es", _ => "" };
				double E = (A % 3);
				string F = (A % 3) switch { not 1 => "s", _ => "" };
				lblCostText.Text = $"Order {A} Game{B} :\n Tax @ 6.75% :\n {C} box{D} :\n {E} Envelope{F} :\n Total :";
				double A2 = (Convert.ToDouble(A) * 59.99);
				double B2 = A2 * 0.0675;
				double C2 = C;
				double D2 = E * 0.5;
				double E2 = A2 + B2 + C2 + D2;
				lblCost.Text = $" {A2:C}\n {B2:C}\n {C2:C}\n {D2:C}\n {E2:C}";
			}
			else
			{
				lblCostText.Text = "";
				lblCost.Text = "";
			}
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			if (sender is not TextBoxBase textBox)
				return;
			if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				e.Handled = true;
			}
			if (textBox.Text.Length == 3 && e.KeyChar != '\b')
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
