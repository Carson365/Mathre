using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmMyFavorites : Form
	{
		public static FrmMathre main;
		public static FrmMyFavorites MF;
		public FrmMyFavorites()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			MF = Application.OpenForms.OfType<FrmMyFavorites>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
			foreach (RadioButton Button in pnlFavoriteControls.Controls)
			{
				Button.Click += Favorites;
			}
		}
		public void Favorites(object sender, EventArgs e) // Event Handler for a button press
		{
			// The below five eventhandlers all handle the buttons on the My Favorites page. They each set their respective radio button to appear checked, set the title text, the info label text, and then the image
			if (sender.GetType().ToString().Contains("Menu"))
			{
				RadioButton b = (RadioButton)MF.pnlFavoriteControls.Controls[$"btnFavorite{sender}"];
				b.Checked = true;
			}
			if (ReferenceEquals(sender, btnFavoriteActor) | ReferenceEquals(sender, main.mnuFavoriteActor))
			{
				MF.lblFavoriteInfo.Text = "My favorite actor is Tom Hiddleston. \n He has starred and appeared in several films, but his most famous role is that of Loki in Marvel's MCU.";
			}
			else if (ReferenceEquals(sender, btnFavoriteMovie) | ReferenceEquals(sender, main.mnuFavoriteMovie))
			{
				MF.lblFavoriteInfo.Text = "My favorite movie is The Imitation Game. \n it follows the work and life of Alan Turing, a revolutionary code-breaker and very early computer scientist.";
			}
			else if (ReferenceEquals(sender, btnFavoriteFruit) | ReferenceEquals(sender, main.mnuFavoriteFruit))
			{
				MF.lblFavoriteInfo.Text = "My favorite fruit is any stone fruit. \n The stone fruit family includes raspberries and blackberries, as well as peaches, plums, cherries, and other great fruits.";
			}
			else if (ReferenceEquals(sender, btnFavoriteHobby) | ReferenceEquals(sender, main.mnuFavoriteHobby))
			{
				MF.lblFavoriteInfo.Text = "My favorite hobby is remote control. \n Remote control cars are very fun to drive and work on, and despite their high price they are an easy hobby to get into.";
			}
			else if (ReferenceEquals(sender, btnFavoriteColor) | ReferenceEquals(sender, main.mnuFavoriteColor))
			{
				MF.lblFavoriteInfo.Text = "My favorite color is purple. \n It can complement a variety of other colors, works well to convey many different ideas or emotions, and it looks good.";
				MF.pnlFavoriteImage.BackgroundImage = null;
				MF.pnlFavoriteImage.BackColor = ColorTranslator.FromHtml("#6622cc");
			}
			lblFavoriteTitle.Text = $"My Favorite {pnlFavoriteControls.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text}";
			pnlFavoriteImage.BackgroundImage = main.imgFavoriteImages.Images[$"{MF.pnlFavoriteControls.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text}.jpg".ToString()];
		}
	}
}
