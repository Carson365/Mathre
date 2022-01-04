using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Mathre
{
	public partial class Frm00Mathre : Form
	{
		private string AccentColor;
		private static Color SystemColor;
		private bool hidden;
		private Size FormSize;
		public Frm00Mathre()
		{
			InitializeComponent();
			Frm01HelloWorld HW = new();
			Frm02MySchool MS = new();
			Frm05Temperature TC = new();
			Frm10VideoGames VG = new();
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
			Resize += Resized;
			tabMathre.SelectedIndexChanged += FormManager;
			mnuPS4.Click += VG.Transfer;
			mnuXB1.Click += VG.Transfer;
			Shown += LoadEvent;
		}
		public void LoadEvent(object sender, EventArgs e)
		{
			//
			tabMathre.TabPages.Clear();
			Type formType = typeof(Form);
			foreach (Type type in Assembly.GetExecutingAssembly().GetTypes().OrderBy(x => x.Name))
			{
				if (formType.IsAssignableFrom(type))
				{
					if ($"{type.Name}" != "Frm00Mathre")
					{
						var form = Activator.CreateInstance(Type.GetType($"{type}")) as Form;
						form.Size = FormSize;
						form.FormBorderStyle = FormBorderStyle.None;
						form.Left = 0;
						form.Top = 45;
						form.TopLevel = false;
						form.Visible = true;
						this.Controls.Add(form);
						form.Focus();
						Resized(null, null);
						TabPage abc = new();
						abc.Name = $"{Regex.Replace(form.Name, @"Frm\d*", "tab")}";
						abc.Text = $"{form.Text}";
						tabMathre.TabPages.Add(abc);
					}
					}
				}
			//
			hidden = true;
			mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
			AccentColor = $"{(ColorKey.GetValue("AccentColor"))}";
			ColorKey.Close();
			KeyPreview = true;
			SystemColor = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
			foreach (var ToolStripMenuItem in mnuBaseLayer.Items)
			{
				AddMenuItemHandlers((ToolStripMenuItem)ToolStripMenuItem);
			}
			foreach (ToolStripItem Item in mnuFavorites.DropDownItems)
			{
				Frm04MyFavorites MF = new();
				Item.Click += MF.Favorites;
			}
			foreach (ToolStripItem Item in mnuGrade.DropDownItems)
			{
				Frm09Grade GC = new();
				Item.Click += GC.ButtonSelector;
			}
			foreach (ToolStripItem Item in mnuPizza.DropDownItems)
			{
				Frm08Pizza PD = new();
				Item.Click += PD.Pizza;
			}
			foreach (Control c in Controls)
			{
				GetAllControls(this);
			}
			foreach (ToolStripItem Item in mnuRPS.DropDownItems)
			{
				Frm11RPS RG = new();
				Item.Click += RG.MenuHandler;
			}
			foreach (ToolStripItem Item in mnuHurricane.DropDownItems)
			{
				Frm12Hurricane HC = new();
				Item.Click += HC.MenuHandler;
			}
			foreach (ToolStripItem Item in mnuSlots.DropDownItems)
			{
				Frm13Slots SM = new();
				Item.Click += SM.MenuHandler;
			}
			tabMathre.TabPages.Remove(tabSecret);
			//
			// Old Tab saved by name
			//
			foreach (TabPage c in tabMathre.TabPages)
			{
				ToolStripMenuItem item = new();
				item.Name = c.Name.ToString().Replace("tab", "mnuView");
				item.Text = c.Text.ToString();
				item.Click += new EventHandler(PageSelect);
				mnuView.DropDownItems.Add(item);
			}
			MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, 500);
			tabMathre.SelectedIndex = tabMathre.TabCount - 2;
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
		public void FormManager(object sender, EventArgs e)
		{
			if (Application.OpenForms.Count > 0 && tabMathre.TabPages.Count > 0)
			{
				for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
				{
					Console.WriteLine(Application.OpenForms[i].Name);
					if (Application.OpenForms[i].Name != "Frm00Mathre" && Regex.Replace(Application.OpenForms[i].Name, @"Frm\d*", "tab") != tabMathre.SelectedTab.Name)
					{
						Application.OpenForms[i].Hide();
					}
					else if (Application.OpenForms[i].Name != "Frm00Mathre")
					{
						Application.OpenForms[i].Show();
					}
				}
				if (tabMathre.SelectedTab.Name.Replace("tab", "frm") == "frmSlots")
				{
					// Slots MessageBox code
					Frm13Slots SM = new();
					SM.Tabbed(null, null);
				}
				if (tabMathre.SelectedTab.Name.Replace("tab", "frm") == "frmAcronym")
				{
					// Slots MessageBox code
					Frm14Acronym AM = new();
					AM.Tabbed(null, null);
				}
			}
		}
		public void PageSelect(object sender, EventArgs e)
		{
			tabMathre.SelectTab((sender as ToolStripMenuItem).Name.ToString().Replace("mnuView", "tab"));
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
		public void KeyboardShortcuts(object sender, KeyEventArgs e)
		{
			Frm01HelloWorld HW = new();
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
			if (e.Control & e.KeyCode == Keys.R & mnuSecret.Enabled)
			{
				HW.HelloWorld(mnuRandomify, null);
			}
			if (e.Control & e.Shift & e.KeyCode == Keys.R)
			{
				HW.HelloWorld(mnuHelloWorldReset, null);
			}
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode >= Keys.D1 & e.KeyCode <= Keys.D8))
			{
				tabMathre.SelectedTab = tabMathre.TabPages[e.KeyCode - Keys.D1];
			}
			if (e.Control & (e.KeyCode - Keys.D0 <= tabMathre.TabCount & e.KeyCode == Keys.D9))
			{
				tabMathre.SelectedTab = tabMathre.TabPages[tabMathre.TabCount - 1];
			}
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
			Color BorderColor = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
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
