// SOURCES:  https://github.com/fferlito/Cat-faces-dataset
using Mathre.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm18Humane : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		public static Frm18Humane ThisForm;
		int n = 1;
		readonly Random rnd = new();
		readonly System.Timers.Timer aTimer = new(2000);
		public Frm18Humane()
		{
			InitializeComponent();
			Load += FormLoad;
			aTimer.Elapsed += Images;
			foreach (Panel pnl in pnlBody2.Controls.OfType<Panel>()) { foreach (PictureBox pb in pnl.Controls.OfType<PictureBox>()) { pb.LoadCompleted += Catname; } }
			btnTimerToggle.Click += (p, e) => { aTimer.Enabled = !aTimer.Enabled; };
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			ThisForm = Application.OpenForms.OfType<Frm18Humane>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
			var loopfour = 1;
			while (loopfour < 5)
			{
				int num = rnd.Next(0, 500);
				((Label)Controls.Find($"lblCat{loopfour}", true)[0]).Text = File.ReadLines($"{Path.GetFullPath(@"..\..\")}\\Resources\\PetNames.txt").ElementAt(num);
				((PictureBox)Controls.Find($"picCat{loopfour}", true)[0]).Image = Image.FromFile($"{Path.GetFullPath(@"..\..\")}\\Resources\\CatPictures\\cat_{num}.png");
				loopfour++;
			}
		}
		public void Tabbed(bool enable) { aTimer.Enabled = enable; }
		public void MenuControl(object sender, EventArgs e)
		{
			var senderName = ((ToolStripMenuItem)sender).Name;
			Action a = senderName.Substring(0, 3) switch
			{
				"btn" => () => ((Button)Controls.Find(senderName, true)[0]).PerformClick(),
				"rad" => () => ((RadioButton)Controls.Find(senderName, true)[0]).PerformClick(),
				"chb" => () => ((CheckBox)Controls.Find(senderName, true)[0]).Checked ^= true,
				_ => null,
			};
			a?.Invoke();
		}
		public void Images(object sender, EventArgs e) { ((PictureBox)Controls.Find($"picCat{n}", true)[0]).LoadAsync(@"https://thiscatdoesnotexist.com/"); }
		public void Catname(object sender, EventArgs e)
		{
			int num = rnd.Next(0, 500);
			ThisForm.Invoke(new MethodInvoker(delegate ()
			{
				if (((PictureBox)Controls.Find($"picCat{n}", true)[0]).Image == ((PictureBox)Controls.Find($"picCat{n}", true)[0]).ErrorImage)
				{
					((PictureBox)Controls.Find($"picCat{n}", true)[0]).Image = Image.FromFile($"{Path.GetFullPath(@"..\..\")}\\Resources\\CatPictures\\cat_{num}.png");
				}
				((Label)Controls.Find($"lblCat{n++}", true)[0]).Text = File.ReadLines($"{Path.GetFullPath(@"..\..\")}\\Resources\\PetNames.txt").ElementAt(num);
			}));
			if (n > 4) n = 1;
		}
		public void Default(object sender, EventArgs e)
		{

		}
	}
}