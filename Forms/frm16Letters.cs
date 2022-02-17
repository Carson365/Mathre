using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm16Letters : Form
	{
		public Frm16Letters()
		{
			InitializeComponent();
			btnSearch.Click += Search;
		}
		public void Search(object sender, EventArgs e)
		{
			lblSearch.Text = Interaction.InputBox("What is the word or phrase to search?", "Letter Counter", "");
			lblFind.Text = $"{Interaction.InputBox("What is the character to search for?\nOnly the first character will be searched", "Letter Counter", "").FirstOrDefault()}";
			int count = 0;
			foreach (char c in lblSearch.Text) { if ($"{c}".ToLower() == $"{lblFind.Text}".ToLower()) count++; }
			lblOccurrances.Text = count.ToString();
		}
	}
}
