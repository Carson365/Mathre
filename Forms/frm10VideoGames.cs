//
// SOURCES:
//
// Stardew / PS4 : https://m.media-amazon.com/images/I/81VgMy0mHYL._SL1500_.jpg / http://www.simpleimageresizer.com/_uploads/photos/b409afe6/81VgMy0mHYL._SL1500__x100.jpg
// Stardew / XB1 : https://m.media-amazon.com/images/I/81ELSb3bhGL._SL1500_.jpg / http://www.simpleimageresizer.com/_uploads/photos/b409afe6/81ELSb3bhGL._SL1500__x100.jpg
// Minecraft / PS4 : https://media.gamestop.com/i/gamestop/11098604/Minecraft-Starter-Collection---PlayStation-4 / http://www.simpleimageresizer.com/_uploads/photos/b409afe6/Minecraft-Starter-Collection---PlayStation-4_x100.jpg
// Minecraft / XB1 : https://m.media-amazon.com/images/I/71QpSBZtkqL._SL1106_.jpg / http://www.simpleimageresizer.com/_uploads/photos/b409afe6/71QpSBZtkqL._SL1106__x100.jpg
// Doom / PS4 : https://m.media-amazon.com/images/I/91uV7r7aAhL._SX385_.jpg / http://www.simpleimageresizer.com/_uploads/photos/b409afe6/91uV7r7aAhL._SX385__x100.jpg
// Doom / XB1 : https://media.gamestop.com/i/gamestop/10123072/DOOM / http://www.simpleimageresizer.com/_uploads/photos/b409afe6/DOOM_x100.jpg
//
//
//
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
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmVideoGames>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
	}
}
