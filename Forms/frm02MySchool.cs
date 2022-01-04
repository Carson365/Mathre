// SOURCES:
// Mascot: https://www.gfschools.org/cms/lib/ND02203034/Centricity/Template/GlobalAssets/images///logos/Red%20River%20HS.png
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm02MySchool : Form
	{
		public static Frm00Mathre BaseForm;
		public static Frm02MySchool ThisForm;
		public Frm02MySchool()
		{
			InitializeComponent();
			btnMySchoolToggleMascot.Click += MySchool;
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			ThisForm = Application.OpenForms.OfType<Frm02MySchool>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void MySchool(object sender, EventArgs e)
		{
			if (ReferenceEquals(sender, btnMySchoolToggleMascot) | ReferenceEquals(sender, BaseForm.mnuMySchoolToggleMascot))
			{
				ThisForm.picMySchoolMascot.Visible = !ThisForm.picMySchoolMascot.Visible;
				if (ThisForm.lblMySchoolMascot.ForeColor != Color.Black)
				{
					ThisForm.lblMySchoolMascot.ForeColor = Color.Black;
				}
				else
				{
					ThisForm.lblMySchoolMascot.ForeColor = Color.DimGray;
				}
			}
		}
	}
}
