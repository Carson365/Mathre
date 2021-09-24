// Sources:
//
// Flag icons are sourced from the free icon set at https://www.iconfinder.com/iconsets/flags-37
// RoughRiders mascot image sourced from https://www.gfschools.org/cms/lib/ND02203034/Centricity/Template/GlobalAssets/images///logos/Red%20River%20HS.png
// Enter icon sourced from https://icons8.com/icon/62334/enter-mac-key
// 
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mathre
{
    public partial class FrmMathre
    {
        public FrmMathre()
        {
            InitializeComponent();
        }
        // 
        public static string StartingValue; // Define a global variable to store the starting value of the lblHelloWorld Label
        public static string AccentColor; // Define a global variable to store the starting value of the System Accent Color
        public static TabControl colRemovedTabs = new(); // Add a hidden/unused TabControl to store the Secret Settings tab  when not enabled
        public static TabPage tabSecretStorage; // Add a variable "tabSecretStorage" as a Tabpage to store the Secret Settings tab  without modifying it
        public static Color SystemColor;
        private object Placeholder;
        public static Rectangle Rect;
        public static Graphics g;



        // 
        public void FormLoad(object sender, EventArgs e) //Formload event handler
        {
            tabSecretStorage = tabMathre.TabPages[3]; // Copy the secret settings page to tabSecretStorage
            colRemovedTabs.Controls.Add(tabSecretStorage); // Add the Secret Settings tab to the hidden tabcontrol
            tabMathre.Controls.Remove(tabSecretStorage); // Remove the Secret Settings tab from the primary tabcontrol
            mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable()); // Use the custom color table to color the menu items, rather than using the default one.
            var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM"); // Navigate to this windows directory key
            AccentColor = Conversions.ToString(ColorKey.GetValue("AccentColor")); // Set the systemcolor variable to the value of the AccentColor field within the windows directory key.
            ColorKey.Close(); // Stop registry access
            KeyPreview = true; // Ensure key inputs on the form are being tracked
            StartingValue = grpHelloWorld.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name; // Store the default checked radio button in grpHelloWorld
            SystemColor = ColorTranslator.FromWin32(Conversions.ToInteger(AccentColor));
            foreach (var ToolStripMenuItem in mnuBaseLayer.Items) // Recursion point
            {
                AddMenuItemHandlers((ToolStripMenuItem)ToolStripMenuItem); // Call on the next function to run
            } // Begin recursion
        }
        // 
        private void AddMenuItemHandlers(ToolStripMenuItem ToolStripMenuItem) // ToolStripMenuItem.DropDown.Keydown doesn't work unless you add an alias (ToolStripMenuItem) for ToolStripMenuItem.
        {
            foreach (var ToolStripItem in ToolStripMenuItem.DropDownItems) // Recursion point
            {
                if (ToolStripItem is ToolStripMenuItem ToolstripItem) // For the menu items that don't have key input tracking -
                {
                    ToolStripMenuItem.DropDown.KeyDown += KeyboardShortcuts; // - add a function to track key inputs (under the name of the main form's, for simplicity.
                    AddMenuItemHandlers(ToolstripItem); // Call back to the above sub to repeat this code on the next menu item.
                }
            } // Begin recursion
        }
        // 
        private void KeyboardShortcuts(object sender, KeyEventArgs e) // Event handler for keypresses made within the form (which now includes keypresses from the menu items)
        {
            if (e.Control & e.KeyCode == Keys.S) // Add Control+S shortcut
            {
                if (tabMathre.TabPages.Contains(tabSecretStorage)) // Check for the Secret Settings tab in the main tablist
                {
                    colRemovedTabs.Controls.Add(tabSecretStorage); // If the Secret Settings tab is in the main tablist, add it to the hidden removed tab list -
                    tabMathre.Controls.Remove(tabSecretStorage); // - then remove it.
                }
                else
                {
                    tabMathre.Controls.Add(colRemovedTabs.TabPages[0]); // If the Secret Settings tab is not in the main tablist, add it -
                    colRemovedTabs.Controls.Remove(tabSecretStorage); // then remove it from the hidden removed tab list -
                    tabMathre.SelectedTab = tabSecretStorage; // - and switch to the Secret Settings tab.
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
                Buttons(mnuHelloWorldReset, null); // Use shortcut to reset the lblHelloWorld to its stored value by pressing the reset button.
            }
            //
            if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode >= Keys.D1 & e.KeyCode <= Keys.D9)) // Add Control+Number shortcut for each tab page, and no more than the amout of pages.
            {
                tabMathre.SelectedTab = tabMathre.TabPages[e.KeyCode - Keys.D1]; // Navigate to the tab of the key pressed by converting the key value to a number and then subtracting 1 to adjust for the indexing starting at 0.
            }
            //
            if (txtSecretPassword.ContainsFocus & e.KeyCode == Keys.Enter)  // Add Enter keypress handler for the text box on the Secret Settings menu
            {
                SecretHandler(txtSecretPassword, null); // Send the inputted text to SecretHandler for processing.
            }
            //
            if (txtRectangleDimensions.ContainsFocus & e.KeyCode == Keys.Enter)
            {
                Rectangle(Placeholder, null);
            }

            if (txtRectangleDimensions.ContainsFocus & e.KeyCode == Keys.Back)
            {
                if (new Regex((string)(@"^\d+( x )+$")).Match(txtRectangleDimensions.Text).Success)
                {
                    if (txtRectangleDimensions.SelectionStart.Equals(txtRectangleDimensions.Text.Length))
                    {
                        e.SuppressKeyPress = true;
                        txtRectangleDimensions.Text = txtRectangleDimensions.Text.Substring(0, txtRectangleDimensions.Text.Length - 3);
                        txtRectangleDimensions.SelectionStart = (txtRectangleDimensions.Text.Length);
                    }
                }
            }
        }

        private void SecretHandler(object sender, EventArgs e) // Event handler for the functions on the Secret Settings page.
        {
            if (ReferenceEquals(sender, txtSecretPassword)) // If the event is caused by the textbox:
            {
                string hashedvalue; // Introduce the 'hashedvalue' variable
                if (String.IsNullOrEmpty(txtSecretPassword.Text)) // Check for a null value in the Secret Setting password field
                    hashedvalue = String.Empty; // Set the hashedvalue to Empty if the value is null.
                using (var sha = new System.Security.Cryptography.SHA256Managed()) // Introduce the Sha256 hashing method
                {
                    byte[] textData = System.Text.Encoding.UTF8.GetBytes(txtSecretPassword.Text); // Get the value of the Secret Settings password field input and convert it to a usable form (bytes).
                    byte[] hash = sha.ComputeHash(textData); // Compute the Sha256 hash of the input.
                    hashedvalue = BitConverter.ToString(hash).Replace("-", String.Empty); // Convert the calculated hash to a useable format and store it in the hashedvalue variable.
                }
                if (hashedvalue == "5994471ABB01112AFCC18159F6CC74B4F511B99806DA59B3CAF5A9C173CACFC5") // If the hashed value of the text matches this predefined value (AKA the correct password):
                {
                    btnSecretEnable.Enabled = true; // Enable the control buttons.
                    btnSecretDisable.Enabled = true; // Enable the control buttons.
                }
                else
                {
                    btnSecretEnable.Enabled = false; // Disable the control buttons.
                    btnSecretDisable.Enabled = false; // Disable the control buttons.
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
                mnuSecret.Enabled = true; // Enable the Secret menu.
                btnSecretEnable.Checked = true; // Check the Enabled button.
            }

            if (ReferenceEquals(sender, btnSecretDisable)) // If the event is caused by the Disable button:
            {
                mnuSecret.Enabled = false; // Disable the Secret menu.
                btnSecretDisable.Checked = true; // Check the Disabled button
            }
            // 
        }
        // 
        private void Buttons(object sender, EventArgs e) // Event Handler for a press of the French button
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
                Buttons(grpHelloWorld.Controls[StartingValue], null); // Call back to the Buttons Sub with the pre-stored initially checked radio button substituted as sender in order to reset both the buttons and the label to their initial value.
            }
            else if (ReferenceEquals(sender, mnuRandomify))
            {
                lblHelloWorldTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString(); // Uses a random value between 0 and 1 with modification to 'randomify' the lblHelloWorld value.
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
                Application.Exit(); // Exit.
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

        private void Rectangle(object sender, EventArgs e)
        {
            double Height = 0;
            double Width = 0;
            string[] words = txtRectangleDimensions.Text.Split(' ');
            if (words.Length > 2)
            {
                var LengthIsNumeric = double.TryParse(words[2], out double HeightValue);
                if (LengthIsNumeric)
                {
                    Height = HeightValue;
                }
                var WidthIsNumeric = double.TryParse(words[0], out double WidthValue);
                if (WidthIsNumeric)
                {
                    Width = WidthValue;
                }
            }
            if (ReferenceEquals(sender, button1))
            {
                Rectangle(Placeholder, null);
            }
            if (ReferenceEquals(sender, Placeholder))
            {
                var ratioX = (double)grpRectangle.MaximumSize.Width / Width;
                var ratioY = (double)grpRectangle.MaximumSize.Height / Height;
                var ratio = Math.Min(ratioX, ratioY);
                var newWidth = (int)(Width * ratio);
                var newHeight = (int)(Height * ratio);
                grpRectangle.Width = newWidth;
                grpRectangle.Height = newHeight;
                grpRectangle.Left = (grpRectangle.Parent.Width - grpRectangle.Width) / 2;
                grpRectangle.Top = (grpRectangle.Parent.Height - grpRectangle.Height) / 2;
                grpRectangle.Visible = true;
                lblArea.Text = (Width * Height).ToString();
                lblPerimeter.Text = (2 * Width + 2 * Height).ToString();
            }

            if (!new Regex((string)(@"^\d+( x ){1}\d+$")).Match(txtRectangleDimensions.Text).Success)
            {
                if (new Regex((string)(@"^\d+( x ){1}\d+[^\d]+$")).Match(txtRectangleDimensions.Text).Success)
                {
                    txtRectangleDimensions.Text = txtRectangleDimensions.Text.Substring(0, txtRectangleDimensions.Text.Length - 1);
                    txtRectangleDimensions.SelectionStart = txtRectangleDimensions.Text.Length;
                }
                else
                {
                    if (!new Regex((string)(@"^\d+( x ){1}$")).Match(txtRectangleDimensions.Text).Success)
                    {
                        if (new Regex((string)(@"^\d+( x ){1}[^\d]+$")).Match(txtRectangleDimensions.Text).Success)
                        {
                            txtRectangleDimensions.Text = txtRectangleDimensions.Text.Substring(0, txtRectangleDimensions.Text.Length - 1);
                            txtRectangleDimensions.SelectionStart = txtRectangleDimensions.Text.Length;
                        }
                        else
                        {
                            if (!new Regex((string)(@"^[0-9]?$")).Match(txtRectangleDimensions.Text).Success)
                            {
                                if (txtRectangleDimensions.Text.Length == 1)
                                {
                                    txtRectangleDimensions.Text = txtRectangleDimensions.Text.Remove(txtRectangleDimensions.Text.Length - 1, 1);
                                }
                            }

                            if (!new Regex((string)(@"^[0-9]+$")).Match(txtRectangleDimensions.Text).Success)
                            {
                                if (txtRectangleDimensions.Text.Length != 0)
                                {
                                    txtRectangleDimensions.Text = txtRectangleDimensions.Text.Substring(0, txtRectangleDimensions.Text.Length - 1) + " x ";
                                    txtRectangleDimensions.SelectionStart = txtRectangleDimensions.Text.Length;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
