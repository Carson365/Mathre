using Mathre.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmUnknown : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		public FrmUnknown()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e) { throw new NotImplementedException(); }
	}
}
