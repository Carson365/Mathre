using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm25aTurtle : Form
	{
		Frm24bInvaders F25b; //F25b
		public Frm25aTurtle()
		{
			InitializeComponent();
			F25b = new();
			Shown += Default;
			//VisibleChanged += (p, e) => F25b.tmrMain.Enabled = Visible;
		}
		public void Default(object sender, EventArgs e)
		{
			F25b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			F25b.FormBorderStyle = FormBorderStyle.None;
			F25b.Left = 2;
			F25b.Top = 2;
			F25b.TopLevel = false;
			F25b.Visible = true;
			F25b.Size = new System.Drawing.Size(pnlBody.Width - 4, pnlBody.Height - 4);
			pnlBody.Controls.Add(F25b);
		}
	}
}