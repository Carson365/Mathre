using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmChange : Form
	{
		public static FrmMathre main;
		public static FrmChange CM;
		public FrmChange()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			CM = Application.OpenForms.OfType<FrmChange>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
	}
}