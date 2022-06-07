using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm24aInvaders : Form
	{
		static readonly Frm24bInvaders F24b = new();
		public Frm24aInvaders()
		{
			InitializeComponent();
			Shown += Default;
			VisibleChanged += (p, e) => Frm24bInvaders.tmrMain.Enabled = Visible;
		}
		public void Default(object sender, EventArgs e)
		{
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