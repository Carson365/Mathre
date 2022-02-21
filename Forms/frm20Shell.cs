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
		}
		public void Default(object sender, EventArgs e)
		{
			if (sender.GetType() == typeof(PictureBox))
			{
				Random rnd = new();
				int rnum = rnd.Next(1, 4);
				PictureBox pb = sender as PictureBox;
				if (pb.Name[8] == $"{rnum}"[0])
				{
					Console.WriteLine("yay");
				
				
				}
			}
		}
	}
}