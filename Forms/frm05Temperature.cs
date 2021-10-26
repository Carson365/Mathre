using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmTemperature : Form
	{
		public static FrmMathre main;
		public static FrmTemperature TC;
		public FrmTemperature()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			TC = Application.OpenForms.OfType<FrmTemperature>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
	}
}