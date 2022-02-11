using Mathre.Forms;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm16Letters : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		public Frm16Letters()
		{
			InitializeComponent();
			Load += FormLoad;
			btnSearch.Click += Search;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e)
		{
			Action a = $"{((ToolStripMenuItem)sender).Name}".Substring(0, 3) switch
			{
				"btn" => () => ((Button)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).PerformClick(),
				"rad" => () => ((RadioButton)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).PerformClick(),
				"chb" => () => ((CheckBox)Controls.Find($"{((ToolStripMenuItem)sender).Name}", true)[0]).Checked ^= true,
				_ => null,
			};
			a?.Invoke();
		}
		public void Search(object sender, EventArgs e)
		{
			lblSearch.Text = Interaction.InputBox("What is the word or phrase to search?", "Letter Counter", "");
			lblFind.Text = $"{Interaction.InputBox("What is the character to search for?\nOnly the first character will be searched", "Letter Counter", "").FirstOrDefault()}";
			int count = 0;
			foreach (char c in lblSearch.Text) { if ($"{c}".ToLower() == $"{lblFind.Text}".ToLower()) { count++; } }
			lblOccurrances.Text = count.ToString();
		}
	}
}
