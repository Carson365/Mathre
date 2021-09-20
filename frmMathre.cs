// Sources:
// The AddMenuItemHandlers Sub (and some supporting code in the FormLoad sub) is sourced from https://social.msdn.microsoft.com/Forums/vstudio/2ac347d5-4946-4143-8d54-e136d5508f64
// Flag icons are sourced from the free icon set at https://www.iconfinder.com/iconsets/flags-37
// 
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

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
        private static string systemColor;
        public static TabControl colRemovedTabs = new();
        public static TabPage tabSecretStorage;

        public static string SystemColor { get => systemColor; set => systemColor = value; }

        // 
        public void FormLoad(object sender, EventArgs e)
        {
            tabSecretStorage = tabMathre.TabPages[3];
            colRemovedTabs.Controls.Add(tabSecretStorage);
            tabMathre.Controls.Remove(tabSecretStorage);
            mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
            var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
            SystemColor = Conversions.ToString(ColorKey.GetValue("AccentColor"));
            ColorKey.Close();
            KeyPreview = true; // Ensure key inputs on the form are being tracked
            StartingValue = grpHelloWorld.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Name;
            foreach (var ToolStripMenuItem in mnuBaseLayer.Items) // Recursion point
            {
                AddMenuItemHandlers((ToolStripMenuItem)ToolStripMenuItem); // Call on the next function to run
            } // Begin recursion
        }

        public void SystemColorChecker(object sender, EventArgs e)
        {
            var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
            SystemColor = Conversions.ToString(ColorKey.GetValue("AccentColor"));
            ColorKey.Close();
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

            if (e.Control & e.KeyCode == Keys.R & mnuSecret.Enabled) // Add Control+R shortcut, dependent on the secret menu being enabled
            {
                Buttons(mnuRandomify, null); // Use shortcut to quickly run the randomize function
            }
            // 
            if (e.Control & e.Shift & e.KeyCode == Keys.R) // Add Control+Shift+R shortcut
            {
                Buttons(mnuReset, null); // Use shortcut to reset the lblHelloWorld to its stored value by pressing the reset button.
            }

            if (txtSecretPassword.ContainsFocus & e.KeyCode == Keys.Enter)
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
            if (ReferenceEquals(sender, btnEnglish) | ReferenceEquals(sender, mnuEnglish))
            {
                btnEnglish.Checked = true;
                lblHelloWorld.Text = "Hello World"; // Sets lblHelloWorld to English
            }
            else if (ReferenceEquals(sender, btnFrench) | ReferenceEquals(sender, mnuFrench))
            {
                btnFrench.Checked = true;
                lblHelloWorld.Text = "Bonjour le Monde"; // Sets lblHelloWorld to French
            }
            else if (ReferenceEquals(sender, btnGerman) | ReferenceEquals(sender, mnuGerman))
            {
                btnGerman.Checked = true;
                lblHelloWorld.Text = "Hallo Welt"; // Sets lblHelloWorld to German
            }
            else if (ReferenceEquals(sender, btnReset) | ReferenceEquals(sender, mnuReset))
            {
                Buttons(grpHelloWorld.Controls[StartingValue.ToString()], null); // Call back to the Buttons Sub with the pre-stored initially checked radio button substituted as sender in order to reset both the buttons and the label to their initial value.
            }
            else if (ReferenceEquals(sender, mnuRandomify))
            {
                lblHelloWorld.Text = ((long)Math.Round(Math.Pow(5d * Math.Pow(0.5d + VBMath.Rnd(), 2d) + 55d, 2f + 5f * VBMath.Rnd()))).ToString(); // Uses a random value between 0 and 1 with modification to 'randomify' the lblHelloWorld value.
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
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
    }
}