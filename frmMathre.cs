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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmMathre
	{
		public static string StartingValue; // Define a global variable to store the starting value of the lblHelloWorld Label
		public static string AccentColor; // Define a global variable to store the starting value of the System Accent Color
		public static Color SystemColor; // Define a global color to store the converted value of the System Accent Color
		public static bool hidden; // Define a global variable to acknowledge whether the Secret Settings page is hidden
		public object Placeholder; // Define a global object to use to send blank events between event handlers
		public static Rectangle Rect; // Define a global rectangle to use for measurements
		public FrmMathre()
		{
			this.InitializeComponent();
			// The following are all event handlers. They assign the event (left) to its handler (right)
			btnHelloWorldFrench.Click += Buttons;
			Load += FormLoad;
			KeyDown += KeyboardShortcuts;
			btnHelloWorldReset.Click += Buttons;
			btnHelloWorldGerman.Click += Buttons;
			btnHelloWorldEnglish.Click += Buttons;
			btnMySchoolToggleMascot.Click += Buttons;
			btnRectangleCalculate.Click += Rectangle;
			mnuRectangleCalculate.Click += Rectangle;
			mnuDigitsCalculate.Click += Temperature;
			txtRectangleDimensions.KeyPress += RectangleKeypress;
			txtNumber.KeyPress += NumericalKeypress;
			txtTemperature.KeyPress += NumericalKeypress;
			txtRectangleDimensions.TextChanged += Rectangle;
			btnSecretDisable.Click += SecretHandler;
			btnSecretEnable.Click += SecretHandler;
			mnuView.Click += Buttons;
			mnuEdit.Click += Buttons;
			mnuExit.Click += Buttons;
			mnuMySchoolToggleMascot.Click += Buttons;
			mnuHelloWorldReset.Click += Buttons;
			mnuHelloWorldLanguageGerman.Click += Buttons;
			mnuHelloWorldLanguageFrench.Click += Buttons;
			mnuHelloWorldLanguageEnglish.Click += Buttons;
			mnuRandomify.Click += Buttons;
			mnuTechnicolor.Click += Buttons;
			mnuDarkMode.Click += Buttons;
			mnuRecolor.Click += Buttons;
			mnuSecret.Click += Buttons;
			btnFavoriteActor.Click += Buttons;
			btnFavoriteColor.Click += Buttons;
			btnFavoriteFruit.Click += Buttons;
			btnFavoriteHobby.Click += Buttons;
			btnFavoriteMovie.Click += Buttons;
			mnuFavoriteActor.Click += Buttons;
			mnuFavoriteColor.Click += Buttons;
			mnuFavoriteFruit.Click += Buttons;
			mnuFavoriteHobby.Click += Buttons;
			mnuFavoriteMovie.Click += Buttons;
			btnFahrenheit.Click += Temperature;
			btnCelsius.Click += Temperature;
			btnFahrenheit.CheckedChanged += Temperature;
			btnCelsius.CheckedChanged += Temperature;
			txtTemperature.KeyUp += Temperature;
			txtNumber.KeyUp += Digits;
			mnuTemperatureFahrenheit.Click += Temperature;
			mnuTemperatureCelsius.Click += Temperature;
			mnuViewHelloWorld.Click += Buttons;
			mnuViewMySchool.Click += Buttons;
			mnuViewRectangle.Click += Buttons;
			mnuViewMyFavorites.Click += Buttons;
			mnuViewTemperature.Click += Buttons;
			mnuViewDigits.Click += Buttons;
			mnuViewUnknown.Click += Buttons;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			lblDigitsListOdds.Text = "";
			lblDigitsListEvens.Text = "";
			lblRectangleError.Visible = false; // Hide the Rectangle Calculator Error box
			tabMathre.TabPages.Remove(tabSecret); // Hide the secret settings tab
			hidden = true; // Mark the secret settings hidden variable as true
			mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable()); // Use the custom color table to color the menu items, rather than using the default one
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM"); // Navigate to this windows directory key
			AccentColor = Conversions.ToString(ColorKey.GetValue("AccentColor")); // Set the systemcolor variable to the value of the AccentColor field within the windows directory key
			ColorKey.Close(); // Stop registry access
			KeyPreview = true; // Ensure key inputs on the form are being tracked
			StartingValue = grpHelloWorld.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name; // Store the default checked radio button in grpHelloWorld
			SystemColor = ColorTranslator.FromWin32(Conversions.ToInteger(AccentColor)); // Translate the system accent color to a usable format
			foreach (var ToolStripMenuItem in mnuBaseLayer.Items) // Recursion point
			{
				AddMenuItemHandlers((ToolStripMenuItem)ToolStripMenuItem); // Call on the next function to run
			} // Begin recursion
		}
		private void AddMenuItemHandlers(ToolStripMenuItem ToolStripMenuItem) // ToolStripMenuItem.DropDown.Keydown doesn't work unless you add an alias (ToolStripMenuItem) for ToolStripMenuItem
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
		private void KeyboardShortcuts(object sender, KeyEventArgs e) // Event handler for keypresses made within the form (which now includes keypresses from the menu items)
		{
			if (e.Control & e.KeyCode == Keys.S) // Add Control+S shortcut
			{
				if (hidden == true) // Ensure the secret settings tab is hidden
				{
					tabMathre.Controls.Add(tabSecret); // Unhide the secret settings tab
					tabMathre.SelectedTab = tabSecret; // Select the secret settings tab
					hidden = false; // Mark the secret settings tab as shown
				}
				else if (hidden == false)  // Ensure the secret settings tab is not hidden
				{
					tabMathre.Controls.Remove(tabSecret); // Hide the secret settings tab
					hidden = true; // Mark the secret settings tab as hidden
				}
			}
			//
			if (e.Control & e.KeyCode == Keys.R & mnuSecret.Enabled) // Add Control+R shortcut, dependent on the secret menu being enabled
			{
				Buttons(mnuRandomify, null); // Use shortcut to quickly run the randomize function
			}
			// 
			if (e.Control & e.Shift & e.KeyCode == Keys.R) // Add Control+Shift+R shortcut
			{
				Buttons(mnuHelloWorldReset, null); // Use shortcut to reset the lblHelloWorld to its stored value by pressing the reset button
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
			if (txtRectangleDimensions.ContainsFocus) // Check whether the rectangle calculator is selected
			{
				if (e.KeyCode == Keys.Enter) // Check whether the enter key is pressed
				{
					Rectangle(Placeholder, null); // Run the Rectangle Calculator
				}
				if (e.KeyCode == Keys.Delete) // Check whether the delete key is pressed
				{
					e.Handled = true; // Discard input
				}
				if (e.KeyCode == Keys.Control) // Check whether the control key is pressed
				{
					e.Handled = true; // Discard input
				}
			}
			if (txtNumber.ContainsFocus & e.KeyCode == Keys.Enter)  // Add Enter keypress handler for the text box on the Secret Settings menu
			{
				Digits(txtNumber, null); // Send the inputted text to SecretHandler for processing
			}
		}
		private void RectangleKeypress(object sender, KeyPressEventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			int space1 = (txtRectangleDimensions.Text.IndexOf(" ")); // Get the position of the first space in the textbox
			int x1 = (txtRectangleDimensions.Text.IndexOf("x")); // Get the position of the first x in the textbox
			int space2 = (txtRectangleDimensions.Text.IndexOf(" ", txtRectangleDimensions.Text.IndexOf(" ") + 1)); // Get the position of the second space in the textbox
			int currentpos = (txtRectangleDimensions.SelectionStart - 1); // Add a variable represesnting the character that would be deleted with a backspace keypress 
			int modifier = 0; // Introduce the modifier variable
			string[] words = txtRectangleDimensions.Text.Split(' '); // Split the input using the spaces as separators
			if (!(e.KeyChar == (char)Keys.Return)) // Check whether the pressed key is anything other than enter 
			{
				grpRectangle.Visible = false; // Clear the rectangle
				lblRectangleArea.Text = "Area"; // Clear the area
				lblRectanglePerimeter.Text = "Perimeter"; // Clear the perimeter
			}
			if (sender is not TextBoxBase textBox) // Ensure the sender is the input form -
				return; // -or else discard it
			if (txtRectangleDimensions.SelectedText.Contains(" ") || txtRectangleDimensions.SelectedText.Contains("x")) // If there is a selection made that includes part of the multiplier field
			{
				if (e.KeyChar == '\b') // If backspace is pressed
				{
					e.Handled = true; // Discard the backspace keypress
					txtRectangleDimensions.SelectedText = ""; // Delete the selected text
					int selectionIndex = textBox.SelectionStart; // Get the current position
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x ", ""); // (this one probably isn't needed)
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x", ""); // Delete all variations of the multiplication separator
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace("x ", ""); // Delete all variations of the multiplication separator
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" ", ""); // Delete all variations of the multiplication separator
					if (currentpos == space1) modifier = 1; // If the action of deleting put the cursor at the first space, move it back 1 to reallign it
					else if (currentpos == x1) modifier = 2; // If the action of deleting put the cursor at the first x, move it back 2 to reallign it
					else if (currentpos == space2) modifier = 3; // If the action of deleting put the cursor at the second space, move it back 3 to reallign it
					else modifier = 0; // If the selection was outside of the multiplication separator, don't move it
					textBox.SelectionStart = selectionIndex - modifier; // Set the cursor to the modified position
				}
			}
			if (e.KeyChar.ToString() == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator) // If the pressed key is the user's decimal separator
			{
				if (words.Length > 2) // If there are at least 3 substrings (meaning the multiplication separator exists)
				{
					if (currentpos < space1) // If the cursor is before the first space
					{
						if (words[0].Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) // If there is already a decimal separator
						{
							e.Handled = true; // Discard the decimal separator input
						}
					}
					else if (currentpos >= space2) // If the cursor is at or after the first space
					{
						if (words[2].Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) // If there is already a decimal separator
						{
							e.Handled = true;// Discard the decimal separator input
						}
					}
					else
					{
						e.Handled = true; // Discard the decimal separator input
					}
				}
				else if (textBox.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) // If there are not multiple number groups and there is already a decimal separator
				{
					e.Handled = true; // Discard the decimal separator input
				}
			}

			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))) // If a non-backspace non-number character is pressed
			{
				if (textBox.Text.Contains(" x ")) // If there is a multiplication separator
				{
					e.Handled = true; // Discard the character input
				}
				else
				{
					e.Handled = true;  // Discard the character input
					string insertText = " x "; // Set the multiplication separator
					int selectionIndex = textBox.SelectionStart; // Set the current position
					textBox.Text = textBox.Text.Insert(selectionIndex, insertText); // Append the multiplication separator
					textBox.SelectionStart = selectionIndex + 3; // Restore cursor position
				}
			}
			else if ((currentpos == space1 || currentpos == x1 || currentpos == space2) && currentpos != -1) //If the cursor is located where it would delete the multiplication operator
			{
				if (currentpos != space2) // Make sure numbers can't be entered between the spaces by the x
				{
					e.Handled = true;
				}
				if (currentpos == space1 || currentpos == x1 || currentpos == space2 && currentpos != -1) //If the cursor is located where it would delete the multiplication operator
				{
					if (e.KeyChar == '\b') // If backspace is pressed
					{
						if (txtRectangleDimensions.Text.Contains(" x ")) // If the string has a multiplication operator
						{
							e.Handled = true; // Discard the backspace
							int selectionIndex = textBox.SelectionStart; // Get the cursor position
							txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x ", ""); // Remove the multiplication operator
							if (currentpos == space1) modifier = 1; // If the action of deleting put the cursor at the first space, move it back 1 to reallign it
							if (currentpos == x1) modifier = 2; // If the action of deleting put the cursor at the first x, move it back 2 to reallign it
							if (currentpos == space2) modifier = 3; // If the action of deleting put the cursor at the second space, move it back 3 to reallign it
							textBox.SelectionStart = selectionIndex - modifier; // Set the cursor to the modified position

						}
					}
				}
			}
		}
		private void SecretHandler(object sender, EventArgs e) // Event handler for the functions on the Secret Settings page
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
		private void Buttons(object sender, EventArgs e) // Event Handler for a button press
		{
			if (ReferenceEquals(sender, btnHelloWorldEnglish) | ReferenceEquals(sender, mnuHelloWorldLanguageEnglish)) // If the event is caused by the English button or menu item:
			{
				btnHelloWorldEnglish.Checked = true;
				lblHelloWorldTitle.Text = "Hello World"; // Sets lblHelloWorld to English
			}
			else if (ReferenceEquals(sender, btnHelloWorldFrench) | ReferenceEquals(sender, mnuHelloWorldLanguageFrench)) // If the event is caused by the French button or menu item:
			{
				btnHelloWorldFrench.Checked = true;
				lblHelloWorldTitle.Text = "Bonjour le Monde"; // Sets lblHelloWorld to French
			}
			else if (ReferenceEquals(sender, btnHelloWorldGerman) | ReferenceEquals(sender, mnuHelloWorldLanguageGerman)) // If the event is caused by the German button or menu item:
			{
				btnHelloWorldGerman.Checked = true;
				lblHelloWorldTitle.Text = "Hallo Welt"; // Sets lblHelloWorld to German
			}
			else if (ReferenceEquals(sender, btnHelloWorldReset) | ReferenceEquals(sender, mnuHelloWorldReset))  // If the event is caused by the Reset button or menu item:
			{
				Buttons(grpHelloWorld.Controls[StartingValue], null); // Call back to the Buttons Sub with the pre-stored initially checked radio button substituted as sender in order to reset both the buttons and the label to their initial value
			}
			else if (ReferenceEquals(sender, mnuRandomify))
			{
				btnHelloWorldEnglish.Checked = false;
				btnHelloWorldFrench.Checked = false;
				btnHelloWorldGerman.Checked = false;
				lblHelloWorldTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString(); // Uses a random value between 0 and 1 with modification to 'randomify' the lblHelloWorld value
			}
			else if (ReferenceEquals(sender, btnMySchoolToggleMascot) | ReferenceEquals(sender, mnuMySchoolToggleMascot)) // If the event is caused by the ToggleMascot button or menu item:
			{
				picMySchoolMascot.Visible = !picMySchoolMascot.Visible; // Inverts the visibility of the mascot image
				if (lblMySchoolMascot.ForeColor != Color.Black) // Inverts the text color
				{
					lblMySchoolMascot.ForeColor = Color.Black;
				}
				else
				{
					lblMySchoolMascot.ForeColor = Color.DimGray;
				}
			}
			else if (ReferenceEquals(sender, mnuExit)) // If the event is caused by the Exit menu item:
			{
				Application.Exit(); // Exit
			}
			// The below five eventhandlers all handle the buttons on the My Favorites page. They each set their respective radio button to appear checked, set the title text, the info label text, and then the image
			else if (ReferenceEquals(sender, btnFavoriteActor) | ReferenceEquals(sender, mnuFavoriteActor))
			{
				btnFavoriteActor.Checked = true;
				lblFavoriteTitle.Text = "My Favorite Actor";
				lblFavoriteInfo.Text = "My favorite actor is Tom Hiddleston. \n He has starred and appeared in several films, but his most famous role is that of Loki in Marvel's MCU.";
				grpFavoriteImage.BackgroundImage = imgFavoriteImages.Images[0];
			}
			else if (ReferenceEquals(sender, btnFavoriteMovie) | ReferenceEquals(sender, mnuFavoriteMovie))
			{
				btnFavoriteMovie.Checked = true;
				lblFavoriteTitle.Text = "My Favorite Movie";
				lblFavoriteInfo.Text = "My favorite movie is The Imitation Game. \n it follows the work and life of Alan Turing, a revolutionary code-breaker and very early computer scientist.";
				grpFavoriteImage.BackgroundImage = imgFavoriteImages.Images[1];
			}
			else if (ReferenceEquals(sender, btnFavoriteFruit) | ReferenceEquals(sender, mnuFavoriteFruit))
			{
				btnFavoriteFruit.Checked = true;
				lblFavoriteTitle.Text = "My Favorite Fruit";
				lblFavoriteInfo.Text = "My favorite fruit is any stone fruit. \n The stone fruit family includes raspberries and blackberries, as well as peaches, plums, cherries, and other great fruits.";
				grpFavoriteImage.BackgroundImage = imgFavoriteImages.Images[2];
			}
			else if (ReferenceEquals(sender, btnFavoriteHobby) | ReferenceEquals(sender, mnuFavoriteHobby))
			{
				btnFavoriteHobby.Checked = true;
				lblFavoriteTitle.Text = "My Favorite Hobby";
				lblFavoriteInfo.Text = "My favorite hobby is remote control. \n Remote control cars are very fun to drive and work on, and despite their high price they are an easy hobby to get into.";
				grpFavoriteImage.BackgroundImage = imgFavoriteImages.Images[3];
			}
			else if (ReferenceEquals(sender, btnFavoriteColor) | ReferenceEquals(sender, mnuFavoriteColor))
			{
				btnFavoriteColor.Checked = true;
				lblFavoriteTitle.Text = "My Favorite Color";
				lblFavoriteInfo.Text = "My favorite color is purple. \n It can complement a variety of other colors, works well to convey many different ideas or emotions, and it looks good.";
				grpFavoriteImage.BackgroundImage = null;
				grpFavoriteImage.BackColor = ColorTranslator.FromHtml("#6622cc");
			}
			else if (ReferenceEquals(sender, mnuViewHelloWorld) | ReferenceEquals(sender, mnuViewMySchool) | ReferenceEquals(sender, mnuViewRectangle) | ReferenceEquals(sender, mnuViewMyFavorites) | ReferenceEquals(sender, mnuViewTemperature) | ReferenceEquals(sender, mnuViewDigits) | ReferenceEquals(sender, mnuViewUnknown))
			{
				tabMathre.SelectTab((sender as ToolStripMenuItem).Name.ToString().Replace("mnuView", "tab"));
			}
		}
		private void Rectangle(object sender, EventArgs e) // Event handler for the rectangle calculation functions
		{
			double Height = 0; // Add a variable to store the rectangle height
			double Width = 0; // Add a variable to store the rectangle width
			string[] words = txtRectangleDimensions.Text.Split(' '); // Split the input using the spaces as separators
			if (words.Length > 2) // If there are at least three substrings
			{
				if (double.TryParse(words[2], out double HeightValue)) // Check whether the third substring is a number
				{
					Height = HeightValue; // Assign the height value to the third substring if numeric
				}
				if (double.TryParse(words[0], out double WidthValue)) // Check whether the first substring is a number
				{
					Width = WidthValue; // Assign the width value to the first substring if numeric
				}
			}
			if ((ReferenceEquals(sender, btnRectangleCalculate)) || (ReferenceEquals(sender, mnuRectangleCalculate))) // If the Calculate button is pressed
			{
				Rectangle(Placeholder, null); // Run the rectangle calculator with the values from the input field
			}
			if (ReferenceEquals(sender, Placeholder)) // If the rectangle needs to be calculated and visualized
			{
				var ratioX = (double)grpRectangle.MaximumSize.Width / Width; // Make the X-ratio equal to the proportional size of the maximum width of the visualization rectangle
				var ratioY = (double)grpRectangle.MaximumSize.Height / Height; // Make the Y-ratio equal to the proportional size of the maximum height of the visualization rectangle
				var ratio = Math.Min(ratioX, ratioY); // Set the overall ratio equal to the smallest of the two ratios
				var newWidth = (int)(Width * ratio); // Create a new width for the visualizer that fits on the screen according to the ratio
				var newHeight = (int)(Height * ratio); // Create a new height for the visualizer that fits on the screen according to the ratio
				grpRectangle.Width = newWidth; // Set the visualization width to the modified proportional width
				grpRectangle.Height = newHeight; // Set the visualization height to the modified proportional height
				grpRectangle.Left = (grpRectangle.Parent.Width - grpRectangle.Width) / 2; // Center the rectangle horizontally within its visualization space
				grpRectangle.Top = (grpRectangle.Parent.Height - grpRectangle.Height) / 2; // Center the rectangle vertically within its visualization space
				grpRectangle.Visible = true; // Make the visualization rectangle visible
				lblRectangleError.Visible = false; // Hide the error label
				if ((newHeight == 0 || newWidth == 0) && (!(Height == 0 || Width == 0))) // Check whether the adjusted sizes (using the ratio) are zero
				{
					lblRectangleError.Text = "Invalid Visualization"; // Show a visualization error message
					lblRectangleError.Visible = true; // Make the error visible
					lblRectangleArea.Text = (Width * Height).ToString(); // Show the area result
					lblRectanglePerimeter.Text = (2 * Width + 2 * Height).ToString(); // Show the perimeter result
				}
				else if ((Height == 0 || Width == 0 || newHeight == -2147483648 || newWidth == -2147483648)) // If the height or width is zero or invalid
				{
					lblRectangleError.Text = "Invalid Dimensions"; // Show an input error message
					lblRectangleError.Visible = true; // Make the error visible
					lblRectangleArea.Text = "Invalid Dimensions"; // Show an input error for the area result
					lblRectanglePerimeter.Text = "Invalid Dimensions"; // Show an input error for the perimeter result
				}
				else
				{
					lblRectangleArea.Text = (Width * Height).ToString(); // Show the area result
					lblRectanglePerimeter.Text = (2 * Width + 2 * Height).ToString(); // Show the perimeter result
				}
			}
		}
		private void Temperature(object sender, EventArgs e)
		{
			if (mnuTemperatureCelsius.Checked | ReferenceEquals(sender, mnuTemperatureCelsius))
			{
				btnCelsius.Checked = true;
			}
			else if (mnuTemperatureFahrenheit.Checked | ReferenceEquals(sender, mnuTemperatureFahrenheit))
			{
				btnFahrenheit.Checked = true;
			}
			if (!btnCelsius.Checked & !btnFahrenheit.Checked)
			{
				btnCelsius.Checked = true;
			}
			double temp = 0;
			var roundamount = 0;
			if (txtTemperature.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
			{
				if (txtTemperature.Text[txtTemperature.Text.Length - 1].ToString() != CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
				{
					string[] words = txtTemperature.Text.Split(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray());
					roundamount = words[1].Length;
				}
			}
			else
			{
				roundamount = 0;
			}
			if (double.TryParse(txtTemperature.Text, out var tempcheck))
			{
				temp = tempcheck; // Assign the height value to the third substring if numeric
			}
			if (btnFahrenheit.Checked)
			{
				lblCelsiusDisplay.Text = $"{Math.Round(((temp - 32) * 5 / 9), roundamount).ToString()} °C";
				lblFahrenheitDisplay.Text = $"{Math.Round((temp), roundamount).ToString()} °F";
			}
			else if (btnCelsius.Checked)
			{
				lblCelsiusDisplay.Text = $"{Math.Round((temp), roundamount).ToString()} °C";
				lblFahrenheitDisplay.Text = $"{Math.Round(((temp * 9 / 5) + 32), roundamount).ToString()} °F";
			}
		}
		private void Digits(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			lblDigitsCount.Text = txtNumber.Text.Length.ToString();
			lblDigitsListEvens.Text = "";
			lblDigitsListOdds.Text = "";
			for (int i = 0; i < txtNumber.Text.Length; i++)
			{
				char c = txtNumber.Text[i];
				if ((txtNumber.Text.IndexOf(c, i) + 1) % 2 == 0)
				{
					lblDigitsListEvens.Text += $"Digit {i+1}: {c}\r\n";
				}
				else if ((txtNumber.Text.IndexOf(c, i) + 1) % 2 == 1)
				{
					lblDigitsListOdds.Text += $"Digit {i+1}: {c}\r\n";
				}
			}
		}
		private void NumericalKeypress(object sender, KeyPressEventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			if (sender is not TextBoxBase textBox) // Ensure the sender is the input form -
				return; // -or else discard it
			if (e.KeyChar.ToString() == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator) // If the pressed key is the user's decimal separator
			{
				if (!ReferenceEquals(sender, txtNumber))
				{
					if (textBox.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) // If there are not multiple number groups and there is already a decimal separator
					{
						e.Handled = true; // Discard the decimal separator input
					}
				}
				else
				{
					e.Handled = true;
				}
			}
			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))) // If a non-backspace non-number character is pressed
			{
				if (!ReferenceEquals(sender, txtNumber))
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
		}
		private class MenuColorTable : ProfessionalColorTable // Custom Color table for theming
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
		//private void BuildMenuItems()
		//{
		//	ToolStripMenuItem[] items = new ToolStripMenuItem[2]; // You would obviously calculate this value at runtime
		//	for (int i = 0; i < items.Length; i++)
		//	{
		//		items[i] = new ToolStripMenuItem();
		//		items[i].Name = "dynamicItem" + i.ToString();
		//		items[i].Text = "Visible Menu Text Here";
		//		items[i].Click += new EventHandler(MenuItemClickHandler);
		//	}

		//	mnuEdit.DropDownItems.AddRange(items);
		//}

		//private void MenuItemClickHandler(object sender, EventArgs e)
		//{
		//	ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
		//	// Take some action based on the data in clickedItem
		//}

	}
}
