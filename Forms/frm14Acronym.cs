using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm14Acronym : Form
	{
		public static Frm00Mathre BaseForm;
		public static Frm14Acronym ThisForm;
		public Frm14Acronym()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			ThisForm = Application.OpenForms.OfType<Frm14Acronym>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Tabbed(object sender, EventArgs e)
		{
			// This could be combined into 'Loaded' but it would require "ThisForm' distinctions before every local object in 'Loaded'
			ThisForm.Loaded(null, null);
		}
		public void Loaded(object sender, EventArgs e)
		{
			string Acronym = "";
			double Words = 0;
			int RunCount = 1;
			while (Words == 0) // Keep displaying the message box if a valid count isn't entered
			{
				string WordCount = Interaction.InputBox("How many words in the acronym?", "Acronym Maker", "");
				if (double.TryParse(WordCount, out double WordResult))
				{
					Words = WordResult;
				}
			}
			while (Words != 0)
			{
				string Place;
				int DivNum = RunCount switch
				{
					< 31 => 20,
					_ => 10,
				};
				Place = (RunCount % DivNum) switch
				{
					1 => "st",
					2 => "nd",
					3 => "rd",
					_ => "th",
				};
				string NextWord = "";
				while (NextWord == "") // Keep displaying the message box if a valid word isn't entered
				{
					NextWord = Interaction.InputBox($"What is the {RunCount}{Place} Word?", "Acronym Maker", "");
				}
				Acronym = $"{Acronym}{NextWord[0]}".ToUpper();
				Words--;
				RunCount++;
			}
			lblAcronym.Text = Acronym;
		}
	}
}