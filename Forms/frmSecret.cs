using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmSecret : Form
	{
		public static FrmMathre main;
		public static FrmSecret SS;
		public FrmSecret()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			SS = Application.OpenForms.OfType<FrmSecret>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
	}
}