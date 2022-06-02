using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm00Mathre : Form
	{
		public static Color SystemColor;
		public static Color SystemLight;
		public static Color SystemDark;
		public bool Dark = true;
		private ToolStripMenuItem Secret;
		public readonly List<Form> Projects = new();
		ToolStripItem LastTab = null;
		ToolStripItem ActiveTab = null;
		public Frm00Mathre()
		{
			InitializeComponent();
			KeyDown += KeyboardShortcuts;
			Load += LoadEvent;
			Microsoft.Win32.SystemEvents.UserPreferenceChanged += (p, e) => SysTheme();
			mnuTabs.ItemClicked += (o, e) => { LastTab = ActiveTab; ActiveTab = e.ClickedItem; RePaint(); FormManager(); };
		}
		// Add a paint event handler to manage a clicked manuitem 'tab' then remove it once the tab has been styled
		public void RePaint() { mnuTabs.Paint += (p, e) => SetSelectStyle(e); mnuTabs.Invalidate(); mnuTabs.Paint -= (p, e) => SetSelectStyle(e); }
		public void SetSelectStyle(PaintEventArgs e)
		// Add visual effects to the selected form's corresponding tab
		{
			e.Graphics.FillRectangle(new SolidBrush(SystemDark), ActiveTab.Bounds);
			e.Graphics.DrawRectangle(new Pen(SystemColor, 1), new Rectangle(ActiveTab.Bounds.Location, new Size(ActiveTab.Bounds.Width - 1, ActiveTab.Bounds.Height - 1)));
		}
		public void Recurse(object o)
		// Set up the Menu Items to have the proper styling
		{
			if (o is ToolStripMenuItem ti)
			{
				foreach (ToolStripItem a in ti.DropDownItems) Recurse(a);
				ti.DropDown.BackColor = SystemColors.Control;
				((ToolStripDropDownMenu)ti.DropDown).ShowImageMargin = false;
				ti.DropDown.KeyDown += KeyboardShortcuts;
			}
			else if (o is ToolStripTextBox tb) { tb.BackColor = SystemColors.Control; tb.KeyDown += KeyboardShortcuts; }
		}
		// Make sure the right form is always showing
		public void FormManager() { foreach (Form form in Projects) { if (form.Name.Replace("Frm", "tab") != ActiveTab.Name) form.Hide(); else form.Show(); } }
		public Color Blend(Color color, Color backColor, double amount)
		// Return a color by combining two input colors in a specified ratio
		{
			byte r = (byte)(color.R * amount + backColor.R * (1 - amount));
			byte g = (byte)(color.G * amount + backColor.G * (1 - amount));
			byte b = (byte)(color.B * amount + backColor.B * (1 - amount));
			return Color.FromArgb(r, g, b);
		}
		public void StartTheme()
		// Trigger theming of all controls
		{
			foreach (Control c in Controls) DarkMode(c);
			foreach (ToolStripMenuItem ti in mnuBaseLayer.Items) DarkMode(ti);
		}
		public void DarkMode(object o)
		// The main 'theme engine' - swaps between light/dark mode and sets the colors of all controls (the colors are manually chosen)
		{
			if (o is Control c)
			{
				if (c is Form f) f.BackColor = Dark ? Blend(Color.DimGray, Color.Black, 0.5) : SystemColors.ControlLightLight;
				else if (c is Panel pnl && pnl.Name != "pnlFrame")
				{
					if (pnl.BackColor != Color.Transparent) pnl.BackColor = Dark ? Color.Gray : SystemColors.Control;
					else pnl.BackColor = Dark ? Color.DimGray : Color.Transparent;
				}
				else if (c is TextBox) { c.BackColor = Dark ? Color.DimGray : Color.White; }
				else if (c is ListView || c is MenuStrip || c is TabControl) { c.BackColor = Dark ? Color.DimGray : SystemColors.Control; }
				else if (c is NumericUpDown || c is Button || c.Parent is UpDownBase) { c.BackColor = Dark ? Color.DimGray : Color.White; }
				else if (c is ListView lv) lv.ForeColor = Dark ? Color.DimGray : Color.White;
				else c.BackColor = Color.Transparent;
				c.ForeColor = Dark ? Color.White : Color.Black;
				if (c is Button btn) { btn.FlatStyle = FlatStyle.Flat; btn.FlatAppearance.BorderSize = 1; btn.FlatAppearance.BorderColor = SystemColor; }
				// Recurse
				foreach (Control a in c.Controls) DarkMode(a);
			}
			else if (o is ToolStripMenuItem ti)
			{
				ti.DropDown.BackColor = Dark ? Color.DimGray : SystemColors.Control;
				ti.DropDown.ForeColor = Dark ? Color.White : Color.Black;
				// Recurse
				foreach (ToolStripItem a in ti.DropDownItems) DarkMode(a);
			}
			else if (o is ToolStripTextBox tb)
			{ tb.BackColor = Dark ? Color.DimGray : Color.White; tb.ForeColor = Dark ? Color.White : Color.Black; }
		}
		// Set up forms and menu items based on projects created in the solution
		public void LoadEvent(object sender, EventArgs e)
		{
			foreach (Type type in Assembly.GetExecutingAssembly().DefinedTypes.Where(t => t.BaseType == typeof(Form) && t.Name != "Frm00Mathre" && t.Name != "FrmTemplate").OrderBy(x => x.Name))
			{
				Icon = Resources.Rainbow;
				Form form = Activator.CreateInstance(type) as Form;
				Projects.Add(form);
				if (!System.Text.RegularExpressions.Regex.IsMatch(form.Name, @"\d{2}b"))
				{
					form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					form.FormBorderStyle = FormBorderStyle.None;
					form.Left = 140;
					form.Top = 24;
					form.TopLevel = false;
					form.Visible = true;
					Controls.Add(form);
					form.Focus();
					form.Width = Width - 156;
					form.Height = Height - 63;
					ToolStripMenuItem newTab = new();
					newTab.Name = $"{form.Name.Replace("Frm", "tab")}";
					newTab.Text = $"{form.Text}";
					if (newTab.Name == "tabSecret") { Secret = newTab; mnuTabs.Items.Remove(Secret); }
					else
					{
						mnuTabs.Items.Add(newTab);
						ToolStripMenuItem item = new();
						item.Name = newTab.Name.Replace("tab", "mnuView");
						item.Text = newTab.Text;
						item.Click += (s, e) => { newTab.PerformClick(); };
						mnuView.DropDownItems.Add(item);
						ToolStripMenuItem menu = new();
						menu.Text = form.Text;
						menu.Name = form.Name.Replace("tab", "mnu");
						mnuFile.DropDownItems.Add(menu);
						form.Controls.OfType<Control>().All(c => { GetMenu(c, menu, form); return true; });
					}
				}
			}
			ToolStripMenuItem exit = new();
			exit.Name = "mnuExit";
			exit.Text = "Exit";
			exit.Click += (s, e) => { Close(); };
			mnuFile.DropDownItems.Add(exit);
			mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
			mnuTabs.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
			foreach (Control c in Controls) GetPanels(c);
			MinimumSize = new Size(1600, mnuTabs.Items[mnuTabs.Items.Count - 1].Bounds.Bottom + 65);
			Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
			mnuTabs.Items[mnuTabs.Items.Count - 2].PerformClick();
			KeyPreview = true;
			BackColor = SystemColor;
			foreach (ToolStripMenuItem ti in mnuBaseLayer.Items) Recurse(ti);
			SysTheme();
		}
		// Get the system color and apply it. Called when the system color changes.
		public void SysTheme()
		{
			Microsoft.Win32.RegistryKey ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
			SystemColor = ColorTranslator.FromWin32(Convert.ToInt32(ColorKey.GetValue("AccentColor")));
			ColorKey.Close();
			PaintTheme();
		}
		public void PaintTheme()
		// Initiate recursive theming for all elements
		{
			SystemLight = Blend(SystemColor, Color.GhostWhite, .4);
			SystemDark = Blend(SystemColor, Color.GhostWhite, .6);
			StartTheme();
			foreach (Control c in Controls) Recolor(c);
		}
		// Repaint all elements following a theme change
		public void Recolor(Control c) { c.Invalidate(); foreach (Control a in c.Controls) Recolor(a); }
		// Recurse through controls to find the panels to add a paint event handler to
		public void GetPanels(Control container) { foreach (Control b in container.Controls) { GetPanels(b); if ((b is Panel) && b.Name != "pnlFrame") b.Paint += PaintPanel; } }
		public void PaintPanel(object box, PaintEventArgs p)
		// Set the background color of the panels
		{
			Color Border = SystemColor;
			if ($"{((Panel)box).Tag}".StartsWith("Black")) Border = Color.Black;
			if ($"{((Panel)box).Tag}".StartsWith("Transparent")) Border = Color.Transparent;
			ControlPaint.DrawBorder(p.Graphics, ((Panel)box).ClientRectangle, Border, 2, ButtonBorderStyle.Solid, Border, 2, ButtonBorderStyle.Solid, Border, 2, ButtonBorderStyle.Solid, Border, 2, ButtonBorderStyle.Solid);
		}
		// Button Clicker
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		public void GetMenu(Control container, ToolStripMenuItem item, Form form)
		// Add Menu items to the menu corresponding to various elements within the projects
		{
			foreach (Control b in container.Controls)
			{
				if ((b is Panel) && $"{b.Tag}".Contains(','))
				{
					ToolStripMenuItem menu = new();
					menu.Text = $"{b.Tag}".Substring($"{b.Tag}".LastIndexOf(',') + 1);
					item.DropDownItems.Add(menu);
					GetMenu(b, menu, form);
				}
				else GetMenu(b, item, form);
				if ((b is Button && b.Text != "") || (b is RadioButton) || (b is CheckBox) || (b is PictureBox pic && b.FindForm().Name == "Frm20Shell" && $"{pic.Tag}" != ""))
				{
					ToolStripMenuItem tool = new();
					tool.Enabled = b.Enabled;
					tool.Text = b.Text;
					if (b is PictureBox pb) tool.Text = pb.Tag.ToString();
					tool.Name = b.Name;
					tool.Click += (p, e) => { SendMessage(b.Handle, 0x0201, 0, 1); SendMessage(b.Handle, 0x0202, 0, 0); };
					item.DropDownItems.Add(tool);
				}
				if (b is TextBox bx && (b.Parent is not NumericUpDown))
				{
					ToolStripTextBox tool = new();
					tool.BorderStyle = BorderStyle.FixedSingle;
					tool.Enabled = b.Enabled;
					tool.Text = b.Text;
					tool.Name = b.Name;
					tool.TextBox.Name = b.Name;
					if (b.FindForm().Name == "Frm03Rectangle")
						tool.TextBox.KeyDown += Application.OpenForms.OfType<Frm03Rectangle>().SingleOrDefault().RectangleKeypress;
					else if (b.FindForm().Name == "Frm17WordGuess")
						tool.TextBox.KeyDown += Application.OpenForms.OfType<Frm17WordGuess>().SingleOrDefault().KeyPressEvent;
					else if (b.FindForm().Name == "Frm12Hurricane")
						tool.TextBox.KeyDown += Application.OpenForms.OfType<Frm12Hurricane>().SingleOrDefault().EnterKey;
					else tool.TextBox.KeyPress += ((Forms.IManager)form).InputFormatter;
					b.TextChanged += (p, e) => tool.Text = b.Text;
					tool.TextChanged += (p, e) => b.Text = tool.Text;
					item.DropDownItems.Add(tool);
				}
			}
		}
		public void KeyboardShortcuts(object sender, KeyEventArgs e)
		// This is the main keyboard shortcut handler
		{
			if (e.Control & e.KeyCode == Keys.S)
			{
				bool sized = Location == new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
				if (!mnuTabs.Items.Contains(Secret))
				{
					mnuTabs.Items.Add(Secret);
					MinimumSize = new Size(1600, mnuTabs.Items[mnuTabs.Items.Count - 1].Bounds.Bottom + 65);
					if (sized) Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
					Secret.PerformClick();
				}
				else { mnuTabs.Items.Remove(Secret); LastTab.PerformClick(); }
				bool minsized = Size == MinimumSize;
				MinimumSize = new Size(1600, mnuTabs.Items[mnuTabs.Items.Count - 1].Bounds.Bottom + 65);
				if (minsized) Size = MinimumSize;
				if (sized) Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
			}
			var F01 = Application.OpenForms.OfType<Frm01HelloWorld>().Single();
			if (e.Control & e.KeyCode == Keys.R) F01.HelloWorld("Secret", null);
			if (e.Control & e.Shift & e.KeyCode == Keys.R) F01.HelloWorld("Reset", null);
			if (e.Control & e.KeyCode == Keys.Down || e.KeyCode == Keys.Right) mnuTabs.Items[Math.Min(mnuTabs.Items.Count - 1, mnuTabs.Items.IndexOf(ActiveTab) + 1)].PerformClick();
			if (e.Control & e.KeyCode == Keys.Up || e.KeyCode == Keys.Left) mnuTabs.Items[Math.Max(0, mnuTabs.Items.IndexOf(ActiveTab) - 1)].PerformClick();
		}
		public class MenuColorTable : ProfessionalColorTable
		// Set the colors for the menu strips
		{
			public override Color MenuItemBorder => SystemColor;
			public override Color MenuItemSelected => SystemLight;
			public override Color MenuBorder => SystemColor;
			public override Color ToolStripDropDownBackground => SystemColor;
			public override Color MenuItemSelectedGradientBegin => SystemLight;
			public override Color MenuItemSelectedGradientEnd => SystemLight;
			public override Color MenuItemPressedGradientBegin => SystemDark;
			public override Color MenuItemPressedGradientEnd => SystemDark;
		}
	}
}