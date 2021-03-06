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
		int n = 1;
		readonly static Random rnd = new();
		readonly static System.Timers.Timer aTimer = new(2000);
		int shown = 4;
		public Frm18Humane()
		{
			InitializeComponent();
			Load += FormLoad;
			aTimer.Elapsed += Images;
			btnKeep1.Click += Keep;
			btnKeep2.Click += Keep;
			btnKeep3.Click += Keep;
			btnKeep4.Click += Keep;
			VisibleChanged += (p, e) => { if (shown > 0) shown--; else aTimer.Enabled = Visible; };
			foreach (Panel pnl in pnlBody2.Controls.OfType<Panel>()) { foreach (PictureBox pb in pnl.Controls.OfType<PictureBox>()) { pb.LoadCompleted += Catname; } }
			btnTimerToggle.Click += (p, e) => { aTimer.Enabled = !aTimer.Enabled; };
		}
		public void FormLoad(object sender, EventArgs e)
		{
			lblCatSave.Text = "";
			pnlPictureSave.Visible = false;
			var loopfour = 1;
			while (loopfour < 5)
			{
				int num = rnd.Next(0, 500);
				((Label)Controls.Find($"lblCat{loopfour}", true)[0]).Text = File.ReadLines($"{Path.GetFullPath(@"..\..\..\")}\\Resources\\PetNames.txt").ElementAt(num);
				((PictureBox)Controls.Find($"picCat{loopfour}", true)[0]).Image = Image.FromFile($"{Path.GetFullPath(@"..\..\..\")}\\Resources\\CatPictures\\cat_{num}.png");
				loopfour++;
			}
		}
		public void Images(object sender, EventArgs e) { ((PictureBox)Controls.Find($"picCat{n}", true)[0]).LoadAsync(@"https://thiscatdoesnotexist.com/"); }
		public void Catname(object sender, EventArgs e)
		{
			int num = rnd.Next(0, 500);
			Invoke(new MethodInvoker(delegate ()
			{
				if (((PictureBox)Controls.Find($"picCat{n}", true)[0]).Image == ((PictureBox)Controls.Find($"picCat{n}", true)[0]).ErrorImage)
				{
					((PictureBox)Controls.Find($"picCat{n}", true)[0]).Image = Image.FromFile($"{Path.GetFullPath(@"..\..\..\")}\\Resources\\CatPictures\\cat_{num}.png");
				}
				((Label)Controls.Find($"lblCat{n++}", true)[0]).Text = File.ReadLines($"{Path.GetFullPath(@"..\..\..\")}\\Resources\\PetNames.txt").ElementAt(num);
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
				if (lblCatSave.Text.Length > 8) { lblCatSave.Text = lblCatSave.Text[..8]; SystemSounds.Asterisk.Play(); }
			}
			pnlPictureSave.Visible = true;
			picCatSave.Image = img;
		}
	}
}