using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmRectangle : Form
	{
		public static FrmMathre main;
		public static FrmRectangle RC;
		public FrmRectangle()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			RC = Application.OpenForms.OfType<FrmRectangle>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
	}
}