﻿// SOURCES:  https://github.com/fferlito/Cat-faces-dataset
using Mathre.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm18Humane : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		public static Frm18Humane ThisForm;
		int n = 1;
		readonly System.Timers.Timer aTimer = new(1500);
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
			aTimer.Enabled = true;
		}
		public void MenuControl(object sender, EventArgs e) { var ThisForm = Application.OpenForms.OfType<Frm18Humane>().Single(); ThisForm.MenuHandler(sender, e); }
		public void MenuHandler(object sender, EventArgs e) { ((Button)Controls[$"btn{sender}"]).PerformClick(); }
		public void Images(object sender, EventArgs e) { ((PictureBox)Controls.Find($"picCat{n}", true)[0]).LoadAsync(@"https://thiscatdoesnotexist.com/"); }
		public void Catname(object sender, EventArgs e)
		{
			Random rnd = new(); int choice = rnd.Next(0, 211);
			ThisForm.Invoke(new MethodInvoker(delegate () {
				if (((PictureBox)Controls.Find($"picCat{n}", true)[0]).Image == ((PictureBox)Controls.Find($"picCat{n}", true)[0]).ErrorImage)
				{
					Random rnd = new(); int num = rnd.Next(0, 500);
					((PictureBox)Controls.Find($"picCat{n}", true)[0]).Image = Image.FromFile($"{Path.GetFullPath(@"..\..\")}\\Resources\\CatPictures\\cat_{num}.png");
				}
				((Label)Controls.Find($"lblCat{n++}", true)[0]).Text = File.ReadLines($"{Path.GetFullPath(@"..\..\")}\\Resources\\PetNames.txt").ElementAt(choice);
			}));
			if (n > 4) n = 1;
		}
		public void Default(object sender, EventArgs e)
		{

		}
	}
}