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
		public bool hidden;
		private TabPage Secret;
		private readonly List<Form> Projects = new();
		private int hotTrackTab = -1;
		public Frm00Mathre()
		{
			InitializeComponent();
			KeyDown += KeyboardShortcuts;
			Load += LoadEvent;
			tabMathre.DrawItem += (p, e) => DrawTab(p as TabControl, e);
			tabMathre.MouseEnter += (p, e) => UpdateHotTrack(p as TabControl);
			tabMathre.MouseLeave += (p, e) => UpdateHotTrack(p as TabControl);
			tabMathre.MouseMove += (p, e) => UpdateHotTrack(p as TabControl);
			tabMathre.LostFocus += (p, e) => UpdateHotTrack(p as TabControl);
			Shown += (p, e) => tabMathre.SelectedTab.Focus();
			tabMathre.SelectedIndexChanged += (p, e) => tabMathre.SelectedTab.Focus();
		}
		private int GetTabUnderCursor(TabControl Tab)
		// Return the index of the tab under the cursor, or -1 if none
		{
			for (int i = 0; i < Tab.TabPages.Count; i++) if (Tab.GetTabRect(i).Contains(Tab.PointToClient(Cursor.Position)) && ContainsFocus) return i;
			return -1;
		}
		private void UpdateHotTrack(TabControl Tab)
		// Remove effects from the old tab and then add them to the new one
		{
			int hot = GetTabUnderCursor(Tab);
			if (hot != hotTrackTab)
			{
				if (hotTrackTab != -1) Tab.Invalidate(Tab.GetTabRect(hotTrackTab));
				hotTrackTab = hot;
				if (hotTrackTab != -1) Tab.Invalidate(Tab.GetTabRect(hotTrackTab));
				Tab.Update();
			}
		}
		private Color Blend(Color color, Color backColor, double amount)
		// Return a color by combining two input colors in a specified ratio
		{
			byte r = (byte)(color.R * amount + backColor.R * (1 - amount));
			byte g = (byte)(color.G * amount + backColor.G * (1 - amount));
			byte b = (byte)(color.B * amount + backColor.B * (1 - amount));
			return Color.FromArgb(r, g, b);
		}
		private void DrawTab(TabControl Tab, DrawItemEventArgs e)
		// Draw the background based on hot tracking
		{
			if (e.Index == hotTrackTab)
			{
				using Brush b = new SolidBrush(Blend(SystemColor, Color.GhostWhite, ((e.Index == Tab.SelectedIndex) ? .5 : .25)));
				using Pen p = new(Color.FromArgb(255, SystemColor));
				e.Graphics.FillRectangle(b, e.Bounds);
				Rectangle r = new(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
				e.Graphics.DrawRectangle(p, r);
			}
			else
			{
				e.Graphics.FillRectangle(new SolidBrush(Blend(SystemColor, Color.GhostWhite, .65)), e.Bounds);
				if (!(e.State == DrawItemState.Selected)) e.Graphics.FillRectangle(Brushes.GhostWhite, e.Bounds);
			}
			StringFormat _stringFlags = new() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
			e.Graphics.DrawString(Tab.TabPages[e.Index].Text, Tab.Font, new SolidBrush(Color.Black), Tab.GetTabRect(e.Index), new StringFormat(_stringFlags));
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
					form.Left = 125 / 2;
					form.Top = 45;
					form.TopLevel = false;
					form.Visible = true;
					Controls.Add(form);
					form.Focus();
					form.Width = Width - 16;
					form.Height = Height - 84;
					TabPage newTab = new();
					newTab.Name = $"{form.Name.Replace("Frm", "tab")}";
					newTab.Text = $"{form.Text}";
					if (newTab.Name == "tabSecret") { Secret = newTab; tabMathre.TabPages.Remove(Secret); }
					else
					{
						tabMathre.TabPages.Add(newTab);
						ToolStripMenuItem item = new();
						item.Name = newTab.Name.Replace("tab", "mnuView");
						item.Text = newTab.Text;
						item.Click += (s, e) => { tabMathre.SelectTab(newTab); };
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
			foreach (var ToolStripMenuItem in mnuBaseLayer.Items) MenuKeypress((ToolStripMenuItem)ToolStripMenuItem);
			foreach (Control c in Controls) GetPanels(c);
			hidden = true;
			MinimumSize = new Size(1600, tabMathre.GetTabRect(tabMathre.TabCount - 1).Bottom + 65);
			Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
			tabMathre.SelectedIndex = tabMathre.TabCount - 2;
			FormManager(null, null);
			tabMathre.SelectedIndexChanged += FormManager;
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
			AccentColor = $"{ColorKey.GetValue("AccentColor")}";
			ColorKey.Close();
			KeyPreview = true;
			SystemColor = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
		}
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
			foreach (Form form in Projects) { if (form.Name.Replace("Frm", "tab") != tabMathre.SelectedTab.Name) form.Hide(); else form.Show(); }
		}
		public void MenuKeypress(ToolStripMenuItem TSMI)
		{
			foreach (var TSI in GetAll(TSMI.DropDownItems)) { if (TSI is ToolStripMenuItem TSI2) { TSMI.DropDown.KeyDown += KeyboardShortcuts; MenuKeypress(TSI2); } }
		}
		public void KeyboardShortcuts(object sender, KeyEventArgs e)
		{
			if (e.Control & e.KeyCode == Keys.S)
			{
				if (hidden == true)
				{
					tabMathre.Controls.Add(Secret);
					bool sized1 = Location == new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
					MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 2).Right + tabMathre.GetTabRect(tabMathre.TabCount - 1).Width + 17, 500);
					if (sized1) Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
					tabMathre.SelectedTab = Secret;
					hidden = false;
				}
				else if (hidden == false) { tabMathre.Controls.Remove(Secret); hidden = true; }
				bool sized = Location == new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
				bool minsized = Size == MinimumSize;
				MinimumSize = new Size(1600, tabMathre.GetTabRect(tabMathre.TabCount - 1).Bottom + 65);
				if (minsized) Size = MinimumSize;
				if (sized) Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
			}
			var F01 = Application.OpenForms.OfType<Frm01HelloWorld>().Single();
			if (e.Control & e.KeyCode == Keys.R & hidden == false) F01.HelloWorld("Secret", null);
			if (e.Control & e.Shift & e.KeyCode == Keys.R) F01.HelloWorld("Reset", null);
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode >= Keys.D1 & e.KeyCode <= Keys.D8)) tabMathre.SelectedTab = tabMathre.TabPages[e.KeyCode - Keys.D1];
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode == Keys.D9)) tabMathre.SelectedTab = tabMathre.TabPages[tabMathre.TabCount - 1];
		}
		public class MenuColorTable : ProfessionalColorTable
		{
			public override Color MenuItemBorder { get { return SystemColor; } }
			public override Color MenuItemSelected { get { return SystemColor; } }
			public override Color MenuBorder { get { return SystemColor; } }
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
