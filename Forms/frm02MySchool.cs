// RoughRiders mascot image sourced from https://www.gfschools.org/cms/lib/ND02203034/Centricity/Template/GlobalAssets/images///logos/Red%20River%20HS.png
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmMySchool : Form
	{
		private FrmMathre BaseForm;
		private FrmMySchool ThisForm;
		public FrmMySchool()
		{
			InitializeComponent();
			btnMySchoolToggleMascot.Click += MySchool;
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmMySchool>().Single();
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
