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
		private string AccentColor;
		private static Color SystemColor;
		private static Color SystemLight;
		private static Color SystemDark;
		public bool Dark = false;
		private ToolStripMenuItem Secret;
		public readonly List<Form> Projects = new();
		ToolStripItem activeToolStripItem = null;
		public Frm00Mathre()
		{
			InitializeComponent();
			KeyDown += KeyboardShortcuts;
			Load += LoadEvent;
			Shown += (p, e) => activeToolStripItem.Select();
			Microsoft.Win32.SystemEvents.UserPreferenceChanged += (p, e) => SysTheme();
			mnuTabs.ItemClicked += (o, e) => { activeToolStripItem = e.ClickedItem; RePaint(); FormManager(o, e); };
		}
		public void RePaint()
		{
			mnuTabs.Paint += (o, e) => SetSelectStyle(activeToolStripItem, e);
			mnuTabs.Invalidate();
			mnuTabs.Paint -= (o, e) => SetSelectStyle(activeToolStripItem, e);
		}
		public Color Blend(Color color, Color backColor, double amount)
		// Return a color by combining two input colors in a specified ratio
		{
			byte r = (byte)(color.R * amount + backColor.R * (1 - amount));
			byte g = (byte)(color.G * amount + backColor.G * (1 - amount));
			byte b = (byte)(color.B * amount + backColor.B * (1 - amount));
			return Color.FromArgb(r, g, b);
		}
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
			foreach (ToolStripMenuItem ti in mnuBaseLayer.Items) { MenuKeypress(ti); ((ToolStripDropDownMenu)ti.DropDown).ShowImageMargin = false; }
			foreach (Control c in Controls) GetPanels(c);
			MinimumSize = new Size(1600, mnuTabs.Items[mnuTabs.Items.Count - 1].Bounds.Bottom + 65);
			Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
			mnuTabs.Items[mnuTabs.Items.Count - 2].PerformClick();
			KeyPreview = true;
			SysTheme();
			BackColor = SystemColor;
		}
		public void SysTheme()
		{
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
			AccentColor = $"{ColorKey.GetValue("AccentColor")}";
			ColorKey.Close();
			KeyPreview = true;
			SystemColor = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
			SystemLight = Blend(SystemColor, Color.GhostWhite, .4);
			SystemDark = Blend(SystemColor, Color.GhostWhite, .6);
			foreach (Control c in Controls) Recolor(c);
		}
		public void Recolor(Control c) { c.Invalidate(); foreach (Control a in c.Controls) Recolor(a); }
		public IEnumerable<ToolStripMenuItem> GetAll(ToolStripItemCollection items)
		{
			List<ToolStripMenuItem> allItems = new();
			foreach (ToolStripMenuItem item in items.OfType<ToolStripMenuItem>()) { allItems.Add(item); allItems.AddRange(GetAll(item.DropDownItems)); }
			return allItems;
		}
		public void GetPanels(Control container)
		{
			foreach (Control b in container.Controls) { GetPanels(b); if ((b is Panel) && (b is not TabPage) && b.Name != "pnlFrame") b.Paint += PaintPanel; }
		}
		// Button Clicker
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		public void GetMenu(Control container, ToolStripMenuItem item, Form form)
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
		public void FormManager(object sender, EventArgs e)
		{
			foreach (Form form in Projects) { if (form.Name.Replace("Frm", "tab") != activeToolStripItem.Name) form.Hide(); else form.Show(); }
		}
		public void MenuKeypress(ToolStripMenuItem TSMI)
		{
			foreach (ToolStripMenuItem TSI in GetAll(TSMI.DropDownItems))
			{
				((ToolStripDropDownMenu)TSI.DropDown).ShowImageMargin = false;
				TSMI.DropDown.KeyDown += KeyboardShortcuts;
				MenuKeypress(TSI);
			}
		}
		public void KeyboardShortcuts(object sender, KeyEventArgs e)
		{
			if (e.Control & e.KeyCode == Keys.S)
			{
				if (!mnuTabs.Items.Contains(Secret))
				{
					mnuTabs.Items.Add(Secret);
					bool sized1 = Location == new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
					MinimumSize = new Size(1600, mnuTabs.Items[mnuTabs.Items.Count - 1].Bounds.Bottom + 65);
					if (sized1) Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
					Secret.PerformClick();
				}
				else { mnuTabs.Items.Remove(Secret); mnuTabs.Items[0].PerformClick(); }
				bool sized = Location == new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
				bool minsized = Size == MinimumSize;
				MinimumSize = new Size(1600, mnuTabs.Items[mnuTabs.Items.Count - 1].Bounds.Bottom + 65);
				if (minsized) Size = MinimumSize;
				if (sized) Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
			}
			var F01 = Application.OpenForms.OfType<Frm01HelloWorld>().Single();
			if (e.Control & e.KeyCode == Keys.R) F01.HelloWorld("Secret", null);
			if (e.Control & e.Shift & e.KeyCode == Keys.R) F01.HelloWorld("Reset", null);
			if (e.Control & e.KeyCode == Keys.Down || e.KeyCode == Keys.Right) mnuTabs.Items[Math.Min(mnuTabs.Items.Count - 1, mnuTabs.Items.IndexOf(activeToolStripItem) + 1)].PerformClick();
			if (e.Control & e.KeyCode == Keys.Up || e.KeyCode == Keys.Left) mnuTabs.Items[Math.Max(0, mnuTabs.Items.IndexOf(activeToolStripItem) - 1)].PerformClick();
		}
		public void SetSelectStyle(object sender, PaintEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(Blend(SystemColor, Color.GhostWhite, .6)), ((ToolStripMenuItem)sender).Bounds);
		}
		public class MenuColorTable : ProfessionalColorTable
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
		public void PaintPanel(object box, PaintEventArgs p)
		{
			Color Border = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
			if ($"{((Panel)box).Tag}".StartsWith("Black")) Border = Color.Black;
			if ($"{((Panel)box).Tag}".StartsWith("Transparent")) Border = Color.Transparent;
			ControlPaint.DrawBorder(p.Graphics, ((Panel)box).ClientRectangle, Border, 2, ButtonBorderStyle.Solid, Border, 2, ButtonBorderStyle.Solid, Border, 2, ButtonBorderStyle.Solid, Border, 2, ButtonBorderStyle.Solid);
		}
	}
}
