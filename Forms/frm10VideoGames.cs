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
	}
}
