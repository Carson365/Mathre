using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm24aInvaders : Form
	{
		readonly Frm24bInvaders F24b;
		public Frm24aInvaders()
		{
			InitializeComponent();
			F24b = new();
			Shown += Default;
			VisibleChanged += (p, e) => F24b.tmrMain.Enabled = Visible;
		}
		public void Default(object sender, EventArgs e)
		{
			F24b.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			F24b.FormBorderStyle = FormBorderStyle.None;
			F24b.Left = 2;
			F24b.Top = 2;
			F24b.TopLevel = false;
			F24b.Visible = true;
			F24b.Size = new System.Drawing.Size(pnlBody.Width - 4, pnlBody.Height - 4);
			pnlBody.Controls.Add(F24b);
		}
	}
}