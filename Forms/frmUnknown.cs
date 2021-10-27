using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmUnknown : Form
	{
		public static FrmMathre BaseForm;
		public static FrmUnknown ThisForm;
		public FrmUnknown()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmUnknown>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void NumericalKeypress(object sender, KeyPressEventArgs e)
		{
			if (sender is not TextBoxBase)
				return;
			if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				e.Handled = true;
			}
		}
	}
}
