using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmMathre : Form
	{
		public static string AccentColor;
		public static Color SystemColor;
		public static bool hidden;
		public static Size FormSize;
		public FrmMathre()
		{
			InitializeComponent();
			FrmHelloWorld HW = new();
			FrmMySchool MS = new();
			FrmTemperature TC = new();
			FrmVideoGames VG = new();
			Load += FormLoad;
			KeyDown += KeyboardShortcuts;
			mnuExit.Click += Exit;
			mnuMySchoolToggleMascot.Click += MS.MySchool;
			mnuHelloWorldReset.Click += HW.HelloWorld;
			mnuHelloWorldLanguageGerman.Click += HW.HelloWorld;
			mnuHelloWorldLanguageFrench.Click += HW.HelloWorld;
			mnuHelloWorldLanguageEnglish.Click += HW.HelloWorld;
			mnuRandomify.Click += HW.HelloWorld;
			mnuTemperatureFahrenheit.Click += TC.Temperature;
			mnuTemperatureCelsius.Click += TC.Temperature;
			Shown += FormShown;
			Resize += Resized;
			tabMathre.SelectedIndexChanged += FormManager;
			tabMathre.KeyDown += StopArrows;
			mnuPS4.Click += VG.Transfer;
			mnuXB1.Click += VG.Transfer;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			tabMathre.TabPages.Remove(tabSecret);
			hidden = true;
			mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
			AccentColor = Conversions.ToString(ColorKey.GetValue("AccentColor"));
			ColorKey.Close();
			//KeyPreview = true;
			SystemColor = ColorTranslator.FromWin32(Conversions.ToInteger(AccentColor));
			MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, 500);
			foreach (var ToolStripMenuItem in mnuBaseLayer.Items)
			{
				AddMenuItemHandlers((ToolStripMenuItem)ToolStripMenuItem);
			}
			foreach (ToolStripItem Item in mnuFavorites.DropDownItems)
			{
				FrmMyFavorites MF = new();
				Item.Click += MF.Favorites;
			}
			foreach (ToolStripItem Item in mnuGrade.DropDownItems)
			{
				FrmGrade GC = new();
				Item.Click += GC.ButtonSelector;
			}
			foreach (ToolStripItem Item in mnuPizza.DropDownItems)
			{
				FrmPizza PD = new();
				Item.Click += PD.Pizza;
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
		public void AddMenuItemHandlers(ToolStripMenuItem ToolStripMenuItem)
		{
			foreach (var ToolStripItem in ToolStripMenuItem.DropDownItems)
			{
				if (ToolStripItem is ToolStripMenuItem ToolstripItem)
				{
					ToolStripMenuItem.DropDown.KeyDown += KeyboardShortcuts;
					AddMenuItemHandlers(ToolstripItem);
				}
			}
		}
		public void StopArrows(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
			{
				e.Handled = true;
			}
		}
		public void KeyboardShortcuts(object sender, KeyEventArgs e)
		{
			FrmHelloWorld HW = new();
			if (e.Control & e.KeyCode == Keys.S)
			{
				if (hidden == true)
				{
					tabMathre.Controls.Add(tabSecret);
					MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 2).Right + tabMathre.GetTabRect(tabMathre.TabCount - 1).Width + 17, 500);
					tabMathre.SelectedTab = tabSecret;
					hidden = false;
				}
				else if (hidden == false)
				{
					tabMathre.Controls.Remove(tabSecret);
					hidden = true;
				}
				MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, 500);
			}
			//
			if (e.Control & e.KeyCode == Keys.R & mnuSecret.Enabled)
			{
				HW.HelloWorld(mnuRandomify, null);
			}
			// 
			if (e.Control & e.Shift & e.KeyCode == Keys.R)
			{
				HW.HelloWorld(mnuHelloWorldReset, null);
			}
			//
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode >= Keys.D1 & e.KeyCode <= Keys.D8))
			{
				tabMathre.SelectedTab = tabMathre.TabPages[e.KeyCode - Keys.D1];
			}
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode == Keys.D9))
			{
				tabMathre.SelectedTab = tabMathre.TabPages[tabMathre.TabCount - 1];
			}
			if (e.Control & e.KeyCode == Keys.Left)
			{
				if (tabMathre.SelectedIndex > 0)
				{
					tabMathre.SelectedIndex--;
				}
			}
			if (e.Control & e.KeyCode == Keys.Right)
			{
				if (tabMathre.SelectedIndex < tabMathre.TabCount - 1)
				{
					tabMathre.SelectedIndex++;
				}
			}
		}
		public void PageSelect(object sender, EventArgs e)
		{
			tabMathre.SelectTab((sender as ToolStripMenuItem).Name.ToString().Replace("mnuView", "tab"));
		}
		public class MenuColorTable : ProfessionalColorTable
		{
			public override Color MenuItemBorder
			{
				get
				{
					return SystemColor;
				}
			}
			public override Color MenuItemSelected
			{
				get
				{
					return SystemColor;
				}
			}
			public override Color MenuBorder
			{
				get
				{
					return SystemColor;
				}
			}
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
