using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmMyFavorites : Form
	{
		public static FrmMathre main;
		public static FrmMyFavorites MF;
		public FrmMyFavorites()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			MF = Application.OpenForms.OfType<FrmMyFavorites>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
	}
}