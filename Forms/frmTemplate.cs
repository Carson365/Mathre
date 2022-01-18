using Mathre.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmTemplate : Form, IManager
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
		public void MenuControl(object sender, EventArgs e) { var ThisForm = Application.OpenForms.OfType<FrmTemplate>().Single(); ThisForm.Default(sender, e); }
		public void Default(object sender, EventArgs e)
		{
		}
	}
}