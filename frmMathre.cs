// Sources:
// The AddMenuItemHandlers Sub (and some supporting code in the FormLoad sub) is sourced from https://social.msdn.microsoft.com/Forums/vstudio/2ac347d5-4946-4143-8d54-e136d5508f64
// Flag icons are sourced from the free icon set at https://www.iconfinder.com/iconsets/flags-37
// RoughRiders mascot image sourced from https://www.gfschools.org/cms/lib/ND02203034/Centricity/Template/GlobalAssets/images///logos/Red%20River%20HS.png
// 
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Linq;
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
        public static string systemColor; // Define a global variable to store the starting value of the System Accent Color
        public static TabControl colRemovedTabs = new(); // Add a hidden/unused TabControl to store the Secret Settings page when not enabled
        public static TabPage tabSecretStorage; // Add a variable "tabSecretStorage" as a Tabpage to store the Secret Setting Page without modifying it


        public static string SystemColor { get => systemColor; set => systemColor = value; } // Not sure what this is or what it does but it needs to be here otherwise everything breaks
        // 
        public void FormLoad(object sender, EventArgs e) //Formload event handler
        {
            tabSecretStorage = tabMathre.TabPages[2]; // Copy the secret settings page to tabSecretStorage
            colRemovedTabs.Controls.Add(tabSecretStorage); // Add the secret settings tab to the hidden tabcontrol
            tabMathre.Controls.Remove(tabSecretStorage); // Remove the secret settings tab from the primary tabcontrol
            mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable()); // Use the custom color table to color the menu items, rather than using the default one.
            var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM"); // Navigate to this windows directory key
            SystemColor = Conversions.ToString(ColorKey.GetValue("AccentColor")); // Set the systemcolor variable to the value of the AccentColor field within the windows directory key.
            ColorKey.Close(); // Stop registry access
            KeyPreview = true; // Ensure key inputs on the form are being tracked
            StartingValue = grpHelloWorldGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name; // Store the default checked radio button in grpHelloWorld
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
                if (tabMathre.TabPages.Contains(tabSecretStorage))
                {
                    colRemovedTabs.Controls.Add(tabSecretStorage);
                    tabMathre.Controls.Remove(tabSecretStorage);
                }
                else
                {
                    tabMathre.Controls.Add(colRemovedTabs.TabPages[0]);
                    colRemovedTabs.Controls.Remove(tabSecretStorage);
                    tabMathre.SelectedTab = tabSecretStorage;
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
                tabMathre.SelectedTab = tabMathre.TabPages[e.KeyCode - Keys.D1];
            }
            //
            if (txtSecretPassword.ContainsFocus & e.KeyCode == Keys.Enter)  // Add Enter keypress handler for the text box on the Secret Settings menu
            {
                SecretHandler(txtSecretPassword, null);
            }
        }

        private void SecretHandler(object sender, EventArgs e) // Event handler for keypresses made within the form (which now includes keypresses from the menu items)
        {
            if (ReferenceEquals(sender, txtSecretPassword))
            {
                if (txtSecretPassword.Text == "12345")
                {
                    btnSecretEnable.Enabled = true;
                    btnSecretDisable.Enabled = true;
                }
                else
                {
                    btnSecretEnable.Enabled = false;
                    btnSecretDisable.Enabled = false;
                    btnSecretDisable.Checked = true;
                }

                if (btnSecretEnable.Enabled == false)
                {
                    mnuSecret.Enabled = false;
                }
            }

            txtSecretPassword.Text = "";
            if (ReferenceEquals(sender, btnSecretEnable))
            {
                mnuSecret.Enabled = true;
                btnSecretEnable.Checked = true;
            }

            if (ReferenceEquals(sender, btnSecretDisable))
            {
                mnuSecret.Enabled = false;
                btnSecretDisable.Checked = true;
            }
            // 
        }
        // 
        private void Buttons(object sender, EventArgs e) // Event Handler for a press of the French button
        {
            if (ReferenceEquals(sender, btnHelloWorldEnglish) | ReferenceEquals(sender, mnuHelloWorldLanguageEnglish))
            {
                btnHelloWorldEnglish.Checked = true;
                lblHelloWorldTitle.Text = "Hello World"; // Sets lblHelloWorld to English
            }
            else if (ReferenceEquals(sender, btnHelloWorldFrench) | ReferenceEquals(sender, mnuHelloWorldLanguageFrench))
            {
                btnHelloWorldFrench.Checked = true;
                lblHelloWorldTitle.Text = "Bonjour le Monde"; // Sets lblHelloWorld to French
            }
            else if (ReferenceEquals(sender, btnHelloWorldGerman) | ReferenceEquals(sender, mnuHelloWorldLanguageGerman))
            {
                btnHelloWorldGerman.Checked = true;
                lblHelloWorldTitle.Text = "Hallo Welt"; // Sets lblHelloWorld to German
            }
            else if (ReferenceEquals(sender, btnHelloWorldReset) | ReferenceEquals(sender, mnuHelloWorldReset))
            {
                Buttons(grpHelloWorldGroupBox.Controls[StartingValue], null); // Call back to the Buttons Sub with the pre-stored initially checked radio button substituted as sender in order to reset both the buttons and the label to their initial value.
            }
            else if (ReferenceEquals(sender, mnuRandomify))
            {
                lblHelloWorldTitle.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString(); // Uses a random value between 0 and 1 with modification to 'randomify' the lblHelloWorld value.
            }
            else if (ReferenceEquals(sender, btnMySchoolToggleMascot) | ReferenceEquals(sender, mnuMySchoolToggleMascot))
            {
                picMySchoolMascot.Visible = !picMySchoolMascot.Visible;
                if (lblMySchoolMascot.ForeColor != Color.Black)
                {
                    lblMySchoolMascot.ForeColor = Color.Black;
                }
                else
                {
                    lblMySchoolMascot.ForeColor = Color.DimGray;
                }
            }
            else if (ReferenceEquals(sender, mnuExit))
            {
                Application.Exit();
            }
        }

        private class MenuColorTable : ProfessionalColorTable
        {
            public override Color MenuItemBorder
            {
                get
                {
                    return ColorTranslator.FromWin32(Conversions.ToInteger(SystemColor));
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return ColorTranslator.FromWin32(Conversions.ToInteger(SystemColor));
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return ColorTranslator.FromWin32(Conversions.ToInteger(SystemColor));
                }
            }
            // 
        }
    }
}
