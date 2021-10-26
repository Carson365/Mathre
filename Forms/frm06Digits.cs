using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmDigits : Form
	{
		public static FrmMathre main;
		public static FrmDigits DS;
		public FrmDigits()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			DS = Application.OpenForms.OfType<FrmDigits>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
	}
}