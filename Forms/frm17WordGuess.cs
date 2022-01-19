using Mathre.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm17WordGuess : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		public Frm17WordGuess()
		{
			InitializeComponent();
			Load += FormLoad;
			txtP1.TextChanged += Default;
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
			//  Get the string to guess from
			//  set the label with the corresponding amount of blanks
			// get the character for the guess
			// check the character against the string using a loop for each letter in the string that captures the letter's index
			// set the letter in the guess label at the corresponding index to the character that matched
			//
			//
			//
			if (ReferenceEquals(sender, txtP1))
			{
				string abc = new string('_', txtP1.Text.Replace(" ", "").Length).Replace("_", "_ ").Insert(0, "a");
				for (int i = txtP1.Text.Length - 1; i >= 0; i--)
				{
					if (txtP1.Text[i] == ' ')
					{
						abc.Remove(2 * i -1);
						abc.Insert(2 * i -1, " ");
					}
				}
				lblPhrase.Text = $"{abc}";
			}

		}
	}
}