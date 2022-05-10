using System;
using System.Windows.Forms;

namespace Mathre
{
	public partial class Frm24bInvaders : Form
	{
		bool SRight;
		bool SLeft;
		int ShooterSpeed = 1;
		readonly System.Timers.Timer tmrMain = new(10);

		public Frm24bInvaders()
		{
			KeyPreview = true;
			Shown += (p,e) => { tmrMain.Enabled = true; Focus(); };
			KeyDown += Key;
			KeyUp += UnKey;
			tmrMain.Elapsed += Timer;
			InitializeComponent();
		}
		
		private void Timer(object sender, EventArgs e)
		{
			MoveShooter();
		}
		internal void Tabbed(bool v)
		{
			if(v) Focus();
		}
		//keys void
		private void Key(object sender, KeyEventArgs e)
		{
			Console.WriteLine("Test");
			if (e.KeyCode == Keys.D)
			{
				SRight = true;
				SLeft = false;
			}
			if (e.KeyCode == Keys.A)
			{
				SLeft = true;
				SRight = false;
			}
		}
		//unkeys void
		private void UnKey(object sender, KeyEventArgs e)
		{
			Console.WriteLine("Test");
			if (e.KeyCode == Keys.D)
			{
				SRight = false;
			}
			if (e.KeyCode == Keys.A)
			{
				SLeft = false;
			}
		}
		//moveshooter void
		private void MoveShooter()
		{
			if (SRight == true)
			{
				picShooter.Left += ShooterSpeed;
			}
			if (SLeft == true)
			{
				picShooter.Left -= ShooterSpeed;
			}
		}
	}
}