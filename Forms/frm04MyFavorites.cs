// SOURCES:
// Image Resizer: https://transloadit.com/demos/image-manipulation/resize-to-100x100/
// Actor : https://www.nydailynews.com/resizer/CSMoV-0r7NhBWiY4g8hbi8EBWoM=/1200x0/top/cloudfront-us-east-1.images.arcpublishing.com/tronc/J47DUG2ZZVBWTG325QQY3L3DWQ.jpg
// Movie : https://m.media-amazon.com/images/M/MV5BOTgwMzFiMWYtZDhlNS00ODNkLWJiODAtZDVhNzgyNzJhYjQ4L2ltYWdlXkEyXkFqcGdeQXVyNzEzOTYxNTQ@._V1_.jpg
// Fruit : https://www.gardeningknowhow.com/wp-content/uploads/2019/10/stone-fruit-400x267.jpg
// Hobby : https://rccarmarketplace.com/wp-content/uploads/2020/10/arrma-mojave-exb-full-option-roller-p2-720x380.jpg
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm04MyFavorites : Form
	{
		public Frm04MyFavorites()
		{
			InitializeComponent();
			foreach (RadioButton Button in pnlBody.Controls) { Button.CheckedChanged += Favorites; }
		}
		public void Favorites(object sender, EventArgs e)
		{
			if (sender is RadioButton button)
			{
				lblFavoriteInfo.Text = button.Parent.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked)?.Name.ToString() switch
				{
					"radFavoriteActor" => "My favorite actor is Tom Hiddleston. \n He has starred and appeared in several films, but his most famous role is that of Loki in Marvel's MCU.",
					"radFavoriteMovie" => "My favorite movie is The Imitation Game. \n it follows the work and life of Alan Turing, a revolutionary code-breaker and very early computer scientist.",
					"radFavoriteFruit" => "My favorite fruit is any stone fruit. \n The stone fruit family includes raspberries and blackberries, as well as peaches, plums, cherries, and other great fruits.",
					"radFavoriteHobby" => "My favorite hobby is remote control. \n Remote control cars are very fun to drive and work on, and despite their high price they are an easy hobby to get into.",
					"radFavoriteColor" => "My favorite color is purple. \n It can complement a variety of other colors, works well to convey many different ideas or emotions, and it looks good.",
					_ => null,
				};
				if (sender == radFavoriteColor)
				{
					pnlFavoriteImage.BackgroundImage = null;
					pnlFavoriteImage.BackColor = ColorTranslator.FromHtml("#6622cc");
				}
				lblTitle.Text = $"My Favorite {pnlBody.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text}";
				pnlFavoriteImage.BackgroundImage = imgFavoriteImages.Images[$"{pnlBody.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text}.jpg".ToString()];
			}
		}
	}
}