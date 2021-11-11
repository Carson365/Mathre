// SOURCES:
// Images for the My Favorites page were sourced from the below links and then run through the following resizer: https://transloadit.com/demos/image-manipulation/resize-to-100x100/
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
	public partial class FrmMyFavorites : Form
	{
		public static FrmMathre BaseForm;
		public static FrmMyFavorites ThisForm;
		public FrmMyFavorites()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmMyFavorites>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
			foreach (RadioButton Button in pnlFavoriteControls.Controls)
			{
				Button.CheckedChanged += Favorites;
			}
		}
		public void Favorites(object sender, EventArgs e)
		{
			if (sender.GetType().ToString().Contains("Menu"))
			{
				RadioButton b = (RadioButton)ThisForm.pnlFavoriteControls.Controls[$"btnFavorite{sender}"];
				b.Checked = true;
			}
			if (sender is RadioButton button)
			{
				ThisForm.lblFavoriteInfo.Text = button.Parent.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked)?.Name.ToString() switch
				{
					"btnFavoriteActor" => "My favorite actor is Tom Hiddleston. \n He has starred and appeared in several films, but his most famous role is that of Loki in Marvel's MCU.",
					"btnFavoriteMovie" => "My favorite movie is The Imitation Game. \n it follows the work and life of Alan Turing, a revolutionary code-breaker and very early computer scientist.",
					"btnFavoriteFruit" => "My favorite fruit is any stone fruit. \n The stone fruit family includes raspberries and blackberries, as well as peaches, plums, cherries, and other great fruits.",
					"btnFavoriteHobby" => "My favorite hobby is remote control. \n Remote control cars are very fun to drive and work on, and despite their high price they are an easy hobby to get into.",
					"btnFavoriteColor" => "My favorite color is purple. \n It can complement a variety of other colors, works well to convey many different ideas or emotions, and it looks good.",
					_ => throw new NotImplementedException(),
				};
				if (ReferenceEquals(sender, btnFavoriteColor))
				{
					ThisForm.pnlFavoriteImage.BackgroundImage = null;
					ThisForm.pnlFavoriteImage.BackColor = ColorTranslator.FromHtml("#6622cc");
				}
				lblFavoriteTitle.Text = $"My Favorite {pnlFavoriteControls.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text}";
				pnlFavoriteImage.BackgroundImage = BaseForm.imgFavoriteImages.Images[$"{ThisForm.pnlFavoriteControls.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text}.jpg".ToString()];
			}
		}
	}
}
