using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm19bSecretMessage : Form
	{
		public static Frm00Mathre BaseForm;
		public Frm19bSecretMessage()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			Icon = Resources.Icon;
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void Default(object sender, EventArgs e)
		{
		}
	}
}