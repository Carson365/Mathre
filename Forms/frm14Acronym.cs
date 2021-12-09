using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmAcronym : Form
	{
		public static FrmMathre BaseForm;
		public static FrmAcronym ThisForm;
		public FrmAcronym()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmAcronym>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
	}
}
