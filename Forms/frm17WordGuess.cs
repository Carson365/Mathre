﻿using Mathre.Forms;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm17WordGuess : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		string abc = "";
		public Frm17WordGuess()
		{
			InitializeComponent();
			Load += FormLoad;
			txtP1.TextChanged += Default;
			txtP1.KeyDown += (p, e) => { if (txtP1.Text.Length > 15 && e.KeyCode != Keys.Back) { e.SuppressKeyPress = true; } };
			txtP2.TextChanged += Default;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e) { var ThisForm = Application.OpenForms.OfType<FrmTemplate>().Single(); ThisForm.Default(sender, e); }
		public void Default(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, txtP1))
			{
				abc = ""; for (int i = 0; i <= txtP1.Text.Length - 1; i++) { abc += Regex.Replace($"{txtP1.Text[i]}", @"\S", "_"); }
				lblPhrase.Text = Regex.Replace(Regex.Replace($"{abc}", "  ", "   "), "_", " _");
			}
			if (ReferenceEquals(sender, txtP2))
			{
				for (int i = 0; i <= txtP1.Text.Length - 1; i++)
				{
					if ($"{txtP1.Text[i]}".ToLower() == txtP2.Text.ToLower())
					{
						abc = abc.Remove(i, 1);
						abc = abc.Insert(i, $"{txtP1.Text[i]}");
					}
					Console.WriteLine($"{txtP1.Text[i]}");
				}
				lblPhrase.Text = Regex.Replace(Regex.Replace(Regex.Replace($"{abc}", "  ", "   "), "_", " _"), @"_(\w)", @"_ $1");
				txtP2.Text = "";
			}
		}
	}
}