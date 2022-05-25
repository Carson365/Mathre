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
		public Frm02MySchool()
		{
			InitializeComponent();
			btnMySchoolToggleMascot.Click += MySchool;
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
		}
		public void MySchool(object sender, EventArgs e)
		{
			picMySchoolMascot.Visible ^= true;
			lblMySchoolMascot.ForeColor = $"{lblMySchoolMascot.ForeColor}" switch { "Color [Black]" => BaseForm.Dark ? Color.LightGray : Color.DimGray, _ => Color.Black };
		}
	}
}