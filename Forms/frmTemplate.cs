using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmTemplate : Form
	{
		public static Frm00Mathre BaseForm;
		public FrmTemplate()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void Default(object sender, EventArgs e)
		{
		}
	}
}