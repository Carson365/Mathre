using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmHurricane : Form
	{
		public static FrmMathre BaseForm;
		public static FrmHurricane ThisForm;
		public FrmHurricane()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmHurricane>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}

	}
}