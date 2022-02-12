using Mathre.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm00Mathre : Form, IManager
	{
		private string AccentColor;
		private static Color SystemColor;
		public bool hidden;
		private TabPage Secret;
		public Frm00Mathre()
		{
			InitializeComponent();
			KeyDown += KeyboardShortcuts;
			tabMathre.SelectedIndexChanged += FormManager;
			Load += LoadEvent;
		}
		public void LoadEvent(object sender, EventArgs e)
		{
			foreach (Type type in Assembly.Load("Mathre").GetTypes().OrderBy(x => x.Name).Where(t => typeof(Form).IsAssignableFrom(t) && t.Name != "Frm00Mathre" && t.Name != "FrmTemplate" && t.Name != "Frm19bSecretMessage"))
			{
				var form = Activator.CreateInstance(type) as Form;
				form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Left = 0;
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
					item.Click += new EventHandler((sender, e) => { tabMathre.SelectTab((sender as ToolStripMenuItem).Name.ToString().Replace("mnuView", "tab")); });
					mnuView.DropDownItems.Add(item);
					ToolStripMenuItem menu = new();
					menu.Text = form.Text;
					menu.Name = form.Name.Replace("tab", "mnu");
					mnuFile.DropDownItems.Add(menu);
					form.Controls.OfType<Control>().All(c => { GetButtons(c, menu); return true; });
				}
			}
			ToolStripMenuItem exit = new();
			exit.Name = "mnuExit";
			exit.Text = "Exit";
			exit.Click += (s, e) => { Close(); };
			mnuFile.DropDownItems.Add(exit);
			mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
			AccentColor = $"{ColorKey.GetValue("AccentColor")}";
			ColorKey.Close();
			KeyPreview = true;
			SystemColor = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
			foreach (var ToolStripMenuItem in mnuBaseLayer.Items) { MenuKeypress((ToolStripMenuItem)ToolStripMenuItem); }
			foreach (Control c in Controls) { GetAllControls(this); }
			hidden = true;
			MinimumSize = new Size(Math.Min(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, Screen.FromControl(this).Bounds.Width), 500);
			tabMathre.SelectedIndex = tabMathre.TabCount - 2;
		}
		public void MenuControl(object sender, EventArgs e) { throw new NotImplementedException(); }
		public IEnumerable<ToolStripMenuItem> GetAll(ToolStripItemCollection items)
		{
			List<ToolStripMenuItem> allItems = new();
			foreach (ToolStripMenuItem item in items.OfType<ToolStripMenuItem>()) { allItems.Add(item); allItems.AddRange(GetAll(item.DropDownItems)); }
			return allItems;
		}
		public void GetAllControls(Control container)
		{
			foreach (Control b in container.Controls) { GetAllControls(b); if ((b is Panel) && (b is not TabPage) && b.Name != "pnlFrame") { b.Paint += PaintPanel; } }
		}
		public void GetButtons(Control container, ToolStripMenuItem item)
		{
			foreach (Control b in container.Controls)
			{
				if ((b is Panel) && $"{b.Tag}".Contains(','))
				{
					ToolStripMenuItem menu = new();
					menu.Text = $"{b.Tag}".Substring($"{b.Tag}".LastIndexOf(',') + 1);
					item.DropDownItems.Add(menu);
					GetButtons(b, menu);
				}
				else { GetButtons(b, item); }
				if ((b is Button) || (b is RadioButton) || (b is CheckBox))
				{
					ToolStripMenuItem tool = new();
					tool.Enabled = b.Enabled;
					tool.Text = b.Text;
					tool.Name = b.Name;
					tool.Click += ((IManager)Application.OpenForms[$"{b.FindForm().Name}"]).MenuControl;
					item.DropDownItems.Add(tool);
				}
			}
		}
		public void FormManager(object sender, EventArgs e)
		{
			if (Application.OpenForms.Count > 0 && tabMathre.TabPages.Count > 0)
			{
				foreach (Form form in Application.OpenForms)
				{
					if (form.Name != "Frm00Mathre" && form.Name.Replace("Frm", "tab") != tabMathre.SelectedTab.Name) { form.Hide(); }
					else if (form.Name != "Frm00Mathre") { form.Show(); }
				}
				var F13 = Application.OpenForms.OfType<Frm13Slots>().SingleOrDefault();
				if (tabMathre.SelectedTab.Name == "tab13Slots" && F13 != null) F13.Tabbed();
				var F17 = Application.OpenForms.OfType<Frm17WordGuess>().SingleOrDefault();
				if (tabMathre.SelectedTab.Name == "tab17WordGuess" && F17 != null) F17.Tabbed(true);
				else F17.Tabbed(false);
				var F18 = Application.OpenForms.OfType<Frm18Humane>().SingleOrDefault();
				if (tabMathre.SelectedTab.Name == "tab18Humane" && F18 != null) F18.Tabbed(true);
				else F18.Tabbed(false);
			}
		}
		public void MenuKeypress(ToolStripMenuItem TSMI)
		{
			foreach (var TSI in GetAll(TSMI.DropDownItems)) { if (TSI is ToolStripMenuItem TSI2) { TSMI.DropDown.KeyDown += KeyboardShortcuts; MenuKeypress(TSI2); } }
		}
		public void KeyboardShortcuts(object sender, KeyEventArgs e)
		{
			var F01 = Application.OpenForms.OfType<Frm01HelloWorld>().Single();
			if (e.Control & e.KeyCode == Keys.S)
			{
				if (hidden == true)
				{
					tabMathre.Controls.Add(Secret);
					MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 2).Right + tabMathre.GetTabRect(tabMathre.TabCount - 1).Width + 17, 500);
					tabMathre.SelectedTab = Secret;
					hidden = false;
				}
				else if (hidden == false) { tabMathre.Controls.Remove(Secret); hidden = true; }
				MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, 500);
			}
			if (e.Control & e.KeyCode == Keys.R & hidden == false) { F01.HelloWorld("Secret", null); }
			if (e.Control & e.Shift & e.KeyCode == Keys.R) { F01.HelloWorld("Reset", null); }
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode >= Keys.D1 & e.KeyCode <= Keys.D8)) { tabMathre.SelectedTab = tabMathre.TabPages[e.KeyCode - Keys.D1]; }
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode == Keys.D9)) { tabMathre.SelectedTab = tabMathre.TabPages[tabMathre.TabCount - 1]; }
		}
		public class MenuColorTable : ProfessionalColorTable
		{
			public override Color MenuItemBorder { get { return SystemColor; } }
			public override Color MenuItemSelected { get { return SystemColor; } }
			public override Color MenuBorder { get { return SystemColor; } }
		}
		public void PaintPanel(object box, PaintEventArgs p)
		{
			Color BorderColor = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
			if ($"{((Panel)box).Tag}".Contains("Black")) { BorderColor = Color.Black; }
			if ($"{((Panel)box).Tag}".Contains("Transparent")) { BorderColor = Color.Transparent; }
			var rect = new Rectangle(0, 0, ((Panel)box).Width, ((Panel)box).Height);
			ControlPaint.DrawBorder(p.Graphics, rect, BorderColor, ButtonBorderStyle.Solid);
			rect.Inflate(-1, -1);
			ControlPaint.DrawBorder(p.Graphics, rect, BorderColor, ButtonBorderStyle.Solid);
		}
	}
}