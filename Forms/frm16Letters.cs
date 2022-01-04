using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm16Letters : Form
	{
		public static Frm00Mathre BaseForm;
		public static Frm16Letters ThisForm;
		public Frm16Letters()
		{
			InitializeComponent();
			Load += FormLoad;
			btnSearch.Click += Search;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			ThisForm = Application.OpenForms.OfType<Frm16Letters>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Search(object sender, EventArgs e)
		{
			int count = 0;
			foreach (char c in txtText.Text)
			{
				if ($"{c}" == $"{txtChar}")
				{
					count++;
				}
			}
			lblSearchedText.Text = count.ToString();
		}
	}
}
