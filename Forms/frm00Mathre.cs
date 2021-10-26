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
			mnuDigitsCalculate.Click += Temperature;
			txtNumber.KeyPress += NumericalKeypress;
			txtTemperature.KeyPress += NumericalKeypress;
			txtPaidAmount.KeyPress += NumericalKeypress;
			txtPizzaTip.KeyPress += NumericalKeypress;
			txtPizzaSize.KeyPress += NumericalKeypress;
			btnSecretDisable.Click += SecretHandler;
			btnSecretEnable.Click += SecretHandler;
			//mnuView.Click += Buttons;
			//mnuEdit.Click += Buttons;
			mnuExit.Click += Exit;
			mnuMySchoolToggleMascot.Click += MS.MySchool;
			mnuHelloWorldReset.Click += HW.HelloWorld;
			mnuHelloWorldLanguageGerman.Click += HW.HelloWorld;
			mnuHelloWorldLanguageFrench.Click += HW.HelloWorld;
			mnuHelloWorldLanguageEnglish.Click += HW.HelloWorld;
			mnuRandomify.Click += HW.HelloWorld;
			//mnuTechnicolor.Click += HW.Buttons;
			//mnuDarkMode.Click += Buttons;
			//mnuRecolor.Click += Buttons;
			// Make sure that's working right
			// \/ \/ \/ \/ \/ \/ \/ \/ \/ \/
			//mnuSecret.Click += HelloWorld;
			btnFahrenheit.Click += Temperature;
			btnCelsius.Click += Temperature;
			btnFahrenheit.CheckedChanged += Temperature;
			btnCelsius.CheckedChanged += Temperature;
			txtTemperature.KeyUp += Temperature;
			txtNumber.KeyUp += Digits;
			txtPaidAmount.KeyUp += ChangeMaker;
			txtPizzaSize.KeyUp += Pizza;
			txtPizzaTip.KeyUp += Pizza;
			btnDelivery.CheckedChanged += Pizza;
			btnTakeout.CheckedChanged += Pizza;
			btnPercent.CheckedChanged += Pizza;
			btnDollars.CheckedChanged += Pizza;
			mnuPizzaDelivery.Click += Pizza;
			mnuPizzaTakeout.Click += Pizza;
			mnuPizzaPercent.Click += Pizza;
			mnuPizzaDollars.Click += Pizza;
			mnuTemperatureFahrenheit.Click += Temperature;
			mnuTemperatureCelsius.Click += Temperature;
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
				FavoriteItem.Click += Favorites;
			}
			foreach (RadioButton Button in pnlFavoriteControls.Controls)
			{
				Button.Click += Favorites;
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
			//
			if (txtSecretPassword.ContainsFocus & e.KeyCode == Keys.Enter)  // Add Enter keypress handler for the text box on the Secret Settings menu
			{
				SecretHandler(txtSecretPassword, null); // Send the inputted text to SecretHandler for processing
			}
			//
			if (txtNumber.ContainsFocus & e.KeyCode == Keys.Enter)  // Add Enter keypress handler for the text box on the Secret Settings menu
			{
				Digits(txtNumber, null); // Send the inputted text to SecretHandler for processing
			}
		}
		public void SecretHandler(object sender, EventArgs e) // Event handler for the functions on the Secret Settings page
		{
			if (ReferenceEquals(sender, txtSecretPassword)) // If the event is caused by the textbox:
			{
				string hashedvalue; // Introduce the 'hashedvalue' variable
				if (String.IsNullOrEmpty(txtSecretPassword.Text)) // Check for a null value in the Secret Setting password field
					hashedvalue = String.Empty; // Set the hashedvalue to Empty if the value is null.
				using (var sha = new System.Security.Cryptography.SHA256Managed()) // Introduce the Sha256 hashing method
				{
					byte[] textData = System.Text.Encoding.UTF8.GetBytes(txtSecretPassword.Text); // Get the value of the Secret Settings password field input and convert it to a usable form (bytes)
					byte[] hash = sha.ComputeHash(textData); // Compute the Sha256 hash of the input.
					hashedvalue = BitConverter.ToString(hash).Replace("-", String.Empty); // Convert the calculated hash to a useable format and store it in the hashedvalue variable
				}
				if (hashedvalue == "5994471ABB01112AFCC18159F6CC74B4F511B99806DA59B3CAF5A9C173CACFC5") // If the hashed value of the text matches this predefined value (AKA the correct password):
				{
					btnSecretEnable.Enabled = true; // Enable the control buttons
					btnSecretDisable.Enabled = true; // Enable the control buttons
				}
				else
				{
					btnSecretEnable.Enabled = false; // Disable the control buttons
					btnSecretDisable.Enabled = false; // Disable the control buttons
					btnSecretDisable.Checked = true; // Check the Disabled button
				}

				if (btnSecretEnable.Enabled == false) // If the Enabled button is not pressed:
				{
					mnuSecret.Enabled = false; // Disable the Secret Settings menu item
				}
			}

			txtSecretPassword.Text = ""; // Clear the text box when buttons are pressed
			if (ReferenceEquals(sender, btnSecretEnable)) // If the event is caused by the Enable button:
			{
				mnuSecret.Enabled = true; // Enable the Secret menu
				btnSecretEnable.Checked = true; // Check the Enabled button
			}

			if (ReferenceEquals(sender, btnSecretDisable)) // If the event is caused by the Disable button:
			{
				mnuSecret.Enabled = false; // Disable the Secret menu
				btnSecretDisable.Checked = true; // Check the Disabled button
			}
			// 
		}
		public void PageSelect(object sender, EventArgs e)
		{
			tabMathre.SelectTab((sender as ToolStripMenuItem).Name.ToString().Replace("mnuView", "tab"));
		}
		public void Favorites(object sender, EventArgs e) // Event Handler for a button press
		{
			// The below five eventhandlers all handle the buttons on the My Favorites page. They each set their respective radio button to appear checked, set the title text, the info label text, and then the image
			if (sender.GetType().ToString().Contains("Menu"))
			{
				RadioButton b = (RadioButton)pnlFavoriteControls.Controls[$"btnFavorite{sender}"];
				b.Checked = true;
			}
			if (ReferenceEquals(sender, btnFavoriteActor) | ReferenceEquals(sender, mnuFavoriteActor))
			{
				lblFavoriteInfo.Text = "My favorite actor is Tom Hiddleston. \n He has starred and appeared in several films, but his most famous role is that of Loki in Marvel's MCU.";
			}
			else if (ReferenceEquals(sender, btnFavoriteMovie) | ReferenceEquals(sender, mnuFavoriteMovie))
			{
				lblFavoriteInfo.Text = "My favorite movie is The Imitation Game. \n it follows the work and life of Alan Turing, a revolutionary code-breaker and very early computer scientist.";
			}
			else if (ReferenceEquals(sender, btnFavoriteFruit) | ReferenceEquals(sender, mnuFavoriteFruit))
			{
				lblFavoriteInfo.Text = "My favorite fruit is any stone fruit. \n The stone fruit family includes raspberries and blackberries, as well as peaches, plums, cherries, and other great fruits.";
			}
			else if (ReferenceEquals(sender, btnFavoriteHobby) | ReferenceEquals(sender, mnuFavoriteHobby))
			{
				lblFavoriteInfo.Text = "My favorite hobby is remote control. \n Remote control cars are very fun to drive and work on, and despite their high price they are an easy hobby to get into.";
			}
			else if (ReferenceEquals(sender, btnFavoriteColor) | ReferenceEquals(sender, mnuFavoriteColor))
			{
				lblFavoriteInfo.Text = "My favorite color is purple. \n It can complement a variety of other colors, works well to convey many different ideas or emotions, and it looks good.";
				pnlFavoriteImage.BackgroundImage = null;
				pnlFavoriteImage.BackColor = ColorTranslator.FromHtml("#6622cc");
			}
			lblFavoriteTitle.Text = $"My Favorite {pnlFavoriteControls.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text}";
			pnlFavoriteImage.BackgroundImage = imgFavoriteImages.Images[$"{pnlFavoriteControls.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text}.jpg".ToString()];
		}
		public void Temperature(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, mnuTemperatureCelsius)) //Set the buttons' appearances based on their checked state
			{
				btnCelsius.Checked = true; // ...
			}
			else if (ReferenceEquals(sender, mnuTemperatureFahrenheit)) // ...
			{
				btnFahrenheit.Checked = true; // ...
			}
			if (!btnCelsius.Checked & !btnFahrenheit.Checked) // ...
			{
				btnCelsius.Checked = true; // ...
			}
			double temp = 0; // Declare Variables
			var roundamount = 0; // ...
			if (txtTemperature.Text.Contains(DecimalChar)) // Check for the decimal character
			{
				if (txtTemperature.Text[txtTemperature.Text.Length - 1].ToString() != DecimalChar) // Check whether there are numbers on each side of the decimal
				{
					string[] words = txtTemperature.Text.Split(DecimalChar.ToCharArray()); // Split the string based on decimal position
					roundamount = words[1].Length; // Store the amount of precision
				}
			}
			else
			{
				roundamount = 0; // If there is no decimal, do not round decimals in the answer
			}
			if (double.TryParse(txtTemperature.Text, out var tempcheck)) // Check whether the temperature is numeric
			{
				temp = tempcheck; // Assign the temperature value if it is numeric
			}
			if (btnFahrenheit.Checked) // ...
			{
				lblCelsiusDisplay.Text = $"{Math.Round((temp - 32) * 5 / 9, roundamount)} °C"; // Set the Celsius value using the proper math and degree of precision
				lblFahrenheitDisplay.Text = $"{Math.Round(temp, roundamount)} °F"; // Set the Fahrenheit value using the proper degree of precision
			}
			else if (btnCelsius.Checked) // ...
			{
				lblCelsiusDisplay.Text = $"{Math.Round(temp, roundamount)} °C";  // Set the Celsius value using the proper degree of precision
				lblFahrenheitDisplay.Text = $"{Math.Round((temp * 9 / 5) + 32, roundamount)} °F"; // Set the Fahrenheit value using the proper math and degree of precision
			}
		}
		public void Digits(object sender, KeyEventArgs e) // Event Handler for keypresses in the Digits text box (pre-filtered to be only in the proper format)
		{
			lblDigitsCount.Text = txtNumber.Text.Length.ToString(); // Set the length based on the string length
			lblDigitsListEvens.Text = ""; // Clear the Even Number List (happens each keypress)
			lblDigitsListOdds.Text = ""; // Clear the Odd Number List (happens each keypress)
			for (int i = 0; i < txtNumber.Text.Length; i++) // Run the following code for each character in the text box, and note the index of the character.
			{
				char c = txtNumber.Text[i];
				if ((txtNumber.Text.IndexOf(c, i) + 1) % 2 == 0) // Check if the number is even
				{
					lblDigitsListEvens.Text += $"Digit {i + 1}: {c}\r\n"; // Add it to the even list in the proper format
				}
				else if ((txtNumber.Text.IndexOf(c, i) + 1) % 2 == 1) // Check if the number is even
				{
					lblDigitsListOdds.Text += $"Digit {i + 1}: {c}\r\n"; // Add it to the odd list in the proper format
				}
			}
		}
		public void ChangeMaker(object sender, EventArgs e) // Event Handler for keypresses in the Digits text box (pre-filtered to be only in the proper format)
		{
			string[] decimals = txtPaidAmount.Text.Split(DecimalChar.ToCharArray()); // Split the input using the spaces as separators
			int Bills = 0;
			int Coins = 0;
			if (int.TryParse(decimals[0], out int BillsAmount)) // Check whether the first substring is a number
			{
				Bills = BillsAmount; // Assign the width value to the first substring if numeric
			}
			if (decimals.Length > 1) // Ensure there is more than one substring
			{
				if (int.TryParse(decimals[1], out int CoinsAmount)) // Check whether the second substring is a number
				{
					Coins = CoinsAmount; // Assign the width value to the first substring if numeric
				}
			}
			lblHundredsCount.Text = (Bills / 100).ToString(); // Integer division to determine how many whole 100s the dollar value can be divided by
			lblFiftiesCount.Text = (Bills % 100 / 50).ToString(); // Use mod division to determine the remainder after checking for hundreds, then integer division to see how many whole 50s the number can be divided by
			lblTwentiesCount.Text = (Bills % 100 % 50 / 20).ToString(); // ...
			lblTensCount.Text = (Bills % 100 % 50 % 20 / 10).ToString(); // ...
			lblFivesCount.Text = (Bills % 100 % 50 % 20 % 10 / 5).ToString(); // ...
			lblOnesCount.Text = (Bills % 100 % 50 % 20 % 10 % 5 / 1).ToString(); // ...
			lblQuartersCount.Text = (Coins / 25).ToString(); // Perform the same process for the coins
			lblDimesCount.Text = (Coins % 25 / 10).ToString(); // ...
			lblNickelsCount.Text = (Coins % 25 % 10 / 5).ToString(); // ...
			lblPenniesCount.Text = (Coins % 25 % 10 % 5 / 1).ToString(); // ...
		}
		public void NumericalKeypress(object sender, KeyPressEventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			if (sender is not TextBoxBase textBox) // Ensure the sender is the input form -
				return; // -or else discard it
			if (e.KeyChar.ToString() == DecimalChar) // If the pressed key is the user's decimal separator
			{
				if (!(ReferenceEquals(sender, txtNumber) | ReferenceEquals(sender, txtPizzaSize)))
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
				if (!(ReferenceEquals(sender, txtNumber) | ReferenceEquals(sender, txtPizzaSize) | ReferenceEquals(sender, txtPizzaTip)))
				{
					if (e.KeyChar != '-')
					{
						e.Handled = true; // Discard the character input
					}
					else if (textBox.SelectionStart != 0)
					{
						e.Handled = true;
					}
				}
				else
				{
					e.Handled = true;
				}
			}
			if (sender == txtPaidAmount | sender == txtPizzaTip)
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
		public void Pizza(object sender, EventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			if (ReferenceEquals(sender, mnuPizzaDelivery)) //Set the buttons' appearances based on their checked state
			{
				btnDelivery.Checked = true; // ...
			}
			else if (ReferenceEquals(sender, mnuPizzaTakeout)) // ...
			{
				btnTakeout.Checked = true; // ...
			}
			if (!btnDelivery.Checked & !btnTakeout.Checked) // ...
			{
				btnDelivery.Checked = true; // ...
			}
			if (ReferenceEquals(sender, mnuPizzaDollars)) // ...
			{
				btnDollars.Checked = true; // ...
			}
			else if (ReferenceEquals(sender, mnuPizzaPercent)) // ...
			{
				btnPercent.Checked = true; // ...
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
				pnlPizzaViewer.BackgroundImage = imgFavoriteImages.Images[$"SmallPizza.png".ToString()]; // ...
			}
			else if (Size > 13)
			{
				pnlPizzaViewer.BackgroundImage = imgFavoriteImages.Images[$"LargePizza.png".ToString()]; // ...
			}
			else if (Size is not 0)
			{
				pnlPizzaViewer.BackgroundImage = imgFavoriteImages.Images[$"MediumPizza.png".ToString()]; // ...
			}
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
			// 
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
