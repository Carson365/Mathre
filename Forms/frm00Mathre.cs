using System;
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
			Frm01HelloWorld HW = new();
			Frm02MySchool MS = new();
			Frm05Temperature TC = new();
			Frm10VideoGames VG = new();
			KeyDown += KeyboardShortcuts;
			mnuExit.Click += (s, e) => { Close(); };
			mnuMySchoolToggleMascot.Click += MS.MySchool;
			mnuHelloWorldReset.Click += HW.HelloWorld;
			mnuHelloWorldLanguageGerman.Click += HW.HelloWorld;
			mnuHelloWorldLanguageFrench.Click += HW.HelloWorld;
			mnuHelloWorldLanguageEnglish.Click += HW.HelloWorld;
			mnuRandomify.Click += HW.HelloWorld;
			mnuTemperatureFahrenheit.Click += TC.Temperature;
			mnuTemperatureCelsius.Click += TC.Temperature;
			//ResizeEnd += Resized;
			//ResizeBegin += Resized;
			Resize += Resized;
			tabMathre.SelectedIndexChanged += FormManager;
			mnuPS4.Click += VG.Transfer;
			mnuXB1.Click += VG.Transfer;
			Shown += LoadEvent;
			//ResizeBegin += (s, e) => { SuspendLayout(); };
			//ResizeEnd += (s, e) => { ResumeLayout(); };
		}
		public void LoadEvent(object sender, EventArgs e)
		{
			foreach (Type type in Assembly.GetExecutingAssembly().GetTypes().OrderBy(x => x.Name).Where(t => (typeof(Form).IsAssignableFrom(t)) && t.IsClass && t.FullName.StartsWith("Mathre.") && t.Name != "Frm00Mathre"))
			{
				var form = Activator.CreateInstance(Type.GetType($"{type}")) as Form;
				form.Size = FormSize;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Left = 0;
				form.Top = 45;
				form.TopLevel = false;
				form.Visible = true;
				//form.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
				Controls.Add(form);
				form.Focus();
				form.Width = Width - 16;
				form.Height = Height - 84;
				TabPage newTab = new();
				newTab.Name = $"{Regex.Replace(form.Name, @"Frm\d*", "tab")}";
				newTab.Text = $"{form.Text}";
				if (newTab.Name == "tabSecret")
				{
					Secret = newTab;
					tabMathre.TabPages.Remove(Secret);
				}
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
			//
			//Type formType = typeof(Form);
			//foreach (Type type in Assembly.GetExecutingAssembly().GetTypes().OrderBy(x => x.Name))
			//{
			//	if (formType.IsAssignableFrom(type))
			//	{
			//		if ($"{type.Name}" != "Frm00Mathre")
			//		{
			//			var form = Activator.CreateInstance(Type.GetType($"{type}")) as Form;
			//			form.Size = FormSize;
			//			form.FormBorderStyle = FormBorderStyle.None;
			//			form.Left = 0;
			//			form.Top = 45;
			//			form.TopLevel = false;
			//			form.Visible = true;
			//			//form.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
			//			Controls.Add(form);
			//			form.Focus();
			//			form.Width = Width - 16;
			//			form.Height = Height - 84;
			//			TabPage newTab = new();
			//			newTab.Name = $"{Regex.Replace(form.Name, @"Frm\d*", "tab")}";
			//			newTab.Text = $"{form.Text}";
			//			if (newTab.Name == "tabSecret")
			//			{
			//				Secret = newTab;
			//				tabMathre.TabPages.Remove(Secret);
			//			}
			//			else
			//			{
			//				tabMathre.TabPages.Add(newTab);
			//				ToolStripMenuItem item = new();
			//				item.Name = newTab.Name.ToString().Replace("tab", "mnuView");
			//				item.Text = newTab.Text.ToString();
			//				item.Click += new EventHandler((sender, e) => { tabMathre.SelectTab((sender as ToolStripMenuItem).Name.ToString().Replace("mnuView", "tab")); });
			//				mnuView.DropDownItems.Add(item);
			//			}
			//}
			//}
			//}
			//
			mnuBaseLayer.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
			var ColorKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
			AccentColor = $"{(ColorKey.GetValue("AccentColor"))}";
			ColorKey.Close();
			KeyPreview = true;
			SystemColor = ColorTranslator.FromWin32(Convert.ToInt32(AccentColor));
			//
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
			//
			hidden = true;
			MinimumSize = new Size(Math.Min(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, Screen.FromControl(this).Bounds.Width), 500);
			tabMathre.SelectedIndex = tabMathre.TabCount - 2;
		}
		public void GetAllControls(Control container)
		{
			foreach (Control b in container.Controls)
			{
				GetAllControls(b);
				if ((b is Panel) && (b is not TabPage) && b.Name != "pnlFrame")
				{
					b.Paint += PaintPanel;
				}
			}
		}
		public void FormManager(object sender, EventArgs e)
		{
			if (Application.OpenForms.Count > 0 && tabMathre.TabPages.Count > 0)
			{
				foreach (Form form in Application.OpenForms)
				{
					if (form.Name != "Frm00Mathre" && Regex.Replace(form.Name, @"Frm\d*", "tab") != tabMathre.SelectedTab.Name)
					{
						form.Hide();
						//form.SuspendLayout();
					}
					else if (form.Name != "Frm00Mathre")
					{
						form.Show();
						//form.ResumeLayout();
					}
				}



				//for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
				//{
				//	//

				//		Console.WriteLine(Regex.Replace(Application.OpenForms[i].Name, @"Frm\d*", "tab"));
				//		Console.WriteLine(tabMathre.SelectedTab.Name);

				//	//
				//	if (Application.OpenForms[i].Name != "Frm00Mathre" && Regex.Replace(Application.OpenForms[i].Name, @"Frm\d*", "tab") != tabMathre.SelectedTab.Name)
				//	{
				//		Application.OpenForms[i].Hide();
				//		Application.OpenForms[i].SuspendLayout();
				//	}
				//	else if (Application.OpenForms[i].Name != "Frm00Mathre")
				//	{
				//		Application.OpenForms[i].Show();
				//		Application.OpenForms[i].ResumeLayout();
				//	}
				//}
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
					tabMathre.Controls.Add(Secret);

					MinimumSize = new Size(tabMathre.GetTabRect(tabMathre.TabCount - 2).Right + tabMathre.GetTabRect(tabMathre.TabCount - 1).Width + 17, 500);
					tabMathre.SelectedTab = Secret;
					hidden = false;
				}
				else if (hidden == false)
				{
					tabMathre.Controls.Remove(Secret);
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
			//if (Application.OpenForms.Count > 0 && tabMathre.TabPages.Count > 0)
			//{
			//	if (FormSize.Width > Screen.FromControl(this).Bounds.Width - 200)
			//	{
			//		MaximumSize = new Size(Screen.FromControl(this).Bounds.Width - 100, 100000);
			//	}
			//	else
			//	{
			//		MinimumSize = new Size(Math.Min(tabMathre.GetTabRect(tabMathre.TabCount - 1).Right + 17, Screen.FromControl(this).Bounds.Width), 500);
			//		MaximumSize = new Size(100000, 100000);
			//	}
			//}
			//
			//
			//
			//
			FormSize.Width = Width - 16;
			FormSize.Height = Height - 84;
			foreach (Form form in Application.OpenForms)
			{
				if (form.Visible && form.Name != "Frm00Mathre")
				{
					form.Size = FormSize;
				}
			}
		}
	}
}
