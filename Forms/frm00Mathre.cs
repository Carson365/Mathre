using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm00Mathre : Form
	{
		private string AccentColor;
		private static Color SystemColor;
		private bool hidden;
		private Size FormSize;
		private TabPage Secret;
		public Frm00Mathre()
		{
			InitializeComponent();
			KeyDown += KeyboardShortcuts;
			mnuExit.Click += (s, e) => { Close(); };
			tabMathre.SelectedIndexChanged += FormManager;
			Resize += Resized;
			Load += LoadEvent;
		}
		public void LoadEvent(object sender, EventArgs e)
		{
			foreach (Type type in Assembly.Load("Mathre").GetTypes().OrderBy(x => x.Name).Where(t => typeof(Form).IsAssignableFrom(t) && t.Name != "Frm00Mathre"))
			{
				var form = Activator.CreateInstance(type) as Form;
				form.Size = FormSize;
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
				newTab.Name = $"{Regex.Replace(form.Name, "Frm", "tab")}";
				newTab.Text = $"{form.Text}";
				if (newTab.Name == "tabSecret") { Secret = newTab; tabMathre.TabPages.Remove(Secret); }
				else
				{
					tabMathre.TabPages.Add(newTab);
					ToolStripMenuItem item = new();
					item.Name = newTab.Name.ToString().Replace("tab", "mnuView");
					item.Text = newTab.Text.ToString();
					item.Click += new EventHandler((sender, e) => { tabMathre.SelectTab((sender as ToolStripMenuItem).Name.ToString().Replace("mnuView", "tab")); });
					mnuView.DropDownItems.Add(item);
				}
			}
			mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
			AccentColor = $"{(ColorKey.GetValue("AccentColor"))}";
			ColorKey.Close();
			KeyPreview = true;
			SystemColor = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
			foreach (var ToolStripMenuItem in mnuBaseLayer.Items) { MenuItemKeypressHandler((ToolStripMenuItem)ToolStripMenuItem); }
			FormCollection Forms = Application.OpenForms;
			foreach (ToolStripItem Item in GetAll(mnu01HelloWorld.DropDownItems))		{ var F01 = Forms.OfType<Frm01HelloWorld>().Single(); Item.Click += F01.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu02MySchool.DropDownItems))			{ var F02 = Forms.OfType<Frm02MySchool>().Single(); Item.Click += F02.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu04Favorites.DropDownItems))		{ var F04 = Forms.OfType<Frm04MyFavorites>().Single(); Item.Click += F04.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu05Temperature.DropDownItems))		{ var F05 = Forms.OfType<Frm05Temperature>().Single(); Item.Click += F05.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu08Pizza.DropDownItems))			{ var F08 = Forms.OfType<Frm08Pizza>().Single(); Item.Click += F08.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu09Grade.DropDownItems))			{ var F09 = Forms.OfType<Frm09Grade>().Single(); Item.Click += F09.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu10VideoGames.DropDownItems))		{ var F10 = Forms.OfType<Frm10VideoGames>().Single(); Item.Click += F10.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu11RPS.DropDownItems))				{ var F11 = Forms.OfType<Frm11RPS>().Single(); Item.Click += F11.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu12Hurricane.DropDownItems))		{ var F12 = Forms.OfType<Frm12Hurricane>().Single(); Item.Click += F12.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu13Slots.DropDownItems))			{ var F13 = Forms.OfType<Frm13Slots>().Single(); Item.Click += F13.MenuControl; }
			foreach (ToolStripItem Item in GetAll(mnu16Letters.DropDownItems))			{ var F16 = Forms.OfType<Frm16Letters>().Single(); Item.Click += F16.MenuControl; }
																						{ var F01 = Forms.OfType<Frm01HelloWorld>().Single(); mnuRandomify.Click += F01.MenuControl; }
			foreach (Control c in Controls) { GetAllControls(this); }
			hidden = true;
			MinimumSize = new Size(Math.Min(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, Screen.FromControl(this).Bounds.Width), 500);
			tabMathre.SelectedIndex = tabMathre.TabCount - 2;
		}
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
		public void FormManager(object sender, EventArgs e)
		{
			if (Application.OpenForms.Count > 0 && tabMathre.TabPages.Count > 0)
			{
				foreach (Form form in Application.OpenForms)
				{
					if (form.Name != "Frm00Mathre" && Regex.Replace(form.Name, @"Frm", "tab") != tabMathre.SelectedTab.Name) { form.Hide(); }
					else if (form.Name != "Frm00Mathre") { form.Show(); }
				}
				if (tabMathre.SelectedTab.Name == "tab13Slots") { var F13 = Application.OpenForms.OfType<Frm13Slots>().Single(); F13.Tabbed(null, null); }
			}
		}
		public void MenuItemKeypressHandler(ToolStripMenuItem ToolStripMenuItem)
		{
			foreach (var ToolStripItem in GetAll(ToolStripMenuItem.DropDownItems))
			{
				if (ToolStripItem is ToolStripMenuItem ToolstripItem) { ToolStripMenuItem.DropDown.KeyDown += KeyboardShortcuts; MenuItemKeypressHandler(ToolstripItem); }
			}
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
			if (e.Control & e.KeyCode == Keys.R & mnuSecret.Enabled) { F01.HelloWorld(mnuRandomify, null); }
			if (e.Control & e.Shift & e.KeyCode == Keys.R) { F01.HelloWorld(mnuHelloWorldReset, null); }
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
			if ((string)((Panel)box).Tag == "Black") { BorderColor = Color.Black; }
			if ((string)((Panel)box).Tag == "Transparent") { BorderColor = Color.Transparent; }
			var rect = new Rectangle(0, 0, ((Panel)box).Width, ((Panel)box).Height);
			ControlPaint.DrawBorder(p.Graphics, rect, BorderColor, ButtonBorderStyle.Solid);
			rect.Inflate(-1, -1);
			ControlPaint.DrawBorder(p.Graphics, rect, BorderColor, ButtonBorderStyle.Solid);
		}
		public void Resized(object sender, EventArgs e)
		{
			FormSize.Width = Width - 16;
			FormSize.Height = Height - 84;
			foreach (Form form in Application.OpenForms) { if (form.Visible && form.Name != "Frm00Mathre") { form.Size = FormSize; } }
		}
	}
}