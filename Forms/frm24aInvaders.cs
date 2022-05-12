using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm24cInvaders : Form
	{
		int Loading = 4;
		public Frm24cInvaders()
		{
			InitializeComponent();
			Shown += Default;
			VisibleChanged += (p,e) => { if (Loading > 0) Loading--; else FormManager(); } ;
		}
		public void Default(object sender, EventArgs e)
		{
			Form F24b = Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().DefinedTypes.Where(t => t.Name == "Frm24bInvaders").SingleOrDefault()) as Form;
			F24b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			F24b.FormBorderStyle = FormBorderStyle.None;
			F24b.Left = 2;
			F24b.Top = 2;
			F24b.TopLevel = false;
			F24b.Visible = true;
			F24b.Size = new System.Drawing.Size(pnlBody.Width - 4, pnlBody.Height - 4);
			pnlBody.Controls.Add(F24b);
			F24b.Focus();
		}
		public void FormManager()
		{
			var F24b = Application.OpenForms.OfType<Frm24bInvaders>().SingleOrDefault();
			F24b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			F24b.FormBorderStyle = FormBorderStyle.None;
			F24b.Left = 2;
			F24b.Top = 2;
			F24b.TopLevel = false;
			F24b.Visible = true;
			F24b.Size = new System.Drawing.Size(pnlBody.Width - 4, pnlBody.Height - 4);
			pnlBody.Controls.Add(F24b);
			F24b.Focus();
		}
	}
}