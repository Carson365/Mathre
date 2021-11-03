
//
// SOURCES:
//
// Stardew / PS4 : https://m.media-amazon.com/images/I/81VgMy0mHYL._SL100_.jpg
// Stardew / XB1 : https://m.media-amazon.com/images/I/81ELSb3bhGL._SL100_.jpg
// Minecraft / PS4 : https://m.media-amazon.com/images/I/71AKO+U6F6L._SL100_.jpg
// Minecraft / XB1 : https://m.media-amazon.com/images/I/71QpSBZtkqL._SL100_.jpg
// Doom / PS4 : https://m.media-amazon.com/images/I/91uV7r7aAhL._SL100_.jpg
// Doom / XB1 : https://m.media-amazon.com/images/I/61bF5-QAX+L._SL100_.jpg
//
//
//
using System;
using System.Drawing;
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
			btnPS4.Click += Cost;
			btnXB1.Click += Cost;
			txtDoom.TextChanged += Cost;
			txtStardew.TextChanged += Cost;
			txtMinecraft.TextChanged += Cost;
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
			int Doom = 0;
			if (int.TryParse(txtDoom.Text, out int DoomCount))
			{
				Doom = DoomCount;
			}
			int Stardew = 0;
			if (int.TryParse(txtStardew.Text, out int StardewCount))
			{
				Stardew = StardewCount;
			}
			int Minecraft = 0;
			if (int.TryParse(txtMinecraft.Text, out int MinecraftCount))
			{
				Minecraft = MinecraftCount;
			}
			if (txtDoom.Text != "" | txtStardew.Text != "" | txtMinecraft.Text != "")
			{
				int A = (Doom+Minecraft+Stardew);
				string B = A switch { not 1 => "s", _ => "" };
				int C = (A / 3);
				string D = C switch { not 1 => "es", _ => "" };
				double E = (A % 3);
				string F = (A % 3) switch { not 1 => "s", _ => "" };
				lblCostText.Text = $"Order {A} Game{B} :  $\n Tax @ 6.75% :  $\n {C} box{D} :  $\n {E} Envelope{F} :  $\n Total :  $";
				double A2 = Convert.ToDouble(A) * 59.99;
				double B2 = A2 * 0.0675;
				double C2 = C;
				double D2 = E * 0.5;
				double E2 = A2 + B2 + C2 + D2;
				string A3 = (A2.ToString().Split('.'))[1].Length switch { 0 => "00", 1 => "0", _ => "" };
				string B3 = (B2.ToString().Split('.'))[1].Length switch { 0 => "00", 1 => "0", _ => "" };
				string D3 = (D2.ToString().Split('.'))[1].Length switch { 0 => "00", 1 => "0", _ => "" };
				string E3 = (E2.ToString().Split('.'))[1].Length switch { 0 => "00", 1 => "0", _ => "" };
				lblCost.Text = $" {Math.Round(A2,2)}{A3}\n {Math.Round(B2, 2)}{B3}\n {Math.Round(C2, 2)}.00\n {Math.Round(D2, 2)}{D3}\n {Math.Round(E2, 2)}{E3}";
			}
			else
			{
				lblCostText.Text = "";
			}
		}
	}
}
