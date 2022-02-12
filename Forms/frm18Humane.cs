// SOURCES:  https://github.com/fferlito/Cat-faces-dataset
using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm18Humane : Form
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
			btnKeep1.Click += Keep;
			btnKeep2.Click += Keep;
			btnKeep3.Click += Keep;
			btnKeep4.Click += Keep;
			foreach (Panel pnl in pnlBody2.Controls.OfType<Panel>()) { foreach (PictureBox pb in pnl.Controls.OfType<PictureBox>()) { pb.LoadCompleted += Catname; } }
			btnTimerToggle.Click += (p, e) => { aTimer.Enabled = !aTimer.Enabled; };
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			ThisForm = Application.OpenForms.OfType<Frm18Humane>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
			lblCatSave.Text = "";
			pnlPictureSave.Visible = false;
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
		public void Keep(object sender, EventArgs e)
		{
			SystemSounds.Exclamation.Play();
			Image img = ((PictureBox)Controls.Find($"picCat{$"{((Button)sender).Name}".Substring(7, 1)}", true)[0]).Image;
			string name = ((Label)Controls.Find($"lblCat{$"{((Button)sender).Name}".Substring(7, 1)}", true)[0]).Text;
			lblCatSave.Text = "";
			while (lblCatSave.Text == "")
			{
				lblCatSave.Text = Interaction.InputBox("What would you like to name this cat?\n(At most 8 letters)", "Humane Society", name).ToUpper();
				if (lblCatSave.Text.Length > 8) { lblCatSave.Text = lblCatSave.Text.Substring(0, 8); SystemSounds.Asterisk.Play(); }
			}
			pnlPictureSave.Visible = true;
			picCatSave.Image = img;
		}
	}
}