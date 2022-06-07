using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm25aTurtle : Form
	{
		static readonly Frm25bTurtle F25b = new();
		public Frm25aTurtle()
		{
			InitializeComponent();
			Shown += Default;
			VisibleChanged += (p, e) => Frm25bTurtle.tmrMain.Enabled = Visible;
		}
		public void Default(object sender, EventArgs e)
		{
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