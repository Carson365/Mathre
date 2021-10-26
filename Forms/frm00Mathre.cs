// Sources:
//
// Flag icons are sourced from the free icon set at https://www.iconfinder.com/iconsets/flags-37
// RoughRiders mascot image sourced from https://www.gfschools.org/cms/lib/ND02203034/Centricity/Template/GlobalAssets/images///logos/Red%20River%20HS.png
// Enter icon sourced from https://icons8.com/icon/62334/enter-mac-key
//
// Images for the My Favorites page were sourced from the below links and then run through the following resizer: https://transloadit.com/demos/image-manipulation/resize-to-100x100/
//
// Actor : https://www.nydailynews.com/resizer/CSMoV-0r7NhBWiY4g8hbi8EBWoM=/1200x0/top/cloudfront-us-east-1.images.arcpublishing.com/tronc/J47DUG2ZZVBWTG325QQY3L3DWQ.jpg
// Movie : https://m.media-amazon.com/images/M/MV5BOTgwMzFiMWYtZDhlNS00ODNkLWJiODAtZDVhNzgyNzJhYjQ4L2ltYWdlXkEyXkFqcGdeQXVyNzEzOTYxNTQ@._V1_.jpg
// Fruit : https://www.gardeningknowhow.com/wp-content/uploads/2019/10/stone-fruit-400x267.jpg
// Hobby : https://rccarmarketplace.com/wp-content/uploads/2020/10/arrma-mojave-exb-full-option-roller-p2-720x380.jpg
// 
// Images for the Pizza page were sourced from the below links:
// Small: https://preview.redd.it/rkt6dt3nf1841.jpg?auto=webp&s=28216c881e0906e1c893cd7e0bc8290b25151e3c
// Medium : https://image.mlive.com/home/mlive-media/width2048/img/food_impact/photo/hungry-howies-pizza-21b1ef848c80e115.jpg
// Large: https://cloudfront-us-east-1.images.arcpublishing.com/gmg/BCUKGOJJYRABVPC7IK3422PWBE.jpg
//
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{

	public partial class FrmMathre : Form
	{
		public static string StartingValue; // Define a global variable to store the starting value of the lblHelloWorld Label
		public static string AccentColor; // Define a global variable to store the starting value of the System Accent Color
		public static Color SystemColor; // Define a global color to store the converted value of the System Accent Color
		public static bool hidden; // Define a global variable to acknowledge whether the Secret Settings page is hidden
		public object Placeholder; // Define a global object to use to send blank events between event handlers
		public static Rectangle Rect; // Define a global rectangle to use for measurements
		public static string DecimalChar;
		public static Size FormSize;
		public static FrmMathre main;
		public static FrmSecret SS;
		public static FrmHelloWorld HW;
		public static FrmMySchool MS;
		public static FrmRectangle RC;
		public static FrmMyFavorites MF;
		public static FrmTemperature TC;
		public static FrmDigits DS;
		public static FrmChange CM;
		public static FrmPizza PD;
		public FrmMathre()
		{
			InitializeComponent();
			FrmSecret SS = new();
			FrmHelloWorld HW = new();
			FrmMySchool MS = new();
			FrmRectangle RC = new();
			FrmMyFavorites MF = new();
			FrmTemperature TC = new();
			FrmDigits DS = new();
			FrmChange CM = new();
			FrmPizza PD = new();
			// The following are all event handlers. They assign the event (left) to its handler (right)
			Load += FormLoad;
			KeyDown += KeyboardShortcuts;
			mnuExit.Click += Exit;
			mnuMySchoolToggleMascot.Click += MS.MySchool;
			mnuHelloWorldReset.Click += HW.HelloWorld;
			mnuHelloWorldLanguageGerman.Click += HW.HelloWorld;
			mnuHelloWorldLanguageFrench.Click += HW.HelloWorld;
			mnuHelloWorldLanguageEnglish.Click += HW.HelloWorld;
			mnuRandomify.Click += HW.HelloWorld;
			mnuPizzaDelivery.Click += PD.Pizza;
			mnuPizzaTakeout.Click += PD.Pizza;
			mnuPizzaPercent.Click += PD.Pizza;
			mnuPizzaDollars.Click += PD.Pizza;
			mnuTemperatureFahrenheit.Click += TC.Temperature;
			mnuTemperatureCelsius.Click += TC.Temperature;
			Shown += FormShown;
			Resize += Resized;
			tabMathre.SelectedIndexChanged += FormManager;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			lblDigitsListOdds.Text = "";
			lblDigitsListEvens.Text = "";
			tabMathre.TabPages.Remove(tabSecret); // Hide the secret settings tab
			hidden = true; // Mark the secret settings hidden variable as true
			mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable()); // Use the custom color table to color the menu items, rather than using the default one
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM"); // Navigate to this windows directory key
			AccentColor = Conversions.ToString(ColorKey.GetValue("AccentColor")); // Set the systemcolor variable to the value of the AccentColor field within the windows directory key
			ColorKey.Close(); // Stop registry access
			KeyPreview = true; // Ensure key inputs on the form are being tracked
			StartingValue = pnlHelloWorld.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name; // Store the default checked radio button in grpHelloWorld
			SystemColor = ColorTranslator.FromWin32(Conversions.ToInteger(AccentColor)); // Translate the system accent color to a usable format
			MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, 500);
			foreach (var ToolStripMenuItem in mnuBaseLayer.Items) // Recursion point
			{
				AddMenuItemHandlers((ToolStripMenuItem)ToolStripMenuItem); // Call on the next function to run
			} // Begin recursion
			foreach (ToolStripItem FavoriteItem in mnuFavorites.DropDownItems)
			{
				FrmMyFavorites MF = new();
				FavoriteItem.Click += MF.Favorites;
			}
			foreach (Control c in Controls)
			{
				GetAllControls(this);
			}
		}
		public void GetAllControls(Control container)
		{
			foreach (Control b in container.Controls)
			{
				GetAllControls(b);
				if ((b is Panel) && (b is not TabPage))
				{
					b.Paint += PaintPanel;
				}
			}
		}
		public void FormShown(object sender, EventArgs e)
		{
			foreach (TabPage c in tabMathre.TabPages)
			{
				ToolStripMenuItem item = new();
				item.Name = c.Name.ToString().Replace("tab", "mnuView");
				item.Text = c.Text.ToString();
				item.Click += new EventHandler(PageSelect);
				mnuView.DropDownItems.Add(item);
			}
			FormManager(null, null);
		}
		public void FormManager(object sender, EventArgs e)
		{
			var type = Type.GetType("Mathre." + tabMathre.SelectedTab.Name.Replace("tab", "Frm"));
			if (type != null)
			{
				var form = Activator.CreateInstance(type) as Form;
				form.Size = FormSize;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Left = 0;
				form.Top = 45;
				form.TopLevel = false;
				form.Visible = true;
				this.Controls.Add(form);
				form.Focus();
				Resized(null, null);
			}
			for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
			{
				if (Application.OpenForms[i].Name != "FrmMathre" && Application.OpenForms[i].Name != tabMathre.SelectedTab.Name.Replace("tab", "Frm"))
				{
					Application.OpenForms[i].Close();
				}
			}
		}
		public void Exit(object sender, EventArgs e)
		{
			Close();
		}
		public void AddMenuItemHandlers(ToolStripMenuItem ToolStripMenuItem) // ToolStripMenuItem.DropDown.Keydown doesn't work unless you add an alias (ToolStripMenuItem) for ToolStripMenuItem
		{
			foreach (var ToolStripItem in ToolStripMenuItem.DropDownItems) // Recursion point
			{
				if (ToolStripItem is ToolStripMenuItem ToolstripItem) // For the menu items that don't have key input tracking -
				{
					ToolStripMenuItem.DropDown.KeyDown += KeyboardShortcuts; // - add a function to track key inputs (under the name of the main form's, for simplicity)
					AddMenuItemHandlers(ToolstripItem); // Call back to the above sub to repeat this code on the next menu item
				}
			} // Begin recursion
		}
		public void KeyboardShortcuts(object sender, KeyEventArgs e) // Event handler for keypresses made within the form (which now includes keypresses from the menu items)
		{
			if (e.Control & e.KeyCode == Keys.S) // Add Control+S shortcut
			{
				if (hidden == true) // Ensure the secret settings tab is hidden
				{
					tabMathre.Controls.Add(tabSecret); // Unhide the secret settings tab
					MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 2).Right + tabMathre.GetTabRect(tabMathre.TabCount - 1).Width + 17, 500);
					tabMathre.SelectedTab = tabSecret; // Select the secret settings tab
					hidden = false; // Mark the secret settings tab as shown
				}
				else if (hidden == false)  // Ensure the secret settings tab is not hidden
				{
					tabMathre.Controls.Remove(tabSecret); // Hide the secret settings tab
					hidden = true; // Mark the secret settings tab as hidden
				}
				MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, 500);
			}
			//
			if (e.Control & e.KeyCode == Keys.R & mnuSecret.Enabled) // Add Control+R shortcut, dependent on the secret menu being enabled
			{
				HW.HelloWorld(mnuRandomify, null); // Use shortcut to quickly run the randomize function
			}
			// 
			if (e.Control & e.Shift & e.KeyCode == Keys.R) // Add Control+Shift+R shortcut
			{
				HW.HelloWorld(mnuHelloWorldReset, null); // Use shortcut to reset the lblHelloWorld to its stored value by pressing the reset button
			}
			//
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode >= Keys.D1 & e.KeyCode <= Keys.D9)) // Add Control+Number shortcut for each tab page, and no more than the amout of pages
			{
				tabMathre.SelectedTab = tabMathre.TabPages[e.KeyCode - Keys.D1]; // Navigate to the tab of the key pressed by converting the key value to a number and then subtracting 1 to adjust for the indexing starting at 0
			}
		}
		public void PageSelect(object sender, EventArgs e)
		{
			tabMathre.SelectTab((sender as ToolStripMenuItem).Name.ToString().Replace("mnuView", "tab"));
		}
		public class MenuColorTable : ProfessionalColorTable // Custom Color table for theming
		{
			public override Color MenuItemBorder // Override the MenuItemBorder Color
			{
				get
				{
					return SystemColor; // Use the stored system accent color to replace the default color
				}
			}
			public override Color MenuItemSelected // Override the MenuItemSelected Color
			{
				get
				{
					return SystemColor; // Use the stored system accent color to replace the default color
				}
			}
			public override Color MenuBorder // Override the MenuBorder Color
			{
				get
				{
					return SystemColor; // Use the stored system accent color to replace the default color
				}
			}
		}
		public void PaintPanel(object sender, PaintEventArgs p)
		{
			Panel box = (Panel)sender;
			Color BorderColor = ColorTranslator.FromWin32(Conversions.ToInteger(AccentColor));
			if ((string)box.Tag == "Black")
			{
				BorderColor = Color.Black;
			}
			if ((string)box.Tag == "Transparent")
			{
				BorderColor = Color.Transparent;
			}
			var rect = new Rectangle(0, 0, box.Width, box.Height);
			ControlPaint.DrawBorder(p.Graphics, rect, BorderColor, ButtonBorderStyle.Solid);
			rect.Inflate(-1, -1);
			ControlPaint.DrawBorder(p.Graphics, rect, BorderColor, ButtonBorderStyle.Solid);
		}
		public void Resized(object sender, EventArgs e)
		{
			FormSize.Width = this.Width - 16;
			FormSize.Height = this.Height - 84;
			foreach (Form form in Application.OpenForms)
			{
				if (form.Visible && form.Name != "FrmMathre")
				{
					form.Size = FormSize;
				}
			}
		}
	}
}
