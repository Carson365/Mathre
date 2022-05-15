using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mathre
{
	public partial class Frm24bInvaders : Form
	{
		bool SRight;
		bool SLeft;
		int ShooterSpeed;
		int ShotSpeed;
		int InvaderSpeed;
		int InvaderDrop;
		readonly int NumOfInvaders = 5;
		int InvadersShot = 0;
		bool playing = false;
		bool playsounds = false;
		int Loading = 3;

		public readonly System.Timers.Timer tmrMain = new(10);
		readonly List<Invader> Invaders = new();
		public Frm24bInvaders()
		{
			InitializeComponent();
			tmrMain.Enabled = false;
			KeyPreview = true;
			Shown += (p, e) => { Focus(); InvaderSetup(); };
			KeyDown += Key;
			KeyDown += Pause;
			KeyUp += UnKey;
			tmrMain.Elapsed += Timer;
			VisibleChanged += (p, e) => { playsounds = Visible; if (Loading == 0) { LoadSettings(); tmrMain.Enabled = Visible; if (Visible) Focus(); else SRight = false; SLeft = false; } else Loading--; };
		}
		class Invader : PictureBox
		{
			public bool IRight { get; set; }
		}

		private void InvaderSetup()
		{
			for (int x = 0; x < NumOfInvaders; x++)
			{
				var invader = new Invader()
				{
					Size = picInvader.Size,
					Image = picInvader.Image,
				};
				Invaders.Add(invader);
				Controls.Add(invader);
			}
		}

		private void Timer(object sender, EventArgs e)
		{
			if (IsHandleCreated) Invoke(new MethodInvoker(delegate
			{
				MoveShooter(); FireShot(); MoveInvader(); CheckHit(); EndGame();
			}));
		}

		private void Key(object sender, KeyEventArgs e)
		{
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
			if (e.KeyCode == Keys.Space && picShot.Visible == false)
			{
				if (tmrMain.Enabled)
				{
					picShot.Top = picShooter.Top;
					picShot.Left = picShooter.Left + picShooter.Width / 2 - picShot.Width / 2;
					picShot.Visible = true;
				}
			}
		}
		private void Pause(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				tmrMain.Enabled ^= true;
			}
		}
		private void UnKey(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.D)
			{
				SRight = false;
			}
			if (e.KeyCode == Keys.A)
			{
				SLeft = false;
			}
		}
		private void MoveShooter()
		{
			if (SRight == true && picShooter.Left + 5 + picShooter.Width < ClientRectangle.Width)
			{
				picShooter.Left += ShooterSpeed;
			}
			if (SLeft == true && picShooter.Left - 5 > ClientRectangle.Left)
			{
				picShooter.Left -= ShooterSpeed;
			}
		}
		private void FireShot()
		{
			if (picShot.Visible)
			{
				if (!playing) { Play("Shot", "wav"); playing = true; }
				picShot.Top -= ShotSpeed;
				if (picShot.Top + picShot.Height < ClientRectangle.Top)
				{
					picShot.Visible = false;
				}
			}
			else playing = false;
		}
		private void MoveInvader()
		{
			for (int x = 0; x < NumOfInvaders; x++)
			{
				if (Invaders[x].IRight) Invaders[x].Left += InvaderSpeed;
				else Invaders[x].Left -= InvaderSpeed;
				if (Invaders[x].Left + Invaders[x].Width > ClientRectangle.Width && Invaders[x].IRight) { Invaders[x].IRight = false; Invaders[x].Top += InvaderDrop; }
				if (Invaders[x].Left < ClientRectangle.Left && !Invaders[x].IRight) { Invaders[x].IRight = true; Invaders[x].Top += InvaderDrop; }
			}
		}
		private void EndGame()
		{
			if (tmrMain.Enabled)
			{
				if (InvadersShot == NumOfInvaders)
				{
					tmrMain.Enabled = false;
					Play("Win", "wav");
					MessageBox.Show("Earth is Saved");
					PlayAgain();
				}
				for (int x = 0; x < NumOfInvaders; x++)
				{
					if (Invaders[x].Top + Invaders[x].Height >= picShooter.Top && Invaders[x].Visible)
					{
						tmrMain.Enabled = false;
						Play("Dead", "wav");
						x = NumOfInvaders;
						MessageBox.Show("Game Over. Earth Invaded.");
						PlayAgain();
					}
				}
			}
		}
		private void CheckHit()
		{
			for (int x = 0; x < NumOfInvaders; x++)
			{
				if ((picShot.Top + picShot.Height >= Invaders[x].Top) && (picShot.Top <= Invaders[x].Top + Invaders[x].Height) && (picShot.Left + picShot.Width >= Invaders[x].Left) && (picShot.Left <= Invaders[x].Left + Invaders[x].Width) && Invaders[x].Visible && picShot.Visible)
				{
					InvadersShot++;
					Invaders[x].Visible = false;
					picShot.Visible = false;
					Play("Hit", "wav");
				}
			}
		}
		private void LoadSettings()
		{
			for (int x = 0; x < NumOfInvaders; x++)
			{
				Invaders[x].IRight = true;
				Invaders[x].Location = new Point(picInvader.Left + picInvader.Width + 10 + (x * 60) - (NumOfInvaders * 60 + 180), picInvader.Top);
				Invaders[x].Top = 0;
				Invaders[x].Visible = true;
			}
			picShooter.Top = ClientRectangle.Bottom - picShooter.Height;
			ShooterSpeed = 5;
			InvaderSpeed = 6;
			ShotSpeed = 7;
			InvaderDrop = 50;
			Play("Intro", "wav");
			InvadersShot = 0;
			SRight = false;
			SLeft = false;
			tmrMain.Enabled = true;
		}
		//
		[System.Runtime.InteropServices.DllImport("winmm.dll")]
		public static extern uint mciSendString(string command, StringBuilder buffer, int buffersize, int hWndCallback);
		public void Play(string file, string type)
		{
			string Sound = string.Format($"{{0}}Resources\\{file}.{type}", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));
			mciSendString(@$"close {file}", null, 0, 0);
			if (playsounds)
			{
				// Gets the location of the file by string, opens it using the native windows API "mciSendString" after ensuring another isn't open, then closes it when done.
				mciSendString(@$"open ""{Sound}"" alias {file}", null, 0, 0);
				if (file == "Background") mciSendString($"play {file} repeat", null, 0, 0);
				else mciSendString($"play {file}", null, 0, 0);
			}
			else
			{ }
		}
		public void PlayAgain()
		{
			if (MessageBox.Show("Play Again?", "Game Over", MessageBoxButtons.YesNo) == DialogResult.Yes) LoadSettings();
		}
	}
}