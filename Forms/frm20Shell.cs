using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm20Shell : Form
	{
		public Frm20Shell()
		{
			InitializeComponent();
			picShell1.Click += Default;
			picShell2.Click += Default;
			picShell3.Click += Default;
			foreach (Control b in pnlBody.Controls) if (b.GetType() == typeof(PictureBox) && b.Name.Contains("Pearl")) b.Visible = false;
		}
		public void Default(object sender, EventArgs e)
		{
			string wonlost = "lost";
			Random rnd = new();
			int rnum = rnd.Next(1, 4);
			PictureBox pb = sender as PictureBox;
			if (pb.Name[8] == $"{rnum}"[0])
			{
				foreach (Control b in pnlBody.Controls) if (b.GetType() == typeof(PictureBox) && b.Name.Contains("Pearl") && b.Name[8] == $"{rnum}"[0])
					{ b.Visible = true; wonlost = "won"; lblWins.Text = $"{Convert.ToInt32(lblWins.Text) + 1}"; }
			}
			MessageBox.Show($"You have {wonlost}.", "Results");
			foreach (Control b in pnlBody.Controls) if (b.GetType() == typeof(PictureBox) && b.Name.Contains("Pearl")) b.Visible = false;
			lblGames.Text = $"{Convert.ToInt32(lblGames.Text) + 1}";
		}
	}
}