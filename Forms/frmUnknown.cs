using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmUnknown : Form
	{
		public static Frm00Mathre BaseForm;
		public static FrmUnknown ThisForm;
		public FrmUnknown()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmUnknown>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
	}
}
