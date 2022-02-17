using Microsoft.VisualBasic;
using System;
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
			btnCreate.Click += Acronym;
		}
		public void Acronym(object sender, EventArgs e)
		{
			string Acronym = "";
			double Words = 0;
			int RunCount = 1;
			while (Words == 0)
			{
				string WordCount = Interaction.InputBox("How many words in the acronym?\nAt most 10 words can be acronymized.", "Acronym Maker", "");
				if (double.TryParse(WordCount, out double WordResult)) { Words = WordResult switch { < 10 => WordResult, _ => 10 }; }
			}
			while (Words != 0)
			{
				string Place;
				int DivNum = RunCount switch { < 31 => 20, _ => 10, };
				Place = (RunCount % DivNum) switch
				{
					1 => "st",
					2 => "nd",
					3 => "rd",
					_ => "th",
				};
				string NextWord = "";
				while (NextWord == "") { NextWord = Interaction.InputBox($"What is the {RunCount}{Place} Word?", "Acronym Maker", ""); }
				Acronym = $"{Acronym}{NextWord[0]}".ToUpper();
				Words--;
				RunCount++;
			}
			lblAcronym.Text = Acronym;
		}
	}
}