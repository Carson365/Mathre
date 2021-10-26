using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmMySchool : Form
	{
		public static FrmMathre main;
		public static FrmMySchool MS;
		public FrmMySchool()
		{
			InitializeComponent();
			btnMySchoolToggleMascot.Click += MySchool;
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			MS = Application.OpenForms.OfType<FrmMySchool>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
		public void MySchool(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, btnMySchoolToggleMascot) | ReferenceEquals(sender, main.mnuMySchoolToggleMascot)) // If the event is caused by the ToggleMascot button or menu item:
			{
				MS.picMySchoolMascot.Visible = !MS.picMySchoolMascot.Visible; // Inverts the visibility of the mascot image
				if (MS.lblMySchoolMascot.ForeColor != Color.Black) // Inverts the text color
				{
					MS.lblMySchoolMascot.ForeColor = Color.Black;
				}
				else
				{
					MS.lblMySchoolMascot.ForeColor = Color.DimGray;
				}
			}
		}
	}
}
