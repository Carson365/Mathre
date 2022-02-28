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
			foreach (Control b in pnlBody.Controls) if (b.GetType() == typeof(PictureBox) && b.Name.Contains("Pearl")) b.Visible = false; // Hide all of the pearls
		}
		public void Default(object sender, EventArgs e)
		{
			string wonlost = "lost"; // Default to lost
			Random rnd = new();
			int rnum = rnd.Next(1, 4);
			PictureBox pb = sender as PictureBox;
			if (pb.Name[8] == $"{rnum}"[0]) // If the clicked picturebox is the randomly chosen one
			{
				foreach (Control b in pnlBody.Controls) if (b.GetType() == typeof(PictureBox) && b.Name.Contains($"Pearl{Convert.ToString(rnum)[0]}")) // Get the right pearl
					{ b.Visible = true; wonlost = "won"; lblWins.Text = $"{Convert.ToInt32(lblWins.Text) + 1}"; } // Set winstate, increment wins and show the pearl
			}
			MessageBox.Show($"You have {wonlost}.", "Results"); // Display the won message, then...
			foreach (Control b in pnlBody.Controls) if (b.GetType() == typeof(PictureBox) && b.Name.Contains("Pearl")) b.Visible = false; // Re-hide all of the pearls
			lblGames.Text = $"{Convert.ToInt32(lblGames.Text) + 1}"; // Increment total games
		}
	}
}