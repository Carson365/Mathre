using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmPizza : Form
	{
		public static FrmMathre main;
		public static FrmPizza PD;
		public FrmPizza()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			PD = Application.OpenForms.OfType<FrmPizza>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
	}
}
